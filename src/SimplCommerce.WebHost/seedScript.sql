﻿CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

CREATE TABLE "Address" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Street" text NULL,
    "FirstAddress" character varying(250) NULL,
    "SecondAddress" character varying(250) NULL,
    "City" character varying(500) NULL,
    "District" text NULL,
    "State" text NULL,
    "PostalCode" character varying(9) NULL,
    "Number" text NULL,
    "Complement" character varying(250) NULL,
    "PhoneNumber" text NULL,
    "Country" text NULL,
    "WhoReceives" text NULL,
    "OwnerId" bigint NOT NULL,
    CONSTRAINT "PK_Address" PRIMARY KEY ("Id")
);

CREATE TABLE "ApplicationUser" (
    "Id" text NOT NULL,
    "UserName" text NULL,
    "NormalizedUserName" text NULL,
    "Email" text NULL,
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
    CONSTRAINT "PK_ApplicationUser" PRIMARY KEY ("Id")
);

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
    "Id" bigserial NOT NULL,
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
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" character varying(450) NOT NULL,
    "Slug" character varying(450) NOT NULL,
    "MetaTitle" character varying(450) NULL,
    "MetaKeywords" character varying(450) NULL,
    "MetaDescription" text NULL,
    "Description" character varying(450) NOT NULL,
    "DisplayOrder" integer NOT NULL,
    "IsPublished" boolean NOT NULL,
    "IncludeInMenu" boolean NOT NULL,
    "ParentId" bigint NULL,
    "ThumbnailImageUrl" text NULL,
    CONSTRAINT "PK_Category" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Category_Category_ParentId" FOREIGN KEY ("ParentId") REFERENCES "Category" ("Id") ON DELETE RESTRICT
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

CREATE TABLE "ProductAttributeGroup" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" character varying(450) NOT NULL,
    CONSTRAINT "PK_ProductAttributeGroup" PRIMARY KEY ("Id")
);

CREATE TABLE "ProductOption" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" character varying(450) NOT NULL,
    CONSTRAINT "PK_ProductOption" PRIMARY KEY ("Id")
);

CREATE TABLE "ProductTemplate" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" text NULL,
    CONSTRAINT "PK_ProductTemplate" PRIMARY KEY ("Id")
);

CREATE TABLE "Wishlist" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "CustomerId" integer NOT NULL,
    CONSTRAINT "PK_Wishlist" PRIMARY KEY ("Id")
);

CREATE TABLE "StormyVendor" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "CompanyName" text NULL,
    "ContactTitle" text NULL,
    "AddressId" integer NOT NULL,
    "AddressId1" bigint NULL,
    "Phone" text NULL,
    "Email" text NULL,
    "WebSite" text NULL,
    "TypeGoods" text NULL,
    "SizeUrl" text NULL,
    "Logo" text NULL,
    "Note" text NULL,
    CONSTRAINT "PK_StormyVendor" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyVendor_Address_AddressId1" FOREIGN KEY ("AddressId1") REFERENCES "Address" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "AspNetRoleClaims" (
    "Id" serial NOT NULL,
    "RoleId" text NOT NULL,
    "ClaimType" text NULL,
    "ClaimValue" text NULL,
    CONSTRAINT "PK_AspNetRoleClaims" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_AspNetRoleClaims_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE CASCADE
);

CREATE TABLE "AspNetUserClaims" (
    "Id" serial NOT NULL,
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
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Slug" character varying(450) NOT NULL,
    "Name" character varying(450) NOT NULL,
    "EntityId" bigint NOT NULL,
    "EntityTypeId" character varying(450) NOT NULL,
    CONSTRAINT "PK_Entity" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Entity_EntityType_EntityTypeId" FOREIGN KEY ("EntityTypeId") REFERENCES "EntityType" ("Id") ON DELETE CASCADE
);

CREATE TABLE "StormyCustomer" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "UserId" text NULL,
    "CPF" character varying(9) NULL,
    "NormalizedEmail" text NULL,
    "PhoneNumber" text NULL,
    "PhoneNumberConfirmed" boolean NOT NULL,
    "EmailConfirmed" boolean NOT NULL,
    "DefaultShippingAddressId" bigint NULL,
    "DefaultBillingAddressId" bigint NULL,
    "CustomerReviewsId" bigint NOT NULL,
    "CustomerWishlistId" bigint NOT NULL,
    "UserName" text NULL,
    "FullName" character varying(450) NULL,
    "Email" text NULL,
    "CreatedOn" timestamp with time zone NOT NULL,
    CONSTRAINT "PK_StormyCustomer" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyCustomer_Wishlist_CustomerWishlistId" FOREIGN KEY ("CustomerWishlistId") REFERENCES "Wishlist" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyCustomer_Address_DefaultBillingAddressId" FOREIGN KEY ("DefaultBillingAddressId") REFERENCES "Address" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyCustomer_Address_DefaultShippingAddressId" FOREIGN KEY ("DefaultShippingAddressId") REFERENCES "Address" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "StormyProduct" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "SKU" text NOT NULL,
    "ProductName" character varying(400) NOT NULL,
    "Slug" text NULL,
    "BrandId" bigint NOT NULL,
    "MediaId" bigint NOT NULL,
    "VendorId" bigint NOT NULL,
    "CategoryId" bigint NOT NULL,
    "ProductLinksId" bigint NOT NULL,
    "TypeName" text NOT NULL,
    "QuantityPerUnity" integer NOT NULL,
    "UnitSize" numeric NOT NULL,
    "UnitPrice" numeric NOT NULL,
    "Discount" numeric NOT NULL,
    "UnitWeight" double precision NOT NULL,
    "UnitsInStock" integer NOT NULL,
    "UnitsOnOrder" integer NOT NULL,
    "ProductAvailable" boolean NOT NULL,
    "DiscountAvailable" boolean NOT NULL,
    "StockTrackingIsEnabled" boolean NOT NULL,
    "ThumbnailImage" text NULL,
    "Ranking" integer NOT NULL,
    "Note" text NULL,
    "Price" text NULL,
    "OldPrice" text NULL,
    "HasDiscountApplied" boolean NOT NULL,
    "Published" boolean NOT NULL,
    "Status" text NOT NULL,
    "NotReturnable" boolean NOT NULL,
    "AvailableForPreorder" boolean NOT NULL,
    "ProductCost" numeric NOT NULL,
    "PreOrderAvailabilityStartDate" timestamp without time zone NULL,
    "CreatedAt" timestamp without time zone NOT NULL,
    "UpdatedOnUtc" timestamp without time zone NOT NULL,
    "AllowCustomerReview" boolean NOT NULL,
    "ApprovedRatingSum" integer NOT NULL,
    "NotApprovedRatingSum" integer NOT NULL,
    "ApprovedTotalReviews" integer NOT NULL,
    "NotApprovedTotalReviews" integer NOT NULL,
    CONSTRAINT "PK_StormyProduct" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyProduct_Brand_BrandId" FOREIGN KEY ("BrandId") REFERENCES "Brand" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyProduct_Category_CategoryId" FOREIGN KEY ("CategoryId") REFERENCES "Category" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyProduct_StormyVendor_VendorId" FOREIGN KEY ("VendorId") REFERENCES "StormyVendor" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Review" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "StormyCustomerId" bigint NOT NULL,
    "Title" text NULL,
    "Comment" text NULL,
    "ReviewerName" text NULL,
    "RatingLevel" integer NOT NULL,
    CONSTRAINT "PK_Review" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Review_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Shipment" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "StormyCustomerId" bigint NOT NULL,
    "UserId" text NULL,
    "WhoReceives" text NULL,
    "TrackNumber" character varying(250) NULL,
    "ShipmentMethod" text NULL,
    "ShipmentProviderName" text NULL,
    "TotalWeight" numeric NOT NULL,
    "CreatedOn" timestamp without time zone NOT NULL,
    "ShippedDate" timestamp without time zone NOT NULL,
    "DeliveryDate" timestamp without time zone NOT NULL,
    "Comment" text NULL,
    "Price" numeric NOT NULL,
    "DeliveryCost" numeric NOT NULL,
    "BillingAddressId" bigint NOT NULL,
    "DestinationAddressId" bigint NOT NULL,
    "Height" numeric NOT NULL,
    "Width" numeric NOT NULL,
    "Diameter" numeric NOT NULL,
    CONSTRAINT "PK_Shipment" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Shipment_Address_BillingAddressId" FOREIGN KEY ("BillingAddressId") REFERENCES "Address" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Shipment_Address_DestinationAddressId" FOREIGN KEY ("DestinationAddressId") REFERENCES "Address" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Shipment_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Media" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Caption" text NULL,
    "FileSize" integer NOT NULL,
    "FileName" text NULL,
    "MediaType" integer NOT NULL,
    "SeoFileName" text NULL,
    CONSTRAINT "PK_Media" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Media_StormyProduct_Id" FOREIGN KEY ("Id") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductAttribute" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "GroupId" bigint NOT NULL,
    "Name" text NULL,
    "StormyProductId" bigint NULL,
    CONSTRAINT "PK_ProductAttribute" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductAttribute_ProductAttributeGroup_GroupId" FOREIGN KEY ("GroupId") REFERENCES "ProductAttributeGroup" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductAttribute_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "ProductLink" (
    "Id" bigint NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "ProductId" bigint NOT NULL,
    "LinkedProductId" bigint NOT NULL,
    "LinkType" integer NOT NULL,
    CONSTRAINT "PK_ProductLink" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductLink_StormyProduct_Id" FOREIGN KEY ("Id") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_ProductLink_StormyProduct_LinkedProductId" FOREIGN KEY ("LinkedProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_ProductLink_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductOptionValue" (
    "Id" bigserial NOT NULL,
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

CREATE TABLE "WishlistItem" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "ProductId" integer NOT NULL,
    "ProductId1" bigint NULL,
    "WishlistId" bigint NOT NULL,
    "AddedAt" timestamp without time zone NOT NULL,
    "Deleted" boolean NOT NULL,
    CONSTRAINT "PK_WishlistItem" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_WishlistItem_StormyProduct_ProductId1" FOREIGN KEY ("ProductId1") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_WishlistItem_Wishlist_WishlistId" FOREIGN KEY ("WishlistId") REFERENCES "Wishlist" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ShipmentItem" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "ShipmentId" integer NOT NULL,
    "OrderItemId" integer NOT NULL,
    "Quantity" integer NOT NULL,
    "ShipmentId1" bigint NULL,
    CONSTRAINT "PK_ShipmentItem" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ShipmentItem_Shipment_ShipmentId1" FOREIGN KEY ("ShipmentId1") REFERENCES "Shipment" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "StormyOrder" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "OrderUniqueKey" uuid NOT NULL,
    "CustomerId" bigint NOT NULL,
    "PaymentId" bigint NOT NULL,
    "ShipmentId" bigint NOT NULL,
    "PickUpInStore" boolean NOT NULL,
    "IsCancelled" boolean NOT NULL,
    "ShippingMethod" text NULL,
    "PaymentMethod" character varying(450) NOT NULL,
    "TrackNumber" text NULL,
    "Note" character varying(1000) NULL,
    "Comment" text NULL,
    "Discount" numeric NOT NULL,
    "Tax" numeric NOT NULL,
    "TotalWeight" numeric NOT NULL,
    "TotalPrice" numeric NOT NULL,
    "DeliveryCost" numeric NOT NULL,
    "ShippingAddressId" bigint NULL,
    "OrderDate" timestamp without time zone NOT NULL,
    "RequiredDate" timestamp without time zone NOT NULL,
    "ShippedDate" timestamp without time zone NOT NULL,
    "DeliveryDate" timestamp without time zone NOT NULL,
    "PaymentDate" timestamp without time zone NULL,
    "Status" integer NOT NULL,
    "ShippingStatus" integer NOT NULL,
    CONSTRAINT "PK_StormyOrder" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyOrder_StormyCustomer_CustomerId" FOREIGN KEY ("CustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyOrder_Shipment_ShipmentId" FOREIGN KEY ("ShipmentId") REFERENCES "Shipment" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyOrder_Address_ShippingAddressId" FOREIGN KEY ("ShippingAddressId") REFERENCES "Address" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "ProductAttributeValue" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "AttributeId" bigint NOT NULL,
    "ProductId" bigint NOT NULL,
    "Value" text NULL,
    CONSTRAINT "PK_ProductAttributeValue" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductAttributeValue_ProductAttribute_AttributeId" FOREIGN KEY ("AttributeId") REFERENCES "ProductAttribute" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductAttributeValue_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "ProductTemplateProductAttribute" (
    "ProductTemplateId" bigint NOT NULL,
    "ProductAttributeId" bigint NOT NULL,
    CONSTRAINT "PK_ProductTemplateProductAttribute" PRIMARY KEY ("ProductTemplateId", "ProductAttributeId"),
    CONSTRAINT "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAtt~" FOREIGN KEY ("ProductAttributeId") REFERENCES "ProductAttribute" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemp~" FOREIGN KEY ("ProductTemplateId") REFERENCES "ProductTemplate" ("Id") ON DELETE RESTRICT
);

CREATE TABLE "OrderItem" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Quantity" integer NOT NULL,
    "Price" text NULL,
    "StormyProductId" bigint NOT NULL,
    "StormyOrderId" bigint NOT NULL,
    "ProductName" text NULL,
    "ShipmentId" bigint NOT NULL,
    CONSTRAINT "PK_OrderItem" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_OrderItem_Shipment_ShipmentId" FOREIGN KEY ("ShipmentId") REFERENCES "Shipment" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_OrderItem_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_OrderItem_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Payment" (
    "Id" bigserial NOT NULL,
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

CREATE INDEX "IX_ProductAttribute_StormyProductId" ON "ProductAttribute" ("StormyProductId");

CREATE INDEX "IX_ProductAttributeValue_AttributeId" ON "ProductAttributeValue" ("AttributeId");

CREATE INDEX "IX_ProductAttributeValue_ProductId" ON "ProductAttributeValue" ("ProductId");

CREATE INDEX "IX_ProductLink_LinkedProductId" ON "ProductLink" ("LinkedProductId");

CREATE INDEX "IX_ProductLink_ProductId" ON "ProductLink" ("ProductId");

CREATE INDEX "IX_ProductOptionValue_OptionId" ON "ProductOptionValue" ("OptionId");

CREATE INDEX "IX_ProductOptionValue_ProductId" ON "ProductOptionValue" ("ProductId");

CREATE INDEX "IX_ProductTemplateProductAttribute_ProductAttributeId" ON "ProductTemplateProductAttribute" ("ProductAttributeId");

CREATE INDEX "IX_Review_StormyCustomerId" ON "Review" ("StormyCustomerId");

CREATE INDEX "IX_Shipment_BillingAddressId" ON "Shipment" ("BillingAddressId");

CREATE INDEX "IX_Shipment_DestinationAddressId" ON "Shipment" ("DestinationAddressId");

CREATE INDEX "IX_Shipment_StormyCustomerId" ON "Shipment" ("StormyCustomerId");

CREATE INDEX "IX_ShipmentItem_ShipmentId1" ON "ShipmentItem" ("ShipmentId1");

CREATE UNIQUE INDEX "IX_StormyCustomer_CustomerWishlistId" ON "StormyCustomer" ("CustomerWishlistId");

CREATE INDEX "IX_StormyCustomer_DefaultBillingAddressId" ON "StormyCustomer" ("DefaultBillingAddressId");

CREATE INDEX "IX_StormyCustomer_DefaultShippingAddressId" ON "StormyCustomer" ("DefaultShippingAddressId");

CREATE INDEX "IX_StormyOrder_CustomerId" ON "StormyOrder" ("CustomerId");

CREATE INDEX "IX_StormyOrder_ShipmentId" ON "StormyOrder" ("ShipmentId");

CREATE INDEX "IX_StormyOrder_ShippingAddressId" ON "StormyOrder" ("ShippingAddressId");

CREATE INDEX "IX_StormyProduct_BrandId" ON "StormyProduct" ("BrandId");

CREATE UNIQUE INDEX "IX_StormyProduct_CategoryId" ON "StormyProduct" ("CategoryId");

CREATE INDEX "IX_StormyProduct_VendorId" ON "StormyProduct" ("VendorId");

CREATE INDEX "IX_StormyVendor_AddressId1" ON "StormyVendor" ("AddressId1");

CREATE INDEX "IX_WishlistItem_ProductId1" ON "WishlistItem" ("ProductId1");

CREATE INDEX "IX_WishlistItem_WishlistId" ON "WishlistItem" ("WishlistId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20190909024945_InitialCreate', '2.2.6-servicing-10079');

