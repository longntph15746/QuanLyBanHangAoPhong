﻿using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IsanPhamRepositories
    {
        List<sanPham> GetsanPhamFromDB();
        bool addsanPham(sanPham SanPham);
        bool RemovesanPham(sanPham SanPham);
        bool UpdatesanPham(sanPham SanPham);
    }
}
