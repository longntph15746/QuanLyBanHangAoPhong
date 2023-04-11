using QuanLyBanHang.View.FrmBanHang;
using QuanLyBanHang.View.FrmChatLieu;
using QuanLyBanHang.View.FrmHangSanXuat;
using QuanLyBanHang.View.FrmHoaDon;
using QuanLyBanHang.View.FrmMauSac;
using QuanLyBanHang.View.FrmNhaCungCap;
using QuanLyBanHang.View.FrmSize;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.View.FrmTrangChu
{
    public partial class FormMenuNhanVien : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMenuNhanVien()
        {
            InitializeComponent();
            random = new Random();
            btn_X.Visible = false;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnl_Home.BackColor = color;
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btn_X.Visible = true;
                }
            }
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnl_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_ManChinh.Controls.Add(childForm);
            this.pnl_ManChinh.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lb_home.Text = childForm.Text;
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lbl_Home.Text = "Chào mừng bạn đến với FPOLY TSHIRT";
            currentButton = null;
            btn_X.Visible = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có muốn thoát khỏi chương trình không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã hủy đăng xuất");
            }
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang(), sender);
            lbl_Home.Text = btn_BanHang.Text;
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhaCungCap(), sender);
            lbl_Home.Text = btn_NhaCungCap.Text;
        }

        private void btn_HangSanXuat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHangSX(), sender);
            lbl_Home.Text = btn_HangSanXuat.Text;
        }

        private void btn_ChatLieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChatLieu(), sender);
            lbl_Home.Text = btn_ChatLieu.Text;
        }

        private void btn_MauSac_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMauSac(), sender);
            lbl_Home.Text = btn_MauSac.Text;
        }

        private void btn_Size_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSize(), sender);
            lbl_Home.Text = btn_Size.Text;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon(), sender);
            lbl_Home.Text = btn_HoaDon.Text;
        }
    }

}
