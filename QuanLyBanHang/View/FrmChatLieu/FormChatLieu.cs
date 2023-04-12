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
        public IQLchatLieuServices qLchatLieuServices;
        public chatLieu chatLieu;
        public FormChatLieu()
        {
            InitializeComponent();
            qLchatLieuServices = new QLchatLieuServices();
            LoadData();
        }
        private void LoadData()
        {
            dtgv_ChatLieu.ColumnCount = 3;
            dtgv_ChatLieu.Columns[0].Name = "ID Chất liệu";
            //dgv_DulieuChatLieu.Columns[0].Visible = false;
            dtgv_ChatLieu.Columns[1].Name = "Tên chất liệu";
            dtgv_ChatLieu.Columns[2].Name = "Trạng thái";
            dtgv_ChatLieu.Rows.Clear();

            var listChatLieu = qLchatLieuServices.GetChatLieuFromDB();
            foreach (var item in listChatLieu)
            {
                dtgv_ChatLieu.Rows.Add(item.IDchatLieu, item.tenChatLieu,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenMauSac.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chất liệu!");
            }
            else
            {
                var c = new chatLieu()
                {
                    tenChatLieu = txt_TenMauSac.Text,
                    trangThai = rdb_conHang.Checked,
                };
                qLchatLieuServices.addChatLieu(c);
                MessageBox.Show("Thêm chất liệu thành công!");
                resetForm();
            }
        }

        private void resetForm()
        {
            LoadData();
            txt_TenMauSac.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenMauSac.Text == "")
            {
                MessageBox.Show("Vui lòng nhập chất liệu!");
            }
            else if (chatLieu == null)
            {
                MessageBox.Show("Vui lòng chọn chất liệu cần sửa!");
            }
            else
            {
                chatLieu.tenChatLieu = txt_TenMauSac.Text;
                chatLieu.trangThai = rdb_conHang.Checked;
                qLchatLieuServices.UpdateChatLieu(chatLieu);
                MessageBox.Show("Sửa thành công!");
                resetForm();
            }
        }

        private void dtgv_ChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLchatLieuServices.GetChatLieuFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_ChatLieu.Rows[e.RowIndex];
            chatLieu = qLchatLieuServices.GetChatLieuFromDB().
                FirstOrDefault(x => x.IDchatLieu == Convert.ToInt32(row.Cells[0].Value));
            txt_TenMauSac.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Còn hàng")
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
