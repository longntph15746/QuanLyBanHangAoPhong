using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface InhanVienRepositories
    {
        List<nhanVien> GetnhanVienFromDB();
        bool addNhanVien(nhanVien NhanVien);
        bool RemoveNhanVien(nhanVien NhanVien);
        bool UpdateNhanVien(nhanVien NhanVien);
    }
}
