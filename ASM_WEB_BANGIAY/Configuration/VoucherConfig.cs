using ASM_WEB_BANGIAY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_WEB_BANGIAY.Configuration
{
    public class VoucherConfig : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.ToTable("Voucher");

            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).UseIdentityColumn(1, 1);
            builder.Property(x => x.TenVoucher).HasMaxLength(50).IsRequired();
            builder.Property(x => x.SoLuong).HasMaxLength(50).IsRequired();
        }
    }
}
