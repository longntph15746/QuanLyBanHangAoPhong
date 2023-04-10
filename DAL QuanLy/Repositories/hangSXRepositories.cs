
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
    public class hangSXRepositories : IhangSXRepositories
    {
        private List<hangSX> _lsthangSX;
        private DatabaseContext _context;
        public hangSXRepositories()
        {
            _lsthangSX = new List<hangSX>();
            _context = new DatabaseContext();
        }
        public bool addHangSX(hangSX HangSX)
        {
            _context.Add(HangSX);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveHangSX(hangSX HangSX)
        {
            _context.Remove(HangSX);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateHangSX(hangSX HangSX)
        {
            _context.Update(HangSX);
            _context.SaveChanges();
            return true;
        }
        public List<hangSX> GetHangSXFromDB()
        {
            _lsthangSX = _context.hangSXs.ToList();
            return _lsthangSX;
        }
    }
}
