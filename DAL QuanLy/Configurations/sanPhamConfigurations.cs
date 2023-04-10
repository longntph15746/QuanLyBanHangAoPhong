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
    public class sanPhamConfigurations : IEntityTypeConfiguration<sanPham>
    {
        public void Configure(EntityTypeBuilder<sanPham> builder)
        {
            //tên bảng
            builder.ToTable("sanPham");
            //khóa chính
            builder.HasKey(x => x.IDsanPham);
            builder.Property(x => x.IDsanPham).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenSanPham).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
        }
    }
}
