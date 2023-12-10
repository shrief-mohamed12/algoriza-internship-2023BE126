using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vezeeta.Repository.Migrations
{
    public partial class UpdateCouponTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Coupons");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Coupons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Coupons");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "Coupons",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
