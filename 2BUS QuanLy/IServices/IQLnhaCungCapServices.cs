using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.IServices
{
    public interface IQLnhaCungCapServices
    {
        List<nhaCungCap> GetNhaCungCapFromDB();
        bool addNhaCungCap (nhaCungCap NhaCungCap);
        bool RemoveNhaCungCap (nhaCungCap NhaCungCap);
        bool UpdatesNhaCungCap (nhaCungCap NhaCungCap);
    }
}
