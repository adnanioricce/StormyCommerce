using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class ProductMediaWithProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMedia_StormyProduct_StormyProductId",
                table: "ProductMedia");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMedia_StormyProduct_StormyProductId",
                table: "ProductMedia",
                column: "StormyProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMedia_StormyProduct_StormyProductId",
                table: "ProductMedia");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMedia_StormyProduct_StormyProductId",
                table: "ProductMedia",
                column: "StormyProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
