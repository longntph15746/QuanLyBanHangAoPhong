namespace Shirt_Shop_Project.View
{
    partial class FrmChatLieu
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
            gbDulieu = new GroupBox();
            dgv_DulieuChatLieu = new DataGridView();
            gbChucnang = new GroupBox();
            btnSua = new Button();
            btnThem = new Button();
            gbChatlieu = new GroupBox();
            rbKhongHD = new RadioButton();
            rbHoatdong = new RadioButton();
            label3 = new Label();
            txtChatlieu = new TextBox();
            label2 = new Label();
            gbDulieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DulieuChatLieu).BeginInit();
            gbChucnang.SuspendLayout();
            gbChatlieu.SuspendLayout();
            SuspendLayout();
            // 
            // gbDulieu
            // 
            gbDulieu.Controls.Add(dgv_DulieuChatLieu);
            gbDulieu.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbDulieu.Location = new Point(23, 223);
            gbDulieu.Name = "gbDulieu";
            gbDulieu.Size = new Size(722, 434);
            gbDulieu.TabIndex = 13;
            gbDulieu.TabStop = false;
            gbDulieu.Text = "Dữ liệu";
            // 
            // dgv_DulieuChatLieu
            // 
            dgv_DulieuChatLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DulieuChatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DulieuChatLieu.Location = new Point(9, 26);
            dgv_DulieuChatLieu.Name = "dgv_DulieuChatLieu";
            dgv_DulieuChatLieu.RowHeadersWidth = 51;
            dgv_DulieuChatLieu.RowTemplate.Height = 29;
            dgv_DulieuChatLieu.Size = new Size(703, 270);
            dgv_DulieuChatLieu.TabIndex = 4;
            dgv_DulieuChatLieu.CellClick += dgv_DulieuChatLieu_CellClick;
            dgv_DulieuChatLieu.CellContentClick += dgv_DulieuChatLieu_CellContentClick;
            // 
            // gbChucnang
            // 
            gbChucnang.Controls.Add(btnSua);
            gbChucnang.Controls.Add(btnThem);
            gbChucnang.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbChucnang.Location = new Point(452, 12);
            gbChucnang.Name = "gbChucnang";
            gbChucnang.Size = new Size(262, 192);
            gbChucnang.TabIndex = 11;
            gbChucnang.TabStop = false;
            gbChucnang.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.AppWorkspace;
            btnSua.Location = new Point(56, 106);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(153, 44);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.AppWorkspace;
            btnThem.Location = new Point(56, 56);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 44);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // gbChatlieu
            // 
            gbChatlieu.Controls.Add(rbKhongHD);
            gbChatlieu.Controls.Add(rbHoatdong);
            gbChatlieu.Controls.Add(label3);
            gbChatlieu.Controls.Add(txtChatlieu);
            gbChatlieu.Controls.Add(label2);
            gbChatlieu.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbChatlieu.Location = new Point(23, 12);
            gbChatlieu.Name = "gbChatlieu";
            gbChatlieu.Size = new Size(408, 192);
            gbChatlieu.TabIndex = 12;
            gbChatlieu.TabStop = false;
            gbChatlieu.Text = "Chất liệu";
            // 
            // rbKhongHD
            // 
            rbKhongHD.AutoSize = true;
            rbKhongHD.Location = new Point(269, 99);
            rbKhongHD.Name = "rbKhongHD";
            rbKhongHD.Size = new Size(107, 23);
            rbKhongHD.TabIndex = 8;
            rbKhongHD.TabStop = true;
            rbKhongHD.Text = "Không HD";
            rbKhongHD.UseVisualStyleBackColor = true;
            // 
            // rbHoatdong
            // 
            rbHoatdong.AutoSize = true;
            rbHoatdong.Location = new Point(146, 99);
            rbHoatdong.Name = "rbHoatdong";
            rbHoatdong.Size = new Size(106, 23);
            rbHoatdong.TabIndex = 1;
            rbHoatdong.TabStop = true;
            rbHoatdong.Text = "Hoạt động";
            rbHoatdong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 99);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 7;
            label3.Text = "Trạng thái:";
            // 
            // txtChatlieu
            // 
            txtChatlieu.Location = new Point(146, 41);
            txtChatlieu.Name = "txtChatlieu";
            txtChatlieu.Size = new Size(222, 27);
            txtChatlieu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 44);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 6;
            label2.Text = "Tên chất liệu:";
            // 
            // FrmChatLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 658);
            Controls.Add(gbDulieu);
            Controls.Add(gbChucnang);
            Controls.Add(gbChatlieu);
            Name = "FrmChatLieu";
            Text = "ChatLieu";
            gbDulieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DulieuChatLieu).EndInit();
            gbChucnang.ResumeLayout(false);
            gbChatlieu.ResumeLayout(false);
            gbChatlieu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbDulieu;
        private System.Windows.Forms.DataGridView dgv_DulieuChatLieu;
        private System.Windows.Forms.GroupBox gbChucnang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbChatlieu;
        private System.Windows.Forms.RadioButton rbKhongHD;
        private System.Windows.Forms.RadioButton rbHoatdong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChatlieu;
        private System.Windows.Forms.Label label2;
    }
}