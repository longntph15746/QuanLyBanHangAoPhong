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
    public partial class FormThongKe : Form
    {
        private IQLhoaDonServices _order;
        private IQLhoaDonChiTietServices _orderdetail;
        private IQLkhachHangServices _customer;
        private IQLsanPhamChiTietServices _product;
        public List<hoaDon> _lstOrder;
        public List<hoaDonChiTiet> _lstOrderDetail;
        public List<khachHang> _lstCustomer;
        public List<ViewHienThi1> _lst;
        public FormThongKe()
        {
            InitializeComponent();
            _order = new QLhoaDonServices();
            _orderdetail = new QLhoaDonChiTietServices();
            _customer = new QLkhachHangServices();
            _product = new QLsanPhamChiTietServices();
            _lstOrder = _order.GetHoaDonFromDB();
            _lstOrderDetail = new List<hoaDonChiTiet>();
            _lstCustomer = new List<khachHang>();
            loadDate();
            loadData();
        }
        private void loadData()
        {
            dtgv_hanghoa.ColumnCount = 8;
            dtgv_hanghoa.Columns[0].Name = "Mã hóa đơn";
            dtgv_hanghoa.Columns[1].Name = "Tên sản phẩm";
            dtgv_hanghoa.Columns[2].Name = "Số lượng";
            dtgv_hanghoa.Columns[3].Name = "Đơn giá";
            dtgv_hanghoa.Columns[4].Name = "Tổng tiền";
            dtgv_hanghoa.Columns[5].Name = "Tổng tiền trong hóa đơn";
            dtgv_hanghoa.Columns[6].Name = "Ngày bán";
            dtgv_hanghoa.Columns[7].Name = "Trạng thái";

            dtgv_hanghoa.Rows.Clear();
            var x = (from a in _lstOrder
                     join b in _customer.GetkhachHangFromDB() on a.SDT_KH equals b.SDT_KH
                     join c in _orderdetail.GetHoaDonChiTietFromDB() on a.IDHoaDon equals c.IDHoaDon
                     join d in _product.GetSanPhamCTTFromDB() on c.IDSanPham equals d.IDSanPham
                     where b.SDT_KH.Contains(txt_sdt.Text)

                     select new { a, b, c, d });

            foreach (var i in x)
            {
                dtgv_hanghoa.Rows.Add(i.a.IDHoaDon, i.d.TenSP, i.c.Soluong, i.c.donGia, i.c.donGia * i.c.Soluong, i.a.tongTien, i.a.ngayBan, i.a.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán");
            }

            lbl_doanhthu.Text = x.Select(x => x.a).Distinct().Sum(x => x.tongTien).ToString();
            lbl_soHD.Text = x.GroupBy(x => x.a).Count().ToString();
            lbl_chuaTT.Text = x.Select(x => x.a).Distinct().Where(x => x.trangThai == false).Count().ToString();
            lbl_tongKH.Text = x.GroupBy(x => x.b).Count().ToString();
        }
        private void loadDate()
        {
            for (int i = 1; i < 13; i++)
            {
                cbb_Thang.Items.Add(i);
            }
            //var x = Convert.ToInt32(_order.GetHoaDonFromDB().First().ngayBan.ToString("yyyy"));
            //var y = Convert.ToInt32(_order.GetHoaDonFromDB().Last().ngayBan.ToString("yyyy"));
            for (int i = 2010; i <= 9999; i++)
            {
                cbb_Nam.Items.Add(i);
            }
        }

        private void dtp_doanhthu_ValueChanged(object sender, EventArgs e)
        {
            _lstOrder = _order.GetHoaDonFromDB().Where(x => x.ngayBan.ToString("dd-MM-yyyy") == dtp_doanhthu.Value.ToString("dd-MM-yyyy")).ToList();
            loadData();
        }

        private void cbb_Thang_TextChanged(object sender, EventArgs e)
        {
            if (cbb_Nam.Text != "")
            {
                _lstOrder = _order.GetHoaDonFromDB().Where(x => (x.ngayBan.Month.ToString() == cbb_Thang.Text && x.ngayBan.Year.ToString() == cbb_Nam.Text)).ToList();
                loadData();
            }
        }

        private void cbb_Nam_TextChanged(object sender, EventArgs e)
        {
            if (cbb_Thang.Text != "")
            {
                _lstOrder = _order.GetHoaDonFromDB().Where(x => (x.ngayBan.Month.ToString() == cbb_Thang.Text && x.ngayBan.Year.ToString() == cbb_Nam.Text)).ToList();
                loadData();
            }
            else
            {
                _lstOrder = _order.GetHoaDonFromDB().Where(x => x.ngayBan.Year.ToString() == cbb_Nam.Text).ToList();
                loadData();
            }
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_sdt.Text, out int x) || txt_sdt.Text.Length <= 10)
            {
                loadData();
            }
            else
            {
                dtgv_hanghoa.Rows.Clear();
            }
        }
    }
}
