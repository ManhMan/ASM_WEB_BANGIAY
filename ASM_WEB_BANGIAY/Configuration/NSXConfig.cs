using ASM_WEB_BANGIAY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_WEB_BANGIAY.Configuration
{
    public class NSXConfig : IEntityTypeConfiguration<NSX>
    {
        public void Configure(EntityTypeBuilder<NSX> builder)
        {
            builder.ToTable("NSX");

            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).UseIdentityColumn(1, 1);
            builder.Property(x => x.TenNSX).HasMaxLength(50);
        }
    }
}
