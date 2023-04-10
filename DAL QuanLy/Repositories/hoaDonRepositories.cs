
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
    public class hoaDonRepositories : IhoaDonRepositories
    {
        private List<hoaDon> _lsthoaDon;
        private DatabaseContext _context;
        public hoaDonRepositories()
        {
            _lsthoaDon = new List<hoaDon>();
            _context = new DatabaseContext();
        }
        public bool addHoaDon(hoaDon HoaDon)
        {
            _context.Add(HoaDon);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveHoaDon(hoaDon HoaDon)
        {
            _context.Remove(HoaDon);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateHoaDon(hoaDon HoaDon)
        {
            _context.Update(HoaDon);
            _context.SaveChanges();
            return true;
        }
        public List<hoaDon> GetHoaDonFromDB()
        {
            _lsthoaDon = _context.hoaDons.ToList();
            return _lsthoaDon;
        }
    }
}
