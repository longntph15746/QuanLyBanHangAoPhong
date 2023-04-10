using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.Services;
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
    public partial class FrmSize : Form
    {
        private IQLsizeServices _QLsizeServices;
        public size _size;
        public FrmSize()
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            size accSize = _QLsizeServices.GetSizeFromDB().FirstOrDefault(p => p.tenSize == tbt_Size.Text);
            if (tbt_Size.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if(accSize != null)
            {
                MessageBox.Show("Mã Size đã tồn tại");
                tbt_Size.Text = "";
            }
            else
            {
                size addsize = new size()
                {
                    tenSize = tbt_Size.Text,
                    trangThai = rbHoatdong.Checked,
                };
                _QLsizeServices.addsize(addsize);
                MessageBox.Show("Thêm Size thành công");
                loadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_size == null)
            {
                MessageBox.Show("Vui lòng chọn Size");
            }
            else
            {
                if (_size.tenSize == tbt_Size.Text || (_size.tenSize != tbt_Size.Text && _QLsizeServices.GetSizeFromDB().FirstOrDefault(x => x.tenSize == tbt_Size.Text) == null))
                {
                    _size.tenSize = tbt_Size.Text;
                    _size.trangThai = rbHoatdong.Checked;
                    _QLsizeServices.UpdateSize(_size);
                    MessageBox.Show("Cập nhật thành công");
                    loadData();
                    tbt_Size.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên size đã tồn tại");
                }
            }

        }

        private void dtgv_Size_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_Size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_Size.Rows[e.RowIndex];
                _size = _QLsizeServices.GetSizeFromDB().FirstOrDefault(x => x.IDSize == Convert.ToInt32(row.Cells[0].Value));
                tbt_Size.Text = row.Cells[1].Value.ToString();
                rbHoatdong.Checked = row.Cells[2].Value.ToString() == "Còn hàng" ? true : false;
                rbKhongHD.Checked = row.Cells[2].Value.ToString() == "Hết hàng" ? true : false;
            }
        }
    }
}
