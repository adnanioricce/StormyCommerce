CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

CREATE TABLE `Address` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Street" longtext NULL,
    "FirstAddress" longtext NULL,
    "SecondAddress" longtext NULL,
    "City" longtext NULL,
    "State" longtext NULL,
    "PostalCode" longtext NULL,
    "Number" longtext NULL,
    "Complement" longtext NULL,
    "PhoneNumber" longtext NULL,
    "Country" longtext NULL,
    CONSTRAINT "PK_Address" PRIMARY KEY ("Id")
);

CREATE TABLE `ApplicationUser` (
    "Id" longtext NOT NULL,
    "UserName" longtext NULL,
    "NormalizedUserName" longtext NULL,
    "Email" longtext NULL,
    "NormalizedEmail" longtext NULL,
    "EmailConfirmed" boolean NOT NULL,
    "PasswordHash" longtext NULL,
    "SecurityStamp" longtext NULL,
    "ConcurrencyStamp" longtext NULL,
    "PhoneNumber" longtext NULL,
    "PhoneNumberConfirmed" boolean NOT NULL,
    "TwoFactorEnabled" boolean NOT NULL,
    "LockoutEnd" datetime NULL,
    "LockoutEnabled" boolean NOT NULL,
    "AccessFailedCount" integer NOT NULL,
    CONSTRAINT "PK_ApplicationUser" PRIMARY KEY ("Id")
);

CREATE TABLE `AppSetting` (
    "Id" longtext NOT NULL,
    "Value" character varying(450) NULL,
    "Module" character varying(450) NULL,
    "IsVisibleInCommonSettingPage" boolean NOT NULL,
    CONSTRAINT "PK_AppSetting" PRIMARY KEY ("Id")
);

CREATE TABLE `AspNetRoles` (
    "Id" longtext NOT NULL,
    "Name" character varying(256) NULL,
    "NormalizedName" character varying(256) NULL,
    "ConcurrencyStamp" longtext NULL,
    CONSTRAINT "PK_AspNetRoles" PRIMARY KEY ("Id")
);

CREATE TABLE `AspNetUsers` (
    "Id" longtext NOT NULL,
    "UserName" character varying(256) NULL,
    "NormalizedUserName" character varying(256) NULL,
    "Email" character varying(256) NULL,
    "NormalizedEmail" character varying(256) NULL,
    "EmailConfirmed" boolean NOT NULL,
    "PasswordHash" longtext NULL,
    "SecurityStamp" longtext NULL,
    "ConcurrencyStamp" longtext NULL,
    "PhoneNumber" longtext NULL,
    "PhoneNumberConfirmed" boolean NOT NULL,
    "TwoFactorEnabled" boolean NOT NULL,
    "LockoutEnd" datetime NULL,
    "LockoutEnabled" boolean NOT NULL,
    "AccessFailedCount" integer NOT NULL,
    CONSTRAINT "PK_AspNetUsers" PRIMARY KEY ("Id")
);

CREATE TABLE `Brand` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" longtext NULL,
    "Slug" character varying(450) NOT NULL,
    "Description" longtext NULL,
    "Website" longtext NULL,
    "LogoImage" longtext NULL,
    CONSTRAINT "PK_Brand" PRIMARY KEY ("Id")
);

CREATE TABLE `Category` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" character varying(450) NOT NULL,
    "Slug" character varying(450) NOT NULL,
    "MetaTitle" character varying(450) NULL,
    "MetaKeywords" character varying(450) NULL,
    "MetaDescription" longtext NULL,
    "Description" character varying(450) NOT NULL,
    "DisplayOrder" integer NOT NULL,
    "IsPublished" boolean NOT NULL,
    "IncludeInMenu" boolean NOT NULL,
    "ParentId" bigint NULL,
    "ThumbnailImageUrl" longtext NULL,
    CONSTRAINT "PK_Category" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Category_Category_ParentId" FOREIGN KEY ("ParentId") REFERENCES `Category` ("Id") ON DELETE RESTRICT
);

CREATE TABLE `EntityType` (
    "Id" character varying(450) NOT NULL,
    "IsMenuable" boolean NOT NULL,
    "AreaName" character varying(450) NULL,
    "RoutingController" character varying(450) NULL,
    "RoutingAction" character varying(450) NULL,
    "IsDeleted" boolean NOT NULL,
    CONSTRAINT "PK_EntityType" PRIMARY KEY ("Id")
);

CREATE TABLE `ProductAttributeGroup` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" character varying(450) NOT NULL,
    CONSTRAINT "PK_ProductAttributeGroup" PRIMARY KEY ("Id")
);

CREATE TABLE `ProductOption` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" character varying(450) NOT NULL,
    CONSTRAINT "PK_ProductOption" PRIMARY KEY ("Id")
);

CREATE TABLE `ProductTemplate` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Name" longtext NULL,
    CONSTRAINT "PK_ProductTemplate" PRIMARY KEY ("Id")
);

CREATE TABLE `StormyCustomer` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "UserId" longtext NULL,
    "CPF" character varying(11) NULL,
    "DefaultShippingAddressId" bigint NULL,
    "DefaultBillingAddressId" bigint NULL,
    "UserName" longtext NULL,
    "FullName" character varying(450) NULL,
    "Email" longtext NULL,
    "CreatedOn" datetime NOT NULL,
    CONSTRAINT "PK_StormyCustomer" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyCustomer_Address_DefaultBillingAddressId" FOREIGN KEY ("DefaultBillingAddressId") REFERENCES `Address` ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyCustomer_Address_DefaultShippingAddressId" FOREIGN KEY ("DefaultShippingAddressId") REFERENCES `Address` ("Id") ON DELETE RESTRICT
);

CREATE TABLE `StormyVendor` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "CompanyName" longtext NULL,
    "ContactTitle" longtext NULL,
    "AddressId" integer NOT NULL,
    "AddressId1" bigint NULL,
    "Phone" longtext NULL,
    "Email" longtext NULL,
    "WebSite" longtext NULL,
    "TypeGoods" longtext NULL,
    "SizeUrl" longtext NULL,
    "Logo" longtext NULL,
    "Note" longtext NULL,
    CONSTRAINT "PK_StormyVendor" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyVendor_Address_AddressId1" FOREIGN KEY ("AddressId1") REFERENCES `Address` ("Id") ON DELETE RESTRICT
);

CREATE TABLE `AspNetRoleClaims` (
    "Id" serial NOT NULL,
    "RoleId" longtext NOT NULL,
    "ClaimType" longtext NULL,
    "ClaimValue" longtext NULL,
    CONSTRAINT "PK_AspNetRoleClaims" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_AspNetRoleClaims_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES `AspNetRoles` ("Id") ON DELETE CASCADE
);

CREATE TABLE `AspNetUserClaims` (
    "Id" serial NOT NULL,
    "UserId" longtext NOT NULL,
    "ClaimType" longtext NULL,
    "ClaimValue" longtext NULL,
    CONSTRAINT "PK_AspNetUserClaims" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_AspNetUserClaims_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES `AspNetUsers` ("Id") ON DELETE CASCADE
);

CREATE TABLE `AspNetUserLogins` (
    "LoginProvider" longtext NOT NULL,
    "ProviderKey" longtext NOT NULL,
    "ProviderDisplayName" longtext NULL,
    "UserId" longtext NOT NULL,
    CONSTRAINT "PK_AspNetUserLogins" PRIMARY KEY ("LoginProvider", "ProviderKey"),
    CONSTRAINT "FK_AspNetUserLogins_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES `AspNetUsers` ("Id") ON DELETE CASCADE
);

CREATE TABLE `AspNetUserRoles` (
    "UserId" longtext NOT NULL,
    "RoleId" longtext NOT NULL,
    CONSTRAINT "PK_AspNetUserRoles" PRIMARY KEY ("UserId", "RoleId"),
    CONSTRAINT "FK_AspNetUserRoles_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES `AspNetRoles` ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_AspNetUserRoles_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES `AspNetUsers` ("Id") ON DELETE CASCADE
);

CREATE TABLE `AspNetUserTokens` (
    "UserId" longtext NOT NULL,
    "LoginProvider" longtext NOT NULL,
    "Name" longtext NOT NULL,
    "Value" longtext NULL,
    CONSTRAINT "PK_AspNetUserTokens" PRIMARY KEY ("UserId", "LoginProvider", "Name"),
    CONSTRAINT "FK_AspNetUserTokens_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES `AspNetUsers` ("Id") ON DELETE CASCADE
);

CREATE TABLE `Entity` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Slug" character varying(450) NOT NULL,
    "Name" character varying(450) NOT NULL,
    "EntityId" bigint NOT NULL,
    "EntityTypeId" character varying(450) NOT NULL,
    CONSTRAINT "PK_Entity" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Entity_EntityType_EntityTypeId" FOREIGN KEY ("EntityTypeId") REFERENCES `EntityType` ("Id") ON DELETE CASCADE
);

CREATE TABLE `StormyOrder` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "OrderUniqueKey" uuid NOT NULL,
    "CustomerId" bigint NOT NULL,
    "PaymentId" bigint NOT NULL,
    "PickUpInStore" boolean NOT NULL,
    "IsCancelled" boolean NOT NULL,
    "ShippingMethod" longtext NULL,
    "PaymentMethod" character varying(450) NOT NULL,
    "TrackNumber" longtext NULL,
    "Note" character varying(1000) NULL,
    "Comment" longtext NULL,
    "Discount" numeric NOT NULL,
    "Tax" numeric NOT NULL,
    "TotalWeight" numeric NOT NULL,
    "TotalPrice" numeric NOT NULL,
    "DeliveryCost" numeric NOT NULL,
    "ShippingAddressId" bigint NULL,
    "OrderDate" datetime NOT NULL,
    "RequiredDate" datetime NOT NULL,
    "ShippedDate" datetime NOT NULL,
    "DeliveryDate" datetime NOT NULL,
    "PaymentDate" datetime NULL,
    "Status" integer NOT NULL,
    "ShippingStatus" integer NOT NULL,
    CONSTRAINT "PK_StormyOrder" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyOrder_StormyCustomer_CustomerId" FOREIGN KEY ("CustomerId") REFERENCES `StormyCustomer` ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyOrder_Address_ShippingAddressId" FOREIGN KEY ("ShippingAddressId") REFERENCES `Address` ("Id") ON DELETE RESTRICT
);

CREATE TABLE `Payment` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "StormyOrderId" bigint NOT NULL,
    "CreatedOn" datetime NOT NULL,
    "Amount" numeric NOT NULL,
    "PaymentFee" numeric NOT NULL,
    "PaymentMethod" longtext NULL,
    "GatewayTransactionId" longtext NULL,
    "PaymentStatus" integer NOT NULL,
    "FailureMessage" longtext NULL,
    CONSTRAINT "PK_Payment" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Payment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES `StormyOrder` ("Id") ON DELETE CASCADE
);

CREATE TABLE `Shipment` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "TrackNumber" longtext NULL,
    "TotalWeight" numeric NOT NULL,
    "CreatedOn" datetime NOT NULL,
    "ShippedDate" datetime NULL,
    "DeliveryDate" datetime NULL,
    "Comment" longtext NULL,
    "Price" numeric NOT NULL,
    "DeliveryCost" numeric NOT NULL,
    "StormyOrderId" bigint NULL,
    CONSTRAINT "PK_Shipment" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Shipment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES `StormyOrder` ("Id") ON DELETE RESTRICT
);

CREATE TABLE `StormyProduct` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "SKU" longtext NOT NULL,
    "ProductName" character varying(400) NOT NULL,
    "Slug" longtext NULL,
    "BrandId" bigint NOT NULL,
    "MediaId" bigint NOT NULL,
    "VendorId" bigint NOT NULL,
    "CategoryId" bigint NOT NULL,
    "ProductLinksId" bigint NOT NULL,
    "TypeName" longtext NOT NULL,
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
    "Note" longtext NULL,
    "Price" longtext NULL,
    "OldPrice" longtext NULL,
    "HasDiscountApplied" boolean NOT NULL,
    "Published" boolean NOT NULL,
    "Status" longtext NOT NULL,
    "NotReturnable" boolean NOT NULL,
    "AvailableForPreorder" boolean NOT NULL,
    "ProductCost" numeric NOT NULL,
    "PreOrderAvailabilityStartDate" datetime NULL,
    "CreatedAt" datetime NOT NULL,
    "UpdatedOnUtc" datetime NOT NULL,
    "AllowCustomerReview" boolean NOT NULL,
    "ApprovedRatingSum" integer NOT NULL,
    "NotApprovedRatingSum" integer NOT NULL,
    "ApprovedTotalReviews" integer NOT NULL,
    "NotApprovedTotalReviews" integer NOT NULL,
    CONSTRAINT "PK_StormyProduct" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_StormyProduct_Brand_BrandId" FOREIGN KEY ("BrandId") REFERENCES `Brand` ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyProduct_Category_CategoryId" FOREIGN KEY ("CategoryId") REFERENCES `Category` ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyProduct_StormyVendor_VendorId" FOREIGN KEY ("VendorId") REFERENCES `StormyVendor` ("Id") ON DELETE CASCADE
);

CREATE TABLE `Media` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Caption" longtext NULL,
    "FileSize" integer NOT NULL,
    "FileName" longtext NULL,
    "MediaType" integer NOT NULL,
    "SeoFileName" longtext NULL,
    "StormyProductId" bigint NULL,
    CONSTRAINT "PK_Media" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Media_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES `StormyProduct` ("Id") ON DELETE RESTRICT
);

CREATE TABLE `OrderItem` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "Quantity" integer NOT NULL,
    "Price" longtext NULL,
    "StormyProductId" bigint NOT NULL,
    "StormyOrderId" bigint NOT NULL,
    "ProductName" longtext NULL,
    CONSTRAINT "PK_OrderItem" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_OrderItem_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES `StormyOrder` ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_OrderItem_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES `StormyProduct` ("Id") ON DELETE CASCADE
);

CREATE TABLE `ProductAttribute` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "GroupId" bigint NOT NULL,
    "Name" longtext NULL,
    "StormyProductId" bigint NULL,
    CONSTRAINT "PK_ProductAttribute" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductAttribute_ProductAttributeGroup_GroupId" FOREIGN KEY ("GroupId") REFERENCES `ProductAttributeGroup` ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductAttribute_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES `StormyProduct` ("Id") ON DELETE RESTRICT
);

CREATE TABLE `ProductLink` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "ProductId" bigint NOT NULL,
    "LinkedProductId" bigint NOT NULL,
    "LinkType" integer NOT NULL,
    CONSTRAINT "PK_ProductLink" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductLink_StormyProduct_LinkedProductId" FOREIGN KEY ("LinkedProductId") REFERENCES `StormyProduct` ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_ProductLink_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES `StormyProduct` ("Id") ON DELETE RESTRICT
);

CREATE TABLE `ProductOptionValue` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "OptionId" bigint NOT NULL,
    "ProductId" bigint NOT NULL,
    "Value" character varying(450) NULL,
    "DisplayType" character varying(450) NULL,
    "SortIndex" integer NOT NULL,
    CONSTRAINT "PK_ProductOptionValue" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductOptionValue_ProductOption_OptionId" FOREIGN KEY ("OptionId") REFERENCES `ProductOption` ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductOptionValue_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES `StormyProduct` ("Id") ON DELETE CASCADE
);

CREATE TABLE `ProductAttributeValue` (
    "Id" bigserial NOT NULL,
    "LastModified" datetime NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "AttributeId" bigint NOT NULL,
    "ProductId" bigint NOT NULL,
    "Value" longtext NULL,
    CONSTRAINT "PK_ProductAttributeValue" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProductAttributeValue_ProductAttribute_AttributeId" FOREIGN KEY ("AttributeId") REFERENCES `ProductAttribute` ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductAttributeValue_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES `StormyProduct` ("Id") ON DELETE CASCADE
);

CREATE TABLE `ProductTemplateProductAttribute` (
    "ProductTemplateId" bigint NOT NULL,
    "ProductAttributeId" bigint NOT NULL,
    CONSTRAINT "PK_ProductTemplateProductAttribute" PRIMARY KEY ("ProductTemplateId", "ProductAttributeId"),
    CONSTRAINT "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAtt~" FOREIGN KEY ("ProductAttributeId") REFERENCES `ProductAttribute` ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemp~" FOREIGN KEY ("ProductTemplateId") REFERENCES `ProductTemplate` ("Id") ON DELETE RESTRICT
);

INSERT INTO `Address` ("Id", "City", "Complement", "Country", "FirstAddress", "IsDeleted", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street")
VALUES (5, 'Alexandredo Norte', NULL, NULL, 'Salvador Viela', FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.139359+00:00', '0311', '(90) 92314-5920', '10296-489', 'Sobrado 04', 'Alagoas', '42514 Sílvia Travessa');
INSERT INTO `Address` ("Id", "City", "Complement", "Country", "FirstAddress", "IsDeleted", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street")
VALUES (4, 'Nova Yuride Nossa Senhora', NULL, NULL, 'Felícia Ponte', FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.139319+00:00', '3559', '+55 (84) 5500-4458', '25457-334', 'Apto. 069', 'Mato Grosso', '23189 Karla Alameda');
INSERT INTO `Address` ("Id", "City", "Complement", "Country", "FirstAddress", "IsDeleted", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street")
VALUES (3, 'Batistado Sul', NULL, NULL, 'Oliveira Travessa', FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.13928+00:00', '1268', '(40) 3460-2034', '70963', 'Sobrado 01', 'Amapá', '754 Costa Avenida');
INSERT INTO `Address` ("Id", "City", "Complement", "Country", "FirstAddress", "IsDeleted", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street")
VALUES (2, 'Moraesde Nossa Senhora', NULL, NULL, 'Ricardo Alameda', FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.139197+00:00', '2982', '+55 (94) 6479-0505', '10608-529', 'Casa 5', 'Amazonas', '94069 Tertuliano Ponte');
INSERT INTO `Address` ("Id", "City", "Complement", "Country", "FirstAddress", "IsDeleted", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street")
VALUES (1, 'Mariado Norte', NULL, NULL, 'Franco Rua', FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.137136+00:00', '173', '(01) 3062-4998', '07976', 'Quadra 07', 'Maranhão', '4635 Silas Avenida');

INSERT INTO `Brand` ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (10, 'Illo tenetur dolorum similique sed et dolor facere ut necessitatibus.', FALSE, TIMESTAMPTZ '2019-08-03 21:44:27.82344-03:00', 'https://picsum.photos/640/480/?image=973', 'Braga S.A.', 'molestias-eum-voluptatem', 'raul.br');
INSERT INTO `Brand` ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (9, 'Enim repellendus dolorem eos provident dolores. Dolore autem accusantium. Voluptas accusamus esse.', FALSE, TIMESTAMPTZ '2019-08-20 16:24:51.675269-03:00', 'https://picsum.photos/640/480/?image=155', 'Souza, Martins and Barros', 'quidem-nihil-ipsam', 'júlio césar.br');
INSERT INTO `Brand` ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (8, 'Officiis reiciendis aut ut.
                Recusandae aut sit fugiat reprehenderit ea consequatur aspernatur.', FALSE, TIMESTAMPTZ '2019-08-05 18:43:33.434991-03:00', 'https://picsum.photos/640/480/?image=370', 'Franco - Santos', 'culpa-beatae-ut', 'fabrícia.br');
INSERT INTO `Brand` ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (7, 'Odio ut ipsam perferendis rerum aperiam quis.
                Ut fuga aut consequatur nesciunt.
                Necessitatibus enim autem vero repellendus.
                Consequatur in sunt itaque pariatur aperiam et sint.
                Neque ut dolor voluptas excepturi animi aut magnam.', FALSE, TIMESTAMPTZ '2019-08-10 09:39:20.456098-03:00', 'https://picsum.photos/640/480/?image=137', 'Santos Comércio', 'illum-iure-eaque', 'larissa.com');
INSERT INTO `Brand` ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (6, 'Consequatur libero sequi.', FALSE, TIMESTAMPTZ '2019-08-19 10:08:43.279784-03:00', 'https://picsum.photos/640/480/?image=935', 'Santos S.A.', 'corporis-doloremque-adipisci', 'alessandro.net');
INSERT INTO `Brand` ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (1, 'Deserunt dolores possimus eius.
                Iure ea ab enim cupiditate animi a ut dolorem.
                Nihil distinctio doloribus vitae sequi accusantium non.', FALSE, TIMESTAMPTZ '2019-08-14 01:42:01.652518-03:00', 'https://picsum.photos/640/480/?image=252', 'Martins Comércio', 'autem-esse-quas', 'lorena.info');
INSERT INTO `Brand` ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (2, 'Eum voluptate nihil quia non quo. Corrupti dolorem aut quibusdam veritatis at et tempore et autem. Iste magni nulla quia et. Optio ipsam esse aut illo cum vitae saepe dolor asperiores. Culpa a quos iure sint est quos.', FALSE, TIMESTAMPTZ '2019-08-16 04:02:52.338277-03:00', 'https://picsum.photos/640/480/?image=1062', 'Souza - Melo', 'ab-neque-harum', 'célia.br');
INSERT INTO `Brand` ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (3, 'Illo consequatur harum labore.
                Voluptatem ipsa voluptate corporis odio velit.
                Ea perferendis amet dolorem voluptates.', FALSE, TIMESTAMPTZ '2019-08-08 00:58:13.066214-03:00', 'https://picsum.photos/640/480/?image=62', 'Carvalho - Moraes', 'maxime-saepe-inventore', 'márcia.biz');
INSERT INTO `Brand` ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (4, 'Nemo laborum ipsum.
                Iusto est aperiam illo delectus vero maxime voluptas culpa qui.
                Quidem magnam quasi praesentium neque.
                Impedit voluptates quas minus provident.
                Facilis porro ut quod alias dolorem sed et et.
                Quo dolorem expedita nemo suscipit voluptatibus.', FALSE, TIMESTAMPTZ '2019-08-17 10:10:28.324145-03:00', 'https://picsum.photos/640/480/?image=1069', 'Pereira - Braga', 'sequi-distinctio-fugit', 'roberta.org');
INSERT INTO `Brand` ("Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website")
VALUES (5, 'in', FALSE, TIMESTAMPTZ '2019-08-19 12:24:34.460974-03:00', 'https://picsum.photos/640/480/?image=951', 'Oliveira Comércio', 'suscipit-sed-voluptatem', 'sirineu.biz');

INSERT INTO `Category` ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (1, 'Maiores aspernatur amet minus tenetur beatae reprehenderit aliquam nostrum.
                Iusto consequatur consequuntur nulla velit unde dolor numquam voluptatem.
                Ea officiis est necessitatibus debitis non accusantium saepe.
                Voluptatem eius et numquam quaerat ipsum.
                Dolor quod ad atque voluptas ipsum est deserunt.', 0, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-22 19:04:40.612138-03:00', 'Exercitationem ipsum deleniti.
                Vero minima hic esse fugit voluptate ullam.
                Maxime illo dolores voluptas doloremque sunt recusandae temporibus et.', NULL, NULL, 'Grocery', NULL, 'cum-cum-consequatur', 'http://lorempixel.com/640/480/fashion');
INSERT INTO `Category` ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (9, 'Tempore totam sint aliquam consequatur sit iure sunt ipsam aut. Possimus vero enim autem voluptatem repellat. Voluptates ut consequatur et sunt nemo. Possimus eveniet nesciunt enim ut.', 8, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-17 00:41:26.64605-03:00', 'Quo praesentium repellendus ut sunt modi qui voluptatem alias.', NULL, NULL, 'Electronics', NULL, 'libero-est-quibusdam', 'http://lorempixel.com/640/480/fashion');
INSERT INTO `Category` ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (8, 'Ut dolor velit sunt. Commodi non quae aperiam laboriosam autem. Labore qui ipsum.', 7, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-20 19:11:56.11699-03:00', 'Architecto accusamus voluptatum expedita hic non est qui. Perferendis autem libero voluptatem doloribus unde molestiae sunt cum adipisci. Blanditiis cumque est voluptatum amet ipsa. Et molestiae aut nihil voluptatum voluptates.', NULL, NULL, 'Clothing', NULL, 'nihil-eum-ut', 'http://lorempixel.com/640/480/fashion');
INSERT INTO `Category` ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (7, 'Ipsa aut dolorem pariatur fugit odit perspiciatis nostrum. Velit ut saepe vel ut est sit consequuntur. Natus enim qui eos consequatur repellat aut sit. Aut saepe quis rerum eius vero rem saepe.', 6, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-12 10:06:40.247881-03:00', 'Praesentium est asperiores vero et dolores cupiditate.
                Vel voluptas commodi dolorem.', NULL, NULL, 'Electronics', NULL, 'reprehenderit-officiis-molestiae', 'http://lorempixel.com/640/480/fashion');
INSERT INTO `Category` ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (6, 'Consequatur minus vero iste autem.
                Cupiditate est aut reprehenderit aut iure quia voluptatem non recusandae.
                Quaerat reprehenderit sunt quo sed ratione porro unde autem.', 5, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-10 06:22:47.216614-03:00', 'consectetur', NULL, NULL, 'Beauty', NULL, 'doloremque-eos-et', 'http://lorempixel.com/640/480/fashion');
INSERT INTO `Category` ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (5, 'Et inventore quia. A repellendus atque voluptas explicabo rem officia nobis. Molestiae eius labore non perspiciatis consectetur eum quia aliquid. Voluptas numquam ut tempore sunt. Nihil voluptatem enim.', 4, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-04 21:12:21.065182-03:00', 'Nam a nulla quidem eum et nobis praesentium et voluptatum.', NULL, NULL, 'Beauty', NULL, 'non-accusantium-sed', 'http://lorempixel.com/640/480/fashion');
INSERT INTO `Category` ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (4, 'recusandae', 3, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-18 00:29:32.572466-03:00', 'Autem temporibus iusto dolorem.
                Saepe rerum quibusdam impedit eaque.', NULL, NULL, 'Grocery', NULL, 'delectus-consequatur-possimus', 'http://lorempixel.com/640/480/fashion');
INSERT INTO `Category` ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (3, 'Molestiae aut sapiente quae dolorem asperiores ratione et.', 2, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-21 22:50:29.519893-03:00', 'Enim ducimus nam incidunt.
                Eum quidem non unde vero quisquam.
                Repellat ut voluptate qui sit et repellat voluptatum dolore.
                Quia molestiae enim rerum.', NULL, NULL, 'Movies', NULL, 'ut-autem-sed', 'http://lorempixel.com/640/480/fashion');
INSERT INTO `Category` ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (2, 'Aspernatur aspernatur ad occaecati. Qui quisquam aut quo. Eius voluptatem voluptas illo voluptas. Rerum non molestiae enim voluptate maxime sit cum sunt consectetur. Dolores fugit fugit sint et reiciendis tempora. Enim voluptatem suscipit.', 1, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-01 23:05:14.843994-03:00', 'Facere voluptatem non porro cupiditate accusantium dolorum ut corrupti.
                Velit aliquid nihil dolor aliquid beatae animi.
                Sapiente fugit tempora eveniet mollitia dignissimos quisquam quis et eaque.', NULL, NULL, 'Automotive', NULL, 'sit-vero-omnis', 'http://lorempixel.com/640/480/fashion');
INSERT INTO `Category` ("Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl")
VALUES (10, 'voluptatem', 9, TRUE, FALSE, TRUE, TIMESTAMPTZ '2019-08-07 05:18:18.684815-03:00', 'Optio voluptas et earum mollitia accusamus autem quia itaque est.', NULL, NULL, 'Movies', NULL, 'quia-tempora-quaerat', 'http://lorempixel.com/640/480/fashion');

INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (36, NULL, 'http://lorempixel.com/640/480/fashion', -2028891239, FALSE, TIMESTAMPTZ '2019-08-14 09:55:31.17927-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (35, NULL, 'http://lorempixel.com/640/480/fashion', -748640974, FALSE, TIMESTAMPTZ '2019-08-19 16:18:51.496325-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (34, NULL, 'http://lorempixel.com/640/480/fashion', 287819538, FALSE, TIMESTAMPTZ '2019-08-18 12:37:40.890886-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (33, NULL, 'http://lorempixel.com/640/480/fashion', 248459470, FALSE, TIMESTAMPTZ '2019-08-17 05:53:51.814043-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (29, NULL, 'http://lorempixel.com/640/480/fashion', 412291631, FALSE, TIMESTAMPTZ '2019-08-19 07:35:23.432404-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (31, NULL, 'http://lorempixel.com/640/480/fashion', -1991871196, FALSE, TIMESTAMPTZ '2019-08-19 20:07:26.054553-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (30, NULL, 'http://lorempixel.com/640/480/fashion', 506806775, FALSE, TIMESTAMPTZ '2019-08-22 05:58:49.085359-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (37, NULL, 'http://lorempixel.com/640/480/fashion', 1331111949, FALSE, TIMESTAMPTZ '2019-08-12 01:36:12.534837-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (28, NULL, 'http://lorempixel.com/640/480/fashion', 1642270309, FALSE, TIMESTAMPTZ '2019-08-12 06:47:21.185993-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (32, NULL, 'http://lorempixel.com/640/480/fashion', 1121545587, FALSE, TIMESTAMPTZ '2019-08-12 14:26:59.727968-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (38, NULL, 'http://lorempixel.com/640/480/fashion', 1880556911, FALSE, TIMESTAMPTZ '2019-08-23 04:39:01.113011-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (43, NULL, 'http://lorempixel.com/640/480/fashion', 1850042101, FALSE, TIMESTAMPTZ '2019-08-15 15:45:55.193334-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (40, NULL, 'http://lorempixel.com/640/480/fashion', -1897146226, FALSE, TIMESTAMPTZ '2019-08-15 08:38:52.561579-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (41, NULL, 'http://lorempixel.com/640/480/fashion', -561462601, FALSE, TIMESTAMPTZ '2019-08-24 07:54:57.02637-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (42, NULL, 'http://lorempixel.com/640/480/fashion', 1813501976, FALSE, TIMESTAMPTZ '2019-08-18 23:11:25.931194-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (44, NULL, 'http://lorempixel.com/640/480/fashion', 1208569382, FALSE, TIMESTAMPTZ '2019-08-16 06:50:15.618022-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (45, NULL, 'http://lorempixel.com/640/480/fashion', 433985453, FALSE, TIMESTAMPTZ '2019-08-15 10:06:28.628766-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (46, NULL, 'http://lorempixel.com/640/480/fashion', -867642655, FALSE, TIMESTAMPTZ '2019-08-18 05:20:04.865561-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (47, NULL, 'http://lorempixel.com/640/480/fashion', -1134619703, FALSE, TIMESTAMPTZ '2019-08-10 22:38:08.18715-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (48, NULL, 'http://lorempixel.com/640/480/fashion', 1395452035, FALSE, TIMESTAMPTZ '2019-08-21 03:12:36.887454-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (49, NULL, 'http://lorempixel.com/640/480/fashion', -585593102, FALSE, TIMESTAMPTZ '2019-08-10 23:25:58.612628-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (50, NULL, 'http://lorempixel.com/640/480/fashion', -514670056, FALSE, TIMESTAMPTZ '2019-08-11 08:09:32.548555-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (27, NULL, 'http://lorempixel.com/640/480/fashion', 631911029, FALSE, TIMESTAMPTZ '2019-08-12 20:52:29.112056-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (39, NULL, 'http://lorempixel.com/640/480/fashion', -1131152461, FALSE, TIMESTAMPTZ '2019-08-18 16:17:28.662229-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (26, NULL, 'http://lorempixel.com/640/480/fashion', 465343155, FALSE, TIMESTAMPTZ '2019-08-14 09:59:43.477519-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (23, NULL, 'http://lorempixel.com/640/480/fashion', -1552057834, FALSE, TIMESTAMPTZ '2019-08-24 10:14:08.901097-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (24, NULL, 'http://lorempixel.com/640/480/fashion', -675670246, FALSE, TIMESTAMPTZ '2019-08-21 18:39:44.137219-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (1, NULL, 'http://lorempixel.com/640/480/fashion', -1122921999, FALSE, TIMESTAMPTZ '2019-08-24 05:25:03.478338-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (25, NULL, 'http://lorempixel.com/640/480/fashion', 2096223680, FALSE, TIMESTAMPTZ '2019-08-18 17:21:16.231837-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (3, NULL, 'http://lorempixel.com/640/480/fashion', 1886241747, FALSE, TIMESTAMPTZ '2019-08-20 00:20:57.6763-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (4, NULL, 'http://lorempixel.com/640/480/fashion', 2121165840, FALSE, TIMESTAMPTZ '2019-08-10 14:57:04.837189-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (5, NULL, 'http://lorempixel.com/640/480/fashion', 2125572793, FALSE, TIMESTAMPTZ '2019-08-12 18:23:23.893289-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (6, NULL, 'http://lorempixel.com/640/480/fashion', 1320512845, FALSE, TIMESTAMPTZ '2019-08-12 12:25:58.527407-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (7, NULL, 'http://lorempixel.com/640/480/fashion', -1143979531, FALSE, TIMESTAMPTZ '2019-08-23 06:16:27.970648-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (8, NULL, 'http://lorempixel.com/640/480/fashion', 482867853, FALSE, TIMESTAMPTZ '2019-08-23 15:50:20.801646-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (9, NULL, 'http://lorempixel.com/640/480/fashion', -2002424645, FALSE, TIMESTAMPTZ '2019-08-22 20:08:54.903587-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (10, NULL, 'http://lorempixel.com/640/480/fashion', -1999934605, FALSE, TIMESTAMPTZ '2019-08-19 20:42:33.969888-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (11, NULL, 'http://lorempixel.com/640/480/fashion', 486875962, FALSE, TIMESTAMPTZ '2019-08-20 17:47:22.974435-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (2, NULL, 'http://lorempixel.com/640/480/fashion', 2047801454, FALSE, TIMESTAMPTZ '2019-08-10 22:12:10.883393-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (13, NULL, 'http://lorempixel.com/640/480/fashion', -1267105202, FALSE, TIMESTAMPTZ '2019-08-12 04:24:45.639418-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (14, NULL, 'http://lorempixel.com/640/480/fashion', -1882199765, FALSE, TIMESTAMPTZ '2019-08-12 07:04:58.968494-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (15, NULL, 'http://lorempixel.com/640/480/fashion', -1748135040, FALSE, TIMESTAMPTZ '2019-08-13 18:42:33.468715-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (16, NULL, 'http://lorempixel.com/640/480/fashion', -8103684, FALSE, TIMESTAMPTZ '2019-08-19 13:06:06.472431-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (17, NULL, 'http://lorempixel.com/640/480/fashion', 857240483, FALSE, TIMESTAMPTZ '2019-08-22 13:13:02.959776-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (18, NULL, 'http://lorempixel.com/640/480/fashion', 252708995, FALSE, TIMESTAMPTZ '2019-08-24 01:05:08.932316-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (19, NULL, 'http://lorempixel.com/640/480/fashion', 667642932, FALSE, TIMESTAMPTZ '2019-08-16 03:45:33.669498-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (20, NULL, 'http://lorempixel.com/640/480/fashion', -2060698967, FALSE, TIMESTAMPTZ '2019-08-19 11:53:31.773956-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (21, NULL, 'http://lorempixel.com/640/480/fashion', -1827569694, FALSE, TIMESTAMPTZ '2019-08-13 21:57:27.217506-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (22, NULL, 'http://lorempixel.com/640/480/fashion', -2124219764, FALSE, TIMESTAMPTZ '2019-08-15 15:44:31.822872-03:00', 1, NULL, NULL);
INSERT INTO `Media` ("Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId")
VALUES (12, NULL, 'http://lorempixel.com/640/480/fashion', 1384469487, FALSE, TIMESTAMPTZ '2019-08-17 04:06:24.545599-03:00', 1, NULL, NULL);

INSERT INTO `Shipment` ("Id", "Comment", "CreatedOn", "DeliveryCost", "DeliveryDate", "IsDeleted", "LastModified", "Price", "ShippedDate", "StormyOrderId", "TotalWeight", "TrackNumber")
VALUES (2, 'a single comment', TIMESTAMP '2019-08-24 14:42:50.936561', 22.29, TIMESTAMP '2019-08-27 00:00:00', FALSE, TIMESTAMPTZ '2019-08-24 14:42:50.93656+00:00', 20.99, TIMESTAMP '2019-08-23 00:00:00', NULL, 0.4, 'a56fcda5-d83d-462c-b3d0-d9da32595333');

INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (12, 0, NULL, 'Reis - Martins', 'Alexander.Nogueira67', 'Alexander27@hotmail.com', FALSE, TIMESTAMPTZ '2019-08-15 13:58:52.107162-03:00', 'https://loremflickr.com/320/240?lock=1384527052', 'Ullam possimus ab necessitatibus.
                Dolores eligendi facere eligendi est ipsa ab vero.
                Fuga illum atque vero expedita in qui.', '(55) 54610-6983', '0', 'Tools, Outdoors & Computers', 'alexandre.com');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (13, 0, NULL, 'Nogueira, Moreira and Nogueira', 'Otis86', 'Otis.Costa78@hotmail.com', FALSE, TIMESTAMPTZ '2019-08-08 09:30:35.877391-03:00', 'https://loremflickr.com/320/240?lock=128470094', 'placeat', '(52) 94485-3099', '0', 'Baby & Home', 'alessandra.net');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (14, 0, NULL, 'Barros - Carvalho', 'Audrey_Moreira67', 'Audrey45@yahoo.com', FALSE, TIMESTAMPTZ '2019-08-21 02:11:33.254554-03:00', 'https://loremflickr.com/320/240?lock=580808669', 'Ut quia exercitationem dignissimos et accusantium.
                Consectetur est placeat id.
                Commodi et at eum eum sint in quas.', '(89) 2570-7108', '0', 'Games', 'deneval.info');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (18, 0, NULL, 'Nogueira, Santos and Pereira', 'Ron45', 'Ron_Oliveira74@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-21 03:49:30.011849-03:00', 'https://loremflickr.com/320/240?lock=803316662', 'Accusamus totam sint.', '(10) 77771-3930', '0', 'Jewelery, Computers & Outdoors', 'morgana.net');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (16, 0, NULL, 'Silva - Costa', 'Lorene.Costa', 'Lorene54@bol.com.br', FALSE, TIMESTAMPTZ '2019-07-29 14:38:55.201171-03:00', 'https://loremflickr.com/320/240?lock=1381516639', 'At repudiandae libero harum impedit id qui nemo a.
                Iste error quia.
                Dolor earum aut asperiores tenetur et quo.
                Et aliquid aut earum voluptatem sint in natus.
                Ut et ex omnis.
                Sint voluptatum at pariatur aspernatur soluta possimus.', '(47) 0914-3651', '0', 'Industrial', 'fabrício.org');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (17, 0, NULL, 'Saraiva, Franco and Moreira', 'Vicki32', 'Vicki_Oliveira42@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-15 22:51:00.254143-03:00', 'https://loremflickr.com/320/240?lock=451631878', 'Incidunt at illo.
                Ut aliquam perspiciatis ut tempore porro facere.', '(98) 2036-1237', '0', 'Kids & Jewelery', 'lorena.br');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (11, 0, NULL, 'Melo - Barros', 'Geneva94', 'Geneva_Oliveira@gmail.com', FALSE, TIMESTAMPTZ '2019-07-28 16:43:36.017941-03:00', 'https://loremflickr.com/320/240?lock=2011296218', 'Illum error vel.', '(01) 6221-4049', '0', 'Computers', 'víctor.org');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (15, 0, NULL, 'Barros, Braga and Barros', 'Amanda_Silva', 'Amanda.Silva@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-18 02:49:32.920308-03:00', 'https://loremflickr.com/320/240?lock=1663317621', 'tempore', '+55 (73) 3074-7842', '0', 'Sports, Music & Kids', 'hugo.br');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (10, 0, NULL, 'Carvalho, Batista and Costa', 'Fredrick_Moreira67', 'Fredrick_Moreira@yahoo.com', FALSE, TIMESTAMPTZ '2019-08-16 20:28:36.422295-03:00', 'https://loremflickr.com/320/240?lock=2013959514', 'Atque ut sequi ut incidunt. Reprehenderit minus dolorem dicta. Saepe nemo dolor. Ipsum occaecati quia voluptatem deleniti aut aut. Odit mollitia consectetur quas dolorum consequatur officiis est. Beatae quia aut.', '(00) 11577-7479', '0', 'Music', 'vitória.br');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (4, 0, NULL, 'Saraiva e Associados', 'Pete.Franco83', 'Pete28@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-02 09:44:21.174335-03:00', 'https://loremflickr.com/320/240?lock=1479345371', 'Pariatur reprehenderit numquam saepe dolores porro praesentium. Recusandae est laudantium nostrum. Deserunt maiores consequuntur veniam ab non ducimus. Consequatur expedita repudiandae.', '(72) 4800-9715', '0', 'Sports, Music & Industrial', 'guilherme.br');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (8, 0, NULL, 'Martins, Albuquerque and Franco', 'Trevor.Franco83', 'Trevor_Franco34@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-02 21:06:32.269804-03:00', 'https://loremflickr.com/320/240?lock=55328455', 'Earum dolorem est earum nihil exercitationem et at.
                Sit aliquam temporibus reprehenderit aut ducimus illum impedit.
                Atque magnam et quo et iusto quia sunt non quia.
                Ut qui quia commodi dolor aut.
                Quasi in consequuntur odio aliquid atque sint dolorem similique.', '+55 (35) 4370-2421', '0', 'Sports', 'fabrícia.org');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (7, 0, NULL, 'Barros - Carvalho', 'Jeremy.Santos84', 'Jeremy12@gmail.com', FALSE, TIMESTAMPTZ '2019-08-10 12:34:46.68546-03:00', 'https://loremflickr.com/320/240?lock=1677665313', 'Voluptas nihil nostrum cum ipsa pariatur quia iure nemo quidem.
                Maiores tempora illum sint omnis.', '+55 (31) 2884-2258', '0', 'Home', 'paula.biz');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (6, 0, NULL, 'Melo - Souza', 'Lindsey.Carvalho50', 'Lindsey.Carvalho74@yahoo.com', FALSE, TIMESTAMPTZ '2019-08-05 09:43:24.019667-03:00', 'https://loremflickr.com/320/240?lock=950289620', 'Nihil labore rem repellat nihil officia ut incidunt illo.', '(34) 5207-0114', '0', 'Movies', 'aline.com');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (5, 0, NULL, 'Franco - Costa', 'Leon.Oliveira2', 'Leon.Oliveira@hotmail.com', FALSE, TIMESTAMPTZ '2019-07-29 00:40:04.804111-03:00', 'https://loremflickr.com/320/240?lock=1101375655', 'Est atque dolor consequuntur fuga quam sapiente sed. Est molestiae commodi quia necessitatibus cumque qui iure aut. Iure quis voluptatibus ducimus ut exercitationem quia.', '+55 (04) 9804-7939', '0', 'Music', 'yango.info');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (3, 0, NULL, 'Souza, Franco and Reis', 'Lillie51', 'Lillie83@hotmail.com', FALSE, TIMESTAMPTZ '2019-08-06 05:17:11.638521-03:00', 'https://loremflickr.com/320/240?lock=1618030158', 'Perspiciatis enim nihil vitae qui pariatur.', '(44) 77740-4073', '0', 'Beauty', 'ofélia.name');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (2, 0, NULL, 'Carvalho LTDA', 'Jackie.Batista24', 'Jackie_Batista43@live.com', FALSE, TIMESTAMPTZ '2019-08-19 21:23:35.870262-03:00', 'https://loremflickr.com/320/240?lock=382766622', 'Velit est ullam ullam. Id aliquid illo nulla autem sed saepe in quas eligendi. Voluptatem et illum iure illum maiores eum quo odit. Dicta dolorem accusantium aut tempore non architecto et.', '(58) 40728-1732', '0', 'Clothing, Beauty & Grocery', 'talita.com');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (1, 0, NULL, 'Silva, Reis and Reis', 'Johnathan31', 'Johnathan_Martins73@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-18 21:50:16.562143-03:00', 'https://loremflickr.com/320/240?lock=1400294117', 'Nihil modi pariatur aut facere voluptas consequatur. Voluptatem voluptas sed aut sit voluptas. Veniam sunt sunt autem dolorum sunt ut saepe sint quia. Quidem eum numquam earum sit temporibus. Voluptate velit rerum ut pariatur corporis distinctio est. Vitae tempore voluptatem corrupti.', '(53) 65552-9439', '0', 'Grocery', 'yango.name');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (19, 0, NULL, 'Silva, Martins and Melo', 'Theresa_Moreira', 'Theresa68@bol.com.br', FALSE, TIMESTAMPTZ '2019-08-19 19:58:09.535918-03:00', 'https://loremflickr.com/320/240?lock=1271283624', 'Et corrupti officiis autem. Exercitationem consequuntur rerum velit cum maiores est provident et repellendus. Et sint accusamus nemo enim nostrum. Natus omnis omnis nobis omnis quos aut.', '(19) 07779-3819', '0', 'Baby & Games', 'eduarda.info');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (9, 0, NULL, 'Reis, Batista and Macedo', 'Amanda12', 'Amanda.Batista85@live.com', FALSE, TIMESTAMPTZ '2019-08-07 22:13:46.66557-03:00', 'https://loremflickr.com/320/240?lock=508608293', 'Pariatur qui laboriosam.', '+55 (79) 3233-5603', '0', 'Shoes', 'aline.org');
INSERT INTO `StormyVendor` ("Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite")
VALUES (20, 0, NULL, 'Xavier - Souza', 'Michelle97', 'Michelle.Oliveira@yahoo.com', FALSE, TIMESTAMPTZ '2019-07-31 20:50:33.310924-03:00', 'https://loremflickr.com/320/240?lock=1849781778', 'Voluptatibus assumenda enim beatae vitae ducimus occaecati.', '(37) 82433-2074', '0', 'Tools & Toys', 'márcia.biz');

INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (1, FALSE, 0, 0, FALSE, 10, 3, TIMESTAMP '2018-11-10 09:25:01.251116', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.229373+00:00', 2, 0, 0, FALSE, 'Placeat perspiciatis fugit laboriosam illum amet libero.', 'R$145,26', TIMESTAMP '2020-08-07 17:12:56.164809', 'R$10,12', TRUE, 0.28412012350006, 0, 'Rustic Wooden Bike', TRUE, 20, 1, 'dpnmqtue0yo92s62', 'deserunt-tempora-sed', 'Good', TRUE, 'Jewelery', 14.61407100531, 4.14634283359458, 0.17706038950805569, 76, 18, TIMESTAMP '2019-08-24 14:56:30.71194', 1);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (37, FALSE, 0, 0, FALSE, 3, 10, TIMESTAMP '2019-02-15 11:45:09.620702', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231166+00:00', 12, 0, 0, FALSE, 'Voluptatem tenetur nobis voluptatem magni quae.', 'R$45,61', TIMESTAMP '2020-06-24 07:10:05.710818', 'R$40,04', TRUE, 0.0200394741352831, 0, 'Generic Plastic Pizza', TRUE, 88, 37, '3qep7i23nyv1i667', 'placeat-voluptas-aut', 'Good', TRUE, 'Shoes', 85.9900624891697, 4.01537523326249, 0.16610621109889179, 82, 38, TIMESTAMP '2019-08-25 01:42:39.046201', 10);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (46, FALSE, 0, 0, FALSE, 8, 1, TIMESTAMP '2018-12-07 11:54:36.757517', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231453+00:00', 7, 0, 0, FALSE, 'enim', 'R$152,21', TIMESTAMP '2020-04-16 05:51:01.39368', 'R$24,50', TRUE, 0.309868786162636, 0, 'Incredible Soft Table', TRUE, 36, 46, '02rv6rwc5ydtot55', 'accusantium-earum-odio', 'Good', TRUE, 'Jewelery', 80.579103986071, 1.90018308903099, 0.63795237785109893, 80, 4, TIMESTAMP '2019-08-24 08:28:51.053813', 10);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (47, FALSE, 0, 0, FALSE, 6, 9, TIMESTAMP '2018-12-01 04:13:43.227691', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231475+00:00', 14, 0, 0, FALSE, 'Veniam animi quis voluptatem id non dolorem facilis quo sint. Id dolor qui porro qui rerum. Quia aut praesentium. Beatae totam libero quae non facere voluptatem repellendus ab veniam. Laboriosam consequatur doloribus ut. Expedita est nulla similique voluptatem reiciendis dolores illum adipisci illo.', 'R$49,47', TIMESTAMP '2019-12-27 01:35:52.42921', 'R$42,20', TRUE, 0.361191181634176, 0, 'Ergonomic Steel Table', TRUE, 52, 47, 'tootkz30dvy3t949', 'explicabo-officia-harum', 'Good', TRUE, 'Music', 97.7090409480543, 4.20114052211919, 0.45194678308998548, 56, 38, TIMESTAMP '2019-08-24 11:59:24.947047', 10);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (49, FALSE, 0, 0, FALSE, 4, 5, TIMESTAMP '2018-12-05 18:23:47.815213', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231557+00:00', 18, 0, 0, FALSE, 'Molestiae ab ipsa nulla consequuntur.', 'R$9,70', TIMESTAMP '2019-11-02 16:11:21.784001', 'R$60,67', TRUE, 0.827151452576346, 0, 'Awesome Rubber Table', TRUE, 30, 49, 'hmu4qci5m8k49kie', 'est-reprehenderit-impedit', 'Good', TRUE, 'Toys', 9.36887180868949, 4.74376750399534, 0.40306626884409519, 52, 6, TIMESTAMP '2019-08-24 05:44:56.407488', 12);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (17, FALSE, 0, 0, FALSE, 6, 7, TIMESTAMP '2019-05-25 21:59:58.20605', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230548+00:00', 17, 0, 0, FALSE, 'dolor', 'R$66,99', TIMESTAMP '2020-02-14 18:12:12.836393', 'R$36,11', TRUE, 0.968143675461478, 0, 'Unbranded Soft Keyboard', TRUE, 56, 17, 'i495g5xmb2q2qrdl', 'vero-minus-culpa', 'Good', TRUE, 'Shoes', 55.4806499534662, 4.46155447720622, 0.58846905435829844, 90, 30, TIMESTAMP '2019-08-24 22:52:01.046164', 13);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (26, FALSE, 0, 0, FALSE, 4, 10, TIMESTAMP '2019-08-20 11:09:36.354269', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230833+00:00', 6, 0, 0, FALSE, 'deserunt', 'R$190,46', TIMESTAMP '2020-06-21 12:54:15.802612', 'R$23,92', TRUE, 0.519302337206575, 0, 'Handcrafted Wooden Hat', TRUE, 70, 26, 'qwoi1npgd0bhxcsx', 'sit-illo-repellendus', 'Good', TRUE, 'Automotive', 87.8071657790836, 4.681987913643, 0.39143931790787695, 60, 26, TIMESTAMP '2019-08-25 04:49:09.705927', 13);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (6, FALSE, 0, 0, FALSE, 4, 10, TIMESTAMP '2019-06-04 05:30:39.843807', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.229916+00:00', 12, 0, 0, FALSE, 'nobis', 'R$68,77', TIMESTAMP '2020-06-22 11:26:10.886679', 'R$72,35', TRUE, 0.85122994326578, 0, 'Intelligent Plastic Table', TRUE, 88, 6, '2ew3sej75yfhya9j', 'tempora-ut-asperiores', 'Good', TRUE, 'Baby', 29.2664842816379, 8.39062489028584, 0.87252622697154347, 68, 34, TIMESTAMP '2019-08-24 15:21:13.401868', 14);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (22, FALSE, 0, 0, FALSE, 1, 3, TIMESTAMP '2019-04-26 23:13:13.798468', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.23071+00:00', 8, 0, 0, FALSE, 'placeat', 'R$16,19', TIMESTAMP '2019-09-15 10:19:48.423076', 'R$68,28', TRUE, 0.233692497123821, 0, 'Licensed Fresh Mouse', TRUE, 4, 22, 'z30jeh12xd4qzhqu', 'voluptatem-voluptatem-aut', 'Good', TRUE, 'Clothing', 80.4808125274632, 2.35530056169038, 0.91337394337792599, 76, 46, TIMESTAMP '2019-08-24 15:26:45.267598', 14);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (44, FALSE, 0, 0, FALSE, 3, 8, TIMESTAMP '2018-10-05 17:13:41.186163', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231387+00:00', 10, 0, 0, FALSE, 'Beatae reiciendis corporis reiciendis dolor est aut fugit molestiae ea. Culpa et fugiat totam aut autem a debitis et. Enim eius sed eum deleniti quidem.', 'R$111,24', TIMESTAMP '2020-02-23 07:00:22.151228', 'R$41,21', TRUE, 0.0142584638736483, 0, 'Fantastic Plastic Towels', TRUE, 18, 44, 'rmst9ht0pk62nnoq', 'et-maxime-sit', 'Good', TRUE, 'Shoes', 97.78046305188, 2.86461426078557, 0.39748692344757119, 62, 30, TIMESTAMP '2019-08-25 02:26:06.487042', 14);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (15, FALSE, 0, 0, FALSE, 8, 3, TIMESTAMP '2018-09-19 04:33:46.250171', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.23047+00:00', 18, 0, 0, FALSE, 'Velit sit rerum quam eos deserunt. Voluptates quaerat nostrum ex veritatis omnis in. Quae debitis possimus qui et dolorum ut doloribus voluptatum minima. Vel voluptate adipisci ea sed similique doloribus laboriosam dolor molestiae. Culpa maiores quibusdam dolorum necessitatibus eos omnis suscipit minima molestiae. Qui aspernatur omnis consectetur.', 'R$199,06', TIMESTAMP '2020-08-04 10:48:32.488587', 'R$53,25', TRUE, 0.859701533270861, 0, 'Licensed Steel Table', TRUE, 80, 15, 'd16mwefc05hstzrt', 'alias-nulla-reprehenderit', 'Good', TRUE, 'Computers', 5.2438276378642, 1.20080345831849, 0.69255307581860248, 100, 48, TIMESTAMP '2019-08-24 06:01:28.015405', 15);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (38, FALSE, 0, 0, FALSE, 3, 8, TIMESTAMP '2018-09-15 12:03:36.798832', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231194+00:00', 4, 0, 0, FALSE, 'Qui ratione quo velit.
                Possimus nesciunt nisi.', 'R$198,10', TIMESTAMP '2020-01-30 07:04:57.83571', 'R$53,01', TRUE, 0.46969341415432, 0, 'Generic Soft Gloves', TRUE, 100, 38, 'fjlkzpv8jkrqmez7', 'minus-eum-dolores', 'Good', TRUE, 'Jewelery', 80.4793475570526, 7.28174122389487, 0.7880676289964782, 100, 12, TIMESTAMP '2019-08-24 08:02:12.488928', 15);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (40, FALSE, 0, 0, FALSE, 10, 2, TIMESTAMP '2019-08-04 21:35:51.552897', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231253+00:00', 7, 0, 0, FALSE, 'Asperiores alias nam odio non qui aut. Nobis ut neque repudiandae recusandae. Sint eligendi quibusdam vel laborum aut non ea provident et.', 'R$160,61', TIMESTAMP '2020-08-17 19:04:29.437643', 'R$79,26', TRUE, 0.326926665998496, 0, 'Gorgeous Steel Soap', TRUE, 64, 40, 'ftupvomryppbfvgk', 'fugit-repellat-et', 'Good', TRUE, 'Health', 52.152059856873, 0.069799809749145, 0.66193787598141374, 96, 42, TIMESTAMP '2019-08-24 23:46:08.628992', 15);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (5, FALSE, 0, 0, FALSE, 9, 3, TIMESTAMP '2018-09-01 03:15:53.483953', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.229839+00:00', 9, 0, 0, FALSE, 'Aut qui veniam aliquam.
                Numquam at ipsa excepturi nulla ipsam odio asperiores ea.
                Consequatur enim odit qui maiores.
                Omnis rerum dolores veniam voluptate id necessitatibus maxime.
                Ullam dicta rem alias.', 'R$77,74', TIMESTAMP '2020-02-19 12:47:00.167431', 'R$74,90', TRUE, 0.168283215336634, 0, 'Gorgeous Wooden Soap', TRUE, 18, 5, 'fkuxbm85uig82a5j', 'vel-quasi-aut', 'Good', TRUE, 'Outdoors', 68.8964635454567, 6.92961018389538, 0.089792577125966819, 84, 0, TIMESTAMP '2019-08-24 08:23:53.166057', 16);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (13, FALSE, 0, 0, FALSE, 4, 10, TIMESTAMP '2019-03-12 19:16:12.765252', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230373+00:00', 17, 0, 0, FALSE, 'Qui et quod quia alias amet enim laudantium impedit. Sed sunt repellat laudantium aspernatur. Sunt recusandae quae harum necessitatibus et minus nihil et. Est animi et blanditiis.', 'R$88,69', TIMESTAMP '2020-01-06 15:35:24.760905', 'R$90,34', TRUE, 0.739681523637698, 0, 'Intelligent Plastic Pants', TRUE, 68, 13, '3c19rvns939kswhd', 'aspernatur-beatae-enim', 'Good', TRUE, 'Clothing', 82.3776699054882, 6.90206005093738, 0.61299403738835545, 58, 44, TIMESTAMP '2019-08-23 23:22:49.106596', 16);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (11, FALSE, 0, 0, FALSE, 2, 10, TIMESTAMP '2018-10-13 18:17:16.494031', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230241+00:00', 16, 0, 0, FALSE, 'Id iusto voluptatibus ad corporis.
                Facilis recusandae accusamus sunt tempora esse nobis ipsum commodi aut.
                Omnis alias aut.
                Cupiditate dolor non iure provident.', 'R$137,71', TIMESTAMP '2019-11-14 11:30:25.569258', 'R$73,05', TRUE, 0.859767164969708, 0, 'Sleek Metal Computer', TRUE, 26, 11, '7j6blwn9m1hqcs1p', 'debitis-eos-aut', 'Good', TRUE, 'Music', 63.8944512996331, 1.47117895608357, 0.58943856441855369, 96, 42, TIMESTAMP '2019-08-24 20:54:17.296368', 17);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (35, FALSE, 0, 0, FALSE, 10, 4, TIMESTAMP '2019-01-25 21:40:09.00667', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231114+00:00', 14, 0, 0, FALSE, 'animi', 'R$196,03', TIMESTAMP '2020-04-17 10:31:14.468079', 'R$97,96', TRUE, 0.182701915587625, 0, 'Awesome Fresh Car', TRUE, 42, 35, '4h7tkrkmth1yuaog', 'nisi-dicta-omnis', 'Good', TRUE, 'Baby', 15.1669425494815, 6.32966100998673, 0.91453745305283807, 100, 4, TIMESTAMP '2019-08-24 11:34:34.250886', 17);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (43, FALSE, 0, 0, FALSE, 6, 2, TIMESTAMP '2019-03-28 08:02:37.132983', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231361+00:00', 2, 0, 0, FALSE, 'Perspiciatis rerum laboriosam omnis recusandae est pariatur.', 'R$117,38', TIMESTAMP '2020-03-30 15:31:20.788049', 'R$61,00', TRUE, 0.578952876189236, 0, 'Practical Metal Gloves', TRUE, 76, 43, 'mzu9io67epko6l0i', 'consequatur-iusto-doloremque', 'Good', TRUE, 'Garden', 38.6442824912464, 8.65414302267793, 0.053826924438507728, 60, 6, TIMESTAMP '2019-08-23 20:19:49.819194', 17);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (10, FALSE, 0, 0, FALSE, 2, 5, TIMESTAMP '2019-03-09 00:21:50.6792', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230192+00:00', 18, 0, 0, FALSE, 'Voluptatem non dolor consequatur rem incidunt labore dolorem.', 'R$165,49', TIMESTAMP '2020-04-27 13:18:16.766794', 'R$51,69', TRUE, 0.855124510291556, 0, 'Incredible Wooden Chips', TRUE, 80, 10, 's7llk5e7zvyu633x', 'est-eos-sed', 'Good', TRUE, 'Kids', 61.8891228278583, 4.87505243852504, 0.7078733019101775, 98, 26, TIMESTAMP '2019-08-25 01:58:30.68042', 18);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (14, FALSE, 0, 0, FALSE, 7, 9, TIMESTAMP '2019-03-15 00:48:37.62457', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230431+00:00', 13, 0, 0, FALSE, 'Ab qui dolores perspiciatis consectetur.
                Sapiente nam aut provident omnis.
                Fugiat ut officia quis illo eaque possimus doloribus.', 'R$51,80', TIMESTAMP '2020-01-09 16:29:49.395863', 'R$5,64', TRUE, 0.27515782847775, 0, 'Small Plastic Keyboard', TRUE, 62, 14, 'lt52g3xrqx76bgsj', 'impedit-consequatur-aliquam', 'Good', TRUE, 'Garden', 56.4213363716478, 7.21241304055434, 0.13358747080601169, 94, 2, TIMESTAMP '2019-08-24 06:36:30.032959', 18);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (4, FALSE, 0, 0, FALSE, 2, 3, TIMESTAMP '2018-11-11 23:27:15.1745', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.229789+00:00', 1, 0, 0, FALSE, 'Officia voluptate qui incidunt ab error ipsam rerum rem unde.
                Sed quis sint ea.
                Nesciunt provident velit.
                Facilis et debitis odio nesciunt itaque.', 'R$29,12', TIMESTAMP '2020-05-24 15:04:07.553074', 'R$69,35', TRUE, 0.252658116748863, 0, 'Gorgeous Rubber Chicken', TRUE, 92, 4, 'uuo4gf5poqor8apw', 'autem-ab-eum', 'Good', TRUE, 'Music', 54.372897722932, 1.69287130315456, 0.88130881585241705, 84, 50, TIMESTAMP '2019-08-24 05:03:39.89595', 19);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (8, FALSE, 0, 0, FALSE, 7, 6, TIMESTAMP '2018-11-14 13:05:32.193182', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230023+00:00', 12, 0, 0, FALSE, 'Maiores est reprehenderit et.
                Molestias atque itaque sint.
                Non dolore est accusantium asperiores accusamus.
                Ipsam quibusdam corporis iste ut dolorem.
                Qui consequatur eius ex.
                Quod eum qui aut eaque rerum.', 'R$90,24', TIMESTAMP '2020-07-26 01:45:18.386984', 'R$81,80', TRUE, 0.456052452072526, 0, 'Handcrafted Concrete Salad', TRUE, 18, 8, 'kktk5ic6s6vfuyyr', 'sed-omnis-iusto', 'Good', TRUE, 'Books', 61.2854435393985, 2.10988626447967, 0.20970033491482043, 90, 48, TIMESTAMP '2019-08-24 23:34:04.500199', 19);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (33, FALSE, 0, 0, FALSE, 7, 2, TIMESTAMP '2019-05-29 21:14:18.887771', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231064+00:00', 6, 0, 0, FALSE, 'Nam rerum et.', 'R$77,66', TIMESTAMP '2020-07-26 00:03:31.028931', 'R$99,42', TRUE, 0.916248637678217, 0, 'Licensed Cotton Pizza', TRUE, 4, 33, 'lquf5dp7midai66x', 'maxime-ea-ullam', 'Good', TRUE, 'Games', 74.6586440944386, 8.93304748410966, 0.7826378949837004, 70, 18, TIMESTAMP '2019-08-24 11:50:00.820304', 10);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (16, FALSE, 0, 0, FALSE, 7, 10, TIMESTAMP '2018-12-21 19:59:20.589276', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230522+00:00', 9, 0, 0, FALSE, 'sit', 'R$35,79', TIMESTAMP '2020-03-17 05:16:24.263886', 'R$42,11', TRUE, 0.961874342505762, 0, 'Ergonomic Soft Car', TRUE, 100, 16, '7mg4arl6qe84zhm9', 'explicabo-qui-perferendis', 'Good', TRUE, 'Books', 84.977401553177, 4.815275024071, 0.084318178745134822, 76, 22, TIMESTAMP '2019-08-24 02:26:26.786774', 10);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (34, FALSE, 0, 0, FALSE, 8, 8, TIMESTAMP '2019-02-24 01:47:53.796754', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231091+00:00', 4, 0, 0, FALSE, 'eligendi', 'R$85,96', TIMESTAMP '2019-11-24 13:39:24.03028', 'R$91,88', TRUE, 0.480805765595662, 0, 'Gorgeous Rubber Cheese', TRUE, 80, 34, '40awibgku4nqbcxk', 'at-odio-temporibus', 'Good', TRUE, 'Beauty', 70.0442826701534, 2.57349640716496, 0.61477434337827108, 72, 8, TIMESTAMP '2019-08-23 22:24:57.221745', 9);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (28, FALSE, 0, 0, FALSE, 8, 1, TIMESTAMP '2019-04-26 23:13:54.461716', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230935+00:00', 4, 0, 0, FALSE, 'ipsam', 'R$95,87', TIMESTAMP '2020-05-29 10:31:59.414667', 'R$37,85', TRUE, 0.832561557568871, 0, 'Licensed Metal Cheese', TRUE, 16, 28, '3gasdg717v3t7d4z', 'labore-deserunt-nam', 'Good', TRUE, 'Games', 54.8541851597159, 8.56086242411326, 0.78275329097302315, 80, 12, TIMESTAMP '2019-08-24 07:48:03.312925', 9);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (3, FALSE, 0, 0, FALSE, 2, 4, TIMESTAMP '2018-12-30 20:35:58.424795', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.229737+00:00', 10, 0, 0, FALSE, 'Et perspiciatis et quibusdam. Dolores voluptatem consectetur qui eveniet. Doloribus autem blanditiis esse necessitatibus illum. Libero sunt consequatur est nulla sapiente et. Vel et eveniet nihil repellat beatae itaque doloribus.', 'R$180,58', TIMESTAMP '2020-06-21 21:49:04.705092', 'R$34,51', TRUE, 0.979328738981545, 0, 'Awesome Metal Bacon', TRUE, 64, 3, '12fjaezm3avh89gm', 'dignissimos-ea-sint', 'Good', TRUE, 'Toys', 8.97633415133522, 0.175575376570027, 0.73814693965862832, 84, 14, TIMESTAMP '2019-08-24 18:22:23.147345', 1);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (32, FALSE, 0, 0, FALSE, 3, 10, TIMESTAMP '2018-08-29 02:17:46.605247', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231041+00:00', 7, 0, 0, FALSE, 'quas', 'R$179,17', TIMESTAMP '2020-07-30 16:31:44.391408', 'R$62,76', TRUE, 0.750817866414235, 0, 'Fantastic Metal Shoes', TRUE, 96, 32, '58c6t1bisrasvecg', 'consequatur-et-velit', 'Good', TRUE, 'Music', 99.2901295420202, 8.40757566430027, 0.65115429863853114, 54, 28, TIMESTAMP '2019-08-23 22:10:04.274587', 1);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (45, FALSE, 0, 0, FALSE, 2, 3, TIMESTAMP '2018-11-09 16:20:00.356748', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231425+00:00', 7, 0, 0, FALSE, 'Quo dolores sint cum veritatis.', 'R$80,87', TIMESTAMP '2020-01-15 04:30:02.279718', 'R$99,09', TRUE, 0.577356833767778, 0, 'Tasty Soft Gloves', TRUE, 56, 45, 'btylf5x5vnxmirrr', 'deserunt-optio-sunt', 'Good', TRUE, 'Toys', 47.6042776124572, 4.13630914601326, 0.80667972415996703, 82, 16, TIMESTAMP '2019-08-24 16:33:31.08014', 1);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (23, FALSE, 0, 0, FALSE, 1, 9, TIMESTAMP '2019-07-12 21:40:12.673097', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230736+00:00', 20, 0, 0, FALSE, 'voluptatum', 'R$173,75', TIMESTAMP '2020-06-02 14:13:21.915593', 'R$37,57', TRUE, 0.866775475846033, 0, 'Unbranded Soft Chips', TRUE, 66, 23, '8ent7op44ra305vm', 'ipsum-et-quidem', 'Good', TRUE, 'Grocery', 15.6776676958788, 7.42272589701355, 0.77282776905821071, 72, 4, TIMESTAMP '2019-08-24 01:10:16.864801', 2);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (29, FALSE, 0, 0, FALSE, 10, 5, TIMESTAMP '2019-02-09 05:23:30.154955', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230958+00:00', 17, 0, 0, FALSE, 'Qui deserunt ab accusantium consequatur dolores nostrum aspernatur fugit.', 'R$14,71', TIMESTAMP '2019-11-11 19:58:27.350902', 'R$63,83', TRUE, 0.257010113567584, 0, 'Refined Wooden Mouse', TRUE, 76, 29, 'e4i4g94xtoauoco7', 'aut-minima-quibusdam', 'Good', TRUE, 'Kids', 53.3777780148097, 3.3686247809644, 0.58682333612200954, 100, 22, TIMESTAMP '2019-08-24 16:42:18.635065', 2);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (41, FALSE, 0, 0, FALSE, 6, 10, TIMESTAMP '2018-11-03 08:50:42.224706', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231291+00:00', 4, 0, 0, FALSE, 'Dolor aspernatur voluptatum qui sapiente officiis quasi qui quod. Impedit quidem est aut ab possimus et voluptas assumenda temporibus. Laborum rerum repudiandae quis. Mollitia omnis quaerat aliquid rerum illum.', 'R$31,06', TIMESTAMP '2019-10-12 12:53:40.191228', 'R$75,82', TRUE, 0.996352178974241, 0, 'Licensed Cotton Sausages', TRUE, 82, 41, 'f0q7ksp2l5q406wd', 'harum-totam-aut', 'Good', TRUE, 'Baby', 82.0994779384227, 0.574920047342274, 0.93191479562405255, 98, 10, TIMESTAMP '2019-08-24 07:06:00.679066', 2);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (12, FALSE, 0, 0, FALSE, 6, 4, TIMESTAMP '2019-06-15 06:54:07.648599', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230318+00:00', 15, 0, 0, FALSE, 'ut', 'R$9,56', TIMESTAMP '2020-04-20 05:17:21.863475', 'R$35,89', TRUE, 0.790895264498375, 0, 'Fantastic Frozen Bike', TRUE, 0, 12, '69q1qyfj5n2ngv2n', 'ab-rerum-assumenda', 'Good', TRUE, 'Electronics', 24.3409456798532, 1.59671134855445, 0.8435130379365352, 52, 22, TIMESTAMP '2019-08-24 11:57:08.126688', 3);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (18, FALSE, 0, 0, FALSE, 10, 8, TIMESTAMP '2018-11-10 15:11:44.611979', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230571+00:00', 16, 0, 0, FALSE, 'quibusdam', 'R$156,90', TIMESTAMP '2020-02-18 00:05:38.3686', 'R$95,50', TRUE, 0.654605114671684, 0, 'Rustic Granite Cheese', TRUE, 44, 18, 'bdmoc1k2koc62di7', 'voluptatum-harum-eveniet', 'Good', TRUE, 'Tools', 35.0354205514469, 3.99056311882593, 0.56452928789170886, 86, 14, TIMESTAMP '2019-08-24 14:17:01.561358', 3);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (30, FALSE, 0, 0, FALSE, 2, 6, TIMESTAMP '2018-09-05 07:06:52.405346', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.23099+00:00', 6, 0, 0, FALSE, 'voluptatem', 'R$142,24', TIMESTAMP '2020-02-22 17:45:55.367458', 'R$96,12', TRUE, 0.678475646152382, 0, 'Practical Frozen Computer', TRUE, 22, 30, 'kenszjgsp4o28tb7', 'iure-aut-vero', 'Good', TRUE, 'Baby', 68.1228236612504, 7.51609829138783, 0.20789446551720353, 68, 0, TIMESTAMP '2019-08-24 17:31:26.955327', 4);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (36, FALSE, 0, 0, FALSE, 10, 6, TIMESTAMP '2019-06-11 14:28:13.248078', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231139+00:00', 18, 0, 0, FALSE, 'Nostrum est reiciendis voluptatem quia et quisquam quod quod.', 'R$187,23', TIMESTAMP '2020-06-13 04:39:16.926996', 'R$79,53', TRUE, 0.495638341873716, 0, 'Small Soft Pants', TRUE, 98, 36, 'dy2a23r6nhbatg2r', 'occaecati-consequatur-eveniet', 'Good', TRUE, 'Movies', 72.6733095351017, 6.77998290247283, 0.55165149483440978, 62, 50, TIMESTAMP '2019-08-23 19:06:45.250559', 4);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (24, FALSE, 0, 0, FALSE, 9, 9, TIMESTAMP '2018-12-30 05:49:51.614381', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230758+00:00', 10, 0, 0, FALSE, 'Impedit placeat quia.
                Vero et quam error est ut non voluptatibus et.
                Ab totam nostrum veniam voluptas soluta dolore.
                Voluptatem autem error assumenda molestiae suscipit qui.', 'R$118,29', TIMESTAMP '2020-01-25 08:49:34.289558', 'R$87,02', TRUE, 0.848688895278, 0, 'Unbranded Wooden Towels', TRUE, 42, 24, 'oipw7migacah8vkr', 'mollitia-est-expedita', 'Good', TRUE, 'Shoes', 43.4626735017927, 9.92809152227272, 0.12336136173613432, 74, 36, TIMESTAMP '2019-08-23 17:43:00.53561', 19);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (42, FALSE, 0, 0, FALSE, 6, 7, TIMESTAMP '2019-07-11 20:14:53.932076', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231335+00:00', 10, 0, 0, FALSE, 'sed', 'R$160,88', TIMESTAMP '2019-10-31 16:06:14.91261', 'R$79,63', TRUE, 0.991659930437645, 0, 'Ergonomic Plastic Pants', TRUE, 24, 42, 'dw15c5knk5kui9bg', 'iure-sapiente-saepe', 'Good', TRUE, 'Outdoors', 57.8547190678561, 8.68664018282976, 0.33754434359145552, 82, 10, TIMESTAMP '2019-08-24 11:38:39.698895', 4);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (50, FALSE, 0, 0, FALSE, 10, 10, TIMESTAMP '2018-11-19 19:31:39.425921', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.23159+00:00', 8, 0, 0, FALSE, 'Eligendi vel aut tenetur ea voluptatem velit molestiae commodi. Dolorem modi perferendis velit et molestias ipsa voluptatibus fugit est. Quo nulla tempore et dolores.', 'R$29,92', TIMESTAMP '2020-05-01 06:48:51.934457', 'R$27,34', TRUE, 0.994139316954715, 0, 'Unbranded Rubber Shirt', TRUE, 86, 50, 'vyt65qp3gg6hs967', 'ut-nam-quis', 'Good', TRUE, 'Music', 88.0172816515049, 2.1892400282385, 0.31903389483645272, 52, 22, TIMESTAMP '2019-08-24 16:57:57.526458', 5);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (2, FALSE, 0, 0, FALSE, 9, 6, TIMESTAMP '2019-06-16 22:12:05.47711', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.229697+00:00', 1, 0, 0, FALSE, 'Nemo iure quia architecto aut dolorum sunt sit quidem provident.', 'R$165,70', TIMESTAMP '2020-05-13 14:15:41.837128', 'R$15,31', TRUE, 0.244765206354095, 0, 'Small Plastic Chicken', TRUE, 52, 2, 'kh8hj4yw1l9pb82q', 'est-eaque-qui', 'Good', TRUE, 'Clothing', 81.0817880933554, 4.18230829489525, 0.95460352718578811, 62, 48, TIMESTAMP '2019-08-24 15:45:51.371585', 6);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (25, FALSE, 0, 0, FALSE, 9, 9, TIMESTAMP '2019-04-04 12:49:23.526978', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230799+00:00', 13, 0, 0, FALSE, 'in', 'R$86,46', TIMESTAMP '2020-07-15 00:43:44.115846', 'R$48,93', TRUE, 0.210045502618908, 0, 'Refined Concrete Mouse', TRUE, 68, 25, 'loyk236fbwu6hd83', 'odio-dicta-fugiat', 'Good', TRUE, 'Outdoors', 33.2852340924019, 6.78102986737202, 0.13950262411474373, 82, 2, TIMESTAMP '2019-08-24 06:15:08.135496', 6);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (9, FALSE, 0, 0, FALSE, 10, 5, TIMESTAMP '2019-01-19 21:56:12.92131', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230118+00:00', 5, 0, 0, FALSE, 'Harum qui unde commodi maxime non magni totam dolorem.
                Non aliquid a ut excepturi.
                Qui error omnis quos tenetur.
                Aperiam ducimus molestiae aspernatur reprehenderit aut.', 'R$74,71', TIMESTAMP '2020-08-19 04:08:44.254204', 'R$85,87', TRUE, 0.887210952531179, 0, 'Awesome Concrete Pizza', TRUE, 42, 9, 'dmxokpf83ta4ir1r', 'dignissimos-est-qui', 'Good', TRUE, 'Games', 54.167604518201, 9.52347363788796, 0.53522262747177041, 86, 28, TIMESTAMP '2019-08-24 06:40:11.059589', 7);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (19, FALSE, 0, 0, FALSE, 2, 2, TIMESTAMP '2019-06-22 20:31:33.325184', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230601+00:00', 16, 0, 0, FALSE, 'Consectetur asperiores repellendus et omnis molestiae dolor. Ea eum est quam cum non quia optio molestiae iure. Quis labore aut. Nam incidunt doloribus reiciendis asperiores quaerat porro similique corporis. Occaecati nesciunt recusandae dolore molestiae assumenda. Culpa in sint omnis nostrum veniam est debitis.', 'R$18,21', TIMESTAMP '2019-11-10 20:44:39.594589', 'R$79,48', TRUE, 0.294517896275277, 0, 'Gorgeous Cotton Towels', TRUE, 90, 19, 'xes31f4683cx12jm', 'omnis-omnis-ad', 'Good', TRUE, 'Kids', 40.2566660383049, 7.03260672606184, 0.80532176736990069, 86, 28, TIMESTAMP '2019-08-24 03:16:36.84674', 8);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (21, FALSE, 0, 0, FALSE, 4, 7, TIMESTAMP '2019-04-28 11:03:19.107018', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230684+00:00', 17, 0, 0, FALSE, 'Illo est ut laudantium officia.', 'R$151,29', TIMESTAMP '2020-07-10 20:05:44.864402', 'R$28,73', TRUE, 0.309836792903876, 0, 'Intelligent Fresh Cheese', TRUE, 22, 21, 'vztnbymnessidmpz', 'et-perspiciatis-consequuntur', 'Good', TRUE, 'Sports', 49.1611832516087, 4.70671832780667, 0.78803777871096403, 74, 46, TIMESTAMP '2019-08-23 21:39:44.82233', 8);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (31, FALSE, 0, 0, FALSE, 8, 7, TIMESTAMP '2019-06-06 14:03:02.272242', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231013+00:00', 8, 0, 0, FALSE, 'Aut illum nihil odit fugit reiciendis.', 'R$162,47', TIMESTAMP '2019-11-27 14:39:11.532657', 'R$35,86', TRUE, 0.624750133894733, 0, 'Awesome Cotton Gloves', TRUE, 98, 31, 'k3en7pqk9c76w4r6', 'qui-omnis-reprehenderit', 'Good', TRUE, 'Games', 26.6741186504597, 4.01777024102293, 0.35752464149032004, 86, 14, TIMESTAMP '2019-08-24 16:31:46.151703', 8);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (48, FALSE, 0, 0, FALSE, 4, 4, TIMESTAMP '2019-04-08 14:52:30.609424', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231531+00:00', 16, 0, 0, FALSE, 'Cupiditate voluptatum delectus est est amet.', 'R$103,47', TIMESTAMP '2019-10-12 13:42:24.538414', 'R$22,86', TRUE, 0.0361268976871515, 0, 'Tasty Steel Shirt', TRUE, 2, 48, 'xg3fflq3zdg5ws3c', 'at-pariatur-officiis', 'Good', TRUE, 'Garden', 32.2280015015174, 4.24643037107141, 0.47963282907364557, 60, 44, TIMESTAMP '2019-08-24 13:51:03.527287', 8);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (7, FALSE, 0, 0, FALSE, 3, 6, TIMESTAMP '2018-10-29 20:54:54.7598', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.229968+00:00', 7, 0, 0, FALSE, 'Illum veniam beatae omnis laboriosam quae sunt ipsa.', 'R$78,65', TIMESTAMP '2020-01-04 12:31:08.223559', 'R$77,00', TRUE, 0.0337568991974727, 0, 'Intelligent Concrete Chair', TRUE, 2, 7, '0slc7lokg6mk841p', 'aut-dolorem-et', 'Good', TRUE, 'Health', 63.0152092608694, 5.08335723312728, 0.44288153827324583, 64, 20, TIMESTAMP '2019-08-24 12:31:23.094157', 9);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (27, FALSE, 0, 0, FALSE, 10, 2, TIMESTAMP '2019-01-02 17:13:42.949977', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230882+00:00', 20, 0, 0, FALSE, 'Et unde harum ipsam. Quas perspiciatis autem qui iure. Velit ipsam quasi dolore. Saepe quidem quas quibusdam ducimus aut omnis. At doloremque quo quia suscipit molestiae nisi. Provident numquam voluptatem doloremque amet dolor expedita ut quia dolor.', 'R$23,71', TIMESTAMP '2020-03-14 09:07:14.6419', 'R$83,04', TRUE, 0.882104842868682, 0, 'Awesome Steel Sausages', TRUE, 50, 27, '9kw7n1ft4ubgwkt3', 'ut-est-placeat', 'Good', TRUE, 'Toys', 5.05527481672134, 0.425928882521544, 0.17800735643972054, 94, 40, TIMESTAMP '2019-08-24 16:45:49.026613', 9);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (39, FALSE, 0, 0, FALSE, 3, 2, TIMESTAMP '2019-01-04 02:48:30.793945', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.231221+00:00', 5, 0, 0, FALSE, 'ex', 'R$186,54', TIMESTAMP '2020-04-26 05:25:03.342121', 'R$52,21', TRUE, 0.877715286741832, 0, 'Sleek Frozen Gloves', TRUE, 0, 39, 'pqtkx49zvin5hkl3', 'aut-tempora-temporibus', 'Good', TRUE, 'Computers', 86.5106944863269, 2.58480708235167, 0.33642973533665282, 100, 42, TIMESTAMP '2019-08-24 01:20:51.034515', 5);
INSERT INTO `StormyProduct` ("Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId")
VALUES (20, FALSE, 0, 0, FALSE, 6, 9, TIMESTAMP '2018-12-18 05:28:30.414577', 0.0, FALSE, FALSE, FALSE, TIMESTAMPTZ '2019-08-24 14:42:51.230651+00:00', 11, 0, 0, FALSE, 'Repellat voluptas in.
                Ad sint maiores suscipit similique odit ea harum nostrum.', 'R$68,65', TIMESTAMP '2020-02-04 06:08:33.12599', 'R$55,70', TRUE, 0.604775955250848, 0, 'Tasty Concrete Fish', TRUE, 42, 20, 'n9by5reg0mesn20d', 'hic-voluptatem-aut', 'Good', TRUE, 'Electronics', 55.4657008757189, 3.9561592992191, 0.07544778803151464, 58, 48, TIMESTAMP '2019-08-24 13:49:13.780927', 20);

INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (45, FALSE, TIMESTAMPTZ '2019-08-01 11:11:08.788124-03:00', 2, 41, 1);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (2, FALSE, TIMESTAMPTZ '2019-08-12 02:09:34.236108-03:00', 2, 33, 44);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (47, FALSE, TIMESTAMPTZ '2019-08-01 08:17:31.456789-03:00', 2, 7, 15);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (48, FALSE, TIMESTAMPTZ '2019-08-05 18:44:18.074878-03:00', 2, 15, 23);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (50, FALSE, TIMESTAMPTZ '2019-08-16 13:39:26.31362-03:00', 2, 32, 15);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (28, FALSE, TIMESTAMPTZ '2019-08-04 04:13:27.528258-03:00', 2, 38, 39);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (19, FALSE, TIMESTAMPTZ '2019-08-11 23:20:54.114038-03:00', 2, 50, 5);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (35, FALSE, TIMESTAMPTZ '2019-08-02 01:38:34.84257-03:00', 2, 13, 42);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (11, FALSE, TIMESTAMPTZ '2019-08-04 08:18:56.580276-03:00', 2, 2, 11);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (23, FALSE, TIMESTAMPTZ '2019-08-17 06:13:34.17952-03:00', 2, 50, 11);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (24, FALSE, TIMESTAMPTZ '2019-08-02 23:09:35.42222-03:00', 2, 6, 11);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (6, FALSE, TIMESTAMPTZ '2019-08-07 07:50:51.530417-03:00', 2, 3, 35);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (27, FALSE, TIMESTAMPTZ '2019-08-12 21:10:58.290442-03:00', 2, 19, 35);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (44, FALSE, TIMESTAMPTZ '2019-08-09 21:06:37.076502-03:00', 2, 35, 50);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (3, FALSE, TIMESTAMPTZ '2019-08-19 03:16:35.263231-03:00', 2, 10, 45);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (25, FALSE, TIMESTAMPTZ '2019-08-17 13:18:13.912588-03:00', 2, 4, 18);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (38, FALSE, TIMESTAMPTZ '2019-08-06 22:58:09.87225-03:00', 2, 50, 4);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (39, FALSE, TIMESTAMPTZ '2019-08-23 07:26:43.863789-03:00', 2, 8, 31);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (21, FALSE, TIMESTAMPTZ '2019-07-31 15:01:09.360837-03:00', 2, 18, 24);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (33, FALSE, TIMESTAMPTZ '2019-08-03 01:12:18.202674-03:00', 2, 48, 24);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (5, FALSE, TIMESTAMPTZ '2019-08-02 02:08:26.214766-03:00', 2, 12, 20);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (26, FALSE, TIMESTAMPTZ '2019-08-10 17:38:21.024847-03:00', 2, 47, 20);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (42, FALSE, TIMESTAMPTZ '2019-08-20 06:36:47.325675-03:00', 2, 22, 1);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (32, FALSE, TIMESTAMPTZ '2019-08-07 14:33:59.894593-03:00', 2, 22, 39);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (8, FALSE, TIMESTAMPTZ '2019-07-31 20:45:45.006043-03:00', 2, 45, 22);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (49, FALSE, TIMESTAMPTZ '2019-07-30 16:50:57.767043-03:00', 2, 37, 6);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (41, FALSE, TIMESTAMPTZ '2019-07-31 15:51:42.08736-03:00', 2, 36, 30);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (10, FALSE, TIMESTAMPTZ '2019-08-03 01:54:47.592306-03:00', 2, 36, 42);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (1, FALSE, TIMESTAMPTZ '2019-08-01 06:39:47.420413-03:00', 2, 50, 45);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (7, FALSE, TIMESTAMPTZ '2019-08-13 09:44:56.021281-03:00', 2, 25, 45);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (34, FALSE, TIMESTAMPTZ '2019-08-08 04:53:28.877634-03:00', 2, 19, 12);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (13, FALSE, TIMESTAMPTZ '2019-08-10 04:10:56.843774-03:00', 2, 42, 21);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (36, FALSE, TIMESTAMPTZ '2019-08-18 13:00:08.295014-03:00', 2, 31, 31);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (15, FALSE, TIMESTAMPTZ '2019-08-24 03:30:11.077202-03:00', 2, 25, 48);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (17, FALSE, TIMESTAMPTZ '2019-08-21 16:35:36.495166-03:00', 2, 48, 23);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (37, FALSE, TIMESTAMPTZ '2019-08-17 12:36:08.414354-03:00', 2, 48, 3);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (30, FALSE, TIMESTAMPTZ '2019-08-10 01:48:16.322965-03:00', 2, 20, 3);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (12, FALSE, TIMESTAMPTZ '2019-08-01 23:24:37.155252-03:00', 2, 2, 27);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (22, FALSE, TIMESTAMPTZ '2019-08-22 16:47:20.554047-03:00', 2, 1, 16);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (43, FALSE, TIMESTAMPTZ '2019-08-03 18:21:17.367958-03:00', 2, 31, 33);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (20, FALSE, TIMESTAMPTZ '2019-08-12 23:26:38.447438-03:00', 2, 23, 37);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (29, FALSE, TIMESTAMPTZ '2019-08-15 05:32:06.911557-03:00', 2, 46, 18);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (46, FALSE, TIMESTAMPTZ '2019-08-13 03:10:12.472543-03:00', 2, 46, 25);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (9, FALSE, TIMESTAMPTZ '2019-08-23 08:41:23.551721-03:00', 2, 46, 47);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (14, FALSE, TIMESTAMPTZ '2019-08-15 01:27:45.926853-03:00', 2, 7, 17);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (4, FALSE, TIMESTAMPTZ '2019-08-03 23:22:05.335722-03:00', 2, 17, 26);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (16, FALSE, TIMESTAMPTZ '2019-08-07 20:41:21.943574-03:00', 2, 12, 6);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (40, FALSE, TIMESTAMPTZ '2019-08-06 12:51:51.839824-03:00', 2, 36, 6);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (18, FALSE, TIMESTAMPTZ '2019-08-02 04:02:39.296739-03:00', 2, 34, 32);
INSERT INTO `ProductLink` ("Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId")
VALUES (31, FALSE, TIMESTAMPTZ '2019-08-13 14:14:46.029112-03:00', 2, 6, 20);

CREATE INDEX `IX_AspNetRoleClaims_RoleId` ON `AspNetRoleClaims` ("RoleId");

CREATE UNIQUE INDEX `RoleNameIndex` ON `AspNetRoles` ("NormalizedName");

CREATE INDEX `IX_AspNetUserClaims_UserId` ON `AspNetUserClaims` ("UserId");

CREATE INDEX `IX_AspNetUserLogins_UserId` ON `AspNetUserLogins` ("UserId");

CREATE INDEX `IX_AspNetUserRoles_RoleId` ON `AspNetUserRoles` ("RoleId");

CREATE INDEX `EmailIndex` ON `AspNetUsers` ("NormalizedEmail");

CREATE UNIQUE INDEX `UserNameIndex` ON `AspNetUsers` ("NormalizedUserName");

CREATE INDEX `IX_Category_ParentId` ON `Category` ("ParentId");

CREATE INDEX `IX_Entity_EntityTypeId` ON `Entity` ("EntityTypeId");

CREATE INDEX `IX_Media_StormyProductId` ON `Media` ("StormyProductId");

CREATE INDEX `IX_OrderItem_StormyOrderId` ON `OrderItem` ("StormyOrderId");

CREATE INDEX `IX_OrderItem_StormyProductId` ON `OrderItem` ("StormyProductId");

CREATE UNIQUE INDEX `IX_Payment_StormyOrderId` ON `Payment` ("StormyOrderId");

CREATE INDEX `IX_ProductAttribute_GroupId` ON `ProductAttribute` ("GroupId");

CREATE INDEX `IX_ProductAttribute_StormyProductId` ON `ProductAttribute` ("StormyProductId");

CREATE INDEX `IX_ProductAttributeValue_AttributeId` ON `ProductAttributeValue` ("AttributeId");

CREATE INDEX `IX_ProductAttributeValue_ProductId` ON `ProductAttributeValue` ("ProductId");

CREATE INDEX `IX_ProductLink_LinkedProductId` ON `ProductLink` ("LinkedProductId");

CREATE INDEX `IX_ProductLink_ProductId` ON `ProductLink` ("ProductId");

CREATE INDEX `IX_ProductOptionValue_OptionId` ON `ProductOptionValue` ("OptionId");

CREATE INDEX `IX_ProductOptionValue_ProductId` ON `ProductOptionValue` ("ProductId");

CREATE INDEX `IX_ProductTemplateProductAttribute_ProductAttributeId` ON `ProductTemplateProductAttribute` ("ProductAttributeId");

CREATE INDEX `IX_Shipment_StormyOrderId` ON `Shipment` ("StormyOrderId");

CREATE INDEX `IX_StormyCustomer_DefaultBillingAddressId` ON `StormyCustomer` ("DefaultBillingAddressId");

CREATE INDEX `IX_StormyCustomer_DefaultShippingAddressId` ON `StormyCustomer` ("DefaultShippingAddressId");

CREATE INDEX `IX_StormyOrder_CustomerId` ON `StormyOrder` ("CustomerId");

CREATE INDEX `IX_StormyOrder_ShippingAddressId` ON `StormyOrder` ("ShippingAddressId");

CREATE INDEX `IX_StormyProduct_BrandId` ON `StormyProduct` ("BrandId");

CREATE INDEX `IX_StormyProduct_CategoryId` ON `StormyProduct` ("CategoryId");

CREATE INDEX `IX_StormyProduct_MediaId` ON `StormyProduct` ("MediaId");

CREATE INDEX `IX_StormyProduct_VendorId` ON `StormyProduct` ("VendorId");

CREATE INDEX `IX_StormyVendor_AddressId1` ON `StormyVendor` ("AddressId1");

ALTER TABLE "StormyProduct" ADD CONSTRAINT "FK_StormyProduct_Media_MediaId" FOREIGN KEY ("MediaId") REFERENCES `Media` ("Id") ON DELETE CASCADE;

INSERT INTO `__EFMigrationsHistory` ("MigrationId", "ProductVersion")
VALUES ('20190824144251_InitialCreate', '2.2.4-servicing-10062');

