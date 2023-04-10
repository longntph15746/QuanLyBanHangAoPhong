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
    public class nhanVienConfigurations : IEntityTypeConfiguration<nhanVien>
    {
        public void Configure(EntityTypeBuilder<nhanVien> builder)
        {
            //đặt tên bảng
            builder.ToTable("nhanVien");
            //khóa chính
            builder.HasKey(x => x.IDNhanVien);
            builder.Property(x => x.IDNhanVien).UseIdentityColumn(1, 1);
            //ràng buộc
            builder.Property(x => x.tenNV).IsRequired();
            builder.Property(x => x.SDT).IsRequired();
            builder.Property(x => x.email).IsRequired();
            builder.Property(x => x.matKhau).IsRequired();
            builder.Property(x => x.tinhTrang).IsRequired();
            builder.HasOne(x => x.chucVu).WithMany(g => g.NhanViens).HasForeignKey(p => p.IDChucVu);
        }
    }
}
