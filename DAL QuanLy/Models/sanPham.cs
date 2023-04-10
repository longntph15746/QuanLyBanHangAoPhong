using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Models
{
    public class sanPham
    {
        public int IDsanPham { get; set; }
        public string tenSanPham { get; set; }
        public bool trangThai { get; set; }
        public virtual List<sanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
