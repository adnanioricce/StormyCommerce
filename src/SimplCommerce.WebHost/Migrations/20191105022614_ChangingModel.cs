using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class ChangingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_ParentId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId",
                table: "StormyCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId",
                table: "StormyCustomer");

            migrationBuilder.DropIndex(
                name: "IX_Category_ParentId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "LatestUpdatedOn",
                table: "StormyProduct");

            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "Category");

            migrationBuilder.AddForeignKey(
                name: "FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId",
                table: "StormyCustomer",
                column: "DefaultBillingAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId",
                table: "StormyCustomer",
                column: "DefaultShippingAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId",
                table: "StormyCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId",
                table: "StormyCustomer");

            migrationBuilder.AddColumn<DateTime>(
                name: "LatestUpdatedOn",
                table: "StormyProduct",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "Category",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "Category",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "Category",
                maxLength: 450,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentId",
                table: "Category",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_ParentId",
                table: "Category",
                column: "ParentId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId",
                table: "StormyCustomer",
                column: "DefaultBillingAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId",
                table: "StormyCustomer",
                column: "DefaultShippingAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
