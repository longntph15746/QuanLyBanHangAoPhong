﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Models
{
    public class chucVu
    {
        public int IDChucVu { get; set; }
        public string tenCV { get; set; }
        public virtual List<nhanVien> NhanViens { get; set; }
    }
}
