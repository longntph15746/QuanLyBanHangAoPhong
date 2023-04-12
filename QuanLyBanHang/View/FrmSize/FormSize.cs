using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
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

namespace QuanLyBanHang.View.FrmSize
{
    public partial class FormSize : Form
    {
        public QLsizeServices qLsizeServices;
        public size sz;
        public FormSize()
        {
            qLsizeServices = new QLsizeServices();
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            dtgv_Size.ColumnCount = 3;
            dtgv_Size.Columns[0].Name = "ID size";
            dtgv_Size.Columns[1].Name = "Tên size";
            dtgv_Size.Columns[2].Name = "Trạng thái";
            dtgv_Size.Rows.Clear();

            var listSize = qLsizeServices.GetSizeFromDB();
            foreach (var item in listSize)
            {
                dtgv_Size.Rows.Add(item.IDSize, item.tenSize,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }

        private void dtgv_Size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLsizeServices.GetSizeFromDB().Count) return;
            DataGridViewRow rows = new DataGridViewRow();
            rows = dtgv_Size.Rows[e.RowIndex];
            sz = qLsizeServices.GetSizeFromDB().FirstOrDefault(x => x.IDSize == Convert.ToInt32(rows.Cells[0].Value));
            txt_TenSize.Text = rows.Cells[1].Value.ToString();

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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenSize.Text == "")
            {
                MessageBox.Show("Vui lòng nhập size");
            }
            else
            {
                var size = new size()
                {
                    tenSize = txt_TenSize.Text,
                    trangThai = rdb_conHang.Checked
                };
                qLsizeServices.addsize(size);
                MessageBox.Show("Thêm size thành công");
                resetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenSize.Text == "")
            {
                MessageBox.Show("Vui lòng nhập size");
            }
            else if (sz == null)
            {
                MessageBox.Show("Vui lòng chọn size cần sửa");
            }
            else
            {
                sz.tenSize = txt_TenSize.Text;
                sz.trangThai = rdb_conHang.Checked;
                qLsizeServices.UpdateSize(sz);
                MessageBox.Show("Sửa thành công");
                resetForm();
            }
        }

        private void resetForm()
        {
            loadData();
            txt_TenSize.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;
        }
    }
}
