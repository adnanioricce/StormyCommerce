using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class DeleteBehaviorShipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_CustomerAddress_BillingAddressId",
                table: "Shipment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Shipment_CustomerAddress_DestinationAddressId",
            //    table: "Shipment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Shipment_StormyOrder_StormyOrderId",
            //    table: "Shipment");

            migrationBuilder.DropIndex(
                name: "IX_Shipment_BillingAddressId",
                table: "Shipment");

            migrationBuilder.DropIndex(
                name: "IX_Shipment_DestinationAddressId",
                table: "Shipment");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_BillingAddressId",
                table: "Shipment",
                column: "BillingAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_DestinationAddressId",
                table: "Shipment",
                column: "DestinationAddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_CustomerAddress_BillingAddressId",
                table: "Shipment",
                column: "BillingAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_CustomerAddress_DestinationAddressId",
                table: "Shipment",
                column: "DestinationAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_StormyOrder_StormyOrderId",
                table: "Shipment",
                column: "StormyOrderId",
                principalTable: "StormyOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_CustomerAddress_BillingAddressId",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_CustomerAddress_DestinationAddressId",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_StormyOrder_StormyOrderId",
                table: "Shipment");

            migrationBuilder.DropIndex(
                name: "IX_Shipment_BillingAddressId",
                table: "Shipment");

            migrationBuilder.DropIndex(
                name: "IX_Shipment_DestinationAddressId",
                table: "Shipment");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_BillingAddressId",
                table: "Shipment",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_DestinationAddressId",
                table: "Shipment",
                column: "DestinationAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_CustomerAddress_BillingAddressId",
                table: "Shipment",
                column: "BillingAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_CustomerAddress_DestinationAddressId",
                table: "Shipment",
                column: "DestinationAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_StormyOrder_StormyOrderId",
                table: "Shipment",
                column: "StormyOrderId",
                principalTable: "StormyOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
