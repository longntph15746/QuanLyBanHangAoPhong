namespace FPoly_TShirt_Manage.View.FrmHoaDon
{
    partial class FrmTimKiemHD
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
            this.dtgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.txt_TimKiemHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_ChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_HoaDon);
            this.groupBox1.Controls.Add(this.txt_TimKiemHoaDon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // dtgv_HoaDon
            // 
            this.dtgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HoaDon.Location = new System.Drawing.Point(17, 68);
            this.dtgv_HoaDon.Name = "dtgv_HoaDon";
            this.dtgv_HoaDon.RowHeadersWidth = 51;
            this.dtgv_HoaDon.RowTemplate.Height = 29;
            this.dtgv_HoaDon.Size = new System.Drawing.Size(844, 234);
            this.dtgv_HoaDon.TabIndex = 2;
            // 
            // txt_TimKiemHoaDon
            // 
            this.txt_TimKiemHoaDon.Location = new System.Drawing.Point(582, 32);
            this.txt_TimKiemHoaDon.Name = "txt_TimKiemHoaDon";
            this.txt_TimKiemHoaDon.PlaceholderText = "Tìm kiếm ở đây ...";
            this.txt_TimKiemHoaDon.Size = new System.Drawing.Size(279, 27);
            this.txt_TimKiemHoaDon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_ChiTietHoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dtgv_ChiTietHoaDon
            // 
            this.dtgv_ChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ChiTietHoaDon.Location = new System.Drawing.Point(17, 37);
            this.dtgv_ChiTietHoaDon.Name = "dtgv_ChiTietHoaDon";
            this.dtgv_ChiTietHoaDon.RowHeadersWidth = 51;
            this.dtgv_ChiTietHoaDon.RowTemplate.Height = 29;
            this.dtgv_ChiTietHoaDon.Size = new System.Drawing.Size(844, 249);
            this.dtgv_ChiTietHoaDon.TabIndex = 3;
            // 
            // FrmTimKiemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTimKiemHD";
            this.Text = "FrmTimKiemHD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtgv_HoaDon;
        private TextBox txt_TimKiemHoaDon;
        private Label label1;
        private DataGridView dtgv_ChiTietHoaDon;
    }
}