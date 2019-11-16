using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class ChangeWishListModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateOfBirth",
                table: "StormyCustomer",
                nullable: true,
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AddColumn<long>(
                name: "CustomerWishlistId1",
                table: "StormyCustomer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_CustomerWishlistId1",
                table: "StormyCustomer",
                column: "CustomerWishlistId1");

            migrationBuilder.AddForeignKey(
                name: "FK_StormyCustomer_Wishlist_CustomerWishlistId1",
                table: "StormyCustomer",
                column: "CustomerWishlistId1",
                principalTable: "Wishlist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StormyCustomer_Wishlist_CustomerWishlistId1",
                table: "StormyCustomer");

            migrationBuilder.DropIndex(
                name: "IX_StormyCustomer_CustomerWishlistId1",
                table: "StormyCustomer");

            migrationBuilder.DropColumn(
                name: "CustomerWishlistId1",
                table: "StormyCustomer");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateOfBirth",
                table: "StormyCustomer",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true);
        }
    }
}
