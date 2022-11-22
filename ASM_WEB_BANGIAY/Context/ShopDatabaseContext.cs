using ASM_WEB_BANGIAY.Configuration;
using ASM_WEB_BANGIAY.Models;
using Microsoft.EntityFrameworkCore;

namespace ASM_WEB_BANGIAY.Context
{
    public class ShopDatabaseContext  : DbContext
    {
        public ShopDatabaseContext()
        {
        }

        public ShopDatabaseContext(DbContextOptions<ShopDatabaseContext> options) : base(options)
        {
        }

        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NSX> NSXs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HoaDonConfig ());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfig());
            modelBuilder.ApplyConfiguration(new LoaiTaiKhoanConfig());
            modelBuilder.ApplyConfiguration(new NguoiDungConfig());
            modelBuilder.ApplyConfiguration(new NSXConfig());
            modelBuilder.ApplyConfiguration(new GioHangConfig());
            modelBuilder.ApplyConfiguration(new GioHangChiTietConfig());
            modelBuilder.ApplyConfiguration(new SanPhamConfig());
            modelBuilder.ApplyConfiguration(new VoucherConfig());
            //modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());

            //modelBuilder.Seed(); //gọi cái này để seeding data
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Lấy code về muốn kết nối database thì phải sửa lại dòng này
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-JNDR021\SQLEXPRESS;Database=ASM_C4;Trusted_Connection=True;");
            }
        }
    }
}
