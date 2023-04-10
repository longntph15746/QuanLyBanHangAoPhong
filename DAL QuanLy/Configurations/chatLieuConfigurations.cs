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
    public class chatLieuConfigurations : IEntityTypeConfiguration<chatLieu>
    {
        public void Configure(EntityTypeBuilder<chatLieu> builder)
        {
            //đặt tên bảng
            builder.ToTable("chatLieu");
            //khóa chính
            builder.HasKey(x => x.IDchatLieu);
            builder.Property(x => x.IDchatLieu).UseIdentityColumn(1, 1);
            //set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenChatLieu).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
        }
    }
}
