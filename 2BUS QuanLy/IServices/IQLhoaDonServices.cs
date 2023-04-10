using _1_DAL_QUANLY.Models;
using _2_BUS_QUANLY.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.IServices
{
    public interface IQLhoaDonServices
    {
        List<hoaDon> GetHoaDonFromDB();
        List<ViewHienThi1> getViewhoaDon();
        bool addHoaDon(hoaDon HoaDon);
        bool RemoveHoaDon(hoaDon HoaDon);
        bool UpdateHoaDon(hoaDon HoaDon);
    }
}
