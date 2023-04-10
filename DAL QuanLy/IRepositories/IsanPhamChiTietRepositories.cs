using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IsanPhamChiTietRepositories
    {
        List<sanPhamChiTiet> GetSanPhamFromDB();
        bool addsanPham(sanPhamChiTiet sanPhamCT);
        bool RemoveSanPham(sanPhamChiTiet sanPhamCT);
        bool UpdateSanPham(sanPhamChiTiet sanPhamCT);
    }
}
