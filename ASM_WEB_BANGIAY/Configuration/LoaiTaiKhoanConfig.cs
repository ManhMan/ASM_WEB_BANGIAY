using ASM_WEB_BANGIAY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_WEB_BANGIAY.Configuration
{
    public class LoaiTaiKhoanConfig : IEntityTypeConfiguration<LoaiTaiKhoan>
    {
        public void Configure(EntityTypeBuilder<LoaiTaiKhoan> builder)
        {
            builder.ToTable("LoaiTaiKhoans");

            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).UseIdentityColumn(1, 1);
            builder.Property(x => x.TenLoaiTK).HasMaxLength(50).IsRequired();

        }
    }
}
