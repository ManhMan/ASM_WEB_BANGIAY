using ASM_WEB_BANGIAY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_WEB_BANGIAY.Configuration
{
    public class GioHangChiTietConfig : IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.ToTable("GioHangChiTiets");
            builder.HasKey(x => new { x.MaGioHang, x.MaSP });
            builder.HasOne(x => x.SanPham).WithMany(x => x.GioHangChiTiets).HasForeignKey(x => x.MaSP);
            builder.HasOne(x => x.GioHang).WithMany(x => x.GioHangChiTiets).HasForeignKey(x => x.MaGioHang);
        }
    }
}
