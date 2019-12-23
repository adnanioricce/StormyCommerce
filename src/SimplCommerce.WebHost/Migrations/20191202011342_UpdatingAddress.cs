using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class UpdatingAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_StormyCustomerId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAttributeId",
                table: "ProductTemplateProductAttribute");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemplateId",
                table: "ProductTemplateProductAttribute");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId",
                table: "StormyCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId",
                table: "StormyCustomer");

            migrationBuilder.DropIndex(
                name: "IX_StormyCustomer_DefaultBillingAddressId",
                table: "StormyCustomer");

            migrationBuilder.DropIndex(
                name: "IX_StormyCustomer_DefaultShippingAddressId",
                table: "StormyCustomer");

            migrationBuilder.DropColumn(
                name: "DefaultBillingAddressId",
                table: "StormyCustomer");

            migrationBuilder.DropColumn(
                name: "DefaultShippingAddressId",
                table: "StormyCustomer");

            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "CustomerAddress",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "StormyCustomerId1",
                table: "CustomerAddress",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "CustomerAddress",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "config_appsettings",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    Module = table.Column<string>(nullable: true),
                    IsVisibleInCommonSettingPage = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_config_appsettings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_StormyCustomerId1",
                table: "CustomerAddress",
                column: "StormyCustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_StormyCustomerId",
                table: "CustomerAddress",
                column: "StormyCustomerId",
                principalTable: "StormyCustomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_StormyCustomerId1",
                table: "CustomerAddress",
                column: "StormyCustomerId1",
                principalTable: "StormyCustomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAtt~",
                table: "ProductTemplateProductAttribute",
                column: "ProductAttributeId",
                principalTable: "ProductAttribute",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemp~",
                table: "ProductTemplateProductAttribute",
                column: "ProductTemplateId",
                principalTable: "ProductTemplate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_StormyCustomerId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_StormyCustomerId1",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAtt~",
                table: "ProductTemplateProductAttribute");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemp~",
                table: "ProductTemplateProductAttribute");

            migrationBuilder.DropTable(
                name: "config_appsettings");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddress_StormyCustomerId1",
                table: "CustomerAddress");

            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "CustomerAddress");

            migrationBuilder.DropColumn(
                name: "StormyCustomerId1",
                table: "CustomerAddress");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "CustomerAddress");

            migrationBuilder.AddColumn<long>(
                name: "DefaultBillingAddressId",
                table: "StormyCustomer",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DefaultShippingAddressId",
                table: "StormyCustomer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_DefaultBillingAddressId",
                table: "StormyCustomer",
                column: "DefaultBillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_DefaultShippingAddressId",
                table: "StormyCustomer",
                column: "DefaultShippingAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_StormyCustomerId",
                table: "CustomerAddress",
                column: "StormyCustomerId",
                principalTable: "StormyCustomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAttributeId",
                table: "ProductTemplateProductAttribute",
                column: "ProductAttributeId",
                principalTable: "ProductAttribute",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemplateId",
                table: "ProductTemplateProductAttribute",
                column: "ProductTemplateId",
                principalTable: "ProductTemplate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
    }
}
