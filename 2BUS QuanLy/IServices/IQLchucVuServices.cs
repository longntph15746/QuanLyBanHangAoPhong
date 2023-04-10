using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.IServices
{
    public interface IQLchucVuServices
    {
        List<chucVu> GetchucVuFromDB();
        bool addChucVu(chucVu ChucVu);
        bool RemoveChucVu(chucVu ChucVu);
        bool UpdateChucVu(chucVu ChucVu);
    }
}
