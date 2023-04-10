namespace FPoly_TShirt_Manage.View.FrmLogin
{
    partial class FrmQuenMatKhau
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
            label1 = new Label();
            txt_Email = new TextBox();
            btn_Send = new Button();
            label2 = new Label();
            panel1 = new Panel();
            btn_submit = new Button();
            txt_otp = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(538, 25);
            label1.TabIndex = 0;
            label1.Text = "Vui lòng nhập Email để khôi phục mật khẩu của bạn ";
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Email.Location = new Point(93, 60);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(310, 27);
            txt_Email.TabIndex = 1;
            // 
            // btn_Send
            // 
            btn_Send.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Send.Location = new Point(427, 58);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(107, 29);
            btn_Send.TabIndex = 2;
            btn_Send.Text = "GỬI MÃ";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 4;
            label2.Text = "Email : ";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_submit);
            panel1.Controls.Add(txt_otp);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Send);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_Email);
            panel1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(49, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 262);
            panel1.TabIndex = 5;
            // 
            // btn_submit
            // 
            btn_submit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_submit.Location = new Point(193, 182);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(136, 45);
            btn_submit.TabIndex = 7;
            btn_submit.Text = "XÁC NHẬN";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // txt_otp
            // 
            txt_otp.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_otp.Location = new Point(93, 123);
            txt_otp.Name = "txt_otp";
            txt_otp.Size = new Size(310, 27);
            txt_otp.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 5;
            label3.Text = "OTP:";
            // 
            // FrmQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 341);
            Controls.Add(panel1);
            Name = "FrmQuenMatKhau";
            Text = "FrmQuenMatKhau";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txt_Email;
        private Button btn_Send;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private TextBox txt_otp;
        private Button btn_submit;
    }
}