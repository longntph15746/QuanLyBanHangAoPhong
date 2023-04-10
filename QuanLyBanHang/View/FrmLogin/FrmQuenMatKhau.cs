using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPoly_TShirt_Manage.View.FrmLogin
{
    public partial class FrmQuenMatKhau : Form
    {
        private IQLnhanVienServices qLnhanVienServices;
        Random random = new Random();
        int otp;
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            qLnhanVienServices = new QLnhanVienServices();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Email.Text == "")
                {
                    MessageBox.Show("Hãy nhập tên email để nhận mã OTP!");
                }
                else if (qLnhanVienServices.GetNhanVienFromDB().FindIndex(x => x.nhanViens.email == txt_Email.Text) == -1)
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống!");
                }
                else
                {
                    otp = random.Next(100000, 1000000);
                    var fromEmail = new MailAddress(qLnhanVienServices.GetNhanVienFromDB().FirstOrDefault(x => x.chucVus.tenCV == "Quản lý").nhanViens.email);
                    var toEmail = new MailAddress(txt_Email.Text);
                    const string pass = "tqyqkjuktjhuopym";

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromEmail.Address, pass),
                        Timeout = 200000,
                    };
                    using (var message = new MailMessage(fromEmail, toEmail)
                    {
                        Subject = "Mã OTP xác nhận",
                        Body = "Mã OTP của bạn là: " + otp.ToString()
                        + ", xác nhận để đổi mật khẩu.",
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("OTP đã được gửi qua mail!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(otp == null)
            {
                MessageBox.Show("Mã OTP chưa được tạo!");
            }
            else if (txt_otp.Text == "")
            {
                MessageBox.Show("Hãy nhập mã OTP!");
            }
            else
            {
                if (txt_otp.Text == otp.ToString())
                {
                    FrmDoiMatKhau frm = new FrmDoiMatKhau(txt_Email.Text);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mã OTP không chính xác!");
                }
            }
        }
    }
}
