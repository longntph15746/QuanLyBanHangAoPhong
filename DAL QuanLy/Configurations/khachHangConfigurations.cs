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
    public class khachHangConfigurations : IEntityTypeConfiguration<khachHang>
    {
        public void Configure(EntityTypeBuilder<khachHang> builder)
        {
            builder.ToTable("khachHang");
            // Set khóa chính
            builder.HasKey(x => x.SDT_KH);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.TenKH).IsRequired();
            builder.Property(x => x.diaChi);
            builder.Property(x => x.trangThai);
            builder.Property(x => x.gioiTinh);
        }
    }
}
