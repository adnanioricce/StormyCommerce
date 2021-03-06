﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppSettings",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Value = table.Column<string>(maxLength: 450, nullable: true),
                    Module = table.Column<string>(maxLength: 450, nullable: true),
                    IsVisibleInCommonSettingPage = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(maxLength: 450, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    LogoImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 450, nullable: false),
                    Slug = table.Column<string>(maxLength: 450, nullable: false),
                    Description = table.Column<string>(maxLength: 450, nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    IncludeInMenu = table.Column<bool>(nullable: false),
                    ParentId = table.Column<long>(nullable: true),
                    ChildrenId = table.Column<long>(nullable: true),
                    ThumbnailImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityType",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 450, nullable: false),
                    IsMenuable = table.Column<bool>(nullable: false),
                    AreaName = table.Column<string>(maxLength: 450, nullable: true),
                    RoutingController = table.Column<string>(maxLength: 450, nullable: true),
                    RoutingAction = table.Column<string>(maxLength: 450, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Caption = table.Column<string>(nullable: true),
                    FileSize = table.Column<long>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    MediaType = table.Column<int>(nullable: false),
                    SeoFileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeGroup",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductOption",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VendorAddress",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address_Street = table.Column<string>(nullable: true),
                    Address_FirstAddress = table.Column<string>(nullable: true),
                    Address_SecondAddress = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_District = table.Column<string>(nullable: true),
                    Address_State = table.Column<string>(nullable: true),
                    Address_PostalCode = table.Column<string>(nullable: true),
                    Address_Number = table.Column<string>(nullable: true),
                    Address_Complement = table.Column<string>(nullable: true),
                    Address_Country = table.Column<string>(nullable: true),
                    WhoReceives = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wishlist",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StormyCustomerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Slug = table.Column<string>(maxLength: 450, nullable: false),
                    Name = table.Column<string>(maxLength: 450, nullable: false),
                    EntityId = table.Column<long>(nullable: false),
                    EntityTypeId = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entity_EntityType_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalTable: "EntityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttribute",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    GroupId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttribute_ProductAttributeGroup_GroupId",
                        column: x => x.GroupId,
                        principalTable: "ProductAttributeGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StormyVendor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    ContactTitle = table.Column<string>(nullable: true),
                    VendorAddressId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true),
                    TypeGoods = table.Column<string>(nullable: true),
                    SizeUrl = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StormyVendor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StormyVendor_VendorAddress_VendorAddressId",
                        column: x => x.VendorAddressId,
                        principalTable: "VendorAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StormyProduct",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SKU = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 400, nullable: false),
                    Slug = table.Column<string>(nullable: true),
                    BrandId = table.Column<long>(nullable: false),
                    VendorId = table.Column<long>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    MediaId = table.Column<long>(nullable: true),
                    ProductLinksId = table.Column<long>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    QuantityPerUnity = table.Column<int>(nullable: false),
                    AvailableSizes = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    UnitWeight = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    Diameter = table.Column<double>(nullable: true),
                    UnitsInStock = table.Column<int>(nullable: false),
                    UnitsOnOrder = table.Column<int>(nullable: false),
                    ThumbnailImage = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    ProductCost = table.Column<decimal>(nullable: false),
                    PublishedOn = table.Column<DateTime>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    RatingAverage = table.Column<int>(nullable: false),
                    StockId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StormyProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StormyProduct_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StormyProduct_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StormyProduct_StormyVendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "StormyVendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeValue",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AttributeId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributeValue_ProductAttribute_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "ProductAttribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAttributeValue_StormyProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductCategory_StormyProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductLink",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    LinkedProductId = table.Column<long>(nullable: false),
                    LinkType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductLink_StormyProduct_LinkedProductId",
                        column: x => x.LinkedProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductLink_StormyProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductMedia",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    MediaId = table.Column<long>(nullable: false),
                    StormyProductId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMedia_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductMedia_StormyProduct_StormyProductId",
                        column: x => x.StormyProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductOptionValue",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OptionId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Value = table.Column<string>(maxLength: 450, nullable: true),
                    DisplayType = table.Column<string>(maxLength: 450, nullable: true),
                    SortIndex = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOptionValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOptionValue_ProductOption_OptionId",
                        column: x => x.OptionId,
                        principalTable: "ProductOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOptionValue_StormyProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTemplate",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StormyProductId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTemplate_StormyProduct_StormyProductId",
                        column: x => x.StormyProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishlistItem",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    WishlistId = table.Column<long>(nullable: false),
                    AddedAt = table.Column<DateTime>(nullable: false),
                    WishlistId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishlistItem_StormyProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WishlistItem_Wishlist_WishlistId",
                        column: x => x.WishlistId,
                        principalTable: "Wishlist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WishlistItem_Wishlist_WishlistId1",
                        column: x => x.WishlistId1,
                        principalTable: "Wishlist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductTemplateProductAttribute",
                columns: table => new
                {
                    ProductTemplateId = table.Column<long>(nullable: false),
                    ProductAttributeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTemplateProductAttribute", x => new { x.ProductTemplateId, x.ProductAttributeId });
                    table.ForeignKey(
                        name: "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalTable: "ProductAttribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemplateId",
                        column: x => x.ProductTemplateId,
                        principalTable: "ProductTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StormyOrderId = table.Column<long>(nullable: false),
                    WhoReceives = table.Column<string>(nullable: true),
                    TrackNumber = table.Column<string>(maxLength: 250, nullable: true),
                    ShipmentMethod = table.Column<string>(nullable: true),
                    ShipmentServiceName = table.Column<string>(nullable: true),
                    ShipmentProvider = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<double>(nullable: false),
                    TotalHeight = table.Column<double>(nullable: false),
                    TotalWidth = table.Column<double>(nullable: false),
                    TotalLength = table.Column<double>(nullable: false),
                    TotalArea = table.Column<double>(nullable: false),
                    CubeRoot = table.Column<double>(nullable: false),
                    SafeAmount = table.Column<decimal>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ShippedDate = table.Column<DateTime>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: true),
                    ExpectedDeliveryDate = table.Column<DateTime>(nullable: true),
                    ExpectedHourOfDay = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    DeliveryCost = table.Column<decimal>(nullable: false),
                    BillingAddressId = table.Column<long>(nullable: false),
                    DestinationAddressId = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StormyCustomer",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    CPF = table.Column<string>(maxLength: 9, nullable: true),
                    DefaultShippingAddressId = table.Column<long>(nullable: true),
                    DefaultBillingAddressId = table.Column<long>(nullable: true),
                    CustomerReviewsId = table.Column<long>(nullable: true),
                    CustomerWishlistId = table.Column<long>(nullable: true),
                    FullName = table.Column<string>(maxLength: 450, nullable: true),
                    RefreshTokenHash = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StormyCustomer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StormyCustomer_Wishlist_CustomerWishlistId",
                        column: x => x.CustomerWishlistId,
                        principalTable: "Wishlist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRole",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    StormyCustomerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationRole_StormyCustomer_StormyCustomerId",
                        column: x => x.StormyCustomerId,
                        principalTable: "StormyCustomer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address_Street = table.Column<string>(nullable: true),
                    Address_FirstAddress = table.Column<string>(nullable: true),
                    Address_SecondAddress = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_District = table.Column<string>(nullable: true),
                    Address_State = table.Column<string>(nullable: true),
                    Address_PostalCode = table.Column<string>(nullable: true),
                    Address_Number = table.Column<string>(nullable: true),
                    Address_Complement = table.Column<string>(nullable: true),
                    Address_Country = table.Column<string>(nullable: true),
                    WhoReceives = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    OwnerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_StormyCustomer_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "StormyCustomer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StormyCustomerId = table.Column<string>(nullable: false),
                    StormyProductId = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    ReviewerName = table.Column<string>(nullable: true),
                    RatingLevel = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_StormyCustomer_StormyCustomerId",
                        column: x => x.StormyCustomerId,
                        principalTable: "StormyCustomer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_StormyProduct_StormyProductId",
                        column: x => x.StormyProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StormyOrder",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OrderUniqueKey = table.Column<Guid>(nullable: false),
                    StormyCustomerId = table.Column<long>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    PaymentId = table.Column<long>(nullable: false),
                    ShipmentId = table.Column<long>(nullable: false),
                    PickUpInStore = table.Column<bool>(nullable: false),
                    IsCancelled = table.Column<bool>(nullable: false),
                    Note = table.Column<string>(maxLength: 1000, nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Discount = table.Column<decimal>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    RequiredDate = table.Column<DateTime>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    StockId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StormyOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StormyOrder_StormyCustomer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "StormyCustomer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StormyOrder_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<string>(nullable: true),
                    StormyProductId = table.Column<long>(nullable: false),
                    StormyOrderId = table.Column<long>(nullable: false),
                    ShipmentId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_StormyOrder_StormyOrderId",
                        column: x => x.StormyOrderId,
                        principalTable: "StormyOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_StormyProduct_StormyProductId",
                        column: x => x.StormyProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StormyOrderId = table.Column<long>(nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    PaymentFee = table.Column<decimal>(nullable: false),
                    PaymentMethod = table.Column<string>(nullable: true),
                    GatewayTransactionId = table.Column<string>(nullable: true),
                    PaymentStatus = table.Column<int>(nullable: false),
                    FailureMessage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_StormyOrder_StormyOrderId",
                        column: x => x.StormyOrderId,
                        principalTable: "StormyOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRole_StormyCustomerId",
                table: "ApplicationRole",
                column: "StormyCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_OwnerId",
                table: "CustomerAddress",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_EntityTypeId",
                table: "Entity",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ShipmentId",
                table: "OrderItem",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_StormyOrderId",
                table: "OrderItem",
                column: "StormyOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_StormyProductId",
                table: "OrderItem",
                column: "StormyProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_StormyOrderId",
                table: "Payment",
                column: "StormyOrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttribute_GroupId",
                table: "ProductAttribute",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValue_AttributeId",
                table: "ProductAttributeValue",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValue_ProductId",
                table: "ProductAttributeValue",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_CategoryId",
                table: "ProductCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_ProductId",
                table: "ProductCategory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLink_LinkedProductId",
                table: "ProductLink",
                column: "LinkedProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLink_ProductId",
                table: "ProductLink",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMedia_MediaId",
                table: "ProductMedia",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMedia_StormyProductId",
                table: "ProductMedia",
                column: "StormyProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptionValue_OptionId",
                table: "ProductOptionValue",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptionValue_ProductId",
                table: "ProductOptionValue",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTemplate_StormyProductId",
                table: "ProductTemplate",
                column: "StormyProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTemplateProductAttribute_ProductAttributeId",
                table: "ProductTemplateProductAttribute",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_StormyCustomerId",
                table: "Review",
                column: "StormyCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_StormyProductId",
                table: "Review",
                column: "StormyProductId");

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
                name: "IX_Shipment_StormyOrderId",
                table: "Shipment",
                column: "StormyOrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_CustomerWishlistId",
                table: "StormyCustomer",
                column: "CustomerWishlistId",
                unique: true,
                filter: "[CustomerWishlistId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_DefaultBillingAddressId",
                table: "StormyCustomer",
                column: "DefaultBillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_DefaultShippingAddressId",
                table: "StormyCustomer",
                column: "DefaultShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyOrder_CustomerId",
                table: "StormyOrder",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyOrder_StockId",
                table: "StormyOrder",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyProduct_BrandId",
                table: "StormyProduct",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyProduct_StockId",
                table: "StormyProduct",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyProduct_VendorId",
                table: "StormyProduct",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyVendor_VendorAddressId",
                table: "StormyVendor",
                column: "VendorAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_ProductId",
                table: "WishlistItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_WishlistId",
                table: "WishlistItem",
                column: "WishlistId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_WishlistId1",
                table: "WishlistItem",
                column: "WishlistId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_StormyOrder_StormyOrderId",
                table: "Shipment",
                column: "StormyOrderId",
                principalTable: "StormyOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_CustomerAddress_BillingAddressId",
                table: "Shipment",
                column: "BillingAddressId",
                principalTable: "CustomerAddress",
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
                name: "FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId",
                table: "StormyCustomer",
                column: "DefaultBillingAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId",
                table: "StormyCustomer",
                column: "DefaultShippingAddressId",
                principalTable: "CustomerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_StormyCustomer_OwnerId",
                table: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "ApplicationRole");

            migrationBuilder.DropTable(
                name: "AppSettings");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Entity");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "ProductAttributeValue");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "ProductLink");

            migrationBuilder.DropTable(
                name: "ProductMedia");

            migrationBuilder.DropTable(
                name: "ProductOptionValue");

            migrationBuilder.DropTable(
                name: "ProductTemplateProductAttribute");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "WishlistItem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "EntityType");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "ProductOption");

            migrationBuilder.DropTable(
                name: "ProductAttribute");

            migrationBuilder.DropTable(
                name: "ProductTemplate");

            migrationBuilder.DropTable(
                name: "StormyOrder");

            migrationBuilder.DropTable(
                name: "ProductAttributeGroup");

            migrationBuilder.DropTable(
                name: "StormyProduct");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "StormyVendor");

            migrationBuilder.DropTable(
                name: "VendorAddress");

            migrationBuilder.DropTable(
                name: "StormyCustomer");

            migrationBuilder.DropTable(
                name: "Wishlist");

            migrationBuilder.DropTable(
                name: "CustomerAddress");
        }
    }
}
