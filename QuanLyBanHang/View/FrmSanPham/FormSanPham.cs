using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.Services;
using _2_BUS_QUANLY.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.View.FrmSanPham
{
    public partial class FormSanPham : Form
    {
        IQLnhaCungCapServices _qlnhaCungCapServices;
        IQLhangSXServices _qlhangSXServices;
        IQLchatLieuServices _qlchatLieuServices;
        IQLmauSacServices _qlmauSacServices;
        IQLsizeServices _qlsizeServices;
        IQLsanPhamServices _qlsanPhamServices;
        IQLsanPhamChiTietServices _qlsanPhamChiTietServices;
        public sanPhamChiTiet _sanphamCT;
        public string imageLink;
        public FormSanPham()
        {
            InitializeComponent();
            _qlnhaCungCapServices = new QLnhaCungCapServices();
            _qlhangSXServices = new QLhangSXServices();
            _qlchatLieuServices = new QLchatLieuServices();
            _qlmauSacServices = new QLmauSacServices();
            _qlsizeServices = new QLsizeServices();
            _qlsanPhamServices = new QLsanPhamServices();
            _qlsanPhamChiTietServices = new QLsanPhamChiTietServices();
            _sanphamCT = new sanPhamChiTiet();
            LoadNhaCungCap();
            LoadHangSX();
            LoadChatLieu();
            LoadMauSac();
            LoadSize();
            LoadSanPham();
            LoadData();
        }

        private void LoadSanPham()
        {
            var sp = _qlsanPhamServices.GetsanPhamFromDB().Where(x => x.trangThai == true);
            foreach (var item in sp)
            {
                cbb_tenSP.Items.Add(item.tenSanPham);
            }
            cbb_tenSP.SelectedIndex = 0;
        }

        private void LoadHangSX()
        {
            var hsx = _qlhangSXServices.GetHangSXFromDB().Where(x => x.trangThai == true);
            foreach (var item in hsx)
            {
                cbb_hangSX.Items.Add(item.tenHangSX);
            }
            cbb_hangSX.SelectedIndex = 0;
        }

        private void LoadNhaCungCap()
        {
            var ncc = _qlnhaCungCapServices.GetNhaCungCapFromDB().Where(x => x.trangThai == true);
            foreach (var item in ncc)
            {
                cbb_nhaCC.Items.Add(item.tenNhaCungCap);
            }
            cbb_nhaCC.SelectedIndex = 0;
        }

        private void LoadChatLieu()
        {
            var cl = _qlchatLieuServices.GetChatLieuFromDB().Where(x => x.trangThai == true);
            foreach (var item in cl)
            {
                cbb_chatLieu.Items.Add(item.tenChatLieu);
            }
            cbb_chatLieu.SelectedIndex = 0;
        }

        private void LoadMauSac()
        {
            var ms = _qlmauSacServices.GetMauSacFromDB().Where(x => x.trangThai == true);
            foreach (var item in ms)
            {
                cbb_mauSac.Items.Add(item.tenMau);
            }
            cbb_mauSac.SelectedIndex = 0;
        }

        private void LoadSize()
        {
            var sz = _qlsizeServices.GetSizeFromDB().Where(x => x.trangThai == true);
            foreach (var item in sz)
            {
                cbb_Size.Items.Add(item.tenSize);
            }
            cbb_Size.SelectedIndex = 0;
        }

        private void LoadData()
        {
            dtgv_SPCT.Rows.Clear();
            List<ViewHienThi1> listSPCT = _qlsanPhamChiTietServices.getViewSPCT();
            foreach (ViewHienThi1 item in listSPCT)
            {
                dtgv_SPCT.Rows.Add
                    (
                    item.SanPhamChiTiets.IDSanPhamChiTiet,
                    item.SanPhamChiTiets.maSP,
                    item.SanPhamChiTiets.TenSP,
                    item.SanPhamChiTiets.giaNhap,
                    item.SanPhamChiTiets.giaBan,
                    item.SanPhamChiTiets.soLuong,
                    item.nhaCungCaps.tenNhaCungCap,
                    item.hangSXs.tenHangSX,
                    item.chatLieus.tenChatLieu,
                    item.mauSacs.tenMau,
                    item.sizes.tenSize,
                    item.SanPhamChiTiets.trangThai == true ? "Còn hàng" : "Hết hàng"
                    );
            }
        }
        private void ResetForm()
        {
            LoadData();
            txt_MaSP.Text = "";
            txt_tenSPCT.Text = "";
            txt_giaNhap.Text = "";
            txt_giaBan.Text = "";
            txt_soLuong.Text = "";
            cbb_tenSP.SelectedIndex = 0;
            cbb_nhaCC.SelectedIndex = 0;
            cbb_hangSX.SelectedIndex = 0;
            cbb_chatLieu.SelectedIndex = 0;
            cbb_mauSac.SelectedIndex = 0;
            cbb_Size.SelectedIndex = 0;
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;
            ptb_Anh.Image = Image.FromFile(@"D:\Kì 6_FPL\Dự án 1\Project\QuanLyBanHang\QuanLyBanHang\Resources\empty.jpg");
            imageLink = _sanphamCT.linkAnh;
        }

        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Tất cả các file (*.*)|*.*|Ảnh (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";
            openFileDialog.FilterIndex = 2;

            // Nếu người dùng chọn OK trong OpenFileDialog
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file ảnh
                string imagePath = openFileDialog.FileName;

                // Hiển thị ảnh trong PictureBox
                ptb_Anh.Image = Image.FromFile(imagePath);
                imageLink = imagePath;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaSP.Text == "" || txt_tenSPCT.Text == "" || txt_giaNhap.Text == "" || txt_giaBan.Text == "" || txt_soLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                var spct = new sanPhamChiTiet()
                {
                    maSP = txt_MaSP.Text,
                    TenSP = txt_tenSPCT.Text,
                    giaNhap = Convert.ToInt32(txt_giaNhap.Text),
                    giaBan = Convert.ToInt32(txt_giaBan.Text),
                    soLuong = Convert.ToInt32(txt_soLuong.Text),
                    trangThai = Convert.ToInt32(txt_soLuong.Text) > 0? true : false,
                    IDSanPham = _qlsanPhamServices.GetsanPhamFromDB().FirstOrDefault(x => x.tenSanPham == cbb_tenSP.Text).IDsanPham,
                    IDNhaCungCap = _qlnhaCungCapServices.GetNhaCungCapFromDB().FirstOrDefault(x => x.tenNhaCungCap == cbb_nhaCC.Text).IDNhaCungCap,
                    IDHangSX = _qlhangSXServices.GetHangSXFromDB().FirstOrDefault(x => x.tenHangSX == cbb_hangSX.Text).IDHangSX,
                    IDchatLieu = _qlchatLieuServices.GetChatLieuFromDB().FirstOrDefault(x => x.tenChatLieu == cbb_chatLieu.Text).IDchatLieu,
                    IDMauSac = _qlmauSacServices.GetMauSacFromDB().FirstOrDefault(x => x.tenMau == cbb_mauSac.Text).IDMauSac,
                    IDSize = _qlsizeServices.GetSizeFromDB().FirstOrDefault(x => x.tenSize == cbb_Size.Text).IDSize,
                    linkAnh = imageLink,
                };
                _qlsanPhamChiTietServices.addsanPham(spct);
                MessageBox.Show("Thêm thành công!");
                ResetForm();
            }
        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {
            if (txt_MaSP.Text == "" || txt_tenSPCT.Text == "" || txt_giaNhap.Text == "" || txt_giaBan.Text == "" || txt_soLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else if (_sanphamCT == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa thông tin!");
            }
            else
            {
                _sanphamCT.maSP = txt_MaSP.Text;
                _sanphamCT.TenSP = txt_tenSPCT.Text;
                _sanphamCT.giaNhap = Convert.ToInt32(txt_giaNhap.Text);
                _sanphamCT.giaBan = Convert.ToInt32(txt_giaBan.Text);
                _sanphamCT.soLuong = Convert.ToInt32(txt_soLuong.Text);
                _sanphamCT.trangThai = Convert.ToInt32(txt_soLuong.Text) > 0 ? true : false;
                _sanphamCT.IDSanPham = _qlsanPhamServices.GetsanPhamFromDB().FirstOrDefault(x => x.tenSanPham == cbb_tenSP.Text).IDsanPham;
                _sanphamCT.IDNhaCungCap = _qlnhaCungCapServices.GetNhaCungCapFromDB().FirstOrDefault(x => x.tenNhaCungCap == cbb_nhaCC.Text).IDNhaCungCap;
                _sanphamCT.IDHangSX = _qlhangSXServices.GetHangSXFromDB().FirstOrDefault(x => x.tenHangSX == cbb_hangSX.Text).IDHangSX;
                _sanphamCT.IDchatLieu = _qlchatLieuServices.GetChatLieuFromDB().FirstOrDefault(x => x.tenChatLieu == cbb_chatLieu.Text).IDchatLieu;
                _sanphamCT.IDMauSac = _qlmauSacServices.GetMauSacFromDB().FirstOrDefault(x => x.tenMau == cbb_mauSac.Text).IDMauSac;
                _sanphamCT.IDSize = _qlsizeServices.GetSizeFromDB().FirstOrDefault(x => x.tenSize == cbb_Size.Text).IDSize;
                _sanphamCT.linkAnh = imageLink;
                _qlsanPhamChiTietServices.UpdateSanPham(_sanphamCT);
                MessageBox.Show("Sửa thành công!");
                ResetForm();
            }
        }

        private void dtgv_SPCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _qlsanPhamChiTietServices.GetSanPhamCTTFromDB().Count) return;
            DataGridViewRow r = new DataGridViewRow();
            r = dtgv_SPCT.Rows[e.RowIndex];
            _sanphamCT = _qlsanPhamChiTietServices.GetSanPhamCTTFromDB()
                .FirstOrDefault(x => x.IDSanPhamChiTiet == Convert.ToInt32(r.Cells[0].Value));
            if (_sanphamCT != null)
            {
                txt_MaSP.Text = r.Cells[1].Value.ToString();
                txt_tenSPCT.Text = r.Cells[2].Value.ToString();
                txt_giaNhap.Text = r.Cells[3].Value.ToString();
                txt_giaBan.Text = r.Cells[4].Value.ToString();
                txt_soLuong.Text = r.Cells[5].Value.ToString();
                cbb_tenSP.SelectedIndex = cbb_tenSP.FindStringExact(
                    _qlsanPhamServices.GetsanPhamFromDB().
                    FirstOrDefault(x => x.IDsanPham == _sanphamCT.IDSanPham).tenSanPham);
                cbb_nhaCC.SelectedIndex = cbb_nhaCC.FindStringExact(r.Cells[6].Value.ToString());
                cbb_hangSX.SelectedIndex = cbb_hangSX.FindStringExact(r.Cells[7].Value.ToString());
                cbb_chatLieu.SelectedIndex = cbb_chatLieu.FindStringExact(r.Cells[8].Value.ToString());
                cbb_mauSac.SelectedIndex = cbb_mauSac.FindStringExact(r.Cells[9].Value.ToString());
                cbb_Size.SelectedIndex = cbb_Size.FindStringExact(r.Cells[10].Value.ToString());
                try
                {
                    ptb_Anh.Image = Image.FromFile(_sanphamCT.linkAnh);
                }
                catch
                {
                    ptb_Anh.Image = Image.FromFile(@"D:\Kì 6_FPL\Dự án 1\Project\QuanLyBanHang\QuanLyBanHang\Resources\empty.jpg");
                }

                imageLink = _sanphamCT.linkAnh;
                if (r.Cells[11].Value.ToString() == "Còn hàng")
                {
                    rdb_conHang.Checked = true;
                    rdb_hetHang.Checked = false;
                }
                else
                {
                    rdb_conHang.Checked = false;
                    rdb_hetHang.Checked = true;
                }
            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timKiem.Text == "")
            {
                LoadData();
            }
            else
            {
                dtgv_SPCT.Rows.Clear();
                List<ViewHienThi1> listSPCT = _qlsanPhamChiTietServices.getViewSPCT().Where(x => x.SanPhamChiTiets.TenSP.ToLower().Contains(txt_timKiem.Text.ToLower())).ToList();
                foreach (ViewHienThi1 item in listSPCT)
                {
                    dtgv_SPCT.Rows.Add
                        (
                        item.SanPhamChiTiets.IDSanPhamChiTiet,
                        item.SanPhamChiTiets.maSP,
                        item.SanPhamChiTiets.TenSP,
                        item.SanPhamChiTiets.giaNhap,
                        item.SanPhamChiTiets.giaBan,
                        item.SanPhamChiTiets.soLuong,
                        item.nhaCungCaps.tenNhaCungCap,
                        item.hangSXs.tenHangSX,
                        item.chatLieus.tenChatLieu,
                        item.mauSacs.tenMau,
                        item.sizes.tenSize,
                        item.SanPhamChiTiets.trangThai == true ? "Còn hàng" : "Hết hàng"
                        );
                }
            }
        }

        private void btn_xuatEX_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
            worksheet.Name = "Thong ke";

            for (int i = 0; i < dtgv_SPCT.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1].Value = dtgv_SPCT.Columns[i].HeaderText;
            }
            for (int i = 0; i < dtgv_SPCT.Rows.Count; i++)
            {
                for (int j = 0; j < dtgv_SPCT.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1].Value = dtgv_SPCT.Rows[i].Cells[j].Value;
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
            }

            excel.Quit();
        }
    }
}
