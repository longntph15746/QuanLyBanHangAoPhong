﻿namespace QuanLyBanHang.View.FrmChatLieu
{
    partial class FormChatLieu
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgv_ChatLieu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_hetHang = new System.Windows.Forms.RadioButton();
            this.rdb_conHang = new System.Windows.Forms.RadioButton();
            this.txt_TenMauSac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChatLieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_ChatLieu);
            this.groupBox3.Location = new System.Drawing.Point(12, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(705, 311);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ liệu";
            // 
            // dtgv_ChatLieu
            // 
            this.dtgv_ChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ChatLieu.Location = new System.Drawing.Point(6, 26);
            this.dtgv_ChatLieu.Name = "dtgv_ChatLieu";
            this.dtgv_ChatLieu.RowHeadersWidth = 51;
            this.dtgv_ChatLieu.RowTemplate.Height = 29;
            this.dtgv_ChatLieu.Size = new System.Drawing.Size(693, 267);
            this.dtgv_ChatLieu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Location = new System.Drawing.Point(494, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 202);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(42, 118);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(145, 41);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "CẬP NHẬP";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(42, 50);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(145, 41);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_hetHang);
            this.groupBox1.Controls.Add(this.rdb_conHang);
            this.groupBox1.Controls.Add(this.txt_TenMauSac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chất liệu";
            // 
            // rdb_hetHang
            // 
            this.rdb_hetHang.AutoSize = true;
            this.rdb_hetHang.Location = new System.Drawing.Point(292, 101);
            this.rdb_hetHang.Name = "rdb_hetHang";
            this.rdb_hetHang.Size = new System.Drawing.Size(91, 24);
            this.rdb_hetHang.TabIndex = 4;
            this.rdb_hetHang.TabStop = true;
            this.rdb_hetHang.Text = "Hết hàng";
            this.rdb_hetHang.UseVisualStyleBackColor = true;
            // 
            // rdb_conHang
            // 
            this.rdb_conHang.AutoSize = true;
            this.rdb_conHang.Location = new System.Drawing.Point(165, 101);
            this.rdb_conHang.Name = "rdb_conHang";
            this.rdb_conHang.Size = new System.Drawing.Size(93, 24);
            this.rdb_conHang.TabIndex = 3;
            this.rdb_conHang.TabStop = true;
            this.rdb_conHang.Text = "Còn hàng";
            this.rdb_conHang.UseVisualStyleBackColor = true;
            // 
            // txt_TenMauSac
            // 
            this.txt_TenMauSac.Location = new System.Drawing.Point(165, 48);
            this.txt_TenMauSac.Name = "txt_TenMauSac";
            this.txt_TenMauSac.Size = new System.Drawing.Size(257, 27);
            this.txt_TenMauSac.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chất liệu : ";
            // 
            // FormChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormChatLieu";
            this.Text = "FormChatLieu";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChatLieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dtgv_ChatLieu;
        private GroupBox groupBox2;
        private Button btn_Sua;
        private Button btn_Them;
        private GroupBox groupBox1;
        private RadioButton rdb_hetHang;
        private RadioButton rdb_conHang;
        private TextBox txt_TenMauSac;
        private Label label2;
        private Label label1;
    }
}