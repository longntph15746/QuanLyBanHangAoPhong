
using _1_DAL_QUANLY.IRepositories;
using _1_DAL_QUANLY.Models;
using _1_DAL_QUANLY.Repositories;
using _2_BUS_QUANLY.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLsanPhamServices : IQLsanPhamServices
    {
        private IsanPhamRepositories _sanPham;
        private List<sanPham> _lstsanPham;
        public QLsanPhamServices()
        {
            _lstsanPham = new List<sanPham>();
            _sanPham = new sanPhamRepositories();
        }
        public bool addsanPham(sanPham SanPham)
        {
            _sanPham.addsanPham(SanPham);
            return true;
        }

        public List<sanPham> GetsanPhamFromDB()
        {
            _lstsanPham = _sanPham.GetsanPhamFromDB();
            return _lstsanPham;
        }

        public bool RemovesanPham(sanPham SanPham)
        {
            _sanPham.RemovesanPham(SanPham);
            return true;
        }

        public bool UpdatesanPham(sanPham SanPham)
        {
            _sanPham.UpdatesanPham(SanPham);
            return true;
        }
    }
}
