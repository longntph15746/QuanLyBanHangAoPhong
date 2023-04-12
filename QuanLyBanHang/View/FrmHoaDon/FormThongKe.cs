using _1_DAL_QUANLY.Models;
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
        }
    }
}
