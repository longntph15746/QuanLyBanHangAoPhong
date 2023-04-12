using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.View.FrmMauSac
{
    public partial class FormMauSac : Form
    {
        public QLmauSacServices qLmauSacServices;
        public mauSac ms;

        public FormMauSac()
        {
            qLmauSacServices = new QLmauSacServices();
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            dtgv_MauSac.ColumnCount = 3;
            dtgv_MauSac.Columns[0].Name = "ID";
            dtgv_MauSac.Columns[1].Name = "Màu sắc";
            dtgv_MauSac.Columns[2].Name = "Trạng thái";
            dtgv_MauSac.Rows.Clear();

            var listMauSac = qLmauSacServices.GetMauSacFromDB();
            foreach (var item in listMauSac)
            {
                dtgv_MauSac.Rows.Add(item.IDMauSac, item.tenMau,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }


        private void FormMauSac_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenMauSac.Text == "")
            {
                MessageBox.Show("Vui lòng nhập màu sắc");
            }
            else
            {
                var mausac = new mauSac()
                {
                    tenMau = txt_TenMauSac.Text,
                    trangThai = rdb_conHang.Checked
                };
                qLmauSacServices.addMauSac(mausac);
                MessageBox.Show("Thêm màu sắc thành công");
                resetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenMauSac.Text == "")
            {
                MessageBox.Show("Vui lòng nhập màu sắc");
            }
            else if (ms == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc cần sửa");
            }
            else
            {
                ms.tenMau = txt_TenMauSac.Text;
                ms.trangThai = rdb_conHang.Checked;
                qLmauSacServices.UpdateMauSac(ms);
                MessageBox.Show("Sửa thành công");
                resetForm();
            }
        }

        private void resetForm()
        {
            loadData();
            txt_TenMauSac.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;
        }

        private void dtgv_MauSac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgv_MauSac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLmauSacServices.GetMauSacFromDB().Count) return;
            DataGridViewRow rows = new DataGridViewRow();
            rows = dtgv_MauSac.Rows[e.RowIndex];
            ms = qLmauSacServices.GetMauSacFromDB().FirstOrDefault(x => x.IDMauSac == Convert.ToInt32(rows.Cells[0].Value));
            txt_TenMauSac.Text = rows.Cells[1].Value.ToString();

            if (rows.Cells[2].Value.ToString() == "Còn hàng")
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
