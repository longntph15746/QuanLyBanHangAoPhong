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

namespace QuanLyBanHang.View.FrmHangSanXuat
{
    public partial class FormHangSX : Form
    {
        private IQLhangSXServices _qLhangSXServices;
        public hangSX _hangSX;
        public FormHangSX()
        {
            _qLhangSXServices = new QLhangSXServices();
            _hangSX = new hangSX();
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            dtgv_HangSX.ColumnCount = 3;
            dtgv_HangSX.Columns[0].Name = "ID hãng sản xuất";
            dtgv_HangSX.Columns[1].Name = "Tên hãng sản xuất";
            dtgv_HangSX.Columns[2].Name = "Trạng thái";
            dtgv_HangSX.Rows.Clear();

            var listNcc = _qLhangSXServices.GetHangSXFromDB();
            foreach (var x in listNcc)
            {
                dtgv_HangSX.Rows.Add(x.IDHangSX, x.tenHangSX, x.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }
        public void resetForm()
        {
            loadData();
            txt_TenHangSX.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenHangSX.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên Hãng sản xuất");
            }
            else
            {
                var hsx = new hangSX()
                {
                    tenHangSX = txt_TenHangSX.Text,
                    trangThai = rdb_conHang.Checked,
                };
                _qLhangSXServices.addHangSX(hsx);
                MessageBox.Show("Thêm hãng sản xuất thành công!");
                resetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenHangSX.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên Hãng sản xuất");
            }
            else if (_hangSX == null)
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất cần sửa");
            }
            else
            {
                _hangSX.tenHangSX = txt_TenHangSX.Text;
                _hangSX.trangThai = rdb_conHang.Checked;
                _qLhangSXServices.UpdateHangSX(_hangSX);
                MessageBox.Show("Sửa hãng sản xuất thành công!");
                resetForm();
            }
        }

        private void dtgv_HangSX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_HangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _qLhangSXServices.GetHangSXFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_HangSX.Rows[e.RowIndex];
            _hangSX = _qLhangSXServices.GetHangSXFromDB().FirstOrDefault(x => x.IDHangSX == Convert.ToInt32(row.Cells[0].Value));
            txt_TenHangSX.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Còn Hàng")
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
