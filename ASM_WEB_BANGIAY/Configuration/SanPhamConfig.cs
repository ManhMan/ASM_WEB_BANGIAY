using ASM_WEB_BANGIAY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_WEB_BANGIAY.Configuration
{
    public class SanPhamConfig : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPhams");

            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).UseIdentityColumn(1, 1);
            builder.Property(x => x.TenSP).HasMaxLength(50).IsRequired();
            builder.Property(x => x.SoLuong).HasMaxLength(50).IsRequired();
            builder.HasOne(x => x.NSX).WithMany(x => x.SanPhams).HasForeignKey(x => x.MaNSX);
        }
    }
}
