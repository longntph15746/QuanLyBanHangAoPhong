namespace QuanLyBanHang.View.FrmSize
{
    partial class FormSize
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
            this.rdb_hetHang = new System.Windows.Forms.RadioButton();
            this.rdb_conHang = new System.Windows.Forms.RadioButton();
            this.txt_TenSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgv_Size = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_hetHang);
            this.groupBox1.Controls.Add(this.rdb_conHang);
            this.groupBox1.Controls.Add(this.txt_TenSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(595, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rdb_hetHang
            // 
            this.rdb_hetHang.AutoSize = true;
            this.rdb_hetHang.Location = new System.Drawing.Point(365, 96);
            this.rdb_hetHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_hetHang.Name = "rdb_hetHang";
            this.rdb_hetHang.Size = new System.Drawing.Size(96, 23);
            this.rdb_hetHang.TabIndex = 4;
            this.rdb_hetHang.TabStop = true;
            this.rdb_hetHang.Text = "Hết hàng";
            this.rdb_hetHang.UseVisualStyleBackColor = true;
            // 
            // rdb_conHang
            // 
            this.rdb_conHang.AutoSize = true;
            this.rdb_conHang.Location = new System.Drawing.Point(190, 96);
            this.rdb_conHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_conHang.Name = "rdb_conHang";
            this.rdb_conHang.Size = new System.Drawing.Size(99, 23);
            this.rdb_conHang.TabIndex = 3;
            this.rdb_conHang.TabStop = true;
            this.rdb_conHang.Text = "Còn hàng";
            this.rdb_conHang.UseVisualStyleBackColor = true;
            // 
            // txt_TenSize
            // 
            this.txt_TenSize.Location = new System.Drawing.Point(190, 46);
            this.txt_TenSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TenSize.Name = "txt_TenSize";
            this.txt_TenSize.Size = new System.Drawing.Size(320, 27);
            this.txt_TenSize.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên size :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Location = new System.Drawing.Point(618, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(279, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(52, 112);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(181, 39);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "CẬP NHẬP";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(52, 48);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(181, 39);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_Size);
            this.groupBox3.Location = new System.Drawing.Point(15, 209);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(881, 295);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ liệu";
            // 
            // dtgv_Size
            // 
            this.dtgv_Size.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Size.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgv_Size.Location = new System.Drawing.Point(8, 25);
            this.dtgv_Size.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgv_Size.Name = "dtgv_Size";
            this.dtgv_Size.RowHeadersWidth = 51;
            this.dtgv_Size.RowTemplate.Height = 29;
            this.dtgv_Size.Size = new System.Drawing.Size(866, 254);
            this.dtgv_Size.TabIndex = 0;
            this.dtgv_Size.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Size_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Size";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Size";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trạng thái";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // FormSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 516);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormSize";
            this.Text = "FormSize";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Size)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txt_TenSize;
        private Label label2;
        private Label label1;
        private RadioButton rdb_hetHang;
        private RadioButton rdb_conHang;
        private Button btn_Sua;
        private Button btn_Them;
        private DataGridView dtgv_Size;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}