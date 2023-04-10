namespace Shirt_Shop_Project.View
{
    partial class FrmKhachHang
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
            this.dtgv_DanhSachKH = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuatt = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.rbHoatDong = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSodienthoaiKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DanhSachKH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_DanhSachKH
            // 
            this.dtgv_DanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DanhSachKH.Location = new System.Drawing.Point(17, 37);
            this.dtgv_DanhSachKH.Name = "dtgv_DanhSachKH";
            this.dtgv_DanhSachKH.RowHeadersWidth = 51;
            this.dtgv_DanhSachKH.RowTemplate.Height = 29;
            this.dtgv_DanhSachKH.Size = new System.Drawing.Size(679, 387);
            this.dtgv_DanhSachKH.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSuatt);
            this.groupBox2.Controls.Add(this.btnThemKH);
            this.groupBox2.Controls.Add(this.dtgv_DanhSachKH);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(494, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 587);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // btnSuatt
            // 
            this.btnSuatt.Image = global::FPoly_TShirt_Manage.Properties.Resources.icons8_add_new_32;
            this.btnSuatt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuatt.Location = new System.Drawing.Point(443, 484);
            this.btnSuatt.Name = "btnSuatt";
            this.btnSuatt.Size = new System.Drawing.Size(164, 41);
            this.btnSuatt.TabIndex = 9;
            this.btnSuatt.Text = "Sửa Thông Tin";
            this.btnSuatt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuatt.UseVisualStyleBackColor = true;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Image = global::FPoly_TShirt_Manage.Properties.Resources.icons8_add_new_32;
            this.btnThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKH.Location = new System.Drawing.Point(124, 484);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(185, 41);
            this.btnThemKH.TabIndex = 8;
            this.btnThemKH.Text = "Thêm Khách Hàng";
            this.btnThemKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemKH.UseVisualStyleBackColor = true;
            // 
            // rbHoatDong
            // 
            this.rbHoatDong.AutoSize = true;
            this.rbHoatDong.Location = new System.Drawing.Point(129, 332);
            this.rbHoatDong.Name = "rbHoatDong";
            this.rbHoatDong.Size = new System.Drawing.Size(106, 23);
            this.rbHoatDong.TabIndex = 3;
            this.rbHoatDong.TabStop = true;
            this.rbHoatDong.Text = "Hoạt động";
            this.rbHoatDong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng :";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(150, 49);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(265, 27);
            this.txtTenKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trạng thái :";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(150, 215);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(265, 27);
            this.txtMatkhau.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Điểm :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại :";
            // 
            // txtSodienthoaiKH
            // 
            this.txtSodienthoaiKH.Location = new System.Drawing.Point(150, 163);
            this.txtSodienthoaiKH.Name = "txtSodienthoaiKH";
            this.txtSodienthoaiKH.Size = new System.Drawing.Size(265, 27);
            this.txtSodienthoaiKH.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Địa chỉ :";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(150, 104);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(265, 27);
            this.txtDiachi.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mật khẩu :";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(256, 332);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(154, 23);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Không hoạt động";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSodienthoaiKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMatkhau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbHoatDong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(22, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 587);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách Hàng ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DanhSachKH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dtgv_DanhSachKH;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnSuatt;
    private System.Windows.Forms.Button btnThemKH;
    private System.Windows.Forms.RadioButton rbHoatDong;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtTenKH;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtMatkhau;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtSodienthoaiKH;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtDiachi;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox1;
}
}