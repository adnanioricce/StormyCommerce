CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

CREATE TABLE "Address" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Address" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Street" TEXT NULL,
    "FirstAddress" TEXT NULL,
    "SecondAddress" TEXT NULL,
    "City" TEXT NULL,
    "District" TEXT NULL,
    "State" TEXT NULL,
    "PostalCode" TEXT NULL,
    "Number" TEXT NULL,
    "Complement" TEXT NULL,
    "PhoneNumber" TEXT NULL,
    "Country" TEXT NULL,
    "WhoReceives" TEXT NULL,
    "OwnerId" INTEGER NOT NULL
);

CREATE TABLE "AppSettings" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_AppSettings" PRIMARY KEY,
    "Value" TEXT NULL,
    "Module" TEXT NULL,
    "IsVisibleInCommonSettingPage" INTEGER NOT NULL
);

CREATE TABLE "AspNetRoles" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_AspNetRoles" PRIMARY KEY,
    "Name" TEXT NULL,
    "NormalizedName" TEXT NULL,
    "ConcurrencyStamp" TEXT NULL
);

CREATE TABLE "AspNetUsers" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_AspNetUsers" PRIMARY KEY,
    "UserName" TEXT NULL,
    "NormalizedUserName" TEXT NULL,
    "Email" TEXT NULL,
    "NormalizedEmail" TEXT NULL,
    "EmailConfirmed" INTEGER NOT NULL,
    "PasswordHash" TEXT NULL,
    "SecurityStamp" TEXT NULL,
    "ConcurrencyStamp" TEXT NULL,
    "PhoneNumber" TEXT NULL,
    "PhoneNumberConfirmed" INTEGER NOT NULL,
    "TwoFactorEnabled" INTEGER NOT NULL,
    "LockoutEnd" TEXT NULL,
    "LockoutEnabled" INTEGER NOT NULL,
    "AccessFailedCount" INTEGER NOT NULL
);

CREATE TABLE "Brand" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Brand" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Name" TEXT NULL,
    "Slug" TEXT NOT NULL,
    "Description" TEXT NULL,
    "Website" TEXT NULL,
    "LogoImage" TEXT NULL
);

CREATE TABLE "Category" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Category" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Name" TEXT NOT NULL,
    "Slug" TEXT NOT NULL,
    "MetaTitle" TEXT NULL,
    "MetaKeywords" TEXT NULL,
    "MetaDescription" TEXT NULL,
    "Description" TEXT NOT NULL,
    "DisplayOrder" INTEGER NOT NULL,
    "IsPublished" INTEGER NOT NULL,
    "IncludeInMenu" INTEGER NOT NULL,
    "ParentId" INTEGER NULL,
    "ThumbnailImageUrl" TEXT NULL,
    CONSTRAINT "FK_Category_Category_ParentId" FOREIGN KEY ("ParentId") REFERENCES "Category" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "EntityType" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_EntityType" PRIMARY KEY,
    "IsMenuable" INTEGER NOT NULL,
    "AreaName" TEXT NULL,
    "RoutingController" TEXT NULL,
    "RoutingAction" TEXT NULL,
    "IsDeleted" INTEGER NOT NULL
);

CREATE TABLE "ProductAttributeGroup" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductAttributeGroup" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Name" TEXT NOT NULL
);

CREATE TABLE "ProductOption" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductOption" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Name" TEXT NOT NULL
);

CREATE TABLE "Stock" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Stock" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL
);

CREATE TABLE "StormyCustomer" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_StormyCustomer" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "UserId" TEXT NULL,
    "CPF" TEXT NULL,
    "NormalizedEmail" TEXT NULL,
    "PhoneNumber" TEXT NULL,
    "PhoneNumberConfirmed" INTEGER NOT NULL,
    "EmailConfirmed" INTEGER NOT NULL,
    "DefaultShippingAddressId" INTEGER NULL,
    "DefaultBillingAddressId" INTEGER NULL,
    "CustomerReviewsId" INTEGER NOT NULL,
    "CustomerWishlistId" INTEGER NOT NULL,
    "UserName" TEXT NULL,
    "NormalizedUserName" TEXT NULL,
    "FullName" TEXT NULL,
    "Email" TEXT NOT NULL,
    "RefreshTokenHash" TEXT NULL,
    "Role" TEXT NULL,
    "CreatedOn" TEXT NOT NULL,
    CONSTRAINT "FK_StormyCustomer_Address_DefaultBillingAddressId" FOREIGN KEY ("DefaultBillingAddressId") REFERENCES "Address" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyCustomer_Address_DefaultShippingAddressId" FOREIGN KEY ("DefaultShippingAddressId") REFERENCES "Address" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "StormyVendor" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_StormyVendor" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "CompanyName" TEXT NULL,
    "ContactTitle" TEXT NULL,
    "AddressId" INTEGER NOT NULL,
    "Phone" TEXT NULL,
    "Email" TEXT NULL,
    "WebSite" TEXT NULL,
    "TypeGoods" TEXT NULL,
    "SizeUrl" TEXT NULL,
    "Logo" TEXT NULL,
    "Note" TEXT NULL,
    CONSTRAINT "FK_StormyVendor_Address_AddressId" FOREIGN KEY ("AddressId") REFERENCES "Address" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ApplicationUser" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_ApplicationUser" PRIMARY KEY,
    "UserName" TEXT NULL,
    "NormalizedUserName" TEXT NULL,
    "Email" TEXT NULL,
    "NormalizedEmail" TEXT NULL,
    "EmailConfirmed" INTEGER NOT NULL,
    "PasswordHash" TEXT NULL,
    "SecurityStamp" TEXT NULL,
    "ConcurrencyStamp" TEXT NULL,
    "PhoneNumber" TEXT NULL,
    "PhoneNumberConfirmed" INTEGER NOT NULL,
    "TwoFactorEnabled" INTEGER NOT NULL,
    "LockoutEnd" TEXT NULL,
    "LockoutEnabled" INTEGER NOT NULL,
    "AccessFailedCount" INTEGER NOT NULL,
    "RefreshTokenHash" TEXT NULL,
    "RoleId" TEXT NULL,
    CONSTRAINT "FK_ApplicationUser_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "AspNetRoleClaims" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_AspNetRoleClaims" PRIMARY KEY AUTOINCREMENT,
    "RoleId" TEXT NOT NULL,
    "ClaimType" TEXT NULL,
    "ClaimValue" TEXT NULL,
    CONSTRAINT "FK_AspNetRoleClaims_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE CASCADE
);

CREATE TABLE "AspNetUserClaims" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_AspNetUserClaims" PRIMARY KEY AUTOINCREMENT,
    "UserId" TEXT NOT NULL,
    "ClaimType" TEXT NULL,
    "ClaimValue" TEXT NULL,
    CONSTRAINT "FK_AspNetUserClaims_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);

CREATE TABLE "AspNetUserLogins" (
    "LoginProvider" TEXT NOT NULL,
    "ProviderKey" TEXT NOT NULL,
    "ProviderDisplayName" TEXT NULL,
    "UserId" TEXT NOT NULL,
    CONSTRAINT "PK_AspNetUserLogins" PRIMARY KEY ("LoginProvider", "ProviderKey"),
    CONSTRAINT "FK_AspNetUserLogins_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);

CREATE TABLE "AspNetUserRoles" (
    "UserId" TEXT NOT NULL,
    "RoleId" TEXT NOT NULL,
    CONSTRAINT "PK_AspNetUserRoles" PRIMARY KEY ("UserId", "RoleId"),
    CONSTRAINT "FK_AspNetUserRoles_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_AspNetUserRoles_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);

CREATE TABLE "AspNetUserTokens" (
    "UserId" TEXT NOT NULL,
    "LoginProvider" TEXT NOT NULL,
    "Name" TEXT NOT NULL,
    "Value" TEXT NULL,
    CONSTRAINT "PK_AspNetUserTokens" PRIMARY KEY ("UserId", "LoginProvider", "Name"),
    CONSTRAINT "FK_AspNetUserTokens_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Entity" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Entity" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Slug" TEXT NOT NULL,
    "Name" TEXT NOT NULL,
    "EntityId" INTEGER NOT NULL,
    "EntityTypeId" TEXT NOT NULL,
    CONSTRAINT "FK_Entity_EntityType_EntityTypeId" FOREIGN KEY ("EntityTypeId") REFERENCES "EntityType" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductAttribute" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductAttribute" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "GroupId" INTEGER NOT NULL,
    "Name" TEXT NULL,
    CONSTRAINT "FK_ProductAttribute_ProductAttributeGroup_GroupId" FOREIGN KEY ("GroupId") REFERENCES "ProductAttributeGroup" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Review" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Review" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "StormyCustomerId" INTEGER NOT NULL,
    "Title" TEXT NULL,
    "Comment" TEXT NULL,
    "ReviewerName" TEXT NULL,
    "RatingLevel" INTEGER NOT NULL,
    "Status" INTEGER NOT NULL,
    CONSTRAINT "FK_Review_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE CASCADE
);

CREATE TABLE "StormyOrder" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_StormyOrder" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "OrderUniqueKey" BLOB NOT NULL,
    "StormyCustomerId" INTEGER NOT NULL,
    "UserId" TEXT NULL,
    "PaymentId" INTEGER NOT NULL,
    "ShipmentId" INTEGER NOT NULL,
    "PickUpInStore" INTEGER NOT NULL,
    "IsCancelled" INTEGER NOT NULL,
    "Note" TEXT NULL,
    "Comment" TEXT NULL,
    "Discount" TEXT NOT NULL,
    "Tax" TEXT NOT NULL,
    "TotalPrice" TEXT NOT NULL,
    "OrderDate" TEXT NOT NULL,
    "RequiredDate" TEXT NOT NULL,
    "PaymentDate" TEXT NULL,
    "Status" INTEGER NOT NULL,
    "StockId" INTEGER NULL,
    CONSTRAINT "FK_StormyOrder_Stock_StockId" FOREIGN KEY ("StockId") REFERENCES "Stock" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyOrder_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Wishlist" (
    "Id" INTEGER NOT NULL,
    "StormyCustomerId" INTEGER NOT NULL,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "CustomerId" INTEGER NULL,
    CONSTRAINT "PK_Wishlist" PRIMARY KEY ("Id", "StormyCustomerId"),
    CONSTRAINT "AK_Wishlist_Id" UNIQUE ("Id"),
    CONSTRAINT "FK_Wishlist_StormyCustomer_CustomerId" FOREIGN KEY ("CustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "StormyProduct" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_StormyProduct" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "SKU" TEXT NOT NULL,
    "Gtin" TEXT NULL,
    "NormalizedName" TEXT NULL,
    "ProductName" TEXT NOT NULL,
    "Slug" TEXT NULL,
    "MetaKeywords" TEXT NULL,
    "MetaDescription" TEXT NULL,
    "MetaTitle" TEXT NULL,
    "CreatedById" INTEGER NOT NULL,
    "BrandId" INTEGER NOT NULL,
    "MediaId" INTEGER NOT NULL,
    "VendorId" INTEGER NOT NULL,
    "CategoryId" INTEGER NOT NULL,
    "ProductLinksId" INTEGER NULL,
    "TaxClassId" INTEGER NULL,
    "LatestUpdatedById" INTEGER NULL,
    "TypeName" TEXT NOT NULL,
    "ShortDescription" TEXT NULL,
    "Description" TEXT NULL,
    "Specification" TEXT NULL,
    "QuantityPerUnity" INTEGER NOT NULL,
    "AvailableSizes" TEXT NULL,
    "UnitPrice" TEXT NOT NULL,
    "Discount" TEXT NOT NULL,
    "UnitWeight" REAL NOT NULL,
    "Height" TEXT NOT NULL,
    "Width" TEXT NOT NULL,
    "Length" TEXT NOT NULL,
    "Diameter" INTEGER NULL,
    "UnitsInStock" INTEGER NOT NULL,
    "UnitsOnOrder" INTEGER NOT NULL,
    "ReviewsCount" INTEGER NOT NULL,
    "ProductAvailable" INTEGER NOT NULL,
    "DiscountAvailable" INTEGER NOT NULL,
    "StockTrackingIsEnabled" INTEGER NOT NULL,
    "ThumbnailImage" TEXT NULL,
    "Ranking" INTEGER NOT NULL,
    "Note" TEXT NULL,
    "Price" decimal(18,4) NULL,
    "OldPrice" decimal(18,4) NULL,
    "SpecialPrice" TEXT NULL,
    "SpecialPriceStart" TEXT NULL,
    "SpecialPriceEnd" TEXT NULL,
    "HasDiscountApplied" INTEGER NOT NULL,
    "IsPublished" INTEGER NOT NULL,
    "Status" TEXT NOT NULL,
    "NotReturnable" INTEGER NOT NULL,
    "AvailableForPreorder" INTEGER NOT NULL,
    "HasOptions" INTEGER NOT NULL,
    "IsVisibleIndividually" INTEGER NOT NULL,
    "IsFeatured" INTEGER NOT NULL,
    "IsCallForPricing" INTEGER NOT NULL,
    "IsAllowToOrder" INTEGER NOT NULL,
    "ProductCost" TEXT NOT NULL,
    "PreOrderAvailabilityStartDate" TEXT NULL,
    "PublishedOn" TEXT NULL,
    "CreatedOn" TEXT NULL,
    "LatestUpdatedOn" TEXT NULL,
    "AllowCustomerReview" INTEGER NOT NULL,
    "ApprovedRatingSum" INTEGER NOT NULL,
    "NotApprovedRatingSum" INTEGER NOT NULL,
    "ApprovedTotalReviews" INTEGER NOT NULL,
    "NotApprovedTotalReviews" INTEGER NOT NULL,
    "RatingAverage" INTEGER NOT NULL,
    "StockId" INTEGER NULL,
    CONSTRAINT "FK_StormyProduct_Brand_BrandId" FOREIGN KEY ("BrandId") REFERENCES "Brand" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyProduct_Category_CategoryId" FOREIGN KEY ("CategoryId") REFERENCES "Category" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyProduct_Stock_StockId" FOREIGN KEY ("StockId") REFERENCES "Stock" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyProduct_StormyVendor_VendorId" FOREIGN KEY ("VendorId") REFERENCES "StormyVendor" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Payment" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Payment" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "StormyOrderId" INTEGER NOT NULL,
    "CreatedOn" TEXT NOT NULL,
    "Amount" TEXT NOT NULL,
    "PaymentFee" TEXT NOT NULL,
    "PaymentMethod" TEXT NULL,
    "GatewayTransactionId" TEXT NULL,
    "PaymentStatus" INTEGER NOT NULL,
    "FailureMessage" TEXT NULL,
    CONSTRAINT "FK_Payment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Shipment" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Shipment" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "StormyOrderId" INTEGER NOT NULL,
    "UserId" TEXT NULL,
    "StormyCustomerId" INTEGER NOT NULL,
    "WhoReceives" TEXT NULL,
    "TrackNumber" TEXT NULL,
    "ShipmentMethod" TEXT NULL,
    "ShipmentServiceName" TEXT NULL,
    "ShipmentProvider" TEXT NULL,
    "TotalWeight" TEXT NOT NULL,
    "TotalHeight" TEXT NOT NULL,
    "TotalWidth" TEXT NOT NULL,
    "TotalArea" TEXT NOT NULL,
    "CreatedOn" TEXT NOT NULL,
    "ShippedDate" TEXT NULL,
    "DeliveryDate" TEXT NULL,
    "ExpectedDeliveryDate" TEXT NULL,
    "ExpectedHourOfDay" TEXT NOT NULL,
    "Comment" TEXT NULL,
    "DeliveryCost" TEXT NOT NULL,
    "BillingAddressId" INTEGER NOT NULL,
    "DestinationAddressId" INTEGER NOT NULL,
    "Status" INTEGER NOT NULL,
    CONSTRAINT "FK_Shipment_Address_BillingAddressId" FOREIGN KEY ("BillingAddressId") REFERENCES "Address" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Shipment_Address_DestinationAddressId" FOREIGN KEY ("DestinationAddressId") REFERENCES "Address" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Shipment_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Shipment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Media" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Media" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Caption" TEXT NULL,
    "FileSize" INTEGER NOT NULL,
    "FileName" TEXT NULL,
    "MediaType" INTEGER NOT NULL,
    "SeoFileName" TEXT NULL,
    CONSTRAINT "FK_Media_StormyProduct_Id" FOREIGN KEY ("Id") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductAttributeValue" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductAttributeValue" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "AttributeId" INTEGER NOT NULL,
    "ProductId" INTEGER NOT NULL,
    "Value" TEXT NULL,
    CONSTRAINT "FK_ProductAttributeValue_ProductAttribute_AttributeId" FOREIGN KEY ("AttributeId") REFERENCES "ProductAttribute" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductAttributeValue_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductLink" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductLink" PRIMARY KEY,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "ProductId" INTEGER NOT NULL,
    "LinkedProductId" INTEGER NOT NULL,
    "LinkType" INTEGER NOT NULL,
    CONSTRAINT "FK_ProductLink_StormyProduct_Id" FOREIGN KEY ("Id") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_ProductLink_StormyProduct_LinkedProductId" FOREIGN KEY ("LinkedProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_ProductLink_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductOptionValue" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductOptionValue" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "OptionId" INTEGER NOT NULL,
    "ProductId" INTEGER NOT NULL,
    "Value" TEXT NULL,
    "DisplayType" TEXT NULL,
    "SortIndex" INTEGER NOT NULL,
    CONSTRAINT "FK_ProductOptionValue_ProductOption_OptionId" FOREIGN KEY ("OptionId") REFERENCES "ProductOption" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductOptionValue_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductTemplate" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductTemplate" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Name" TEXT NULL,
    "StormyProductId" INTEGER NOT NULL,
    CONSTRAINT "FK_ProductTemplate_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "WishlistItem" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_WishlistItem" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "ProductId" INTEGER NOT NULL,
    "ProductId1" INTEGER NULL,
    "WishlistId" INTEGER NOT NULL,
    "AddedAt" TEXT NOT NULL,
    "Deleted" INTEGER NOT NULL,
    CONSTRAINT "FK_WishlistItem_StormyProduct_ProductId1" FOREIGN KEY ("ProductId1") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_WishlistItem_Wishlist_WishlistId" FOREIGN KEY ("WishlistId") REFERENCES "Wishlist" ("Id") ON DELETE CASCADE
);

CREATE TABLE "OrderItem" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_OrderItem" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Quantity" INTEGER NOT NULL,
    "Price" TEXT NULL,
    "StormyProductId" INTEGER NOT NULL,
    "StormyOrderId" INTEGER NOT NULL,
    "ShipmentId" INTEGER NOT NULL,
    CONSTRAINT "FK_OrderItem_Shipment_ShipmentId" FOREIGN KEY ("ShipmentId") REFERENCES "Shipment" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_OrderItem_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_OrderItem_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductTemplateProductAttribute" (
    "ProductTemplateId" INTEGER NOT NULL,
    "ProductAttributeId" INTEGER NOT NULL,
    CONSTRAINT "PK_ProductTemplateProductAttribute" PRIMARY KEY ("ProductTemplateId", "ProductAttributeId"),
    CONSTRAINT "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAttributeId" FOREIGN KEY ("ProductAttributeId") REFERENCES "ProductAttribute" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemplateId" FOREIGN KEY ("ProductTemplateId") REFERENCES "ProductTemplate" ("Id") ON DELETE RESTRICT
);

CREATE INDEX "IX_ApplicationUser_RoleId" ON "ApplicationUser" ("RoleId");

CREATE INDEX "IX_AspNetRoleClaims_RoleId" ON "AspNetRoleClaims" ("RoleId");

CREATE UNIQUE INDEX "RoleNameIndex" ON "AspNetRoles" ("NormalizedName");

CREATE INDEX "IX_AspNetUserClaims_UserId" ON "AspNetUserClaims" ("UserId");

CREATE INDEX "IX_AspNetUserLogins_UserId" ON "AspNetUserLogins" ("UserId");

CREATE INDEX "IX_AspNetUserRoles_RoleId" ON "AspNetUserRoles" ("RoleId");

CREATE INDEX "EmailIndex" ON "AspNetUsers" ("NormalizedEmail");

CREATE UNIQUE INDEX "UserNameIndex" ON "AspNetUsers" ("NormalizedUserName");

CREATE INDEX "IX_Category_ParentId" ON "Category" ("ParentId");

CREATE INDEX "IX_Entity_EntityTypeId" ON "Entity" ("EntityTypeId");

CREATE INDEX "IX_OrderItem_ShipmentId" ON "OrderItem" ("ShipmentId");

CREATE INDEX "IX_OrderItem_StormyOrderId" ON "OrderItem" ("StormyOrderId");

CREATE INDEX "IX_OrderItem_StormyProductId" ON "OrderItem" ("StormyProductId");

CREATE UNIQUE INDEX "IX_Payment_StormyOrderId" ON "Payment" ("StormyOrderId");

CREATE INDEX "IX_ProductAttribute_GroupId" ON "ProductAttribute" ("GroupId");

CREATE INDEX "IX_ProductAttributeValue_AttributeId" ON "ProductAttributeValue" ("AttributeId");

CREATE INDEX "IX_ProductAttributeValue_ProductId" ON "ProductAttributeValue" ("ProductId");

CREATE INDEX "IX_ProductLink_LinkedProductId" ON "ProductLink" ("LinkedProductId");

CREATE INDEX "IX_ProductLink_ProductId" ON "ProductLink" ("ProductId");

CREATE INDEX "IX_ProductOptionValue_OptionId" ON "ProductOptionValue" ("OptionId");

CREATE INDEX "IX_ProductOptionValue_ProductId" ON "ProductOptionValue" ("ProductId");

CREATE INDEX "IX_ProductTemplate_StormyProductId" ON "ProductTemplate" ("StormyProductId");

CREATE INDEX "IX_ProductTemplateProductAttribute_ProductAttributeId" ON "ProductTemplateProductAttribute" ("ProductAttributeId");

CREATE INDEX "IX_Review_StormyCustomerId" ON "Review" ("StormyCustomerId");

CREATE INDEX "IX_Shipment_BillingAddressId" ON "Shipment" ("BillingAddressId");

CREATE INDEX "IX_Shipment_DestinationAddressId" ON "Shipment" ("DestinationAddressId");

CREATE INDEX "IX_Shipment_StormyCustomerId" ON "Shipment" ("StormyCustomerId");

CREATE UNIQUE INDEX "IX_Shipment_StormyOrderId" ON "Shipment" ("StormyOrderId");

CREATE INDEX "IX_StormyCustomer_DefaultBillingAddressId" ON "StormyCustomer" ("DefaultBillingAddressId");

CREATE INDEX "IX_StormyCustomer_DefaultShippingAddressId" ON "StormyCustomer" ("DefaultShippingAddressId");

CREATE INDEX "IX_StormyOrder_StockId" ON "StormyOrder" ("StockId");

CREATE INDEX "IX_StormyOrder_StormyCustomerId" ON "StormyOrder" ("StormyCustomerId");

CREATE INDEX "IX_StormyProduct_BrandId" ON "StormyProduct" ("BrandId");

CREATE UNIQUE INDEX "IX_StormyProduct_CategoryId" ON "StormyProduct" ("CategoryId");

CREATE INDEX "IX_StormyProduct_StockId" ON "StormyProduct" ("StockId");

CREATE INDEX "IX_StormyProduct_VendorId" ON "StormyProduct" ("VendorId");

CREATE INDEX "IX_StormyVendor_AddressId" ON "StormyVendor" ("AddressId");

CREATE UNIQUE INDEX "IX_Wishlist_CustomerId" ON "Wishlist" ("CustomerId");

CREATE INDEX "IX_WishlistItem_ProductId1" ON "WishlistItem" ("ProductId1");

CREATE INDEX "IX_WishlistItem_WishlistId" ON "WishlistItem" ("WishlistId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191020200757_InitialCreate', '2.2.6-servicing-10079');

