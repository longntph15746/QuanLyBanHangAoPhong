using _1_DAL_QUANLY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Configurations
{
    public class hoaDonChiTietConfigurations : IEntityTypeConfiguration<hoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<hoaDonChiTiet> builder)
        {
            // Đặt tên bảng
            builder.ToTable("hoaDonChiTiet");
            // Set khóa chính
            builder.HasKey(x => new { x.IDHoaDon, x.IDSanPham });
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.Soluong).IsRequired();
            builder.Property(x => x.donGia).IsRequired();
            builder.Property(x => x.Trangthai).IsRequired();
            builder.HasOne(x => x.sanPham)
                .WithMany(x => x.hoaDonChiTiet).HasForeignKey(x => x.IDSanPham);
            builder.HasOne(x => x.hoaDon)
                .WithMany(x => x.HoaDonChiTiets).HasForeignKey(x => x.IDHoaDon);
        }
    }
}
