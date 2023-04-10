using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.ViewModel;
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
    public partial class FrmNhanVien : Form
    {
        public IQLnhanVienServices qLnhanVienServices;
        public IQLchucVuServices qLchucVuServices;
        public ViewHienThi1 viewNV;

        public FrmNhanVien()
        {
            InitializeComponent();
            qLnhanVienServices = new QLnhanVienServices();
            qLchucVuServices = new QLchucVuServices();
            viewNV = new ViewHienThi1();
            LoadComboBox();
            LoadData();
        }

        private void LoadData()
        {
            gtgv_NhanVien.ColumnCount = 8;
            gtgv_NhanVien.Columns[0].Name = "Id";
            //gtgv_NhanVien.Columns[0].Visible = false;
            gtgv_NhanVien.Columns[1].Name = "Tên NV";
            gtgv_NhanVien.Columns[2].Name = "Địa chỉ";
            gtgv_NhanVien.Columns[3].Name = "SĐT";
            gtgv_NhanVien.Columns[4].Name = "Email";
            gtgv_NhanVien.Columns[5].Name = "Mật khẩu";
            gtgv_NhanVien.Columns[6].Name = "Chức vụ";
            gtgv_NhanVien.Columns[7].Name = "Trạng thái";

            gtgv_NhanVien.Rows.Clear();
            var listViewNV = qLnhanVienServices.GetNhanVienFromDB();
            foreach (var item in listViewNV)
            {
                gtgv_NhanVien.Rows.Add(
                    item.nhanViens.IDNhanVien,
                    item.nhanViens.tenNV,
                    item.nhanViens.diaChi,
                    item.nhanViens.SDT,
                    item.nhanViens.email,
                    item.nhanViens.matKhau,
                    item.chucVus.tenCV,
                    item.nhanViens.tinhTrang == true ? "Hoạt động" : "Không HĐ"
                    );
            }
        }

        private void LoadComboBox()
        {
            foreach (var item in qLnhanVienServices.GetNhanVienFromDB())
            {
                cbbChucvu.Items.Add(item.chucVus.tenCV);
            }
            cbbChucvu.SelectedIndex = 0;
        }

        public void ResetForm()
        {
            LoadData();
            txtTenNV.Text = "";
            txtDiachi.Text = "";
            txtSodienthoai.Text = "";
            txtEmail.Text = "";
            txtMatkhau.Text = "";
            cbbChucvu.SelectedIndex = 0;
            rbHoatDong.Checked = false;
            radioButton2.Checked = false;

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" || txtDiachi.Text == "" || txtSodienthoai.Text == "" || txtEmail.Text == "" || txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!");
            }
            else
            {
                var nv = new ViewHienThi1()
                {
                    nhanViens = new nhanVien()
                    {
                        tenNV = txtTenNV.Text,
                        diaChi = txtDiachi.Text,
                        SDT = txtSodienthoai.Text,
                        email = txtEmail.Text,
                        matKhau = txtMatkhau.Text,
                        IDChucVu = cbbChucvu.SelectedIndex + 1,
                        tinhTrang = rbHoatDong.Checked,
                    }
                };
                qLnhanVienServices.addNhanVien(nv);
                MessageBox.Show("Thêm nhân viên thành công!");
                ResetForm();
            }
        }

        private void btnSuatt_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" || txtDiachi.Text == "" || txtSodienthoai.Text == "" ||
                txtEmail.Text == "" || txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!");
            }
            else if (viewNV == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa thông tin!");
            }
            else
            {
                viewNV.nhanViens.tenNV = txtTenNV.Text;
                viewNV.nhanViens.diaChi = txtDiachi.Text;
                viewNV.nhanViens.SDT = txtSodienthoai.Text;
                viewNV.nhanViens.email = txtEmail.Text;
                viewNV.nhanViens.matKhau = txtMatkhau.Text;
                viewNV.nhanViens.IDChucVu = cbbChucvu.SelectedIndex + 1;
                viewNV.nhanViens.tinhTrang = rbHoatDong.Checked;
                qLnhanVienServices.UpdateNhanVien(viewNV);
                MessageBox.Show("Sửa thành công!");
                ResetForm();

            }
        }

        private void gtgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLnhanVienServices.GetNhanVienFromDB().Count) return;
            DataGridViewRow r = new DataGridViewRow();
            r = gtgv_NhanVien.Rows[e.RowIndex];
            viewNV = qLnhanVienServices.GetNhanVienFromDB().
                FirstOrDefault(x => x.nhanViens.IDNhanVien == Convert.ToInt32(r.Cells[0].Value));
            txtTenNV.Text = r.Cells[1].Value.ToString();
            txtDiachi.Text = r.Cells[2].Value.ToString();
            txtSodienthoai.Text = r.Cells[3].Value.ToString();
            txtEmail.Text = r.Cells[4].Value.ToString();
            txtMatkhau.Text = r.Cells[5].Value.ToString();
            cbbChucvu.SelectedIndex = cbbChucvu.FindStringExact(r.Cells[6].Value.ToString());
            if (r.Cells[7].Value.ToString() == "Hoạt động")
            {
                rbHoatDong.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton2.Checked = true;
                rbHoatDong.Checked = false;
            }
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
    

