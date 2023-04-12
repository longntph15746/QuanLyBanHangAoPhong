using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
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

namespace QuanLyBanHang.View.FrmHoaDon
{
    public partial class FormDanhMucHD : Form
    {
        IQLhoaDonServices _HDservices;
        IQLnhanVienServices _NHanVienServices;
        IQLkhachHangServices _KHSer;
        List<hoaDon> _lstOrder;
        List<ViewHoaDonCT> _lstHDCT;
        IQLhoaDonChiTietServices _HDCTser;
        private hoaDon _HD;
        private IQLsanPhamChiTietServices _qLsanPhamChiTiet;
        int _idHD;
        public FormDanhMucHD()
        {
            InitializeComponent();
            _HDservices = new QLhoaDonServices();
            _NHanVienServices = new QLnhanVienServices();
            _KHSer = new QLkhachHangServices();
            _HDCTser = new QLhoaDonChiTietServices();
            _lstOrder = _HDservices.GetHoaDonFromDB();
            _lstHDCT = new List<ViewHoaDonCT>();
            _HD = new hoaDon();
            _qLsanPhamChiTiet = new QLsanPhamChiTietServices();
            LoadHD();
        }

        private void LoadHD()
        {
            dtgv_HoaDon.Rows.Clear();
            foreach (var i in _HDservices.GetHoaDonFromDB())
            {
                dtgv_HoaDon.Rows.Add(i.IDHoaDon, i.IDNhanVien, i.SDT_KH, i.tongTien, i.ngayBan, i.ghiChu, i.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }
        public void LoadHDCT(int maHoaDon)
        {
            _idHD = maHoaDon;
            dtgv_ChiTietHoaDon.Rows.Clear();
            foreach (var i in _HDCTser.getViewHoaDonChiTiet(maHoaDon))
            {
                dtgv_ChiTietHoaDon.Rows.Add(i.ID, i.maSanPham, i.tenSanPham, i.soLuong, i.donGia);
            }
        }

        private void dtgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_HoaDon.Rows[e.RowIndex];
                LoadHDCT(Convert.ToInt32(r.Cells[0].Value));
                txt_MaHD.Text = r.Cells[0].Value.ToString();
                txt_MaNV.Text = r.Cells[1].Value.ToString();
                txt_SDTKH.Text = r.Cells[2].Value.ToString();
                txt_TongTien.Text = r.Cells[3].Value.ToString();
                dtp_ngayBan.Text = r.Cells[4].Value.ToString();
                txt_ghiChu.Text = r.Cells[5].Value.ToString();
                rdb_ChuaThanhToan.Checked = r.Cells[6].Value.ToString() == "Chưa thanh toán" ? true : false;
                rdb_DaThanhToan.Checked = r.Cells[6].Value.ToString() == "Đã thanh toán" ? true : false;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtgv_HoaDon.Rows.Clear();
            dtgv_ChiTietHoaDon.Rows.Clear();
            int value;
            if (txt_timKiem.Text != " ")
            {
                if (int.TryParse(txt_timKiem.Text, out value))
                {
                    var items = _lstOrder.Where(x => x.IDHoaDon.ToString().Contains(value.ToString()));
                    if (items.Any())
                    {
                        foreach (var i in items)
                        {
                            dtgv_HoaDon.Rows.Add(i.IDHoaDon, i.IDNhanVien, i.SDT_KH, i.tongTien, i.ngayBan, i.ghiChu, i.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã hóa đơn tương ứng");
                        LoadHD();
                    }
                }
                else
                {
                    MessageBox.Show("Yêu cầu kiểm tra lại thông tin cần tìm");
                    LoadHD();
                }
            }
        }
    }
}
