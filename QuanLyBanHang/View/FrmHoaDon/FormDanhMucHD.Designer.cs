namespace QuanLyBanHang.View.FrmHoaDon
{
    partial class FormDanhMucHD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_SDTKH = new System.Windows.Forms.TextBox();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.dtp_ngayBan = new System.Windows.Forms.DateTimePicker();
            this.rdb_DaThanhToan = new System.Windows.Forms.RadioButton();
            this.rdb_ChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CapNhap = new System.Windows.Forms.Button();
            this.dtgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.dtgv_ChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rdb_ChuaThanhToan);
            this.groupBox1.Controls.Add(this.rdb_DaThanhToan);
            this.groupBox1.Controls.Add(this.dtp_ngayBan);
            this.groupBox1.Controls.Add(this.txt_ghiChu);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.txt_SDTKH);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.txt_MaHD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(971, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục đơn hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_CapNhap);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Location = new System.Drawing.Point(1016, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(312, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_HoaDon);
            this.groupBox3.Controls.Add(this.btn_TimKiem);
            this.groupBox3.Controls.Add(this.txt_timKiem);
            this.groupBox3.Location = new System.Drawing.Point(15, 252);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1314, 246);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgv_ChiTietHoaDon);
            this.groupBox4.Location = new System.Drawing.Point(15, 504);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(1314, 196);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "SDT KH :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày bán :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ghi chú :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trạng thái :";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(156, 47);
            this.txt_MaHD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(259, 27);
            this.txt_MaHD.TabIndex = 7;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(156, 97);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(259, 27);
            this.txt_MaNV.TabIndex = 8;
            // 
            // txt_SDTKH
            // 
            this.txt_SDTKH.Location = new System.Drawing.Point(156, 149);
            this.txt_SDTKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_SDTKH.Name = "txt_SDTKH";
            this.txt_SDTKH.Size = new System.Drawing.Size(259, 27);
            this.txt_SDTKH.TabIndex = 9;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(575, 47);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(259, 27);
            this.txt_TongTien.TabIndex = 10;
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Location = new System.Drawing.Point(575, 152);
            this.txt_ghiChu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(259, 27);
            this.txt_ghiChu.TabIndex = 11;
            // 
            // dtp_ngayBan
            // 
            this.dtp_ngayBan.Location = new System.Drawing.Point(575, 95);
            this.dtp_ngayBan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtp_ngayBan.Name = "dtp_ngayBan";
            this.dtp_ngayBan.Size = new System.Drawing.Size(259, 27);
            this.dtp_ngayBan.TabIndex = 12;
            // 
            // rdb_DaThanhToan
            // 
            this.rdb_DaThanhToan.AutoSize = true;
            this.rdb_DaThanhToan.Location = new System.Drawing.Point(575, 194);
            this.rdb_DaThanhToan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_DaThanhToan.Name = "rdb_DaThanhToan";
            this.rdb_DaThanhToan.Size = new System.Drawing.Size(131, 23);
            this.rdb_DaThanhToan.TabIndex = 13;
            this.rdb_DaThanhToan.TabStop = true;
            this.rdb_DaThanhToan.Text = "Đã thanh toán";
            this.rdb_DaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdb_ChuaThanhToan
            // 
            this.rdb_ChuaThanhToan.AutoSize = true;
            this.rdb_ChuaThanhToan.Location = new System.Drawing.Point(751, 192);
            this.rdb_ChuaThanhToan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_ChuaThanhToan.Name = "rdb_ChuaThanhToan";
            this.rdb_ChuaThanhToan.Size = new System.Drawing.Size(150, 23);
            this.rdb_ChuaThanhToan.TabIndex = 14;
            this.rdb_ChuaThanhToan.TabStop = true;
            this.rdb_ChuaThanhToan.Text = "Chưa thanh toán";
            this.rdb_ChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(921, 16);
            this.txt_timKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.PlaceholderText = "Tìm kiếm ở đây ...";
            this.txt_timKiem.Size = new System.Drawing.Size(259, 27);
            this.txt_timKiem.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(849, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Vnđ";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(1189, 14);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(118, 28);
            this.btn_TimKiem.TabIndex = 16;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(62, 46);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(186, 45);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_CapNhap
            // 
            this.btn_CapNhap.Location = new System.Drawing.Point(62, 123);
            this.btn_CapNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_CapNhap.Name = "btn_CapNhap";
            this.btn_CapNhap.Size = new System.Drawing.Size(186, 45);
            this.btn_CapNhap.TabIndex = 1;
            this.btn_CapNhap.Text = "CẬP NHẬP";
            this.btn_CapNhap.UseVisualStyleBackColor = true;
            // 
            // dtgv_HoaDon
            // 
            this.dtgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HoaDon.Location = new System.Drawing.Point(8, 48);
            this.dtgv_HoaDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgv_HoaDon.Name = "dtgv_HoaDon";
            this.dtgv_HoaDon.RowHeadersWidth = 51;
            this.dtgv_HoaDon.RowTemplate.Height = 29;
            this.dtgv_HoaDon.Size = new System.Drawing.Size(1299, 180);
            this.dtgv_HoaDon.TabIndex = 17;
            // 
            // dtgv_ChiTietHoaDon
            // 
            this.dtgv_ChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ChiTietHoaDon.Location = new System.Drawing.Point(8, 25);
            this.dtgv_ChiTietHoaDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgv_ChiTietHoaDon.Name = "dtgv_ChiTietHoaDon";
            this.dtgv_ChiTietHoaDon.RowHeadersWidth = 51;
            this.dtgv_ChiTietHoaDon.RowTemplate.Height = 29;
            this.dtgv_ChiTietHoaDon.Size = new System.Drawing.Size(1299, 165);
            this.dtgv_ChiTietHoaDon.TabIndex = 18;
            // 
            // FormDanhMucHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 711);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormDanhMucHD";
            this.Text = "FormDanhMucHD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_SDTKH;
        private TextBox txt_MaNV;
        private TextBox txt_MaHD;
        private TextBox txt_ghiChu;
        private TextBox txt_TongTien;
        private DateTimePicker dtp_ngayBan;
        private RadioButton rdb_ChuaThanhToan;
        private RadioButton rdb_DaThanhToan;
        private TextBox txt_timKiem;
        private Label label9;
        private Button btn_TimKiem;
        private Button btn_CapNhap;
        private Button btn_Them;
        private DataGridView dtgv_HoaDon;
        private DataGridView dtgv_ChiTietHoaDon;
    }
}