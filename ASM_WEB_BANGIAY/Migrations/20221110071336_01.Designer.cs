// <auto-generated />
using System;
using ASM_WEB_BANGIAY.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASM_WEB_BANGIAY.Migrations
{
    [DbContext(typeof(ShopDatabaseContext))]
    [Migration("20221110071336_01")]
    partial class _01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.GioHang", b =>
                {
                    b.Property<int>("Ma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<int>("MaVoucher")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Ma");

                    b.HasIndex("MaNguoiDung");

                    b.ToTable("GioHangs");
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.GioHangChiTiet", b =>
                {
                    b.Property<int>("MaGioHang")
                        .HasColumnType("int");

                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaGioHang", "MaSP");

                    b.HasIndex("MaSP");

                    b.ToTable("GioHangChiTiets");
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.HoaDon", b =>
                {
                    b.Property<int>("Ma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<int>("MaVoucher")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Ma");

                    b.HasIndex("MaNguoiDung");

                    b.HasIndex("MaVoucher");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.HoaDonChiTiet", b =>
                {
                    b.Property<int>("MaHoaDon")
                        .HasColumnType("int");

                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaHoaDon", "MaSP");

                    b.HasIndex("MaSP");

                    b.ToTable("HoaDonChiTiets");
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.LoaiTaiKhoan", b =>
                {
                    b.Property<int>("Ma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoaiTK")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Ma");

                    b.ToTable("LoaiTaiKhoans");
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.NSX", b =>
                {
                    b.Property<int>("Ma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenNSX")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Ma");

                    b.ToTable("NSX");
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.NguoiDung", b =>
                {
                    b.Property<int>("Ma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaLoaiTaiKhoan")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Ma");

                    b.HasIndex("MaLoaiTaiKhoan");

                    b.ToTable("NguoiDungs");
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.SanPham", b =>
                {
                    b.Property<int>("Ma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaNSX")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Ma");

                    b.HasIndex("MaNSX");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.Voucher", b =>
                {
                    b.Property<int>("Ma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SoLuong")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<string>("TenVoucher")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Ma");

                    b.ToTable("Voucher");
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.GioHang", b =>
                {
                    b.HasOne("ASM_WEB_BANGIAY.Models.NguoiDung", "NguoiDung")
                        .WithMany("GioHangs")
                        .HasForeignKey("MaNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.GioHangChiTiet", b =>
                {
                    b.HasOne("ASM_WEB_BANGIAY.Models.GioHang", "GioHang")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("MaGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM_WEB_BANGIAY.Models.SanPham", "SanPham")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.HoaDon", b =>
                {
                    b.HasOne("ASM_WEB_BANGIAY.Models.NguoiDung", "NguoiDung")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM_WEB_BANGIAY.Models.Voucher", "Voucher")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaVoucher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("ASM_WEB_BANGIAY.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("MaHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM_WEB_BANGIAY.Models.SanPham", "SanPham")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.NguoiDung", b =>
                {
                    b.HasOne("ASM_WEB_BANGIAY.Models.LoaiTaiKhoan", "LoaiTaiKhoan")
                        .WithMany("NguoiDungs")
                        .HasForeignKey("MaLoaiTaiKhoan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASM_WEB_BANGIAY.Models.SanPham", b =>
                {
                    b.HasOne("ASM_WEB_BANGIAY.Models.NSX", "NSX")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaNSX")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
