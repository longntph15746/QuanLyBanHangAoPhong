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
    public class nhaCungCapConfigurations : IEntityTypeConfiguration<nhaCungCap>
    {
        public void Configure(EntityTypeBuilder<nhaCungCap> builder)
        {
            // Đặt tên bảng
            builder.ToTable("nhaCungCap");
            // Set khóa chính
            builder.HasKey(x => x.IDNhaCungCap);
            builder.Property(x => x.IDNhaCungCap).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenNhaCungCap).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
        }
    }
}
