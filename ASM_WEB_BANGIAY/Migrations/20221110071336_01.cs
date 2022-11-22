using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASM_WEB_BANGIAY.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiTaiKhoans",
                columns: table => new
                {
                    Ma = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiTK = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTaiKhoans", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "NSX",
                columns: table => new
                {
                    Ma = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNSX = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NSX", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    Ma = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenVoucher = table.Column<string>(maxLength: 50, nullable: false),
                    SoLuong = table.Column<int>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    Ma = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    TaiKhoan = table.Column<string>(maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(maxLength: 50, nullable: false),
                    MaLoaiTaiKhoan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_NguoiDungs_LoaiTaiKhoans_MaLoaiTaiKhoan",
                        column: x => x.MaLoaiTaiKhoan,
                        principalTable: "LoaiTaiKhoans",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    Ma = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNSX = table.Column<int>(nullable: false),
                    TenSP = table.Column<string>(maxLength: 50, nullable: false),
                    GiaNhap = table.Column<decimal>(nullable: false),
                    GiaBan = table.Column<decimal>(nullable: false),
                    NgayNhap = table.Column<DateTime>(nullable: false),
                    SoLuong = table.Column<int>(maxLength: 50, nullable: false),
                    HinhAnh = table.Column<string>(nullable: true),
                    TrangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_SanPhams_NSX_MaNSX",
                        column: x => x.MaNSX,
                        principalTable: "NSX",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangs",
                columns: table => new
                {
                    Ma = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNguoiDung = table.Column<int>(nullable: false),
                    MaVoucher = table.Column<int>(nullable: false),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    TrangThai = table.Column<bool>(nullable: false),
                    TongTien = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_GioHangs_NguoiDungs_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDungs",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    Ma = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNguoiDung = table.Column<int>(nullable: false),
                    MaVoucher = table.Column<int>(nullable: false),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    TrangThai = table.Column<bool>(nullable: false),
                    TongTien = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_HoaDons_NguoiDungs_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDungs",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_Voucher_MaVoucher",
                        column: x => x.MaVoucher,
                        principalTable: "Voucher",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiets",
                columns: table => new
                {
                    MaSP = table.Column<int>(nullable: false),
                    MaGioHang = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    GiaBan = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiets", x => new { x.MaGioHang, x.MaSP });
                    table.ForeignKey(
                        name: "FK_GioHangChiTiets_GioHangs_MaGioHang",
                        column: x => x.MaGioHang,
                        principalTable: "GioHangs",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiets_SanPhams_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPhams",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiets",
                columns: table => new
                {
                    MaSP = table.Column<int>(nullable: false),
                    MaHoaDon = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    GiaBan = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiets", x => new { x.MaHoaDon, x.MaSP });
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_HoaDons_MaHoaDon",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_SanPhams_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPhams",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiets_MaSP",
                table: "GioHangChiTiets",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangs_MaNguoiDung",
                table: "GioHangs",
                column: "MaNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_MaSP",
                table: "HoaDonChiTiets",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaNguoiDung",
                table: "HoaDons",
                column: "MaNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaVoucher",
                table: "HoaDons",
                column: "MaVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDungs_MaLoaiTaiKhoan",
                table: "NguoiDungs",
                column: "MaLoaiTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_MaNSX",
                table: "SanPhams",
                column: "MaNSX");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangChiTiets");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "NguoiDungs");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "NSX");

            migrationBuilder.DropTable(
                name: "LoaiTaiKhoans");
        }
    }
}
