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
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        }  
    }
}
