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

namespace Shirt_Shop_Project.View
{
    public partial class FrmChatLieu : Form
    {
        public IQLchatLieuServices qLchatLieuServices;
        public chatLieu chatLieu;
        public FrmChatLieu()
        {
            InitializeComponent();
            qLchatLieuServices = new QLchatLieuServices();
            LoadData();
        }

        private void LoadData()
        {
            dgv_DulieuChatLieu.ColumnCount = 3;
            dgv_DulieuChatLieu.Columns[0].Name = "ID Chất liệu";
            //dgv_DulieuChatLieu.Columns[0].Visible = false;
            dgv_DulieuChatLieu.Columns[1].Name = "Tên chất liệu";
            dgv_DulieuChatLieu.Columns[2].Name = "Trạng thái";
            dgv_DulieuChatLieu.Rows.Clear();

            var listChatLieu = qLchatLieuServices.GetChatLieuFromDB();
            foreach (var item in listChatLieu)
            {
                dgv_DulieuChatLieu.Rows.Add(item.IDchatLieu, item.tenChatLieu,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtChatlieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chất liệu!");
            }
            else
            {
                var c = new chatLieu()
                {
                    tenChatLieu = txtChatlieu.Text,
                    trangThai = rbHoatdong.Checked,
                };
                qLchatLieuServices.addChatLieu(c);
                MessageBox.Show("Thêm chất liệu thành công!");
                resetForm();
            }
        }

        private void resetForm()
        {
            LoadData();
            txtChatlieu.Text = "";
            rbHoatdong.Checked = false;
            rbKhongHD.Checked = false;

        }

        private void dgv_DulieuChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLchatLieuServices.GetChatLieuFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_DulieuChatLieu.Rows[e.RowIndex];
            chatLieu = qLchatLieuServices.GetChatLieuFromDB().
                FirstOrDefault(x => x.IDchatLieu == Convert.ToInt32(row.Cells[0].Value));
            txtChatlieu.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Còn hàng")
            {
                rbHoatdong.Checked = true;
                rbKhongHD.Checked = false;
            }
            else
            {
                rbKhongHD.Checked = true;
                rbHoatdong.Checked = false;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtChatlieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập chất liệu!");
            }
            else if (chatLieu == null)
            {
                MessageBox.Show("Vui lòng chọn chất liệu cần sửa!");
            }
            else
            {
                chatLieu.tenChatLieu = txtChatlieu.Text;
                chatLieu.trangThai = rbHoatdong.Checked;
                qLchatLieuServices.UpdateChatLieu(chatLieu);
                MessageBox.Show("Sửa thành công!");
                resetForm();
            }
        }

        private void dgv_DulieuChatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
