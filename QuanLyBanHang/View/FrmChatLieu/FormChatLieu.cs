using _1_DAL_QUANLY.Models;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.View.FrmChatLieu
{
    public partial class FormChatLieu : Form
    {
        public IQLchatLieuServices qLchatlieuServices;
        public chatLieu chatlieu;
        public FormChatLieu()
        {
            InitializeComponent();
            qLchatlieuServices = new QLchatLieuServices();
            LoadData();
        }

        private void LoadData()
        {
            dtgv_ChatLieu.ColumnCount = 3;
            dtgv_ChatLieu.Columns[0].Name = "ID chất liệu";
            dtgv_ChatLieu.Columns[1].Name = "Tên chất liệu";
            dtgv_ChatLieu.Columns[2].Name = "Trạng thái";
            dtgv_ChatLieu.Rows.Clear();
            foreach (var x in qLchatlieuServices.GetChatLieuFromDB())
            {
                dtgv_ChatLieu.Rows.Add(x.IDchatLieu, x.tenChatLieu, x.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }

        private void resetForm()
        {
            LoadData();
            txt_Chatlieu.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_Chatlieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chất liệu");
            }
            else 
            {
                var c = new chatLieu()
                {
                    tenChatLieu = txt_Chatlieu.Text,
                    trangThai = rdb_conHang.Checked
                };
                qLchatlieuServices.addChatLieu(c);
                MessageBox.Show("Thêm chất liệu thành công");
                resetForm();
            }
        }
        
        private void txt_TenMauSac_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_Chatlieu.Text == "")
            {
                MessageBox.Show("Mời bạn nhập chất liệu");
            }
            else if (chatlieu == null)
            {
                MessageBox.Show("Mời bạn nhập chất liệu cần sửa");
            }
            else
            {
                chatlieu.tenChatLieu = txt_Chatlieu.Text;
                chatlieu.trangThai = rdb_conHang.Checked;
                qLchatlieuServices.UpdateChatLieu(chatlieu);
                MessageBox.Show("Sửa thành công");
                resetForm();
            }
        }

        private void dtgv_ChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLchatlieuServices.GetChatLieuFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_ChatLieu.Rows[e.RowIndex];
            chatlieu = qLchatlieuServices.GetChatLieuFromDB().FirstOrDefault(x => x.IDchatLieu == Convert.ToInt32(row.Cells[0].Value));
            txt_Chatlieu.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Còn Hàng")
            {
                rdb_conHang.Checked = true;
                rdb_hetHang.Checked = false;
            }
            else
            {
                rdb_hetHang.Checked = true;
                rdb_conHang.Checked = false;
            }
        }
    }
}
