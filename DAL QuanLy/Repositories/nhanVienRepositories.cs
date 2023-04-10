
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

    public class nhanVienRepositories : InhanVienRepositories
    {
        private List<nhanVien> _lstNhanVien;
        private DatabaseContext _context;
        public nhanVienRepositories()
        {
            _lstNhanVien = new List<nhanVien>();
            _context = new DatabaseContext();

        }
        public bool addNhanVien(nhanVien NhanVien)
        {
            if (NhanVien == null) return false;
            _context.nhanViens.Add(NhanVien);
            _context.SaveChanges();
            return true;
        }

        public List<nhanVien> GetnhanVienFromDB()
        {
            _lstNhanVien = _context.nhanViens.ToList();
            return _lstNhanVien;
        }

        public bool RemoveNhanVien(nhanVien NhanVien)
        {
            if (NhanVien == null) return false;
            var temp = _context.nhanViens.FirstOrDefault(p => p.IDNhanVien == NhanVien.IDNhanVien);
            _context.nhanViens.Remove(temp);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateNhanVien(nhanVien NhanVien)
        {
            if (NhanVien == null) return false;
            var temp = _context.nhanViens.FirstOrDefault(p => p.IDNhanVien == NhanVien.IDNhanVien);
            temp.tenNV = NhanVien.tenNV;
            temp.SDT = NhanVien.SDT;
            temp.chucVu = NhanVien.chucVu;
            temp.IDChucVu = NhanVien.IDChucVu;
            temp.diaChi = NhanVien.diaChi;
            temp.email = NhanVien.email;
            temp.matKhau = NhanVien.matKhau;
            _context.nhanViens.Update(temp);
            _context.SaveChanges();
            return true;
        }
    }
}
