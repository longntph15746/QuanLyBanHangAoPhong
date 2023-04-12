using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.View.FrmMauSac
{
    public partial class FormMauSac : Form
    {
        public IQLmauSacServices _qLmauSacServices;
        public mauSac _mausac;
        public FormMauSac()
        {
            _qLmauSacServices = new QLmauSacServices();
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dtgv_MauSac.ColumnCount = 3;
            dtgv_MauSac.Columns[0].Name = "ID";
            dtgv_MauSac.Columns[1].Name = "Màu sắc";
            dtgv_MauSac.Columns[2].Name = "Trạng thái";
            dtgv_MauSac.Rows.Clear();

            var listMauSac = _qLmauSacServices.GetMauSacFromDB();
            foreach (var x in listMauSac)
            {
                dtgv_MauSac.Rows.Add(x.IDMauSac, x.tenMau,
                x.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }
        private void resetForm()
        {
            LoadData();
            txt_TenMauSac.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenMauSac.Text == "")
            {
                MessageBox.Show("Vui lòng nhập màu sắc!");
            }
            else
            {
                var mausac = new mauSac()
                {
                    tenMau = txt_TenMauSac.Text,
                    trangThai = rdb_conHang.Checked,
                };
                _qLmauSacServices.addMauSac(mausac);
                MessageBox.Show("Thêm màu sắc thành công!");
                resetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenMauSac.Text == "")
            {
                MessageBox.Show("Vui lòng nhập màu sắc!");
            }
            else if (_mausac == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc cần sửa!");
            }
            else
            {
                _mausac.tenMau = txt_TenMauSac.Text;
                _mausac.trangThai = rdb_conHang.Checked;
                _qLmauSacServices.UpdateMauSac(_mausac);
                MessageBox.Show("Sửa thành công!");
                resetForm();
            }
        }

        private void dtgv_MauSac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _qLmauSacServices.GetMauSacFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_MauSac.Rows[e.RowIndex];
            _mausac = _qLmauSacServices.GetMauSacFromDB().
                FirstOrDefault(x => x.IDMauSac == Convert.ToInt32(row.Cells[0].Value));
            txt_TenMauSac.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Còn hàng")
            {
                rdb_conHang.Checked = true;
                rdb_hetHang.Checked = false;
            }
            else
            {
                rdb_hetHang.Checked = true;
                rdb_conHang.Checked = false;
            }
        }
    }
}
