﻿// <auto-generated />
using System;
using DAL_QuanLy.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL_QuanLy.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230413144841_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1_DAL_QUANLY.Models.chatLieu", b =>
                {
                    b.Property<int>("IDchatLieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDchatLieu"), 1L, 1);

                    b.Property<string>("tenChatLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDchatLieu");

                    b.ToTable("chatLieu", (string)null);

                    b.HasData(
                        new
                        {
                            IDchatLieu = 1,
                            tenChatLieu = "Vải mềm",
                            trangThai = true
                        },
                        new
                        {
                            IDchatLieu = 2,
                            tenChatLieu = "Vải cứng",
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.chucVu", b =>
                {
                    b.Property<int>("IDChucVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDChucVu"), 1L, 1);

                    b.Property<string>("tenCV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDChucVu");

                    b.ToTable("chucVu", (string)null);

                    b.HasData(
                        new
                        {
                            IDChucVu = 1,
                            tenCV = "Quản lý"
                        },
                        new
                        {
                            IDChucVu = 2,
                            tenCV = "Nhân viên"
                        });
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.hangSX", b =>
                {
                    b.Property<int>("IDHangSX")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDHangSX"), 1L, 1);

                    b.Property<string>("tenHangSX")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDHangSX");

                    b.ToTable("hangSX", (string)null);

                    b.HasData(
                        new
                        {
                            IDHangSX = 1,
                            tenHangSX = "Nike",
                            trangThai = true
                        },
                        new
                        {
                            IDHangSX = 2,
                            tenHangSX = "Gucci",
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.hoaDon", b =>
                {
                    b.Property<int>("IDHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDHoaDon"), 1L, 1);

                    b.Property<int>("IDNhanVien")
                        .HasColumnType("int");

                    b.Property<string>("SDT_KH")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ghiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayBan")
                        .HasColumnType("datetime2");

                    b.Property<float>("tongTien")
                        .HasColumnType("real");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDHoaDon");

                    b.HasIndex("IDNhanVien");

                    b.HasIndex("SDT_KH");

                    b.ToTable("hoaDon", (string)null);
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.hoaDonChiTiet", b =>
                {
                    b.Property<int>("IDHoaDon")
                        .HasColumnType("int");

                    b.Property<int>("IDSanPham")
                        .HasColumnType("int");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<bool>("Trangthai")
                        .HasColumnType("bit");

                    b.Property<float>("donGia")
                        .HasColumnType("real");

                    b.HasKey("IDHoaDon", "IDSanPham");

                    b.HasIndex("IDSanPham");

                    b.ToTable("hoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.khachHang", b =>
                {
                    b.Property<string>("SDT_KH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("diemTichluy")
                        .HasColumnType("int");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("SDT_KH");

                    b.ToTable("khachHang", (string)null);

                    b.HasData(
                        new
                        {
                            SDT_KH = "089999999",
                            TenKH = "Thành Long",
                            diaChi = "Hà Nội",
                            diemTichluy = 100,
                            gioiTinh = true,
                            trangThai = true
                        },
                        new
                        {
                            SDT_KH = "086666666",
                            TenKH = "Thành Vinh",
                            diaChi = "Hà Nam",
                            diemTichluy = 200,
                            gioiTinh = true,
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.mauSac", b =>
                {
                    b.Property<int>("IDMauSac")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDMauSac"), 1L, 1);

                    b.Property<string>("tenMau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDMauSac");

                    b.ToTable("mauSac", (string)null);

                    b.HasData(
                        new
                        {
                            IDMauSac = 1,
                            tenMau = "Xanh",
                            trangThai = true
                        },
                        new
                        {
                            IDMauSac = 2,
                            tenMau = "Trắng",
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.nhaCungCap", b =>
                {
                    b.Property<int>("IDNhaCungCap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDNhaCungCap"), 1L, 1);

                    b.Property<string>("tenNhaCungCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDNhaCungCap");

                    b.ToTable("nhaCungCap", (string)null);

                    b.HasData(
                        new
                        {
                            IDNhaCungCap = 1,
                            tenNhaCungCap = "Hàn Quốc",
                            trangThai = true
                        },
                        new
                        {
                            IDNhaCungCap = 2,
                            tenNhaCungCap = "Việt Nam",
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.nhanVien", b =>
                {
                    b.Property<int>("IDNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDNhanVien"), 1L, 1);

                    b.Property<int>("IDChucVu")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("tinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("IDNhanVien");

                    b.HasIndex("IDChucVu");

                    b.ToTable("nhanVien", (string)null);

                    b.HasData(
                        new
                        {
                            IDNhanVien = 1,
                            IDChucVu = 1,
                            SDT = "0902096529",
                            diaChi = "Hải Dương",
                            email = "nguyenthanhlong081120022@gmail.com",
                            matKhau = "Long0811",
                            tenNV = "Nguyễn Thành Long",
                            tinhTrang = true
                        },
                        new
                        {
                            IDNhanVien = 2,
                            IDChucVu = 2,
                            SDT = "0329746336",
                            diaChi = "Ninh Giang",
                            email = "long@gmail.com",
                            matKhau = "Long08112002",
                            tenNV = "LongNT",
                            tinhTrang = true
                        });
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.sanPham", b =>
                {
                    b.Property<int>("IDsanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDsanPham"), 1L, 1);

                    b.Property<string>("tenSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDsanPham");

                    b.ToTable("sanPham", (string)null);

                    b.HasData(
                        new
                        {
                            IDsanPham = 1,
                            tenSanPham = "Áo thun",
                            trangThai = true
                        },
                        new
                        {
                            IDsanPham = 2,
                            tenSanPham = "Áo local brand",
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.sanPhamChiTiet", b =>
                {
                    b.Property<int>("IDSanPhamChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDSanPhamChiTiet"), 1L, 1);

                    b.Property<int>("IDHangSX")
                        .HasColumnType("int");

                    b.Property<int>("IDMauSac")
                        .HasColumnType("int");

                    b.Property<int>("IDNhaCungCap")
                        .HasColumnType("int");

                    b.Property<int>("IDSanPham")
                        .HasColumnType("int");

                    b.Property<int>("IDSize")
                        .HasColumnType("int");

                    b.Property<int>("IDchatLieu")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("giaBan")
                        .HasColumnType("real");

                    b.Property<float>("giaNhap")
                        .HasColumnType("real");

                    b.Property<string>("linkAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDSanPhamChiTiet");

                    b.HasIndex("IDHangSX");

                    b.HasIndex("IDMauSac");

                    b.HasIndex("IDNhaCungCap");

                    b.HasIndex("IDSanPham");

                    b.HasIndex("IDSize");

                    b.HasIndex("IDchatLieu");

                    b.ToTable("sanPhamChiTiet", (string)null);

                    b.HasData(
                        new
                        {
                            IDSanPhamChiTiet = 1,
                            IDHangSX = 1,
                            IDMauSac = 1,
                            IDNhaCungCap = 1,
                            IDSanPham = 1,
                            IDSize = 1,
                            IDchatLieu = 1,
                            TenSP = "Long",
                            giaBan = 5000f,
                            giaNhap = 1000f,
                            linkAnh = "",
                            maSP = "SP01",
                            soLuong = 1,
                            trangThai = true
                        },
                        new
                        {
                            IDSanPhamChiTiet = 2,
                            IDHangSX = 2,
                            IDMauSac = 2,
                            IDNhaCungCap = 2,
                            IDSanPham = 2,
                            IDSize = 2,
                            IDchatLieu = 2,
                            TenSP = "Vinh",
                            giaBan = 10000f,
                            giaNhap = 2000f,
                            linkAnh = "",
                            maSP = "SP02",
                            soLuong = 1,
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.size", b =>
                {
                    b.Property<int>("IDSize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDSize"), 1L, 1);

                    b.Property<string>("tenSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDSize");

                    b.ToTable("size", (string)null);

                    b.HasData(
                        new
                        {
                            IDSize = 1,
                            tenSize = "M",
                            trangThai = true
                        },
                        new
                        {
                            IDSize = 2,
                            tenSize = "L",
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.hoaDon", b =>
                {
                    b.HasOne("_1_DAL_QUANLY.Models.nhanVien", "nhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_QUANLY.Models.khachHang", "khachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("SDT_KH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("khachHang");

                    b.Navigation("nhanVien");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.hoaDonChiTiet", b =>
                {
                    b.HasOne("_1_DAL_QUANLY.Models.hoaDon", "hoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IDHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_QUANLY.Models.sanPhamChiTiet", "sanPham")
                        .WithMany("hoaDonChiTiet")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoaDon");

                    b.Navigation("sanPham");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.nhanVien", b =>
                {
                    b.HasOne("_1_DAL_QUANLY.Models.chucVu", "chucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("IDChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("chucVu");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.sanPhamChiTiet", b =>
                {
                    b.HasOne("_1_DAL_QUANLY.Models.hangSX", "hangSX")
                        .WithMany("SanPhamChiTiets")
                        .HasForeignKey("IDHangSX")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_QUANLY.Models.mauSac", "mauSac")
                        .WithMany("SanPhamChiTiets")
                        .HasForeignKey("IDMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_QUANLY.Models.nhaCungCap", "nhaCungCap")
                        .WithMany("SanPhamChiTiets")
                        .HasForeignKey("IDNhaCungCap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_QUANLY.Models.sanPham", "sanPham")
                        .WithMany("SanPhamChiTiets")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_QUANLY.Models.size", "size")
                        .WithMany("SanPhamChiTiets")
                        .HasForeignKey("IDSize")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_QUANLY.Models.chatLieu", "chatLieu")
                        .WithMany("SanphamChitiets")
                        .HasForeignKey("IDchatLieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("chatLieu");

                    b.Navigation("hangSX");

                    b.Navigation("mauSac");

                    b.Navigation("nhaCungCap");

                    b.Navigation("sanPham");

                    b.Navigation("size");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.chatLieu", b =>
                {
                    b.Navigation("SanphamChitiets");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.chucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.hangSX", b =>
                {
                    b.Navigation("SanPhamChiTiets");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.hoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.khachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.mauSac", b =>
                {
                    b.Navigation("SanPhamChiTiets");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.nhaCungCap", b =>
                {
                    b.Navigation("SanPhamChiTiets");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.nhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.sanPham", b =>
                {
                    b.Navigation("SanPhamChiTiets");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.sanPhamChiTiet", b =>
                {
                    b.Navigation("hoaDonChiTiet");
                });

            modelBuilder.Entity("_1_DAL_QUANLY.Models.size", b =>
                {
                    b.Navigation("SanPhamChiTiets");
                });
#pragma warning restore 612, 618
        }
    }
}
