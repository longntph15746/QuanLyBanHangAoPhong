using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Models
{
    public class size
    {
        public int IDSize { get; set; }
        public string tenSize { get; set; }
        public bool trangThai { get; set; }
        public virtual List<sanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
