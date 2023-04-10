
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
    public class QLchucVuServices : IQLchucVuServices
    {
        private IchucVuRepositories _chucVu;
        private List<chucVu> _lstchuVu;
        public QLchucVuServices()
        {
            _lstchuVu = new List<chucVu>();
            _chucVu = new chucVuRepositories();
        }
        
        public bool addChucVu(chucVu ChucVu)
        {
            _chucVu.addChucVu(ChucVu);
            return true;
        }

        public List<chucVu> GetchucVuFromDB()
        {
           _lstchuVu = _chucVu.GetchucVuFromDB();
            return _lstchuVu;
        }

        public bool RemoveChucVu(chucVu ChucVu)
        {
            _chucVu.RemoveChucVu(ChucVu);   
            return true;
        }

        public bool UpdateChucVu(chucVu ChucVu)
        {
            _chucVu.UpdateChucVu(ChucVu);
            return true;
        }
    }
}
