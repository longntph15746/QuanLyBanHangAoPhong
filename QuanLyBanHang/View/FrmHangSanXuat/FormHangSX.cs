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
        private hangSX _hangSX;
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
            dtgv_HangSX.Columns[0].Name = "ID";
            dtgv_HangSX.Columns[1].Name = "Hãng SX";
            dtgv_HangSX.Columns[2].Name = "Trạng thái";

            dtgv_HangSX.Rows.Clear();
            foreach (var item in _qLhangSXServices.GetHangSXFromDB())
            {
                dtgv_HangSX.Rows.Add(item.IDHangSX, item.tenHangSX,
                    item.trangThai == true ? "Hoạt động" : "Không hoạt động");

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            hangSX hsx = _qLhangSXServices.GetHangSXFromDB().FirstOrDefault(p => p.tenHangSX == txt_TenHangSX.Text);
            if (txt_TenHangSX.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (hsx != null)
            {
                MessageBox.Show("Mã đã tồn tại");
                txt_TenHangSX.Text = "";
            }
            else
            {
                hangSX addhangSX = new hangSX()
                {
                    tenHangSX = txt_TenHangSX.Text,
                    trangThai = rdb_conHang.Checked,
                };
                _qLhangSXServices.addHangSX(addhangSX);
                MessageBox.Show("Thêm thành công");
                loadData();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_hangSX == null)
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất");
            }
            else
            {
                if (_hangSX.tenHangSX == txt_TenHangSX.Text || (_hangSX.tenHangSX != txt_TenHangSX.Text && _qLhangSXServices.GetHangSXFromDB().FirstOrDefault(x => x.tenHangSX == txt_TenHangSX.Text) == null))
                {
                    _hangSX.tenHangSX = txt_TenHangSX.Text;
                    _hangSX.trangThai = rdb_conHang.Checked;
                    _qLhangSXServices.UpdateHangSX(_hangSX);
                    MessageBox.Show("Cập nhật thành công");
                    loadData();
                    txt_TenHangSX.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên hãng sản xuất đã tồn tại");
                }
            }
        }

        private void dtgv_HangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_HangSX.Rows[e.RowIndex];
                _hangSX = _qLhangSXServices.GetHangSXFromDB().FirstOrDefault(x => x.IDHangSX == Convert.ToInt32(row.Cells[0].Value));
                txt_TenHangSX.Text = row.Cells[1].Value.ToString();
                rdb_conHang.Checked = row.Cells[2].Value.ToString() == "Hoạt động" ? true : false;
                rdb_hetHang.Checked = row.Cells[2].Value.ToString() == "Không hoạt động" ? true : false;
            }
        }
    }
}
