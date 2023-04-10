using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface InhaCungCapRepositories
    {
        List<nhaCungCap> GetnhaCungCapFromDB();
        bool addnhaCungCap(nhaCungCap NhaCungCap);
        bool RemovenhaCungCap(nhaCungCap NhaCungCap);
        bool UpdatenhaCungCap(nhaCungCap NhaCungCap);
    }
}
