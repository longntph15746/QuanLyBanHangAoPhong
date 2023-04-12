using _1_DAL_QUANLY.Configurations;
using _1_DAL_QUANLY.Extensions;
using _1_DAL_QUANLY.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-QLJVQ0K;Initial Catalog=TshirtProject;Trusted_Connection=True;Integrated Security=True");
            }
        }
        public DbSet<chucVu> chucVus { get; set; }
        public DbSet<hangSX> hangSXs { get; set; }
        public DbSet<nhaCungCap> nhaCungCaps { get; set; }
        public DbSet<chatLieu> chatLieus { get; set; }
        public DbSet<mauSac> mauSacs { get; set; }
        public DbSet<size> sizes { get; set; }
        public DbSet<hoaDon> hoaDons { get; set; }
        public DbSet<hoaDonChiTiet> hoaDonChiTiets { get; set; }
        public DbSet<sanPham> sanPhams { get; set; }
        public DbSet<sanPhamChiTiet> sanPhamCTs { get; set; }
        public DbSet<nhanVien> nhanViens { get; set; }
        public DbSet<khachHang> khachHangs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new chucVuConfigurations());
            modelBuilder.ApplyConfiguration(new hangSXConfigurations());
            modelBuilder.ApplyConfiguration(new nhaCungCapConfigurations());
            modelBuilder.ApplyConfiguration(new chatLieuConfigurations());
            modelBuilder.ApplyConfiguration(new mauSacConfigurations());
            modelBuilder.ApplyConfiguration(new sizeConfigurations());
            modelBuilder.ApplyConfiguration(new hoaDonConfigurations());
            modelBuilder.ApplyConfiguration(new hoaDonChiTietConfigurations());
            modelBuilder.ApplyConfiguration(new nhanVienConfigurations());
            modelBuilder.ApplyConfiguration(new khachHangConfigurations());
            modelBuilder.ApplyConfiguration(new sanPhamConfigurations());
            modelBuilder.ApplyConfiguration(new sanPhamChiTietConfigurations());
            //seeding data
            modelBuilder.Seed();
        }
    }
}
