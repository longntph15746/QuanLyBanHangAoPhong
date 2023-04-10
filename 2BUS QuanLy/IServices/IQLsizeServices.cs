using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.IServices
{
    public interface IQLsizeServices
    {
        List<size> GetSizeFromDB();
        bool addsize(size Size);
        bool RemoveSize(size Size);
        bool UpdateSize(size Size);
    }
}
