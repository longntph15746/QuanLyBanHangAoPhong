using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using QuanLyBanHang.View.FrmTrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.View.FrmDangNhap
{
    public partial class FormDangNhap : Form
    {
        IQLnhanVienServices _sv;
        public FormDangNhap()
        {
            _sv = new QLnhanVienServices();
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            check();
        }

        private void llForgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.ShowDialog();
        }
        public void check()
        {
            var acc = _sv.GetNhanVienFromDB().ToList();
            if (txt_taiKhoan.Text.Trim() == "" || txt_matKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tài khoản, mật khẩu");
            }
            else
            {
                for (int i = 0; i < acc.Count; i++)
                {
                    if (txt_taiKhoan.Text == acc[i].nhanViens.email && txt_matKhau.Text == acc[i].nhanViens.matKhau && acc[i].nhanViens.IDChucVu == 1)
                    {
                        MessageBox.Show("Đăng nhập với tư cách quản lí");
                        FormMenuAdmin frmTrangChu = new FormMenuAdmin();
                        frmTrangChu.ShowDialog();
                        return;
                    }
                    else if (txt_taiKhoan.Text == acc[i].nhanViens.email && txt_matKhau.Text == acc[i].nhanViens.matKhau && acc[i].nhanViens.IDChucVu == 2)
                    {
                        MessageBox.Show("Đăng nhập với tư cách nhân viên");
                        FormMenuNhanVien frmTrangChuNhanVien = new FormMenuNhanVien();
                        frmTrangChuNhanVien.ShowDialog();
                        return;
                    }
                }
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            //txt_taiKhoan.Text = Properties.Default.tk;
            //txt_matKhau.Text = Properties.Settings.Default.mk;
            //if (Properties.Settings.Default.tk != "")
            //{
            //    cb_nhoTK.Checked = true;
            //}
        }

        private void cb_nhoTK_CheckedChanged(object sender, EventArgs e)
        {
            //if (txt_taiKhoan.Text != "" || txt_matKhau.Text != "")
            //{
            //    if (cb_nhoTK.Checked == true)
            //    {
            //        string user = txt_taiKhoan.Text;
            //        string pass = txt_matKhau.Text;
            //        Properties.Settings.Default.tk = user;
            //        Properties.Settings.Default.mk = pass;
            //        Properties.Settings.Default.Save();
            //    }
            //    else
            //    {
            //        Properties.Settings.Default.Reset();
            //    }
        }
    }
    

}
