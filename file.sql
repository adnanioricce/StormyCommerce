CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

ALTER TABLE "StormyProduct" ALTER COLUMN "Width" TYPE double precision;
ALTER TABLE "StormyProduct" ALTER COLUMN "Width" SET NOT NULL;
ALTER TABLE "StormyProduct" ALTER COLUMN "Width" DROP DEFAULT;

ALTER TABLE "StormyProduct" ALTER COLUMN "Length" TYPE double precision;
ALTER TABLE "StormyProduct" ALTER COLUMN "Length" SET NOT NULL;
ALTER TABLE "StormyProduct" ALTER COLUMN "Length" DROP DEFAULT;

ALTER TABLE "StormyProduct" ALTER COLUMN "Height" TYPE double precision;
ALTER TABLE "StormyProduct" ALTER COLUMN "Height" SET NOT NULL;
ALTER TABLE "StormyProduct" ALTER COLUMN "Height" DROP DEFAULT;

ALTER TABLE "StormyProduct" ALTER COLUMN "Diameter" TYPE double precision;
ALTER TABLE "StormyProduct" ALTER COLUMN "Diameter" DROP NOT NULL;
ALTER TABLE "StormyProduct" ALTER COLUMN "Diameter" DROP DEFAULT;

ALTER TABLE "Shipment" ALTER COLUMN "TotalWidth" TYPE double precision;
ALTER TABLE "Shipment" ALTER COLUMN "TotalWidth" SET NOT NULL;
ALTER TABLE "Shipment" ALTER COLUMN "TotalWidth" DROP DEFAULT;

ALTER TABLE "Shipment" ALTER COLUMN "TotalWeight" TYPE double precision;
ALTER TABLE "Shipment" ALTER COLUMN "TotalWeight" SET NOT NULL;
ALTER TABLE "Shipment" ALTER COLUMN "TotalWeight" DROP DEFAULT;

ALTER TABLE "Shipment" ALTER COLUMN "TotalLength" TYPE double precision;
ALTER TABLE "Shipment" ALTER COLUMN "TotalLength" SET NOT NULL;
ALTER TABLE "Shipment" ALTER COLUMN "TotalLength" DROP DEFAULT;

ALTER TABLE "Shipment" ALTER COLUMN "TotalHeight" TYPE double precision;
ALTER TABLE "Shipment" ALTER COLUMN "TotalHeight" SET NOT NULL;
ALTER TABLE "Shipment" ALTER COLUMN "TotalHeight" DROP DEFAULT;

ALTER TABLE "Shipment" ALTER COLUMN "TotalArea" TYPE double precision;
ALTER TABLE "Shipment" ALTER COLUMN "TotalArea" SET NOT NULL;
ALTER TABLE "Shipment" ALTER COLUMN "TotalArea" DROP DEFAULT;

CREATE UNIQUE INDEX "UserNameIndex" ON "AspNetUsers" ("NormalizedUserName");

CREATE UNIQUE INDEX "RoleNameIndex" ON "AspNetRoles" ("NormalizedName");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191106113816_AppSettingsInConfigDatabase', '2.2.6-servicing-10079');

CREATE TABLE "AppSettings" (
    "Id" text NOT NULL,
    "Value" character varying(450) NULL,
    "Module" character varying(450) NULL,
    "IsVisibleInCommonSettingPage" boolean NOT NULL,
    CONSTRAINT "PK_AppSettings" PRIMARY KEY ("Id")
);

CREATE TABLE "AspNetRoles" (
    "Id" text NOT NULL,
    "Name" character varying(256) NULL,
    "NormalizedName" character varying(256) NULL,
    "ConcurrencyStamp" text NULL,
    CONSTRAINT "PK_AspNetRoles" PRIMARY KEY ("Id")
);

CREATE TABLE "AspNetUsers" (
    "Id" text NOT NULL,
    "UserName" character varying(256) NULL,
    "NormalizedUserName" character varying(256) NULL,
    "Email" character varying(256) NULL,
    "NormalizedEmail" character varying(256) NULL,
    "EmailConfirmed" boolean NOT NULL,
    "PasswordHash" text NULL,
    "SecurityStamp" text NULL,
    "ConcurrencyStamp" text NULL,
    "PhoneNumber" text NULL,
    "PhoneNumberConfirmed" boolean NOT NULL,
    "TwoFactorEnabled" boolean NOT NULL,
    "LockoutEnd" timestamp with time zone NULL,
    "LockoutEnabled" boolean NOT NULL,
    "AccessFailedCount" integer NOT NULL,
    CONSTRAINT "PK_AspNetUsers" PRIMARY KEY ("Id")
);

CREATE TABLE "Brand" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" text NULL,
    "Slug" character varying(450) NOT NULL,
    "Description" text NULL,
    "Website" text NULL,
    "LogoImage" text NULL,
    CONSTRAINT "PK_Brand" PRIMARY KEY ("Id")
);

CREATE TABLE "Category" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" character varying(450) NOT NULL,
    "Slug" character varying(450) NOT NULL,
    "Description" character varying(450) NOT NULL,
    "DisplayOrder" integer NOT NULL,
    "IsPublished" boolean NOT NULL,
    "IncludeInMenu" boolean NOT NULL,
    "ParentId" bigint NULL,
    "ChildrenId" bigint NULL,
    "ThumbnailImageUrl" text NULL,
    CONSTRAINT "PK_Category" PRIMARY KEY ("Id")
);

CREATE TABLE "EntityType" (
    "Id" character varying(450) NOT NULL,
    "IsMenuable" boolean NOT NULL,
    "AreaName" character varying(450) NULL,
    "RoutingController" character varying(450) NULL,
    "RoutingAction" character varying(450) NULL,
    "IsDeleted" boolean NOT NULL,
    CONSTRAINT "PK_EntityType" PRIMARY KEY ("Id")
);

CREATE TABLE "Media" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Caption" text NULL,
    "FileSize" bigint NOT NULL,
    "FileName" text NULL,
    "MediaType" integer NOT NULL,
    "SeoFileName" text NULL,
    CONSTRAINT "PK_Media" PRIMARY KEY ("Id")
);

CREATE TABLE "ProductAttributeGroup" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" character varying(450) NOT NULL,
    CONSTRAINT "PK_ProductAttributeGroup" PRIMARY KEY ("Id")
);

CREATE TABLE "ProductOption" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" character varying(450) NOT NULL,
    CONSTRAINT "PK_ProductOption" PRIMARY KEY ("Id")
);

CREATE TABLE "Stock" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    CONSTRAINT "PK_Stock" PRIMARY KEY ("Id")
);

CREATE TABLE "VendorAddress" (
    "Id" bigint NOT NULL,
    "Address_Street" text NULL,
    "Address_FirstAddress" text NULL,
    "Address_SecondAddress" text NULL,
    "Address_City" text NULL,
    "Address_District" text NULL,
    "Address_State" text NULL,
    "Address_PostalCode" text NULL,
    "Address_Number" text NULL,
    "Address_Complement" text NULL,
    "Address_Country" text NULL,
    "WhoReceives" text NULL,
    "PhoneNumber" text NULL,
    CONSTRAINT "PK_VendorAddress" PRIMARY KEY ("Id")
);

CREATE TABLE "Wishlist" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "StormyCustomerId" text NULL,
    CONSTRAINT "PK_Wishlist" PRIMARY KEY ("Id")
);

CREATE TABLE "AspNetRoleClaims" (
    "Id" integer NOT NULL,
    "RoleId" text NOT NULL,
    "ClaimType" text NULL,
    "ClaimValue" text NULL,
    CONSTRAINT "PK_AspNetRoleClaims" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_AspNetRoleClaims_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE CASCADE
);

CREATE TABLE "AspNetUserClaims" (
    "Id" integer NOT NULL,
    "UserId" text NOT NULL,
    "ClaimType" text NULL,
    "ClaimValue" text NULL,
    CONSTRAINT "PK_AspNetUserClaims" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_AspNetUserClaims_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);

CREATE TABLE "AspNetUserLogins" (
    "LoginProvider" text NOT NULL,
    "ProviderKey" text NOT NULL,
    "ProviderDisplayName" text NULL,
    "UserId" text NOT NULL,
    CONSTRAINT "PK_AspNetUserLogins" PRIMARY KEY ("LoginProvider", "ProviderKey"),
    CONSTRAINT "FK_AspNetUserLogins_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);

CREATE TABLE "AspNetUserRoles" (
    "UserId" text NOT NULL,
    "RoleId" text NOT NULL,
    CONSTRAINT "PK_AspNetUserRoles" PRIMARY KEY ("UserId", "RoleId"),
    CONSTRAINT "FK_AspNetUserRoles_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_AspNetUserRoles_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);

CREATE TABLE "AspNetUserTokens" (
    "UserId" text NOT NULL,
    "LoginProvider" text NOT NULL,
    "Name" text NOT NULL,
    "Value" text NULL,
    CONSTRAINT "PK_AspNetUserTokens" PRIMARY KEY ("UserId", "LoginProvider", "Name"),
    CONSTRAINT "FK_AspNetUserTokens_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Entity" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Slug" character varying(450) NOT NULL,
    "Name" character varying(450) NOT NULL,
    "EntityId" bigint NOT NULL,
    "EntityTypeId" character varying(450) NOT NULL,
    CONSTRAINT "PK_Entity" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Entity_EntityType_EntityTypeId" FOREIGN KEY ("EntityTypeId") REFERENCES "EntityType" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductAttribute" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "GroupId" bigint NOT NULL,
    "Name" text NULL,
    CONSTRAINT "PK_ProductAttribute" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductAttribute_ProductAttributeGroup_GroupId" FOREIGN KEY ("GroupId") REFERENCES "ProductAttributeGroup" ("Id") ON DELETE CASCADE
);

CREATE TABLE "StormyVendor" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "CompanyName" text NULL,
    "ContactTitle" text NULL,
    "VendorAddressId" bigint NOT NULL,
    "ProductId" bigint NOT NULL,
    "Phone" text NULL,
    "Email" text NULL,
    "WebSite" text NULL,
    "TypeGoods" text NULL,
    "SizeUrl" text NULL,
    "Logo" text NULL,
    "Note" text NULL,
    CONSTRAINT "PK_StormyVendor" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyVendor_VendorAddress_VendorAddressId" FOREIGN KEY ("VendorAddressId") REFERENCES "VendorAddress" ("Id") ON DELETE CASCADE
);

CREATE TABLE "StormyProduct" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "SKU" text NOT NULL,
    "ProductName" character varying(400) NOT NULL,
    "Slug" text NULL,
    "BrandId" bigint NOT NULL,
    "VendorId" bigint NOT NULL,
    "CategoryId" bigint NOT NULL,
    "MediaId" bigint NULL,
    "ProductLinksId" bigint NULL,
    "ShortDescription" text NULL,
    "Description" text NULL,
    "QuantityPerUnity" integer NOT NULL,
    "AvailableSizes" text NULL,
    "UnitPrice" numeric NOT NULL,
    "Discount" numeric NOT NULL,
    "UnitWeight" double precision NOT NULL,
    "Height" double precision NOT NULL,
    "Width" double precision NOT NULL,
    "Length" double precision NOT NULL,
    "Diameter" double precision NULL,
    "UnitsInStock" integer NOT NULL,
    "UnitsOnOrder" integer NOT NULL,
    "ThumbnailImage" text NULL,
    "Note" text NULL,
    "ProductCost" numeric NOT NULL,
    "PublishedOn" timestamp without time zone NULL,
    "CreatedOn" timestamp without time zone NULL,
    "RatingAverage" integer NOT NULL,
    "StockId" bigint NULL,
    CONSTRAINT "PK_StormyProduct" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyProduct_Brand_BrandId" FOREIGN KEY ("BrandId") REFERENCES "Brand" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyProduct_Stock_StockId" FOREIGN KEY ("StockId") REFERENCES "Stock" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyProduct_StormyVendor_VendorId" FOREIGN KEY ("VendorId") REFERENCES "StormyVendor" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "ProductAttributeValue" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "AttributeId" bigint NOT NULL,
    "ProductId" bigint NOT NULL,
    "Value" text NULL,
    CONSTRAINT "PK_ProductAttributeValue" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductAttributeValue_ProductAttribute_AttributeId" FOREIGN KEY ("AttributeId") REFERENCES "ProductAttribute" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductAttributeValue_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductCategory" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "DisplayOrder" integer NOT NULL,
    "CategoryId" bigint NOT NULL,
    "ProductId" bigint NOT NULL,
    CONSTRAINT "PK_ProductCategory" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductCategory_Category_CategoryId" FOREIGN KEY ("CategoryId") REFERENCES "Category" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_ProductCategory_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "ProductLink" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "ProductId" bigint NOT NULL,
    "LinkedProductId" bigint NOT NULL,
    "LinkType" integer NOT NULL,
    CONSTRAINT "PK_ProductLink" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductLink_StormyProduct_LinkedProductId" FOREIGN KEY ("LinkedProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductLink_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "ProductMedia" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "MediaId" bigint NOT NULL,
    "StormyProductId" bigint NOT NULL,
    CONSTRAINT "PK_ProductMedia" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductMedia_Media_MediaId" FOREIGN KEY ("MediaId") REFERENCES "Media" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_ProductMedia_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "ProductOptionValue" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "OptionId" bigint NOT NULL,
    "ProductId" bigint NOT NULL,
    "Value" character varying(450) NULL,
    "DisplayType" character varying(450) NULL,
    "SortIndex" integer NOT NULL,
    CONSTRAINT "PK_ProductOptionValue" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductOptionValue_ProductOption_OptionId" FOREIGN KEY ("OptionId") REFERENCES "ProductOption" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductOptionValue_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductTemplate" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" text NULL,
    "StormyProductId" bigint NOT NULL,
    CONSTRAINT "PK_ProductTemplate" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductTemplate_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "WishlistItem" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "ProductId" bigint NOT NULL,
    "WishlistId" bigint NOT NULL,
    "AddedAt" timestamp without time zone NOT NULL,
    "WishlistId1" bigint NULL,
    CONSTRAINT "PK_WishlistItem" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_WishlistItem_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_WishlistItem_Wishlist_WishlistId" FOREIGN KEY ("WishlistId") REFERENCES "Wishlist" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_WishlistItem_Wishlist_WishlistId1" FOREIGN KEY ("WishlistId1") REFERENCES "Wishlist" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "ProductTemplateProductAttribute" (
    "ProductTemplateId" bigint NOT NULL,
    "ProductAttributeId" bigint NOT NULL,
    CONSTRAINT "PK_ProductTemplateProductAttribute" PRIMARY KEY ("ProductTemplateId", "ProductAttributeId"),
    CONSTRAINT "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAttributeId" FOREIGN KEY ("ProductAttributeId") REFERENCES "ProductAttribute" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemplateId" FOREIGN KEY ("ProductTemplateId") REFERENCES "ProductTemplate" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "Shipment" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "StormyOrderId" bigint NOT NULL,
    "WhoReceives" text NULL,
    "TrackNumber" character varying(250) NULL,
    "ShipmentMethod" text NULL,
    "ShipmentServiceName" text NULL,
    "ShipmentProvider" text NULL,
    "TotalWeight" double precision NOT NULL,
    "TotalHeight" double precision NOT NULL,
    "TotalWidth" double precision NOT NULL,
    "TotalLength" double precision NOT NULL,
    "TotalArea" double precision NOT NULL,
    "CubeRoot" double precision NOT NULL,
    "SafeAmount" numeric NOT NULL,
    "CreatedOn" timestamp without time zone NOT NULL,
    "ShippedDate" timestamp without time zone NULL,
    "DeliveryDate" timestamp without time zone NULL,
    "ExpectedDeliveryDate" timestamp without time zone NULL,
    "ExpectedHourOfDay" timestamp without time zone NOT NULL,
    "Comment" text NULL,
    "DeliveryCost" numeric NOT NULL,
    "BillingAddressId" bigint NOT NULL,
    "DestinationAddressId" bigint NOT NULL,
    "Status" integer NOT NULL,
    CONSTRAINT "PK_Shipment" PRIMARY KEY ("Id")
);

CREATE TABLE "StormyCustomer" (
    "Id" text NOT NULL,
    "UserName" text NULL,
    "NormalizedUserName" text NULL,
    "Email" text NOT NULL,
    "NormalizedEmail" text NULL,
    "EmailConfirmed" boolean NOT NULL,
    "PasswordHash" text NULL,
    "SecurityStamp" text NULL,
    "ConcurrencyStamp" text NULL,
    "PhoneNumber" text NULL,
    "PhoneNumberConfirmed" boolean NOT NULL,
    "TwoFactorEnabled" boolean NOT NULL,
    "LockoutEnd" timestamp with time zone NULL,
    "LockoutEnabled" boolean NOT NULL,
    "AccessFailedCount" integer NOT NULL,
    "CPF" character varying(9) NULL,
    "DefaultShippingAddressId" bigint NULL,
    "DefaultBillingAddressId" bigint NULL,
    "CustomerReviewsId" bigint NULL,
    "CustomerWishlistId" bigint NULL,
    "FullName" character varying(450) NULL,
    "RefreshTokenHash" text NULL,
    "CreatedOn" timestamp with time zone NOT NULL,
    CONSTRAINT "PK_StormyCustomer" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyCustomer_Wishlist_CustomerWishlistId" FOREIGN KEY ("CustomerWishlistId") REFERENCES "Wishlist" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "ApplicationRole" (
    "Id" text NOT NULL,
    "Name" text NULL,
    "NormalizedName" text NULL,
    "ConcurrencyStamp" text NULL,
    "StormyCustomerId" text NULL,
    CONSTRAINT "PK_ApplicationRole" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ApplicationRole_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "CustomerAddress" (
    "Id" bigint NOT NULL,
    "Address_Street" text NULL,
    "Address_FirstAddress" text NULL,
    "Address_SecondAddress" text NULL,
    "Address_City" text NULL,
    "Address_District" text NULL,
    "Address_State" text NULL,
    "Address_PostalCode" text NULL,
    "Address_Number" text NULL,
    "Address_Complement" text NULL,
    "Address_Country" text NULL,
    "WhoReceives" text NULL,
    "IsDeleted" boolean NOT NULL,
    "UserId" text NULL,
    "OwnerId" text NULL,
    CONSTRAINT "PK_CustomerAddress" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_CustomerAddress_StormyCustomer_OwnerId" FOREIGN KEY ("OwnerId") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "Review" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "StormyCustomerId" text NOT NULL,
    "StormyProductId" bigint NOT NULL,
    "Title" text NULL,
    "Comment" text NULL,
    "ReviewerName" text NULL,
    "RatingLevel" integer NOT NULL,
    "Status" integer NOT NULL,
    CONSTRAINT "PK_Review" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Review_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Review_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "StormyOrder" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "OrderUniqueKey" uuid NOT NULL,
    "StormyCustomerId" bigint NOT NULL,
    "UserId" text NULL,
    "PaymentId" bigint NOT NULL,
    "ShipmentId" bigint NOT NULL,
    "PickUpInStore" boolean NOT NULL,
    "IsCancelled" boolean NOT NULL,
    "Note" character varying(1000) NULL,
    "Comment" text NULL,
    "Discount" numeric NOT NULL,
    "Tax" numeric NOT NULL,
    "TotalPrice" numeric NOT NULL,
    "CustomerId" text NULL,
    "OrderDate" timestamp without time zone NOT NULL,
    "RequiredDate" timestamp without time zone NOT NULL,
    "PaymentDate" timestamp without time zone NULL,
    "Status" integer NOT NULL,
    "StockId" bigint NULL,
    CONSTRAINT "PK_StormyOrder" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyOrder_StormyCustomer_CustomerId" FOREIGN KEY ("CustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyOrder_Stock_StockId" FOREIGN KEY ("StockId") REFERENCES "Stock" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "OrderItem" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Quantity" integer NOT NULL,
    "Price" text NULL,
    "StormyProductId" bigint NOT NULL,
    "StormyOrderId" bigint NOT NULL,
    "ShipmentId" bigint NOT NULL,
    CONSTRAINT "PK_OrderItem" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_OrderItem_Shipment_ShipmentId" FOREIGN KEY ("ShipmentId") REFERENCES "Shipment" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_OrderItem_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_OrderItem_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Payment" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "StormyOrderId" bigint NOT NULL,
    "CreatedOn" timestamp with time zone NOT NULL,
    "Amount" numeric NOT NULL,
    "PaymentFee" numeric NOT NULL,
    "PaymentMethod" text NULL,
    "GatewayTransactionId" text NULL,
    "PaymentStatus" integer NOT NULL,
    "FailureMessage" text NULL,
    CONSTRAINT "PK_Payment" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Payment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE CASCADE
);

CREATE INDEX "IX_ApplicationRole_StormyCustomerId" ON "ApplicationRole" ("StormyCustomerId");

CREATE INDEX "IX_AspNetRoleClaims_RoleId" ON "AspNetRoleClaims" ("RoleId");

CREATE UNIQUE INDEX "RoleNameIndex" ON "AspNetRoles" ("NormalizedName") WHERE [NormalizedName] IS NOT NULL;

CREATE INDEX "IX_AspNetUserClaims_UserId" ON "AspNetUserClaims" ("UserId");

CREATE INDEX "IX_AspNetUserLogins_UserId" ON "AspNetUserLogins" ("UserId");

CREATE INDEX "IX_AspNetUserRoles_RoleId" ON "AspNetUserRoles" ("RoleId");

CREATE INDEX "EmailIndex" ON "AspNetUsers" ("NormalizedEmail");

CREATE UNIQUE INDEX "UserNameIndex" ON "AspNetUsers" ("NormalizedUserName") WHERE [NormalizedUserName] IS NOT NULL;

CREATE INDEX "IX_CustomerAddress_OwnerId" ON "CustomerAddress" ("OwnerId");

CREATE INDEX "IX_Entity_EntityTypeId" ON "Entity" ("EntityTypeId");

CREATE INDEX "IX_OrderItem_ShipmentId" ON "OrderItem" ("ShipmentId");

CREATE INDEX "IX_OrderItem_StormyOrderId" ON "OrderItem" ("StormyOrderId");

CREATE INDEX "IX_OrderItem_StormyProductId" ON "OrderItem" ("StormyProductId");

CREATE UNIQUE INDEX "IX_Payment_StormyOrderId" ON "Payment" ("StormyOrderId");

CREATE INDEX "IX_ProductAttribute_GroupId" ON "ProductAttribute" ("GroupId");

CREATE INDEX "IX_ProductAttributeValue_AttributeId" ON "ProductAttributeValue" ("AttributeId");

CREATE INDEX "IX_ProductAttributeValue_ProductId" ON "ProductAttributeValue" ("ProductId");

CREATE INDEX "IX_ProductCategory_CategoryId" ON "ProductCategory" ("CategoryId");

CREATE INDEX "IX_ProductCategory_ProductId" ON "ProductCategory" ("ProductId");

CREATE INDEX "IX_ProductLink_LinkedProductId" ON "ProductLink" ("LinkedProductId");

CREATE INDEX "IX_ProductLink_ProductId" ON "ProductLink" ("ProductId");

CREATE INDEX "IX_ProductMedia_MediaId" ON "ProductMedia" ("MediaId");

CREATE INDEX "IX_ProductMedia_StormyProductId" ON "ProductMedia" ("StormyProductId");

CREATE INDEX "IX_ProductOptionValue_OptionId" ON "ProductOptionValue" ("OptionId");

CREATE INDEX "IX_ProductOptionValue_ProductId" ON "ProductOptionValue" ("ProductId");

CREATE INDEX "IX_ProductTemplate_StormyProductId" ON "ProductTemplate" ("StormyProductId");

CREATE INDEX "IX_ProductTemplateProductAttribute_ProductAttributeId" ON "ProductTemplateProductAttribute" ("ProductAttributeId");

CREATE INDEX "IX_Review_StormyCustomerId" ON "Review" ("StormyCustomerId");

CREATE INDEX "IX_Review_StormyProductId" ON "Review" ("StormyProductId");

CREATE UNIQUE INDEX "IX_Shipment_BillingAddressId" ON "Shipment" ("BillingAddressId");

CREATE UNIQUE INDEX "IX_Shipment_DestinationAddressId" ON "Shipment" ("DestinationAddressId");

CREATE UNIQUE INDEX "IX_Shipment_StormyOrderId" ON "Shipment" ("StormyOrderId");

CREATE UNIQUE INDEX "IX_StormyCustomer_CustomerWishlistId" ON "StormyCustomer" ("CustomerWishlistId") WHERE [CustomerWishlistId] IS NOT NULL;

CREATE INDEX "IX_StormyCustomer_DefaultBillingAddressId" ON "StormyCustomer" ("DefaultBillingAddressId");

CREATE INDEX "IX_StormyCustomer_DefaultShippingAddressId" ON "StormyCustomer" ("DefaultShippingAddressId");

CREATE INDEX "IX_StormyOrder_CustomerId" ON "StormyOrder" ("CustomerId");

CREATE INDEX "IX_StormyOrder_StockId" ON "StormyOrder" ("StockId");

CREATE INDEX "IX_StormyProduct_BrandId" ON "StormyProduct" ("BrandId");

CREATE INDEX "IX_StormyProduct_StockId" ON "StormyProduct" ("StockId");

CREATE INDEX "IX_StormyProduct_VendorId" ON "StormyProduct" ("VendorId");

CREATE UNIQUE INDEX "IX_StormyVendor_VendorAddressId" ON "StormyVendor" ("VendorAddressId");

CREATE INDEX "IX_WishlistItem_ProductId" ON "WishlistItem" ("ProductId");

CREATE INDEX "IX_WishlistItem_WishlistId" ON "WishlistItem" ("WishlistId");

CREATE INDEX "IX_WishlistItem_WishlistId1" ON "WishlistItem" ("WishlistId1");

ALTER TABLE "Shipment" ADD CONSTRAINT "FK_Shipment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE RESTRICT;

ALTER TABLE "Shipment" ADD CONSTRAINT "FK_Shipment_CustomerAddress_BillingAddressId" FOREIGN KEY ("BillingAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT;

ALTER TABLE "Shipment" ADD CONSTRAINT "FK_Shipment_CustomerAddress_DestinationAddressId" FOREIGN KEY ("DestinationAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT;

ALTER TABLE "StormyCustomer" ADD CONSTRAINT "FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId" FOREIGN KEY ("DefaultBillingAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT;

ALTER TABLE "StormyCustomer" ADD CONSTRAINT "FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId" FOREIGN KEY ("DefaultShippingAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191110230438_Initial', '2.2.6-servicing-10079');

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191115184426_UpdateModel', '2.2.6-servicing-10079');

ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" TYPE timestamp with time zone;
ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" DROP NOT NULL;
ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" DROP DEFAULT;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191115212046_dateofbirth', '2.2.6-servicing-10079');

ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" TYPE timestamp with time zone;
ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" DROP NOT NULL;
ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" DROP DEFAULT;

ALTER TABLE "StormyCustomer" ADD "CustomerWishlistId1" bigint NULL;

CREATE INDEX "IX_StormyCustomer_CustomerWishlistId1" ON "StormyCustomer" ("CustomerWishlistId1");

ALTER TABLE "StormyCustomer" ADD CONSTRAINT "FK_StormyCustomer_Wishlist_CustomerWishlistId1" FOREIGN KEY ("CustomerWishlistId1") REFERENCES "Wishlist" ("Id") ON DELETE RESTRICT;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191116134002_ChangeWishListModel', '2.2.6-servicing-10079');

CREATE TABLE "ProductOptionCombination" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "ProductId" bigint NOT NULL,
    "OptionId" bigint NOT NULL,
    "Value" character varying(450) NULL,
    "SortIndex" integer NOT NULL,
    CONSTRAINT "PK_ProductOptionCombination" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductOptionCombination_ProductOption_OptionId" FOREIGN KEY ("OptionId") REFERENCES "ProductOption" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductOptionCombination_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE INDEX "IX_ProductOptionCombination_OptionId" ON "ProductOptionCombination" ("OptionId");

CREATE INDEX "IX_ProductOptionCombination_ProductId" ON "ProductOptionCombination" ("ProductId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191116195940_RoleModel', '2.2.6-servicing-10079');

DROP TABLE "ApplicationRole";

DROP INDEX "IX_StormyCustomer_CustomerWishlistId";

DROP INDEX "UserNameIndex";

DROP INDEX "RoleNameIndex";

ALTER TABLE "StormyCustomer" ADD "RoleId" text NULL;

ALTER TABLE "AspNetRoles" ADD "Discriminator" text NOT NULL DEFAULT '';

CREATE TABLE "Comment" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Title" character varying(450) NOT NULL,
    "Body" character varying(450) NULL,
    "ProductId" bigint NOT NULL,
    "StormyCustomerId" text NULL,
    CONSTRAINT "PK_Comment" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Comment_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_Comment_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT
);

CREATE UNIQUE INDEX "IX_StormyCustomer_CustomerWishlistId" ON "StormyCustomer" ("CustomerWishlistId");

CREATE INDEX "IX_StormyCustomer_RoleId" ON "StormyCustomer" ("RoleId");

CREATE UNIQUE INDEX "UserNameIndex" ON "AspNetUsers" ("NormalizedUserName");

CREATE UNIQUE INDEX "RoleNameIndex" ON "AspNetRoles" ("NormalizedName");

CREATE INDEX "IX_Comment_ProductId" ON "Comment" ("ProductId");

CREATE INDEX "IX_Comment_StormyCustomerId" ON "Comment" ("StormyCustomerId");

ALTER TABLE "StormyCustomer" ADD CONSTRAINT "FK_StormyCustomer_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE RESTRICT;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191124233029_UpdateThatIDontKnowWhatIDo', '2.2.6-servicing-10079');

ALTER TABLE "CustomerAddress" DROP CONSTRAINT "FK_CustomerAddress_StormyCustomer_OwnerId";

ALTER TABLE "OrderItem" DROP CONSTRAINT "FK_OrderItem_Shipment_ShipmentId";

DROP TABLE "Payment";

DROP TABLE "Shipment";

DROP INDEX "IX_CustomerAddress_OwnerId";

ALTER TABLE "StormyOrder" DROP COLUMN "Tax";

ALTER TABLE "CustomerAddress" DROP COLUMN "OwnerId";

ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_Street" TO "Street";

ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_State" TO "State";

ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_SecondAddress" TO "SecondAddress";

ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_PostalCode" TO "PostalCode";

ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_Number" TO "Number";

ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_FirstAddress" TO "FirstAddress";

ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_District" TO "District";

ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_Country" TO "Country";

ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_Complement" TO "Complement";

ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_City" TO "City";

ALTER TABLE "CustomerAddress" RENAME COLUMN "UserId" TO "StormyCustomerId";

ALTER TABLE "VendorAddress" ALTER COLUMN "Id" TYPE bigint;
ALTER TABLE "VendorAddress" ALTER COLUMN "Id" SET NOT NULL;
ALTER TABLE "VendorAddress" ALTER COLUMN "Id" DROP DEFAULT;

ALTER TABLE "OrderItem" ALTER COLUMN "ShipmentId" TYPE bigint;
ALTER TABLE "OrderItem" ALTER COLUMN "ShipmentId" DROP NOT NULL;
ALTER TABLE "OrderItem" ALTER COLUMN "ShipmentId" DROP DEFAULT;

ALTER TABLE "OrderItem" ALTER COLUMN "Price" TYPE numeric;
ALTER TABLE "OrderItem" ALTER COLUMN "Price" SET NOT NULL;
ALTER TABLE "OrderItem" ALTER COLUMN "Price" DROP DEFAULT;

CREATE TABLE "StormyPayment" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "StormyOrderId" bigint NOT NULL,
    "CreatedOn" timestamp with time zone NOT NULL,
    "PaidOutAt" timestamp with time zone NULL,
    "Amount" numeric NOT NULL,
    "PaymentFee" numeric NOT NULL,
    "PaymentMethod" integer NOT NULL,
    "GatewayTransactionId" text NULL,
    "PaymentStatus" integer NOT NULL,
    "FailureMessage" text NULL,
    "BoletoUrl" text NULL,
    "BoletoBarcode" text NULL,
    CONSTRAINT "PK_StormyPayment" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyPayment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "StormyShipment" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "StormyOrderId" bigint NOT NULL,
    "TrackNumber" character varying(250) NULL,
    "ShipmentMethod" integer NOT NULL,
    "ShipmentProvider" text NULL,
    "TotalWeight" double precision NOT NULL,
    "TotalHeight" double precision NOT NULL,
    "TotalWidth" double precision NOT NULL,
    "TotalLength" double precision NOT NULL,
    "TotalArea" double precision NOT NULL,
    "CubeRoot" double precision NOT NULL,
    "SafeAmount" numeric NOT NULL,
    "CreatedOn" timestamp with time zone NOT NULL,
    "ShippedDate" timestamp with time zone NULL,
    "DeliveryDate" timestamp with time zone NULL,
    "ExpectedDeliveryDate" timestamp with time zone NULL,
    "ExpectedHourOfDay" timestamp with time zone NULL,
    "DeliveryCost" numeric NOT NULL,
    "DestinationAddressId" bigint NOT NULL,
    "Status" integer NOT NULL,
    CONSTRAINT "PK_StormyShipment" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyShipment_CustomerAddress_DestinationAddressId" FOREIGN KEY ("DestinationAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyShipment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE RESTRICT
);

CREATE INDEX "IX_CustomerAddress_StormyCustomerId" ON "CustomerAddress" ("StormyCustomerId");

CREATE UNIQUE INDEX "IX_StormyPayment_StormyOrderId" ON "StormyPayment" ("StormyOrderId");

CREATE UNIQUE INDEX "IX_StormyShipment_DestinationAddressId" ON "StormyShipment" ("DestinationAddressId");

CREATE UNIQUE INDEX "IX_StormyShipment_StormyOrderId" ON "StormyShipment" ("StormyOrderId");

ALTER TABLE "CustomerAddress" ADD CONSTRAINT "FK_CustomerAddress_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT;

ALTER TABLE "OrderItem" ADD CONSTRAINT "FK_OrderItem_StormyShipment_ShipmentId" FOREIGN KEY ("ShipmentId") REFERENCES "StormyShipment" ("Id") ON DELETE RESTRICT;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191201132419_UpdatingPaymentAndOrderModel', '2.2.6-servicing-10079');

ALTER TABLE "CustomerAddress" DROP CONSTRAINT "FK_CustomerAddress_StormyCustomer_StormyCustomerId";

ALTER TABLE "ProductTemplateProductAttribute" DROP CONSTRAINT "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAttributeId";

ALTER TABLE "ProductTemplateProductAttribute" DROP CONSTRAINT "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemplateId";

ALTER TABLE "StormyCustomer" DROP CONSTRAINT "FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId";

ALTER TABLE "StormyCustomer" DROP CONSTRAINT "FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId";

DROP INDEX "IX_StormyCustomer_DefaultBillingAddressId";

DROP INDEX "IX_StormyCustomer_DefaultShippingAddressId";

ALTER TABLE "StormyCustomer" DROP COLUMN "DefaultBillingAddressId";

ALTER TABLE "StormyCustomer" DROP COLUMN "DefaultShippingAddressId";

ALTER TABLE "CustomerAddress" ADD "IsDefault" boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "CustomerAddress" ADD "StormyCustomerId1" text NULL;

ALTER TABLE "CustomerAddress" ADD "Type" integer NOT NULL DEFAULT 0;

CREATE TABLE config_appsettings (
    "Id" text NOT NULL,
    "Value" text NULL,
    "Module" text NULL,
    "IsVisibleInCommonSettingPage" boolean NOT NULL,
    CONSTRAINT "PK_config_appsettings" PRIMARY KEY ("Id")
);

CREATE INDEX "IX_CustomerAddress_StormyCustomerId1" ON "CustomerAddress" ("StormyCustomerId1");

ALTER TABLE "CustomerAddress" ADD CONSTRAINT "FK_CustomerAddress_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE CASCADE;

ALTER TABLE "CustomerAddress" ADD CONSTRAINT "FK_CustomerAddress_StormyCustomer_StormyCustomerId1" FOREIGN KEY ("StormyCustomerId1") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT;

ALTER TABLE "ProductTemplateProductAttribute" ADD CONSTRAINT "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAtt~" FOREIGN KEY ("ProductAttributeId") REFERENCES "ProductAttribute" ("Id") ON DELETE CASCADE;

ALTER TABLE "ProductTemplateProductAttribute" ADD CONSTRAINT "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemp~" FOREIGN KEY ("ProductTemplateId") REFERENCES "ProductTemplate" ("Id") ON DELETE RESTRICT;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191202011342_UpdatingAddress', '2.2.6-servicing-10079');

ALTER TABLE "Comment" DROP CONSTRAINT "FK_Comment_StormyProduct_ProductId";

ALTER TABLE "Comment" DROP CONSTRAINT "FK_Comment_StormyCustomer_StormyCustomerId";

ALTER TABLE "CustomerAddress" DROP CONSTRAINT "FK_CustomerAddress_StormyCustomer_StormyCustomerId";

ALTER TABLE "CustomerAddress" DROP CONSTRAINT "FK_CustomerAddress_StormyCustomer_StormyCustomerId1";

ALTER TABLE "OrderItem" DROP CONSTRAINT "FK_OrderItem_StormyShipment_ShipmentId";

ALTER TABLE "OrderItem" DROP CONSTRAINT "FK_OrderItem_StormyOrder_StormyOrderId";

ALTER TABLE "OrderItem" DROP CONSTRAINT "FK_OrderItem_StormyProduct_StormyProductId";

ALTER TABLE "ProductAttributeValue" DROP CONSTRAINT "FK_ProductAttributeValue_StormyProduct_ProductId";

ALTER TABLE "ProductCategory" DROP CONSTRAINT "FK_ProductCategory_StormyProduct_ProductId";

ALTER TABLE "ProductLink" DROP CONSTRAINT "FK_ProductLink_StormyProduct_LinkedProductId";

ALTER TABLE "ProductLink" DROP CONSTRAINT "FK_ProductLink_StormyProduct_ProductId";

ALTER TABLE "ProductMedia" DROP CONSTRAINT "FK_ProductMedia_StormyProduct_StormyProductId";

ALTER TABLE "ProductOptionCombination" DROP CONSTRAINT "FK_ProductOptionCombination_StormyProduct_ProductId";

ALTER TABLE "ProductOptionValue" DROP CONSTRAINT "FK_ProductOptionValue_StormyProduct_ProductId";

ALTER TABLE "ProductTemplate" DROP CONSTRAINT "FK_ProductTemplate_StormyProduct_StormyProductId";

ALTER TABLE "Review" DROP CONSTRAINT "FK_Review_StormyCustomer_StormyCustomerId";

ALTER TABLE "Review" DROP CONSTRAINT "FK_Review_StormyProduct_StormyProductId";

ALTER TABLE "StormyCustomer" DROP CONSTRAINT "FK_StormyCustomer_Wishlist_CustomerWishlistId";

ALTER TABLE "StormyCustomer" DROP CONSTRAINT "FK_StormyCustomer_Wishlist_CustomerWishlistId1";

ALTER TABLE "StormyCustomer" DROP CONSTRAINT "FK_StormyCustomer_AspNetRoles_RoleId";

ALTER TABLE "StormyOrder" DROP CONSTRAINT "FK_StormyOrder_Stock_StockId";

ALTER TABLE "StormyOrder" DROP CONSTRAINT "FK_StormyOrder_StormyCustomer_StormyCustomerId";

ALTER TABLE "StormyPayment" DROP CONSTRAINT "FK_StormyPayment_StormyOrder_StormyOrderId";

ALTER TABLE "StormyProduct" DROP CONSTRAINT "FK_StormyProduct_Brand_BrandId";

ALTER TABLE "StormyProduct" DROP CONSTRAINT "FK_StormyProduct_Stock_StockId";

ALTER TABLE "StormyProduct" DROP CONSTRAINT "FK_StormyProduct_StormyVendor_VendorId";

ALTER TABLE "StormyShipment" DROP CONSTRAINT "FK_StormyShipment_CustomerAddress_DestinationAddressId";

ALTER TABLE "StormyShipment" DROP CONSTRAINT "FK_StormyShipment_StormyOrder_StormyOrderId";

ALTER TABLE "StormyVendor" DROP CONSTRAINT "FK_StormyVendor_VendorAddress_VendorAddressId";

ALTER TABLE "WishlistItem" DROP CONSTRAINT "FK_WishlistItem_StormyProduct_ProductId";

ALTER TABLE "StormyVendor" DROP CONSTRAINT "PK_StormyVendor";

ALTER TABLE "StormyShipment" DROP CONSTRAINT "PK_StormyShipment";

ALTER TABLE "StormyProduct" DROP CONSTRAINT "PK_StormyProduct";

ALTER TABLE "StormyPayment" DROP CONSTRAINT "PK_StormyPayment";

ALTER TABLE "StormyOrder" DROP CONSTRAINT "PK_StormyOrder";

ALTER TABLE "StormyCustomer" DROP CONSTRAINT "PK_StormyCustomer";

DROP INDEX "IX_StormyCustomer_CustomerWishlistId";

DROP INDEX "IX_StormyCustomer_CustomerWishlistId1";

ALTER TABLE "StormyCustomer" DROP COLUMN "CustomerWishlistId";

ALTER TABLE "StormyCustomer" DROP COLUMN "CustomerWishlistId1";

ALTER TABLE "StormyVendor" RENAME TO "Vendor";

ALTER TABLE "StormyShipment" RENAME TO "Shipment";

ALTER TABLE "StormyProduct" RENAME TO "Product";

ALTER TABLE "StormyPayment" RENAME TO "Payment";

ALTER TABLE "StormyOrder" RENAME TO "Order";

ALTER TABLE "StormyCustomer" RENAME TO "Customer";

ALTER INDEX "IX_StormyVendor_VendorAddressId" RENAME TO "IX_Vendor_VendorAddressId";

ALTER INDEX "IX_StormyShipment_StormyOrderId" RENAME TO "IX_Shipment_StormyOrderId";

ALTER INDEX "IX_StormyShipment_DestinationAddressId" RENAME TO "IX_Shipment_DestinationAddressId";

ALTER INDEX "IX_StormyProduct_VendorId" RENAME TO "IX_Product_VendorId";

ALTER INDEX "IX_StormyProduct_StockId" RENAME TO "IX_Product_StockId";

ALTER INDEX "IX_StormyProduct_BrandId" RENAME TO "IX_Product_BrandId";

ALTER INDEX "IX_StormyPayment_StormyOrderId" RENAME TO "IX_Payment_StormyOrderId";

ALTER INDEX "IX_StormyOrder_StormyCustomerId" RENAME TO "IX_Order_StormyCustomerId";

ALTER INDEX "IX_StormyOrder_StockId" RENAME TO "IX_Order_StockId";

ALTER INDEX "IX_StormyCustomer_RoleId" RENAME TO "IX_Customer_RoleId";

ALTER TABLE "Customer" ALTER COLUMN "CPF" TYPE character varying(11);
ALTER TABLE "Customer" ALTER COLUMN "CPF" DROP NOT NULL;
ALTER TABLE "Customer" ALTER COLUMN "CPF" DROP DEFAULT;

ALTER TABLE "Vendor" ADD CONSTRAINT "PK_Vendor" PRIMARY KEY ("Id");

ALTER TABLE "Shipment" ADD CONSTRAINT "PK_Shipment" PRIMARY KEY ("Id");

ALTER TABLE "Product" ADD CONSTRAINT "PK_Product" PRIMARY KEY ("Id");

ALTER TABLE "Payment" ADD CONSTRAINT "PK_Payment" PRIMARY KEY ("Id");

ALTER TABLE "Order" ADD CONSTRAINT "PK_Order" PRIMARY KEY ("Id");

ALTER TABLE "Customer" ADD CONSTRAINT "PK_Customer" PRIMARY KEY ("Id");

CREATE UNIQUE INDEX "IX_Wishlist_StormyCustomerId" ON "Wishlist" ("StormyCustomerId");

ALTER TABLE "Comment" ADD CONSTRAINT "FK_Comment_Product_ProductId" FOREIGN KEY ("ProductId") REFERENCES "Product" ("Id") ON DELETE RESTRICT;

ALTER TABLE "Comment" ADD CONSTRAINT "FK_Comment_Customer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "Customer" ("Id") ON DELETE RESTRICT;

ALTER TABLE "Customer" ADD CONSTRAINT "FK_Customer_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE RESTRICT;

ALTER TABLE "CustomerAddress" ADD CONSTRAINT "FK_CustomerAddress_Customer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "Customer" ("Id") ON DELETE CASCADE;

ALTER TABLE "CustomerAddress" ADD CONSTRAINT "FK_CustomerAddress_Customer_StormyCustomerId1" FOREIGN KEY ("StormyCustomerId1") REFERENCES "Customer" ("Id") ON DELETE RESTRICT;

ALTER TABLE "Order" ADD CONSTRAINT "FK_Order_Stock_StockId" FOREIGN KEY ("StockId") REFERENCES "Stock" ("Id") ON DELETE RESTRICT;

ALTER TABLE "Order" ADD CONSTRAINT "FK_Order_Customer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "Customer" ("Id") ON DELETE RESTRICT;

ALTER TABLE "OrderItem" ADD CONSTRAINT "FK_OrderItem_Shipment_ShipmentId" FOREIGN KEY ("ShipmentId") REFERENCES "Shipment" ("Id") ON DELETE RESTRICT;

ALTER TABLE "OrderItem" ADD CONSTRAINT "FK_OrderItem_Order_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "Order" ("Id") ON DELETE CASCADE;

ALTER TABLE "OrderItem" ADD CONSTRAINT "FK_OrderItem_Product_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "Product" ("Id") ON DELETE CASCADE;

ALTER TABLE "Payment" ADD CONSTRAINT "FK_Payment_Order_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "Order" ("Id") ON DELETE RESTRICT;

ALTER TABLE "Product" ADD CONSTRAINT "FK_Product_Brand_BrandId" FOREIGN KEY ("BrandId") REFERENCES "Brand" ("Id") ON DELETE CASCADE;

ALTER TABLE "Product" ADD CONSTRAINT "FK_Product_Stock_StockId" FOREIGN KEY ("StockId") REFERENCES "Stock" ("Id") ON DELETE RESTRICT;

ALTER TABLE "Product" ADD CONSTRAINT "FK_Product_Vendor_VendorId" FOREIGN KEY ("VendorId") REFERENCES "Vendor" ("Id") ON DELETE RESTRICT;

ALTER TABLE "ProductAttributeValue" ADD CONSTRAINT "FK_ProductAttributeValue_Product_ProductId" FOREIGN KEY ("ProductId") REFERENCES "Product" ("Id") ON DELETE CASCADE;

ALTER TABLE "ProductCategory" ADD CONSTRAINT "FK_ProductCategory_Product_ProductId" FOREIGN KEY ("ProductId") REFERENCES "Product" ("Id") ON DELETE RESTRICT;

ALTER TABLE "ProductLink" ADD CONSTRAINT "FK_ProductLink_Product_LinkedProductId" FOREIGN KEY ("LinkedProductId") REFERENCES "Product" ("Id") ON DELETE CASCADE;

ALTER TABLE "ProductLink" ADD CONSTRAINT "FK_ProductLink_Product_ProductId" FOREIGN KEY ("ProductId") REFERENCES "Product" ("Id") ON DELETE RESTRICT;

ALTER TABLE "ProductMedia" ADD CONSTRAINT "FK_ProductMedia_Product_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "Product" ("Id") ON DELETE RESTRICT;

ALTER TABLE "ProductOptionCombination" ADD CONSTRAINT "FK_ProductOptionCombination_Product_ProductId" FOREIGN KEY ("ProductId") REFERENCES "Product" ("Id") ON DELETE CASCADE;

ALTER TABLE "ProductOptionValue" ADD CONSTRAINT "FK_ProductOptionValue_Product_ProductId" FOREIGN KEY ("ProductId") REFERENCES "Product" ("Id") ON DELETE CASCADE;

ALTER TABLE "ProductTemplate" ADD CONSTRAINT "FK_ProductTemplate_Product_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "Product" ("Id") ON DELETE CASCADE;

ALTER TABLE "Review" ADD CONSTRAINT "FK_Review_Customer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "Customer" ("Id") ON DELETE CASCADE;

ALTER TABLE "Review" ADD CONSTRAINT "FK_Review_Product_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "Product" ("Id") ON DELETE RESTRICT;

ALTER TABLE "Shipment" ADD CONSTRAINT "FK_Shipment_CustomerAddress_DestinationAddressId" FOREIGN KEY ("DestinationAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT;

ALTER TABLE "Shipment" ADD CONSTRAINT "FK_Shipment_Order_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "Order" ("Id") ON DELETE RESTRICT;

ALTER TABLE "Vendor" ADD CONSTRAINT "FK_Vendor_VendorAddress_VendorAddressId" FOREIGN KEY ("VendorAddressId") REFERENCES "VendorAddress" ("Id") ON DELETE CASCADE;

ALTER TABLE "Wishlist" ADD CONSTRAINT "FK_Wishlist_Customer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "Customer" ("Id") ON DELETE RESTRICT;

ALTER TABLE "WishlistItem" ADD CONSTRAINT "FK_WishlistItem_Product_ProductId" FOREIGN KEY ("ProductId") REFERENCES "Product" ("Id") ON DELETE RESTRICT;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191203194245_AddingCustomerToWishlistRelation', '2.2.6-servicing-10079');

