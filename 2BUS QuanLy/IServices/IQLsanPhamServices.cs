using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.IServices
{
    public interface IQLsanPhamServices
    {
        List<sanPham> GetsanPhamFromDB();
        bool addsanPham(sanPham SanPham);
        bool RemovesanPham(sanPham SanPham);
        bool UpdatesanPham(sanPham SanPham);
    }
}
