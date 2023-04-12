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
    public partial class FormHoaDon : Form
    {
        IQLhoaDonServices _HDservices;
        IQLnhanVienServices _NHanVienServices;
        IQLkhachHangServices _KHSer;
        List<hoaDon> _lstOrder;
        List<ViewHoaDonCT> _lstHDCT;
        IQLhoaDonChiTietServices _HDCTser;
        int _idHD;
        public FormHoaDon()
        {
            _HDservices = new QLhoaDonServices();
            _NHanVienServices = new QLnhanVienServices();
            _KHSer = new QLkhachHangServices();
            _HDCTser = new QLhoaDonChiTietServices();
            _lstOrder = _HDservices.GetHoaDonFromDB();
            _lstHDCT = new List<ViewHoaDonCT>();
            LoadHD();
        }

        private void LoadHD()
        {
            dtgv_HoaDon.Rows.Clear();
            foreach (var i in _lstOrder)
            {
                dtgv_HoaDon.Rows.Add(i.IDHoaDon, i.IDNhanVien, i.SDT_KH, i.tongTien, i.ngayBan, i.ghiChu, i.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }
        public void LoadHDCT(int maHoaDon)
        {
            _idHD = maHoaDon;
            dtgv_CTHD.Rows.Clear();
            foreach (var i in _HDCTser.getViewHoaDonChiTiet(maHoaDon))
            {
                dtgv_CTHD.Rows.Add(i.ID, i.maSanPham, i.tenSanPham, i.soLuong, i.donGia);
            }
        }
        private void dtgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_HoaDon.Rows[e.RowIndex];
                LoadHDCT(Convert.ToInt32(r.Cells[0].Value));
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtgv_HoaDon.Rows.Clear();
            dtgv_CTHD.Rows.Clear();
            int value;
            if (txt_TimKiem.Text != " ")
            {
                if (int.TryParse(txt_TimKiem.Text, out value))
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

        private void dtgv_CTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
