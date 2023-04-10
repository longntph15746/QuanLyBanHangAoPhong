
using _1_DAL_QUANLY.IRepositories;
using _1_DAL_QUANLY.Models;
using DAL_QuanLy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Repositories
{
    public class sanPhamRepositories : IsanPhamRepositories
    {
        private List<sanPham> _lstsanPham;
        private DatabaseContext _context;
        public sanPhamRepositories()
        {
            _lstsanPham = new List<sanPham>();
            _context = new DatabaseContext();
        }
        public bool addsanPham(sanPham SanPham)
        {
            _context.Add(SanPham);
            _context.SaveChanges();
            return true;
        }

        public List<sanPham> GetsanPhamFromDB()
        {
            _lstsanPham = _context.sanPhams.ToList();
            return _lstsanPham;
        }

        public bool RemovesanPham(sanPham SanPham)
        {
            _context.Remove(SanPham);
            _context.SaveChanges();
            return true;
        }

        public bool UpdatesanPham(sanPham SanPham)
        {
            _context.Update(SanPham);
            _context.SaveChanges();
            return true;
        }
    }
}
