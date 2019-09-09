CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
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
VALUES ('20190909005424_initialCreate', '2.2.4-servicing-10062');

INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (3, 'Totam sunt aliquid laudantium et aut magnam possimus quasi non.', FALSE, TIMESTAMPTZ '2019-09-05 07:38:25.041591-03:00', 'https://picsum.photos/640/480/?image=39', 'Santos, Santos and Barros', 'aut-sint-ea', 'janaína.org');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (10, 'Aliquid aliquam inventore qui suscipit quaerat velit. Perferendis inventore aut sint unde reprehenderit saepe porro ipsum. Qui sit ex ut consequatur quod omnis dolor.', FALSE, TIMESTAMPTZ '2019-09-02 17:37:32.285461-03:00', 'https://picsum.photos/640/480/?image=826', 'Batista, Braga and Barros', 'culpa-accusantium-tempora', 'morgana.org');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (9, 'Enim aperiam qui ut sed occaecati molestiae sit perspiciatis consequatur. Magni alias quam necessitatibus quas perspiciatis esse illum aut. Suscipit voluptate voluptatem laborum sint totam iusto quia incidunt. Qui id fuga qui quia esse fuga praesentium.', FALSE, TIMESTAMPTZ '2019-08-29 23:22:44.973562-03:00', 'https://picsum.photos/640/480/?image=438', 'Silva LTDA', 'ipsa-quibusdam-error', 'mércia.name');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (8, 'Et ex aliquam iure ea commodi earum nesciunt sequi et. Maxime delectus quos voluptatibus nisi at voluptates ducimus assumenda et. Ipsam praesentium qui velit. Nesciunt dolorem atque perferendis voluptatum asperiores commodi aut odio sed. Enim incidunt est. Asperiores cupiditate autem quis est qui aspernatur facere voluptate.', FALSE, TIMESTAMPTZ '2019-08-22 07:53:16.72834-03:00', 'https://picsum.photos/640/480/?image=917', 'Nogueira S.A.', 'ipsa-eos-dolores', 'paulo.name');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (7, 'Et eaque ducimus saepe dolore fugiat ad dicta beatae. Labore non molestiae voluptatem velit incidunt. Quod ex explicabo maxime ut velit modi. Sit voluptatem dolores consequatur.', FALSE, TIMESTAMPTZ '2019-08-20 17:26:04.291254-03:00', 'https://picsum.photos/640/480/?image=636', 'Batista e Associados', 'dolorem-quas-harum', 'roberta.name');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (6, 'quo', FALSE, TIMESTAMPTZ '2019-08-28 09:04:26.61838-03:00', 'https://picsum.photos/640/480/?image=932', 'Saraiva LTDA', 'fugiat-consequuntur-aut', 'félix.biz');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (5, 'Sed dolores voluptates perspiciatis. Ab voluptates aut. Eius rerum perferendis nemo exercitationem ut commodi eos ipsum. Aut quos et magni eius ullam et.', FALSE, TIMESTAMPTZ '2019-09-08 02:35:42.687994-03:00', 'https://picsum.photos/640/480/?image=450', 'Carvalho e Associados', 'consectetur-in-ab', 'marli.info');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (4, 'omnis', FALSE, TIMESTAMPTZ '2019-08-21 08:14:13.444272-03:00', 'https://picsum.photos/640/480/?image=1038', 'Nogueira - Oliveira', 'sed-sunt-porro', 'maria.info');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (2, 'Ea odit magni facilis assumenda qui itaque sed.', FALSE, TIMESTAMPTZ '2019-08-29 01:09:06.062219-03:00', 'https://picsum.photos/640/480/?image=880', 'Souza, Silva and Silva', 'laudantium-quas-tempora', 'vitória.br');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (1, 'est', FALSE, TIMESTAMPTZ '2019-08-23 02:49:14.126694-03:00', 'https://picsum.photos/640/480/?image=209', 'Franco - Reis', 'labore-et-ab', 'rafael.br');

INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (1, 'Illum nihil laboriosam iste. Incidunt dolorem sapiente dicta architecto in iure possimus qui. Voluptas voluptas distinctio possimus voluptates. Laudantium eius eaque nesciunt alias dolore ipsam. Omnis veniam ea quia repellendus labore aut dolor doloribus.', 0, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-16 11:43:45.542019-03:00', 'Quia qui excepturi id ut deserunt amet voluptate asperiores blanditiis.
                Vitae optio et ex atque.
                In dolor voluptatibus molestias eos.
                Temporibus eius dolor aut culpa incidunt officia.
                Ab explicabo sit quis debitis.', NULL, NULL, 'Grocery', NULL, 'impedit-iusto-amet', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (9, 'Eaque perferendis soluta ab voluptatem placeat fugit suscipit voluptates. Excepturi cumque qui sapiente quia neque. Reprehenderit perferendis facere.', 8, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-09-05 01:45:58.522715-03:00', 'Doloribus eveniet quia vel sed ullam illum non dolores.', NULL, NULL, 'Tools', NULL, 'est-odit-assumenda', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (8, 'Esse dolorum iste ullam sed quod.', 7, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-27 23:43:30.07378-03:00', 'Est ex est consequuntur voluptatem voluptatibus reprehenderit eum ipsa voluptatem. Mollitia velit et sint veniam. Est consequatur aut pariatur iusto dignissimos. Et voluptatem qui et dolor. Amet molestiae culpa ducimus eum est exercitationem ut atque molestiae.', NULL, NULL, 'Computers', NULL, 'voluptas-omnis-et', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (7, 'Eligendi nobis nostrum voluptatem in architecto similique modi.
                Dolor cum quod accusamus ullam laudantium modi facere amet vel.
                Ipsa adipisci quia consequatur est a occaecati ut aut.
                Eius ipsa dolor explicabo.
                Est aspernatur minus quia maiores voluptatum repellat non rerum numquam.', 6, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-25 13:14:14.981547-03:00', 'Consequatur voluptatibus libero quas.', NULL, NULL, 'Baby', NULL, 'velit-nesciunt-recusandae', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (6, 'Iure repellat magnam ipsam. Recusandae molestiae laborum quas aut iusto ut voluptatem. Enim optio possimus. Qui porro repellat qui illum in in quibusdam harum praesentium.', 5, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-26 13:36:55.715436-03:00', 'Repellendus inventore ipsa modi et et necessitatibus voluptatem voluptatem.', NULL, NULL, 'Computers', NULL, 'corporis-ducimus-saepe', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (5, 'Laboriosam tenetur voluptas odio magnam veritatis qui.', 4, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-29 21:48:15.802845-03:00', 'Ut quis molestias omnis sunt aut optio delectus.', NULL, NULL, 'Jewelery', NULL, 'placeat-a-doloribus', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (4, 'Quibusdam rerum commodi molestiae tempore illo.
                Eum alias modi tenetur consequatur.
                Animi iure et officia et enim nisi doloribus.
                Ipsam reprehenderit tempora.
                Nemo suscipit quo modi libero inventore dicta quas.', 3, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-09-06 01:03:53.372909-03:00', 'reprehenderit', NULL, NULL, 'Tools', NULL, 'unde-enim-voluptas', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (3, 'Culpa praesentium eos necessitatibus blanditiis fugit expedita voluptas doloribus. Voluptas optio commodi voluptas distinctio. Perspiciatis numquam vitae est minima perferendis iste ipsum est. Nam porro repellendus accusamus placeat illo velit. Debitis exercitationem et accusamus nesciunt temporibus dolor. Temporibus id et alias aut.', 2, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-24 07:09:38.302278-03:00', 'Adipisci odio iusto quo quia provident error et eligendi neque.', NULL, NULL, 'Movies', NULL, 'pariatur-qui-earum', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (2, 'Ut ad molestias. Aut dolorum debitis deserunt. Cum eum quasi ab est eum temporibus dolorum id. Voluptate sed voluptatem doloribus. Veniam deleniti omnis et non quis et mollitia. Iusto qui rerum libero voluptas.', 1, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-09-07 10:26:14.000119-03:00', 'Maxime modi esse quidem ullam eum maiores ab.
                Autem praesentium minus nihil reiciendis nihil.
                Eum pariatur ea nulla perferendis.
                Praesentium possimus repellendus possimus laborum ut.
                Sed omnis ut error optio quis.', NULL, NULL, 'Industrial', NULL, 'ipsa-sunt-quae', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (10, 'eos', 9, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-09-05 00:23:30.376254-03:00', 'Quae id eveniet accusantium dolor. Et nisi blanditiis. Assumenda officiis praesentium in. Voluptatem repellendus nulla assumenda. Illum occaecati cumque quaerat repellendus mollitia et sunt. Sapiente itaque et.', NULL, NULL, 'Music', NULL, 'sit-quam-quis', 'http://lorempixel.com/640/480/fashion');

INSERT INTO "Entity" ("Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug")
VALUES (4, 1, 'Product', FALSE, TIMESTAMPTZ '2019-09-08 00:01:23.950474-03:00', 'Small Soft Pants', 'cum-impedit-fuga');
INSERT INTO "Entity" ("Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug")
VALUES (1, 1, 'Product', FALSE, TIMESTAMPTZ '2019-09-07 23:44:09.543513-03:00', 'Small Cotton Hat', 'non-magni-delectus');
INSERT INTO "Entity" ("Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug")
VALUES (2, 1, 'Product', FALSE, TIMESTAMPTZ '2019-09-08 12:20:59.42595-03:00', 'Unbranded Metal Bike', 'consequatur-nam-molestiae');
INSERT INTO "Entity" ("Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug")
VALUES (3, 1, 'Product', FALSE, TIMESTAMPTZ '2019-09-07 23:59:34.113998-03:00', 'Practical Metal Salad', 'quam-modi-rerum');
INSERT INTO "Entity" ("Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug")
VALUES (5, 1, 'Product', FALSE, TIMESTAMPTZ '2019-09-07 18:50:58.794931-03:00', 'Intelligent Metal Soap', 'porro-voluptatum-ipsa');
INSERT INTO "Entity" ("Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug")
VALUES (9, 1, 'Product', FALSE, TIMESTAMPTZ '2019-09-06 22:53:23.740313-03:00', 'Handcrafted Concrete Pizza', 'quam-nisi-quidem');
INSERT INTO "Entity" ("Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug")
VALUES (7, 1, 'Product', FALSE, TIMESTAMPTZ '2019-09-08 20:50:26.533063-03:00', 'Tasty Fresh Shoes', 'iure-omnis-atque');
INSERT INTO "Entity" ("Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug")
VALUES (8, 1, 'Product', FALSE, TIMESTAMPTZ '2019-09-07 02:40:34.630358-03:00', 'Licensed Wooden Shirt', 'hic-laboriosam-consequatur');
INSERT INTO "Entity" ("Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug")
VALUES (10, 1, 'Product', FALSE, TIMESTAMPTZ '2019-09-07 10:06:59.35649-03:00', 'Small Metal Tuna', 'consectetur-rerum-aperiam');
INSERT INTO "Entity" ("Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug")
VALUES (6, 1, 'Product', FALSE, TIMESTAMPTZ '2019-09-08 01:38:16.946688-03:00', 'Handmade Granite Hat', 'quia-repellat-est');

UPDATE "Shipment" SET "CreatedOn" = TIMESTAMP '2019-09-09 01:21:49.958875', "LastModified" = TIMESTAMPTZ '2019-09-09 01:21:49.958875+00:00', "TrackNumber" = '0df2c052-bd92-4ef5-972b-d2a06bd8296f'
WHERE "Id" = 2;

INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (39, FALSE, 0, 0, FALSE, 39, 39, TIMESTAMP '2018-10-23 14:28:13.235613', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918933+00:00', 39, 0, 0, FALSE, 'alias', 'R$56,54', TIMESTAMP '2019-12-05 08:19:22.052447', 'R$4,63', TRUE, 0.0086502879898298, 0, 'Incredible Plastic Bike', TRUE, 36, 39, 'oksugn8ps0vurayk', 'rerum-fugit-et', 'Good', TRUE, NULL, 'Computers', 70.767855723746, 8.28400865117275, 0.48603081912083124, 5, 4, TIMESTAMP '2019-09-09 11:21:55.391954', 39);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (40, FALSE, 0, 0, FALSE, 40, 40, TIMESTAMP '2019-08-22 17:16:59.418076', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918955+00:00', 40, 0, 0, FALSE, 'Alias suscipit ex qui officia alias occaecati aliquam. Doloribus est dolores eligendi non illo. Itaque placeat illum impedit ut sed sequi et nemo. Sit qui ea officia. Et culpa voluptatibus dicta est eum sint libero inventore. Vitae quaerat explicabo quo at omnis veniam facilis necessitatibus.', 'R$24,47', TIMESTAMP '2020-02-13 15:49:55.823395', 'R$81,62', TRUE, 0.157163063603064, 0, 'Gorgeous Plastic Shoes', TRUE, 24, 40, '8f3cpucp3y6c92ac', 'maxime-dicta-commodi', 'Good', TRUE, NULL, 'Industrial', 69.9145312280928, 2.1515053287854, 0.74281104316134516, 8, 8, TIMESTAMP '2019-09-08 16:06:10.110681', 40);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (41, FALSE, 0, 0, FALSE, 41, 41, TIMESTAMP '2019-02-15 13:50:29.576482', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.919006+00:00', 41, 0, 0, FALSE, 'Molestiae in alias enim beatae.
                Consectetur ea a recusandae corporis nulla odio adipisci accusamus qui.
                In quia nisi.
                Quia modi veritatis soluta dolore impedit nihil consequuntur reprehenderit.', 'R$5,64', TIMESTAMP '2020-06-15 19:29:08.486077', 'R$8,22', TRUE, 0.220530608771616, 0, 'Sleek Plastic Chips', TRUE, 74, 41, 'sww4sjpug0f2rx5y', 'inventore-non-qui', 'Good', TRUE, NULL, 'Baby', 46.9380942391875, 0.841017780285802, 0.7740645193374085, 8, 7, TIMESTAMP '2019-09-09 04:19:40.042802', 41);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (42, FALSE, 0, 0, FALSE, 42, 42, TIMESTAMP '2018-12-02 08:57:32.591796', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.919045+00:00', 42, 0, 0, FALSE, 'Adipisci vel enim sit rerum repudiandae nulla hic. Dolorem maxime nobis voluptas est architecto dolores impedit dignissimos. Eos nulla facilis velit ex provident. Et non nihil impedit aliquid ea.', 'R$117,90', TIMESTAMP '2019-09-19 14:12:25.285873', 'R$44,49', TRUE, 0.214703987918191, 0, 'Handcrafted Frozen Chips', TRUE, 86, 42, 'l395uavldpbe5fb6', 'earum-harum-fugiat', 'Good', TRUE, NULL, 'Home', 62.3042290854753, 2.84946910238334, 0.87555582117082353, 1, 2, TIMESTAMP '2019-09-08 21:03:21.703693', 42);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (43, FALSE, 0, 0, FALSE, 43, 43, TIMESTAMP '2019-05-15 02:06:23.675406', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.919091+00:00', 43, 0, 0, FALSE, 'Dignissimos aliquid sapiente dolor.', 'R$173,84', TIMESTAMP '2019-12-05 21:25:32.739683', 'R$26,52', TRUE, 0.652881345550009, 0, 'Licensed Fresh Shoes', TRUE, 34, 43, 'xhv3ojqgsi4vj6wh', 'provident-ab-harum', 'Good', TRUE, NULL, 'Beauty', 17.981447800054, 2.464575861797, 0.39454672643660882, 3, 9, TIMESTAMP '2019-09-09 07:46:40.068017', 43);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (44, FALSE, 0, 0, FALSE, 44, 44, TIMESTAMP '2018-10-04 14:55:20.769842', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.919116+00:00', 44, 0, 0, FALSE, 'eos', 'R$169,31', TIMESTAMP '2020-06-02 04:12:11.387143', 'R$97,02', TRUE, 0.869588138940552, 0, 'Awesome Fresh Gloves', TRUE, 78, 44, 'pnl8spz5ccg5mwa8', 'omnis-quae-deserunt', 'Good', TRUE, NULL, 'Movies', 37.2795286296306, 9.13652768784041, 0.92152253627848002, 0, 8, TIMESTAMP '2019-09-09 03:20:20.213084', 44);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (46, FALSE, 0, 0, FALSE, 46, 46, TIMESTAMP '2018-12-29 00:47:23.697542', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.919167+00:00', 46, 0, 0, FALSE, 'Natus aut quis assumenda aut deleniti corrupti dolor inventore.
                Error numquam eius officiis.
                Quos nulla animi expedita aperiam.
                Odit ut laudantium amet cumque excepturi libero dolores laboriosam sit.', 'R$102,52', TIMESTAMP '2019-12-07 00:49:09.08265', 'R$38,92', TRUE, 0.523882869409343, 0, 'Handcrafted Frozen Soap', TRUE, 74, 46, 'eof1jn0c03c90byc', 'saepe-saepe-voluptas', 'Good', TRUE, NULL, 'Outdoors', 87.1993276230988, 5.37829653144735, 0.15423408996045315, 7, 1, TIMESTAMP '2019-09-08 04:37:59.576239', 46);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (47, FALSE, 0, 0, FALSE, 47, 47, TIMESTAMP '2019-06-11 01:29:46.995261', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.919207+00:00', 47, 0, 0, FALSE, 'vel', 'R$131,76', TIMESTAMP '2020-01-12 01:24:41.432245', 'R$46,32', TRUE, 0.35528677578796, 0, 'Practical Cotton Chips', TRUE, 28, 47, 't0d9inknukzjwgrt', 'culpa-velit-ut', 'Good', TRUE, NULL, 'Sports', 6.10771361091533, 7.15326104180574, 0.18313758223463669, 7, 6, TIMESTAMP '2019-09-08 18:07:36.748855', 47);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (48, FALSE, 0, 0, FALSE, 48, 48, TIMESTAMP '2019-08-11 21:54:33.875681', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.919232+00:00', 48, 0, 0, FALSE, 'Velit quod libero ut. Quisquam ducimus non. Est facere et itaque non dolore. Cupiditate et eaque. Consectetur qui rerum ut. Commodi et harum quia voluptate.', 'R$7,45', TIMESTAMP '2020-04-13 07:08:10.697621', 'R$68,49', TRUE, 0.660856823744651, 0, 'Ergonomic Frozen Mouse', TRUE, 48, 48, 'u3uimeym867ltflp', 'aut-rerum-velit', 'Good', TRUE, NULL, 'Toys', 20.3538313137152, 1.921510948763, 0.18115461998672905, 2, 7, TIMESTAMP '2019-09-09 07:54:43.815807', 48);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (49, FALSE, 0, 0, FALSE, 49, 49, TIMESTAMP '2018-12-22 10:25:01.252957', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.919277+00:00', 49, 0, 0, FALSE, 'Odit non deleniti quia reiciendis ullam saepe praesentium provident. Illum et tempore amet est possimus eos. Aut quod laborum dolorum impedit error ab et alias totam. Sunt ex nobis non dolor.', 'R$151,12', TIMESTAMP '2020-01-31 12:46:15.764993', 'R$3,98', TRUE, 0.443583503106415, 0, 'Incredible Fresh Ball', TRUE, 82, 49, 'wiftrjzy4oxvqz0u', 'voluptatem-rerum-possimus', 'Good', TRUE, NULL, 'Jewelery', 3.44242984589302, 8.87438341457135, 0.092149143150145718, 7, 4, TIMESTAMP '2019-09-08 08:18:44.297542', 49);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (50, FALSE, 0, 0, FALSE, 50, 50, TIMESTAMP '2019-05-27 02:53:42.361743', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.919318+00:00', 50, 0, 0, FALSE, 'eum', 'R$126,17', TIMESTAMP '2020-03-12 09:58:42.253861', 'R$41,68', TRUE, 0.154674463511759, 0, 'Licensed Plastic Sausages', TRUE, 98, 50, 'w5pbclhrp5h8w4ja', 'nihil-magni-odio', 'Good', TRUE, NULL, 'Computers', 42.6539593574842, 3.13471169822603, 0.16318879144414739, 4, 6, TIMESTAMP '2019-09-09 02:06:40.492352', 50);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (38, FALSE, 0, 0, FALSE, 38, 38, TIMESTAMP '2019-09-02 21:21:02.670835', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918894+00:00', 38, 0, 0, FALSE, 'Est et adipisci nihil quasi labore adipisci.
                Quia error nihil inventore occaecati.
                Qui suscipit quia aliquam ut cupiditate doloremque dolores placeat.
                Totam consequuntur aut consequatur.', 'R$138,63', TIMESTAMP '2020-02-21 21:52:25.982168', 'R$59,22', TRUE, 0.0977343363211184, 0, 'Licensed Concrete Cheese', TRUE, 22, 38, 'ci4sp4li4lbi0bxr', 'dicta-voluptatem-sit', 'Good', TRUE, NULL, 'Movies', 75.6327221056599, 6.4075899805909, 0.20558505188933809, 0, 0, TIMESTAMP '2019-09-09 08:27:28.462497', 38);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (45, FALSE, 0, 0, FALSE, 45, 45, TIMESTAMP '2018-11-15 12:23:12.657274', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.919142+00:00', 45, 0, 0, FALSE, 'Non accusantium molestiae beatae deserunt culpa nemo.', 'R$27,74', TIMESTAMP '2020-08-12 15:53:49.438186', 'R$55,64', TRUE, 0.323246334364287, 0, 'Handmade Soft Soap', TRUE, 18, 45, 'ig7ltsq0ewfx6yuj', 'quibusdam-nostrum-libero', 'Good', TRUE, NULL, 'Electronics', 48.706354363219, 5.11812743037852, 0.53663965386182055, 7, 6, TIMESTAMP '2019-09-09 02:16:27.692891', 45);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (37, FALSE, 0, 0, FALSE, 37, 37, TIMESTAMP '2019-02-11 19:33:20.315019', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918855+00:00', 37, 0, 0, FALSE, 'Dolor sint cumque.
                Et eos aspernatur.
                Inventore quia deserunt voluptas assumenda est non quidem qui.
                Esse voluptas voluptatem sunt saepe soluta.
                Sunt facilis praesentium.', 'R$171,21', TIMESTAMP '2019-11-05 05:26:56.328171', 'R$5,74', TRUE, 0.179452706211923, 0, 'Licensed Cotton Pants', TRUE, 28, 37, 'uhz0rnbwda2gam7m', 'non-at-et', 'Good', TRUE, NULL, 'Clothing', 52.5953166897387, 8.47135023608401, 0.95414447363193355, 10, 4, TIMESTAMP '2019-09-08 18:59:59.405199', 37);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (31, FALSE, 0, 0, FALSE, 31, 31, TIMESTAMP '2018-10-13 18:15:50.437873', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918656+00:00', 31, 0, 0, FALSE, 'Rerum corporis quo ut quam.', 'R$150,78', TIMESTAMP '2020-07-08 16:14:44.669477', 'R$37,44', TRUE, 0.337242469814253, 0, 'Unbranded Frozen Bike', TRUE, 34, 31, 'z3q1bdvtuuj6odce', 'maxime-reiciendis-repudiandae', 'Good', TRUE, NULL, 'Toys', 77.3535941156343, 5.11596045695057, 0.41919439352079962, 7, 3, TIMESTAMP '2019-09-08 20:43:56.488936', 31);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (35, FALSE, 0, 0, FALSE, 35, 35, TIMESTAMP '2018-12-19 14:29:40.348312', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918793+00:00', 35, 0, 0, FALSE, 'Mollitia accusamus consectetur beatae natus rerum officiis iusto. Libero in dignissimos sit explicabo voluptatibus fuga mollitia asperiores. Quis ex excepturi veritatis ea.', 'R$133,16', TIMESTAMP '2020-05-29 21:57:24.51555', 'R$22,68', TRUE, 0.979414777354996, 0, 'Incredible Concrete Mouse', TRUE, 54, 35, '5154njc9alvu5naa', 'suscipit-qui-doloribus', 'Good', TRUE, NULL, 'Books', 32.1055863667771, 1.76236594643554, 0.7464740666311579, 3, 0, TIMESTAMP '2019-09-09 04:51:08.688737', 35);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (11, FALSE, 0, 0, FALSE, 11, 11, TIMESTAMP '2018-10-28 20:09:20.155984', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917915+00:00', 11, 0, 0, FALSE, 'Officia sequi debitis sunt facere perspiciatis.', 'R$153,28', TIMESTAMP '2020-02-24 22:42:16.93116', 'R$46,68', TRUE, 0.80679363003317, 0, 'Practical Concrete Shoes', TRUE, 70, 11, 'nzrphvb1x4muwxv2', 'qui-blanditiis-molestiae', 'Good', TRUE, NULL, 'Outdoors', 22.2262196346308, 7.83375084299303, 0.59794866600909669, 7, 6, TIMESTAMP '2019-09-09 09:03:47.020107', 11);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (12, FALSE, 0, 0, FALSE, 12, 12, TIMESTAMP '2018-11-27 10:42:37.18373', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917942+00:00', 12, 0, 0, FALSE, 'Enim ut voluptas alias.
                Magnam sed qui velit nobis adipisci ex incidunt.
                Id voluptatem quia nobis aperiam.
                Temporibus quia odit ipsa.', 'R$128,70', TIMESTAMP '2020-01-21 17:31:27.869195', 'R$46,46', TRUE, 0.255708296436681, 0, 'Small Concrete Salad', TRUE, 26, 12, 'e5o1wyicfx7j4t6w', 'qui-ex-aut', 'Good', TRUE, NULL, 'Shoes', 37.4928126751877, 1.51954872138777, 0.41976917880576531, 3, 7, TIMESTAMP '2019-09-08 18:52:09.169713', 12);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (13, FALSE, 0, 0, FALSE, 13, 13, TIMESTAMP '2019-01-30 11:39:44.276096', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917979+00:00', 13, 0, 0, FALSE, 'Natus dolorem qui dicta tempora eveniet dolorem expedita.', 'R$93,02', TIMESTAMP '2019-09-28 06:45:42.92213', 'R$26,09', TRUE, 0.513662214630126, 0, 'Tasty Wooden Computer', TRUE, 12, 13, 'pfjfkn66ose1tr53', 'explicabo-iste-in', 'Good', TRUE, NULL, 'Tools', 54.3267866849558, 7.21912356895354, 0.051640555752273908, 10, 7, TIMESTAMP '2019-09-09 00:58:55.972327', 13);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (14, FALSE, 0, 0, FALSE, 14, 14, TIMESTAMP '2019-05-20 10:39:25.229776', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918009+00:00', 14, 0, 0, FALSE, 'Praesentium quos dignissimos natus maxime nisi alias non. Quo laboriosam aliquam. Fugit facilis officiis aut et.', 'R$101,44', TIMESTAMP '2019-10-28 12:47:09.725485', 'R$88,15', TRUE, 0.325773295166797, 0, 'Generic Cotton Chair', TRUE, 88, 14, '4n1tkqykp0dkwqi3', 'a-aut-hic', 'Good', TRUE, NULL, 'Kids', 43.0337288617314, 3.32566461680721, 0.83972615182387, 1, 8, TIMESTAMP '2019-09-09 11:32:34.138588', 14);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (15, FALSE, 0, 0, FALSE, 15, 15, TIMESTAMP '2019-06-12 13:45:22.078341', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918043+00:00', 15, 0, 0, FALSE, 'Assumenda laboriosam ullam neque reprehenderit velit et.
                Consequuntur earum eos laudantium dolores alias maxime commodi officiis.
                Molestias in natus.
                Tempora et ea aperiam numquam occaecati.
                Architecto ratione corporis.', 'R$164,88', TIMESTAMP '2020-08-12 03:00:33.802918', 'R$54,88', TRUE, 0.730819283859254, 0, 'Licensed Concrete Mouse', TRUE, 92, 15, 'poyuv9ix05dikx6l', 'suscipit-natus-eius', 'Good', TRUE, NULL, 'Jewelery', 36.7003809831573, 6.26484465145732, 0.15493425547840736, 4, 7, TIMESTAMP '2019-09-08 10:20:53.614138', 15);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (16, FALSE, 0, 0, FALSE, 16, 16, TIMESTAMP '2019-01-27 00:13:41.920351', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918087+00:00', 16, 0, 0, FALSE, 'Qui ducimus sed temporibus velit qui mollitia et officia.
                Nemo dolores voluptate explicabo excepturi qui voluptate magni voluptas dolore.
                Qui eius mollitia id incidunt autem necessitatibus maxime ex.
                Quasi impedit et.
                Qui quibusdam provident repudiandae expedita neque id.
                Perferendis blanditiis iste eum laudantium voluptate pariatur.', 'R$75,99', TIMESTAMP '2020-04-16 15:36:03.6577', 'R$86,37', TRUE, 0.880498895365977, 0, 'Rustic Plastic Tuna', TRUE, 80, 16, '0ctfmmskq71zb4sr', 'ex-adipisci-voluptates', 'Good', TRUE, NULL, 'Shoes', 91.8131047356004, 5.58726063724014, 0.67378393219494448, 2, 5, TIMESTAMP '2019-09-08 09:13:49.918136', 16);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (17, FALSE, 0, 0, FALSE, 17, 17, TIMESTAMP '2019-03-01 12:04:25.338036', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918135+00:00', 17, 0, 0, FALSE, 'Adipisci ut earum nemo qui. Quis ut eius assumenda aut doloribus deleniti dolorem doloribus. Optio non voluptas id. Praesentium eos quia. Tempora reiciendis quod. Quae eligendi similique.', 'R$115,91', TIMESTAMP '2019-12-13 10:57:00.729317', 'R$70,93', TRUE, 0.828983906111207, 0, 'Intelligent Frozen Pants', TRUE, 48, 17, 'pv8s8sihx0v76344', 'sed-qui-quae', 'Good', TRUE, NULL, 'Sports', 49.3752417384532, 8.93655412780892, 0.74450396594801171, 2, 0, TIMESTAMP '2019-09-09 09:15:40.502413', 17);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (36, FALSE, 0, 0, FALSE, 36, 36, TIMESTAMP '2019-08-04 21:04:07.334399', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.91883+00:00', 36, 0, 0, FALSE, 'sit', 'R$23,04', TIMESTAMP '2020-08-19 03:35:02.850479', 'R$1,20', TRUE, 0.677171506302977, 0, 'Incredible Rubber Chicken', TRUE, 8, 36, 'qosl0fvj2lkc3c4q', 'sunt-odio-quisquam', 'Good', TRUE, NULL, 'Garden', 82.8927630944609, 8.06327623690631, 0.85732109838040593, 9, 6, TIMESTAMP '2019-09-08 13:25:09.587546', 36);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (19, FALSE, 0, 0, FALSE, 19, 19, TIMESTAMP '2019-07-10 11:28:50.563243', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918225+00:00', 19, 0, 0, FALSE, 'dolore', 'R$91,67', TIMESTAMP '2019-11-14 20:29:29.957414', 'R$81,04', TRUE, 0.447769802272213, 0, 'Unbranded Wooden Table', TRUE, 80, 19, '8h7vasnim4u7qvgy', 'harum-reiciendis-saepe', 'Good', TRUE, NULL, 'Industrial', 40.4257609697179, 9.6470597151886, 0.40032750293627728, 7, 0, TIMESTAMP '2019-09-08 13:13:30.3325', 19);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (20, FALSE, 0, 0, FALSE, 20, 20, TIMESTAMP '2018-12-27 04:44:17.688486', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918247+00:00', 20, 0, 0, FALSE, 'Qui ad expedita blanditiis maiores atque.
                Et a occaecati ut occaecati.
                Qui facere non.', 'R$154,57', TIMESTAMP '2020-03-09 11:43:26.845511', 'R$48,18', TRUE, 0.156675286664011, 0, 'Incredible Wooden Chips', TRUE, 26, 20, 'eo50v470qhvzo06m', 'ad-vitae-aut', 'Good', TRUE, NULL, 'Games', 41.3925373653846, 6.555601654833, 0.70160124623291253, 1, 6, TIMESTAMP '2019-09-08 08:19:00.391368', 20);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (21, FALSE, 0, 0, FALSE, 21, 21, TIMESTAMP '2019-09-06 13:39:17.707138', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918281+00:00', 21, 0, 0, FALSE, 'Quia nesciunt et aliquam est.
                Quia aut nemo vel fuga odio odit sed nihil a.
                Et repellendus cumque.
                Sed sapiente qui voluptatum dolores et tempore neque enim.
                Nostrum repellendus asperiores quae et dicta iusto et sint omnis.', 'R$52,26', TIMESTAMP '2019-10-04 11:51:14.424502', 'R$21,15', TRUE, 0.726119154471028, 0, 'Small Soft Cheese', TRUE, 26, 21, '9gu7gwka78ioiwyb', 'error-ut-et', 'Good', TRUE, NULL, 'Computers', 77.3376784647525, 6.59944848930438, 0.68304773731299107, 9, 5, TIMESTAMP '2019-09-08 05:47:08.830291', 21);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (22, FALSE, 0, 0, FALSE, 22, 22, TIMESTAMP '2019-02-12 08:50:35.555583', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918357+00:00', 22, 0, 0, FALSE, 'Odio corrupti quae rem nihil ut voluptate.', 'R$11,12', TIMESTAMP '2019-12-11 08:31:39.90932', 'R$87,26', TRUE, 0.656116310346926, 0, 'Handmade Fresh Salad', TRUE, 64, 22, 't2gm71s8djyzvcn4', 'corrupti-quidem-officiis', 'Good', TRUE, NULL, 'Baby', 23.4175663550466, 2.83976122403506, 0.38736571063630548, 7, 3, TIMESTAMP '2019-09-08 14:12:57.773733', 22);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (18, FALSE, 0, 0, FALSE, 18, 18, TIMESTAMP '2019-01-25 16:47:55.118692', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.91818+00:00', 18, 0, 0, FALSE, 'Illo sed eos nesciunt tempore modi repudiandae ut ducimus omnis. Rem cum dolore explicabo. Praesentium qui voluptate autem sed. Placeat velit est veritatis aut quasi ipsa impedit libero. Excepturi ipsa enim velit aliquid expedita dolorum consequatur.', 'R$80,46', TIMESTAMP '2020-05-05 07:41:07.284842', 'R$97,47', TRUE, 0.75171517941715, 0, 'Handmade Frozen Sausages', TRUE, 28, 18, '9yc02ilhk31bq7ta', 'tempora-rerum-harum', 'Good', TRUE, NULL, 'Electronics', 99.7582716866202, 9.02725532605651, 0.46440220878664507, 9, 8, TIMESTAMP '2019-09-09 01:40:28.590247', 18);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (24, FALSE, 0, 0, FALSE, 24, 24, TIMESTAMP '2018-11-24 19:27:24.956555', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918419+00:00', 24, 0, 0, FALSE, 'Nulla nisi eum nulla. At et dignissimos. Optio quam rerum veniam consequatur et corporis. Ullam et iste quia dolor et qui ullam minus. Blanditiis earum explicabo animi provident. Perspiciatis ipsum totam qui dolorum non vel mollitia quod.', 'R$183,65', TIMESTAMP '2019-12-26 21:36:54.877643', 'R$23,70', TRUE, 0.00311370846029078, 0, 'Awesome Soft Car', TRUE, 32, 24, 'wejonaqq0t7gjo06', 'aut-laborum-nihil', 'Good', TRUE, NULL, 'Grocery', 93.7677325651831, 5.77698371176468, 0.6027264234622598, 6, 0, TIMESTAMP '2019-09-08 21:36:41.551104', 24);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (23, FALSE, 0, 0, FALSE, 23, 23, TIMESTAMP '2019-07-09 08:57:00.765589', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918394+00:00', 23, 0, 0, FALSE, 'Porro eum doloremque eum quo.', 'R$61,73', TIMESTAMP '2020-03-17 09:30:38.569413', 'R$51,49', TRUE, 0.854177849299357, 0, 'Refined Metal Keyboard', TRUE, 96, 23, '1mfu62y5tcyn4wwx', 'excepturi-excepturi-eum', 'Good', TRUE, NULL, 'Sports', 8.10807221946682, 5.7330054816478, 0.76432975370638523, 9, 9, TIMESTAMP '2019-09-09 05:30:10.4514', 23);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (33, FALSE, 0, 0, FALSE, 33, 33, TIMESTAMP '2018-10-28 16:10:21.204791', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918728+00:00', 33, 0, 0, FALSE, 'Ea recusandae similique dolores aut.', 'R$190,30', TIMESTAMP '2019-12-23 19:25:56.132256', 'R$35,80', TRUE, 0.523292097041054, 0, 'Ergonomic Granite Soap', TRUE, 56, 33, '9fpkb8ockbr7ivz2', 'voluptates-magni-voluptatem', 'Good', TRUE, NULL, 'Electronics', 71.0297122462791, 0.755866584720028, 0.75644976448102375, 1, 3, TIMESTAMP '2019-09-09 02:39:36.16855', 33);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (32, FALSE, 0, 0, FALSE, 32, 32, TIMESTAMP '2018-09-20 12:23:32.879698', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918682+00:00', 32, 0, 0, FALSE, 'Quam facilis reiciendis dolores ea et voluptatum. Recusandae et deleniti. Porro neque libero minus neque. Minima non nemo facere nostrum. Qui mollitia veniam a numquam sapiente. Similique dolorem qui a odit expedita qui.', 'R$26,99', TIMESTAMP '2019-12-11 10:18:44.334437', 'R$61,46', TRUE, 0.132406162625368, 0, 'Fantastic Cotton Shirt', TRUE, 82, 32, 'x87kne0zdrmlyml2', 'eum-ut-tenetur', 'Good', TRUE, NULL, 'Toys', 27.5612058711989, 6.38080841227472, 0.9980431264257259, 6, 0, TIMESTAMP '2019-09-09 02:50:21.500057', 32);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (30, FALSE, 0, 0, FALSE, 30, 30, TIMESTAMP '2019-02-09 00:36:35.653675', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.91862+00:00', 30, 0, 0, FALSE, 'Sed quod porro sint.
                Necessitatibus ea ut aperiam quis fuga totam facilis.
                At vitae hic qui quod.
                Distinctio velit incidunt.', 'R$21,21', TIMESTAMP '2020-09-02 14:25:19.384037', 'R$94,40', TRUE, 0.92855622383233, 0, 'Fantastic Wooden Fish', TRUE, 34, 30, '9a4juekhdiugky9a', 'dolor-officiis-qui', 'Good', TRUE, NULL, 'Games', 20.2414014470956, 7.09035757327935, 0.49126131436380621, 7, 4, TIMESTAMP '2019-09-08 03:59:56.52732', 30);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (34, FALSE, 0, 0, FALSE, 34, 34, TIMESTAMP '2019-08-31 10:34:03.984792', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918753+00:00', 34, 0, 0, FALSE, 'Sint vel doloribus. Et et dolor magnam fugiat mollitia consequatur. Distinctio ut nemo omnis quibusdam repudiandae. Earum voluptatem non et qui qui qui.', 'R$91,56', TIMESTAMP '2020-06-24 13:09:25.01845', 'R$50,28', TRUE, 0.162161725183093, 0, 'Handmade Steel Keyboard', TRUE, 26, 34, 'uwm3htk4u916qyew', 'eveniet-ea-hic', 'Good', TRUE, NULL, 'Baby', 16.4277588559444, 4.10813323413401, 0.92754169410445808, 4, 2, TIMESTAMP '2019-09-09 09:39:03.575111', 34);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (28, FALSE, 0, 0, FALSE, 28, 28, TIMESTAMP '2019-05-06 21:02:09.863644', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918552+00:00', 28, 0, 0, FALSE, 'Omnis pariatur sed explicabo aut recusandae saepe. Voluptas voluptatem et sint aperiam cupiditate. Molestiae earum molestiae enim ut reiciendis. Illum sit voluptatem ducimus vitae repudiandae dolorem non. Ex laborum at aut in quae.', 'R$48,04', TIMESTAMP '2020-07-05 11:56:31.400973', 'R$25,16', TRUE, 0.34641127118208, 0, 'Licensed Rubber Sausages', TRUE, 48, 28, 'egiz8aaekfkcca8k', 'quis-ut-iusto', 'Good', TRUE, NULL, 'Tools', 53.9993072180074, 3.19157861321772, 0.67787231722747554, 8, 7, TIMESTAMP '2019-09-09 02:35:13.068301', 28);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (27, FALSE, 0, 0, FALSE, 27, 27, TIMESTAMP '2019-02-05 12:50:57.241917', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918529+00:00', 27, 0, 0, FALSE, 'eveniet', 'R$57,27', TIMESTAMP '2020-01-18 02:41:14.836223', 'R$51,30', TRUE, 0.77023431461781, 0, 'Ergonomic Cotton Soap', TRUE, 94, 27, 'khl1b6wef62jia2h', 'non-corporis-qui', 'Good', TRUE, NULL, 'Books', 49.2119146274458, 3.17556973228956, 0.89477759408521351, 9, 4, TIMESTAMP '2019-09-09 09:32:45.285472', 27);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (26, FALSE, 0, 0, FALSE, 26, 26, TIMESTAMP '2019-02-07 16:39:54.902692', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918494+00:00', 26, 0, 0, FALSE, 'Nobis ea et dolores provident.
                Nisi ratione sed dolorem accusantium ut.
                Aut dolorem eum aut necessitatibus est.', 'R$155,71', TIMESTAMP '2020-07-29 03:29:43.042959', 'R$5,88', TRUE, 0.791772374320669, 0, 'Awesome Steel Bike', TRUE, 60, 26, 'am8qt4ya0ltjykeo', 'porro-ducimus-aut', 'Good', TRUE, NULL, 'Books', 55.3120605905131, 4.04614544662002, 0.86214974516171483, 1, 2, TIMESTAMP '2019-09-08 18:58:00.375626', 26);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (25, FALSE, 0, 0, FALSE, 25, 25, TIMESTAMP '2019-06-03 09:43:28.426546', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918471+00:00', 25, 0, 0, FALSE, 'nihil', 'R$69,89', TIMESTAMP '2019-09-20 12:34:30.930132', 'R$64,65', TRUE, 0.859905632613183, 0, 'Handmade Soft Ball', TRUE, 38, 25, 'd2nf8jaizih3wtq6', 'iusto-atque-numquam', 'Good', TRUE, NULL, 'Shoes', 98.8738825539471, 9.50978370826216, 0.13911046094219687, 5, 6, TIMESTAMP '2019-09-08 22:43:15.040615', 25);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (29, FALSE, 0, 0, FALSE, 29, 29, TIMESTAMP '2019-04-14 06:29:46.570371', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.918597+00:00', 29, 0, 0, FALSE, 'vero', 'R$109,22', TIMESTAMP '2019-10-05 04:35:16.151873', 'R$69,76', TRUE, 0.510305277309523, 0, 'Refined Cotton Bacon', TRUE, 52, 29, '2rucmckw17tnuzl4', 'illum-quaerat-et', 'Good', TRUE, NULL, 'Games', 87.8897731601679, 8.91490924121575, 0.69694294347285435, 2, 9, TIMESTAMP '2019-09-09 04:09:10.152013', 29);

INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (9, 0, NULL, 'Moraes, Carvalho and Nogueira', 'Pete_Reis1', 'Pete88@live.com', FALSE, TIMESTAMPTZ '2019-08-19 01:10:10.781952-03:00', 'https://loremflickr.com/320/240?lock=1437624520', 'A similique quia neque dolorum accusantium ea dolore impedit.', '(45) 43630-3534', '0', 'Baby & Home', 'fabrício.net');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (1, 0, NULL, 'Moreira, Carvalho and Martins', 'Tommie.Nogueira83', 'Tommie97@yahoo.com', FALSE, TIMESTAMPTZ '2019-09-07 23:30:40.955985-03:00', 'https://loremflickr.com/320/240?lock=2123917279', 'Consequatur sed ducimus cum dolores laudantium cumque.
                Sunt commodi qui sit autem et debitis dolores.', '+55 (85) 8173-5459', '0', 'Computers, Jewelery & Tools', 'júlio.biz');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (2, 0, NULL, 'Macedo - Oliveira', 'Marjorie8', 'Marjorie39@gmail.com', FALSE, TIMESTAMPTZ '2019-09-07 05:03:43.765569-03:00', 'https://loremflickr.com/320/240?lock=342631471', 'Consectetur architecto eum sit molestiae at distinctio ut consequatur. Vero sit quos autem repellendus qui voluptatibus. Et excepturi adipisci fuga. Consequatur voluptatem perferendis.', '+55 (93) 6512-8363', '0', 'Toys, Electronics & Sports', 'breno.net');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (3, 0, NULL, 'Nogueira e Associados', 'Sylvester.Albuquerque', 'Sylvester_Albuquerque56@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-26 00:11:35.172878-03:00', 'https://loremflickr.com/320/240?lock=352140114', 'eum', '(67) 39799-6845', '0', 'Tools, Electronics & Beauty', 'yuri.net');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (4, 0, NULL, 'Albuquerque - Moraes', 'Brendan39', 'Brendan.Melo@hotmail.com', FALSE, TIMESTAMPTZ '2019-08-25 14:57:47.83788-03:00', 'https://loremflickr.com/320/240?lock=476183543', 'Delectus earum eum et qui qui explicabo.', '(89) 99747-1717', '0', 'Games', 'lorena.info');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (5, 0, NULL, 'Martins, Moreira and Silva', 'Otis_Moraes36', 'Otis98@gmail.com', FALSE, TIMESTAMPTZ '2019-08-29 01:13:15.434143-03:00', 'https://loremflickr.com/320/240?lock=139736825', 'Ab dicta corporis qui et est ducimus.', '+55 (78) 8546-2918', '0', 'Clothing & Electronics', 'júlio césar.br');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (6, 0, NULL, 'Santos - Franco', 'Adrienne.Reis', 'Adrienne_Reis@hotmail.com', FALSE, TIMESTAMPTZ '2019-09-05 10:48:03.871307-03:00', 'https://loremflickr.com/320/240?lock=2023165179', 'Sit voluptatum vero aut laborum quo. Consequatur odit quidem est aspernatur et expedita. Sapiente aspernatur saepe facilis rerum explicabo eveniet suscipit officiis error. Inventore sit corporis voluptatem. Tempora aut adipisci ut perspiciatis est laborum sit quis.', '+55 (49) 3492-4307', '0', 'Shoes', 'marli.name');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (7, 0, NULL, 'Santos - Albuquerque', 'Holly.Nogueira', 'Holly.Nogueira21@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-30 21:43:59.214622-03:00', 'https://loremflickr.com/320/240?lock=594888452', 'deserunt', '(03) 4665-3852', '0', 'Automotive', 'janaína.br');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (8, 0, NULL, 'Reis S.A.', 'Connie18', 'Connie.Costa@gmail.com', FALSE, TIMESTAMPTZ '2019-08-27 22:42:40.547673-03:00', 'https://loremflickr.com/320/240?lock=1834192405', 'Minus eius ipsum nisi consequatur voluptatum voluptas. Beatae incidunt quas voluptas earum ducimus provident ut in ut. Corporis eos culpa. Rerum est a earum deleniti.', '+55 (13) 3764-5286', '0', 'Industrial', 'isabela.info');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (10, 0, NULL, 'Franco, Melo and Silva', 'Garry_Carvalho73', 'Garry_Carvalho74@yahoo.com', FALSE, TIMESTAMPTZ '2019-08-20 06:44:30.113032-03:00', 'https://loremflickr.com/320/240?lock=2066227561', 'Delectus aliquam ea cum assumenda odio aspernatur.
                Qui sint cupiditate reprehenderit.
                Nisi impedit nobis voluptate autem magni.
                Rerum necessitatibus eum illum dolorem molestiae sapiente.
                Ut magnam eius sit et.', '(08) 9533-3947', '0', 'Beauty', 'paulo.info');

INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (11, NULL, 'http://lorempixel.com/640/480/fashion', -1264734430, FALSE, TIMESTAMPTZ '2019-08-26 03:35:23.737616-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (33, NULL, 'http://lorempixel.com/640/480/fashion', -1473902813, FALSE, TIMESTAMPTZ '2019-08-29 15:29:46.329254-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (34, NULL, 'http://lorempixel.com/640/480/fashion', 540893930, FALSE, TIMESTAMPTZ '2019-09-01 09:01:57.808142-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (36, NULL, 'http://lorempixel.com/640/480/fashion', 1424906684, FALSE, TIMESTAMPTZ '2019-09-03 20:05:02.151864-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (37, NULL, 'http://lorempixel.com/640/480/fashion', 945018751, FALSE, TIMESTAMPTZ '2019-09-01 15:33:22.437736-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (38, NULL, 'http://lorempixel.com/640/480/fashion', -1684380823, FALSE, TIMESTAMPTZ '2019-08-30 12:58:06.608965-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (39, NULL, 'http://lorempixel.com/640/480/fashion', -402365753, FALSE, TIMESTAMPTZ '2019-09-02 21:30:19.007849-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (40, NULL, 'http://lorempixel.com/640/480/fashion', -1444882552, FALSE, TIMESTAMPTZ '2019-09-06 05:06:49.244936-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (41, NULL, 'http://lorempixel.com/640/480/fashion', -1557697484, FALSE, TIMESTAMPTZ '2019-08-31 21:48:52.01908-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (42, NULL, 'http://lorempixel.com/640/480/fashion', -1924705078, FALSE, TIMESTAMPTZ '2019-08-30 13:26:48.370955-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (43, NULL, 'http://lorempixel.com/640/480/fashion', -921539045, FALSE, TIMESTAMPTZ '2019-08-30 03:21:17.238694-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (44, NULL, 'http://lorempixel.com/640/480/fashion', -1102749153, FALSE, TIMESTAMPTZ '2019-09-07 10:17:16.180217-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (45, NULL, 'http://lorempixel.com/640/480/fashion', 141938577, FALSE, TIMESTAMPTZ '2019-09-05 09:41:06.837007-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (46, NULL, 'http://lorempixel.com/640/480/fashion', -2072191706, FALSE, TIMESTAMPTZ '2019-08-26 09:53:19.909036-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (47, NULL, 'http://lorempixel.com/640/480/fashion', -1392325140, FALSE, TIMESTAMPTZ '2019-08-28 05:35:09.689451-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (48, NULL, 'http://lorempixel.com/640/480/fashion', -107725463, FALSE, TIMESTAMPTZ '2019-08-26 15:10:27.511418-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (49, NULL, 'http://lorempixel.com/640/480/fashion', -693742117, FALSE, TIMESTAMPTZ '2019-09-08 12:28:38.715355-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (50, NULL, 'http://lorempixel.com/640/480/fashion', 1792125534, FALSE, TIMESTAMPTZ '2019-09-05 18:46:47.825495-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (32, NULL, 'http://lorempixel.com/640/480/fashion', 768884583, FALSE, TIMESTAMPTZ '2019-08-27 07:06:37.268762-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (31, NULL, 'http://lorempixel.com/640/480/fashion', -606887426, FALSE, TIMESTAMPTZ '2019-09-01 20:34:07.002648-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (35, NULL, 'http://lorempixel.com/640/480/fashion', 225239800, FALSE, TIMESTAMPTZ '2019-09-04 03:27:16.460571-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (29, NULL, 'http://lorempixel.com/640/480/fashion', -1721625985, FALSE, TIMESTAMPTZ '2019-09-03 03:13:44.289254-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (12, NULL, 'http://lorempixel.com/640/480/fashion', -1942048856, FALSE, TIMESTAMPTZ '2019-08-27 18:47:28.780625-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (13, NULL, 'http://lorempixel.com/640/480/fashion', -594671186, FALSE, TIMESTAMPTZ '2019-09-08 05:33:24.017187-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (14, NULL, 'http://lorempixel.com/640/480/fashion', -1445606272, FALSE, TIMESTAMPTZ '2019-09-04 00:55:43.575987-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (15, NULL, 'http://lorempixel.com/640/480/fashion', -2030646440, FALSE, TIMESTAMPTZ '2019-09-03 10:52:43.519276-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (30, NULL, 'http://lorempixel.com/640/480/fashion', -275607601, FALSE, TIMESTAMPTZ '2019-08-28 03:00:42.553003-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (17, NULL, 'http://lorempixel.com/640/480/fashion', 1225582823, FALSE, TIMESTAMPTZ '2019-08-31 13:26:18.846209-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (18, NULL, 'http://lorempixel.com/640/480/fashion', 1072923031, FALSE, TIMESTAMPTZ '2019-08-27 22:42:43.546908-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (19, NULL, 'http://lorempixel.com/640/480/fashion', 92350989, FALSE, TIMESTAMPTZ '2019-08-31 17:44:46.553948-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (20, NULL, 'http://lorempixel.com/640/480/fashion', -605189417, FALSE, TIMESTAMPTZ '2019-08-30 05:51:28.94157-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (16, NULL, 'http://lorempixel.com/640/480/fashion', 122236656, FALSE, TIMESTAMPTZ '2019-08-28 02:37:36.230953-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (22, NULL, 'http://lorempixel.com/640/480/fashion', 1451929477, FALSE, TIMESTAMPTZ '2019-09-06 23:30:29.540794-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (23, NULL, 'http://lorempixel.com/640/480/fashion', 1131857972, FALSE, TIMESTAMPTZ '2019-08-29 13:52:05.678242-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (24, NULL, 'http://lorempixel.com/640/480/fashion', -2060878840, FALSE, TIMESTAMPTZ '2019-08-26 20:22:57.333351-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (25, NULL, 'http://lorempixel.com/640/480/fashion', -528168889, FALSE, TIMESTAMPTZ '2019-09-03 02:34:18.488512-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (26, NULL, 'http://lorempixel.com/640/480/fashion', -282695610, FALSE, TIMESTAMPTZ '2019-08-28 17:17:17.453161-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (27, NULL, 'http://lorempixel.com/640/480/fashion', 678894843, FALSE, TIMESTAMPTZ '2019-09-01 20:48:47.041071-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (28, NULL, 'http://lorempixel.com/640/480/fashion', 2063657694, FALSE, TIMESTAMPTZ '2019-08-26 01:36:29.982451-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (21, NULL, 'http://lorempixel.com/640/480/fashion', 1513091595, FALSE, TIMESTAMPTZ '2019-08-30 15:32:19.811821-03:00', 1, NULL);

INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (8, FALSE, 0, 0, FALSE, 8, 8, TIMESTAMP '2018-12-13 05:29:20.226708', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917778+00:00', 8, 0, 0, FALSE, 'Sunt eum culpa aut.
                Possimus id aut qui ut repellendus et porro.
                Et et ut debitis consectetur.
                Veniam veritatis omnis laudantium aliquam.
                Qui et quia eos vel voluptatem minima ipsam magni rerum.
                Eum dolores dolores temporibus cumque vel expedita consequuntur provident.', 'R$190,52', TIMESTAMP '2020-04-12 06:21:14.457537', 'R$1,38', TRUE, 0.215005341551735, 0, 'Fantastic Metal Fish', TRUE, 72, 8, 'fpxkbn6gp9e979ei', 'harum-alias-voluptates', 'Good', TRUE, NULL, 'Grocery', 28.2546035611325, 2.95491014744849, 0.60256014745801689, 7, 9, TIMESTAMP '2019-09-08 20:20:10.461314', 8);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (7, FALSE, 0, 0, FALSE, 7, 7, TIMESTAMP '2019-03-30 02:18:04.735926', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917732+00:00', 7, 0, 0, FALSE, 'Ut perferendis nobis ut cupiditate et nisi et.
                Molestias accusantium hic animi itaque enim ratione tenetur in.
                Adipisci ipsam qui vel soluta iusto.
                Amet quae suscipit.', 'R$161,72', TIMESTAMP '2020-06-13 19:01:17.356239', 'R$26,29', TRUE, 0.0707104341456249, 0, 'Small Steel Pizza', TRUE, 78, 7, 'l0qlnowe0pgp7msb', 'repellendus-et-ea', 'Good', TRUE, NULL, 'Kids', 97.4202213796881, 4.05560880622622, 0.41329447059579866, 3, 8, TIMESTAMP '2019-09-09 06:27:23.053206', 7);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (6, FALSE, 0, 0, FALSE, 6, 6, TIMESTAMP '2019-08-31 06:38:24.117552', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917705+00:00', 6, 0, 0, FALSE, 'Sequi optio nulla consequatur sapiente voluptatibus.', 'R$135,02', TIMESTAMP '2020-02-19 20:48:02.766514', 'R$59,48', TRUE, 0.792115869835073, 0, 'Generic Plastic Gloves', TRUE, 46, 6, 'brr663l45p872gsd', 'a-alias-sit', 'Good', TRUE, NULL, 'Kids', 38.5838592604659, 7.22717728336676, 0.38442640629803126, 5, 3, TIMESTAMP '2019-09-08 19:01:04.366686', 6);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (5, FALSE, 0, 0, FALSE, 5, 5, TIMESTAMP '2019-03-15 04:11:00.638351', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917677+00:00', 5, 0, 0, FALSE, 'nisi', 'R$134,46', TIMESTAMP '2020-06-10 06:06:18.659051', 'R$76,15', TRUE, 0.0968083292696664, 0, 'Small Rubber Towels', TRUE, 74, 5, '34rs0rjpi4tv1gc4', 'architecto-et-asperiores', 'Good', TRUE, NULL, 'Games', 75.8200576881972, 1.58030351697481, 0.77614764858789165, 4, 1, TIMESTAMP '2019-09-09 20:30:00.901645', 5);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (1, FALSE, 0, 0, FALSE, 1, 1, TIMESTAMP '2018-10-04 16:39:33.207938', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.90663+00:00', 1, 0, 0, FALSE, 'est', 'R$7,24', TIMESTAMP '2020-01-02 05:56:29.546596', 'R$4,77', TRUE, 0.0434706700236866, 0, 'Ergonomic Fresh Table', TRUE, 18, 1, 'cbyd2dund75ea07i', 'non-eaque-quidem', 'Good', TRUE, NULL, 'Computers', 23.0859608962601, 4.03199454491585, 0.30094694220505047, 5, 2, TIMESTAMP '2019-09-08 13:52:41.757842', 1);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (3, FALSE, 0, 0, FALSE, 3, 3, TIMESTAMP '2019-03-03 09:53:57.951891', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917572+00:00', 3, 0, 0, FALSE, 'Et quia aliquam.
                Enim libero blanditiis rem nesciunt modi id sed est odit.
                Dignissimos dicta officia inventore ut necessitatibus modi cumque.', 'R$176,56', TIMESTAMP '2019-12-11 07:01:30.073557', 'R$71,02', TRUE, 0.795103080940946, 0, 'Intelligent Wooden Salad', TRUE, 78, 3, 'exkjp46yha6h87as', 'nobis-assumenda-nisi', 'Good', TRUE, NULL, 'Automotive', 10.118744853008, 0.251079080743286, 0.24961629009322089, 5, 6, TIMESTAMP '2019-09-09 09:08:58.703026', 3);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (2, FALSE, 0, 0, FALSE, 2, 2, TIMESTAMP '2019-01-13 03:03:20.801527', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917475+00:00', 2, 0, 0, FALSE, 'quos', 'R$117,68', TIMESTAMP '2019-12-30 23:39:04.811477', 'R$87,32', TRUE, 0.883742507958665, 0, 'Refined Wooden Tuna', TRUE, 84, 2, 'wxy9cwjnlzwu3gm8', 'rerum-dicta-et', 'Good', TRUE, NULL, 'Outdoors', 16.2922104430814, 2.11285292269329, 0.60742099937397098, 3, 1, TIMESTAMP '2019-09-09 03:04:58.009599', 2);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (9, FALSE, 0, 0, FALSE, 9, 9, TIMESTAMP '2019-04-18 03:34:38.806543', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917832+00:00', 9, 0, 0, FALSE, 'Voluptas est dignissimos dolorum quaerat.
                Possimus temporibus aut et modi at nobis quos.
                Animi id doloremque nobis repellat cumque et quasi quis voluptatem.
                Omnis ut est nihil a saepe quaerat.
                Autem earum a mollitia molestiae ea in officia.', 'R$180,84', TIMESTAMP '2020-01-27 11:19:24.184978', 'R$81,26', TRUE, 0.361017505340752, 0, 'Refined Granite Soap', TRUE, 10, 9, '4mpm6hyymme7615d', 'eligendi-occaecati-culpa', 'Good', TRUE, NULL, 'Computers', 72.4169059062455, 3.3906062149399, 0.98345063346598793, 2, 2, TIMESTAMP '2019-09-09 13:14:52.154889', 9);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (4, FALSE, 0, 0, FALSE, 4, 4, TIMESTAMP '2019-02-12 12:00:46.915828', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917623+00:00', 4, 0, 0, FALSE, 'Delectus reiciendis tempora excepturi iusto harum. Minus illo eaque tempora sit laudantium. Facere accusantium impedit animi nesciunt beatae voluptatem ratione. Adipisci inventore explicabo. Velit corporis veritatis accusamus praesentium veniam nemo.', 'R$195,48', TIMESTAMP '2020-05-04 15:30:15.582123', 'R$98,72', TRUE, 0.630945194806412, 0, 'Handmade Frozen Mouse', TRUE, 58, 4, 'o0ycj0bvryyu3xgt', 'iure-odit-expedita', 'Good', TRUE, NULL, 'Jewelery', 54.640758342408, 5.07422258848055, 0.049929586728070671, 5, 1, TIMESTAMP '2019-09-08 20:43:00.4537', 4);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (10, FALSE, 0, 0, FALSE, 10, 10, TIMESTAMP '2019-08-11 09:52:51.730978', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-09-09 01:21:49.917878+00:00', 10, 0, 0, FALSE, 'Beatae nisi ut est asperiores iste architecto similique quia et. Amet dignissimos ut non. Et aperiam quibusdam ea ratione.', 'R$149,33', TIMESTAMP '2020-02-08 02:14:36.933933', 'R$85,93', TRUE, 0.310661727241549, 0, 'Practical Concrete Salad', TRUE, 32, 10, 'pl8m5cqwu2gnbl0p', 'sapiente-rerum-qui', 'Good', TRUE, NULL, 'Music', 11.1523835506068, 6.00295803789187, 0.80688511757500703, 1, 9, TIMESTAMP '2019-09-08 16:28:21.084012', 10);

INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (1, NULL, 'http://lorempixel.com/640/480/fashion', 471510968, FALSE, TIMESTAMPTZ '2019-08-26 01:58:05.219044-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (2, NULL, 'http://lorempixel.com/640/480/fashion', -625983839, FALSE, TIMESTAMPTZ '2019-09-01 19:00:02.499567-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (3, NULL, 'http://lorempixel.com/640/480/fashion', 333507804, FALSE, TIMESTAMPTZ '2019-09-07 20:53:49.641305-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (4, NULL, 'http://lorempixel.com/640/480/fashion', -1873580435, FALSE, TIMESTAMPTZ '2019-09-01 18:29:49.008953-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (5, NULL, 'http://lorempixel.com/640/480/fashion', -727424194, FALSE, TIMESTAMPTZ '2019-08-28 08:20:30.142502-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (6, NULL, 'http://lorempixel.com/640/480/fashion', -2021669936, FALSE, TIMESTAMPTZ '2019-09-04 18:55:05.553502-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (7, NULL, 'http://lorempixel.com/640/480/fashion', -732655365, FALSE, TIMESTAMPTZ '2019-09-02 04:41:51.347155-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (8, NULL, 'http://lorempixel.com/640/480/fashion', -692453031, FALSE, TIMESTAMPTZ '2019-08-30 00:39:26.566216-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (9, NULL, 'http://lorempixel.com/640/480/fashion', 1801307023, FALSE, TIMESTAMPTZ '2019-08-28 15:44:32.363018-03:00', 1, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName")
VALUES (10, NULL, 'http://lorempixel.com/640/480/fashion', 316626617, FALSE, TIMESTAMPTZ '2019-09-03 08:04:09.092038-03:00', 1, NULL);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20190909012150_seed', '2.2.4-servicing-10062');

