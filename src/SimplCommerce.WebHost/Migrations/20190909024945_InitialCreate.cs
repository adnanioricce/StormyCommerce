using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class InitialCreate : Migration
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
            //         { 1L, false, new DateTimeOffset(new DateTime(2019, 9, 2, 0, 59, 50, 286, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, 0, 0, 0, 0)), 2, 14L, 46L },
            //         { 28L, false, new DateTimeOffset(new DateTime(2019, 8, 16, 23, 30, 32, 602, DateTimeKind.Unspecified).AddTicks(5657), new TimeSpan(0, 0, 0, 0, 0)), 2, 42L, 13L },
            //         { 29L, false, new DateTimeOffset(new DateTime(2019, 9, 8, 6, 5, 27, 613, DateTimeKind.Unspecified).AddTicks(5065), new TimeSpan(0, 0, 0, 0, 0)), 2, 16L, 50L },
            //         { 30L, false, new DateTimeOffset(new DateTime(2019, 8, 30, 23, 50, 55, 499, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 0, 0, 0, 0)), 2, 6L, 24L },
            //         { 31L, false, new DateTimeOffset(new DateTime(2019, 9, 2, 10, 8, 16, 511, DateTimeKind.Unspecified).AddTicks(8473), new TimeSpan(0, 0, 0, 0, 0)), 2, 13L, 18L },
            //         { 32L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 11, 10, 20, 497, DateTimeKind.Unspecified).AddTicks(3268), new TimeSpan(0, 0, 0, 0, 0)), 2, 41L, 49L },
            //         { 33L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 23, 17, 35, 599, DateTimeKind.Unspecified).AddTicks(2357), new TimeSpan(0, 0, 0, 0, 0)), 2, 9L, 4L },
            //         { 34L, false, new DateTimeOffset(new DateTime(2019, 9, 1, 9, 34, 32, 922, DateTimeKind.Unspecified).AddTicks(8342), new TimeSpan(0, 0, 0, 0, 0)), 2, 4L, 20L },
            //         { 35L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 9, 22, 40, 249, DateTimeKind.Unspecified).AddTicks(7369), new TimeSpan(0, 0, 0, 0, 0)), 2, 33L, 33L },
            //         { 36L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 22, 3, 49, 845, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 0, 0, 0, 0)), 2, 21L, 13L },
            //         { 37L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 8, 1, 59, 741, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 0, 0, 0, 0)), 2, 50L, 47L },
            //         { 27L, false, new DateTimeOffset(new DateTime(2019, 8, 23, 21, 53, 57, 34, DateTimeKind.Unspecified).AddTicks(3563), new TimeSpan(0, 0, 0, 0, 0)), 2, 42L, 29L },
            //         { 38L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 14, 23, 3, 388, DateTimeKind.Unspecified).AddTicks(4099), new TimeSpan(0, 0, 0, 0, 0)), 2, 48L, 2L },
            //         { 40L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 12, 28, 14, 501, DateTimeKind.Unspecified).AddTicks(9822), new TimeSpan(0, 0, 0, 0, 0)), 2, 45L, 33L },
            //         { 41L, false, new DateTimeOffset(new DateTime(2019, 8, 31, 7, 57, 43, 732, DateTimeKind.Unspecified).AddTicks(7630), new TimeSpan(0, 0, 0, 0, 0)), 2, 35L, 14L },
            //         { 42L, false, new DateTimeOffset(new DateTime(2019, 8, 19, 13, 10, 9, 482, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 0, 0, 0, 0)), 2, 44L, 18L },
            //         { 43L, false, new DateTimeOffset(new DateTime(2019, 9, 3, 16, 17, 43, 569, DateTimeKind.Unspecified).AddTicks(4204), new TimeSpan(0, 0, 0, 0, 0)), 2, 49L, 37L },
            //         { 44L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 12, 51, 54, 315, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 0, 0, 0, 0)), 2, 18L, 48L },
            //         { 45L, false, new DateTimeOffset(new DateTime(2019, 9, 6, 1, 38, 28, 328, DateTimeKind.Unspecified).AddTicks(8561), new TimeSpan(0, 0, 0, 0, 0)), 2, 17L, 39L },
            //         { 46L, false, new DateTimeOffset(new DateTime(2019, 9, 4, 15, 54, 19, 432, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 0, 0, 0, 0)), 2, 7L, 9L },
            //         { 47L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 2, 38, 10, 312, DateTimeKind.Unspecified).AddTicks(6151), new TimeSpan(0, 0, 0, 0, 0)), 2, 14L, 45L },
            //         { 48L, false, new DateTimeOffset(new DateTime(2019, 8, 21, 20, 50, 56, 949, DateTimeKind.Unspecified).AddTicks(867), new TimeSpan(0, 0, 0, 0, 0)), 2, 29L, 7L },
            //         { 49L, false, new DateTimeOffset(new DateTime(2019, 8, 26, 22, 10, 4, 686, DateTimeKind.Unspecified).AddTicks(9700), new TimeSpan(0, 0, 0, 0, 0)), 2, 19L, 16L },
            //         { 39L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 18, 25, 37, 389, DateTimeKind.Unspecified).AddTicks(1007), new TimeSpan(0, 0, 0, 0, 0)), 2, 17L, 22L },
            //         { 50L, false, new DateTimeOffset(new DateTime(2019, 9, 1, 7, 44, 26, 61, DateTimeKind.Unspecified).AddTicks(7273), new TimeSpan(0, 0, 0, 0, 0)), 2, 11L, 24L },
            //         { 26L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 1, 25, 38, 946, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), 2, 7L, 10L },
            //         { 24L, false, new DateTimeOffset(new DateTime(2019, 9, 5, 19, 33, 47, 700, DateTimeKind.Unspecified).AddTicks(975), new TimeSpan(0, 0, 0, 0, 0)), 2, 31L, 29L },
            //         { 2L, false, new DateTimeOffset(new DateTime(2019, 8, 19, 8, 17, 21, 910, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 0, 0, 0, 0)), 2, 24L, 14L },
            //         { 3L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 19, 39, 7, 616, DateTimeKind.Unspecified).AddTicks(5261), new TimeSpan(0, 0, 0, 0, 0)), 2, 19L, 14L },
            //         { 4L, false, new DateTimeOffset(new DateTime(2019, 8, 29, 11, 19, 37, 189, DateTimeKind.Unspecified).AddTicks(964), new TimeSpan(0, 0, 0, 0, 0)), 2, 7L, 48L },
            //         { 5L, false, new DateTimeOffset(new DateTime(2019, 8, 30, 3, 19, 58, 622, DateTimeKind.Unspecified).AddTicks(7133), new TimeSpan(0, 0, 0, 0, 0)), 2, 42L, 25L },
            //         { 6L, false, new DateTimeOffset(new DateTime(2019, 8, 28, 4, 12, 18, 171, DateTimeKind.Unspecified).AddTicks(9338), new TimeSpan(0, 0, 0, 0, 0)), 2, 39L, 35L },
            //         { 7L, false, new DateTimeOffset(new DateTime(2019, 8, 24, 22, 14, 28, 525, DateTimeKind.Unspecified).AddTicks(3947), new TimeSpan(0, 0, 0, 0, 0)), 2, 50L, 17L },
            //         { 8L, false, new DateTimeOffset(new DateTime(2019, 9, 3, 15, 12, 31, 442, DateTimeKind.Unspecified).AddTicks(281), new TimeSpan(0, 0, 0, 0, 0)), 2, 10L, 15L },
            //         { 9L, false, new DateTimeOffset(new DateTime(2019, 8, 16, 1, 21, 49, 26, DateTimeKind.Unspecified).AddTicks(6192), new TimeSpan(0, 0, 0, 0, 0)), 2, 17L, 1L },
            //         { 10L, false, new DateTimeOffset(new DateTime(2019, 8, 24, 7, 52, 15, 57, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), 2, 27L, 19L },
            //         { 11L, false, new DateTimeOffset(new DateTime(2019, 8, 28, 2, 6, 34, 844, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)), 2, 40L, 46L },
            //         { 25L, false, new DateTimeOffset(new DateTime(2019, 8, 21, 1, 13, 5, 120, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 0, 0, 0, 0)), 2, 27L, 38L },
            //         { 12L, false, new DateTimeOffset(new DateTime(2019, 9, 8, 16, 16, 28, 678, DateTimeKind.Unspecified).AddTicks(9265), new TimeSpan(0, 0, 0, 0, 0)), 2, 27L, 18L },
            //         { 14L, false, new DateTimeOffset(new DateTime(2019, 9, 7, 6, 21, 28, 851, DateTimeKind.Unspecified).AddTicks(3121), new TimeSpan(0, 0, 0, 0, 0)), 2, 12L, 21L },
            //         { 15L, false, new DateTimeOffset(new DateTime(2019, 9, 6, 17, 50, 19, 183, DateTimeKind.Unspecified).AddTicks(2627), new TimeSpan(0, 0, 0, 0, 0)), 2, 1L, 33L },
            //         { 16L, false, new DateTimeOffset(new DateTime(2019, 9, 5, 23, 54, 54, 84, DateTimeKind.Unspecified).AddTicks(6220), new TimeSpan(0, 0, 0, 0, 0)), 2, 39L, 4L },
            //         { 17L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 7, 38, 58, 87, DateTimeKind.Unspecified).AddTicks(6651), new TimeSpan(0, 0, 0, 0, 0)), 2, 14L, 17L },
            //         { 18L, false, new DateTimeOffset(new DateTime(2019, 9, 4, 14, 46, 2, 242, DateTimeKind.Unspecified).AddTicks(3976), new TimeSpan(0, 0, 0, 0, 0)), 2, 40L, 28L },
            //         { 19L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 13, 8, 55, 170, DateTimeKind.Unspecified).AddTicks(6456), new TimeSpan(0, 0, 0, 0, 0)), 2, 4L, 5L },
            //         { 20L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 0, 7, 31, 127, DateTimeKind.Unspecified).AddTicks(9667), new TimeSpan(0, 0, 0, 0, 0)), 2, 44L, 8L },
            //         { 21L, false, new DateTimeOffset(new DateTime(2019, 9, 2, 11, 35, 26, 560, DateTimeKind.Unspecified).AddTicks(8789), new TimeSpan(0, 0, 0, 0, 0)), 2, 14L, 43L },
            //         { 22L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 4, 43, 52, 204, DateTimeKind.Unspecified).AddTicks(8530), new TimeSpan(0, 0, 0, 0, 0)), 2, 48L, 18L },
            //         { 23L, false, new DateTimeOffset(new DateTime(2019, 9, 7, 20, 44, 52, 526, DateTimeKind.Unspecified).AddTicks(3294), new TimeSpan(0, 0, 0, 0, 0)), 2, 20L, 15L },
            //         { 13L, false, new DateTimeOffset(new DateTime(2019, 8, 18, 13, 37, 57, 636, DateTimeKind.Unspecified).AddTicks(6499), new TimeSpan(0, 0, 0, 0, 0)), 2, 11L, 47L }
            //     });

            // migrationBuilder.InsertData(
            //     table: "Shipment",
            //     columns: new[] { "Id", "BillingAddressId", "Comment", "CreatedOn", "DeliveryCost", "DeliveryDate", "DestinationAddressId", "Diameter", "Height", "IsDeleted", "LastModified", "Price", "ShipmentMethod", "ShipmentProviderName", "ShippedDate", "StormyCustomerId", "TotalWeight", "TrackNumber", "UserId", "WhoReceives", "Width" },
            //     values: new object[] { 2L, 0L, "a single comment", new DateTime(2019, 9, 9, 2, 49, 44, 456, DateTimeKind.Utc).AddTicks(9537), 22.29m, new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 0L, 0m, 0m, false, new DateTimeOffset(new DateTime(2019, 9, 9, 2, 49, 44, 456, DateTimeKind.Unspecified).AddTicks(8597), new TimeSpan(0, 0, 0, 0, 0)), 20.99m, null, null, new DateTime(2019, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 0L, 0.400m, "a4b83b71-a4ba-4d0b-81db-d9ad6365810e", null, null, 0m });

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
