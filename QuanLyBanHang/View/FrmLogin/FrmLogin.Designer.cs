namespace Shirt_Shop_Project.View
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_taiKhoan = new System.Windows.Forms.TextBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_nhoTK = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llForgotpassword = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_taiKhoan
            // 
            this.txt_taiKhoan.Location = new System.Drawing.Point(168, 101);
            this.txt_taiKhoan.Name = "txt_taiKhoan";
            this.txt_taiKhoan.Size = new System.Drawing.Size(325, 30);
            this.txt_taiKhoan.TabIndex = 1;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(168, 150);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.PasswordChar = '*';
            this.txt_matKhau.Size = new System.Drawing.Size(324, 30);
            this.txt_matKhau.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(148, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN SYSTEM";
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.BackColor = System.Drawing.Color.Turquoise;
            this.btn_dangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dangNhap.Image = global::FPoly_TShirt_Manage.Properties.Resources.icons8_login_32;
            this.btn_dangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangNhap.Location = new System.Drawing.Point(216, 234);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(173, 49);
            this.btn_dangNhap.TabIndex = 5;
            this.btn_dangNhap.Text = "ĐĂNG NHẬP";
            this.btn_dangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangNhap.UseVisualStyleBackColor = false;
            this.btn_dangNhap.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.cb_nhoTK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_dangNhap);
            this.panel1.Controls.Add(this.llForgotpassword);
            this.panel1.Controls.Add(this.txt_taiKhoan);
            this.panel1.Controls.Add(this.txt_matKhau);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(29, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 324);
            this.panel1.TabIndex = 8;
            // 
            // cb_nhoTK
            // 
            this.cb_nhoTK.AutoSize = true;
            this.cb_nhoTK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cb_nhoTK.Location = new System.Drawing.Point(168, 187);
            this.cb_nhoTK.Name = "cb_nhoTK";
            this.cb_nhoTK.Size = new System.Drawing.Size(131, 23);
            this.cb_nhoTK.TabIndex = 10;
            this.cb_nhoTK.Text = "Nhớ tài khoản";
            this.cb_nhoTK.UseVisualStyleBackColor = true;
            this.cb_nhoTK.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "MẬT KHẨU :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "TÀI KHOẢN : ";
            // 
            // llForgotpassword
            // 
            this.llForgotpassword.AutoSize = true;
            this.llForgotpassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.llForgotpassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.llForgotpassword.Location = new System.Drawing.Point(350, 186);
            this.llForgotpassword.Name = "llForgotpassword";
            this.llForgotpassword.Size = new System.Drawing.Size(142, 22);
            this.llForgotpassword.TabIndex = 7;
            this.llForgotpassword.TabStop = true;
            this.llForgotpassword.Text = "Quên mật khẩu?";
            this.llForgotpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llForgotpassword_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 389);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_taiKhoan;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dangNhap;
        private Panel panel1;
        private LinkLabel llForgotpassword;
        private Label label2;
        private Label label1;
        private CheckBox cb_nhoTK;
    }
}