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

namespace Shirt_Shop_Project.View
{
    public partial class FrmMauSac : Form
    {
        public IQLmauSacServices qLmauSacServices;
        public mauSac ms;

        public FrmMauSac()
        {
            qLmauSacServices = new QLmauSacServices();
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvDulieu.ColumnCount = 3;
            dgvDulieu.Columns[0].Name = "ID";
            dgvDulieu.Columns[1].Name = "Màu sắc";
            dgvDulieu.Columns[2].Name = "Trạng thái";
            dgvDulieu.Rows.Clear();

            var listMauSac = qLmauSacServices.GetMauSacFromDB();
            foreach (var item in listMauSac)
            {
                dgvDulieu.Rows.Add(item.IDMauSac, item.tenMau,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập màu sắc!");
            }
            else
            {
                var mausac = new mauSac()
                {
                    tenMau = textBox1.Text,
                    trangThai = rbHoatdong.Checked,
                };
                qLmauSacServices.addMauSac(mausac);
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                resetForm();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập màu sắc!");
            }
            else if (ms == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc cần sửa!");
            }
            else
            {
                ms.tenMau = textBox1.Text;
                ms.trangThai = rbHoatdong.Checked;
                qLmauSacServices.UpdateMauSac(ms);
                MessageBox.Show("Sửa thành công!");
                resetForm();
            }
        }

        private void resetForm()
        {
            LoadData();
            textBox1.Text = "";
            rbHoatdong.Checked = false;
            rbKhongHD.Checked = false;
        }

        private void dgvDulieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLmauSacServices.GetMauSacFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDulieu.Rows[e.RowIndex];
            ms = qLmauSacServices.GetMauSacFromDB().
                FirstOrDefault(x => x.IDMauSac == Convert.ToInt32(row.Cells[0].Value));
            textBox1.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Còn hàng")
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
    }
}
