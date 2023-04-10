
using _1_DAL_QUANLY.IRepositories;
using _1_DAL_QUANLY.Models;
using _1_DAL_QUANLY.Repositories;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.Services;
using _2_BUS_QUANLY.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLsanPhamChiTietServices : IQLsanPhamChiTietServices
    {
        private IsanPhamChiTietRepositories _sanPhamCT;
        private List<sanPhamChiTiet> _lstsanPhamCT;
        private IQLsizeServices _qLsizeServices;
        private IQLmauSacServices _qLmauSacServices;
        private IQLhangSXServices _qLhangSXServices;
        private IQLnhaCungCapServices _qLnhaCungCapServices;
        private IQLchatLieuServices _qLchatLieuServices;
        private IQLsanPhamServices _qLsanPhamServices;
        private List<ViewHienThi1> _lstView;
        public QLsanPhamChiTietServices()
        {
            _lstsanPhamCT = new List<sanPhamChiTiet>();
            _sanPhamCT = new sanPhamChiTietRepositories();
            _qLhangSXServices = new QLhangSXServices();
            _qLmauSacServices = new QLmauSacServices();
            _qLsizeServices = new QLsizeServices();
            _qLnhaCungCapServices = new QLnhaCungCapServices();
            _qLchatLieuServices = new QLchatLieuServices();
            _qLsanPhamServices = new QLsanPhamServices();
            _lstView = new List<ViewHienThi1>();
            GetSanPhamCTTFromDB();
        }
        public bool addsanPham(sanPhamChiTiet sanPhamCT)
        {
            _sanPhamCT.addsanPham(sanPhamCT);
            return true;
        }

        public List<sanPhamChiTiet> GetSanPhamCTTFromDB()
        {
            _lstsanPhamCT = _sanPhamCT.GetSanPhamFromDB();
            return _lstsanPhamCT;
        }
        public List<ViewHienThi1> getViewSPCT()
        {
            _lstView = (from a in GetSanPhamCTTFromDB()
                        join b in _qLmauSacServices.GetMauSacFromDB() on a.IDMauSac equals b.IDMauSac
                        join c in _qLhangSXServices.GetHangSXFromDB() on a.IDHangSX equals c.IDHangSX
                        join d in _qLnhaCungCapServices.GetNhaCungCapFromDB() on a.IDNhaCungCap equals d.IDNhaCungCap
                        join e in _qLchatLieuServices.GetChatLieuFromDB() on a.IDchatLieu equals e.IDchatLieu
                        join f in _qLsizeServices.GetSizeFromDB() on a.IDSize equals f.IDSize
                        join g in _qLsanPhamServices.GetsanPhamFromDB() on a.IDSanPham equals g.IDsanPham
                        select new ViewHienThi1 { SanPhamChiTiets = a, mauSacs = b, hangSXs = c, nhaCungCaps = d, chatLieus = e, sizes = f, sanPhams = g }).ToList();
            return _lstView;
        }

        public bool RemoveSanPham(sanPhamChiTiet sanPhamCT)
        {
            _sanPhamCT.RemoveSanPham(sanPhamCT);
            return true;
        }

        public bool UpdateSanPham(sanPhamChiTiet sanPhamCT)
        {
            _sanPhamCT.UpdateSanPham(sanPhamCT);
            return true;
        }
    }
}
