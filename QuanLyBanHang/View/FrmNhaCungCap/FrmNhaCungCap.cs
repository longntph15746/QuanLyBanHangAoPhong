using _1_DAL_QUANLY.Models;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.Services;
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
    public partial class FrmNhaCungCap : Form
    {
        public IQLnhaCungCapServices qLnhaCungCapServices;
        public nhaCungCap nhaCC;
        public FrmNhaCungCap()
        {
            InitializeComponent();
            qLnhaCungCapServices = new QLnhaCungCapServices();
            LoadData();
        }

        public void LoadData()
        {
            dgvDulieuNCC.ColumnCount = 3;
            dgvDulieuNCC.Columns[0].Name = "ID Nhà cung cấp";
            dgvDulieuNCC.Columns[1].Name = "Tên nhà cung cấp";
            dgvDulieuNCC.Columns[2].Name = "Trạng thái";
            dgvDulieuNCC.Rows.Clear();

            var listNCC = qLnhaCungCapServices.GetNhaCungCapFromDB();
            foreach (var item in listNCC)
            {
                dgvDulieuNCC.Rows.Add(item.IDNhaCungCap, item.tenNhaCungCap,
                    item.trangThai == true ? "Đang hoạt động" : "Ngừng hoạt động");
            }
        }


        public void resetForm()
        {
            LoadData();
            txtNhacungcap.Text = "";
            rbHoatdong.Checked = false;
            rbKhongHD.Checked = false;
        }


        private void dgvDulieuNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLnhaCungCapServices.GetNhaCungCapFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDulieuNCC.Rows[e.RowIndex];
            nhaCC = qLnhaCungCapServices.GetNhaCungCapFromDB().
                FirstOrDefault(x => x.IDNhaCungCap == Convert.ToInt32(row.Cells[0].Value));
            txtNhacungcap.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Đang hoạt động")
            {
                rbHoatdong.Checked = true;
                rbKhongHD.Checked = false;
            }
            else
            {
                rbKhongHD.Checked = true;
                rbHoatdong.Checked = false;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (txtNhacungcap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!");
            }
            else
            {
                var ncc = new nhaCungCap()
                {
                    tenNhaCungCap = txtNhacungcap.Text,
                    trangThai = rbHoatdong.Checked,
                };
                qLnhaCungCapServices.addNhaCungCap(ncc);
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                resetForm();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (txtNhacungcap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!");
            }
            else if (nhaCC == null)
            {
                MessageBox.Show("Vui lòng chọn tên nhà cung cấp cần sửa!");
            }
            else
            {
                nhaCC.tenNhaCungCap = txtNhacungcap.Text;
                nhaCC.trangThai = rbHoatdong.Checked;
                qLnhaCungCapServices.UpdatesNhaCungCap(nhaCC);
                MessageBox.Show("Sửa thành công!");
                resetForm();
            }
        }

        private void dgvDulieuNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
