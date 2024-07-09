using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Entities
{
    /// <inheritdoc />
    public partial class AddNewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaCV = table.Column<int>(type: "int", nullable: false),
                    TenCV = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChucVu__27258E76CB839769", x => x.MaCV);
                });

            migrationBuilder.CreateTable(
                name: "CuaHang",
                columns: table => new
                {
                    MaCuaHang = table.Column<int>(type: "int", nullable: false),
                    TenCuaHang = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DiaChi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CuaHang__0840BCA6C880D736", x => x.MaCuaHang);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false),
                    TenKH = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SDT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DiaChi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KhachHan__2725CF1E9E12D26C", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    TenDangNhap = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    HoTen = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MatKhau = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GioiTinh = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SDT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DiaChi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NguoiDun__55F68FC1745B5175", x => x.TenDangNhap);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaNCC = table.Column<int>(type: "int", nullable: false),
                    TenNCC = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DiaChi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Sdt = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhaCungC__3A185DEB39898FA7", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TenSP = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    GiaSP = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    HSD = table.Column<DateOnly>(type: "date", nullable: true),
                    NSX = table.Column<DateOnly>(type: "date", nullable: true),
                    PhanLoaiSP = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SanPham__2725081C391B8501", x => x.MaSP);
                });

            migrationBuilder.CreateTable(
                name: "QuanLy",
                columns: table => new
                {
                    MaQL = table.Column<int>(type: "int", nullable: false),
                    TenQL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SDT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DiaChi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NgaySinh = table.Column<DateOnly>(type: "date", nullable: true),
                    GioiTinh = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    MaCV = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuanLy__2725F8529CFD4029", x => x.MaQL);
                    table.ForeignKey(
                        name: "FK__QuanLy__MaCV__4F7CD00D",
                        column: x => x.MaCV,
                        principalTable: "ChucVu",
                        principalColumn: "MaCV");
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    MaDH = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<int>(type: "int", nullable: true),
                    MaKH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DonHang__27258661E9C30AA0", x => x.MaDH);
                    table.ForeignKey(
                        name: "FK__DonHang__MaKH__5CD6CB2B",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH");
                    table.ForeignKey(
                        name: "FK__DonHang__MaSP__5BE2A6F2",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<int>(type: "int", nullable: false),
                    MaSp = table.Column<int>(type: "int", nullable: false),
                    TenSp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    NgayBan = table.Column<DateOnly>(type: "date", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    MaQL = table.Column<int>(type: "int", nullable: true),
                    MaSpNavigationMaSp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDon__2725A6E008FED14D", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_SanPham_MaSpNavigationMaSp",
                        column: x => x.MaSpNavigationMaSp,
                        principalTable: "SanPham",
                        principalColumn: "MaSP");
                    table.ForeignKey(
                        name: "FK__HoaDon__MaQL__6477ECF3",
                        column: x => x.MaQL,
                        principalTable: "QuanLy",
                        principalColumn: "MaQL");
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhap",
                columns: table => new
                {
                    MaPN = table.Column<int>(type: "int", nullable: false),
                    NgayNhap = table.Column<DateOnly>(type: "date", nullable: true),
                    MaNCC = table.Column<int>(type: "int", nullable: true),
                    SdtNcc = table.Column<int>(type: "int", nullable: true),
                    MaSp = table.Column<int>(type: "int", nullable: false),
                    MaCuaHang = table.Column<int>(type: "int", nullable: true),
                    TongTienHang = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    MaQL = table.Column<int>(type: "int", nullable: true),
                    MaSpNavigationMaSp = table.Column<int>(type: "int", nullable: true),
                    MaCuaHangNavigationMaCuaHang = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PhieuNha__2725E7F0A1544A75", x => x.MaPN);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_CuaHang_MaCuaHangNavigationMaCuaHang",
                        column: x => x.MaCuaHangNavigationMaCuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "MaCuaHang");
                    table.ForeignKey(
                        name: "FK_PhieuNhap_SanPham_MaSpNavigationMaSp",
                        column: x => x.MaSpNavigationMaSp,
                        principalTable: "SanPham",
                        principalColumn: "MaSP");
                    table.ForeignKey(
                        name: "FK__PhieuNhap__MaNCC__693CA210",
                        column: x => x.MaNCC,
                        principalTable: "NhaCungCap",
                        principalColumn: "MaNCC");
                    table.ForeignKey(
                        name: "FK__PhieuNhap__MaQL__6A30C649",
                        column: x => x.MaQL,
                        principalTable: "QuanLy",
                        principalColumn: "MaQL");
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    MaSale = table.Column<int>(type: "int", nullable: false),
                    TenSale = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NgaySinh = table.Column<DateOnly>(type: "date", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ChucVu = table.Column<int>(type: "int", nullable: true),
                    MaCuaHang = table.Column<int>(type: "int", nullable: true),
                    SL = table.Column<int>(type: "int", nullable: true),
                    MaQL = table.Column<int>(type: "int", nullable: true),
                    TenDangNhap = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sale__B234B7A748EE0427", x => x.MaSale);
                    table.ForeignKey(
                        name: "FK__Sale__ChucVu__52593CB8",
                        column: x => x.ChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaCV");
                    table.ForeignKey(
                        name: "FK__Sale__CuaHang__534D60F1",
                        column: x => x.MaCuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "MaCuaHang");
                    table.ForeignKey(
                        name: "FK__Sale__MaQL__5441852A",
                        column: x => x.MaQL,
                        principalTable: "QuanLy",
                        principalColumn: "MaQL");
                    table.ForeignKey(
                        name: "FK__Sale__TenDangNha__5535A963",
                        column: x => x.TenDangNhap,
                        principalTable: "NguoiDung",
                        principalColumn: "TenDangNhap");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHang",
                columns: table => new
                {
                    MaDH = table.Column<int>(type: "int", nullable: true),
                    NgayTao = table.Column<DateOnly>(type: "date", nullable: true),
                    CuaHang = table.Column<int>(type: "int", nullable: true),
                    MaKH = table.Column<int>(type: "int", nullable: true),
                    TenKH = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SDT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MaSP = table.Column<int>(type: "int", nullable: true),
                    TenSP = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SoLuongSP = table.Column<int>(type: "int", nullable: true),
                    TongGiaTien = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__ChiTietDo__CuaHa__5FB337D6",
                        column: x => x.CuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "MaCuaHang");
                    table.ForeignKey(
                        name: "FK__ChiTietDon__MaDH__5EBF139D",
                        column: x => x.MaDH,
                        principalTable: "DonHang",
                        principalColumn: "MaDH");
                    table.ForeignKey(
                        name: "FK__ChiTietDon__MaKH__60A75C0F",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH");
                    table.ForeignKey(
                        name: "FK__ChiTietDon__MaSP__619B8048",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP");
                });

            migrationBuilder.CreateTable(
                name: "PhieuXuat",
                columns: table => new
                {
                    MaPX = table.Column<int>(type: "int", nullable: false),
                    MaCuaHang = table.Column<int>(type: "int", nullable: false),
                    NgayXuat = table.Column<DateOnly>(type: "date", nullable: true),
                    MaQL = table.Column<int>(type: "int", nullable: true),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNVNavigationMaSale = table.Column<int>(type: "int", nullable: true),
                    MaSPNavigationMaSp = table.Column<int>(type: "int", nullable: true),
                    MaCuaHangNavigationMaCuaHang = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PhieuXua__2725E7CA7610C990", x => x.MaPX);
                    table.ForeignKey(
                        name: "FK_PhieuXuat_CuaHang_MaCuaHangNavigationMaCuaHang",
                        column: x => x.MaCuaHangNavigationMaCuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "MaCuaHang");
                    table.ForeignKey(
                        name: "FK_PhieuXuat_Sale_MaNVNavigationMaSale",
                        column: x => x.MaNVNavigationMaSale,
                        principalTable: "Sale",
                        principalColumn: "MaSale");
                    table.ForeignKey(
                        name: "FK_PhieuXuat_SanPham_MaSPNavigationMaSp",
                        column: x => x.MaSPNavigationMaSp,
                        principalTable: "SanPham",
                        principalColumn: "MaSP");
                    table.ForeignKey(
                        name: "FK__PhieuXuat__MaQL__6D0D32F4",
                        column: x => x.MaQL,
                        principalTable: "QuanLy",
                        principalColumn: "MaQL");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_CuaHang",
                table: "ChiTietDonHang",
                column: "CuaHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_MaDH",
                table: "ChiTietDonHang",
                column: "MaDH");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_MaKH",
                table: "ChiTietDonHang",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_MaSP",
                table: "ChiTietDonHang",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_MaKH",
                table: "DonHang",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_MaSP",
                table: "DonHang",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaQL",
                table: "HoaDon",
                column: "MaQL");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaSpNavigationMaSp",
                table: "HoaDon",
                column: "MaSpNavigationMaSp");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_MaCuaHangNavigationMaCuaHang",
                table: "PhieuNhap",
                column: "MaCuaHangNavigationMaCuaHang");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_MaNCC",
                table: "PhieuNhap",
                column: "MaNCC");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_MaQL",
                table: "PhieuNhap",
                column: "MaQL");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_MaSpNavigationMaSp",
                table: "PhieuNhap",
                column: "MaSpNavigationMaSp");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuat_MaCuaHangNavigationMaCuaHang",
                table: "PhieuXuat",
                column: "MaCuaHangNavigationMaCuaHang");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuat_MaNVNavigationMaSale",
                table: "PhieuXuat",
                column: "MaNVNavigationMaSale");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuat_MaQL",
                table: "PhieuXuat",
                column: "MaQL");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuat_MaSPNavigationMaSp",
                table: "PhieuXuat",
                column: "MaSPNavigationMaSp");

            migrationBuilder.CreateIndex(
                name: "IX_QuanLy_MaCV",
                table: "QuanLy",
                column: "MaCV");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_ChucVu",
                table: "Sale",
                column: "ChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_MaCuaHang",
                table: "Sale",
                column: "MaCuaHang");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_MaQL",
                table: "Sale",
                column: "MaQL");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_TenDangNhap",
                table: "Sale",
                column: "TenDangNhap");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDonHang");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "PhieuNhap");

            migrationBuilder.DropTable(
                name: "PhieuXuat");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "CuaHang");

            migrationBuilder.DropTable(
                name: "QuanLy");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
