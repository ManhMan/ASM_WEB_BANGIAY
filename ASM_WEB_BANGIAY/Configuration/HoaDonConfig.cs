using ASM_WEB_BANGIAY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_WEB_BANGIAY.Configuration
{
    public class HoaDonConfig : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDons");

            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).UseIdentityColumn(1, 1);
            builder.HasOne(p => p.Voucher).WithMany(p => p.HoaDons).HasForeignKey(p => p.MaVoucher);
            builder.HasOne(p => p.NguoiDung).WithMany(p => p.HoaDons).HasForeignKey(p => p.MaNguoiDung);
        }
    }
}
