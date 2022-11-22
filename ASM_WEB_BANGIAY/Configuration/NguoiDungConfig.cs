using ASM_WEB_BANGIAY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM_WEB_BANGIAY.Configuration
{
    public class NguoiDungConfig : IEntityTypeConfiguration<NguoiDung>
    {
        public void Configure(EntityTypeBuilder<NguoiDung> builder)
        {
            builder.ToTable("NguoiDungs");

            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).UseIdentityColumn(1, 1);
            builder.Property(x => x.Ten).HasMaxLength(50).IsRequired();
            builder.Property(x => x.TaiKhoan).HasMaxLength(50).IsRequired();
            builder.Property(x => x.MatKhau).HasMaxLength(50).IsRequired();
            builder.HasOne(p => p.LoaiTaiKhoan).WithMany(p => p.NguoiDungs).HasForeignKey(p => p.MaLoaiTaiKhoan);
            
        }
    }
}
