using _1_DAL_QUANLY.IRepositories;
using _1_DAL_QUANLY.Models;
using _1_DAL_QUANLY.Repositories;
using _2_BUS_QUANLY.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.Services
{
    public class QLnhaCungCapServices : IQLnhaCungCapServices
    {
        private InhaCungCapRepositories _nhaCungCap;
        private List<nhaCungCap> _lstnhaCungCap;
        public QLnhaCungCapServices()
        {
            _lstnhaCungCap = new List<nhaCungCap>();
            _nhaCungCap = new nhaCungCapRepositories();
        }

        public bool addNhaCungCap(nhaCungCap NhaCungCap)
        {
            _nhaCungCap.addnhaCungCap(NhaCungCap);
            return true;
        }

        public List<nhaCungCap> GetNhaCungCapFromDB()
        {
            _lstnhaCungCap = _nhaCungCap.GetnhaCungCapFromDB();
            return _lstnhaCungCap;
        }

        public bool RemoveNhaCungCap(nhaCungCap NhaCungCap)
        {
            _nhaCungCap.RemovenhaCungCap(NhaCungCap);
            return true;
        }

        public bool UpdatesNhaCungCap(nhaCungCap NhaCungCap)
        {
            _nhaCungCap.UpdatenhaCungCap(NhaCungCap);
            return true;
        }
    }
}
