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

namespace QuanLyBanHang.View.FrmSize
{
    public partial class FormSize : Form
    {
        private IQLsizeServices _QLsizeServices;
        public size _size;
        public FormSize()
        {
            _QLsizeServices = new QLsizeServices();
            _size = new size();
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            dtgv_Size.Rows.Clear();
            foreach (var item in _QLsizeServices.GetSizeFromDB())
            {
                dtgv_Size.Rows.Add(item.IDSize, item.tenSize,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            size accSize = _QLsizeServices.GetSizeFromDB().FirstOrDefault(p => p.tenSize == txt_TenSize.Text);
            if (txt_TenSize.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (accSize != null)
            {
                MessageBox.Show("Mã Size đã tồn tại");
                txt_TenSize.Text = "";
            }
            else
            {
                size addsize = new size()
                {
                    tenSize = txt_TenSize.Text,
                    trangThai = rdb_conHang.Checked,
                };
                _QLsizeServices.addsize(addsize);
                MessageBox.Show("Thêm Size thành công");
                loadData();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_size == null)
            {
                MessageBox.Show("Vui lòng chọn Size");
            }
            else
            {
                if (_size.tenSize == txt_TenSize.Text || (_size.tenSize != txt_TenSize.Text && _QLsizeServices.GetSizeFromDB().FirstOrDefault(x => x.tenSize == txt_TenSize.Text) == null))
                {
                    _size.tenSize = txt_TenSize.Text;
                    _size.trangThai = rdb_conHang.Checked;
                    _QLsizeServices.UpdateSize(_size);
                    MessageBox.Show("Cập nhật thành công");
                    loadData();
                    txt_TenSize.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên size đã tồn tại");
                }
            }
        }

        private void dtgv_Size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_Size.Rows[e.RowIndex];
                _size = _QLsizeServices.GetSizeFromDB().FirstOrDefault(x => x.IDSize == Convert.ToInt32(row.Cells[0].Value));
                txt_TenSize.Text = row.Cells[1].Value.ToString();
                rdb_conHang.Checked = row.Cells[2].Value.ToString() == "Còn hàng" ? true : false;
                rdb_hetHang.Checked = row.Cells[2].Value.ToString() == "Hết hàng" ? true : false;
            }
        }
    }
}
