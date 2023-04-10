namespace FPoly_TShirt_Manage.View
{
    partial class FrmDoiMatKhau
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
            panel1 = new Panel();
            btn_Thoat = new Button();
            txt_xacNhanMatKhau = new TextBox();
            txt_matKhauMoi = new TextBox();
            btn_doiMatKhau = new Button();
            cb_hienMatKhau = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Thoat);
            panel1.Controls.Add(txt_xacNhanMatKhau);
            panel1.Controls.Add(txt_matKhauMoi);
            panel1.Controls.Add(btn_doiMatKhau);
            panel1.Controls.Add(cb_hienMatKhau);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(35, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 324);
            panel1.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Thoat.Location = new Point(351, 235);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(145, 39);
            btn_Thoat.TabIndex = 28;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // txt_xacNhanMatKhau
            // 
            txt_xacNhanMatKhau.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_xacNhanMatKhau.Location = new Point(309, 118);
            txt_xacNhanMatKhau.Name = "txt_xacNhanMatKhau";
            txt_xacNhanMatKhau.Size = new Size(245, 27);
            txt_xacNhanMatKhau.TabIndex = 27;
            txt_xacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // txt_matKhauMoi
            // 
            txt_matKhauMoi.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_matKhauMoi.Location = new Point(309, 51);
            txt_matKhauMoi.Name = "txt_matKhauMoi";
            txt_matKhauMoi.Size = new Size(245, 27);
            txt_matKhauMoi.TabIndex = 25;
            txt_matKhauMoi.UseSystemPasswordChar = true;
            // 
            // btn_doiMatKhau
            // 
            btn_doiMatKhau.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_doiMatKhau.Location = new Point(174, 235);
            btn_doiMatKhau.Name = "btn_doiMatKhau";
            btn_doiMatKhau.Size = new Size(145, 39);
            btn_doiMatKhau.TabIndex = 22;
            btn_doiMatKhau.Text = "Đổi mật khẩu ";
            btn_doiMatKhau.UseVisualStyleBackColor = true;
            btn_doiMatKhau.Click += btn_doiMatKhau_Click;
            // 
            // cb_hienMatKhau
            // 
            cb_hienMatKhau.AutoSize = true;
            cb_hienMatKhau.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cb_hienMatKhau.Location = new Point(309, 171);
            cb_hienMatKhau.Name = "cb_hienMatKhau";
            cb_hienMatKhau.Size = new Size(140, 24);
            cb_hienMatKhau.TabIndex = 21;
            cb_hienMatKhau.Text = "Hiện mật khẩu ";
            cb_hienMatKhau.UseVisualStyleBackColor = true;
            cb_hienMatKhau.CheckedChanged += cb_hienMatKhau_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(120, 126);
            label4.Name = "label4";
            label4.Size = new Size(181, 19);
            label4.TabIndex = 20;
            label4.Text = "Xác nhận lại mật khẩu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(120, 59);
            label3.Name = "label3";
            label3.Size = new Size(125, 19);
            label3.TabIndex = 19;
            label3.Text = "Mật khẩu mới : ";
            // 
            // FrmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 372);
            Controls.Add(panel1);
            Name = "FrmDoiMatKhau";
            Text = "FrmDoiMatKhau";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_Thoat;
        private TextBox txt_xacNhanMatKhau;
        private TextBox txt_matKhauMoi;
        private Button btn_doiMatKhau;
        private CheckBox cb_hienMatKhau;
        private Label label4;
        private Label label3;
    }
}