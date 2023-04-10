using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using FPoly_TShirt_Manage.View.FrmTrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shirt_Shop_Project.View
{
    public partial class FrmHangSX : Form
    {
        private IQLhangSXServices _qLhangSXServices;
        public hangSX _hangSX;
        public FrmHangSX()
        {
            _qLhangSXServices = new QLhangSXServices();
            _hangSX = new hangSX();
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            dtgvHangSX.Rows.Clear();
            foreach (var item in _qLhangSXServices.GetHangSXFromDB())
            {
                dtgvHangSX.Rows.Add(item.IDHangSX, item.tenHangSX,
                    item.trangThai == true ? "Hoạt động" : "Không hoạt động");

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            hangSX hsx = _qLhangSXServices.GetHangSXFromDB().FirstOrDefault(p => p.tenHangSX == txt_hangSX.Text);
            if (txt_hangSX.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (hsx != null)
            {
                MessageBox.Show("Mã đã tồn tại");
                txt_hangSX.Text = "";
            }
            else
            {
                hangSX addhangSX = new hangSX()
                {
                    tenHangSX = txt_hangSX.Text,
                    trangThai = rdb_HD.Checked,
                };
                _qLhangSXServices.addHangSX(addhangSX);
                MessageBox.Show("Thêm thành công");
                loadData();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (_hangSX == null)
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất");
            }
            else
            {
                if (_hangSX.tenHangSX == txt_hangSX.Text || (_hangSX.tenHangSX != txt_hangSX.Text && _qLhangSXServices.GetHangSXFromDB().FirstOrDefault(x => x.tenHangSX == txt_hangSX.Text) == null))
                {
                    _hangSX.tenHangSX = txt_hangSX.Text;
                    _hangSX.trangThai = rdb_HD.Checked;
                    _qLhangSXServices.UpdateHangSX(_hangSX);
                    MessageBox.Show("Cập nhật thành công");
                    loadData();
                    txt_hangSX.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên hãng sản xuất đã tồn tại");
                }
            }
        }

        private void dtgvHangSX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgvHangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvHangSX.Rows[e.RowIndex];
                _hangSX = _qLhangSXServices.GetHangSXFromDB().FirstOrDefault(x => x.IDHangSX == Convert.ToInt32(row.Cells[0].Value));
                txt_hangSX.Text = row.Cells[1].Value.ToString();
                rdb_HD.Checked = row.Cells[2].Value.ToString() == "Hoạt động" ? true : false;
                rdb_KHD.Checked = row.Cells[2].Value.ToString() == "Không hoạt động" ? true : false;
            }
        }
    }
}
