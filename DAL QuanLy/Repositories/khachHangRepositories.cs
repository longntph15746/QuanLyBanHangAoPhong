
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
    public class khachHangRepositories : IkhachHangRepositories
    {
        private List<khachHang> _lstkhachHang;
        private DatabaseContext _context;
        public khachHangRepositories()
        {
            _lstkhachHang = new List<khachHang>();
            _context = new DatabaseContext();
            GetkhachHangFromDB();
        }
        public bool addkhachHang(khachHang KhachHang)
        {
            _context.Add(KhachHang);
            _context.SaveChanges();
            return true;
        }      

        public bool RemoveKhachHang(khachHang KhachHang)
        {
            _context.Remove(KhachHang);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateKhachHang(khachHang KhachHang)
        {
            _context.Update(KhachHang);
            _context.SaveChanges();
            return true;
        }
        public List<khachHang> GetkhachHangFromDB()
        {
            _lstkhachHang = _context.khachHangs.ToList();
            return _lstkhachHang;
        }
    }
}
