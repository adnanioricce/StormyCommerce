CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);


DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    DROP TABLE "AppSettings";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    DROP INDEX "UserNameIndex";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    DROP INDEX "RoleNameIndex";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    ALTER TABLE "StormyProduct" ALTER COLUMN "Width" TYPE double precision;
    ALTER TABLE "StormyProduct" ALTER COLUMN "Width" SET NOT NULL;
    ALTER TABLE "StormyProduct" ALTER COLUMN "Width" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    ALTER TABLE "StormyProduct" ALTER COLUMN "Length" TYPE double precision;
    ALTER TABLE "StormyProduct" ALTER COLUMN "Length" SET NOT NULL;
    ALTER TABLE "StormyProduct" ALTER COLUMN "Length" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    ALTER TABLE "StormyProduct" ALTER COLUMN "Height" TYPE double precision;
    ALTER TABLE "StormyProduct" ALTER COLUMN "Height" SET NOT NULL;
    ALTER TABLE "StormyProduct" ALTER COLUMN "Height" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    ALTER TABLE "StormyProduct" ALTER COLUMN "Diameter" TYPE double precision;
    ALTER TABLE "StormyProduct" ALTER COLUMN "Diameter" DROP NOT NULL;
    ALTER TABLE "StormyProduct" ALTER COLUMN "Diameter" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    ALTER TABLE "Shipment" ALTER COLUMN "TotalWidth" TYPE double precision;
    ALTER TABLE "Shipment" ALTER COLUMN "TotalWidth" SET NOT NULL;
    ALTER TABLE "Shipment" ALTER COLUMN "TotalWidth" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    ALTER TABLE "Shipment" ALTER COLUMN "TotalWeight" TYPE double precision;
    ALTER TABLE "Shipment" ALTER COLUMN "TotalWeight" SET NOT NULL;
    ALTER TABLE "Shipment" ALTER COLUMN "TotalWeight" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    ALTER TABLE "Shipment" ALTER COLUMN "TotalLength" TYPE double precision;
    ALTER TABLE "Shipment" ALTER COLUMN "TotalLength" SET NOT NULL;
    ALTER TABLE "Shipment" ALTER COLUMN "TotalLength" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    ALTER TABLE "Shipment" ALTER COLUMN "TotalHeight" TYPE double precision;
    ALTER TABLE "Shipment" ALTER COLUMN "TotalHeight" SET NOT NULL;
    ALTER TABLE "Shipment" ALTER COLUMN "TotalHeight" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    ALTER TABLE "Shipment" ALTER COLUMN "TotalArea" TYPE double precision;
    ALTER TABLE "Shipment" ALTER COLUMN "TotalArea" SET NOT NULL;
    ALTER TABLE "Shipment" ALTER COLUMN "TotalArea" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    ALTER TABLE "Shipment" ADD "CubeRoot" double precision NOT NULL DEFAULT 0.0;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    CREATE UNIQUE INDEX "UserNameIndex" ON "AspNetUsers" ("NormalizedUserName");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    CREATE UNIQUE INDEX "RoleNameIndex" ON "AspNetRoles" ("NormalizedName");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191106113816_AppSettingsInConfigDatabase') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20191106113816_AppSettingsInConfigDatabase', '2.2.6-servicing-10079');
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "AppSettings" (
        "Id" text NOT NULL,
        "Value" character varying(450) NULL,
        "Module" character varying(450) NULL,
        "IsVisibleInCommonSettingPage" boolean NOT NULL,
        CONSTRAINT "PK_AppSettings" PRIMARY KEY ("Id")
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "AspNetRoles" (
        "Id" text NOT NULL,
        "Name" character varying(256) NULL,
        "NormalizedName" character varying(256) NULL,
        "ConcurrencyStamp" text NULL,
        CONSTRAINT "PK_AspNetRoles" PRIMARY KEY ("Id")
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "EntityType" (
        "Id" character varying(450) NOT NULL,
        "IsMenuable" boolean NOT NULL,
        "AreaName" character varying(450) NULL,
        "RoutingController" character varying(450) NULL,
        "RoutingAction" character varying(450) NULL,
        "IsDeleted" boolean NOT NULL,
        CONSTRAINT "PK_EntityType" PRIMARY KEY ("Id")
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "ProductAttributeGroup" (
        "Id" bigint NOT NULL,
        "LastModified" timestamp with time zone NOT NULL,
        "IsDeleted" boolean NOT NULL,
        "Name" character varying(450) NOT NULL,
        CONSTRAINT "PK_ProductAttributeGroup" PRIMARY KEY ("Id")
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "ProductOption" (
        "Id" bigint NOT NULL,
        "LastModified" timestamp with time zone NOT NULL,
        "IsDeleted" boolean NOT NULL,
        "Name" character varying(450) NOT NULL,
        CONSTRAINT "PK_ProductOption" PRIMARY KEY ("Id")
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "Stock" (
        "Id" bigint NOT NULL,
        "LastModified" timestamp with time zone NOT NULL,
        "IsDeleted" boolean NOT NULL,
        CONSTRAINT "PK_Stock" PRIMARY KEY ("Id")
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "Wishlist" (
        "Id" bigint NOT NULL,
        "LastModified" timestamp with time zone NOT NULL,
        "IsDeleted" boolean NOT NULL,
        "StormyCustomerId" text NULL,
        CONSTRAINT "PK_Wishlist" PRIMARY KEY ("Id")
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "AspNetRoleClaims" (
        "Id" integer NOT NULL,
        "RoleId" text NOT NULL,
        "ClaimType" text NULL,
        "ClaimValue" text NULL,
        CONSTRAINT "PK_AspNetRoleClaims" PRIMARY KEY ("Id"),
        CONSTRAINT "FK_AspNetRoleClaims_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE CASCADE
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "AspNetUserClaims" (
        "Id" integer NOT NULL,
        "UserId" text NOT NULL,
        "ClaimType" text NULL,
        "ClaimValue" text NULL,
        CONSTRAINT "PK_AspNetUserClaims" PRIMARY KEY ("Id"),
        CONSTRAINT "FK_AspNetUserClaims_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "AspNetUserLogins" (
        "LoginProvider" text NOT NULL,
        "ProviderKey" text NOT NULL,
        "ProviderDisplayName" text NULL,
        "UserId" text NOT NULL,
        CONSTRAINT "PK_AspNetUserLogins" PRIMARY KEY ("LoginProvider", "ProviderKey"),
        CONSTRAINT "FK_AspNetUserLogins_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "AspNetUserRoles" (
        "UserId" text NOT NULL,
        "RoleId" text NOT NULL,
        CONSTRAINT "PK_AspNetUserRoles" PRIMARY KEY ("UserId", "RoleId"),
        CONSTRAINT "FK_AspNetUserRoles_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE CASCADE,
        CONSTRAINT "FK_AspNetUserRoles_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "AspNetUserTokens" (
        "UserId" text NOT NULL,
        "LoginProvider" text NOT NULL,
        "Name" text NOT NULL,
        "Value" text NULL,
        CONSTRAINT "PK_AspNetUserTokens" PRIMARY KEY ("UserId", "LoginProvider", "Name"),
        CONSTRAINT "FK_AspNetUserTokens_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "ProductAttribute" (
        "Id" bigint NOT NULL,
        "LastModified" timestamp with time zone NOT NULL,
        "IsDeleted" boolean NOT NULL,
        "GroupId" bigint NOT NULL,
        "Name" text NULL,
        CONSTRAINT "PK_ProductAttribute" PRIMARY KEY ("Id"),
        CONSTRAINT "FK_ProductAttribute_ProductAttributeGroup_GroupId" FOREIGN KEY ("GroupId") REFERENCES "ProductAttributeGroup" ("Id") ON DELETE CASCADE
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "ProductTemplate" (
        "Id" bigint NOT NULL,
        "LastModified" timestamp with time zone NOT NULL,
        "IsDeleted" boolean NOT NULL,
        "Name" text NULL,
        "StormyProductId" bigint NOT NULL,
        CONSTRAINT "PK_ProductTemplate" PRIMARY KEY ("Id"),
        CONSTRAINT "FK_ProductTemplate_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "ProductTemplateProductAttribute" (
        "ProductTemplateId" bigint NOT NULL,
        "ProductAttributeId" bigint NOT NULL,
        CONSTRAINT "PK_ProductTemplateProductAttribute" PRIMARY KEY ("ProductTemplateId", "ProductAttributeId"),
        CONSTRAINT "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAttributeId" FOREIGN KEY ("ProductAttributeId") REFERENCES "ProductAttribute" ("Id") ON DELETE CASCADE,
        CONSTRAINT "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemplateId" FOREIGN KEY ("ProductTemplateId") REFERENCES "ProductTemplate" ("Id") ON DELETE RESTRICT
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE TABLE "ApplicationRole" (
        "Id" text NOT NULL,
        "Name" text NULL,
        "NormalizedName" text NULL,
        "ConcurrencyStamp" text NULL,
        "StormyCustomerId" text NULL,
        CONSTRAINT "PK_ApplicationRole" PRIMARY KEY ("Id"),
        CONSTRAINT "FK_ApplicationRole_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ApplicationRole_StormyCustomerId" ON "ApplicationRole" ("StormyCustomerId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_AspNetRoleClaims_RoleId" ON "AspNetRoleClaims" ("RoleId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE UNIQUE INDEX "RoleNameIndex" ON "AspNetRoles" ("NormalizedName") WHERE [NormalizedName] IS NOT NULL;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_AspNetUserClaims_UserId" ON "AspNetUserClaims" ("UserId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_AspNetUserLogins_UserId" ON "AspNetUserLogins" ("UserId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_AspNetUserRoles_RoleId" ON "AspNetUserRoles" ("RoleId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "EmailIndex" ON "AspNetUsers" ("NormalizedEmail");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE UNIQUE INDEX "UserNameIndex" ON "AspNetUsers" ("NormalizedUserName") WHERE [NormalizedUserName] IS NOT NULL;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_CustomerAddress_OwnerId" ON "CustomerAddress" ("OwnerId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_Entity_EntityTypeId" ON "Entity" ("EntityTypeId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_OrderItem_ShipmentId" ON "OrderItem" ("ShipmentId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_OrderItem_StormyOrderId" ON "OrderItem" ("StormyOrderId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_OrderItem_StormyProductId" ON "OrderItem" ("StormyProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE UNIQUE INDEX "IX_Payment_StormyOrderId" ON "Payment" ("StormyOrderId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductAttribute_GroupId" ON "ProductAttribute" ("GroupId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductAttributeValue_AttributeId" ON "ProductAttributeValue" ("AttributeId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductAttributeValue_ProductId" ON "ProductAttributeValue" ("ProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductCategory_CategoryId" ON "ProductCategory" ("CategoryId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductCategory_ProductId" ON "ProductCategory" ("ProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductLink_LinkedProductId" ON "ProductLink" ("LinkedProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductLink_ProductId" ON "ProductLink" ("ProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductMedia_MediaId" ON "ProductMedia" ("MediaId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductMedia_StormyProductId" ON "ProductMedia" ("StormyProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductOptionValue_OptionId" ON "ProductOptionValue" ("OptionId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductOptionValue_ProductId" ON "ProductOptionValue" ("ProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductTemplate_StormyProductId" ON "ProductTemplate" ("StormyProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_ProductTemplateProductAttribute_ProductAttributeId" ON "ProductTemplateProductAttribute" ("ProductAttributeId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_Review_StormyCustomerId" ON "Review" ("StormyCustomerId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_Review_StormyProductId" ON "Review" ("StormyProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE UNIQUE INDEX "IX_Shipment_BillingAddressId" ON "Shipment" ("BillingAddressId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE UNIQUE INDEX "IX_Shipment_DestinationAddressId" ON "Shipment" ("DestinationAddressId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE UNIQUE INDEX "IX_Shipment_StormyOrderId" ON "Shipment" ("StormyOrderId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE UNIQUE INDEX "IX_StormyCustomer_CustomerWishlistId" ON "StormyCustomer" ("CustomerWishlistId") WHERE [CustomerWishlistId] IS NOT NULL;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_StormyCustomer_DefaultBillingAddressId" ON "StormyCustomer" ("DefaultBillingAddressId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_StormyCustomer_DefaultShippingAddressId" ON "StormyCustomer" ("DefaultShippingAddressId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_StormyOrder_CustomerId" ON "StormyOrder" ("CustomerId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_StormyOrder_StockId" ON "StormyOrder" ("StockId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_StormyProduct_BrandId" ON "StormyProduct" ("BrandId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_StormyProduct_StockId" ON "StormyProduct" ("StockId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_StormyProduct_VendorId" ON "StormyProduct" ("VendorId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE UNIQUE INDEX "IX_StormyVendor_VendorAddressId" ON "StormyVendor" ("VendorAddressId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_WishlistItem_ProductId" ON "WishlistItem" ("ProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_WishlistItem_WishlistId" ON "WishlistItem" ("WishlistId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    CREATE INDEX "IX_WishlistItem_WishlistId1" ON "WishlistItem" ("WishlistId1");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    ALTER TABLE "Shipment" ADD CONSTRAINT "FK_Shipment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE RESTRICT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    ALTER TABLE "Shipment" ADD CONSTRAINT "FK_Shipment_CustomerAddress_BillingAddressId" FOREIGN KEY ("BillingAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    ALTER TABLE "Shipment" ADD CONSTRAINT "FK_Shipment_CustomerAddress_DestinationAddressId" FOREIGN KEY ("DestinationAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    ALTER TABLE "StormyCustomer" ADD CONSTRAINT "FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId" FOREIGN KEY ("DefaultBillingAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    ALTER TABLE "StormyCustomer" ADD CONSTRAINT "FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId" FOREIGN KEY ("DefaultShippingAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191110230438_Initial') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20191110230438_Initial', '2.2.6-servicing-10079');
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191115184426_UpdateModel') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20191115184426_UpdateModel', '2.2.6-servicing-10079');
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191115212046_dateofbirth') THEN
    ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" TYPE timestamp with time zone;
    ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" DROP NOT NULL;
    ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191115212046_dateofbirth') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20191115212046_dateofbirth', '2.2.6-servicing-10079');
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191116134002_ChangeWishListModel') THEN
    ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" TYPE timestamp with time zone;
    ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" DROP NOT NULL;
    ALTER TABLE "StormyCustomer" ALTER COLUMN "DateOfBirth" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191116134002_ChangeWishListModel') THEN
    ALTER TABLE "StormyCustomer" ADD "CustomerWishlistId1" bigint NULL;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191116134002_ChangeWishListModel') THEN
    CREATE INDEX "IX_StormyCustomer_CustomerWishlistId1" ON "StormyCustomer" ("CustomerWishlistId1");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191116134002_ChangeWishListModel') THEN
    ALTER TABLE "StormyCustomer" ADD CONSTRAINT "FK_StormyCustomer_Wishlist_CustomerWishlistId1" FOREIGN KEY ("CustomerWishlistId1") REFERENCES "Wishlist" ("Id") ON DELETE RESTRICT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191116134002_ChangeWishListModel') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20191116134002_ChangeWishListModel', '2.2.6-servicing-10079');
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191116195940_RoleModel') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191116195940_RoleModel') THEN
    CREATE INDEX "IX_ProductOptionCombination_OptionId" ON "ProductOptionCombination" ("OptionId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191116195940_RoleModel') THEN
    CREATE INDEX "IX_ProductOptionCombination_ProductId" ON "ProductOptionCombination" ("ProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191116195940_RoleModel') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20191116195940_RoleModel', '2.2.6-servicing-10079');
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    DROP TABLE "ApplicationRole";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    DROP INDEX "IX_StormyCustomer_CustomerWishlistId";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    DROP INDEX "UserNameIndex";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    DROP INDEX "RoleNameIndex";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    ALTER TABLE "StormyCustomer" ADD "RoleId" text NULL;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    ALTER TABLE "AspNetRoles" ADD "Discriminator" text NOT NULL DEFAULT '';
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    CREATE UNIQUE INDEX "IX_StormyCustomer_CustomerWishlistId" ON "StormyCustomer" ("CustomerWishlistId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    CREATE INDEX "IX_StormyCustomer_RoleId" ON "StormyCustomer" ("RoleId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    CREATE UNIQUE INDEX "UserNameIndex" ON "AspNetUsers" ("NormalizedUserName");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    CREATE UNIQUE INDEX "RoleNameIndex" ON "AspNetRoles" ("NormalizedName");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    CREATE INDEX "IX_Comment_ProductId" ON "Comment" ("ProductId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    CREATE INDEX "IX_Comment_StormyCustomerId" ON "Comment" ("StormyCustomerId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    ALTER TABLE "StormyCustomer" ADD CONSTRAINT "FK_StormyCustomer_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE RESTRICT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191124233029_UpdateThatIDontKnowWhatIDo') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20191124233029_UpdateThatIDontKnowWhatIDo', '2.2.6-servicing-10079');
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" DROP CONSTRAINT "FK_CustomerAddress_StormyCustomer_OwnerId";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "OrderItem" DROP CONSTRAINT "FK_OrderItem_Shipment_ShipmentId";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    DROP TABLE "Payment";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    DROP TABLE "Shipment";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    DROP INDEX "IX_CustomerAddress_OwnerId";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "StormyOrder" DROP COLUMN "Tax";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" DROP COLUMN "OwnerId";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_Street" TO "Street";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_State" TO "State";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_SecondAddress" TO "SecondAddress";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_PostalCode" TO "PostalCode";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_Number" TO "Number";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_FirstAddress" TO "FirstAddress";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_District" TO "District";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_Country" TO "Country";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_Complement" TO "Complement";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" RENAME COLUMN "Address_City" TO "City";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" RENAME COLUMN "UserId" TO "StormyCustomerId";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "VendorAddress" ALTER COLUMN "Id" TYPE bigint;
    ALTER TABLE "VendorAddress" ALTER COLUMN "Id" SET NOT NULL;
    ALTER TABLE "VendorAddress" ALTER COLUMN "Id" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "OrderItem" ALTER COLUMN "ShipmentId" TYPE bigint;
    ALTER TABLE "OrderItem" ALTER COLUMN "ShipmentId" DROP NOT NULL;
    ALTER TABLE "OrderItem" ALTER COLUMN "ShipmentId" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "OrderItem" ALTER COLUMN "Price" TYPE numeric;
    ALTER TABLE "OrderItem" ALTER COLUMN "Price" SET NOT NULL;
    ALTER TABLE "OrderItem" ALTER COLUMN "Price" DROP DEFAULT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
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
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    CREATE INDEX "IX_CustomerAddress_StormyCustomerId" ON "CustomerAddress" ("StormyCustomerId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    CREATE UNIQUE INDEX "IX_StormyPayment_StormyOrderId" ON "StormyPayment" ("StormyOrderId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    CREATE UNIQUE INDEX "IX_StormyShipment_DestinationAddressId" ON "StormyShipment" ("DestinationAddressId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    CREATE UNIQUE INDEX "IX_StormyShipment_StormyOrderId" ON "StormyShipment" ("StormyOrderId");
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "CustomerAddress" ADD CONSTRAINT "FK_CustomerAddress_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    ALTER TABLE "OrderItem" ADD CONSTRAINT "FK_OrderItem_StormyShipment_ShipmentId" FOREIGN KEY ("ShipmentId") REFERENCES "StormyShipment" ("Id") ON DELETE RESTRICT;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20191201132419_UpdatingPaymentAndOrderModel') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20191201132419_UpdatingPaymentAndOrderModel', '2.2.6-servicing-10079');
    END IF;
END $$;
