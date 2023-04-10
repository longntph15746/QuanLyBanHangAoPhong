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
    public class hoaDonConfigurations : IEntityTypeConfiguration<hoaDon>
    {
        public void Configure(EntityTypeBuilder<hoaDon> builder)
        {
            // Đặt tên bảng
            builder.ToTable("hoaDon");
            // Set khóa chính
            builder.HasKey(x => x.IDHoaDon);
            builder.Property(x => x.IDHoaDon).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.ngayBan).IsRequired();
            builder.Property(x => x.tongTien).IsRequired();
            builder.Property(x => x.ghiChu).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
            builder.HasOne(x => x.khachHang)
            .WithMany(g => g.HoaDons).HasForeignKey(p => p.SDT_KH);
            builder.HasOne(x => x.nhanVien)
            .WithMany(g => g.HoaDons).HasForeignKey(p => p.IDNhanVien);
        }
    }
}
