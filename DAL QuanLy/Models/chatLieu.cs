using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Models
{
    public class chatLieu
    {
        public int IDchatLieu { get; set; }
        public string tenChatLieu { get; set; }
        public bool trangThai { get; set; }
        public virtual List<sanPhamChiTiet> SanphamChitiets { get; set; }
    }
}
