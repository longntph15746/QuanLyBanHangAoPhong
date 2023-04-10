namespace Shirt_Shop_Project.View
{
    partial class FrmHoaDonChiTiet
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
            this.gbDulieu = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.gbChucnang = new System.Windows.Forms.GroupBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChitiethoadon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayban = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.rbDathanhtoan = new System.Windows.Forms.RadioButton();
            this.tbChuathanhtoan = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbDulieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.gbChucnang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiethoadon)).BeginInit();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDulieu
            // 
            this.gbDulieu.Controls.Add(this.btnTimkiem);
            this.gbDulieu.Controls.Add(this.dgvHoaDon);
            this.gbDulieu.Controls.Add(this.txtTimkiem);
            this.gbDulieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDulieu.Location = new System.Drawing.Point(18, 220);
            this.gbDulieu.Name = "gbDulieu";
            this.gbDulieu.Size = new System.Drawing.Size(1218, 321);
            this.gbDulieu.TabIndex = 16;
            this.gbDulieu.TabStop = false;
            this.gbDulieu.Text = "Hóa đơn";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTimkiem.Location = new System.Drawing.Point(1098, 22);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(103, 32);
            this.btnTimkiem.TabIndex = 11;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 60);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 29;
            this.dgvHoaDon.Size = new System.Drawing.Size(1189, 235);
            this.dgvHoaDon.TabIndex = 4;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(792, 25);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PlaceholderText = "Tìm kiếm ở đây ...";
            this.txtTimkiem.Size = new System.Drawing.Size(291, 27);
            this.txtTimkiem.TabIndex = 26;
            // 
            // gbChucnang
            // 
            this.gbChucnang.Controls.Add(this.btnCapnhat);
            this.gbChucnang.Controls.Add(this.btnThem);
            this.gbChucnang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbChucnang.Location = new System.Drawing.Point(945, 19);
            this.gbChucnang.Name = "gbChucnang";
            this.gbChucnang.Size = new System.Drawing.Size(283, 195);
            this.gbChucnang.TabIndex = 14;
            this.gbChucnang.TabStop = false;
            this.gbChucnang.Text = "Chức năng";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCapnhat.Image = global::FPoly_TShirt_Manage.Properties.Resources.icons8_update_32;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapnhat.Location = new System.Drawing.Point(56, 105);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(178, 44);
            this.btnCapnhat.TabIndex = 9;
            this.btnCapnhat.Text = "CẬP NHẬP";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThem.Image = global::FPoly_TShirt_Manage.Properties.Resources.icons8_add_new_32;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(56, 55);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(178, 44);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvChitiethoadon);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(18, 566);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1218, 356);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // dgvChitiethoadon
            // 
            this.dgvChitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiethoadon.Location = new System.Drawing.Point(12, 26);
            this.dgvChitiethoadon.Name = "dgvChitiethoadon";
            this.dgvChitiethoadon.RowHeadersWidth = 51;
            this.dgvChitiethoadon.RowTemplate.Height = 29;
            this.dgvChitiethoadon.Size = new System.Drawing.Size(1189, 303);
            this.dgvChitiethoadon.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã hóa đơn: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã nhân viên: ";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(157, 41);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(207, 27);
            this.txtMaHD.TabIndex = 11;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(157, 82);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(207, 27);
            this.txtMaNV.TabIndex = 12;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(157, 125);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(207, 27);
            this.txtSDTKH.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "SĐT Khách hàng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tổng tiền: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày bán: ";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(515, 31);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(197, 27);
            this.txtTongtien.TabIndex = 17;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(515, 115);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(197, 27);
            this.txtGhichu.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ghi chú: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Trạng thái:";
            // 
            // dtpNgayban
            // 
            this.dtpNgayban.Location = new System.Drawing.Point(516, 72);
            this.dtpNgayban.Name = "dtpNgayban";
            this.dtpNgayban.Size = new System.Drawing.Size(196, 27);
            this.dtpNgayban.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(718, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "VNĐ";
            // 
            // rbDathanhtoan
            // 
            this.rbDathanhtoan.AutoSize = true;
            this.rbDathanhtoan.Location = new System.Drawing.Point(516, 159);
            this.rbDathanhtoan.Name = "rbDathanhtoan";
            this.rbDathanhtoan.Size = new System.Drawing.Size(131, 23);
            this.rbDathanhtoan.TabIndex = 24;
            this.rbDathanhtoan.TabStop = true;
            this.rbDathanhtoan.Text = "Đã thanh toán";
            this.rbDathanhtoan.UseVisualStyleBackColor = true;
            // 
            // tbChuathanhtoan
            // 
            this.tbChuathanhtoan.AutoSize = true;
            this.tbChuathanhtoan.Location = new System.Drawing.Point(673, 159);
            this.tbChuathanhtoan.Name = "tbChuathanhtoan";
            this.tbChuathanhtoan.Size = new System.Drawing.Size(150, 23);
            this.tbChuathanhtoan.TabIndex = 25;
            this.tbChuathanhtoan.TabStop = true;
            this.tbChuathanhtoan.Text = "Chưa thanh toán";
            this.tbChuathanhtoan.UseVisualStyleBackColor = true;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.tbChuathanhtoan);
            this.gbSize.Controls.Add(this.rbDathanhtoan);
            this.gbSize.Controls.Add(this.label8);
            this.gbSize.Controls.Add(this.dtpNgayban);
            this.gbSize.Controls.Add(this.label7);
            this.gbSize.Controls.Add(this.label4);
            this.gbSize.Controls.Add(this.txtGhichu);
            this.gbSize.Controls.Add(this.txtTongtien);
            this.gbSize.Controls.Add(this.label5);
            this.gbSize.Controls.Add(this.label6);
            this.gbSize.Controls.Add(this.label1);
            this.gbSize.Controls.Add(this.txtSDTKH);
            this.gbSize.Controls.Add(this.txtMaNV);
            this.gbSize.Controls.Add(this.txtMaHD);
            this.gbSize.Controls.Add(this.label3);
            this.gbSize.Controls.Add(this.label2);
            this.gbSize.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSize.Location = new System.Drawing.Point(18, 9);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(905, 205);
            this.gbSize.TabIndex = 15;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Doanh mục đơn hàng";
            // 
            // FrmHoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 934);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDulieu);
            this.Controls.Add(this.gbChucnang);
            this.Controls.Add(this.gbSize);
            this.Name = "FrmHoaDonChiTiet";
            this.Text = "FrmHoaDon";
            this.gbDulieu.ResumeLayout(false);
            this.gbDulieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.gbChucnang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiethoadon)).EndInit();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbDulieu;
    private System.Windows.Forms.Button btnTimkiem;
    private System.Windows.Forms.DataGridView dgvHoaDon;
    private System.Windows.Forms.TextBox txtTimkiem;
    private System.Windows.Forms.GroupBox gbChucnang;
    private System.Windows.Forms.Button btnCapnhat;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView dgvChitiethoadon;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMaHD;
    private System.Windows.Forms.TextBox txtMaNV;
    private System.Windows.Forms.TextBox txtSDTKH;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtTongtien;
    private System.Windows.Forms.TextBox txtGhichu;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DateTimePicker dtpNgayban;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.RadioButton rbDathanhtoan;
    private System.Windows.Forms.RadioButton tbChuathanhtoan;
    private System.Windows.Forms.GroupBox gbSize;
}
}