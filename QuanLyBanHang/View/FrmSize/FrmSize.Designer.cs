namespace Shirt_Shop_Project.View
{
    partial class FrmSize
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
            this.dtgv_Size = new System.Windows.Forms.DataGridView();
            this.gbChucnang = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.tbt_Size = new System.Windows.Forms.TextBox();
            this.rbKhongHD = new System.Windows.Forms.RadioButton();
            this.rbHoatdong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDulieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Size)).BeginInit();
            this.gbChucnang.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDulieu
            // 
            this.gbDulieu.Controls.Add(this.dtgv_Size);
            this.gbDulieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDulieu.Location = new System.Drawing.Point(23, 223);
            this.gbDulieu.Name = "gbDulieu";
            this.gbDulieu.Size = new System.Drawing.Size(722, 360);
            this.gbDulieu.TabIndex = 13;
            this.gbDulieu.TabStop = false;
            this.gbDulieu.Text = "Dữ liệu";
            // 
            // dtgv_Size
            // 
            this.dtgv_Size.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Size.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgv_Size.Location = new System.Drawing.Point(9, 26);
            this.dtgv_Size.Name = "dtgv_Size";
            this.dtgv_Size.RowHeadersWidth = 51;
            this.dtgv_Size.RowTemplate.Height = 29;
            this.dtgv_Size.Size = new System.Drawing.Size(654, 317);
            this.dtgv_Size.TabIndex = 4;
            this.dtgv_Size.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Size_CellClick);
            this.dtgv_Size.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Size_CellContentClick);
            // 
            // gbChucnang
            // 
            this.gbChucnang.Controls.Add(this.btnSua);
            this.gbChucnang.Controls.Add(this.btnThem);
            this.gbChucnang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbChucnang.Location = new System.Drawing.Point(452, 12);
            this.gbChucnang.Name = "gbChucnang";
            this.gbChucnang.Size = new System.Drawing.Size(283, 192);
            this.gbChucnang.TabIndex = 11;
            this.gbChucnang.TabStop = false;
            this.gbChucnang.Text = "Chức năng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSua.Image = global::FPoly_TShirt_Manage.Properties.Resources.icons8_update_32;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(62, 109);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(151, 44);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "SỬA ";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThem.Image = global::FPoly_TShirt_Manage.Properties.Resources.icons8_add_new_32;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(62, 64);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 44);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.tbt_Size);
            this.gbSize.Controls.Add(this.rbKhongHD);
            this.gbSize.Controls.Add(this.rbHoatdong);
            this.gbSize.Controls.Add(this.label3);
            this.gbSize.Controls.Add(this.label2);
            this.gbSize.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSize.Location = new System.Drawing.Point(23, 12);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(409, 192);
            this.gbSize.TabIndex = 12;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Màu sắc";
            // 
            // tbt_Size
            // 
            this.tbt_Size.Location = new System.Drawing.Point(132, 41);
            this.tbt_Size.Name = "tbt_Size";
            this.tbt_Size.Size = new System.Drawing.Size(230, 27);
            this.tbt_Size.TabIndex = 9;
            // 
            // rbKhongHD
            // 
            this.rbKhongHD.AutoSize = true;
            this.rbKhongHD.Location = new System.Drawing.Point(255, 99);
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
            this.rbHoatdong.Location = new System.Drawing.Point(132, 99);
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
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Size: ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Size";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Size";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trạng Thái";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // FrmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.gbDulieu);
            this.Controls.Add(this.gbChucnang);
            this.Controls.Add(this.gbSize);
            this.Name = "FrmSize";
            this.Text = "FrmSize";
            this.gbDulieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Size)).EndInit();
            this.gbChucnang.ResumeLayout(false);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbDulieu;
    private System.Windows.Forms.DataGridView dtgv_Size;
    private System.Windows.Forms.GroupBox gbChucnang;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.GroupBox gbSize;
    private System.Windows.Forms.RadioButton rbKhongHD;
    private System.Windows.Forms.RadioButton rbHoatdong;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
        private TextBox tbt_Size;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}