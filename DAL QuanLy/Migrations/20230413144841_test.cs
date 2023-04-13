using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL_QuanLy.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "nhanVien",
                keyColumn: "IDNhanVien",
                keyValue: 2,
                column: "email",
                value: "long@gmail.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "nhanVien",
                keyColumn: "IDNhanVien",
                keyValue: 2,
                column: "email",
                value: "nguyenthanhlong081120022@gmail.com");
        }
    }
}
