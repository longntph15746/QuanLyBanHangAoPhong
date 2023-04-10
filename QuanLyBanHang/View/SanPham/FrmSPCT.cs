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

namespace FPoly_TShirt_Manage.View.SanPham
{
    public partial class FrmSPCT : Form
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
        public FrmSPCT()
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

        private void LoadData()
        {
            dtgv_DSsanPham.Rows.Clear();
            List<ViewHienThi1> listSPCT = _qlsanPhamChiTietServices.getViewSPCT();
            foreach (ViewHienThi1 item in listSPCT)
            {
                dtgv_DSsanPham.Rows.Add
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

        private void LoadSize()
        {
            var sz = _qlsizeServices.GetSizeFromDB().Where(x => x.trangThai == true);
            foreach (var item in sz)
            {
                cbb_size.Items.Add(item.tenSize);
            }
            cbb_size.SelectedIndex = 0;
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

        private void LoadChatLieu()
        {
            var cl = _qlchatLieuServices.GetChatLieuFromDB().Where(x => x.trangThai == true);
            foreach (var item in cl)
            {
                cbb_chatLieu.Items.Add(item.tenChatLieu);
            }
            cbb_chatLieu.SelectedIndex = 0;
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

        private void LoadSanPham()
        {
            var sp = _qlsanPhamServices.GetsanPhamFromDB().Where(x => x.trangThai == true);
            foreach (var item in sp)
            {
                cbb_sanPham.Items.Add(item.tenSanPham);
            }
            cbb_sanPham.SelectedIndex = 0;
        }

        private void ResetForm()
        {
            LoadData();
            tbt_maSP.Text = "";
            tbt_spct.Text = "";
            tbt_giaNhap.Text = "";
            tbt_giaBan.Text = "";
            tbt_soLuong.Text = "";
            cbb_sanPham.SelectedIndex = 0;
            cbb_nhaCC.SelectedIndex = 0;
            cbb_hangSX.SelectedIndex = 0;
            cbb_chatLieu.SelectedIndex = 0;
            cbb_mauSac.SelectedIndex = 0;
            cbb_size.SelectedIndex = 0;
            rb_con.Checked = false;
            rb_het.Checked = false;
            ptb_linkAnh.Image = Image.FromFile(@"D:\Kì 6_FPL\Dự án 1\Project\FPoly_TShirt_Manage\FPoly_TShirt_Manage\Resources\empty.jpg");
            imageLink = _sanphamCT.linkAnh;
        }
        private void ptb_linkAnh_Click(object sender, EventArgs e)
        {

        }

        private void btn_chonAnh_Click_1(object sender, EventArgs e)
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
                ptb_linkAnh.Image = Image.FromFile(imagePath);
                imageLink = imagePath;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            if (tbt_maSP.Text == "" || tbt_spct.Text == "" || tbt_giaNhap.Text == "" || tbt_giaBan.Text == "" || tbt_soLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                var spct = new sanPhamChiTiet()
                {
                    maSP = tbt_maSP.Text,
                    TenSP = tbt_spct.Text,
                    giaNhap = Convert.ToInt32(tbt_giaNhap.Text),
                    giaBan = Convert.ToInt32(tbt_giaBan.Text),
                    soLuong = Convert.ToInt32(tbt_soLuong.Text),
                    trangThai = rb_con.Checked,
                    IDSanPham = _qlsanPhamServices.GetsanPhamFromDB().FirstOrDefault(x => x.tenSanPham == cbb_sanPham.Text).IDsanPham,
                    IDNhaCungCap = _qlnhaCungCapServices.GetNhaCungCapFromDB().FirstOrDefault(x => x.tenNhaCungCap == cbb_nhaCC.Text).IDNhaCungCap,
                    IDHangSX = _qlhangSXServices.GetHangSXFromDB().FirstOrDefault(x => x.tenHangSX == cbb_hangSX.Text).IDHangSX,
                    IDchatLieu = _qlchatLieuServices.GetChatLieuFromDB().FirstOrDefault(x => x.tenChatLieu == cbb_chatLieu.Text).IDchatLieu,
                    IDMauSac = _qlmauSacServices.GetMauSacFromDB().FirstOrDefault(x => x.tenMau == cbb_mauSac.Text).IDMauSac,
                    IDSize = _qlsizeServices.GetSizeFromDB().FirstOrDefault(x => x.tenSize == cbb_size.Text).IDSize,
                    linkAnh = imageLink,
                };
                _qlsanPhamChiTietServices.addsanPham(spct);
                MessageBox.Show("Thêm thành công!");
                ResetForm();
            }
        }

        private void btn_capNhat_Click_1(object sender, EventArgs e)
        {
            if (tbt_maSP.Text == "" || tbt_spct.Text == "" || tbt_giaNhap.Text == "" || tbt_giaBan.Text == "" || tbt_soLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else if (_sanphamCT == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa thông tin!");
            }
            else
            {
                _sanphamCT.maSP = tbt_maSP.Text;
                _sanphamCT.TenSP = tbt_spct.Text;
                _sanphamCT.giaNhap = Convert.ToInt32(tbt_giaNhap.Text);
                _sanphamCT.giaBan = Convert.ToInt32(tbt_giaBan.Text);
                _sanphamCT.soLuong = Convert.ToInt32(tbt_soLuong.Text);
                _sanphamCT.trangThai = rb_con.Checked;
                _sanphamCT.IDSanPham = _qlsanPhamServices.GetsanPhamFromDB().FirstOrDefault(x => x.tenSanPham == cbb_sanPham.Text).IDsanPham;
                _sanphamCT.IDNhaCungCap = _qlnhaCungCapServices.GetNhaCungCapFromDB().FirstOrDefault(x => x.tenNhaCungCap == cbb_nhaCC.Text).IDNhaCungCap;
                _sanphamCT.IDHangSX = _qlhangSXServices.GetHangSXFromDB().FirstOrDefault(x => x.tenHangSX == cbb_hangSX.Text).IDHangSX;
                _sanphamCT.IDchatLieu = _qlchatLieuServices.GetChatLieuFromDB().FirstOrDefault(x => x.tenChatLieu == cbb_chatLieu.Text).IDchatLieu;
                _sanphamCT.IDMauSac = _qlmauSacServices.GetMauSacFromDB().FirstOrDefault(x => x.tenMau == cbb_mauSac.Text).IDMauSac;
                _sanphamCT.IDSize = _qlsizeServices.GetSizeFromDB().FirstOrDefault(x => x.tenSize == cbb_size.Text).IDSize;
                _sanphamCT.linkAnh = imageLink;
                _qlsanPhamChiTietServices.UpdateSanPham(_sanphamCT);
                MessageBox.Show("Sửa thành công!");
                ResetForm();
            }
        }

        private void dtgv_DSsanPham_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _qlsanPhamChiTietServices.GetSanPhamCTTFromDB().Count) return;
            DataGridViewRow r = new DataGridViewRow();
            r = dtgv_DSsanPham.Rows[e.RowIndex];
            _sanphamCT = _qlsanPhamChiTietServices.GetSanPhamCTTFromDB()
                .FirstOrDefault(x => x.IDSanPhamChiTiet == Convert.ToInt32(r.Cells[0].Value));
            if(_sanphamCT != null )
            {
                tbt_maSP.Text = r.Cells[1].Value.ToString();
                tbt_spct.Text = r.Cells[2].Value.ToString();
                tbt_giaNhap.Text = r.Cells[3].Value.ToString();
                tbt_giaBan.Text = r.Cells[4].Value.ToString();
                tbt_soLuong.Text = r.Cells[5].Value.ToString();
                cbb_sanPham.SelectedIndex = cbb_sanPham.FindStringExact(
                    _qlsanPhamServices.GetsanPhamFromDB().
                    FirstOrDefault(x => x.IDsanPham == _sanphamCT.IDSanPham).tenSanPham);
                cbb_nhaCC.SelectedIndex = cbb_nhaCC.FindStringExact(r.Cells[6].Value.ToString());
                cbb_hangSX.SelectedIndex = cbb_hangSX.FindStringExact(r.Cells[7].Value.ToString());
                cbb_chatLieu.SelectedIndex = cbb_chatLieu.FindStringExact(r.Cells[8].Value.ToString());
                cbb_mauSac.SelectedIndex = cbb_mauSac.FindStringExact(r.Cells[9].Value.ToString());
                cbb_size.SelectedIndex = cbb_size.FindStringExact(r.Cells[10].Value.ToString());
                try
                {
                    ptb_linkAnh.Image = Image.FromFile(_sanphamCT.linkAnh);
                }
                catch
                {
                    ptb_linkAnh.Image = Image.FromFile(@"D:\Kì 6_FPL\Dự án 1\Project\FPoly_TShirt_Manage\FPoly_TShirt_Manage\Resources\empty.jpg");
                }

                imageLink = _sanphamCT.linkAnh;
                if (r.Cells[11].Value.ToString() == "Còn hàng")
                {
                    rb_con.Checked = true;
                    rb_het.Checked = false;
                }
                else
                {
                    rb_con.Checked = false;
                    rb_het.Checked = true;
                }
            }
        }

        private void tbt_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (tbt_timKiem.Text == "")
            {
                LoadData();
            }
            else
            {
                dtgv_DSsanPham.Rows.Clear();
                List<ViewHienThi1> listSPCT = _qlsanPhamChiTietServices.getViewSPCT().Where(x => x.SanPhamChiTiets.TenSP.ToLower().Contains(tbt_timKiem.Text.ToLower())).ToList();
                foreach (ViewHienThi1 item in listSPCT)
                {
                    dtgv_DSsanPham.Rows.Add
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
    }
}
