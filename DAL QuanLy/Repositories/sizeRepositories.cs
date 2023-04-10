
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
    public class sizeRepositories : IsizeRepositories
    {
        private List<size> _lstSize;
        private DatabaseContext _context;
        public sizeRepositories()
        {
            _lstSize = new List<size>();
            _context = new DatabaseContext();
        }
        public bool addsize(size Size)
        {
            _context.Add(Size);
            _context.SaveChanges();
            return true;
        }

        public List<size> GetSizeFromDB()
        {
            _lstSize = _context.sizes.ToList();
            return _lstSize;
        }

        public bool RemoveSize(size Size)
        {
            _context.Remove(Size);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateSize(size Size)
        {
            _context.Update(Size);
            _context.SaveChanges();
            return true;
        }
    }
}
