using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using FPoly_TShirt_Manage.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPoly_TShirt_Manage.View
{
    public partial class FrmDoiMatKhau : Form
    {
        private IQLnhanVienServices qLnhanVienServices;
        private string email;
        public FrmDoiMatKhau(string emailDoiMK)
        {
            InitializeComponent();
            qLnhanVienServices = new QLnhanVienServices();
            email = emailDoiMK;
        }

        private void btn_doiMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_matKhauMoi.Text == "" || txt_xacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ cả Mật khẩu và Xác nhận mật khẩu!");
            }
            else if (txt_xacNhanMatKhau.Text != txt_matKhauMoi.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không giống với mật khẩu!");
            }
            else
            {
                var nv = qLnhanVienServices.GetNhanVienFromDB().FirstOrDefault(x => x.nhanViens.email == email);
                nv.nhanViens.matKhau = txt_matKhauMoi.Text;
                qLnhanVienServices.UpdateNhanVien(nv);
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Hide();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cb_hienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienMatKhau.Checked == true)
            {
                txt_matKhauMoi.UseSystemPasswordChar = false;
                txt_xacNhanMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matKhauMoi.UseSystemPasswordChar = true;
                txt_xacNhanMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
