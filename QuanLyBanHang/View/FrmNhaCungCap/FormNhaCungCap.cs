using _1_DAL_QUANLY.Models;
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

namespace QuanLyBanHang.View.FrmNhaCungCap
{
    public partial class FormNhaCungCap : Form
    {
        public IQLnhaCungCapServices qLnhaCungCapServices;
        public nhaCungCap nhaCungcap;
        public FormNhaCungCap()
        {
            InitializeComponent();
            qLnhaCungCapServices = new QLnhaCungCapServices();
            LoadData();
        }

        public void LoadData()
        {
            dtgv_nhaCC.ColumnCount = 3;
            dtgv_nhaCC.Columns[0].Name = "ID nhà cung cấp";
            dtgv_nhaCC.Columns[1].Name = "Tên nhà cung cấp";
            dtgv_nhaCC.Columns[2].Name = "Trạng thái";
            dtgv_nhaCC.Rows.Clear();

            var listNcc = qLnhaCungCapServices.GetNhaCungCapFromDB();
            foreach (var x in listNcc)
            {
                dtgv_nhaCC.Rows.Add(x.IDNhaCungCap, x.tenNhaCungCap, x.trangThai == true? "Còn hàng" : "Hết hàng");
            }
        }

        public void resetForm()
        {
            LoadData();
            txt_TenNhaCC.Text = "";
            rbConhang.Checked = false;
            rbHethang.Checked = false;
        }

        private void dtgv_nhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLnhaCungCapServices.GetNhaCungCapFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_nhaCC.Rows[e.RowIndex];
            nhaCungcap = qLnhaCungCapServices.GetNhaCungCapFromDB().FirstOrDefault(x => x.IDNhaCungCap == Convert.ToInt32(row.Cells[0].Value));
            txt_TenNhaCC.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Còn Hàng")
            {
                rbConhang.Checked = true;
                rbHethang.Checked = false;
            }
            else
            {
                rbHethang.Checked = true;
                rbConhang.Checked = false;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenNhaCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nhà cung cấp");

            }
            else
            {
                var ncc = new nhaCungCap()
                {
                    tenNhaCungCap = txt_TenNhaCC.Text,
                    trangThai = rbConhang.Checked
                };
                qLnhaCungCapServices.addNhaCungCap(ncc);
                MessageBox.Show("Thêm nhà cung cấp thành công");
                resetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(txt_TenNhaCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp");
            }else if(nhaCungcap == null){
                MessageBox.Show("Vui lòng chọn tneen nhà cung cấp");
            }
            else
            {
                nhaCungcap.tenNhaCungCap = txt_TenNhaCC.Text;
                nhaCungcap.trangThai = rbConhang.Checked;
                qLnhaCungCapServices.UpdatesNhaCungCap(nhaCungcap);
                MessageBox.Show("Sửa thành công");
                resetForm();
            }
        }

    }
}
