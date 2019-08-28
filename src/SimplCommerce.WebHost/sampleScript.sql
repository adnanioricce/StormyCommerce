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
    "FirstAddress" text NULL,
    "SecondAddress" text NULL,
    "City" text NULL,
    "State" text NULL,
    "PostalCode" text NULL,
    "Number" text NULL,
    "Complement" text NULL,
    "PhoneNumber" text NULL,
    "Country" text NULL,
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

CREATE TABLE "StormyCustomer" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "UserId" text NULL,
    "CPF" character varying(11) NULL,
    "DefaultShippingAddressId" bigint NULL,
    "DefaultBillingAddressId" bigint NULL,
    "UserName" text NULL,
    "FullName" character varying(450) NULL,
    "Email" text NULL,
    "CreatedOn" timestamp with time zone NOT NULL,
    CONSTRAINT "PK_StormyCustomer" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyCustomer_Address_DefaultBillingAddressId" FOREIGN KEY ("DefaultBillingAddressId") REFERENCES "Address" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyCustomer_Address_DefaultShippingAddressId" FOREIGN KEY ("DefaultShippingAddressId") REFERENCES "Address" ("Id") ON DELETE RESTRICT
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

CREATE TABLE "StormyOrder" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "OrderUniqueKey" uuid NOT NULL,
    "CustomerId" bigint NOT NULL,
    "PaymentId" bigint NOT NULL,
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
    CONSTRAINT "FK_StormyOrder_Address_ShippingAddressId" FOREIGN KEY ("ShippingAddressId") REFERENCES "Address" ("Id") ON DELETE RESTRICT
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

CREATE TABLE "Shipment" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "TrackNumber" text NULL,
    "TotalWeight" numeric NOT NULL,
    "CreatedOn" timestamp without time zone NOT NULL,
    "ShippedDate" timestamp without time zone NULL,
    "DeliveryDate" timestamp without time zone NULL,
    "Comment" text NULL,
    "Price" numeric NOT NULL,
    "DeliveryCost" numeric NOT NULL,
    "StormyOrderId" bigint NULL,
    CONSTRAINT "PK_Shipment" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Shipment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE RESTRICT
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

CREATE TABLE "Media" (
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Caption" text NULL,
    "FileSize" integer NOT NULL,
    "FileName" text NULL,
    "MediaType" integer NOT NULL,
    "SeoFileName" text NULL,
    "StormyProductId" bigint NULL,
    CONSTRAINT "PK_Media" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Media_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT
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
    CONSTRAINT "PK_OrderItem" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_OrderItem_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_OrderItem_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
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
    "Id" bigserial NOT NULL,
    "LastModified" timestamp with time zone NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "ProductId" bigint NOT NULL,
    "LinkedProductId" bigint NOT NULL,
    "LinkType" integer NOT NULL,
    CONSTRAINT "PK_ProductLink" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductLink_StormyProduct_LinkedProductId" FOREIGN KEY ("LinkedProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_ProductLink_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT
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

INSERT INTO "Address" ("Id", "City", "Complement", "Country", "FirstAddress", "IsDeleted", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street")
VALUES (5, 'Município de Yangodo Norte', NULL, NULL, 'Saraiva Rua', FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.330939+00:00', '447', '+55 (71) 3644-0193', '12085-706', 'Apto. 741', 'Minas Gerais', '58999 Meire Alameda');
INSERT INTO "Address" ("Id", "City", "Complement", "Country", "FirstAddress", "IsDeleted", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street")
VALUES (4, 'Município de Morganade Nossa Senhora', NULL, NULL, 'Costa Marginal', FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.330899+00:00', '1146', '+55 (54) 2596-3118', '91640', 'Lote 25', 'Mato Grosso', '65200 Saraiva Rodovia');
INSERT INTO "Address" ("Id", "City", "Complement", "Country", "FirstAddress", "IsDeleted", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street")
VALUES (3, 'Batistado Descoberto', NULL, NULL, 'Kléber Rodovia', FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.330853+00:00', '8320', '+55 (17) 9738-4336', '83275-491', 'Quadra 10', 'Rio de Janeiro', '53520 Carvalho Viela');
INSERT INTO "Address" ("Id", "City", "Complement", "Country", "FirstAddress", "IsDeleted", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street")
VALUES (2, 'Moreirado Descoberto', NULL, NULL, 'Melo Rodovia', FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.330785+00:00', '568', '+55 (36) 5356-5529', '20015-649', 'Sobrado 74', 'Pernambuco', '729 Santos Marginal');
INSERT INTO "Address" ("Id", "City", "Complement", "Country", "FirstAddress", "IsDeleted", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street")
VALUES (1, 'Município de Warley', NULL, NULL, 'Isabela Travessa', FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.32876+00:00', '368', '(28) 50091-5505', '16769', 'Quadra 08', 'Paraíba', '057 Júlia Alameda');

INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (10, 'Dolorem omnis laborum aut cupiditate explicabo voluptatum quia veniam voluptatem.
                Et eaque qui sint dolores fuga doloribus voluptatum omnis adipisci.
                Et provident numquam cumque possimus veniam culpa dicta provident vitae.
                Et odit ea.
                Aut eum inventore ut sed.', FALSE, TIMESTAMPTZ '2019-08-21 05:56:24.093281-03:00', 'https://picsum.photos/640/480/?image=1002', 'Pereira, Nogueira and Macedo', 'cum-ea-animi', 'gustavo.info');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (9, 'Expedita est autem quasi.', FALSE, TIMESTAMPTZ '2019-08-20 02:13:43.911888-03:00', 'https://picsum.photos/640/480/?image=460', 'Souza - Souza', 'minus-odio-similique', 'eduarda.com');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (8, 'Iusto illum eos architecto est aliquid.
                Sed ut hic est temporibus explicabo quas fugiat fugit.
                Modi impedit esse aperiam nemo aut quisquam.', FALSE, TIMESTAMPTZ '2019-08-19 01:43:21.933171-03:00', 'https://picsum.photos/640/480/?image=426', 'Moraes - Carvalho', 'et-porro-quibusdam', 'sara.com');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (7, 'Sit qui voluptas distinctio perspiciatis libero.
                Aliquam quos et.
                Eligendi consequatur est vel quasi.
                Reiciendis ut quaerat sed voluptatem rem asperiores.', FALSE, TIMESTAMPTZ '2019-08-09 11:51:54.323866-03:00', 'https://picsum.photos/640/480/?image=662', 'Barros, Nogueira and Costa', 'consequatur-harum-et', 'salvador.name');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (6, 'Eum voluptate exercitationem tenetur.', FALSE, TIMESTAMPTZ '2019-07-31 19:37:27.996324-03:00', 'https://picsum.photos/640/480/?image=577', 'Barros - Pereira', 'perferendis-sapiente-sed', 'talita.name');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (1, 'Dolorum sed sapiente rerum quisquam velit asperiores hic. Porro ad eaque ut. Dolores error provident ipsam nemo. Inventore quibusdam quibusdam est nam voluptates a enim. Ut dolor a fugiat eos. Dolores reprehenderit corporis sit asperiores vero consequatur.', FALSE, TIMESTAMPTZ '2019-08-04 02:59:33.135094-03:00', 'https://picsum.photos/640/480/?image=75', 'Saraiva - Pereira', 'eveniet-est-ipsa', 'isabel.info');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (2, 'Ratione molestiae quas tempora rerum quia id assumenda. Id culpa aut enim explicabo quia praesentium natus et. Quos velit repellat magnam et repellendus ea doloribus explicabo ut. Sequi sunt eos ab non deserunt. Cupiditate dolore in.', FALSE, TIMESTAMPTZ '2019-08-10 16:57:19.630489-03:00', 'https://picsum.photos/640/480/?image=73', 'Nogueira - Pereira', 'rerum-iusto-minus', 'frederico.net');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (3, 'Cupiditate et eaque excepturi molestiae eum.
                Et laborum aliquid eaque laborum dicta vel aut facilis eum.
                Consequuntur tenetur quidem voluptatibus.
                Aut cumque optio tenetur.', FALSE, TIMESTAMPTZ '2019-07-31 13:35:32.33122-03:00', 'https://picsum.photos/640/480/?image=824', 'Silva - Moreira', 'aliquam-neque-totam', 'ofélia.info');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (4, 'Ea in et omnis quia doloribus aliquid.', FALSE, TIMESTAMPTZ '2019-08-21 23:33:57.436282-03:00', 'https://picsum.photos/640/480/?image=323', 'Carvalho Comércio', 'ad-ut-odit', 'alessandro.biz');
INSERT INTO "Brand" ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (5, 'Magni corporis et. Id magnam consequatur. Voluptatem unde officiis ipsa est eius debitis iure. Eum est ad eaque quam est corrupti eos aliquid architecto.', FALSE, TIMESTAMPTZ '2019-08-18 05:00:45.801513-03:00', 'https://picsum.photos/640/480/?image=247', 'Nogueira LTDA', 'facere-autem-quidem', 'carla.br');

INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (1, 'Qui quasi laboriosam cumque.', 0, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-22 12:20:11.886626-03:00', 'Esse nostrum ipsa dicta accusamus vitae beatae.', NULL, NULL, 'Toys', NULL, 'officia-accusamus-est', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (9, 'Unde et impedit animi saepe. Molestias enim animi distinctio magnam. Ipsa aperiam aut dolorem ad inventore excepturi qui.', 8, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-04 15:17:03.966444-03:00', 'rerum', NULL, NULL, 'Books', NULL, 'vel-laborum-laboriosam', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (8, 'Nesciunt iure quos est molestiae eum. Totam vitae laudantium vel blanditiis et harum omnis in. Molestiae nesciunt voluptas modi. Ut blanditiis tempore possimus omnis vel tenetur.', 7, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-06 18:06:23.112199-03:00', 'Molestiae architecto nemo exercitationem excepturi.', NULL, NULL, 'Beauty', NULL, 'impedit-molestiae-sed', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (7, 'Ut dolorem deleniti quis ut.
                Eius sit ipsam saepe autem molestias non ad necessitatibus.', 6, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-14 18:35:22.821887-03:00', 'Nemo in enim laborum consequuntur adipisci sequi. Quos a cumque vitae ducimus animi. Rem sint laudantium molestias rerum sed illum non iure. Aliquam qui architecto repellat soluta quas omnis qui eveniet. Sunt ipsa ex optio. Dolores assumenda ea quaerat harum.', NULL, NULL, 'Clothing', NULL, 'incidunt-dignissimos-est', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (6, 'Aspernatur omnis voluptatem et corporis similique temporibus est. Atque dignissimos eaque possimus dolor ut qui vero. Est doloremque impedit ad exercitationem minus tempore ducimus aliquid blanditiis. At aut itaque dolorem atque.', 5, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-12 19:39:13.748166-03:00', 'Non aliquid tempore ratione porro aspernatur voluptatem aut culpa non.', NULL, NULL, 'Computers', NULL, 'tenetur-reprehenderit-possimus', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (5, 'Hic quaerat aut quo molestias placeat eveniet officia voluptatem.', 4, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-20 16:11:01.353541-03:00', 'quo', NULL, NULL, 'Computers', NULL, 'similique-qui-voluptatibus', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (4, 'Dolore sint error quod cum. Tenetur odio sed. Ipsum rerum possimus sint nesciunt et.', 3, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-01 07:44:02.664702-03:00', 'ipsam', NULL, NULL, 'Electronics', NULL, 'sed-mollitia-vel', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (3, 'Voluptas libero minima dolores et dolores totam distinctio.', 2, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-19 14:47:26.85447-03:00', 'Ipsam molestiae magni enim nam omnis.', NULL, NULL, 'Industrial', NULL, 'dolorem-laudantium-corrupti', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (2, 'Et dolores repellendus.
                Debitis quo ea rerum et qui fugiat a.
                Ullam quia numquam illum labore aliquam perspiciatis fuga earum consequatur.
                Eum eum quia.
                Ipsum voluptate sed reprehenderit.', 1, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-16 17:44:08.335922-03:00', 'Itaque omnis eaque velit.
                Inventore et aut et eaque consequuntur dolores nostrum distinctio.', NULL, NULL, 'Grocery', NULL, 'et-qui-dicta', 'http://lorempixel.com/640/480/fashion');
INSERT INTO "Category" ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (10, 'Et itaque in blanditiis ipsa.', 9, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-07 21:35:19.819352-03:00', 'Hic et culpa. Hic voluptas esse inventore rerum totam tempore hic hic. Assumenda nemo quia aut nam. Explicabo voluptatem at soluta modi alias. Quisquam pariatur velit alias magni aut quia quia eos non. Aliquam natus delectus iste optio sunt sit suscipit ea vel.', NULL, NULL, 'Automotive', NULL, 'dolorem-sunt-magni', 'http://lorempixel.com/640/480/fashion');

INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (36, NULL, 'http://lorempixel.com/640/480/fashion', -2108669627, FALSE, TIMESTAMPTZ '2019-08-16 15:59:29.049092-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (35, NULL, 'http://lorempixel.com/640/480/fashion', 1348465874, FALSE, TIMESTAMPTZ '2019-08-23 23:01:37.097476-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (34, NULL, 'http://lorempixel.com/640/480/fashion', -908392503, FALSE, TIMESTAMPTZ '2019-08-17 04:32:54.494675-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (33, NULL, 'http://lorempixel.com/640/480/fashion', -100319305, FALSE, TIMESTAMPTZ '2019-08-14 20:17:01.255109-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (29, NULL, 'http://lorempixel.com/640/480/fashion', -2083566090, FALSE, TIMESTAMPTZ '2019-08-15 11:30:58.817424-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (31, NULL, 'http://lorempixel.com/640/480/fashion', 544970196, FALSE, TIMESTAMPTZ '2019-08-15 16:25:17.991581-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (30, NULL, 'http://lorempixel.com/640/480/fashion', 412570580, FALSE, TIMESTAMPTZ '2019-08-12 06:39:30.390089-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (37, NULL, 'http://lorempixel.com/640/480/fashion', 634328547, FALSE, TIMESTAMPTZ '2019-08-13 21:36:41.747368-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (28, NULL, 'http://lorempixel.com/640/480/fashion', -1097659092, FALSE, TIMESTAMPTZ '2019-08-14 13:35:07.304844-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (32, NULL, 'http://lorempixel.com/640/480/fashion', -1766148219, FALSE, TIMESTAMPTZ '2019-08-22 01:56:57.659994-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (38, NULL, 'http://lorempixel.com/640/480/fashion', -1136934246, FALSE, TIMESTAMPTZ '2019-08-22 23:39:12.027081-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (43, NULL, 'http://lorempixel.com/640/480/fashion', -1914133396, FALSE, TIMESTAMPTZ '2019-08-21 21:42:04.501786-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (40, NULL, 'http://lorempixel.com/640/480/fashion', 2098441845, FALSE, TIMESTAMPTZ '2019-08-11 07:28:56.431942-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (41, NULL, 'http://lorempixel.com/640/480/fashion', 1786569821, FALSE, TIMESTAMPTZ '2019-08-12 19:26:14.577724-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (42, NULL, 'http://lorempixel.com/640/480/fashion', -1260092941, FALSE, TIMESTAMPTZ '2019-08-17 16:52:34.708562-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (44, NULL, 'http://lorempixel.com/640/480/fashion', -489405057, FALSE, TIMESTAMPTZ '2019-08-10 19:49:36.178342-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (45, NULL, 'http://lorempixel.com/640/480/fashion', 339253202, FALSE, TIMESTAMPTZ '2019-08-15 12:25:05.951036-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (46, NULL, 'http://lorempixel.com/640/480/fashion', -1864844783, FALSE, TIMESTAMPTZ '2019-08-13 09:19:28.233374-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (47, NULL, 'http://lorempixel.com/640/480/fashion', -1440869552, FALSE, TIMESTAMPTZ '2019-08-11 02:44:23.585116-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (48, NULL, 'http://lorempixel.com/640/480/fashion', -181993261, FALSE, TIMESTAMPTZ '2019-08-19 07:35:18.94923-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (49, NULL, 'http://lorempixel.com/640/480/fashion', -248962094, FALSE, TIMESTAMPTZ '2019-08-14 15:32:16.712711-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (50, NULL, 'http://lorempixel.com/640/480/fashion', -1119961787, FALSE, TIMESTAMPTZ '2019-08-14 20:39:47.089574-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (27, NULL, 'http://lorempixel.com/640/480/fashion', 1118343401, FALSE, TIMESTAMPTZ '2019-08-19 00:46:14.762729-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (39, NULL, 'http://lorempixel.com/640/480/fashion', 535492750, FALSE, TIMESTAMPTZ '2019-08-19 23:17:08.21624-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (26, NULL, 'http://lorempixel.com/640/480/fashion', -1456160779, FALSE, TIMESTAMPTZ '2019-08-12 15:12:12.175116-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (23, NULL, 'http://lorempixel.com/640/480/fashion', 325028550, FALSE, TIMESTAMPTZ '2019-08-18 01:30:05.535209-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (24, NULL, 'http://lorempixel.com/640/480/fashion', -1923942321, FALSE, TIMESTAMPTZ '2019-08-17 04:55:55.763583-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (1, NULL, 'http://lorempixel.com/640/480/fashion', 611298457, FALSE, TIMESTAMPTZ '2019-08-17 14:35:16.80201-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (25, NULL, 'http://lorempixel.com/640/480/fashion', 1917445442, FALSE, TIMESTAMPTZ '2019-08-18 21:22:33.463243-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (3, NULL, 'http://lorempixel.com/640/480/fashion', -818678637, FALSE, TIMESTAMPTZ '2019-08-23 20:37:35.754971-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (4, NULL, 'http://lorempixel.com/640/480/fashion', -1509550385, FALSE, TIMESTAMPTZ '2019-08-23 22:43:16.136611-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (5, NULL, 'http://lorempixel.com/640/480/fashion', -1506346253, FALSE, TIMESTAMPTZ '2019-08-17 03:01:28.889967-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (6, NULL, 'http://lorempixel.com/640/480/fashion', -149445437, FALSE, TIMESTAMPTZ '2019-08-19 12:38:35.724181-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (7, NULL, 'http://lorempixel.com/640/480/fashion', -503129824, FALSE, TIMESTAMPTZ '2019-08-18 17:43:41.750631-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (8, NULL, 'http://lorempixel.com/640/480/fashion', 1180898732, FALSE, TIMESTAMPTZ '2019-08-18 14:52:41.387939-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (9, NULL, 'http://lorempixel.com/640/480/fashion', 1087295132, FALSE, TIMESTAMPTZ '2019-08-16 02:46:31.663597-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (10, NULL, 'http://lorempixel.com/640/480/fashion', 870675147, FALSE, TIMESTAMPTZ '2019-08-17 21:00:20.753766-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (11, NULL, 'http://lorempixel.com/640/480/fashion', 1043204431, FALSE, TIMESTAMPTZ '2019-08-12 01:34:32.983753-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (2, NULL, 'http://lorempixel.com/640/480/fashion', 243519899, FALSE, TIMESTAMPTZ '2019-08-12 21:10:18.166241-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (13, NULL, 'http://lorempixel.com/640/480/fashion', 704351027, FALSE, TIMESTAMPTZ '2019-08-18 00:39:03.509808-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (14, NULL, 'http://lorempixel.com/640/480/fashion', 1373767583, FALSE, TIMESTAMPTZ '2019-08-14 05:33:44.539327-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (15, NULL, 'http://lorempixel.com/640/480/fashion', -1229790608, FALSE, TIMESTAMPTZ '2019-08-11 21:51:23.846737-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (16, NULL, 'http://lorempixel.com/640/480/fashion', 16787319, FALSE, TIMESTAMPTZ '2019-08-23 06:31:03.396306-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (17, NULL, 'http://lorempixel.com/640/480/fashion', 1618397578, FALSE, TIMESTAMPTZ '2019-08-17 11:00:18.300698-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (18, NULL, 'http://lorempixel.com/640/480/fashion', -453238050, FALSE, TIMESTAMPTZ '2019-08-14 18:07:39.095577-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (19, NULL, 'http://lorempixel.com/640/480/fashion', -1059995747, FALSE, TIMESTAMPTZ '2019-08-19 05:18:58.166283-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (20, NULL, 'http://lorempixel.com/640/480/fashion', -155246211, FALSE, TIMESTAMPTZ '2019-08-15 12:59:11.030891-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (21, NULL, 'http://lorempixel.com/640/480/fashion', -495990426, FALSE, TIMESTAMPTZ '2019-08-14 21:15:30.780588-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (22, NULL, 'http://lorempixel.com/640/480/fashion', 1229556885, FALSE, TIMESTAMPTZ '2019-08-17 19:59:08.543645-03:00', 1, NULL, NULL);
INSERT INTO "Media" ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (12, NULL, 'http://lorempixel.com/640/480/fashion', -1459881308, FALSE, TIMESTAMPTZ '2019-08-15 16:02:56.131268-03:00', 1, NULL, NULL);

INSERT INTO "Shipment" ("Id", "Comment", "CreatedOn", "DeliveryCost", "DeliveryDate", "IsDeleted", "LastModified", "Price", "ShippedDate", "StormyOrderId", "TotalWeight", "TrackNumber")
VALUES (2, 'a single comment', TIMESTAMP '2019-08-24 15:08:25.132208', 22.29, TIMESTAMP '2019-08-27 00:00:00', FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.132207+00:00', 20.99, TIMESTAMP '2019-08-23 00:00:00', NULL, 0.4, '166e94a2-95df-494a-ab5c-6f1fdd495f3f');

INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (12, 0, NULL, 'Reis LTDA', 'John_Carvalho', 'John_Carvalho@yahoo.com', FALSE, TIMESTAMPTZ '2019-08-11 18:50:50.407237-03:00', 'https://loremflickr.com/320/240?lock=791857212', 'deserunt', '(27) 38261-7332', '0', 'Movies, Games & Health', 'maria.info');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (13, 0, NULL, 'Xavier S.A.', 'Marion20', 'Marion.Silva22@live.com', FALSE, TIMESTAMPTZ '2019-08-18 21:55:11.064354-03:00', 'https://loremflickr.com/320/240?lock=1288572883', 'consequatur', '(85) 1969-4516', '0', 'Electronics, Garden & Outdoors', 'víctor.com');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (14, 0, NULL, 'Albuquerque, Moraes and Nogueira', 'Garry81', 'Garry_Melo@gmail.com', FALSE, TIMESTAMPTZ '2019-08-01 11:00:34.803169-03:00', 'https://loremflickr.com/320/240?lock=22161171', 'Est veniam ut fuga optio dolor.
                Mollitia veritatis esse.
                Molestiae ut reiciendis nemo.
                Porro in facilis ut.', '+55 (09) 4771-0411', '0', 'Sports', 'lorraine.com');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (18, 0, NULL, 'Xavier, Braga and Silva', 'Ivan.Carvalho77', 'Ivan22@gmail.com', FALSE, TIMESTAMPTZ '2019-08-16 18:49:33.23717-03:00', 'https://loremflickr.com/320/240?lock=1799454219', 'praesentium', '(23) 91325-2397', '0', 'Computers & Games', 'víctor.name');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (16, 0, NULL, 'Carvalho - Albuquerque', 'Orlando_Carvalho', 'Orlando_Carvalho@gmail.com', FALSE, TIMESTAMPTZ '2019-08-21 09:52:09.368698-03:00', 'https://loremflickr.com/320/240?lock=995885461', 'Doloribus labore et dolores voluptas facilis omnis et magnam rerum.
                Voluptatem excepturi magni.', '(77) 52907-5488', '0', 'Home & Home', 'alessandro.org');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (17, 0, NULL, 'Nogueira, Melo and Reis', 'Dianne.Xavier29', 'Dianne.Xavier34@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-02 17:14:48.144509-03:00', 'https://loremflickr.com/320/240?lock=157927682', 'Mollitia provident esse est aspernatur. Dolores cupiditate repudiandae quia dolor animi. Maiores ipsam nostrum ipsam et. Vero doloremque minima provident sint et odio soluta. Placeat qui accusantium natus cum natus molestias iure.', '(72) 3785-2466', '0', 'Clothing, Shoes & Games', 'janaína.net');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (11, 0, NULL, 'Melo LTDA', 'Jerome_Carvalho', 'Jerome.Carvalho@yahoo.com', FALSE, TIMESTAMPTZ '2019-08-17 02:37:28.085397-03:00', 'https://loremflickr.com/320/240?lock=750672895', 'voluptas', '+55 (09) 6261-5919', '0', 'Garden & Tools', 'frederico.org');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (15, 0, NULL, 'Carvalho, Saraiva and Moreira', 'Jonathan_Souza21', 'Jonathan.Souza49@hotmail.com', FALSE, TIMESTAMPTZ '2019-08-21 05:49:19.075381-03:00', 'https://loremflickr.com/320/240?lock=128559375', 'Quia aliquam doloribus eaque.
                Sequi optio consequuntur id quis sit sint cumque voluptatibus aperiam.
                Dolore mollitia autem aliquid iste quidem.
                Illo officia dolores dolores quae.', '(40) 4806-7683', '0', 'Baby, Books & Computers', 'lorraine.org');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (10, 0, NULL, 'Martins Comércio', 'Alexandra.Albuquerque1', 'Alexandra.Albuquerque@live.com', FALSE, TIMESTAMPTZ '2019-08-06 17:17:20.996116-03:00', 'https://loremflickr.com/320/240?lock=1910852930', 'Dolorem voluptatem tempore rem blanditiis rerum.
                Voluptatem animi eaque aliquid.
                Enim neque nisi non nisi iste.
                Natus quo deleniti placeat commodi omnis ut quia officiis.
                Quia excepturi perferendis voluptatem aut rerum ex illum.', '(20) 18819-0757', '0', 'Games, Toys & Clothing', 'warley.biz');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (4, 0, NULL, 'Carvalho Comércio', 'Erma73', 'Erma.Melo@hotmail.com', FALSE, TIMESTAMPTZ '2019-08-19 22:31:17.131541-03:00', 'https://loremflickr.com/320/240?lock=619332642', 'quidem', '(60) 82307-1286', '0', 'Beauty, Home & Grocery', 'vicente.br');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (8, 0, NULL, 'Franco Comércio', 'Jared_Moraes11', 'Jared.Moraes@yahoo.com', FALSE, TIMESTAMPTZ '2019-08-05 10:26:51.790527-03:00', 'https://loremflickr.com/320/240?lock=1528370096', 'Placeat quibusdam modi error in est autem fugit.
                Ex quo sint eum voluptas eos delectus.
                Saepe sed illum corrupti commodi sapiente.', '(39) 26128-9984', '0', 'Outdoors & Shoes', 'lucas.biz');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (7, 0, NULL, 'Saraiva, Moraes and Pereira', 'Jack_Nogueira48', 'Jack_Nogueira@hotmail.com', FALSE, TIMESTAMPTZ '2019-08-04 15:11:41.307572-03:00', 'https://loremflickr.com/320/240?lock=258072353', 'similique', '(36) 24376-9265', '0', 'Industrial, Automotive & Toys', 'júlio césar.net');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (6, 0, NULL, 'Souza - Carvalho', 'Stanley39', 'Stanley.Oliveira31@yahoo.com', FALSE, TIMESTAMPTZ '2019-07-29 09:02:30.607069-03:00', 'https://loremflickr.com/320/240?lock=96771084', 'Illo eveniet consectetur.
                Sapiente hic ad aspernatur cumque.
                Ipsam ducimus et dignissimos.
                Laboriosam asperiores natus vitae dolorem est dolore in assumenda mollitia.', '(46) 59025-0175', '0', 'Kids', 'roberto.net');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (5, 0, NULL, 'Silva, Silva and Martins', 'Margarita87', 'Margarita.Franco@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-12 22:34:34.807252-03:00', 'https://loremflickr.com/320/240?lock=1227561311', 'Consectetur corporis sint atque optio voluptatem numquam consequatur mollitia.', '(56) 16823-9976', '0', 'Computers & Baby', 'pablo.name');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (3, 0, NULL, 'Nogueira - Carvalho', 'Ronnie29', 'Ronnie20@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-12 22:19:42.135514-03:00', 'https://loremflickr.com/320/240?lock=229830666', 'Sit iusto ex dolor id fuga aut fugiat fugit nihil. Dolor reprehenderit doloremque eos nihil. Molestiae sed mollitia eum voluptatem occaecati suscipit animi odit.', '(11) 84475-7942', '0', 'Computers', 'marcos.com');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (2, 0, NULL, 'Santos, Xavier and Pereira', 'Andres.Saraiva', 'Andres.Saraiva24@yahoo.com', FALSE, TIMESTAMPTZ '2019-08-13 07:39:41.736371-03:00', 'https://loremflickr.com/320/240?lock=1287796653', 'Et eaque consectetur maiores at reiciendis autem accusamus voluptatum quae.
                Aut inventore occaecati velit vero quis.
                Omnis assumenda quasi aut ducimus deserunt tempora tenetur.
                A asperiores dignissimos dicta assumenda rerum magnam sunt ipsa.
                Minus omnis labore.
                Consequatur officia rem commodi voluptatem esse unde soluta eius.', '(91) 18155-7818', '0', 'Kids, Automotive & Jewelery', 'sara.br');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (1, 0, NULL, 'Souza, Carvalho and Martins', 'Josh86', 'Josh_Reis@hotmail.com', FALSE, TIMESTAMPTZ '2019-08-22 04:35:19.352548-03:00', 'https://loremflickr.com/320/240?lock=1621284909', 'numquam', '(41) 66293-9001', '0', 'Shoes, Clothing & Movies', 'heitor.info');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (19, 0, NULL, 'Silva, Santos and Macedo', 'Audrey21', 'Audrey_Braga8@hotmail.com', FALSE, TIMESTAMPTZ '2019-08-05 11:44:13.958943-03:00', 'https://loremflickr.com/320/240?lock=703460413', 'Tempore at corporis sed sit maxime omnis cumque sunt.', '+55 (64) 8538-0409', '0', 'Kids', 'roberta.info');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (9, 0, NULL, 'Albuquerque - Souza', 'Courtney_Saraiva', 'Courtney.Saraiva@gmail.com', FALSE, TIMESTAMPTZ '2019-08-16 11:52:11.384365-03:00', 'https://loremflickr.com/320/240?lock=1596160703', 'Quis fuga dolor dolorem qui aut id.', '(05) 5481-3711', '0', 'Baby & Garden', 'ígor.net');
INSERT INTO "StormyVendor" ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (20, 0, NULL, 'Macedo - Batista', 'Fernando37', 'Fernando_Moreira32@hotmail.com', FALSE, TIMESTAMPTZ '2019-08-12 12:51:01.194091-03:00', 'https://loremflickr.com/320/240?lock=397258838', 'Neque laboriosam consequatur.', '(18) 8585-1434', '0', 'Toys, Toys & Health', 'alexandre.biz');

INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (13, FALSE, 0, 0, FALSE, 7, 10, TIMESTAMP '2019-03-27 09:01:14.216474', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491661+00:00', 2, 0, 0, FALSE, 'Modi vel vitae minus aut molestias dolores ut inventore. Tempore qui laboriosam sed omnis veniam illo perferendis quasi in. Quia error tempore perferendis. Error repellat distinctio sunt sint laborum sunt aliquid. Facilis iusto magni eos quo voluptatibus dolorem non possimus et. Odit ea dolorem optio beatae et illum molestiae.', 'R$12,05', TIMESTAMP '2020-02-22 11:03:09.219571', 'R$62,37', TRUE, 0.818910778881475, 0, 'Gorgeous Fresh Tuna', TRUE, 72, 13, 'r9yf5gln8khe730i', 'et-dolore-modi', 'Good', TRUE, 'Health', 41.5576038609993, 2.91224795994919, 0.44761612333711986, 56, 32, TIMESTAMP '2019-08-24 20:34:56.589114', 1);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (32, FALSE, 0, 0, FALSE, 6, 9, TIMESTAMP '2019-06-28 09:41:32.23212', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492304+00:00', 3, 0, 0, FALSE, 'Sit quasi est id ipsam laborum sed deleniti voluptatibus. Ipsam omnis quas adipisci dicta. In aspernatur dolore quo quis qui. Minus velit non et doloribus nemo. Expedita et officia in vitae. Optio eos voluptatem ducimus saepe eaque.', 'R$160,92', TIMESTAMP '2020-08-20 23:19:23.133434', 'R$59,49', TRUE, 0.820101412860724, 0, 'Practical Plastic Pizza', TRUE, 52, 32, 't5kv4zbcralpj53g', 'totam-totam-suscipit', 'Good', TRUE, 'Movies', 14.3501326974249, 5.72093444677113, 0.13519204227961229, 72, 48, TIMESTAMP '2019-08-24 03:16:50.788874', 12);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (39, FALSE, 0, 0, FALSE, 9, 10, TIMESTAMP '2019-07-31 10:55:08.36686', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492533+00:00', 18, 0, 0, FALSE, 'Sunt sit vitae ea suscipit earum.', 'R$185,88', TIMESTAMP '2020-06-25 17:50:51.690602', 'R$49,81', TRUE, 0.115652371717455, 0, 'Gorgeous Soft Hat', TRUE, 92, 39, 'wtfw4llk4dzn5z1d', 'ad-ut-totam', 'Good', TRUE, 'Tools', 48.0011621713644, 6.91806766526684, 0.055496517594669253, 66, 48, TIMESTAMP '2019-08-24 09:00:08.915452', 12);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (49, FALSE, 0, 0, FALSE, 7, 8, TIMESTAMP '2019-02-03 15:35:18.229029', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492862+00:00', 15, 0, 0, FALSE, 'Praesentium voluptas animi necessitatibus assumenda maxime.', 'R$22,05', TIMESTAMP '2020-05-28 19:38:25.587576', 'R$64,06', TRUE, 0.307598026146925, 0, 'Fantastic Rubber Soap', TRUE, 50, 49, '54gsdh8g9ix1a4du', 'harum-nihil-consequuntur', 'Good', TRUE, 'Beauty', 85.3512224207405, 1.49395043099949, 0.0046733892544514452, 100, 16, TIMESTAMP '2019-08-23 21:08:47.255284', 12);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (8, FALSE, 0, 0, FALSE, 2, 1, TIMESTAMP '2018-12-20 12:37:44.189393', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491426+00:00', 15, 0, 0, FALSE, 'Harum quam rerum. Aut pariatur cum omnis similique perspiciatis atque. Quos sapiente eius rerum tempore deleniti modi. Sit id ea vel ab inventore doloremque tenetur. Saepe praesentium suscipit inventore unde. Reiciendis ratione totam atque nesciunt rerum.', 'R$176,19', TIMESTAMP '2019-11-24 13:23:30.858868', 'R$51,80', TRUE, 0.509704343280617, 0, 'Intelligent Plastic Soap', TRUE, 16, 8, '6gzbclfdkkatm0es', 'doloribus-commodi-aut', 'Good', TRUE, 'Toys', 28.3852096779203, 2.66953159247969, 0.55612581295712193, 74, 4, TIMESTAMP '2019-08-24 16:30:02.911445', 13);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (4, FALSE, 0, 0, FALSE, 10, 2, TIMESTAMP '2019-08-18 02:06:05.07829', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491294+00:00', 11, 0, 0, FALSE, 'Enim officiis illum aut totam.
                Unde aliquam accusantium ullam nobis fuga cum et.
                Dolores id voluptatem distinctio.
                Reiciendis cumque facilis adipisci doloremque animi.', 'R$176,39', TIMESTAMP '2019-11-07 22:23:37.361024', 'R$5,09', TRUE, 0.779673041673225, 0, 'Intelligent Rubber Pants', TRUE, 72, 4, 'fza8qc77ij45b5u6', 'occaecati-modi-aut', 'Good', TRUE, 'Health', 18.1174839465495, 0.0811699172859871, 0.90433514160305961, 62, 50, TIMESTAMP '2019-08-24 14:10:06.571621', 14);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (7, FALSE, 0, 0, FALSE, 7, 8, TIMESTAMP '2019-07-18 06:24:00.085054', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491398+00:00', 17, 0, 0, FALSE, 'odio', 'R$32,55', TIMESTAMP '2020-08-15 04:58:01.227017', 'R$11,18', TRUE, 0.152297767881443, 0, 'Unbranded Granite Shoes', TRUE, 20, 7, 'vataetlgngl5ynej', 'sunt-eum-aliquid', 'Good', TRUE, 'Automotive', 68.559929155074, 0.487584960873977, 0.8150927055697389, 94, 42, TIMESTAMP '2019-08-23 20:16:26.178964', 14);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (9, FALSE, 0, 0, FALSE, 5, 5, TIMESTAMP '2018-11-03 19:47:55.982016', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491473+00:00', 16, 0, 0, FALSE, 'Perferendis vel corrupti sapiente voluptatem asperiores distinctio. Neque perferendis sed molestiae cupiditate. Pariatur sit aut ex. Dolorum cum non sint ipsa sed eligendi dolores natus. Voluptatem vel quibusdam labore iste deleniti. Sunt minima deleniti non.', 'R$145,70', TIMESTAMP '2019-10-05 06:30:47.569041', 'R$34,38', TRUE, 0.673109453950594, 0, 'Small Soft Salad', TRUE, 86, 9, '0tgttqio35hxk8s7', 'repellat-et-fugiat', 'Good', TRUE, 'Jewelery', 13.4983796689186, 8.95411566782469, 0.33681604374983165, 72, 6, TIMESTAMP '2019-08-24 12:53:44.662485', 14);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (37, FALSE, 0, 0, FALSE, 10, 8, TIMESTAMP '2018-11-18 09:34:54.878931', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492469+00:00', 14, 0, 0, FALSE, 'Iusto sint minima.
                Veniam et exercitationem aut ut magnam architecto et aperiam.
                Rerum est repudiandae officiis quia blanditiis libero sed.
                Sequi veniam neque qui explicabo recusandae saepe maiores.', 'R$76,32', TIMESTAMP '2019-09-05 23:51:39.270666', 'R$51,38', TRUE, 0.161691048723502, 0, 'Handmade Granite Pants', TRUE, 66, 37, 'td6hpl9f4z7y7777', 'voluptas-voluptatem-perspiciatis', 'Good', TRUE, 'Movies', 21.0329801873458, 0.176233537577201, 0.55346768235483568, 58, 50, TIMESTAMP '2019-08-25 10:16:53.560852', 14);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (46, FALSE, 0, 0, FALSE, 7, 3, TIMESTAMP '2019-05-02 09:20:49.608412', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492761+00:00', 18, 0, 0, FALSE, 'Magni facilis ut doloremque et. Architecto ea et. Dolorem minus eaque consequatur. Qui tempore sapiente molestias eos porro quia. Sunt deserunt est qui aut animi. Dicta eum cumque.', 'R$45,44', TIMESTAMP '2020-04-05 09:20:34.794856', 'R$24,64', TRUE, 0.357319748661164, 0, 'Ergonomic Metal Soap', TRUE, 80, 46, '9trxd9rzdlypypmk', 'aliquid-alias-distinctio', 'Good', TRUE, 'Books', 69.9507012823367, 9.63520220463872, 0.16278013082350609, 100, 44, TIMESTAMP '2019-08-24 07:12:09.463205', 15);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (17, FALSE, 0, 0, FALSE, 1, 5, TIMESTAMP '2018-08-31 11:13:07.440518', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491835+00:00', 1, 0, 0, FALSE, 'Nam omnis et non quo in voluptatem aut commodi. Omnis debitis voluptas voluptatibus. Animi et minus tenetur et et et. Assumenda quisquam ratione pariatur nihil repudiandae vel quis accusantium eaque. Est natus inventore praesentium.', 'R$81,36', TIMESTAMP '2020-05-21 15:23:51.749552', 'R$18,06', TRUE, 0.75900348404376, 0, 'Gorgeous Fresh Chicken', TRUE, 62, 17, 'c291i6wwnz9cuzvz', 'voluptates-repellendus-est', 'Good', TRUE, 'Automotive', 42.0782072665534, 9.31272157901559, 0.34589005231200254, 68, 26, TIMESTAMP '2019-08-24 09:07:12.313968', 16);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (18, FALSE, 0, 0, FALSE, 5, 1, TIMESTAMP '2019-07-23 16:15:25.144555', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.49189+00:00', 10, 0, 0, FALSE, 'Eveniet et culpa odit quae nostrum iste nihil accusantium et.', 'R$135,45', TIMESTAMP '2020-07-20 14:31:32.817667', 'R$60,88', TRUE, 0.31019219118645, 0, 'Awesome Soft Sausages', TRUE, 86, 18, 'zw1u1tkqgwjuqund', 'alias-perspiciatis-nisi', 'Good', TRUE, 'Toys', 32.9801229913626, 9.24145208636366, 0.22282055403237258, 100, 2, TIMESTAMP '2019-08-24 10:49:18.801721', 16);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (27, FALSE, 0, 0, FALSE, 9, 6, TIMESTAMP '2018-10-05 17:45:59.154841', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492149+00:00', 15, 0, 0, FALSE, 'Sed dolor aliquid.', 'R$15,27', TIMESTAMP '2019-09-30 07:39:33.772742', 'R$10,67', TRUE, 0.473828706645327, 0, 'Sleek Cotton Sausages', TRUE, 42, 27, '4d79suz3xirtj9bg', 'omnis-voluptas-velit', 'Good', TRUE, 'Automotive', 55.4934694690134, 3.63266267051579, 0.54272435723930801, 70, 10, TIMESTAMP '2019-08-24 18:47:05.313612', 16);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (36, FALSE, 0, 0, FALSE, 2, 10, TIMESTAMP '2019-06-03 01:29:38.041874', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492441+00:00', 4, 0, 0, FALSE, 'Ut ducimus laboriosam alias numquam.', 'R$87,49', TIMESTAMP '2020-07-18 04:19:39.577454', 'R$56,38', TRUE, 0.0844252780472977, 0, 'Awesome Concrete Shoes', TRUE, 98, 36, 'gi9lt25l3lg4n6br', 'facilis-sed-impedit', 'Good', TRUE, 'Outdoors', 67.6102216670337, 7.86649240081501, 0.33264052603982414, 70, 6, TIMESTAMP '2019-08-24 11:24:18.519899', 16);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (43, FALSE, 0, 0, FALSE, 5, 3, TIMESTAMP '2018-09-30 17:23:12.504773', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492664+00:00', 8, 0, 0, FALSE, 'In ut officiis est. Voluptatum cupiditate eum praesentium. Dolorem modi non porro. Optio alias quae ipsum debitis asperiores voluptatem eos consectetur temporibus.', 'R$63,41', TIMESTAMP '2019-10-02 07:41:27.904624', 'R$34,73', TRUE, 0.880236929692438, 0, 'Generic Cotton Fish', TRUE, 38, 43, 'm9abg6lom28xy104', 'ut-occaecati-voluptate', 'Good', TRUE, 'Kids', 37.814918364312, 3.18703152853392, 0.40556247458120925, 54, 14, TIMESTAMP '2019-08-24 09:10:27.069855', 17);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (29, FALSE, 0, 0, FALSE, 2, 4, TIMESTAMP '2019-04-16 20:25:59.662638', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492199+00:00', 7, 0, 0, FALSE, 'Non quisquam consequatur eaque laborum aut commodi atque.
                In ab sed sapiente quos blanditiis beatae maiores.
                Quis corrupti quia voluptatem magnam.', 'R$118,25', TIMESTAMP '2020-07-13 12:20:07.296269', 'R$58,74', TRUE, 0.774775337322976, 0, 'Rustic Fresh Hat', TRUE, 10, 29, 'dltle15tn1plki5v', 'dolores-eum-fugiat', 'Good', TRUE, 'Garden', 22.9745402573489, 3.55948046946874, 0.0058836592388728914, 84, 8, TIMESTAMP '2019-08-24 04:13:41.620893', 18);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (34, FALSE, 0, 0, FALSE, 8, 10, TIMESTAMP '2019-01-09 20:26:51.656664', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492382+00:00', 10, 0, 0, FALSE, 'Nemo impedit quia optio provident explicabo dolorum. Quis perferendis sequi ut nisi aliquam nostrum et similique. Sint suscipit porro asperiores.', 'R$83,37', TIMESTAMP '2019-11-10 13:00:43.262961', 'R$84,27', TRUE, 0.530296365977403, 0, 'Licensed Soft Mouse', TRUE, 38, 34, '7f14d0yeutv2p6gz', 'aut-beatae-odio', 'Good', TRUE, 'Books', 50.0851477263892, 0.307560013750363, 0.504851456035325, 96, 4, TIMESTAMP '2019-08-24 08:14:07.36768', 18);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (38, FALSE, 0, 0, FALSE, 2, 6, TIMESTAMP '2019-06-08 04:52:41.277816', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.49251+00:00', 20, 0, 0, FALSE, 'distinctio', 'R$110,70', TIMESTAMP '2020-07-08 01:00:41.115214', 'R$98,80', TRUE, 0.322477531303874, 0, 'Fantastic Frozen Shirt', TRUE, 88, 38, 'i28sb4i4d8s4k4s7', 'architecto-beatae-ut', 'Good', TRUE, 'Toys', 24.4038528410736, 9.33329112796732, 0.75310187915018845, 96, 42, TIMESTAMP '2019-08-24 18:05:19.106842', 18);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (40, FALSE, 0, 0, FALSE, 7, 6, TIMESTAMP '2018-10-13 07:42:55.909092', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492564+00:00', 1, 0, 0, FALSE, 'et', 'R$93,53', TIMESTAMP '2020-01-18 23:54:57.534121', 'R$49,21', TRUE, 0.438548873848537, 0, 'Ergonomic Concrete Soap', TRUE, 34, 40, 'qseufwqf29n3qssk', 'maxime-facilis-odit', 'Good', TRUE, 'Outdoors', 40.1881550625843, 1.51139843813674, 0.99955304153242752, 86, 14, TIMESTAMP '2019-08-25 03:19:21.625343', 18);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (12, FALSE, 0, 0, FALSE, 8, 9, TIMESTAMP '2019-02-17 06:36:36.088712', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491599+00:00', 6, 0, 0, FALSE, 'Ut id laudantium quis. Omnis atque odio aut et quas molestiae reiciendis dolores alias. Nihil enim praesentium soluta aut est sunt soluta similique accusantium. Consectetur error nisi accusamus incidunt laudantium perspiciatis. Perspiciatis quis dolor ab ut dolor impedit occaecati voluptatibus expedita. Neque magnam ut.', 'R$182,19', TIMESTAMP '2020-04-16 18:37:45.023786', 'R$9,34', TRUE, 0.281461634804244, 0, 'Gorgeous Concrete Chicken', TRUE, 16, 12, 'u15w5lof7bs9au5z', 'nam-distinctio-voluptatem', 'Good', TRUE, 'Beauty', 13.9209376712893, 4.75268557423385, 0.38878679898976665, 52, 28, TIMESTAMP '2019-08-24 11:57:38.68873', 19);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (14, FALSE, 0, 0, FALSE, 7, 1, TIMESTAMP '2019-04-25 20:20:24.099393', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491715+00:00', 1, 0, 0, FALSE, 'Non sed impedit impedit at nesciunt facere.
                Aut omnis voluptate perferendis ex iure.
                Maxime quia rerum tenetur maxime ut sit aliquam qui.
                Illum molestias voluptatem officia recusandae.
                Vitae dicta dolores et rem dolores laudantium.', 'R$171,52', TIMESTAMP '2020-06-16 03:12:35.764256', 'R$11,94', TRUE, 0.539447287814434, 0, 'Rustic Frozen Tuna', TRUE, 84, 14, '4uxvcf2ns1bl76y0', 'nostrum-autem-qui', 'Good', TRUE, 'Shoes', 2.55971150591956, 8.2386600217962, 0.41369204102721624, 74, 28, TIMESTAMP '2019-08-24 12:10:38.232039', 19);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (31, FALSE, 0, 0, FALSE, 3, 6, TIMESTAMP '2019-05-19 04:16:38.175256', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.49226+00:00', 18, 0, 0, FALSE, 'Aut sed est.
                Rem facere quo explicabo nesciunt dolore minus nobis aut commodi.
                Iure fugit quibusdam natus quia quidem rerum id ipsam.', 'R$92,52', TIMESTAMP '2020-04-22 12:56:03.231459', 'R$91,96', TRUE, 0.232138035461371, 0, 'Rustic Steel Salad', TRUE, 100, 31, 'occyundkm123abkz', 'expedita-accusantium-vel', 'Good', TRUE, 'Shoes', 11.6292014306547, 2.18262821071904, 0.083286076822917013, 100, 16, TIMESTAMP '2019-08-23 20:39:19.192502', 19);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (24, FALSE, 0, 0, FALSE, 7, 2, TIMESTAMP '2018-09-27 05:20:28.779213', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492065+00:00', 10, 0, 0, FALSE, 'Dolorem aut et amet velit aut qui et alias asperiores.', 'R$194,67', TIMESTAMP '2020-07-23 15:25:39.620381', 'R$44,26', TRUE, 0.269751491616364, 0, 'Gorgeous Granite Chair', TRUE, 24, 24, 'af1kqrqh320dcvfy', 'omnis-nisi-est', 'Good', TRUE, 'Movies', 18.7064155557688, 5.1203495334463, 0.60660611819783505, 56, 2, TIMESTAMP '2019-08-24 09:20:27.341481', 11);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (19, FALSE, 0, 0, FALSE, 5, 10, TIMESTAMP '2019-01-23 07:18:27.534247', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491925+00:00', 6, 0, 0, FALSE, 'Voluptates quia fugiat beatae id dolorem sunt ex.', 'R$20,15', TIMESTAMP '2019-11-22 07:17:23.44375', 'R$78,38', TRUE, 0.426270312828138, 0, 'Intelligent Concrete Pants', TRUE, 88, 19, '4ypmftibjzb9msdt', 'ullam-sint-est', 'Good', TRUE, 'Industrial', 83.6943903862007, 5.46535172754217, 0.59626471465279562, 68, 0, TIMESTAMP '2019-08-23 18:32:33.86035', 11);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (16, FALSE, 0, 0, FALSE, 7, 10, TIMESTAMP '2018-10-27 11:26:07.777852', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491789+00:00', 14, 0, 0, FALSE, 'Necessitatibus enim atque fugiat earum nostrum.
                Laboriosam quae optio repellendus voluptatum sed a.
                Vero tempore illum fugit sed.
                Ipsa culpa qui possimus.
                Et architecto nesciunt ratione et eos quos non.
                Quos accusamus temporibus nulla sed sit perspiciatis.', 'R$132,30', TIMESTAMP '2020-06-09 03:12:10.769694', 'R$12,90', TRUE, 0.525968569575794, 0, 'Intelligent Frozen Table', TRUE, 30, 16, '243vtfjradircmsh', 'non-rerum-dolorem', 'Good', TRUE, 'Garden', 85.6036529809254, 4.5752304348048, 0.81076627867797679, 64, 38, TIMESTAMP '2019-08-24 18:44:10.874834', 11);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (6, FALSE, 0, 0, FALSE, 8, 2, TIMESTAMP '2019-07-31 06:23:08.159499', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491372+00:00', 5, 0, 0, FALSE, 'Voluptate et eveniet consequuntur dolores.', 'R$137,26', TIMESTAMP '2020-08-11 03:48:42.833289', 'R$43,54', TRUE, 0.947704366383936, 0, 'Unbranded Metal Hat', TRUE, 96, 6, '0asor8wsczyudvzr', 'animi-dolores-provident', 'Good', TRUE, 'Jewelery', 61.9646521573722, 5.5592095412124, 0.35911439375910648, 54, 30, TIMESTAMP '2019-08-25 00:12:10.868975', 11);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (15, FALSE, 0, 0, FALSE, 7, 7, TIMESTAMP '2019-01-21 10:54:53.103122', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491762+00:00', 2, 0, 0, FALSE, 'atque', 'R$113,47', TIMESTAMP '2019-12-10 01:13:35.533243', 'R$25,42', TRUE, 0.775304543215458, 0, 'Rustic Frozen Soap', TRUE, 20, 15, 'yaivve1nlv21bxul', 'ex-dolore-eos', 'Good', TRUE, 'Beauty', 88.7769226863873, 9.37524485838378, 0.076236519998049604, 70, 24, TIMESTAMP '2019-08-24 03:47:19.566927', 1);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (2, FALSE, 0, 0, FALSE, 9, 10, TIMESTAMP '2019-03-29 13:12:54.844486', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491211+00:00', 11, 0, 0, FALSE, 'Nam voluptas possimus nostrum eligendi sed. Harum vel velit pariatur ratione repudiandae non. Et et consequuntur omnis. Et culpa dolorem labore animi enim doloremque perferendis.', 'R$56,90', TIMESTAMP '2020-03-26 20:41:45.493238', 'R$65,96', TRUE, 0.0662712841603306, 0, 'Incredible Rubber Shoes', TRUE, 32, 2, 'nx6jr0ufdeo6ck8t', 'qui-ad-illum', 'Good', TRUE, 'Industrial', 50.2950522817183, 8.78130616563433, 0.74001695482992425, 68, 18, TIMESTAMP '2019-08-24 13:52:52.846871', 3);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (11, FALSE, 0, 0, FALSE, 6, 3, TIMESTAMP '2018-11-26 10:14:44.704889', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491573+00:00', 7, 0, 0, FALSE, 'Esse aut et facilis quae.', 'R$12,27', TIMESTAMP '2020-06-11 04:22:39.422363', 'R$69,17', TRUE, 0.711266136128114, 0, 'Handmade Concrete Car', TRUE, 90, 11, 'ofgl8biasq5k3bb7', 'eius-nam-officiis', 'Good', TRUE, 'Electronics', 25.534857402339, 7.8651794222487, 0.84048852689586973, 96, 26, TIMESTAMP '2019-08-24 01:45:37.116703', 3);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (20, FALSE, 0, 0, FALSE, 4, 6, TIMESTAMP '2018-10-29 23:24:31.735969', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491955+00:00', 14, 0, 0, FALSE, 'magnam', 'R$39,66', TIMESTAMP '2020-01-10 16:10:28.839116', 'R$32,54', TRUE, 0.707606528749506, 0, 'Sleek Rubber Keyboard', TRUE, 38, 20, '498qwzdkaxvv1z7w', 'et-et-cupiditate', 'Good', TRUE, 'Shoes', 54.2632581453134, 9.61834487953146, 0.097855447837084275, 74, 24, TIMESTAMP '2019-08-24 05:29:20.499805', 3);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (28, FALSE, 0, 0, FALSE, 6, 10, TIMESTAMP '2019-01-05 18:48:20.926', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492173+00:00', 4, 0, 0, FALSE, 'fugiat', 'R$61,56', TIMESTAMP '2019-08-26 02:27:43.124414', 'R$51,40', TRUE, 0.361209527291921, 0, 'Awesome Metal Salad', TRUE, 38, 28, 'w1ddnt3girtovlgz', 'voluptatibus-eos-nesciunt', 'Good', TRUE, 'Baby', 66.3270205102521, 3.24259977007406, 0.050175691978156425, 66, 32, TIMESTAMP '2019-08-24 05:37:02.053838', 3);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (44, FALSE, 0, 0, FALSE, 5, 2, TIMESTAMP '2018-11-20 21:56:21.65904', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.49271+00:00', 19, 0, 0, FALSE, 'Nisi qui incidunt mollitia.', 'R$141,48', TIMESTAMP '2020-05-09 07:03:35.597199', 'R$38,68', TRUE, 0.261422734363667, 0, 'Gorgeous Soft Towels', TRUE, 16, 44, 'hawdleuldp38ql78', 'aspernatur-soluta-vero', 'Good', TRUE, 'Jewelery', 93.2771615187066, 6.42759244257006, 0.22945374913022562, 78, 2, TIMESTAMP '2019-08-24 09:19:14.828554', 3);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (3, FALSE, 0, 0, FALSE, 6, 8, TIMESTAMP '2019-05-17 15:26:17.512918', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491268+00:00', 17, 0, 0, FALSE, 'incidunt', 'R$64,46', TIMESTAMP '2020-02-08 03:18:15.903281', 'R$2,85', TRUE, 0.973070869675405, 0, 'Handmade Concrete Soap', TRUE, 10, 3, 'wk6ykhv287ix3lio', 'eum-ipsum-non', 'Good', TRUE, 'Industrial', 44.2303455175042, 3.46046903331786, 0.011263764934271465, 82, 28, TIMESTAMP '2019-08-24 05:04:28.765991', 4);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (35, FALSE, 0, 0, FALSE, 6, 5, TIMESTAMP '2018-10-26 15:50:02.874913', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492418+00:00', 10, 0, 0, FALSE, 'dolorem', 'R$174,43', TIMESTAMP '2020-07-30 20:25:22.697087', 'R$38,92', TRUE, 0.849852119036881, 0, 'Fantastic Granite Ball', TRUE, 80, 35, 'akzt8sdv95tm1myw', 'optio-officiis-ipsam', 'Good', TRUE, 'Outdoors', 90.9415151881713, 1.66170694942666, 0.80545211248353688, 74, 8, TIMESTAMP '2019-08-24 12:09:58.779616', 4);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (41, FALSE, 0, 0, FALSE, 1, 7, TIMESTAMP '2019-05-15 21:19:23.063746', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492587+00:00', 18, 0, 0, FALSE, 'dolores', 'R$24,02', TIMESTAMP '2020-05-09 07:16:17.721124', 'R$85,05', TRUE, 0.604540585821746, 0, 'Handmade Granite Chair', TRUE, 80, 41, 'sqwg13fu8zb8kde4', 'nesciunt-dolorem-recusandae', 'Good', TRUE, 'Automotive', 93.3293826381347, 7.95207493843142, 0.96025233527657217, 70, 38, TIMESTAMP '2019-08-23 18:05:25.934671', 4);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (23, FALSE, 0, 0, FALSE, 10, 9, TIMESTAMP '2019-08-10 17:44:35.994532', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492035+00:00', 10, 0, 0, FALSE, 'Quia quis aperiam aliquid fuga dolore qui sit voluptate.', 'R$99,08', TIMESTAMP '2020-03-31 05:53:29.979387', 'R$74,07', TRUE, 0.547555163292007, 0, 'Incredible Soft Pants', TRUE, 6, 23, 'nxl5gsfdw6qd8270', 'cupiditate-dolor-autem', 'Good', TRUE, 'Shoes', 88.5216192754552, 2.24780717503643, 0.031278286609462594, 70, 48, TIMESTAMP '2019-08-24 09:05:10.302862', 5);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (47, FALSE, 0, 0, FALSE, 2, 5, TIMESTAMP '2019-05-21 15:04:07.112978', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492805+00:00', 13, 0, 0, FALSE, 'eum', 'R$139,88', TIMESTAMP '2019-10-16 11:18:24.663998', 'R$68,41', TRUE, 0.16103878019426, 0, 'Practical Plastic Chips', TRUE, 22, 47, 'wwywdrl08sfwoyre', 'eos-asperiores-doloremque', 'Good', TRUE, 'Jewelery', 68.2362967022864, 1.37495625362497, 0.8378037767660822, 90, 26, TIMESTAMP '2019-08-24 12:14:55.423608', 19);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (25, FALSE, 0, 0, FALSE, 7, 10, TIMESTAMP '2019-01-29 16:25:24.108511', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492091+00:00', 3, 0, 0, FALSE, 'Tempora nostrum recusandae possimus illo.', 'R$199,45', TIMESTAMP '2019-12-31 16:09:56.422697', 'R$86,46', TRUE, 0.403879103904534, 0, 'Licensed Soft Ball', TRUE, 34, 25, 'ftlnlf2p4jbt8row', 'sed-ab-dolore', 'Good', TRUE, 'Movies', 20.9471249119132, 8.35711139177769, 0.37456848443232871, 82, 12, TIMESTAMP '2019-08-24 05:29:20.067758', 5);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (50, FALSE, 0, 0, FALSE, 6, 4, TIMESTAMP '2019-05-26 19:59:28.054051', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.49294+00:00', 19, 0, 0, FALSE, 'Et occaecati dolor possimus laudantium quia quis.
                Nostrum necessitatibus aut qui nihil beatae quia ipsum commodi mollitia.
                Sit possimus nobis laboriosam id illo amet.
                Qui saepe voluptas qui.
                Eaque rem provident voluptates dolorum.', 'R$36,76', TIMESTAMP '2019-11-28 09:50:49.74972', 'R$61,40', TRUE, 0.047755505911892, 0, 'Gorgeous Soft Fish', TRUE, 74, 50, 'v9230agtc9w0s2lf', 'in-consequatur-rerum', 'Good', TRUE, 'Electronics', 96.0666699316663, 3.71288714171987, 0.093095554547894532, 66, 4, TIMESTAMP '2019-08-24 17:18:22.774733', 5);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (30, FALSE, 0, 0, FALSE, 2, 2, TIMESTAMP '2019-04-01 20:26:03.871655', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492233+00:00', 14, 0, 0, FALSE, 'saepe', 'R$53,71', TIMESTAMP '2019-10-07 00:33:29.093335', 'R$11,96', TRUE, 0.4973722991987, 0, 'Practical Steel Computer', TRUE, 84, 30, '71zter6gn6p19u9p', 'excepturi-hic-rem', 'Good', TRUE, 'Computers', 37.488756253146, 4.50506360479866, 0.78021810100424016, 66, 2, TIMESTAMP '2019-08-24 04:19:06.878238', 6);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (48, FALSE, 0, 0, FALSE, 7, 7, TIMESTAMP '2019-05-15 13:02:25.91974', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492831+00:00', 6, 0, 0, FALSE, 'Voluptas aut explicabo rerum vitae illum omnis.
                Modi dolores non aut aut eveniet cum ipsa.', 'R$118,76', TIMESTAMP '2020-07-06 03:06:14.627209', 'R$4,30', TRUE, 0.453305085400727, 0, 'Intelligent Wooden Hat', TRUE, 8, 48, 'j81nxvlvej7or92k', 'magnam-qui-dolor', 'Good', TRUE, 'Beauty', 63.1280176635496, 2.75631591806017, 0.25170601264187414, 58, 4, TIMESTAMP '2019-08-25 02:15:47.265418', 7);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (45, FALSE, 0, 0, FALSE, 4, 7, TIMESTAMP '2018-12-21 22:02:12.896068', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492735+00:00', 12, 0, 0, FALSE, 'dolorum', 'R$100,44', TIMESTAMP '2020-03-04 17:35:51.625876', 'R$78,59', TRUE, 0.447468020695945, 0, 'Sleek Granite Ball', TRUE, 34, 45, 'zqoe0eucne1as47d', 'commodi-consequatur-ratione', 'Good', TRUE, 'Computers', 46.4538065001619, 0.740520735616107, 0.30747961360378173, 54, 2, TIMESTAMP '2019-08-24 06:55:12.609948', 8);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (5, FALSE, 0, 0, FALSE, 9, 1, TIMESTAMP '2019-02-20 05:18:47.204632', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491337+00:00', 16, 0, 0, FALSE, 'Incidunt cum illo magni delectus est.
                Accusamus rem quis ratione.', 'R$106,13', TIMESTAMP '2020-01-11 00:45:15.477994', 'R$86,18', TRUE, 0.451534998347766, 0, 'Generic Rubber Gloves', TRUE, 48, 5, '00ebk8w09kn0zck8', 'fuga-architecto-accusamus', 'Good', TRUE, 'Baby', 12.7275209001859, 0.0745595246900616, 0.5182823760054458, 94, 24, TIMESTAMP '2019-08-25 03:56:15.084247', 9);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (26, FALSE, 0, 0, FALSE, 7, 9, TIMESTAMP '2019-08-02 04:41:22.249531', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.49212+00:00', 3, 0, 0, FALSE, 'Aut autem alias voluptatibus saepe est.', 'R$179,43', TIMESTAMP '2019-12-09 04:44:58.394247', 'R$59,78', TRUE, 0.651229798631384, 0, 'Small Concrete Shirt', TRUE, 12, 26, 'fjp13zday9ogq73i', 'ipsam-perferendis-et', 'Good', TRUE, 'Books', 68.074377564748, 6.46655982195705, 0.70002879933455442, 74, 30, TIMESTAMP '2019-08-24 13:28:22.308584', 9);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (1, FALSE, 0, 0, FALSE, 8, 10, TIMESTAMP '2019-02-07 22:43:40.676141', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.490842+00:00', 1, 0, 0, FALSE, 'Debitis minus ullam est.', 'R$166,97', TIMESTAMP '2019-09-15 20:51:26.761966', 'R$24,20', TRUE, 0.221334681017946, 0, 'Handcrafted Wooden Computer', TRUE, 34, 1, 'f5puofelzgogkg75', 'quidem-et-atque', 'Good', TRUE, 'Kids', 30.6570036945199, 4.21790380227282, 0.29016060162808777, 64, 12, TIMESTAMP '2019-08-24 07:56:16.453807', 10);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (10, FALSE, 0, 0, FALSE, 7, 5, TIMESTAMP '2019-08-22 07:38:21.483856', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491521+00:00', 8, 0, 0, FALSE, 'Rerum soluta incidunt.
                Iusto at ut labore est provident ipsum et.
                Rerum quis est dolores sapiente.
                Totam rerum delectus voluptatem repellendus inventore consectetur perspiciatis voluptas tenetur.
                Consequatur accusantium cum dolor voluptas veritatis quos minima exercitationem voluptatem.', 'R$10,81', TIMESTAMP '2020-02-01 22:44:09.788291', 'R$25,78', TRUE, 0.179377491203778, 0, 'Ergonomic Concrete Salad', TRUE, 96, 10, 'swgumv3y5me6yqqx', 'minus-officiis-animi', 'Good', TRUE, 'Home', 11.3438711554482, 5.39084663865662, 0.38956307684516678, 54, 16, TIMESTAMP '2019-08-23 23:10:58.674116', 10);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (21, FALSE, 0, 0, FALSE, 7, 3, TIMESTAMP '2019-02-20 05:21:43.147376', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491977+00:00', 17, 0, 0, FALSE, 'doloremque', 'R$93,77', TIMESTAMP '2020-06-17 04:41:00.097543', 'R$12,82', TRUE, 0.72778210729723, 0, 'Unbranded Concrete Chair', TRUE, 28, 21, '991oeytdyhvscvq3', 'aut-quo-harum', 'Good', TRUE, 'Toys', 54.9337027384591, 4.02637250443286, 0.78809454328757456, 84, 18, TIMESTAMP '2019-08-24 04:43:42.894231', 10);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (42, FALSE, 0, 0, FALSE, 9, 2, TIMESTAMP '2019-08-06 22:10:10.076806', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492614+00:00', 14, 0, 0, FALSE, 'Eligendi quis harum voluptas perferendis pariatur. Ullam nobis quidem ut qui. Ut perferendis provident tenetur nihil. Vel sequi et aliquam magni odit velit iusto deserunt libero. Suscipit voluptatem veniam eos vel quia. Saepe voluptatum veritatis vero aut dolor dolores repellendus officia consequatur.', 'R$44,79', TIMESTAMP '2019-11-14 13:00:03.834175', 'R$81,55', TRUE, 0.349900769698387, 0, 'Tasty Rubber Ball', TRUE, 32, 42, '09fq7tjfyx3i2pjn', 'quos-voluptates-ipsum', 'Good', TRUE, 'Tools', 22.8435505753586, 7.82491395148678, 0.88285979576542029, 50, 32, TIMESTAMP '2019-08-25 10:19:15.689379', 10);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (33, FALSE, 0, 0, FALSE, 1, 6, TIMESTAMP '2018-09-07 02:07:42.767197', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.492353+00:00', 20, 0, 0, FALSE, 'Non est qui expedita blanditiis quidem.', 'R$153,80', TIMESTAMP '2020-02-09 11:05:35.78967', 'R$76,05', TRUE, 0.86730745056053, 0, 'Practical Cotton Tuna', TRUE, 62, 33, '1edo46moe634prj2', 'et-earum-dolore', 'Good', TRUE, 'Industrial', 4.21673762808402, 9.13562112447602, 0.36467019485527191, 66, 40, TIMESTAMP '2019-08-24 21:31:20.706682', 5);
INSERT INTO "StormyProduct" ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (22, FALSE, 0, 0, FALSE, 2, 3, TIMESTAMP '2019-03-08 16:13:50.341076', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 15:08:25.491999+00:00', 10, 0, 0, FALSE, 'Quasi quae non inventore ab. Fugiat rerum nihil autem optio nostrum sit. Quia vero ut.', 'R$186,22', TIMESTAMP '2020-08-21 12:01:32.019199', 'R$93,53', TRUE, 0.939835513448266, 0, 'Handmade Plastic Shoes', TRUE, 40, 22, 'auinfctao6zuhvqt', 'blanditiis-dolorem-molestiae', 'Good', TRUE, 'Garden', 84.6378441362818, 0.60182854095559, 0.038300707022799509, 66, 34, TIMESTAMP '2019-08-25 00:39:16.747782', 20);

INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (45, FALSE, TIMESTAMPTZ '2019-08-22 08:18:55.886117-03:00', 2, 20, 28);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (39, FALSE, TIMESTAMPTZ '2019-08-07 05:41:40.215285-03:00', 2, 5, 27);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (40, FALSE, TIMESTAMPTZ '2019-08-21 05:43:45.999841-03:00', 2, 27, 23);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (42, FALSE, TIMESTAMPTZ '2019-08-02 10:36:59.233457-03:00', 2, 27, 1);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (14, FALSE, TIMESTAMPTZ '2019-08-05 21:36:26.935043-03:00', 2, 36, 17);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (23, FALSE, TIMESTAMPTZ '2019-08-05 01:14:01.826931-03:00', 2, 36, 23);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (29, FALSE, TIMESTAMPTZ '2019-08-08 06:26:37.215432-03:00', 2, 36, 32);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (43, FALSE, TIMESTAMPTZ '2019-08-03 01:32:11.643816-03:00', 2, 36, 1);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (11, FALSE, TIMESTAMPTZ '2019-08-22 19:06:17.474775-03:00', 2, 48, 43);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (20, FALSE, TIMESTAMPTZ '2019-08-08 03:20:15.268405-03:00', 2, 43, 50);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (30, FALSE, TIMESTAMPTZ '2019-08-02 22:03:13.169231-03:00', 2, 16, 29);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (36, FALSE, TIMESTAMPTZ '2019-08-13 04:13:07.531074-03:00', 2, 34, 23);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (15, FALSE, TIMESTAMPTZ '2019-08-04 00:40:08.374728-03:00', 2, 4, 38);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (25, FALSE, TIMESTAMPTZ '2019-08-07 11:45:26.361198-03:00', 2, 45, 38);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (8, FALSE, TIMESTAMPTZ '2019-08-03 08:43:58.783411-03:00', 2, 3, 40);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (49, FALSE, TIMESTAMPTZ '2019-08-09 13:22:51.546071-03:00', 2, 40, 40);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (50, FALSE, TIMESTAMPTZ '2019-08-09 02:12:18.851385-03:00', 2, 15, 40);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (46, FALSE, TIMESTAMPTZ '2019-08-23 03:17:42.158073-03:00', 2, 12, 2);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (2, FALSE, TIMESTAMPTZ '2019-08-13 18:32:57.791278-03:00', 2, 14, 34);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (9, FALSE, TIMESTAMPTZ '2019-08-10 03:52:08.172128-03:00', 2, 14, 40);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (10, FALSE, TIMESTAMPTZ '2019-08-04 01:07:04.759016-03:00', 2, 38, 14);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (17, FALSE, TIMESTAMPTZ '2019-08-04 00:56:58.187201-03:00', 2, 41, 31);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (21, FALSE, TIMESTAMPTZ '2019-08-02 18:43:10.268097-03:00', 2, 27, 4);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (19, FALSE, TIMESTAMPTZ '2019-08-11 21:38:19.37935-03:00', 2, 50, 27);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (37, FALSE, TIMESTAMPTZ '2019-08-18 12:46:37.612015-03:00', 2, 18, 49);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (18, FALSE, TIMESTAMPTZ '2019-08-15 14:14:28.982117-03:00', 2, 17, 50);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (12, FALSE, TIMESTAMPTZ '2019-08-04 08:41:50.367423-03:00', 2, 28, 44);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (3, FALSE, TIMESTAMPTZ '2019-08-15 23:36:23.202747-03:00', 2, 41, 23);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (7, FALSE, TIMESTAMPTZ '2019-08-08 21:26:49.504387-03:00', 2, 23, 25);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (26, FALSE, TIMESTAMPTZ '2019-08-20 13:01:17.423382-03:00', 2, 2, 50);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (1, FALSE, TIMESTAMPTZ '2019-08-03 12:21:52.262678-03:00', 2, 30, 23);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (44, FALSE, TIMESTAMPTZ '2019-08-10 18:09:09.92816-03:00', 2, 45, 20);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (32, FALSE, TIMESTAMPTZ '2019-07-31 00:18:49.207026-03:00', 2, 44, 10);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (47, FALSE, TIMESTAMPTZ '2019-08-11 13:50:03.881043-03:00', 2, 10, 2);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (6, FALSE, TIMESTAMPTZ '2019-08-13 02:46:21.361257-03:00', 2, 16, 33);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (31, FALSE, TIMESTAMPTZ '2019-08-16 04:06:53.801804-03:00', 2, 20, 16);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (38, FALSE, TIMESTAMPTZ '2019-08-10 17:37:20.810553-03:00', 2, 31, 35);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (4, FALSE, TIMESTAMPTZ '2019-08-18 13:16:24.617898-03:00', 2, 3, 32);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (34, FALSE, TIMESTAMPTZ '2019-08-08 10:41:28.188641-03:00', 2, 32, 13);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (48, FALSE, TIMESTAMPTZ '2019-08-20 04:10:28.010593-03:00', 2, 32, 48);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (16, FALSE, TIMESTAMPTZ '2019-08-14 09:48:22.838449-03:00', 2, 49, 1);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (35, FALSE, TIMESTAMPTZ '2019-08-10 10:50:13.377146-03:00', 2, 49, 21);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (13, FALSE, TIMESTAMPTZ '2019-08-23 05:26:07.191607-03:00', 2, 8, 49);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (24, FALSE, TIMESTAMPTZ '2019-08-03 00:57:22.305862-03:00', 2, 21, 8);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (22, FALSE, TIMESTAMPTZ '2019-08-19 20:12:04.074457-03:00', 2, 9, 6);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (27, FALSE, TIMESTAMPTZ '2019-08-23 12:32:00.231507-03:00', 2, 9, 16);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (5, FALSE, TIMESTAMPTZ '2019-08-11 10:21:26.837541-03:00', 2, 1, 37);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (41, FALSE, TIMESTAMPTZ '2019-08-12 12:13:56.730769-03:00', 2, 46, 21);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (33, FALSE, TIMESTAMPTZ '2019-08-17 13:41:41.786276-03:00', 2, 32, 45);
INSERT INTO "ProductLink" ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (28, FALSE, TIMESTAMPTZ '2019-08-04 22:18:12.122547-03:00', 2, 50, 47);

CREATE INDEX "IX_AspNetRoleClaims_RoleId" ON "AspNetRoleClaims" ("RoleId");

CREATE UNIQUE INDEX "RoleNameIndex" ON "AspNetRoles" ("NormalizedName");

CREATE INDEX "IX_AspNetUserClaims_UserId" ON "AspNetUserClaims" ("UserId");

CREATE INDEX "IX_AspNetUserLogins_UserId" ON "AspNetUserLogins" ("UserId");

CREATE INDEX "IX_AspNetUserRoles_RoleId" ON "AspNetUserRoles" ("RoleId");

CREATE INDEX "EmailIndex" ON "AspNetUsers" ("NormalizedEmail");

CREATE UNIQUE INDEX "UserNameIndex" ON "AspNetUsers" ("NormalizedUserName");

CREATE INDEX "IX_Category_ParentId" ON "Category" ("ParentId");

CREATE INDEX "IX_Entity_EntityTypeId" ON "Entity" ("EntityTypeId");

CREATE INDEX "IX_Media_StormyProductId" ON "Media" ("StormyProductId");

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

CREATE INDEX "IX_Shipment_StormyOrderId" ON "Shipment" ("StormyOrderId");

CREATE INDEX "IX_StormyCustomer_DefaultBillingAddressId" ON "StormyCustomer" ("DefaultBillingAddressId");

CREATE INDEX "IX_StormyCustomer_DefaultShippingAddressId" ON "StormyCustomer" ("DefaultShippingAddressId");

CREATE INDEX "IX_StormyOrder_CustomerId" ON "StormyOrder" ("CustomerId");

CREATE INDEX "IX_StormyOrder_ShippingAddressId" ON "StormyOrder" ("ShippingAddressId");

CREATE INDEX "IX_StormyProduct_BrandId" ON "StormyProduct" ("BrandId");

CREATE INDEX "IX_StormyProduct_CategoryId" ON "StormyProduct" ("CategoryId");

CREATE INDEX "IX_StormyProduct_MediaId" ON "StormyProduct" ("MediaId");

CREATE INDEX "IX_StormyProduct_VendorId" ON "StormyProduct" ("VendorId");

CREATE INDEX "IX_StormyVendor_AddressId1" ON "StormyVendor" ("AddressId1");

ALTER TABLE "StormyProduct" ADD CONSTRAINT "FK_StormyProduct_Media_MediaId" FOREIGN KEY ("MediaId") REFERENCES "Media" ("Id") ON DELETE CASCADE;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20190824150826_InitialCreate', '2.2.6-servicing-10079');

