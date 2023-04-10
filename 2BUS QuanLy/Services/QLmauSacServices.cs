
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
    public class QLmauSacServices : IQLmauSacServices
    {
        private ImauSacRepositories _mauSac;
        private List<mauSac> _lstmauSac;
        public QLmauSacServices()
        {
            _lstmauSac = new List<mauSac>();
            _mauSac = new mauSacRepositories();
        }

        public bool addMauSac(mauSac MauSac)
        {
            _mauSac.addMauSac(MauSac);
            return true;
        }

        public List<mauSac> GetMauSacFromDB()
        {
            _lstmauSac = _mauSac.GetMauSacFromDB();
            return _lstmauSac;
        }

        public bool RemoveMauSac(mauSac MauSac)
        {
            _mauSac.RemoveMauSac(MauSac);
            return true;
        }

        public bool UpdateMauSac(mauSac MauSac)
        {
            _mauSac.UpdateMauSac(MauSac);
            return true;
        }
    }
}
