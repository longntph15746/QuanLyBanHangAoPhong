
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
    public class QLsizeServices : IQLsizeServices
    {
        private IsizeRepositories _size;
        private List<size> _lstsize;
        public QLsizeServices()
        {
            _lstsize = new List<size>();
            _size = new sizeRepositories();
        }
        public bool addsize(size Size)
        {
            _size.addsize(Size);
            return true;
        }

        public List<size> GetSizeFromDB()
        {
            _lstsize = _size.GetSizeFromDB();
            return _lstsize;
        }

        public bool RemoveSize(size Size)
        {
            _size.RemoveSize(Size);
            return true;
        }

        public bool UpdateSize(size Size)
        {
            _size.UpdateSize(Size);
            return true;
        }
    }
}
