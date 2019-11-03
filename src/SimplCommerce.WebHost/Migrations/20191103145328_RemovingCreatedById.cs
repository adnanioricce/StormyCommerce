using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class RemovingCreatedById : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "StormyProduct");

            migrationBuilder.DropColumn(
                name: "ProductMediaId",
                table: "StormyProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CreatedById",
                table: "StormyProduct",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ProductMediaId",
                table: "StormyProduct",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
