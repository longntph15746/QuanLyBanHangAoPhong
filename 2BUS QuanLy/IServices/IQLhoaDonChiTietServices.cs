using _1_DAL_QUANLY.Models;
using _2_BUS_QUANLY.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.IServices
{
    public interface IQLhoaDonChiTietServices
    {
        List<hoaDonChiTiet> GetHoaDonChiTietFromDB();
        bool addHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
        bool RemoveHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
        bool UpdateHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
        List<ViewHoaDonCT> getViewHoaDonChiTiet(int maHoaDon);
    }
}
