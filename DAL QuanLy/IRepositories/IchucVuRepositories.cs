using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IchucVuRepositories
    {
        List<chucVu> GetchucVuFromDB();
        bool addChucVu(chucVu ChucVu);
        bool RemoveChucVu(chucVu ChucVu);
        bool UpdateChucVu(chucVu ChucVu);
    }
}
