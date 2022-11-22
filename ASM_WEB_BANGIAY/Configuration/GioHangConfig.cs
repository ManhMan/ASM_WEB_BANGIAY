using ASM_WEB_BANGIAY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_WEB_BANGIAY.Configuration
{
    public class GioHangConfig : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.ToTable("GioHangs");
            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).UseIdentityColumn(1, 1);
            builder.HasOne(p => p.NguoiDung).WithMany(p => p.GioHangs).HasForeignKey(p => p.MaNguoiDung);
        }
    }
}
