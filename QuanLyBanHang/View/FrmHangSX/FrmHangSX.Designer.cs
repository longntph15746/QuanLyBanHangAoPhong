namespace Shirt_Shop_Project.View
{
    partial class FrmHangSX
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
            this.dtgv_hangSX = new System.Windows.Forms.GroupBox();
            this.dtgvHangSX = new System.Windows.Forms.DataGridView();
            this.gbChucnang = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.gbHangsx = new System.Windows.Forms.GroupBox();
            this.rdb_KHD = new System.Windows.Forms.RadioButton();
            this.rdb_HD = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hangSX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgv_hangSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangSX)).BeginInit();
            this.gbChucnang.SuspendLayout();
            this.gbHangsx.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_hangSX
            // 
            this.dtgv_hangSX.Controls.Add(this.dtgvHangSX);
            this.dtgv_hangSX.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtgv_hangSX.Location = new System.Drawing.Point(25, 235);
            this.dtgv_hangSX.Name = "dtgv_hangSX";
            this.dtgv_hangSX.Size = new System.Drawing.Size(722, 269);
            this.dtgv_hangSX.TabIndex = 13;
            this.dtgv_hangSX.TabStop = false;
            this.dtgv_hangSX.Text = "Danh sách hãng sản xuất";
            // 
            // dtgvHangSX
            // 
            this.dtgvHangSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvHangSX.Location = new System.Drawing.Point(9, 26);
            this.dtgvHangSX.Name = "dtgvHangSX";
            this.dtgvHangSX.RowHeadersWidth = 51;
            this.dtgvHangSX.RowTemplate.Height = 29;
            this.dtgvHangSX.Size = new System.Drawing.Size(703, 226);
            this.dtgvHangSX.TabIndex = 0;
            this.dtgvHangSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHangSX_CellClick);
            this.dtgvHangSX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHangSX_CellContentClick);
            // 
            // gbChucnang
            // 
            this.gbChucnang.Controls.Add(this.btnSua);
            this.gbChucnang.Controls.Add(this.btn_Them);
            this.gbChucnang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbChucnang.Location = new System.Drawing.Point(454, 22);
            this.gbChucnang.Name = "gbChucnang";
            this.gbChucnang.Size = new System.Drawing.Size(283, 182);
            this.gbChucnang.TabIndex = 11;
            this.gbChucnang.TabStop = false;
            this.gbChucnang.Text = "Chức năng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSua.Location = new System.Drawing.Point(73, 105);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(146, 37);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Them.Location = new System.Drawing.Point(73, 60);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(146, 37);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // gbHangsx
            // 
            this.gbHangsx.Controls.Add(this.rdb_KHD);
            this.gbHangsx.Controls.Add(this.rdb_HD);
            this.gbHangsx.Controls.Add(this.label3);
            this.gbHangsx.Controls.Add(this.txt_hangSX);
            this.gbHangsx.Controls.Add(this.label2);
            this.gbHangsx.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbHangsx.Location = new System.Drawing.Point(25, 25);
            this.gbHangsx.Name = "gbHangsx";
            this.gbHangsx.Size = new System.Drawing.Size(403, 192);
            this.gbHangsx.TabIndex = 12;
            this.gbHangsx.TabStop = false;
            this.gbHangsx.Text = "Hãng Sản Xuất";
            // 
            // rdb_KHD
            // 
            this.rdb_KHD.AutoSize = true;
            this.rdb_KHD.Location = new System.Drawing.Point(270, 99);
            this.rdb_KHD.Name = "rdb_KHD";
            this.rdb_KHD.Size = new System.Drawing.Size(107, 23);
            this.rdb_KHD.TabIndex = 8;
            this.rdb_KHD.TabStop = true;
            this.rdb_KHD.Text = "Không HD";
            this.rdb_KHD.UseVisualStyleBackColor = true;
            // 
            // rdb_HD
            // 
            this.rdb_HD.AutoSize = true;
            this.rdb_HD.Location = new System.Drawing.Point(160, 99);
            this.rdb_HD.Name = "rdb_HD";
            this.rdb_HD.Size = new System.Drawing.Size(106, 23);
            this.rdb_HD.TabIndex = 1;
            this.rdb_HD.TabStop = true;
            this.rdb_HD.Text = "Hoạt động";
            this.rdb_HD.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trạng thái:";
            // 
            // txt_hangSX
            // 
            this.txt_hangSX.Location = new System.Drawing.Point(160, 41);
            this.txt_hangSX.Name = "txt_hangSX";
            this.txt_hangSX.Size = new System.Drawing.Size(204, 27);
            this.txt_hangSX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên hãng sản xuất: ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID hãng sản xuất";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hãng sản xuất";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trang thái";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // FrmHangSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.dtgv_hangSX);
            this.Controls.Add(this.gbChucnang);
            this.Controls.Add(this.gbHangsx);
            this.Name = "FrmHangSX";
            this.Text = "FrmHangSX";
            this.dtgv_hangSX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangSX)).EndInit();
            this.gbChucnang.ResumeLayout(false);
            this.gbHangsx.ResumeLayout(false);
            this.gbHangsx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dtgv_hangSX;
        private System.Windows.Forms.GroupBox gbChucnang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox gbHangsx;
        private System.Windows.Forms.RadioButton rdb_KHD;
        private System.Windows.Forms.RadioButton rdb_HD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_hangSX;
        private System.Windows.Forms.Label label2;
        private DataGridView dtgvHangSX;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}