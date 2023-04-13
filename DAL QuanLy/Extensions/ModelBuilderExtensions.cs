using _1_DAL_QUANLY.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chucVu>().HasData
                (
                new chucVu() {IDChucVu = 1, tenCV = "Quản lý" },
                new chucVu() { IDChucVu = 2, tenCV = "Nhân viên"}
                );
            modelBuilder.Entity<nhanVien>().HasData
                (
                new nhanVien() { IDNhanVien = 1, tenNV = "Nguyễn Thành Long", IDChucVu = 1, diaChi = "Hải Dương",SDT = "0902096529", email = "nguyenthanhlong081120022@gmail.com", matKhau = "Long0811", tinhTrang = true  },
                new nhanVien() { IDNhanVien = 2, tenNV = "LongNT", IDChucVu = 2, diaChi = "Ninh Giang",SDT = "0329746336", email = "long@gmail.com", matKhau = "Long08112002", tinhTrang = true  }
                );
            modelBuilder.Entity<nhaCungCap>().HasData
                (
                new nhaCungCap() { IDNhaCungCap = 1, tenNhaCungCap = "Hàn Quốc", trangThai = true},
                new nhaCungCap() { IDNhaCungCap = 2, tenNhaCungCap = "Việt Nam", trangThai = true}
                );
            modelBuilder.Entity<hangSX>().HasData
                (
                new hangSX() { IDHangSX = 1, tenHangSX = "Nike", trangThai = true},
                new hangSX() { IDHangSX = 2, tenHangSX = "Gucci", trangThai = true}
                );
            modelBuilder.Entity<chatLieu>().HasData
                (
                new chatLieu() { IDchatLieu = 1, tenChatLieu = "Vải mềm", trangThai = true},
                new chatLieu() { IDchatLieu = 2, tenChatLieu = "Vải cứng", trangThai = true}
                );
            modelBuilder.Entity<mauSac>().HasData
                (
                new mauSac() { IDMauSac = 1, tenMau = "Xanh", trangThai = true},
                new mauSac() { IDMauSac = 2, tenMau = "Trắng", trangThai = true}
                );
            modelBuilder.Entity<size>().HasData
                ( 
                new size() { IDSize = 1, tenSize = "M", trangThai = true },
                new size() { IDSize = 2, tenSize = "L", trangThai = true }
                );
            modelBuilder.Entity<sanPham>().HasData
                ( 
                new sanPham() { IDsanPham = 1, tenSanPham = "Áo thun", trangThai = true},
                new sanPham() { IDsanPham = 2, tenSanPham = "Áo local brand", trangThai = true}
                );
            modelBuilder.Entity<sanPhamChiTiet>().HasData
                ( 
                new sanPhamChiTiet() {IDSanPhamChiTiet = 1, maSP = "SP01", TenSP = "Long", giaNhap = 1000, giaBan = 5000, soLuong = 1, IDNhaCungCap = 1, IDHangSX = 1, IDchatLieu = 1, IDMauSac = 1, IDSize = 1, trangThai = true, IDSanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() {IDSanPhamChiTiet = 2, maSP = "SP02", TenSP = "Vinh", giaNhap = 2000, giaBan = 10000, soLuong = 1, IDNhaCungCap = 2, IDHangSX = 2, IDchatLieu = 2, IDMauSac = 2, IDSize = 2, trangThai = true, IDSanPham = 2, linkAnh = "" }
                );
            modelBuilder.Entity<khachHang>().HasData
                ( 
                new khachHang() { SDT_KH = "089999999", TenKH = "Thành Long", gioiTinh = true, diaChi = "Hà Nội", trangThai = true, diemTichluy = 100},
                new khachHang() { SDT_KH = "086666666", TenKH = "Thành Vinh", gioiTinh = true, diaChi = "Hà Nam", trangThai = true, diemTichluy = 200}
                );
        }
    }
}
