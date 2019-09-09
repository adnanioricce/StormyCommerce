using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    FirstAddress = table.Column<string>(maxLength: 250, nullable: true),
                    SecondAddress = table.Column<string>(maxLength: 250, nullable: true),
                    City = table.Column<string>(maxLength: 500, nullable: true),
                    District = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(maxLength: 9, nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Complement = table.Column<string>(maxLength: 250, nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    WhoReceives = table.Column<string>(nullable: true),
                    OwnerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
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
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 450, nullable: false),
                    Slug = table.Column<string>(maxLength: 450, nullable: false),
                    MetaTitle = table.Column<string>(maxLength: 450, nullable: true),
                    MetaKeywords = table.Column<string>(maxLength: 450, nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 450, nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    IncludeInMenu = table.Column<bool>(nullable: false),
                    ParentId = table.Column<long>(nullable: true),
                    ThumbnailImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Category_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "ProductAttributeGroup",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTemplate",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wishlist",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StormyVendor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    ContactTitle = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    AddressId1 = table.Column<long>(nullable: true),
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
                        name: "FK_StormyVendor_Address_AddressId1",
                        column: x => x.AddressId1,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                name: "StormyCustomer",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(maxLength: 9, nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    DefaultShippingAddressId = table.Column<long>(nullable: true),
                    DefaultBillingAddressId = table.Column<long>(nullable: true),
                    CustomerReviewsId = table.Column<long>(nullable: false),
                    CustomerWishlistId = table.Column<long>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(maxLength: 450, nullable: true),
                    Email = table.Column<string>(nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StormyCustomer_Address_DefaultBillingAddressId",
                        column: x => x.DefaultBillingAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StormyCustomer_Address_DefaultShippingAddressId",
                        column: x => x.DefaultShippingAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StormyProduct",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SKU = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 400, nullable: false),
                    Slug = table.Column<string>(nullable: true),
                    BrandId = table.Column<long>(nullable: false),
                    MediaId = table.Column<long>(nullable: false),
                    VendorId = table.Column<long>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    ProductLinksId = table.Column<long>(nullable: false),
                    TypeName = table.Column<string>(nullable: false),
                    QuantityPerUnity = table.Column<int>(nullable: false),
                    UnitSize = table.Column<decimal>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    UnitWeight = table.Column<double>(nullable: false),
                    UnitsInStock = table.Column<int>(nullable: false),
                    UnitsOnOrder = table.Column<int>(nullable: false),
                    ProductAvailable = table.Column<bool>(nullable: false),
                    DiscountAvailable = table.Column<bool>(nullable: false),
                    StockTrackingIsEnabled = table.Column<bool>(nullable: false),
                    ThumbnailImage = table.Column<string>(nullable: true),
                    Ranking = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    OldPrice = table.Column<string>(nullable: true),
                    HasDiscountApplied = table.Column<bool>(nullable: false),
                    Published = table.Column<bool>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    NotReturnable = table.Column<bool>(nullable: false),
                    AvailableForPreorder = table.Column<bool>(nullable: false),
                    ProductCost = table.Column<decimal>(nullable: false),
                    PreOrderAvailabilityStartDate = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(nullable: false),
                    AllowCustomerReview = table.Column<bool>(nullable: false),
                    ApprovedRatingSum = table.Column<int>(nullable: false),
                    NotApprovedRatingSum = table.Column<int>(nullable: false),
                    ApprovedTotalReviews = table.Column<int>(nullable: false),
                    NotApprovedTotalReviews = table.Column<int>(nullable: false)
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
                        name: "FK_StormyProduct_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StormyProduct_StormyVendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "StormyVendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StormyCustomerId = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    ReviewerName = table.Column<string>(nullable: true),
                    RatingLevel = table.Column<int>(nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StormyCustomerId = table.Column<long>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    WhoReceives = table.Column<string>(nullable: true),
                    TrackNumber = table.Column<string>(maxLength: 250, nullable: true),
                    ShipmentMethod = table.Column<string>(nullable: true),
                    ShipmentProviderName = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<decimal>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ShippedDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    DeliveryCost = table.Column<decimal>(nullable: false),
                    BillingAddressId = table.Column<long>(nullable: false),
                    DestinationAddressId = table.Column<long>(nullable: false),
                    Height = table.Column<decimal>(nullable: false),
                    Width = table.Column<decimal>(nullable: false),
                    Diameter = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipment_Address_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipment_Address_DestinationAddressId",
                        column: x => x.DestinationAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipment_StormyCustomer_StormyCustomerId",
                        column: x => x.StormyCustomerId,
                        principalTable: "StormyCustomer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Caption = table.Column<string>(nullable: true),
                    FileSize = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    MediaType = table.Column<int>(nullable: false),
                    SeoFileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_StormyProduct_Id",
                        column: x => x.Id,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttribute",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    GroupId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StormyProductId = table.Column<long>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_ProductAttribute_StormyProduct_StormyProductId",
                        column: x => x.StormyProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductLink",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
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
                        name: "FK_ProductLink_StormyProduct_Id",
                        column: x => x.Id,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductLink_StormyProduct_LinkedProductId",
                        column: x => x.LinkedProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductLink_StormyProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOptionValue",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                name: "WishlistItem",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ProductId1 = table.Column<long>(nullable: true),
                    WishlistId = table.Column<long>(nullable: false),
                    AddedAt = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishlistItem_StormyProduct_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "StormyProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WishlistItem_Wishlist_WishlistId",
                        column: x => x.WishlistId,
                        principalTable: "Wishlist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentItem",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ShipmentId = table.Column<int>(nullable: false),
                    OrderItemId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ShipmentId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentItem_Shipment_ShipmentId1",
                        column: x => x.ShipmentId1,
                        principalTable: "Shipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StormyOrder",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OrderUniqueKey = table.Column<Guid>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    PaymentId = table.Column<long>(nullable: false),
                    ShipmentId = table.Column<long>(nullable: false),
                    PickUpInStore = table.Column<bool>(nullable: false),
                    IsCancelled = table.Column<bool>(nullable: false),
                    ShippingMethod = table.Column<string>(nullable: true),
                    PaymentMethod = table.Column<string>(maxLength: 450, nullable: false),
                    TrackNumber = table.Column<string>(nullable: true),
                    Note = table.Column<string>(maxLength: 1000, nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Discount = table.Column<decimal>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    TotalWeight = table.Column<decimal>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    DeliveryCost = table.Column<decimal>(nullable: false),
                    ShippingAddressId = table.Column<long>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    RequiredDate = table.Column<DateTime>(nullable: false),
                    ShippedDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    ShippingStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StormyOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StormyOrder_StormyCustomer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "StormyCustomer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StormyOrder_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StormyOrder_Address_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeValue",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                        name: "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAtt~",
                        column: x => x.ProductAttributeId,
                        principalTable: "ProductAttribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemp~",
                        column: x => x.ProductTemplateId,
                        principalTable: "ProductTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastModified = table.Column<DateTimeOffset>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<string>(nullable: true),
                    StormyProductId = table.Column<long>(nullable: false),
                    StormyOrderId = table.Column<long>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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

            // migrationBuilder.InsertData(
            //     table: "ProductLink",
            //     columns: new[] { "Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId" },
            //     values: new object[,]
            //     {
            //         { 1L, false, new DateTimeOffset(new DateTime(2019, 9, 7, 8, 0, 58, 754, DateTimeKind.Unspecified).AddTicks(6053), new TimeSpan(0, -3, 0, 0, 0)), 2, 47L, 30L },
            //         { 28L, false, new DateTimeOffset(new DateTime(2019, 9, 2, 16, 39, 40, 824, DateTimeKind.Unspecified).AddTicks(4275), new TimeSpan(0, -3, 0, 0, 0)), 2, 28L, 35L },
            //         { 29L, false, new DateTimeOffset(new DateTime(2019, 8, 26, 12, 57, 11, 292, DateTimeKind.Unspecified).AddTicks(2868), new TimeSpan(0, -3, 0, 0, 0)), 2, 46L, 48L },
            //         { 30L, false, new DateTimeOffset(new DateTime(2019, 8, 28, 8, 50, 52, 59, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, -3, 0, 0, 0)), 2, 6L, 5L },
            //         { 31L, false, new DateTimeOffset(new DateTime(2019, 8, 19, 10, 11, 28, 692, DateTimeKind.Unspecified).AddTicks(9890), new TimeSpan(0, -3, 0, 0, 0)), 2, 41L, 49L },
            //         { 32L, false, new DateTimeOffset(new DateTime(2019, 8, 19, 7, 39, 44, 477, DateTimeKind.Unspecified).AddTicks(6341), new TimeSpan(0, -3, 0, 0, 0)), 2, 33L, 24L },
            //         { 33L, false, new DateTimeOffset(new DateTime(2019, 8, 21, 6, 5, 27, 513, DateTimeKind.Unspecified).AddTicks(9913), new TimeSpan(0, -3, 0, 0, 0)), 2, 5L, 42L },
            //         { 34L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 12, 24, 34, 864, DateTimeKind.Unspecified).AddTicks(4906), new TimeSpan(0, -3, 0, 0, 0)), 2, 15L, 27L },
            //         { 35L, false, new DateTimeOffset(new DateTime(2019, 8, 19, 19, 4, 23, 170, DateTimeKind.Unspecified).AddTicks(5609), new TimeSpan(0, -3, 0, 0, 0)), 2, 35L, 9L },
            //         { 36L, false, new DateTimeOffset(new DateTime(2019, 8, 23, 10, 19, 30, 213, DateTimeKind.Unspecified).AddTicks(7084), new TimeSpan(0, -3, 0, 0, 0)), 2, 35L, 49L },
            //         { 37L, false, new DateTimeOffset(new DateTime(2019, 9, 1, 18, 32, 56, 39, DateTimeKind.Unspecified).AddTicks(9452), new TimeSpan(0, -3, 0, 0, 0)), 2, 18L, 34L },
            //         { 27L, false, new DateTimeOffset(new DateTime(2019, 8, 26, 2, 50, 41, 69, DateTimeKind.Unspecified).AddTicks(2021), new TimeSpan(0, -3, 0, 0, 0)), 2, 12L, 36L },
            //         { 38L, false, new DateTimeOffset(new DateTime(2019, 8, 29, 10, 43, 53, 939, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, -3, 0, 0, 0)), 2, 20L, 16L },
            //         { 40L, false, new DateTimeOffset(new DateTime(2019, 9, 3, 17, 55, 6, 755, DateTimeKind.Unspecified).AddTicks(6008), new TimeSpan(0, -3, 0, 0, 0)), 2, 5L, 24L },
            //         { 41L, false, new DateTimeOffset(new DateTime(2019, 9, 2, 14, 7, 35, 139, DateTimeKind.Unspecified).AddTicks(7231), new TimeSpan(0, -3, 0, 0, 0)), 2, 31L, 4L },
            //         { 42L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 1, 35, 31, 431, DateTimeKind.Unspecified).AddTicks(5718), new TimeSpan(0, -3, 0, 0, 0)), 2, 24L, 19L },
            //         { 43L, false, new DateTimeOffset(new DateTime(2019, 8, 26, 17, 32, 23, 399, DateTimeKind.Unspecified).AddTicks(5364), new TimeSpan(0, -3, 0, 0, 0)), 2, 6L, 40L },
            //         { 44L, false, new DateTimeOffset(new DateTime(2019, 9, 6, 2, 20, 36, 664, DateTimeKind.Unspecified).AddTicks(7837), new TimeSpan(0, -3, 0, 0, 0)), 2, 41L, 38L },
            //         { 45L, false, new DateTimeOffset(new DateTime(2019, 8, 19, 3, 13, 56, 41, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, -3, 0, 0, 0)), 2, 33L, 47L },
            //         { 46L, false, new DateTimeOffset(new DateTime(2019, 9, 4, 19, 51, 48, 860, DateTimeKind.Unspecified).AddTicks(1899), new TimeSpan(0, -3, 0, 0, 0)), 2, 23L, 43L },
            //         { 47L, false, new DateTimeOffset(new DateTime(2019, 8, 27, 2, 20, 38, 831, DateTimeKind.Unspecified).AddTicks(1463), new TimeSpan(0, -3, 0, 0, 0)), 2, 44L, 11L },
            //         { 48L, false, new DateTimeOffset(new DateTime(2019, 8, 15, 14, 2, 4, 978, DateTimeKind.Unspecified).AddTicks(4297), new TimeSpan(0, -3, 0, 0, 0)), 2, 9L, 38L },
            //         { 49L, false, new DateTimeOffset(new DateTime(2019, 8, 28, 23, 1, 0, 503, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, -3, 0, 0, 0)), 2, 21L, 21L },
            //         { 39L, false, new DateTimeOffset(new DateTime(2019, 9, 4, 7, 19, 16, 182, DateTimeKind.Unspecified).AddTicks(1040), new TimeSpan(0, -3, 0, 0, 0)), 2, 17L, 41L },
            //         { 50L, false, new DateTimeOffset(new DateTime(2019, 8, 23, 3, 5, 39, 174, DateTimeKind.Unspecified).AddTicks(1042), new TimeSpan(0, -3, 0, 0, 0)), 2, 32L, 16L },
            //         { 26L, false, new DateTimeOffset(new DateTime(2019, 8, 26, 2, 50, 26, 515, DateTimeKind.Unspecified).AddTicks(8681), new TimeSpan(0, -3, 0, 0, 0)), 2, 43L, 33L },
            //         { 24L, false, new DateTimeOffset(new DateTime(2019, 9, 1, 16, 33, 58, 268, DateTimeKind.Unspecified).AddTicks(3115), new TimeSpan(0, -3, 0, 0, 0)), 2, 9L, 26L },
            //         { 2L, false, new DateTimeOffset(new DateTime(2019, 9, 4, 23, 49, 15, 30, DateTimeKind.Unspecified).AddTicks(9943), new TimeSpan(0, -3, 0, 0, 0)), 2, 16L, 17L },
            //         { 3L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 11, 21, 53, 943, DateTimeKind.Unspecified).AddTicks(3232), new TimeSpan(0, -3, 0, 0, 0)), 2, 46L, 17L },
            //         { 4L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 7, 26, 15, 519, DateTimeKind.Unspecified).AddTicks(7062), new TimeSpan(0, -3, 0, 0, 0)), 2, 28L, 21L },
            //         { 5L, false, new DateTimeOffset(new DateTime(2019, 9, 3, 14, 55, 14, 930, DateTimeKind.Unspecified).AddTicks(689), new TimeSpan(0, -3, 0, 0, 0)), 2, 15L, 10L },
            //         { 6L, false, new DateTimeOffset(new DateTime(2019, 8, 16, 17, 52, 42, 767, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, -3, 0, 0, 0)), 2, 2L, 33L },
            //         { 7L, false, new DateTimeOffset(new DateTime(2019, 8, 23, 2, 46, 3, 885, DateTimeKind.Unspecified).AddTicks(6089), new TimeSpan(0, -3, 0, 0, 0)), 2, 21L, 10L },
            //         { 8L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 22, 3, 15, 325, DateTimeKind.Unspecified).AddTicks(8221), new TimeSpan(0, -3, 0, 0, 0)), 2, 43L, 33L },
            //         { 9L, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 47, 35, 909, DateTimeKind.Unspecified).AddTicks(6269), new TimeSpan(0, -3, 0, 0, 0)), 2, 22L, 38L },
            //         { 10L, false, new DateTimeOffset(new DateTime(2019, 8, 26, 15, 2, 10, 99, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, -3, 0, 0, 0)), 2, 2L, 36L },
            //         { 11L, false, new DateTimeOffset(new DateTime(2019, 8, 26, 13, 9, 26, 988, DateTimeKind.Unspecified).AddTicks(2950), new TimeSpan(0, -3, 0, 0, 0)), 2, 18L, 17L },
            //         { 25L, false, new DateTimeOffset(new DateTime(2019, 8, 16, 9, 31, 38, 361, DateTimeKind.Unspecified).AddTicks(5716), new TimeSpan(0, -3, 0, 0, 0)), 2, 22L, 30L },
            //         { 12L, false, new DateTimeOffset(new DateTime(2019, 9, 8, 6, 55, 26, 578, DateTimeKind.Unspecified).AddTicks(4828), new TimeSpan(0, -3, 0, 0, 0)), 2, 31L, 45L },
            //         { 14L, false, new DateTimeOffset(new DateTime(2019, 9, 3, 0, 10, 13, 49, DateTimeKind.Unspecified).AddTicks(5229), new TimeSpan(0, -3, 0, 0, 0)), 2, 42L, 32L },
            //         { 15L, false, new DateTimeOffset(new DateTime(2019, 8, 21, 23, 31, 21, 177, DateTimeKind.Unspecified).AddTicks(8038), new TimeSpan(0, -3, 0, 0, 0)), 2, 10L, 5L },
            //         { 16L, false, new DateTimeOffset(new DateTime(2019, 8, 30, 14, 58, 4, 562, DateTimeKind.Unspecified).AddTicks(5780), new TimeSpan(0, -3, 0, 0, 0)), 2, 37L, 25L },
            //         { 17L, false, new DateTimeOffset(new DateTime(2019, 8, 15, 9, 38, 36, 794, DateTimeKind.Unspecified).AddTicks(789), new TimeSpan(0, -3, 0, 0, 0)), 2, 18L, 9L },
            //         { 18L, false, new DateTimeOffset(new DateTime(2019, 8, 24, 2, 10, 45, 586, DateTimeKind.Unspecified).AddTicks(486), new TimeSpan(0, -3, 0, 0, 0)), 2, 21L, 44L },
            //         { 19L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 4, 43, 53, 231, DateTimeKind.Unspecified).AddTicks(115), new TimeSpan(0, -3, 0, 0, 0)), 2, 26L, 4L },
            //         { 20L, false, new DateTimeOffset(new DateTime(2019, 8, 16, 8, 21, 23, 576, DateTimeKind.Unspecified).AddTicks(5295), new TimeSpan(0, -3, 0, 0, 0)), 2, 28L, 45L },
            //         { 21L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 7, 32, 21, 975, DateTimeKind.Unspecified).AddTicks(1863), new TimeSpan(0, -3, 0, 0, 0)), 2, 19L, 45L },
            //         { 22L, false, new DateTimeOffset(new DateTime(2019, 8, 24, 4, 2, 3, 933, DateTimeKind.Unspecified).AddTicks(4655), new TimeSpan(0, -3, 0, 0, 0)), 2, 19L, 10L },
            //         { 23L, false, new DateTimeOffset(new DateTime(2019, 9, 7, 2, 23, 1, 633, DateTimeKind.Unspecified).AddTicks(8526), new TimeSpan(0, -3, 0, 0, 0)), 2, 10L, 35L },
            //         { 13L, false, new DateTimeOffset(new DateTime(2019, 8, 21, 2, 16, 2, 357, DateTimeKind.Unspecified).AddTicks(2376), new TimeSpan(0, -3, 0, 0, 0)), 2, 27L, 36L }
            //     });

            // migrationBuilder.InsertData(
            //     table: "Shipment",
            //     columns: new[] { "Id", "BillingAddressId", "Comment", "CreatedOn", "DeliveryCost", "DeliveryDate", "DestinationAddressId", "Diameter", "Height", "IsDeleted", "LastModified", "Price", "ShipmentMethod", "ShipmentProviderName", "ShippedDate", "StormyCustomerId", "TotalWeight", "TrackNumber", "UserId", "WhoReceives", "Width" },
            //     values: new object[] { 2L, 0L, "a single comment", new DateTime(2019, 9, 9, 0, 54, 23, 921, DateTimeKind.Utc).AddTicks(7393), 22.29m, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 0L, 0m, 0m, false, new DateTimeOffset(new DateTime(2019, 9, 9, 0, 54, 23, 921, DateTimeKind.Unspecified).AddTicks(6993), new TimeSpan(0, 0, 0, 0, 0)), 20.99m, null, null, new DateTime(2019, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 0L, 0.400m, "21f7844d-3741-4f86-93d3-46f26f3349bf", null, null, 0m });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentId",
                table: "Category",
                column: "ParentId");

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
                name: "IX_ProductAttribute_StormyProductId",
                table: "ProductAttribute",
                column: "StormyProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValue_AttributeId",
                table: "ProductAttributeValue",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValue_ProductId",
                table: "ProductAttributeValue",
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
                name: "IX_ProductOptionValue_OptionId",
                table: "ProductOptionValue",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptionValue_ProductId",
                table: "ProductOptionValue",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTemplateProductAttribute_ProductAttributeId",
                table: "ProductTemplateProductAttribute",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_StormyCustomerId",
                table: "Review",
                column: "StormyCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_BillingAddressId",
                table: "Shipment",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_DestinationAddressId",
                table: "Shipment",
                column: "DestinationAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_StormyCustomerId",
                table: "Shipment",
                column: "StormyCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentItem_ShipmentId1",
                table: "ShipmentItem",
                column: "ShipmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_StormyCustomer_CustomerWishlistId",
                table: "StormyCustomer",
                column: "CustomerWishlistId",
                unique: true);

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
                name: "IX_StormyOrder_ShipmentId",
                table: "StormyOrder",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyOrder_ShippingAddressId",
                table: "StormyOrder",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyProduct_BrandId",
                table: "StormyProduct",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyProduct_CategoryId",
                table: "StormyProduct",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StormyProduct_VendorId",
                table: "StormyProduct",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyVendor_AddressId1",
                table: "StormyVendor",
                column: "AddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_ProductId1",
                table: "WishlistItem",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_WishlistId",
                table: "WishlistItem",
                column: "WishlistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUser");

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
                name: "Media");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "ProductAttributeValue");

            migrationBuilder.DropTable(
                name: "ProductLink");

            migrationBuilder.DropTable(
                name: "ProductOptionValue");

            migrationBuilder.DropTable(
                name: "ProductTemplateProductAttribute");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "ShipmentItem");

            migrationBuilder.DropTable(
                name: "WishlistItem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "EntityType");

            migrationBuilder.DropTable(
                name: "StormyOrder");

            migrationBuilder.DropTable(
                name: "ProductOption");

            migrationBuilder.DropTable(
                name: "ProductAttribute");

            migrationBuilder.DropTable(
                name: "ProductTemplate");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "ProductAttributeGroup");

            migrationBuilder.DropTable(
                name: "StormyProduct");

            migrationBuilder.DropTable(
                name: "StormyCustomer");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "StormyVendor");

            migrationBuilder.DropTable(
                name: "Wishlist");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
