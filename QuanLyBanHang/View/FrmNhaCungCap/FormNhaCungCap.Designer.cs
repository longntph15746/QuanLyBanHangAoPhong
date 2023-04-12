namespace QuanLyBanHang.View.FrmNhaCungCap
{
    partial class FormNhaCungCap
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
            groupBox3 = new GroupBox();
            dtgv_nhaCC = new DataGridView();
            groupBox2 = new GroupBox();
            btn_Sua = new Button();
            btn_Them = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txt_TenNhaCC = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_nhaCC).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgv_nhaCC);
            groupBox3.Location = new Point(15, 209);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(881, 295);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu";
            // 
            // dtgv_nhaCC
            // 
            dtgv_nhaCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_nhaCC.Location = new Point(8, 25);
            dtgv_nhaCC.Margin = new Padding(4, 3, 4, 3);
            dtgv_nhaCC.Name = "dtgv_nhaCC";
            dtgv_nhaCC.RowHeadersWidth = 51;
            dtgv_nhaCC.RowTemplate.Height = 29;
            dtgv_nhaCC.Size = new Size(866, 254);
            dtgv_nhaCC.TabIndex = 0;
            dtgv_nhaCC.CellClick += dtgv_nhaCC_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Location = new Point(618, 11);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(279, 192);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(52, 112);
            btn_Sua.Margin = new Padding(4, 3, 4, 3);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(181, 39);
            btn_Sua.TabIndex = 1;
            btn_Sua.Text = "CẬP NHẬP";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(52, 48);
            btn_Them.Margin = new Padding(4, 3, 4, 3);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(181, 39);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "THÊM";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(txt_TenNhaCC);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 11);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(595, 192);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhà cung cấp";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(396, 96);
            radioButton2.Margin = new Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 23);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hết hàng";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(226, 96);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(99, 23);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Còn hàng";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txt_TenNhaCC
            // 
            txt_TenNhaCC.Location = new Point(226, 46);
            txt_TenNhaCC.Margin = new Padding(4, 3, 4, 3);
            txt_TenNhaCC.Name = "txt_TenNhaCC";
            txt_TenNhaCC.Size = new Size(320, 27);
            txt_TenNhaCC.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 1;
            label2.Text = "Trạng thái :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên nhà cung cấp :";
            // 
            // FormNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 519);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormNhaCungCap";
            Text = "FormNhaCungCap";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_nhaCC).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dtgv_nhaCC;
        private GroupBox groupBox2;
        private Button btn_Sua;
        private Button btn_Them;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txt_TenNhaCC;
        private Label label2;
        private Label label1;
    }
}