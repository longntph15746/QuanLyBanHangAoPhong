using _1_DAL_QUANLY.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Configurations
{
    public class sanPhamChiTietConfigurations : IEntityTypeConfiguration<sanPhamChiTiet>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<sanPhamChiTiet> builder)
        {
            builder.ToTable("sanPhamChiTiet");
            builder.HasKey(c => c.IDSanPhamChiTiet);
            builder.Property(x => x.IDSanPhamChiTiet).UseIdentityColumn(1, 1);
            builder.Property(c => c.maSP).IsRequired();
            builder.Property(c => c.TenSP).IsRequired();
            builder.Property(c => c.giaNhap).IsRequired();
            builder.Property(c => c.giaBan).IsRequired();
            builder.Property(c => c.soLuong).IsRequired();
            builder.Property(c => c.trangThai).IsRequired();
            builder.Property(c => c.linkAnh).IsRequired();
            builder.HasOne(x => x.size)
           .WithMany(g => g.SanPhamChiTiets).HasForeignKey(p => p.IDSize);
            builder.HasOne(x => x.sanPham)
           .WithMany(g => g.SanPhamChiTiets).HasForeignKey(p => p.IDSanPham);
            builder.HasOne(x => x.mauSac)
           .WithMany(g => g.SanPhamChiTiets).HasForeignKey(p => p.IDMauSac);
            builder.HasOne(x => x.hangSX)
          .WithMany(g => g.SanPhamChiTiets).HasForeignKey(p => p.IDHangSX);
            builder.HasOne(x => x.nhaCungCap)
         .WithMany(g => g.SanPhamChiTiets).HasForeignKey(p => p.IDNhaCungCap);
            builder.HasOne(x => x.chatLieu)
         .WithMany(g => g.SanphamChitiets).HasForeignKey(p => p.IDchatLieu);
        }
    }
}
