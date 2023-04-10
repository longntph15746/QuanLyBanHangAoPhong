using _1_DAL_QUANLY.Models;
using _2_BUS_QUANLY.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.IServices
{
    public interface IQLsanPhamChiTietServices
    {
        List<sanPhamChiTiet> GetSanPhamCTTFromDB();
        bool addsanPham(sanPhamChiTiet sanPhamCT);
        bool RemoveSanPham(sanPhamChiTiet sanPhamCT);
        bool UpdateSanPham(sanPhamChiTiet sanPhamCT);
        List<ViewHienThi1> getViewSPCT();
    }
}
