namespace QuanLyBanHang.View.FrmBanHang
{
    partial class FormBanHang
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
            groupBox1 = new GroupBox();
            txt_TimKiem = new TextBox();
            cbb_hangSX = new ComboBox();
            cbb_mauSac = new ComboBox();
            cbb_size = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtgv_DSSP = new DataGridView();
            groupBox2 = new GroupBox();
            btn_TaoHD = new Button();
            btn_XoaGH = new Button();
            btn_XoaSP = new Button();
            dtgv_gioHang = new DataGridView();
            groupBox3 = new GroupBox();
            cbb_KhachHang = new ComboBox();
            rdb_nu = new RadioButton();
            rdb_nam = new RadioButton();
            lbl_diemTichLuy = new Label();
            btn_ThemKH = new Button();
            txt_SDT = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox4 = new GroupBox();
            dtgv_HoadonCho = new DataGridView();
            groupBox5 = new GroupBox();
            btnThanhToan = new Button();
            txt_GhiChu = new TextBox();
            txt_TienThua = new TextBox();
            txt_TongTien = new TextBox();
            txt_khachDua = new TextBox();
            txt_giamGia = new TextBox();
            txt_MaHD = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_DSSP).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_gioHang).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_HoadonCho).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_TimKiem);
            groupBox1.Controls.Add(cbb_hangSX);
            groupBox1.Controls.Add(cbb_mauSac);
            groupBox1.Controls.Add(cbb_size);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtgv_DSSP);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(976, 375);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm ";
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(763, 38);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(201, 27);
            txt_TimKiem.TabIndex = 8;
            txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
            // 
            // cbb_hangSX
            // 
            cbb_hangSX.FormattingEnabled = true;
            cbb_hangSX.Location = new Point(505, 39);
            cbb_hangSX.Name = "cbb_hangSX";
            cbb_hangSX.Size = new Size(124, 27);
            cbb_hangSX.TabIndex = 7;
            cbb_hangSX.SelectedIndexChanged += cbb_hangSX_SelectedIndexChanged;
            // 
            // cbb_mauSac
            // 
            cbb_mauSac.FormattingEnabled = true;
            cbb_mauSac.Location = new Point(243, 38);
            cbb_mauSac.Name = "cbb_mauSac";
            cbb_mauSac.Size = new Size(122, 27);
            cbb_mauSac.TabIndex = 6;
            cbb_mauSac.SelectedIndexChanged += cbb_mauSac_SelectedIndexChanged;
            // 
            // cbb_size
            // 
            cbb_size.FormattingEnabled = true;
            cbb_size.Location = new Point(63, 38);
            cbb_size.Name = "cbb_size";
            cbb_size.Size = new Size(89, 27);
            cbb_size.TabIndex = 5;
            cbb_size.SelectedIndexChanged += cbb_size_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(659, 41);
            label4.Name = "label4";
            label4.Size = new Size(94, 19);
            label4.TabIndex = 4;
            label4.Text = "Tìm kiếm : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 41);
            label3.Name = "label3";
            label3.Size = new Size(121, 19);
            label3.TabIndex = 3;
            label3.Text = "Hãng sản xuất :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 41);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 2;
            label2.Text = "Màu sắc :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 41);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 1;
            label1.Text = "Size : ";
            // 
            // dtgv_DSSP
            // 
            dtgv_DSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_DSSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_DSSP.Location = new Point(12, 100);
            dtgv_DSSP.Name = "dtgv_DSSP";
            dtgv_DSSP.RowHeadersWidth = 51;
            dtgv_DSSP.RowTemplate.Height = 29;
            dtgv_DSSP.Size = new Size(952, 262);
            dtgv_DSSP.TabIndex = 0;
            dtgv_DSSP.CellClick += dtgv_DSSP_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_TaoHD);
            groupBox2.Controls.Add(btn_XoaGH);
            groupBox2.Controls.Add(btn_XoaSP);
            groupBox2.Controls.Add(dtgv_gioHang);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 393);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(557, 305);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng";
            // 
            // btn_TaoHD
            // 
            btn_TaoHD.Location = new Point(388, 255);
            btn_TaoHD.Name = "btn_TaoHD";
            btn_TaoHD.Size = new Size(157, 34);
            btn_TaoHD.TabIndex = 3;
            btn_TaoHD.Text = "Tạo hóa đơn";
            btn_TaoHD.UseVisualStyleBackColor = true;
            btn_TaoHD.Click += btn_TaoHD_Click;
            // 
            // btn_XoaGH
            // 
            btn_XoaGH.Location = new Point(198, 255);
            btn_XoaGH.Name = "btn_XoaGH";
            btn_XoaGH.Size = new Size(157, 34);
            btn_XoaGH.TabIndex = 2;
            btn_XoaGH.Text = "Xóa giỏ hàng";
            btn_XoaGH.UseVisualStyleBackColor = true;
            btn_XoaGH.Click += btn_XoaGH_Click;
            // 
            // btn_XoaSP
            // 
            btn_XoaSP.Location = new Point(6, 255);
            btn_XoaSP.Name = "btn_XoaSP";
            btn_XoaSP.Size = new Size(157, 34);
            btn_XoaSP.TabIndex = 1;
            btn_XoaSP.Text = "Xóa sản phẩm";
            btn_XoaSP.UseVisualStyleBackColor = true;
            btn_XoaSP.Click += btn_XoaSP_Click;
            // 
            // dtgv_gioHang
            // 
            dtgv_gioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_gioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_gioHang.Location = new Point(12, 26);
            dtgv_gioHang.Name = "dtgv_gioHang";
            dtgv_gioHang.RowHeadersWidth = 51;
            dtgv_gioHang.RowTemplate.Height = 29;
            dtgv_gioHang.Size = new Size(533, 208);
            dtgv_gioHang.TabIndex = 0;
            dtgv_gioHang.CellClick += dtgv_gioHang_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbb_KhachHang);
            groupBox3.Controls.Add(rdb_nu);
            groupBox3.Controls.Add(rdb_nam);
            groupBox3.Controls.Add(lbl_diemTichLuy);
            groupBox3.Controls.Add(btn_ThemKH);
            groupBox3.Controls.Add(txt_SDT);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(575, 393);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(413, 305);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thêm nhanh khách hàng";
            // 
            // cbb_KhachHang
            // 
            cbb_KhachHang.FormattingEnabled = true;
            cbb_KhachHang.Location = new Point(162, 28);
            cbb_KhachHang.Name = "cbb_KhachHang";
            cbb_KhachHang.Size = new Size(225, 27);
            cbb_KhachHang.TabIndex = 14;
            cbb_KhachHang.SelectedIndexChanged += cbb_KhachHang_SelectedIndexChanged;
            cbb_KhachHang.TextChanged += cbb_KhachHang_TextChanged;
            // 
            // rdb_nu
            // 
            rdb_nu.AutoSize = true;
            rdb_nu.Location = new Point(259, 124);
            rdb_nu.Name = "rdb_nu";
            rdb_nu.Size = new Size(52, 23);
            rdb_nu.TabIndex = 9;
            rdb_nu.TabStop = true;
            rdb_nu.Text = "Nữ";
            rdb_nu.UseVisualStyleBackColor = true;
            // 
            // rdb_nam
            // 
            rdb_nam.AutoSize = true;
            rdb_nam.Location = new Point(162, 124);
            rdb_nam.Name = "rdb_nam";
            rdb_nam.Size = new Size(64, 23);
            rdb_nam.TabIndex = 8;
            rdb_nam.TabStop = true;
            rdb_nam.Text = "Nam";
            rdb_nam.UseVisualStyleBackColor = true;
            // 
            // lbl_diemTichLuy
            // 
            lbl_diemTichLuy.AutoSize = true;
            lbl_diemTichLuy.Location = new Point(162, 171);
            lbl_diemTichLuy.Name = "lbl_diemTichLuy";
            lbl_diemTichLuy.Size = new Size(21, 19);
            lbl_diemTichLuy.TabIndex = 8;
            lbl_diemTichLuy.Text = "...";
            // 
            // btn_ThemKH
            // 
            btn_ThemKH.Location = new Point(96, 227);
            btn_ThemKH.Name = "btn_ThemKH";
            btn_ThemKH.Size = new Size(241, 40);
            btn_ThemKH.TabIndex = 6;
            btn_ThemKH.Text = "Thêm nhanh khách hàng";
            btn_ThemKH.UseVisualStyleBackColor = true;
            btn_ThemKH.Click += btn_ThemKH_Click;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(162, 72);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(225, 27);
            txt_SDT.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 126);
            label14.Name = "label14";
            label14.Size = new Size(84, 19);
            label14.TabIndex = 3;
            label14.Text = "Giới tính:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 171);
            label13.Name = "label13";
            label13.Size = new Size(119, 19);
            label13.TabIndex = 2;
            label13.Text = "Điểm tích lũy :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 80);
            label12.Name = "label12";
            label12.Size = new Size(115, 19);
            label12.TabIndex = 1;
            label12.Text = "Số điện thoại :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 36);
            label11.Name = "label11";
            label11.Size = new Size(132, 19);
            label11.TabIndex = 0;
            label11.Text = "Tên khách hàng :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtgv_HoadonCho);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(994, 454);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(345, 244);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hóa đơn chờ";
            // 
            // dtgv_HoadonCho
            // 
            dtgv_HoadonCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_HoadonCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_HoadonCho.Location = new Point(9, 26);
            dtgv_HoadonCho.Name = "dtgv_HoadonCho";
            dtgv_HoadonCho.RowHeadersWidth = 51;
            dtgv_HoadonCho.RowTemplate.Height = 29;
            dtgv_HoadonCho.Size = new Size(323, 208);
            dtgv_HoadonCho.TabIndex = 0;
            dtgv_HoadonCho.CellClick += dtgv_HoadonCho_CellClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnThanhToan);
            groupBox5.Controls.Add(txt_GhiChu);
            groupBox5.Controls.Add(txt_TienThua);
            groupBox5.Controls.Add(txt_TongTien);
            groupBox5.Controls.Add(txt_khachDua);
            groupBox5.Controls.Add(txt_giamGia);
            groupBox5.Controls.Add(txt_MaHD);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(994, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(345, 436);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thanh toán";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(74, 354);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(192, 40);
            btnThanhToan.TabIndex = 15;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txt_GhiChu
            // 
            txt_GhiChu.Location = new Point(123, 301);
            txt_GhiChu.Name = "txt_GhiChu";
            txt_GhiChu.Size = new Size(193, 27);
            txt_GhiChu.TabIndex = 11;
            // 
            // txt_TienThua
            // 
            txt_TienThua.Enabled = false;
            txt_TienThua.Location = new Point(123, 249);
            txt_TienThua.Name = "txt_TienThua";
            txt_TienThua.Size = new Size(193, 27);
            txt_TienThua.TabIndex = 10;
            // 
            // txt_TongTien
            // 
            txt_TongTien.Enabled = false;
            txt_TongTien.Location = new Point(123, 201);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.Size = new Size(193, 27);
            txt_TongTien.TabIndex = 9;
            // 
            // txt_khachDua
            // 
            txt_khachDua.Location = new Point(123, 158);
            txt_khachDua.Name = "txt_khachDua";
            txt_khachDua.Size = new Size(193, 27);
            txt_khachDua.TabIndex = 8;
            txt_khachDua.TextChanged += txt_khachDua_TextChanged;
            // 
            // txt_giamGia
            // 
            txt_giamGia.Location = new Point(123, 112);
            txt_giamGia.Name = "txt_giamGia";
            txt_giamGia.Size = new Size(193, 27);
            txt_giamGia.TabIndex = 7;
            txt_giamGia.TextChanged += txt_giamGia_TextChanged;
            // 
            // txt_MaHD
            // 
            txt_MaHD.Enabled = false;
            txt_MaHD.Location = new Point(123, 30);
            txt_MaHD.Name = "txt_MaHD";
            txt_MaHD.Size = new Size(193, 27);
            txt_MaHD.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 309);
            label10.Name = "label10";
            label10.Size = new Size(78, 19);
            label10.TabIndex = 5;
            label10.Text = "Ghi chú :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 257);
            label9.Name = "label9";
            label9.Size = new Size(89, 19);
            label9.TabIndex = 4;
            label9.Text = "Tiền thừa :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 209);
            label8.Name = "label8";
            label8.Size = new Size(89, 19);
            label8.TabIndex = 3;
            label8.Text = "Tổng tiền :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 166);
            label7.Name = "label7";
            label7.Size = new Size(96, 19);
            label7.TabIndex = 2;
            label7.Text = "Khách đưa :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 120);
            label6.Name = "label6";
            label6.Size = new Size(88, 19);
            label6.TabIndex = 1;
            label6.Text = "Giảm giá :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 38);
            label5.Name = "label5";
            label5.Size = new Size(104, 19);
            label5.TabIndex = 0;
            label5.Text = "Mã hóa đơn :";
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 732);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormBanHang";
            Text = "FormBanHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_DSSP).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_gioHang).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_HoadonCho).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private DataGridView dtgv_DSSP;
        private DataGridView dtgv_gioHang;
        private DataGridView dtgv_HoadonCho;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox cbb_size;
        private ComboBox cbb_mauSac;
        private ComboBox cbb_hangSX;
        private TextBox txt_TimKiem;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txt_TienThua;
        private TextBox txt_TongTien;
        private TextBox txt_khachDua;
        private TextBox txt_giamGia;
        private TextBox txt_MaHD;
        private TextBox txt_GhiChu;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btn_ThanhToan;
        private RadioButton rdb_nu;
        private RadioButton rdb_nam;
        private TextBox txt_SDT;
        private Button btn_ThemKH;
        private Button btn_TaoHD;
        private Button btn_XoaGH;
        private Button btn_XoaSP;
        //private Button btn_ThanhToan;
        private Label lbl_diemTichLuy;
        private Button btnThanhToan;
        private ComboBox cbb_KhachHang;
    }
}