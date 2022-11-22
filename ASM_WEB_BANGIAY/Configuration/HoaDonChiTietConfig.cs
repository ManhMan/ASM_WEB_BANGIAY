using ASM_WEB_BANGIAY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_WEB_BANGIAY.Configuration
{
    public class HoaDonChiTietConfig : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiets");
            builder.HasKey(x => new { x.MaHoaDon, x.MaSP });
            builder.HasOne(x => x.SanPham).WithMany(x => x.HoaDonChiTiets).HasForeignKey(x => x.MaSP);
            builder.HasOne(x => x.HoaDon).WithMany(x => x.HoaDonChiTiets).HasForeignKey(x => x.MaHoaDon);
        }
    }
}
