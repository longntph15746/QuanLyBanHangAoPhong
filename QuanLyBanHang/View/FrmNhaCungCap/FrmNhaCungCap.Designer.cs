namespace Shirt_Shop_Project.View
{
    partial class FrmNhaCungCap
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
            this.dgvDulieuNCC = new System.Windows.Forms.DataGridView();
            this.gbChucnang = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbNhacungcap = new System.Windows.Forms.GroupBox();
            this.rbKhongHD = new System.Windows.Forms.RadioButton();
            this.rbHoatdong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhacungcap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDulieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDulieuNCC)).BeginInit();
            this.gbChucnang.SuspendLayout();
            this.gbNhacungcap.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDulieu
            // 
            this.gbDulieu.Controls.Add(this.dgvDulieuNCC);
            this.gbDulieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDulieu.Location = new System.Drawing.Point(30, 223);
            this.gbDulieu.Name = "gbDulieu";
            this.gbDulieu.Size = new System.Drawing.Size(722, 330);
            this.gbDulieu.TabIndex = 13;
            this.gbDulieu.TabStop = false;
            this.gbDulieu.Text = "Dữ liệu";
            // 
            // dgvDulieuNCC
            // 
            this.dgvDulieuNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDulieuNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDulieuNCC.Location = new System.Drawing.Point(9, 47);
            this.dgvDulieuNCC.Name = "dgvDulieuNCC";
            this.dgvDulieuNCC.RowHeadersWidth = 51;
            this.dgvDulieuNCC.RowTemplate.Height = 29;
            this.dgvDulieuNCC.Size = new System.Drawing.Size(703, 277);
            this.dgvDulieuNCC.TabIndex = 4;
            this.dgvDulieuNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDulieuNCC_CellClick);
            this.dgvDulieuNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDulieuNCC_CellContentClick);
            // 
            // gbChucnang
            // 
            this.gbChucnang.Controls.Add(this.btnSua);
            this.gbChucnang.Controls.Add(this.btnThem);
            this.gbChucnang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbChucnang.Location = new System.Drawing.Point(459, 22);
            this.gbChucnang.Name = "gbChucnang";
            this.gbChucnang.Size = new System.Drawing.Size(283, 182);
            this.gbChucnang.TabIndex = 11;
            this.gbChucnang.TabStop = false;
            this.gbChucnang.Text = "Chức năng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSua.Image = global::FPoly_TShirt_Manage.Properties.Resources.icons8_update_32;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(75, 102);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(148, 41);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThem.Image = global::FPoly_TShirt_Manage.Properties.Resources.icons8_add_new_32;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(75, 55);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(148, 41);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // gbNhacungcap
            // 
            this.gbNhacungcap.Controls.Add(this.rbKhongHD);
            this.gbNhacungcap.Controls.Add(this.rbHoatdong);
            this.gbNhacungcap.Controls.Add(this.label3);
            this.gbNhacungcap.Controls.Add(this.txtNhacungcap);
            this.gbNhacungcap.Controls.Add(this.label2);
            this.gbNhacungcap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbNhacungcap.Location = new System.Drawing.Point(30, 12);
            this.gbNhacungcap.Name = "gbNhacungcap";
            this.gbNhacungcap.Size = new System.Drawing.Size(377, 192);
            this.gbNhacungcap.TabIndex = 12;
            this.gbNhacungcap.TabStop = false;
            this.gbNhacungcap.Text = "Nhà cung cấp";
            // 
            // rbKhongHD
            // 
            this.rbKhongHD.AutoSize = true;
            this.rbKhongHD.Location = new System.Drawing.Point(259, 107);
            this.rbKhongHD.Name = "rbKhongHD";
            this.rbKhongHD.Size = new System.Drawing.Size(107, 23);
            this.rbKhongHD.TabIndex = 8;
            this.rbKhongHD.TabStop = true;
            this.rbKhongHD.Text = "Không HD";
            this.rbKhongHD.UseVisualStyleBackColor = true;
            // 
            // rbHoatdong
            // 
            this.rbHoatdong.AutoSize = true;
            this.rbHoatdong.Location = new System.Drawing.Point(149, 107);
            this.rbHoatdong.Name = "rbHoatdong";
            this.rbHoatdong.Size = new System.Drawing.Size(106, 23);
            this.rbHoatdong.TabIndex = 1;
            this.rbHoatdong.TabStop = true;
            this.rbHoatdong.Text = "Hoạt động";
            this.rbHoatdong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trạng thái:";
            // 
            // txtNhacungcap
            // 
            this.txtNhacungcap.Location = new System.Drawing.Point(159, 45);
            this.txtNhacungcap.Name = "txtNhacungcap";
            this.txtNhacungcap.Size = new System.Drawing.Size(208, 27);
            this.txtNhacungcap.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nhà cung cấp: ";
            // 
            // FrmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.gbDulieu);
            this.Controls.Add(this.gbChucnang);
            this.Controls.Add(this.gbNhacungcap);
            this.Name = "FrmNhaCungCap";
            this.Text = "FrmNhaCungCap";
            this.gbDulieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDulieuNCC)).EndInit();
            this.gbChucnang.ResumeLayout(false);
            this.gbNhacungcap.ResumeLayout(false);
            this.gbNhacungcap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDulieu;
        private System.Windows.Forms.DataGridView dgvDulieuNCC;
        private System.Windows.Forms.GroupBox gbChucnang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbNhacungcap;
        private System.Windows.Forms.RadioButton rbKhongHD;
        private System.Windows.Forms.RadioButton rbHoatdong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhacungcap;
        private System.Windows.Forms.Label label2;
    }
}