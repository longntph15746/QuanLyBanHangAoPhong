using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Models
{
    public class sanPhamChiTiet
    {
        public int IDSanPhamChiTiet { get; set; }
        public int IDMauSac { get; set; }
        public int IDSize { get; set; }
        public int IDNhaCungCap { get; set; }
        public int IDHangSX { get; set; }
        public int IDchatLieu { get; set; }
        public int IDSanPham { get; set; }
        public string TenSP { get; set; }
        public string maSP { get; set; }
        public float giaNhap { get; set; }
        public float giaBan { get; set; }
        public int soLuong { get; set; }
        public bool trangThai { get; set; }
        public string linkAnh { get; set; }
        public mauSac mauSac { get; set; }
        public size size { get; set; }
        public hangSX hangSX { get; set; }
        public chatLieu chatLieu { get; set; }
        public nhaCungCap nhaCungCap { get; set; }
        public sanPham sanPham { get; set; }
        public List<hoaDonChiTiet> hoaDonChiTiet { get; set; }
    }

}
