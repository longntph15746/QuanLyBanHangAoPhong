using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.ViewModel;
using OfficeOpenXml;
using System.Data;

namespace QuanLyBanHang.View.FrmBanHang
{
    public partial class FormBanHang : Form
    {
        private IQLsanPhamServices _qlSanPham;
        private IQLhoaDonServices _qlhoaDon;
        private IQLhoaDonChiTietServices _qlhoaDonChiTiet;
        private IQLsanPhamChiTietServices _qlSanPhamCT;
        private IQLnhanVienServices _qLnhanVien;
        private IQLkhachHangServices _qlKhachHang;
        private IQLhangSXServices _qlhangSX;
        private IQLmauSacServices _qlMauSac;
        private IQLsizeServices _qlsize;
        public List<ViewHoaDonCT> _lstViewHoaDonCT;
        public int IdSPinGioHang;
        public hoaDon HoaDon;
        public int pID;
        public khachHang KH;
        public int oID;
        public FormBanHang()
        {
            InitializeComponent();
            _qlMauSac = new QLmauSacServices();
            _qlsize = new QLsizeServices();
            _qlhangSX = new QLhangSXServices();
            _qlSanPham = new QLsanPhamServices();
            _qlSanPhamCT = new QLsanPhamChiTietServices();
            _qlhoaDon = new QLhoaDonServices();
            _qlhoaDonChiTiet = new QLhoaDonChiTietServices();
            _qlKhachHang = new QLkhachHangServices();
            _qLnhanVien = new QLnhanVienServices();
            _lstViewHoaDonCT = new List<ViewHoaDonCT>();
            KH = new khachHang();
            oID = -1;
            LoadSanPham();
            LoadHangSX();
            LoadMauSac();
            LoadSize();
            LoadKhachHang();
            loadHDcho();
        }

        private void LoadMauSac()
        {
            cbb_mauSac.Items.Clear();
            cbb_mauSac.Items.Add("Tất cả");
            var ms = _qlMauSac.GetMauSacFromDB().Where(x => x.trangThai == true);
            foreach (var item in ms)
            {
                cbb_mauSac.Items.Add(item.tenMau);
            }
            cbb_mauSac.SelectedIndex = 0;
        }

        private void LoadHangSX()
        {
            cbb_hangSX.Items.Clear();
            cbb_hangSX.Items.Add("Tất cả");
            var hsx = _qlhangSX.GetHangSXFromDB().Where(x => x.trangThai == true);
            foreach (var item in hsx)
            {
                cbb_hangSX.Items.Add(item.tenHangSX);
            }
            cbb_hangSX.SelectedIndex = 0;
        }

        private void LoadSize()
        {
            cbb_size.Items.Clear();
            cbb_size.Items.Add("Tất cả");
            var sz = _qlsize.GetSizeFromDB().Where(x => x.trangThai == true);
            foreach (var item in sz)
            {
                cbb_size.Items.Add(item.tenSize);
            }
            cbb_size.SelectedIndex = 0;
        }

        private void LoadSanPham()
        {
            dtgv_DSSP.ColumnCount = 8;
            dtgv_DSSP.Columns[0].Name = "ID";
            dtgv_DSSP.Columns[0].Visible = false;
            dtgv_DSSP.Columns[1].Name = "Mã SP";
            dtgv_DSSP.Columns[2].Name = "Tên SP";
            dtgv_DSSP.Columns[3].Name = "Hãng SX";
            dtgv_DSSP.Columns[4].Name = "Màu sắc";
            dtgv_DSSP.Columns[5].Name = "Size";
            dtgv_DSSP.Columns[6].Name = "Giá bán";
            dtgv_DSSP.Columns[7].Name = "SL tồn";

            dtgv_DSSP.Rows.Clear();
            foreach (var item in _qlSanPhamCT.getViewSPCT().Where(x => x.SanPhamChiTiets.soLuong > 0))
            {
                dtgv_DSSP.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP, item.SanPhamChiTiets.TenSP, item.hangSXs.tenHangSX, item.mauSacs.tenMau, item.sizes.tenSize, item.SanPhamChiTiets.giaBan, item.SanPhamChiTiets.soLuong);
            }
        }

        private void LoadKhachHang()
        {
            cbb_KhachHang.Items.Clear();
            foreach (var item in _qlKhachHang.GetkhachHangFromDB())
            {
                cbb_KhachHang.Items.Add(item.TenKH);
            }
        }
        private void dtgv_DSSP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _qlSanPhamCT.GetSanPhamCTTFromDB().Count) return;
            DataGridViewRow r = new DataGridViewRow();
            r = dtgv_DSSP.Rows[e.RowIndex];
            var spct = _qlSanPhamCT.GetSanPhamCTTFromDB().FirstOrDefault(x => x.IDSanPhamChiTiet == Convert.ToInt32(r.Cells[0].Value));
            if (spct != null)
            {
                themGioHang(spct.IDSanPhamChiTiet);
            }
        }
        public void timKiemSPCT()
        {
            var listSPCT = _qlSanPhamCT.getViewSPCT().Where(x => x.SanPhamChiTiets.soLuong > 0);
            if (cbb_size.SelectedIndex != 0)
            {
                listSPCT = listSPCT.Where(x => x.sizes.tenSize == cbb_size.Text);
            }
            if (cbb_mauSac.SelectedIndex != 0)
            {
                listSPCT = listSPCT.Where(x => x.mauSacs.tenMau == cbb_mauSac.Text);
            }
            if (cbb_hangSX.SelectedIndex != 0)
            {
                listSPCT = listSPCT.Where(x => x.hangSXs.tenHangSX == cbb_hangSX.Text);
            }
            if (txt_TimKiem.Text != "")
            {
                listSPCT = listSPCT.Where(x => x.SanPhamChiTiets.TenSP.ToLower().Contains(txt_TimKiem.Text.ToLower()));
            }
            dtgv_DSSP.Rows.Clear();
            foreach (var item in listSPCT)
            {
                dtgv_DSSP.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP, item.SanPhamChiTiets.TenSP, item.hangSXs.tenHangSX, item.mauSacs.tenMau, item.sizes.tenSize, item.SanPhamChiTiets.giaBan, item.SanPhamChiTiets.soLuong);
            }
        }

        private void cbb_size_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            timKiemSPCT();
        }
        private void cbb_mauSac_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            timKiemSPCT();
        }
        private void cbb_hangSX_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            timKiemSPCT();
        }
        private void txt_TimKiem_TextChanged_1(object sender, EventArgs e)
        {
            timKiemSPCT();
        }

        private void themGioHang(int ID)
        {
            var p = _qlSanPhamCT.getViewSPCT().FirstOrDefault(x => x.SanPhamChiTiets.IDSanPhamChiTiet == ID);
            var gioHang = _lstViewHoaDonCT.FirstOrDefault(x => x.ID == p.SanPhamChiTiets.IDSanPhamChiTiet);
            if (gioHang == null)
            {
                ViewHoaDonCT gioHangChiTiet = new ViewHoaDonCT()
                {
                    ID = p.SanPhamChiTiets.IDSanPhamChiTiet,
                    maSanPham = p.SanPhamChiTiets.maSP,
                    tenSanPham = p.SanPhamChiTiets.TenSP,
                    donGia = p.SanPhamChiTiets.giaBan,
                    soLuong = 1,
                };
                _lstViewHoaDonCT.Add(gioHangChiTiet);
            }
            else
            {
                if (gioHang.soLuong == p.SanPhamChiTiets.soLuong)
                {
                    MessageBox.Show("Bạn đã mua hết số lượng hàng trong kho!");
                }
                else
                {
                    gioHang.soLuong++;
                }
            }
            loadGioHang();
        }
        private void loadGioHang()
        {
            dtgv_gioHang.ColumnCount = 5;
            dtgv_gioHang.Columns[0].Name = "ID";
            dtgv_gioHang.Columns[0].Visible = false;
            dtgv_gioHang.Columns[1].Name = "Mã SP";
            dtgv_gioHang.Columns[2].Name = "Tên SP";
            dtgv_gioHang.Columns[3].Name = "Số lượng";
            dtgv_gioHang.Columns[4].Name = "Đơn giá";

            dtgv_gioHang.Rows.Clear();
            foreach (var item in _lstViewHoaDonCT)
            {
                dtgv_gioHang.Rows.Add(item.ID, item.maSanPham, item.tenSanPham, item.soLuong, item.donGia);
            }
        }
        private void dtgv_gioHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _lstViewHoaDonCT.Count) return;
            DataGridViewRow r = dtgv_gioHang.Rows[e.RowIndex];
            IdSPinGioHang = Convert.ToInt32(r.Cells[0].Value);
        }
        private void btn_XoaSP_Click_1(object sender, EventArgs e)
        {
            if (_lstViewHoaDonCT.Any())
            {
                if (_lstViewHoaDonCT.Find(x => x.ID == IdSPinGioHang) != null)
                {
                    var item = _lstViewHoaDonCT.FirstOrDefault(x => x.ID == IdSPinGioHang);
                    _lstViewHoaDonCT.Remove(item);
                    loadGioHang();
                }
                else
                {
                    MessageBox.Show("Hãy chọn sản phẩm trong giỏ hàng cần xóa!");
                }
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng!");
            }
        }
        private void btn_XoaGH_Click_1(object sender, EventArgs e)
        {
            if (_lstViewHoaDonCT.Any())
            {
                _lstViewHoaDonCT = new List<ViewHoaDonCT>();
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng!");
            }
        }
        private void cbb_KhachHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbb_KhachHang.SelectedIndex == -1) { return; }
            var kh = _qlKhachHang.GetkhachHangFromDB()[cbb_KhachHang.SelectedIndex];
            if (kh.gioiTinh == true)
            {
                rdb_nam.Checked = false;
                rdb_nu.Checked = true;
            }
            else
            {
                rdb_nu.Checked = false;
                rdb_nam.Checked = true;
            }
            txt_SDT.Text = kh.SDT_KH;
            lbl_diemTichLuy.Text = kh.diemTichluy.ToString();
        }
        private void cbb_KhachHang_TextChanged_1(object sender, EventArgs e)
        {
            lbl_diemTichLuy.Text = "...";
        }
        private void btn_ThemKH_Click_1(object sender, EventArgs e)
        {
            if (txt_SDT.Text == "" || cbb_KhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            var listKH = _qlKhachHang.GetkhachHangFromDB();
            foreach (var item in listKH)
            {
                if (txt_SDT.Text == item.SDT_KH)
                {
                    MessageBox.Show("SĐT đã được đăng ký! Vui lòng sử dụng SĐT khác!");
                    return;
                }
            }
            var kh = new khachHang();
            kh.SDT_KH = txt_SDT.Text;
            kh.TenKH = cbb_KhachHang.Text;
            kh.gioiTinh = rdb_nu.Checked;
            kh.diaChi = "";
            kh.trangThai = true;
            kh.diemTichluy = 0;
            _qlKhachHang.addkhachHang(kh);
            MessageBox.Show("Thêm khách hàng mới thành công!");
            txt_SDT.Text = "";
            cbb_KhachHang.Text = "";
            lbl_diemTichLuy.Text = "...";
            rdb_nu.Checked = false;
            rdb_nam.Checked = false;
            LoadKhachHang();
        }
        private void btn_TaoHD_Click_1(object sender, EventArgs e)
        {
            if (cbb_KhachHang.Text == "")
            {
                MessageBox.Show("Hãy chọn khách hàng!");
                return;
            }
            if (_lstViewHoaDonCT.Any())
            {
                var existHD = _qlhoaDon.GetHoaDonFromDB().Where(x => x.trangThai == false).FirstOrDefault(x => x.SDT_KH == txt_SDT.Text);
                if (existHD != null)
                {
                    foreach (var item in _lstViewHoaDonCT)
                    {
                        var existHDCT = _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == existHD.IDHoaDon).FirstOrDefault(x => x.IDSanPham == item.ID);
                        if (existHDCT != null)
                        {
                            existHDCT.Soluong += item.soLuong;
                            _qlhoaDonChiTiet.UpdateHoaDonChiTiet(existHDCT);
                        }
                        else
                        {
                            var hdct = new hoaDonChiTiet()
                            {
                                IDHoaDon = existHD.IDHoaDon,
                                IDSanPham = item.ID,
                                Soluong = item.soLuong,
                                donGia = item.donGia,
                                Trangthai = true,
                            };
                            _qlhoaDonChiTiet.addHoaDonChiTiet(hdct);
                        }
                    }
                    MessageBox.Show("Đã gộp với hóa đơn chờ có sẵn!");
                }
                else
                {
                    var hoaDon = new hoaDon()
                    {
                        IDNhanVien = _qLnhanVien.GetNhanVienFromDB().FirstOrDefault(x => x.chucVus.tenCV == "Quản lý").nhanViens.IDNhanVien,
                        SDT_KH = txt_SDT.Text,
                        ngayBan = DateTime.Now,
                        tongTien = 0,
                        ghiChu = "",
                        trangThai = false,
                    };
                    _qlhoaDon.addHoaDon(hoaDon);
                    foreach (var item in _lstViewHoaDonCT)
                    {
                        var hdct = new hoaDonChiTiet()
                        {
                            IDHoaDon = hoaDon.IDHoaDon,
                            IDSanPham = item.ID,
                            Soluong = item.soLuong,
                            donGia = item.donGia,
                            Trangthai = true,
                        };
                        _qlhoaDonChiTiet.addHoaDonChiTiet(hdct);
                    }
                    MessageBox.Show("Tạo hóa đơn thành công!");
                }


                _lstViewHoaDonCT = new List<ViewHoaDonCT>();
                IdSPinGioHang = -1;
                loadGioHang();
                loadHDcho();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong hóa đơn!");
            }
        }
        public void ClearForm()
        {
            // Clear thông tin nhân viên
            cbb_KhachHang.SelectedIndex = -1;
            rdb_nam.Checked = false;
            rdb_nu.Checked = false;
            txt_SDT.Text = "";
            lbl_diemTichLuy.Text = "...";

            // Clear hóa đơn
            txt_MaHD.Text = "";
            txt_giamGia.Text = "";
            txt_TongTien.Text = "";
            txt_khachDua.Text = "";
            txt_TienThua.Text = "";
            txt_GhiChu.Text = "";
        }

        public void loadHDcho()
        {
            dtgv_HoadonCho.ColumnCount = 5;
            dtgv_HoadonCho.Columns[0].Name = "ID hóa đơn";
            dtgv_HoadonCho.Columns[1].Name = "SĐT khách hàng";
            dtgv_HoadonCho.Columns[1].Visible = false;
            dtgv_HoadonCho.Columns[2].Name = "Tên khách hàng";
            dtgv_HoadonCho.Columns[3].Name = "ID nhân viên";
            dtgv_HoadonCho.Columns[3].Visible = false;
            dtgv_HoadonCho.Columns[4].Name = "Thời gian tạo";

            dtgv_HoadonCho.Rows.Clear();
            var hdCho = _qlhoaDon.getViewhoaDon().Where(x => x.hoaDons.trangThai == false);
            foreach (var item in hdCho)
            {
                dtgv_HoadonCho.Rows.Add(item.hoaDons.IDHoaDon, item.hoaDons.SDT_KH, item.khachHangs.TenKH, item.nhanViens.IDNhanVien, item.hoaDons.ngayBan);
            }
        }
        private void dtgv_HoadonCho_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _qlhoaDon.GetHoaDonFromDB().Where(x => x.trangThai == false).Count()) return;
            DataGridViewRow r = dtgv_HoadonCho.Rows[e.RowIndex];
            HoaDon = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == Convert.ToInt32(r.Cells[0].Value.ToString()));
            if (HoaDon == null) return;
            cbb_KhachHang.SelectedIndex = cbb_KhachHang.FindStringExact(_qlKhachHang.GetkhachHangFromDB()
                .FirstOrDefault(x => x.SDT_KH == r.Cells[1].Value.ToString()).TenKH);
            txt_MaHD.Text = HoaDon.IDHoaDon.ToString();
            float tongTien = 0;
            foreach (var item in _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == HoaDon.IDHoaDon))
            {
                tongTien += item.donGia * item.Soluong;
            }
            txt_TongTien.Text = tongTien.ToString();
            txt_khachDua.Text = "0";
            txt_giamGia.Text = "0";
        }
        private void txt_giamGia_TextChanged_1(object sender, EventArgs e)
        {
            if (HoaDon == null) return;
            if (txt_giamGia.Text == "")
            {
                txt_giamGia.Text = "0";
            }

            foreach (char item in txt_giamGia.Text)
            {
                if (!char.IsNumber(item))
                {
                    MessageBox.Show("Nhập lỗi! Chỉ được phép nhập số!");
                    txt_giamGia.Text = "";
                    return;
                }
            }
            if (Convert.ToInt32(txt_giamGia.Text) > _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == HoaDon.SDT_KH).diemTichluy)
            {
                MessageBox.Show("Không đủ điểm tích lũy để sử dụng thêm!");
                txt_giamGia.Text = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == HoaDon.SDT_KH).diemTichluy.ToString();
            }
            float tongTien = 0;
            foreach (var item in _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == HoaDon.IDHoaDon))
            {
                tongTien += item.donGia * item.Soluong;
            }
            if (Convert.ToDecimal(tongTien) - Convert.ToDecimal(txt_giamGia.Text) * 1000 < 0)
            {
                txt_TongTien.Text = "0";
            }
            else
            {
                txt_TongTien.Text = (Convert.ToDecimal(tongTien) - Convert.ToDecimal(txt_giamGia.Text) * 1000).ToString();
            }
            int tienThua = Convert.ToInt32(txt_khachDua.Text) - Convert.ToInt32(txt_TongTien.Text);
            if (tienThua < 0)
            {
                txt_TienThua.Text = "";
            }
            else
            {
                txt_TienThua.Text = tienThua.ToString();
            }
        }
        private void txt_khachDua_TextChanged_1(object sender, EventArgs e)
        {
            if (HoaDon == null) return;
            if (txt_khachDua.Text == "")
            {
                txt_khachDua.Text = "0";
            }
            if (txt_TongTien.Text == "")
            {
                txt_TongTien.Text = "0";
            }
            foreach (char item in txt_khachDua.Text)
            {
                if (!char.IsNumber(item))
                {
                    MessageBox.Show("Nhập lỗi! Chỉ được phép nhập số!");
                    txt_khachDua.Text = "";
                    return;
                }
            }
            int tienThua = Convert.ToInt32(txt_khachDua.Text) - Convert.ToInt32(txt_TongTien.Text);
            if (tienThua < 0)
            {
                txt_TienThua.Text = "";
            }
            else
            {
                txt_TienThua.Text = tienThua.ToString();
            }
        }
        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (HoaDon == null)
            {
                MessageBox.Show("Hãy chọn hóa đơn để thanh toán!");
            }
            else if (txt_TienThua.Text == "")
            {
                MessageBox.Show("Khách chưa trả đủ tiền!");
            }
            else
            {
                // Trừ số lượng sp đã được mua
                foreach (var item in _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == HoaDon.IDHoaDon))
                {
                    var sp = _qlSanPhamCT.GetSanPhamCTTFromDB().FirstOrDefault(x => x.IDSanPhamChiTiet == item.IDSanPham);
                    sp.soLuong -= item.Soluong;
                    _qlSanPhamCT.UpdateSanPham(sp);
                }
                // Trừ số điểm tích lũy đã dùng + điểm tích lũy cộng thêm
                var kh = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == txt_SDT.Text);
                var diemDaDung = Convert.ToInt32(txt_giamGia.Text);
                var listHDCT = _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == HoaDon.IDHoaDon);
                int tongTien = 0;
                foreach (var item in listHDCT)
                {
                    tongTien += Convert.ToInt32(item.donGia) * item.Soluong;
                }
                var diemCongThem = tongTien / 10000;
                kh.diemTichluy = kh.diemTichluy - diemDaDung + diemCongThem;
                _qlKhachHang.UpdateKhachHang(kh);
                HoaDon.trangThai = true;
                HoaDon.ngayBan = DateTime.Now;
                HoaDon.tongTien = Convert.ToInt32(txt_TongTien.Text);
                HoaDon.ghiChu = txt_GhiChu.Text;
                _qlhoaDon.UpdateHoaDon(HoaDon);
                oID = HoaDon.IDHoaDon;
                loadHDcho();
                LoadSanPham();
                ClearForm();
                HoaDon = null;
                MessageBox.Show($"Thanh toán thành công, điểm tích lũy hiện tại của quý khách là {kh.diemTichluy}!");
                InHoaDon();
            }
        }
        private void btn_thanhtoanngay_Click(object sender, EventArgs e)
        {
            if (cbb_KhachHang.Text == "")
            {
                MessageBox.Show("Hãy chọn khách hàng!");
                return;
            };
            float tongTien = 0;
            foreach (var item in _lstViewHoaDonCT)
            {
                tongTien += item.donGia * item.soLuong;
            }
            txt_TongTien.Text = tongTien.ToString();
            txt_khachDua.Text = "0";
            txt_giamGia.Text = "0";

            if (_lstViewHoaDonCT.Any())
            {
                var hoaDon = new hoaDon()
                {
                    IDNhanVien = _qLnhanVien.GetNhanVienFromDB().FirstOrDefault(x => x.nhanViens.email == Properties.Settings.Default.email).nhanViens.IDNhanVien,
                    SDT_KH = txt_SDT.Text,
                    ngayBan = DateTime.Now,
                    tongTien = tongTien,
                    ghiChu = "",
                    trangThai = true,
                };
                _qlhoaDon.addHoaDon(hoaDon);
                foreach (var item in _lstViewHoaDonCT)
                {
                    var hdct = new hoaDonChiTiet()
                    {
                        IDHoaDon = hoaDon.IDHoaDon,
                        IDSanPham = item.ID,
                        Soluong = item.soLuong,
                        donGia = item.donGia,
                        Trangthai = true,
                    };
                    _qlhoaDonChiTiet.addHoaDonChiTiet(hdct);
                }
                txt_MaHD.Text = hoaDon.IDHoaDon.ToString();
                _lstViewHoaDonCT = new List<ViewHoaDonCT>();
                IdSPinGioHang = -1;
                HoaDon = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == hoaDon.IDHoaDon);
                loadGioHang();
                loadHDcho();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong hóa đơn!");
            }
        }
        private void InHoaDon()
        {
            ppdhd.Document = pdhd;
            ppdhd.ShowDialog();
        }
        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                try
                {
                    senderexcel(filePath);
                    MessageBox.Show("Xuất File Excel Thành công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Xuất File Excel không  Thành công" + ex.Message);
                }
            }
            //InHoaDon();
        }

        private void senderexcel(string path)
        {
            using (ExcelPackage p = new ExcelPackage())
            {
                // đặt tên người tạo file
                p.Workbook.Properties.Author = "";

                // đặt tiêu đề cho file
                p.Workbook.Properties.Title = "Báo cáo thống kê";

                //Tạo một sheet để làm việc trên đó
                p.Workbook.Worksheets.Add("sheet");

                // lấy sheet vừa add ra để thao tác
                ExcelWorksheet ws = p.Workbook.Worksheets[1];

                // đặt tên cho sheet
                ws.Name = "sheet";
                // fontsize mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 11;
                // font family mặc định cho cả sheet
                ws.Cells.Style.Font.Name = "Calibri";

                for (int i = 0; i < dtgv_HoadonCho.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1].Value = dtgv_HoadonCho.Columns[i].HeaderText;
                }
                for (int i = 0; i < dtgv_HoadonCho.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_HoadonCho.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1].Value = dtgv_HoadonCho.Rows[i].Cells[j].Value;
                    }
                }
                //Lưu file lại
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(path, bin);
            };
        }
        private void pdhd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var hd = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(c => c.IDHoaDon == oID);
            var kh = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(c => c.SDT_KH == hd.SDT_KH);
            var nv = _qLnhanVien.GetNhanVienFromDB().FirstOrDefault(c => c.nhanViens.IDNhanVien == hd.IDNhanVien);

            //lấy chiều rộng của giấy
            var w = pdhd.DefaultPageSettings.PaperSize.Width;
            //
            e.Graphics.DrawString("FPOLY TSHIRT", new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, 20));

            e.Graphics.DrawString(String.Format("Mã Hóa Đơn : {0}", hd.IDHoaDon), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, 20));
            e.Graphics.DrawString(String.Format(" {0}", DateTime.Now.ToString()), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, 45));

            //
            Pen pn = new Pen(Color.Black, 1);

            var y = 70;
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(pn, p1, p2);
            y += 10;
            e.Graphics.DrawString(String.Format("HÓA ĐƠN BÁN HÀNG"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 - 100, y));
            y += 20;
            e.Graphics.DrawString(String.Format("Ngày Mua : {0}", hd.ngayBan), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y));
            e.Graphics.DrawString(String.Format("Tên Khách Hàng : {0}", kh.TenKH), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y));
            e.Graphics.DrawString(String.Format("SDT : {0}", kh.SDT_KH), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y + 30));
            y += 70;
            e.Graphics.DrawString(String.Format("STT"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y));
            e.Graphics.DrawString(String.Format("Tên Sản Phẩm"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, y));
            e.Graphics.DrawString(String.Format("Số Lượng"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2, y));
            e.Graphics.DrawString(String.Format("Đơn Giá"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 100, y));
            e.Graphics.DrawString(String.Format("Thành Tiền"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y));
            /////
            ///
            int stt = 1;
            y += 20;

            foreach (var x in _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(c => c.IDHoaDon == oID))
            {
                var a = _qlSanPhamCT.GetSanPhamCTTFromDB().FirstOrDefault(p => p.IDSanPhamChiTiet == x.IDSanPham).TenSP;
                var thanhtien = x.Soluong * x.donGia;
                e.Graphics.DrawString(String.Format("{0}", stt++), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y));
                e.Graphics.DrawString(String.Format("{0}", a), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, y));
                e.Graphics.DrawString(String.Format("{0}", x.Soluong), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2, y));
                e.Graphics.DrawString(String.Format("{0}", x.donGia), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 100, y));
                e.Graphics.DrawString(String.Format("{0}", thanhtien), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y));
                y += 20;
            }
            y += 20;
            e.Graphics.DrawLine(pn, p1, p2);
            y += 20;
            e.Graphics.DrawString(String.Format("Tổng Tiền : {0}", hd.tongTien), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y));
        }
    }
}
