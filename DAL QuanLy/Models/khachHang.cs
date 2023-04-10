﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Models
{
    public class khachHang
    {
        public string SDT_KH { get; set; }
        public string TenKH { get; set; }
        public bool gioiTinh { get; set; }
        public string diaChi { get; set; }
        public bool trangThai { get; set; }
        public int diemTichluy { get; set; }
        public virtual List<hoaDon> HoaDons { get; set; }
    }
}
