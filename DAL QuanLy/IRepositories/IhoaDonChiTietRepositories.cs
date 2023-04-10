using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IhoaDonChiTietRepositories
    {
        List<hoaDonChiTiet> GetHoaDonChiTietFromDB();
        bool addHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
        bool RemoveHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
        bool UpdateHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
    }
}
