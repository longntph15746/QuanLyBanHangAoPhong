using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.IServices
{
    public interface IQLhangSXServices
    {
        List<hangSX> GetHangSXFromDB();
        bool addHangSX(hangSX HangSX);
        bool RemoveHangSX(hangSX HangSX);
        bool UpdateHangSX(hangSX HangSX);
    }
}
