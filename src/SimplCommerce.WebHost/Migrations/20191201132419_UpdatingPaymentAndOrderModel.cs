using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class UpdatingPaymentAndOrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_OwnerId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Shipment_ShipmentId",
                table: "OrderItem");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddress_OwnerId",
                table: "CustomerAddress");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "CustomerAddress");

            migrationBuilder.RenameColumn(
                name: "Address_Street",
                table: "CustomerAddress",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Address_State",
                table: "CustomerAddress",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Address_SecondAddress",
                table: "CustomerAddress",
                newName: "SecondAddress");

            migrationBuilder.RenameColumn(
                name: "Address_PostalCode",
                table: "CustomerAddress",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "Address_Number",
                table: "CustomerAddress",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "Address_FirstAddress",
                table: "CustomerAddress",
                newName: "FirstAddress");

            migrationBuilder.RenameColumn(
                name: "Address_District",
                table: "CustomerAddress",
                newName: "District");

            migrationBuilder.RenameColumn(
                name: "Address_Country",
                table: "CustomerAddress",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Address_Complement",
                table: "CustomerAddress",
                newName: "Complement");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "CustomerAddress",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CustomerAddress",
                newName: "StormyCustomerId");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "VendorAddress",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<long>(
                name: "ShipmentId",
                table: "OrderItem",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderItem",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "StormyPayment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OrderId = table.Column<long>(nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    PaidOutAt = table.Column<DateTimeOffset>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    PaymentFee = table.Column<decimal>(nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false),
                    GatewayTransactionId = table.Column<string>(nullable: true),
                    PaymentStatus = table.Column<int>(nullable: false),
                    FailureMessage = table.Column<string>(nullable: true),
                    BoletoUrl = table.Column<string>(nullable: true),
                    BoletoBarcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StormyPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StormyPayment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StormyShipment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OrderId = table.Column<long>(nullable: false),
                    TrackNumber = table.Column<string>(maxLength: 250, nullable: true),
                    ShipmentMethod = table.Column<int>(nullable: false),
                    ShipmentProvider = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<double>(nullable: false),
                    TotalHeight = table.Column<double>(nullable: false),
                    TotalWidth = table.Column<double>(nullable: false),
                    TotalLength = table.Column<double>(nullable: false),
                    TotalArea = table.Column<double>(nullable: false),
                    CubeRoot = table.Column<double>(nullable: false),
                    SafeAmount = table.Column<decimal>(nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    ShippedDate = table.Column<DateTimeOffset>(nullable: true),
                    DeliveryDate = table.Column<DateTimeOffset>(nullable: true),
                    ExpectedDeliveryDate = table.Column<DateTimeOffset>(nullable: true),
                    ExpectedHourOfDay = table.Column<DateTimeOffset>(nullable: true),
                    DeliveryCost = table.Column<decimal>(nullable: false),
                    DestinationAddressId = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StormyShipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StormyShipment_CustomerAddress_DestinationAddressId",
                        column: x => x.DestinationAddressId,
                        principalTable: "CustomerAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StormyShipment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_StormyCustomerId",
                table: "CustomerAddress",
                column: "StormyCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyPayment_OrderId",
                table: "StormyPayment",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StormyShipment_DestinationAddressId",
                table: "StormyShipment",
                column: "DestinationAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StormyShipment_OrderId",
                table: "StormyShipment",
                column: "OrderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_StormyCustomerId",
                table: "CustomerAddress",
                column: "StormyCustomerId",
                principalTable: "StormyCustomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_StormyShipment_ShipmentId",
                table: "OrderItem",
                column: "ShipmentId",
                principalTable: "StormyShipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_StormyCustomerId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_StormyShipment_ShipmentId",
                table: "OrderItem");

            migrationBuilder.DropTable(
                name: "StormyPayment");

            migrationBuilder.DropTable(
                name: "StormyShipment");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddress_StormyCustomerId",
                table: "CustomerAddress");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "CustomerAddress",
                newName: "Address_Street");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "CustomerAddress",
                newName: "Address_State");

            migrationBuilder.RenameColumn(
                name: "SecondAddress",
                table: "CustomerAddress",
                newName: "Address_SecondAddress");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "CustomerAddress",
                newName: "Address_PostalCode");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "CustomerAddress",
                newName: "Address_Number");

            migrationBuilder.RenameColumn(
                name: "FirstAddress",
                table: "CustomerAddress",
                newName: "Address_FirstAddress");

            migrationBuilder.RenameColumn(
                name: "District",
                table: "CustomerAddress",
                newName: "Address_District");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "CustomerAddress",
                newName: "Address_Country");

            migrationBuilder.RenameColumn(
                name: "Complement",
                table: "CustomerAddress",
                newName: "Address_Complement");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "CustomerAddress",
                newName: "Address_City");

            migrationBuilder.RenameColumn(
                name: "StormyCustomerId",
                table: "CustomerAddress",
                newName: "UserId");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "VendorAddress",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<decimal>(
                name: "Tax",
                table: "Order",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<long>(
                name: "ShipmentId",
                table: "OrderItem",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "OrderItem",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "CustomerAddress",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Amount = table.Column<decimal>(nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    FailureMessage = table.Column<string>(nullable: true),
                    GatewayTransactionId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    PaymentFee = table.Column<decimal>(nullable: false),
                    PaymentMethod = table.Column<string>(nullable: true),
                    PaymentStatus = table.Column<int>(nullable: false),
                    OrderId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BillingAddressId = table.Column<long>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CubeRoot = table.Column<double>(nullable: false),
                    DeliveryCost = table.Column<decimal>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: true),
                    DestinationAddressId = table.Column<long>(nullable: false),
                    ExpectedDeliveryDate = table.Column<DateTime>(nullable: true),
                    ExpectedHourOfDay = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    SafeAmount = table.Column<decimal>(nullable: false),
                    ShipmentMethod = table.Column<string>(nullable: true),
                    ShipmentProvider = table.Column<string>(nullable: true),
                    ShipmentServiceName = table.Column<string>(nullable: true),
                    ShippedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    OrderId = table.Column<long>(nullable: false),
                    TotalArea = table.Column<double>(nullable: false),
                    TotalHeight = table.Column<double>(nullable: false),
                    TotalLength = table.Column<double>(nullable: false),
                    TotalWeight = table.Column<double>(nullable: false),
                    TotalWidth = table.Column<double>(nullable: false),
                    TrackNumber = table.Column<string>(maxLength: 250, nullable: true),
                    WhoReceives = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipment_CustomerAddress_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "CustomerAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipment_CustomerAddress_DestinationAddressId",
                        column: x => x.DestinationAddressId,
                        principalTable: "CustomerAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_OwnerId",
                table: "CustomerAddress",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_OrderId",
                table: "Shipment",
                column: "OrderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_OwnerId",
                table: "CustomerAddress",
                column: "OwnerId",
                principalTable: "StormyCustomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Shipment_ShipmentId",
                table: "OrderItem",
                column: "ShipmentId",
                principalTable: "Shipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
