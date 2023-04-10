namespace Shirt_Shop_Project.View
{
    partial class FrmMauSac
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
            rbHoatdong = new RadioButton();
            textBox1 = new TextBox();
            btnThem = new Button();
            dgvDulieu = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            gbMausac = new GroupBox();
            rbKhongHD = new RadioButton();
            gbChucnang = new GroupBox();
            btnSua = new Button();
            gbDulieu = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDulieu).BeginInit();
            gbMausac.SuspendLayout();
            gbChucnang.SuspendLayout();
            gbDulieu.SuspendLayout();
            SuspendLayout();
            // 
            // rbHoatdong
            // 
            rbHoatdong.AutoSize = true;
            rbHoatdong.Location = new Point(125, 99);
            rbHoatdong.Name = "rbHoatdong";
            rbHoatdong.Size = new Size(106, 23);
            rbHoatdong.TabIndex = 1;
            rbHoatdong.TabStop = true;
            rbHoatdong.Text = "Hoạt động";
            rbHoatdong.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.AppWorkspace;
            btnThem.Image = FPoly_TShirt_Manage.Properties.Resources.icons8_add_new_32;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(78, 55);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(145, 39);
            btnThem.TabIndex = 3;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvDulieu
            // 
            dgvDulieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDulieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDulieu.Location = new Point(9, 26);
            dgvDulieu.Name = "dgvDulieu";
            dgvDulieu.RowHeadersWidth = 51;
            dgvDulieu.RowTemplate.Height = 29;
            dgvDulieu.Size = new Size(703, 262);
            dgvDulieu.TabIndex = 4;
            dgvDulieu.CellClick += dgvDulieu_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 44);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 6;
            label2.Text = "Tên màu sắc:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 99);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 7;
            label3.Text = "Trạng thái:";
            // 
            // gbMausac
            // 
            gbMausac.Controls.Add(rbKhongHD);
            gbMausac.Controls.Add(rbHoatdong);
            gbMausac.Controls.Add(label3);
            gbMausac.Controls.Add(textBox1);
            gbMausac.Controls.Add(label2);
            gbMausac.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbMausac.Location = new Point(28, 12);
            gbMausac.Name = "gbMausac";
            gbMausac.Size = new Size(377, 148);
            gbMausac.TabIndex = 9;
            gbMausac.TabStop = false;
            gbMausac.Text = "Màu sắc";
            // 
            // rbKhongHD
            // 
            rbKhongHD.AutoSize = true;
            rbKhongHD.Location = new Point(248, 99);
            rbKhongHD.Name = "rbKhongHD";
            rbKhongHD.Size = new Size(107, 23);
            rbKhongHD.TabIndex = 8;
            rbKhongHD.TabStop = true;
            rbKhongHD.Text = "Không HD";
            rbKhongHD.UseVisualStyleBackColor = true;
            // 
            // gbChucnang
            // 
            gbChucnang.Controls.Add(btnSua);
            gbChucnang.Controls.Add(btnThem);
            gbChucnang.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbChucnang.Location = new Point(457, 22);
            gbChucnang.Name = "gbChucnang";
            gbChucnang.Size = new Size(283, 182);
            gbChucnang.TabIndex = 8;
            gbChucnang.TabStop = false;
            gbChucnang.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.AppWorkspace;
            btnSua.Image = FPoly_TShirt_Manage.Properties.Resources.icons8_update_32;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(78, 100);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(145, 39);
            btnSua.TabIndex = 9;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // gbDulieu
            // 
            gbDulieu.Controls.Add(dgvDulieu);
            gbDulieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbDulieu.Location = new Point(28, 217);
            gbDulieu.Name = "gbDulieu";
            gbDulieu.Size = new Size(722, 294);
            gbDulieu.TabIndex = 10;
            gbDulieu.TabStop = false;
            gbDulieu.Text = "Dữ liệu";
            // 
            // FrmMauSac
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(gbDulieu);
            Controls.Add(gbChucnang);
            Controls.Add(gbMausac);
            Name = "FrmMauSac";
            Text = "FrmMauSac";
            ((System.ComponentModel.ISupportInitialize)dgvDulieu).EndInit();
            gbMausac.ResumeLayout(false);
            gbMausac.PerformLayout();
            gbChucnang.ResumeLayout(false);
            gbDulieu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RadioButton rbHoatdong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDulieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMausac;
        private System.Windows.Forms.RadioButton rbKhongHD;
        private System.Windows.Forms.GroupBox gbChucnang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox gbDulieu;
    }
}