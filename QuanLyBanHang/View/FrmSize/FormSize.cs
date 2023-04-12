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
        public IQLsizeServices _qLsizeServices;
        public size _size;
        public FormSize()
        {
            _qLsizeServices = new QLsizeServices();
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dtgv_Size.ColumnCount = 3;
            dtgv_Size.Columns[0].Name = "ID";
            dtgv_Size.Columns[1].Name = "Size";
            dtgv_Size.Columns[2].Name = "Trạng thái";
            dtgv_Size.Rows.Clear();

            var listMauSac = _qLsizeServices.GetSizeFromDB();
            foreach (var item in listMauSac)
            {
                dtgv_Size.Rows.Add(item.IDSize, item.tenSize,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }
        private void ResetForm()
        {
            LoadData();
            txt_TenSize.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;
        }

        private void dtgv_Size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _qLsizeServices.GetSizeFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_Size.Rows[e.RowIndex];
            _size = _qLsizeServices.GetSizeFromDB().FirstOrDefault(x => x.IDSize == Convert.ToInt32(row.Cells[0].Value));
            txt_TenSize.Text = row.Cells[1].Value.ToString();
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenSize.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Size!");
            }
            else
            {
                var sz = new size()
                {
                    tenSize = txt_TenSize.Text,
                    trangThai = rdb_conHang.Checked,
                };
                _qLsizeServices.addsize(sz);
                MessageBox.Show("Thêm nhà Size thành công!");
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenSize.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Size!");
            }
            else if (_size == null)
            {
                MessageBox.Show("Vui lòng chọn Size cần sửa");
            }
            else
            {
                _size.tenSize = txt_TenSize.Text;
                _size.trangThai = rdb_conHang.Checked;
                _qLsizeServices.UpdateSize(_size);
                MessageBox.Show("Sửa thành công!");
                ResetForm();
            }
        }
   
    }
}
