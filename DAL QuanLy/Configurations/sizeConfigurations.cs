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
    public class sizeConfigurations : IEntityTypeConfiguration<size>
    {
        public void Configure(EntityTypeBuilder<size> builder)
        {
            // Đặt tên bảng
            builder.ToTable("size");
            // Set khóa chính
            builder.HasKey(x => x.IDSize);
            builder.Property(x => x.IDSize).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenSize).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
        }
    }
}
