using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IkhachHangRepositories
    {
        List<khachHang> GetkhachHangFromDB();
        bool addkhachHang(khachHang KhachHang);
        bool RemoveKhachHang(khachHang KhachHang);
        bool UpdateKhachHang(khachHang KhachHang);
    }
}
