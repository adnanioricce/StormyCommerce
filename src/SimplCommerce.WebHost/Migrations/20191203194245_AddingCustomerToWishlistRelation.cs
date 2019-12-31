using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class AddingCustomerToWishlistRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_StormyProduct_ProductId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_StormyCustomer_StormyCustomerId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_StormyCustomerId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_StormyCustomerId1",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_StormyShipment_ShipmentId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_StormyProduct_StormyProductId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttributeValue_StormyProduct_ProductId",
                table: "ProductAttributeValue");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_StormyProduct_ProductId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLink_StormyProduct_LinkedProductId",
                table: "ProductLink");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLink_StormyProduct_ProductId",
                table: "ProductLink");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMedia_StormyProduct_StormyProductId",
                table: "ProductMedia");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOptionCombination_StormyProduct_ProductId",
                table: "ProductOptionCombination");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOptionValue_StormyProduct_ProductId",
                table: "ProductOptionValue");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTemplate_StormyProduct_StormyProductId",
                table: "ProductTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_StormyCustomer_StormyCustomerId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_StormyProduct_StormyProductId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyCustomer_Wishlist_CustomerWishlistId",
                table: "StormyCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyCustomer_Wishlist_CustomerWishlistId1",
                table: "StormyCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyCustomer_AspNetRoles_RoleId",
                table: "StormyCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stock_StockId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_StormyCustomer_StormyCustomerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyPayment_Order_OrderId",
                table: "StormyPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyProduct_Brand_BrandId",
                table: "StormyProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyProduct_Stock_StockId",
                table: "StormyProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyProduct_StormyVendor_VendorId",
                table: "StormyProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyShipment_CustomerAddress_DestinationAddressId",
                table: "StormyShipment");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyShipment_Order_OrderId",
                table: "StormyShipment");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyVendor_VendorAddress_VendorAddressId",
                table: "StormyVendor");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_StormyProduct_ProductId",
                table: "WishlistItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StormyVendor",
                table: "StormyVendor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StormyShipment",
                table: "StormyShipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StormyProduct",
                table: "StormyProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StormyPayment",
                table: "StormyPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StormyCustomer",
                table: "StormyCustomer");

            migrationBuilder.DropIndex(
                name: "IX_StormyCustomer_CustomerWishlistId",
                table: "StormyCustomer");

            migrationBuilder.DropIndex(
                name: "IX_StormyCustomer_CustomerWishlistId1",
                table: "StormyCustomer");

            migrationBuilder.DropColumn(
                name: "CustomerWishlistId",
                table: "StormyCustomer");

            migrationBuilder.DropColumn(
                name: "CustomerWishlistId1",
                table: "StormyCustomer");

            migrationBuilder.RenameTable(
                name: "StormyVendor",
                newName: "Vendor");

            migrationBuilder.RenameTable(
                name: "StormyShipment",
                newName: "Shipment");

            migrationBuilder.RenameTable(
                name: "StormyProduct",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "StormyPayment",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "StormyCustomer",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_StormyVendor_VendorAddressId",
                table: "Vendor",
                newName: "IX_Vendor_VendorAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_StormyShipment_OrderId",
                table: "Shipment",
                newName: "IX_Shipment_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_StormyShipment_DestinationAddressId",
                table: "Shipment",
                newName: "IX_Shipment_DestinationAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_StormyProduct_VendorId",
                table: "Product",
                newName: "IX_Product_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_StormyProduct_StockId",
                table: "Product",
                newName: "IX_Product_StockId");

            migrationBuilder.RenameIndex(
                name: "IX_StormyProduct_BrandId",
                table: "Product",
                newName: "IX_Product_BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_StormyPayment_OrderId",
                table: "Payment",
                newName: "IX_Payment_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_StormyCustomerId",
                table: "Order",
                newName: "IX_Order_StormyCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_StockId",
                table: "Order",
                newName: "IX_Order_StockId");

            migrationBuilder.RenameIndex(
                name: "IX_StormyCustomer_RoleId",
                table: "Customer",
                newName: "IX_Customer_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Customer",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendor",
                table: "Vendor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shipment",
                table: "Shipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_StormyCustomerId",
                table: "Wishlist",
                column: "StormyCustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Product_ProductId",
                table: "Comment",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Customer_StormyCustomerId",
                table: "Comment",
                column: "StormyCustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetRoles_RoleId",
                table: "Customer",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_Customer_StormyCustomerId",
                table: "CustomerAddress",
                column: "StormyCustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_Customer_StormyCustomerId1",
                table: "CustomerAddress",
                column: "StormyCustomerId1",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Stock_StockId",
                table: "Order",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_StormyCustomerId",
                table: "Order",
                column: "StormyCustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Shipment_ShipmentId",
                table: "OrderItem",
                column: "ShipmentId",
                principalTable: "Shipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Product_StormyProductId",
                table: "OrderItem",
                column: "StormyProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Brand_BrandId",
                table: "Product",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Stock_StockId",
                table: "Product",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Vendor_VendorId",
                table: "Product",
                column: "VendorId",
                principalTable: "Vendor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttributeValue_Product_ProductId",
                table: "ProductAttributeValue",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLink_Product_LinkedProductId",
                table: "ProductLink",
                column: "LinkedProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLink_Product_ProductId",
                table: "ProductLink",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMedia_Product_StormyProductId",
                table: "ProductMedia",
                column: "StormyProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOptionCombination_Product_ProductId",
                table: "ProductOptionCombination",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOptionValue_Product_ProductId",
                table: "ProductOptionValue",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTemplate_Product_StormyProductId",
                table: "ProductTemplate",
                column: "StormyProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Customer_StormyCustomerId",
                table: "Review",
                column: "StormyCustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Product_StormyProductId",
                table: "Review",
                column: "StormyProductId",
                principalTable: "Product",
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
                name: "FK_Shipment_Order_OrderId",
                table: "Shipment",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_VendorAddress_VendorAddressId",
                table: "Vendor",
                column: "VendorAddressId",
                principalTable: "VendorAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlist_Customer_StormyCustomerId",
                table: "Wishlist",
                column: "StormyCustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_Product_ProductId",
                table: "WishlistItem",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Product_ProductId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Customer_StormyCustomerId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetRoles_RoleId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_Customer_StormyCustomerId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_Customer_StormyCustomerId1",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stock_StockId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_StormyCustomerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Shipment_ShipmentId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Product_StormyProductId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Brand_BrandId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Stock_StockId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Vendor_VendorId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttributeValue_Product_ProductId",
                table: "ProductAttributeValue");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLink_Product_LinkedProductId",
                table: "ProductLink");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLink_Product_ProductId",
                table: "ProductLink");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMedia_Product_StormyProductId",
                table: "ProductMedia");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOptionCombination_Product_ProductId",
                table: "ProductOptionCombination");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOptionValue_Product_ProductId",
                table: "ProductOptionValue");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTemplate_Product_StormyProductId",
                table: "ProductTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Customer_StormyCustomerId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Product_StormyProductId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_CustomerAddress_DestinationAddressId",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_Order_OrderId",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_VendorAddress_VendorAddressId",
                table: "Vendor");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlist_Customer_StormyCustomerId",
                table: "Wishlist");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_Product_ProductId",
                table: "WishlistItem");

            migrationBuilder.DropIndex(
                name: "IX_Wishlist_StormyCustomerId",
                table: "Wishlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendor",
                table: "Vendor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shipment",
                table: "Shipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Vendor",
                newName: "StormyVendor");

            migrationBuilder.RenameTable(
                name: "Shipment",
                newName: "StormyShipment");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "StormyProduct");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "StormyPayment");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "StormyCustomer");

            migrationBuilder.RenameIndex(
                name: "IX_Vendor_VendorAddressId",
                table: "StormyVendor",
                newName: "IX_StormyVendor_VendorAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipment_OrderId",
                table: "StormyShipment",
                newName: "IX_StormyShipment_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipment_DestinationAddressId",
                table: "StormyShipment",
                newName: "IX_StormyShipment_DestinationAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_VendorId",
                table: "StormyProduct",
                newName: "IX_StormyProduct_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_StockId",
                table: "StormyProduct",
                newName: "IX_StormyProduct_StockId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_BrandId",
                table: "StormyProduct",
                newName: "IX_StormyProduct_BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_OrderId",
                table: "StormyPayment",
                newName: "IX_StormyPayment_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_StormyCustomerId",
                table: "Order",
                newName: "IX_Order_StormyCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_StockId",
                table: "Order",
                newName: "IX_Order_StockId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_RoleId",
                table: "StormyCustomer",
                newName: "IX_StormyCustomer_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "StormyCustomer",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CustomerWishlistId",
                table: "StormyCustomer",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CustomerWishlistId1",
                table: "StormyCustomer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StormyVendor",
                table: "StormyVendor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StormyShipment",
                table: "StormyShipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StormyProduct",
                table: "StormyProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StormyPayment",
                table: "StormyPayment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StormyCustomer",
                table: "StormyCustomer",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_CustomerWishlistId",
                table: "StormyCustomer",
                column: "CustomerWishlistId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_CustomerWishlistId1",
                table: "StormyCustomer",
                column: "CustomerWishlistId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_StormyProduct_ProductId",
                table: "Comment",
                column: "ProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_StormyCustomer_StormyCustomerId",
                table: "Comment",
                column: "StormyCustomerId",
                principalTable: "StormyCustomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_OrderItem_StormyShipment_ShipmentId",
                table: "OrderItem",
                column: "ShipmentId",
                principalTable: "StormyShipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_StormyProduct_StormyProductId",
                table: "OrderItem",
                column: "StormyProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttributeValue_StormyProduct_ProductId",
                table: "ProductAttributeValue",
                column: "ProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_StormyProduct_ProductId",
                table: "ProductCategory",
                column: "ProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLink_StormyProduct_LinkedProductId",
                table: "ProductLink",
                column: "LinkedProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLink_StormyProduct_ProductId",
                table: "ProductLink",
                column: "ProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMedia_StormyProduct_StormyProductId",
                table: "ProductMedia",
                column: "StormyProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOptionCombination_StormyProduct_ProductId",
                table: "ProductOptionCombination",
                column: "ProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOptionValue_StormyProduct_ProductId",
                table: "ProductOptionValue",
                column: "ProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTemplate_StormyProduct_StormyProductId",
                table: "ProductTemplate",
                column: "StormyProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_StormyCustomer_StormyCustomerId",
                table: "Review",
                column: "StormyCustomerId",
                principalTable: "StormyCustomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_StormyProduct_StormyProductId",
                table: "Review",
                column: "StormyProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyCustomer_Wishlist_CustomerWishlistId",
                table: "StormyCustomer",
                column: "CustomerWishlistId",
                principalTable: "Wishlist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyCustomer_Wishlist_CustomerWishlistId1",
                table: "StormyCustomer",
                column: "CustomerWishlistId1",
                principalTable: "Wishlist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyCustomer_AspNetRoles_RoleId",
                table: "StormyCustomer",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Stock_StockId",
                table: "Order",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_StormyCustomer_StormyCustomerId",
                table: "Order",
                column: "StormyCustomerId",
                principalTable: "StormyCustomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyPayment_Order_OrderId",
                table: "StormyPayment",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyProduct_Brand_BrandId",
                table: "StormyProduct",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyProduct_Stock_StockId",
                table: "StormyProduct",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyProduct_StormyVendor_VendorId",
                table: "StormyProduct",
                column: "VendorId",
                principalTable: "StormyVendor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyShipment_CustomerAddress_DestinationAddressId",
                table: "StormyShipment",
                column: "DestinationAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyShipment_Order_OrderId",
                table: "StormyShipment",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyVendor_VendorAddress_VendorAddressId",
                table: "StormyVendor",
                column: "VendorAddressId",
                principalTable: "VendorAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_StormyProduct_ProductId",
                table: "WishlistItem",
                column: "ProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
