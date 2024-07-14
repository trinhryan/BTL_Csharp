using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Entities
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cau_hoi",
                columns: table => new
                {
                    ma_cau_hoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noi_dung = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    dap_an_a = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    dap_an_b = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    dap_an_c = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    dap_an_d = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    dap_an_dung = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__cau_hoi__2EB8A2ADAFA085C1", x => x.ma_cau_hoi);
                });

            migrationBuilder.CreateTable(
                name: "tai_khoan",
                columns: table => new
                {
                    ten_dang_nhap = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    mat_khau = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    quyen = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tai_khoa__363698B26A940221", x => x.ten_dang_nhap);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cau_hoi");

            migrationBuilder.DropTable(
                name: "tai_khoan");
        }
    }
}
