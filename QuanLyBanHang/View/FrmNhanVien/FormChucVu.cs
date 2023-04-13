using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.View.FrmNhanVien
{
    public partial class FormChucVu : Form
    {
        private IQLchucVuServices qLchucVuServices;
        public chucVu _chucVu;
        public FormChucVu()
        {
            _chucVu = new chucVu();
            InitializeComponent();
            qLchucVuServices = new QLchucVuServices();
        }
        public void load()
        {
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 2;
            dtg_show.Columns[0].Name = "Mã chức vụ";
            dtg_show.Columns[1].Name = "Tên chức vụ";
            foreach (var item in qLchucVuServices.GetchucVuFromDB())
            {
                dtg_show.Rows.Add(item.IDChucVu, item.tenCV);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //chucVu accchucvu = qLchucVuServices.GetchucVuFromDB().FirstOrDefault(p => p.maChucVu == tb_macv.Text);
            DialogResult dialogResult = MessageBox.Show("bạn có muốn thêm không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (tb_tencv.Text == "")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            }
            //else if (accchucvu != null)
            //{
            //    MessageBox.Show("Mã chức vụ đã tồn tại");
            //    tb_macv.Text = "";
            //}
            else if (dialogResult == DialogResult.Yes)
            {
                chucVu chucVu = new chucVu();
                {
                    chucVu.tenCV = tb_tencv.Text;
                }
                qLchucVuServices.addChucVu(chucVu);
                load();
            }
            else
            {
                MessageBox.Show("bạn đã hủy thêm");
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_chucVu == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
            }
            else
            {
                if (_chucVu.tenCV == tb_tencv.Text || (_chucVu.tenCV != tb_tencv.Text && qLchucVuServices.GetchucVuFromDB().FirstOrDefault(x => x.tenCV == tb_tencv.Text) == null))
                {
                    _chucVu.tenCV = tb_tencv.Text;
                    qLchucVuServices.UpdateChucVu(_chucVu);
                    MessageBox.Show("Cập nhật thành công");
                    load();
                    tb_tencv.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên chức vụ đã tồn tại");
                }
            }
        }
        public void Rs()
        {
            tb_tencv.Text = "";
        }

        private void FormChucVu_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
