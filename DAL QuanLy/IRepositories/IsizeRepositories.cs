using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IsizeRepositories
    {
        List<size> GetSizeFromDB();
        bool addsize(size Size);
        bool RemoveSize(size Size);
        bool UpdateSize(size Size);
    }
}
