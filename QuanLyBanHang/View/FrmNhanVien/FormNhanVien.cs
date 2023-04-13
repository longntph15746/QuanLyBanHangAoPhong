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

namespace QuanLyBanHang.View.FrmNhanVien
{
    public partial class FormNhanVien : Form
    {
        public IQLnhanVienServices qLnhanVienServices;
        public IQLchucVuServices qLchucVuServices;
        public ViewHienThi1 viewNV;
        public nhanVien _NhanVien;
        private int _maclick;
        private List<ViewHienThi1> lstNv;
        public FormNhanVien()
        {
            InitializeComponent();
            qLnhanVienServices = new QLnhanVienServices();
            qLchucVuServices = new QLchucVuServices();
            viewNV = new ViewHienThi1();
            rdb_HD.Checked = false;
            lstNv = new List<ViewHienThi1>();
            LoadComboBox();
            LoadData();
        }

        private void LoadComboBox()
        {
            foreach (var item in qLnhanVienServices.GetNhanVienFromDB())
            {
                cbb_ChucVu.Items.Add(item.chucVus.tenCV);
            }
            cbb_ChucVu.SelectedIndex = 0;
        }

        private void LoadData()
        {
            dtgv_NhanVien.ColumnCount = 8;
            dtgv_NhanVien.Columns[0].Name = "Id";
            //dtgv_NhanVien.Columns[0].Visible = false;
            dtgv_NhanVien.Columns[1].Name = "Tên NV";
            dtgv_NhanVien.Columns[2].Name = "Địa chỉ";
            dtgv_NhanVien.Columns[3].Name = "SĐT";
            dtgv_NhanVien.Columns[4].Name = "Email";
            dtgv_NhanVien.Columns[5].Name = "Mật khẩu";
            dtgv_NhanVien.Columns[6].Name = "Chức vụ";
            dtgv_NhanVien.Columns[7].Name = "Trạng thái";

            dtgv_NhanVien.Rows.Clear();
            var listViewNV = qLnhanVienServices.GetNhanVienFromDB();
            foreach (var item in listViewNV)
            {
                dtgv_NhanVien.Rows.Add(
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
        public void ResetForm()
        {
            LoadData();
            txt_tenNV.Text = "";
            txt_diaChi.Text = "";
            txt_SDT.Text = "";
            txt_Email.Text = "";
            txt_MatKhau.Text = "";
            cbb_ChucVu.SelectedIndex = 0;
            rdb_HD.Checked = false;
            radioButton2.Checked = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_tenNV.Text == "" || txt_diaChi.Text == "" || txt_SDT.Text == "" || txt_Email.Text == "" || txt_MatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!");
            }
            else
            {
                var nv = new ViewHienThi1()
                {
                    nhanViens = new nhanVien()
                    {
                        tenNV = txt_tenNV.Text,
                        diaChi = txt_diaChi.Text,
                        SDT = txt_SDT.Text,
                        email = txt_Email.Text,
                        matKhau = txt_MatKhau.Text,
                        IDChucVu = cbb_ChucVu.SelectedIndex + 1,
                        tinhTrang = rdb_HD.Checked,
                    }
                };
                qLnhanVienServices.addNhanVien(nv);
                MessageBox.Show("Thêm nhân viên thành công!");
                ResetForm();
            }
        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {
            if (txt_tenNV.Text == "" || txt_diaChi.Text == "" || txt_SDT.Text == "" ||
               txt_Email.Text == "" || txt_MatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!");
            }
            else if (viewNV == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa thông tin!");
            }
            else
            {
                viewNV.nhanViens.tenNV = txt_tenNV.Text;
                viewNV.nhanViens.diaChi = txt_diaChi.Text;
                viewNV.nhanViens.SDT = txt_SDT.Text;
                viewNV.nhanViens.email = txt_Email.Text;
                viewNV.nhanViens.matKhau = txt_MatKhau.Text;
                viewNV.nhanViens.IDChucVu = cbb_ChucVu.SelectedIndex + 1;
                viewNV.nhanViens.tinhTrang = rdb_HD.Checked;
                qLnhanVienServices.UpdateNhanVien(viewNV);
                MessageBox.Show("Sửa thành công!");
                ResetForm();

            }
        }

        private void dtgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLnhanVienServices.GetNhanVienFromDB().Count) return;
            DataGridViewRow r = new DataGridViewRow();
            r = dtgv_NhanVien.Rows[e.RowIndex];
            viewNV = qLnhanVienServices.GetNhanVienFromDB().
                FirstOrDefault(x => x.nhanViens.IDNhanVien == Convert.ToInt32(r.Cells[0].Value));
            txt_tenNV.Text = r.Cells[1].Value.ToString();
            txt_diaChi.Text = r.Cells[2].Value.ToString();
            txt_SDT.Text = r.Cells[3].Value.ToString();
            txt_Email.Text = r.Cells[4].Value.ToString();
            txt_MatKhau.Text = r.Cells[5].Value.ToString();
            cbb_ChucVu.SelectedIndex = cbb_ChucVu.FindStringExact(r.Cells[6].Value.ToString());
            if (r.Cells[7].Value.ToString() == "Hoạt động")
            {
                rdb_HD.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton2.Checked = true;
                rdb_HD.Checked = false;
            }
        }

        private void dtgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
