using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class UpdateThatIDontKnowWhatIDo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationRole");

            migrationBuilder.DropIndex(
                name: "IX_StormyCustomer_CustomerWishlistId",
                table: "StormyCustomer");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "StormyCustomer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 450, nullable: false),
                    Body = table.Column<string>(maxLength: 450, nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    StormyCustomerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_StormyProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_StormyCustomer_StormyCustomerId",
                        column: x => x.StormyCustomerId,
                        principalTable: "StormyCustomer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_CustomerWishlistId",
                table: "StormyCustomer",
                column: "CustomerWishlistId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_RoleId",
                table: "StormyCustomer",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProductId",
                table: "Comment",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_StormyCustomerId",
                table: "Comment",
                column: "StormyCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_StormyCustomer_AspNetRoles_RoleId",
                table: "StormyCustomer",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StormyCustomer_AspNetRoles_RoleId",
                table: "StormyCustomer");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_StormyCustomer_CustomerWishlistId",
                table: "StormyCustomer");

            migrationBuilder.DropIndex(
                name: "IX_StormyCustomer_RoleId",
                table: "StormyCustomer");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "StormyCustomer");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "ApplicationRole",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    StormyCustomerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationRole_StormyCustomer_StormyCustomerId",
                        column: x => x.StormyCustomerId,
                        principalTable: "StormyCustomer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_CustomerWishlistId",
                table: "StormyCustomer",
                column: "CustomerWishlistId",
                unique: true,
                filter: "[CustomerWishlistId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRole_StormyCustomerId",
                table: "ApplicationRole",
                column: "StormyCustomerId");
        }
    }
}
