
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
    public class mauSacRepositories : ImauSacRepositories
    {
        private List<mauSac> _lstMauSac;
        private DatabaseContext _context;
        public mauSacRepositories()
        {
            _lstMauSac = new List<mauSac>();
            _context = new DatabaseContext();
        }
        public bool addMauSac(mauSac MauSac)
        {
            _context.Add(MauSac);
            _context.SaveChanges();
            return true;
        } 
        public bool RemoveMauSac(mauSac MauSac)
        {
            _context.Remove(MauSac);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateMauSac(mauSac MauSac)
        {
            _context.Update(MauSac);
            _context.SaveChanges();
            return true;
        }
        public List<mauSac> GetMauSacFromDB()
        {
            _lstMauSac = _context.mauSacs.ToList();
            return _lstMauSac;
        }
    }
}
