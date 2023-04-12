using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Utilities
{
    internal class ValidateInput
    {
        static public bool CheckSDT(string s) // sdt phai nhap 10 so
        {
            if (s.Substring(0, 1) == "0" && s.Length == 10)
            {
                return true;
            }
            else return false;
        }
    }
}
