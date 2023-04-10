
using _1_DAL_QUANLY.IRepositories;
using _1_DAL_QUANLY.Models;
using _1_DAL_QUANLY.Repositories;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLnhanVienServices : IQLnhanVienServices
    {
        private InhanVienRepositories _nhanVien;
        private List<nhanVien> _lstnhanVien;
        private IQLchucVuServices _qlchucVu;
        private List<ViewHienThi1> nhanVienViews;
        public QLnhanVienServices()
        {
            _lstnhanVien = new List<nhanVien>();
            _nhanVien = new nhanVienRepositories();
            _qlchucVu = new QLchucVuServices();
            nhanVienViews = new List<ViewHienThi1>();
            GetNhanVienFromDB();
        }
        public string addNhanVien(ViewHienThi1 NhanVien)
        {
            if (NhanVien == null) return "Thêm thất bại";
            var nvv = NhanVien.nhanViens;
            if (_nhanVien.addNhanVien(nvv)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public List<nhanVien> GetAll()
        {
            _lstnhanVien = _nhanVien.GetnhanVienFromDB();
            return _lstnhanVien;
        }

        public List<ViewHienThi1> GetNhanVienFromDB()
        {
            nhanVienViews =
                (from a in _nhanVien.GetnhanVienFromDB()
                 join b in _qlchucVu.GetchucVuFromDB() on a.IDChucVu equals b.IDChucVu
                 select new ViewHienThi1()
                 {
                     nhanViens = a,
                     chucVus = b,

                 }).ToList();
            return nhanVienViews;
        }

        public string RemoveNhanVien(ViewHienThi1 NhanVien)
        {
            if (NhanVien == null) return "Xóa thất bại";
            var nvv = NhanVien.nhanViens;
            if (_nhanVien.RemoveNhanVien(nvv)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public string UpdateNhanVien(ViewHienThi1 NhanVien)
        {
            if (NhanVien == null) return "Sửa thất bại";
            var nvv = NhanVien.nhanViens;
            if (_nhanVien.UpdateNhanVien(nvv)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}
