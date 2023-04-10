
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
    public class hoaDonChiTietRepositories : IhoaDonChiTietRepositories
    {
        private List<hoaDonChiTiet> _lsthoaDonChiTiet;
        private DatabaseContext _context;
        public hoaDonChiTietRepositories()
        {
            _lsthoaDonChiTiet = new List<hoaDonChiTiet>();
            _context = new DatabaseContext();
        }
        public bool addHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            _context.Add(HoaDonChiTiet);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            _context.Remove(HoaDonChiTiet);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet)
        {
            _context.Update(HoaDonChiTiet);
            _context.SaveChanges();
            return true;
        }
        public List<hoaDonChiTiet> GetHoaDonChiTietFromDB()
        {
            _lsthoaDonChiTiet = _context.hoaDonChiTiets.ToList();
            return _lsthoaDonChiTiet;
        }
    }
}
