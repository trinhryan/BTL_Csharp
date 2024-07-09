using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Entities
{
    /// <inheritdoc />
    public partial class up : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Sale__ChucVu__52593CB8",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_ChucVu",
                table: "Sale");

            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "Sale",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MaCV",
                table: "Sale",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Sdt",
                table: "NhaCungCap",
                type: "int",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaCuaHang",
                table: "DonHang",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaCuaHangNavigationMaCuaHang",
                table: "DonHang",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "NgayTao",
                table: "DonHang",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TongTien",
                table: "DonHang",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "DonHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_MaCV",
                table: "Sale",
                column: "MaCV");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_MaCuaHangNavigationMaCuaHang",
                table: "DonHang",
                column: "MaCuaHangNavigationMaCuaHang");

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_CuaHang_MaCuaHangNavigationMaCuaHang",
                table: "DonHang",
                column: "MaCuaHangNavigationMaCuaHang",
                principalTable: "CuaHang",
                principalColumn: "MaCuaHang");

            migrationBuilder.AddForeignKey(
                name: "FK__Sale__ChucVu__52593CB8",
                table: "Sale",
                column: "MaCV",
                principalTable: "ChucVu",
                principalColumn: "MaCV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_CuaHang_MaCuaHangNavigationMaCuaHang",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK__Sale__ChucVu__52593CB8",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_MaCV",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_DonHang_MaCuaHangNavigationMaCuaHang",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "MaCV",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "MaCuaHang",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "MaCuaHangNavigationMaCuaHang",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "TongTien",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "DonHang");

            migrationBuilder.AlterColumn<string>(
                name: "Sdt",
                table: "NhaCungCap",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sale_ChucVu",
                table: "Sale",
                column: "ChucVu");

            migrationBuilder.AddForeignKey(
                name: "FK__Sale__ChucVu__52593CB8",
                table: "Sale",
                column: "ChucVu",
                principalTable: "ChucVu",
                principalColumn: "MaCV");
        }
    }
}
