using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IhoaDonRepositories
    {
        List<hoaDon> GetHoaDonFromDB();
        bool addHoaDon(hoaDon HoaDon);
        bool RemoveHoaDon(hoaDon HoaDon);
        bool UpdateHoaDon(hoaDon HoaDon);
    }
}
