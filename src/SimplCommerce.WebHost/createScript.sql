IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [AppSettings] (
        [Id] nvarchar(450) NOT NULL,
        [Value] nvarchar(450) NULL,
        [Module] nvarchar(450) NULL,
        [IsVisibleInCommonSettingPage] bit NOT NULL,
        CONSTRAINT [PK_AppSettings] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [Discriminator] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [Brand] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [Name] nvarchar(max) NULL,
        [Slug] nvarchar(450) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Website] nvarchar(max) NULL,
        [LogoImage] nvarchar(max) NULL,
        CONSTRAINT [PK_Brand] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [Category] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Slug] nvarchar(450) NOT NULL,
        [MetaTitle] nvarchar(450) NULL,
        [MetaKeywords] nvarchar(450) NULL,
        [MetaDescription] nvarchar(max) NULL,
        [Description] nvarchar(450) NOT NULL,
        [DisplayOrder] int NOT NULL,
        [IsPublished] bit NOT NULL,
        [IncludeInMenu] bit NOT NULL,
        [ParentId] bigint NULL,
        [ChildrenId] bigint NULL,
        [ThumbnailImageUrl] nvarchar(max) NULL,
        CONSTRAINT [PK_Category] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Category_Category_ParentId] FOREIGN KEY ([ParentId]) REFERENCES [Category] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [EntityType] (
        [Id] nvarchar(450) NOT NULL,
        [IsMenuable] bit NOT NULL,
        [AreaName] nvarchar(450) NULL,
        [RoutingController] nvarchar(450) NULL,
        [RoutingAction] nvarchar(450) NULL,
        [IsDeleted] bit NOT NULL,
        CONSTRAINT [PK_EntityType] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [ProductAttributeGroup] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_ProductAttributeGroup] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [ProductOption] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_ProductOption] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [Stock] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        CONSTRAINT [PK_Stock] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [VendorAddress] (
        [Id] bigint NOT NULL IDENTITY,
        [Address_Street] nvarchar(max) NULL,
        [Address_FirstAddress] nvarchar(max) NULL,
        [Address_SecondAddress] nvarchar(max) NULL,
        [Address_City] nvarchar(max) NULL,
        [Address_District] nvarchar(max) NULL,
        [Address_State] nvarchar(max) NULL,
        [Address_PostalCode] nvarchar(max) NULL,
        [Address_Number] nvarchar(max) NULL,
        [Address_Complement] nvarchar(max) NULL,
        [Address_Country] nvarchar(max) NULL,
        [WhoReceives] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        CONSTRAINT [PK_VendorAddress] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [ApplicationUser] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(max) NULL,
        [NormalizedUserName] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [NormalizedEmail] nvarchar(max) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        [RefreshTokenHash] nvarchar(max) NULL,
        [RoleId] nvarchar(450) NULL,
        CONSTRAINT [PK_ApplicationUser] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ApplicationUser_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [Entity] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [Slug] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [EntityId] bigint NOT NULL,
        [EntityTypeId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_Entity] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Entity_EntityType_EntityTypeId] FOREIGN KEY ([EntityTypeId]) REFERENCES [EntityType] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [ProductAttribute] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [GroupId] bigint NOT NULL,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_ProductAttribute] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ProductAttribute_ProductAttributeGroup_GroupId] FOREIGN KEY ([GroupId]) REFERENCES [ProductAttributeGroup] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [StormyVendor] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CompanyName] nvarchar(max) NULL,
        [ContactTitle] nvarchar(max) NULL,
        [VendorAddressId] bigint NOT NULL,
        [ProductId] bigint NOT NULL,
        [Phone] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [WebSite] nvarchar(max) NULL,
        [TypeGoods] nvarchar(max) NULL,
        [SizeUrl] nvarchar(max) NULL,
        [Logo] nvarchar(max) NULL,
        [Note] nvarchar(max) NULL,
        CONSTRAINT [PK_StormyVendor] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_StormyVendor_VendorAddress_VendorAddressId] FOREIGN KEY ([VendorAddressId]) REFERENCES [VendorAddress] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [StormyProduct] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [SKU] nvarchar(max) NOT NULL,
        [Gtin] nvarchar(max) NULL,
        [NormalizedName] nvarchar(max) NULL,
        [ProductName] nvarchar(400) NOT NULL,
        [Slug] nvarchar(max) NULL,
        [MetaKeywords] nvarchar(max) NULL,
        [MetaDescription] nvarchar(max) NULL,
        [MetaTitle] nvarchar(max) NULL,
        [CreatedById] bigint NOT NULL,
        [BrandId] bigint NOT NULL,
        [ProductMediaId] bigint NOT NULL,
        [VendorId] bigint NOT NULL,
        [CategoryId] bigint NOT NULL,
        [MediaId] bigint NULL,
        [ProductLinksId] bigint NULL,
        [TaxClassId] bigint NULL,
        [LatestUpdatedById] bigint NULL,
        [ShortDescription] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [QuantityPerUnity] int NOT NULL,
        [AvailableSizes] nvarchar(max) NULL,
        [UnitPrice] decimal(18,2) NOT NULL,
        [Discount] decimal(18,2) NOT NULL,
        [UnitWeight] float NOT NULL,
        [Height] decimal(18,2) NOT NULL,
        [Width] decimal(18,2) NOT NULL,
        [Length] decimal(18,2) NOT NULL,
        [Diameter] int NULL,
        [UnitsInStock] int NOT NULL,
        [UnitsOnOrder] int NOT NULL,
        [ReviewsCount] int NOT NULL,
        [ProductAvailable] bit NOT NULL,
        [DiscountAvailable] bit NOT NULL,
        [StockTrackingIsEnabled] bit NOT NULL,
        [ThumbnailImage] nvarchar(max) NULL,
        [Ranking] int NOT NULL,
        [Note] nvarchar(max) NULL,
        [SpecialPrice] nvarchar(max) NULL,
        [SpecialPriceStart] datetime2 NULL,
        [SpecialPriceEnd] datetime2 NULL,
        [HasDiscountApplied] bit NOT NULL,
        [IsPublished] bit NOT NULL,
        [NotReturnable] bit NOT NULL,
        [AvailableForPreorder] bit NOT NULL,
        [HasOptions] bit NOT NULL,
        [IsVisibleIndividually] bit NOT NULL,
        [IsFeatured] bit NOT NULL,
        [IsCallForPricing] bit NOT NULL,
        [IsAllowToOrder] bit NOT NULL,
        [ProductCost] decimal(18,2) NOT NULL,
        [PreOrderAvailabilityStartDate] datetime2 NULL,
        [PublishedOn] datetime2 NULL,
        [CreatedOn] datetime2 NULL,
        [LatestUpdatedOn] datetime2 NULL,
        [AllowCustomerReview] bit NOT NULL,
        [ApprovedRatingSum] int NOT NULL,
        [NotApprovedRatingSum] int NOT NULL,
        [ApprovedTotalReviews] int NOT NULL,
        [NotApprovedTotalReviews] int NOT NULL,
        [RatingAverage] int NOT NULL,
        [StockId] bigint NULL,
        CONSTRAINT [PK_StormyProduct] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_StormyProduct_Brand_BrandId] FOREIGN KEY ([BrandId]) REFERENCES [Brand] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_StormyProduct_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Category] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_StormyProduct_Stock_StockId] FOREIGN KEY ([StockId]) REFERENCES [Stock] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_StormyProduct_StormyVendor_VendorId] FOREIGN KEY ([VendorId]) REFERENCES [StormyVendor] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [ProductAttributeValue] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [AttributeId] bigint NOT NULL,
        [ProductId] bigint NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_ProductAttributeValue] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ProductAttributeValue_ProductAttribute_AttributeId] FOREIGN KEY ([AttributeId]) REFERENCES [ProductAttribute] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_ProductAttributeValue_StormyProduct_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [StormyProduct] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [ProductLink] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [ProductId] bigint NOT NULL,
        [LinkedProductId] bigint NOT NULL,
        [LinkType] int NOT NULL,
        CONSTRAINT [PK_ProductLink] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ProductLink_StormyProduct_LinkedProductId] FOREIGN KEY ([LinkedProductId]) REFERENCES [StormyProduct] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_ProductLink_StormyProduct_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [StormyProduct] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [ProductMedia] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [Caption] nvarchar(max) NULL,
        [FileSize] int NOT NULL,
        [FileName] nvarchar(max) NULL,
        [MediaType] int NOT NULL,
        [SeoFileName] nvarchar(max) NULL,
        [StormyProductId] bigint NULL,
        CONSTRAINT [PK_ProductMedia] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ProductMedia_StormyProduct_StormyProductId] FOREIGN KEY ([StormyProductId]) REFERENCES [StormyProduct] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [ProductOptionValue] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [OptionId] bigint NOT NULL,
        [ProductId] bigint NOT NULL,
        [Value] nvarchar(450) NULL,
        [DisplayType] nvarchar(450) NULL,
        [SortIndex] int NOT NULL,
        CONSTRAINT [PK_ProductOptionValue] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ProductOptionValue_ProductOption_OptionId] FOREIGN KEY ([OptionId]) REFERENCES [ProductOption] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_ProductOptionValue_StormyProduct_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [StormyProduct] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [ProductTemplate] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [Name] nvarchar(max) NULL,
        [StormyProductId] bigint NOT NULL,
        CONSTRAINT [PK_ProductTemplate] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ProductTemplate_StormyProduct_StormyProductId] FOREIGN KEY ([StormyProductId]) REFERENCES [StormyProduct] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [ProductTemplateProductAttribute] (
        [ProductTemplateId] bigint NOT NULL,
        [ProductAttributeId] bigint NOT NULL,
        CONSTRAINT [PK_ProductTemplateProductAttribute] PRIMARY KEY ([ProductTemplateId], [ProductAttributeId]),
        CONSTRAINT [FK_ProductTemplateProductAttribute_ProductAttribute_ProductAttributeId] FOREIGN KEY ([ProductAttributeId]) REFERENCES [ProductAttribute] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemplateId] FOREIGN KEY ([ProductTemplateId]) REFERENCES [ProductTemplate] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [Shipment] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [StormyOrderId] bigint NOT NULL,
        [WhoReceives] nvarchar(max) NULL,
        [TrackNumber] nvarchar(250) NULL,
        [ShipmentMethod] nvarchar(max) NULL,
        [ShipmentServiceName] nvarchar(max) NULL,
        [ShipmentProvider] nvarchar(max) NULL,
        [TotalWeight] decimal(18,2) NOT NULL,
        [TotalHeight] decimal(18,2) NOT NULL,
        [TotalWidth] decimal(18,2) NOT NULL,
        [TotalLength] decimal(18,2) NOT NULL,
        [TotalArea] decimal(18,2) NOT NULL,
        [CreatedOn] datetime2 NOT NULL,
        [ShippedDate] datetime2 NULL,
        [DeliveryDate] datetime2 NULL,
        [ExpectedDeliveryDate] datetime2 NULL,
        [ExpectedHourOfDay] datetime2 NOT NULL,
        [Comment] nvarchar(max) NULL,
        [DeliveryCost] decimal(18,2) NOT NULL,
        [BillingAddressId] bigint NOT NULL,
        [DestinationAddressId] bigint NOT NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_Shipment] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [StormyCustomer] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [UserId] nvarchar(450) NOT NULL,
        [CPF] nvarchar(9) NULL,
        [NormalizedEmail] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [EmailConfirmed] bit NOT NULL,
        [DefaultShippingAddressId] bigint NULL,
        [DefaultBillingAddressId] bigint NULL,
        [CustomerReviewsId] bigint NULL,
        [CustomerWishlistId] bigint NULL,
        [UserName] nvarchar(max) NULL,
        [NormalizedUserName] nvarchar(max) NULL,
        [FullName] nvarchar(450) NULL,
        [Email] nvarchar(max) NOT NULL,
        [RefreshTokenHash] nvarchar(max) NULL,
        [Role] nvarchar(max) NULL,
        [CreatedOn] datetimeoffset NOT NULL,
        CONSTRAINT [PK_StormyCustomer] PRIMARY KEY ([Id]),
        CONSTRAINT [AK_StormyCustomer_UserId] UNIQUE ([UserId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [CustomerAddress] (
        [Id] bigint NOT NULL IDENTITY,
        [Address_Street] nvarchar(max) NULL,
        [Address_FirstAddress] nvarchar(max) NULL,
        [Address_SecondAddress] nvarchar(max) NULL,
        [Address_City] nvarchar(max) NULL,
        [Address_District] nvarchar(max) NULL,
        [Address_State] nvarchar(max) NULL,
        [Address_PostalCode] nvarchar(max) NULL,
        [Address_Number] nvarchar(max) NULL,
        [Address_Complement] nvarchar(max) NULL,
        [Address_Country] nvarchar(max) NULL,
        [WhoReceives] nvarchar(max) NULL,
        [IsDeleted] bit NOT NULL,
        [UserId] nvarchar(max) NULL,
        [OwnerId] bigint NULL,
        CONSTRAINT [PK_CustomerAddress] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_CustomerAddress_StormyCustomer_OwnerId] FOREIGN KEY ([OwnerId]) REFERENCES [StormyCustomer] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [Review] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [StormyCustomerId] nvarchar(450) NULL,
        [Title] nvarchar(max) NULL,
        [Comment] nvarchar(max) NULL,
        [ReviewerName] nvarchar(max) NULL,
        [RatingLevel] int NOT NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_Review] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Review_StormyCustomer_StormyCustomerId] FOREIGN KEY ([StormyCustomerId]) REFERENCES [StormyCustomer] ([UserId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [StormyOrder] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [OrderUniqueKey] uniqueidentifier NOT NULL,
        [StormyCustomerId] bigint NOT NULL,
        [UserId] nvarchar(max) NULL,
        [PaymentId] bigint NOT NULL,
        [ShipmentId] bigint NOT NULL,
        [PickUpInStore] bit NOT NULL,
        [IsCancelled] bit NOT NULL,
        [Note] nvarchar(1000) NULL,
        [Comment] nvarchar(max) NULL,
        [Discount] decimal(18,2) NOT NULL,
        [Tax] decimal(18,2) NOT NULL,
        [TotalPrice] decimal(18,2) NOT NULL,
        [OrderDate] datetime2 NOT NULL,
        [RequiredDate] datetime2 NOT NULL,
        [PaymentDate] datetime2 NULL,
        [Status] int NOT NULL,
        [StockId] bigint NULL,
        CONSTRAINT [PK_StormyOrder] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_StormyOrder_Stock_StockId] FOREIGN KEY ([StockId]) REFERENCES [Stock] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_StormyOrder_StormyCustomer_StormyCustomerId] FOREIGN KEY ([StormyCustomerId]) REFERENCES [StormyCustomer] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [Wishlist] (
        [Id] bigint NOT NULL,
        [StormyCustomerId] bigint NOT NULL,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        CONSTRAINT [PK_Wishlist] PRIMARY KEY ([Id], [StormyCustomerId]),
        CONSTRAINT [AK_Wishlist_Id] UNIQUE ([Id]),
        CONSTRAINT [FK_Wishlist_StormyCustomer_StormyCustomerId] FOREIGN KEY ([StormyCustomerId]) REFERENCES [StormyCustomer] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [OrderItem] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [Quantity] int NOT NULL,
        [Price] nvarchar(max) NULL,
        [StormyProductId] bigint NOT NULL,
        [StormyOrderId] bigint NOT NULL,
        [ShipmentId] bigint NOT NULL,
        CONSTRAINT [PK_OrderItem] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_OrderItem_Shipment_ShipmentId] FOREIGN KEY ([ShipmentId]) REFERENCES [Shipment] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_OrderItem_StormyOrder_StormyOrderId] FOREIGN KEY ([StormyOrderId]) REFERENCES [StormyOrder] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_OrderItem_StormyProduct_StormyProductId] FOREIGN KEY ([StormyProductId]) REFERENCES [StormyProduct] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [Payment] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [StormyOrderId] bigint NOT NULL,
        [CreatedOn] datetimeoffset NOT NULL,
        [Amount] decimal(18,2) NOT NULL,
        [PaymentFee] decimal(18,2) NOT NULL,
        [PaymentMethod] nvarchar(max) NULL,
        [GatewayTransactionId] nvarchar(max) NULL,
        [PaymentStatus] int NOT NULL,
        [FailureMessage] nvarchar(max) NULL,
        CONSTRAINT [PK_Payment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Payment_StormyOrder_StormyOrderId] FOREIGN KEY ([StormyOrderId]) REFERENCES [StormyOrder] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE TABLE [WishlistItem] (
        [Id] bigint NOT NULL IDENTITY,
        [LastModified] datetimeoffset NOT NULL,
        [IsDeleted] bit NOT NULL,
        [ProductId] int NOT NULL,
        [ProductId1] bigint NULL,
        [WishlistId] bigint NOT NULL,
        [AddedAt] datetime2 NOT NULL,
        [Deleted] bit NOT NULL,
        CONSTRAINT [PK_WishlistItem] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_WishlistItem_StormyProduct_ProductId1] FOREIGN KEY ([ProductId1]) REFERENCES [StormyProduct] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_WishlistItem_Wishlist_WishlistId] FOREIGN KEY ([WishlistId]) REFERENCES [Wishlist] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_ApplicationUser_RoleId] ON [ApplicationUser] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_Category_ParentId] ON [Category] ([ParentId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_CustomerAddress_OwnerId] ON [CustomerAddress] ([OwnerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_Entity_EntityTypeId] ON [Entity] ([EntityTypeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_OrderItem_ShipmentId] ON [OrderItem] ([ShipmentId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_OrderItem_StormyOrderId] ON [OrderItem] ([StormyOrderId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_OrderItem_StormyProductId] ON [OrderItem] ([StormyProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_Payment_StormyOrderId] ON [Payment] ([StormyOrderId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_ProductAttribute_GroupId] ON [ProductAttribute] ([GroupId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_ProductAttributeValue_AttributeId] ON [ProductAttributeValue] ([AttributeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_ProductAttributeValue_ProductId] ON [ProductAttributeValue] ([ProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_ProductLink_LinkedProductId] ON [ProductLink] ([LinkedProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_ProductLink_ProductId] ON [ProductLink] ([ProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_ProductMedia_StormyProductId] ON [ProductMedia] ([StormyProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_ProductOptionValue_OptionId] ON [ProductOptionValue] ([OptionId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_ProductOptionValue_ProductId] ON [ProductOptionValue] ([ProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_ProductTemplate_StormyProductId] ON [ProductTemplate] ([StormyProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_ProductTemplateProductAttribute_ProductAttributeId] ON [ProductTemplateProductAttribute] ([ProductAttributeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_Review_StormyCustomerId] ON [Review] ([StormyCustomerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_Shipment_BillingAddressId] ON [Shipment] ([BillingAddressId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_Shipment_DestinationAddressId] ON [Shipment] ([DestinationAddressId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_Shipment_StormyOrderId] ON [Shipment] ([StormyOrderId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_StormyCustomer_DefaultBillingAddressId] ON [StormyCustomer] ([DefaultBillingAddressId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_StormyCustomer_DefaultShippingAddressId] ON [StormyCustomer] ([DefaultShippingAddressId]) WHERE [DefaultShippingAddressId] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_StormyOrder_StockId] ON [StormyOrder] ([StockId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_StormyOrder_StormyCustomerId] ON [StormyOrder] ([StormyCustomerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_StormyProduct_BrandId] ON [StormyProduct] ([BrandId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_StormyProduct_CategoryId] ON [StormyProduct] ([CategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_StormyProduct_StockId] ON [StormyProduct] ([StockId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_StormyProduct_VendorId] ON [StormyProduct] ([VendorId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_StormyVendor_VendorAddressId] ON [StormyVendor] ([VendorAddressId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_Wishlist_StormyCustomerId] ON [Wishlist] ([StormyCustomerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_WishlistItem_ProductId1] ON [WishlistItem] ([ProductId1]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    CREATE INDEX [IX_WishlistItem_WishlistId] ON [WishlistItem] ([WishlistId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    ALTER TABLE [Shipment] ADD CONSTRAINT [FK_Shipment_StormyOrder_StormyOrderId] FOREIGN KEY ([StormyOrderId]) REFERENCES [StormyOrder] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    ALTER TABLE [Shipment] ADD CONSTRAINT [FK_Shipment_CustomerAddress_BillingAddressId] FOREIGN KEY ([BillingAddressId]) REFERENCES [CustomerAddress] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    ALTER TABLE [Shipment] ADD CONSTRAINT [FK_Shipment_CustomerAddress_DestinationAddressId] FOREIGN KEY ([DestinationAddressId]) REFERENCES [CustomerAddress] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    ALTER TABLE [StormyCustomer] ADD CONSTRAINT [FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId] FOREIGN KEY ([DefaultBillingAddressId]) REFERENCES [CustomerAddress] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    ALTER TABLE [StormyCustomer] ADD CONSTRAINT [FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId] FOREIGN KEY ([DefaultShippingAddressId]) REFERENCES [CustomerAddress] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191101203122_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191101203122_InitialCreate', N'2.2.6-servicing-10079');
END;

GO

