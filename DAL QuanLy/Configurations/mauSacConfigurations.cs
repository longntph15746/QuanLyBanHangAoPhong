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
    public class mauSacConfigurations : IEntityTypeConfiguration<mauSac>
    {
        public void Configure(EntityTypeBuilder<mauSac> builder)
        {
            // Đặt tên bảng
            builder.ToTable("mauSac");
            // Set khóa chính
            builder.HasKey(x => x.IDMauSac);
            builder.Property(x => x.IDMauSac).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenMau).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
        }
    }
}
