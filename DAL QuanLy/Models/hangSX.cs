using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Models
{
    public class hangSX
    {
        public int IDHangSX { get; set; }
        public string tenHangSX { get; set; }
        public bool trangThai { get; set; }
        public virtual List<sanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
