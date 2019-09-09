using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website" },
                values: new object[,]
                {
                    { 3L, "Totam sunt aliquid laudantium et aut magnam possimus quasi non.", false, new DateTimeOffset(new DateTime(2019, 9, 5, 7, 38, 25, 41, DateTimeKind.Unspecified).AddTicks(5917), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=39", "Santos, Santos and Barros", "aut-sint-ea", "janaína.org" },
                    { 10L, "Aliquid aliquam inventore qui suscipit quaerat velit. Perferendis inventore aut sint unde reprehenderit saepe porro ipsum. Qui sit ex ut consequatur quod omnis dolor.", false, new DateTimeOffset(new DateTime(2019, 9, 2, 17, 37, 32, 285, DateTimeKind.Unspecified).AddTicks(4614), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=826", "Batista, Braga and Barros", "culpa-accusantium-tempora", "morgana.org" },
                    { 9L, "Enim aperiam qui ut sed occaecati molestiae sit perspiciatis consequatur. Magni alias quam necessitatibus quas perspiciatis esse illum aut. Suscipit voluptate voluptatem laborum sint totam iusto quia incidunt. Qui id fuga qui quia esse fuga praesentium.", false, new DateTimeOffset(new DateTime(2019, 8, 29, 23, 22, 44, 973, DateTimeKind.Unspecified).AddTicks(5624), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=438", "Silva LTDA", "ipsa-quibusdam-error", "mércia.name" },
                    { 8L, "Et ex aliquam iure ea commodi earum nesciunt sequi et. Maxime delectus quos voluptatibus nisi at voluptates ducimus assumenda et. Ipsam praesentium qui velit. Nesciunt dolorem atque perferendis voluptatum asperiores commodi aut odio sed. Enim incidunt est. Asperiores cupiditate autem quis est qui aspernatur facere voluptate.", false, new DateTimeOffset(new DateTime(2019, 8, 22, 7, 53, 16, 728, DateTimeKind.Unspecified).AddTicks(3401), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=917", "Nogueira S.A.", "ipsa-eos-dolores", "paulo.name" },
                    { 7L, "Et eaque ducimus saepe dolore fugiat ad dicta beatae. Labore non molestiae voluptatem velit incidunt. Quod ex explicabo maxime ut velit modi. Sit voluptatem dolores consequatur.", false, new DateTimeOffset(new DateTime(2019, 8, 20, 17, 26, 4, 291, DateTimeKind.Unspecified).AddTicks(2544), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=636", "Batista e Associados", "dolorem-quas-harum", "roberta.name" },
                    { 6L, "quo", false, new DateTimeOffset(new DateTime(2019, 8, 28, 9, 4, 26, 618, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=932", "Saraiva LTDA", "fugiat-consequuntur-aut", "félix.biz" },
                    { 5L, "Sed dolores voluptates perspiciatis. Ab voluptates aut. Eius rerum perferendis nemo exercitationem ut commodi eos ipsum. Aut quos et magni eius ullam et.", false, new DateTimeOffset(new DateTime(2019, 9, 8, 2, 35, 42, 687, DateTimeKind.Unspecified).AddTicks(9948), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=450", "Carvalho e Associados", "consectetur-in-ab", "marli.info" },
                    { 4L, "omnis", false, new DateTimeOffset(new DateTime(2019, 8, 21, 8, 14, 13, 444, DateTimeKind.Unspecified).AddTicks(2723), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=1038", "Nogueira - Oliveira", "sed-sunt-porro", "maria.info" },
                    { 2L, "Ea odit magni facilis assumenda qui itaque sed.", false, new DateTimeOffset(new DateTime(2019, 8, 29, 1, 9, 6, 62, DateTimeKind.Unspecified).AddTicks(2193), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=880", "Souza, Silva and Silva", "laudantium-quas-tempora", "vitória.br" },
                    { 1L, "est", false, new DateTimeOffset(new DateTime(2019, 8, 23, 2, 49, 14, 126, DateTimeKind.Unspecified).AddTicks(6944), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=209", "Franco - Reis", "labore-et-ab", "rafael.br" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl" },
                values: new object[,]
                {
                    { 1L, "Illum nihil laboriosam iste. Incidunt dolorem sapiente dicta architecto in iure possimus qui. Voluptas voluptas distinctio possimus voluptates. Laudantium eius eaque nesciunt alias dolore ipsam. Omnis veniam ea quia repellendus labore aut dolor doloribus.", 0, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 16, 11, 43, 45, 542, DateTimeKind.Unspecified).AddTicks(191), new TimeSpan(0, -3, 0, 0, 0)), @"Quia qui excepturi id ut deserunt amet voluptate asperiores blanditiis.
                Vitae optio et ex atque.
                In dolor voluptatibus molestias eos.
                Temporibus eius dolor aut culpa incidunt officia.
                Ab explicabo sit quis debitis.", null, null, "Grocery", null, "impedit-iusto-amet", "http://lorempixel.com/640/480/fashion" },
                    { 9L, "Eaque perferendis soluta ab voluptatem placeat fugit suscipit voluptates. Excepturi cumque qui sapiente quia neque. Reprehenderit perferendis facere.", 8, true, false, true, new DateTimeOffset(new DateTime(2019, 9, 5, 1, 45, 58, 522, DateTimeKind.Unspecified).AddTicks(7152), new TimeSpan(0, -3, 0, 0, 0)), "Doloribus eveniet quia vel sed ullam illum non dolores.", null, null, "Tools", null, "est-odit-assumenda", "http://lorempixel.com/640/480/fashion" },
                    { 8L, "Esse dolorum iste ullam sed quod.", 7, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 27, 23, 43, 30, 73, DateTimeKind.Unspecified).AddTicks(7808), new TimeSpan(0, -3, 0, 0, 0)), "Est ex est consequuntur voluptatem voluptatibus reprehenderit eum ipsa voluptatem. Mollitia velit et sint veniam. Est consequatur aut pariatur iusto dignissimos. Et voluptatem qui et dolor. Amet molestiae culpa ducimus eum est exercitationem ut atque molestiae.", null, null, "Computers", null, "voluptas-omnis-et", "http://lorempixel.com/640/480/fashion" },
                    { 7L, @"Eligendi nobis nostrum voluptatem in architecto similique modi.
                Dolor cum quod accusamus ullam laudantium modi facere amet vel.
                Ipsa adipisci quia consequatur est a occaecati ut aut.
                Eius ipsa dolor explicabo.
                Est aspernatur minus quia maiores voluptatum repellat non rerum numquam.", 6, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 25, 13, 14, 14, 981, DateTimeKind.Unspecified).AddTicks(5474), new TimeSpan(0, -3, 0, 0, 0)), "Consequatur voluptatibus libero quas.", null, null, "Baby", null, "velit-nesciunt-recusandae", "http://lorempixel.com/640/480/fashion" },
                    { 6L, "Iure repellat magnam ipsam. Recusandae molestiae laborum quas aut iusto ut voluptatem. Enim optio possimus. Qui porro repellat qui illum in in quibusdam harum praesentium.", 5, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 26, 13, 36, 55, 715, DateTimeKind.Unspecified).AddTicks(4360), new TimeSpan(0, -3, 0, 0, 0)), "Repellendus inventore ipsa modi et et necessitatibus voluptatem voluptatem.", null, null, "Computers", null, "corporis-ducimus-saepe", "http://lorempixel.com/640/480/fashion" },
                    { 5L, "Laboriosam tenetur voluptas odio magnam veritatis qui.", 4, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 29, 21, 48, 15, 802, DateTimeKind.Unspecified).AddTicks(8451), new TimeSpan(0, -3, 0, 0, 0)), "Ut quis molestias omnis sunt aut optio delectus.", null, null, "Jewelery", null, "placeat-a-doloribus", "http://lorempixel.com/640/480/fashion" },
                    { 4L, @"Quibusdam rerum commodi molestiae tempore illo.
                Eum alias modi tenetur consequatur.
                Animi iure et officia et enim nisi doloribus.
                Ipsam reprehenderit tempora.
                Nemo suscipit quo modi libero inventore dicta quas.", 3, true, false, true, new DateTimeOffset(new DateTime(2019, 9, 6, 1, 3, 53, 372, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, -3, 0, 0, 0)), "reprehenderit", null, null, "Tools", null, "unde-enim-voluptas", "http://lorempixel.com/640/480/fashion" },
                    { 3L, "Culpa praesentium eos necessitatibus blanditiis fugit expedita voluptas doloribus. Voluptas optio commodi voluptas distinctio. Perspiciatis numquam vitae est minima perferendis iste ipsum est. Nam porro repellendus accusamus placeat illo velit. Debitis exercitationem et accusamus nesciunt temporibus dolor. Temporibus id et alias aut.", 2, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 24, 7, 9, 38, 302, DateTimeKind.Unspecified).AddTicks(2788), new TimeSpan(0, -3, 0, 0, 0)), "Adipisci odio iusto quo quia provident error et eligendi neque.", null, null, "Movies", null, "pariatur-qui-earum", "http://lorempixel.com/640/480/fashion" },
                    { 2L, "Ut ad molestias. Aut dolorum debitis deserunt. Cum eum quasi ab est eum temporibus dolorum id. Voluptate sed voluptatem doloribus. Veniam deleniti omnis et non quis et mollitia. Iusto qui rerum libero voluptas.", 1, true, false, true, new DateTimeOffset(new DateTime(2019, 9, 7, 10, 26, 14, 0, DateTimeKind.Unspecified).AddTicks(1192), new TimeSpan(0, -3, 0, 0, 0)), @"Maxime modi esse quidem ullam eum maiores ab.
                Autem praesentium minus nihil reiciendis nihil.
                Eum pariatur ea nulla perferendis.
                Praesentium possimus repellendus possimus laborum ut.
                Sed omnis ut error optio quis.", null, null, "Industrial", null, "ipsa-sunt-quae", "http://lorempixel.com/640/480/fashion" },
                    { 10L, "eos", 9, true, false, true, new DateTimeOffset(new DateTime(2019, 9, 5, 0, 23, 30, 376, DateTimeKind.Unspecified).AddTicks(2541), new TimeSpan(0, -3, 0, 0, 0)), "Quae id eveniet accusantium dolor. Et nisi blanditiis. Assumenda officiis praesentium in. Voluptatem repellendus nulla assumenda. Illum occaecati cumque quaerat repellendus mollitia et sunt. Sapiente itaque et.", null, null, "Music", null, "sit-quam-quis", "http://lorempixel.com/640/480/fashion" }
                });

            migrationBuilder.InsertData(
                table: "Entity",
                columns: new[] { "Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug" },
                values: new object[,]
                {
                    { 4L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 0, 1, 23, 950, DateTimeKind.Unspecified).AddTicks(4744), new TimeSpan(0, -3, 0, 0, 0)), "Small Soft Pants", "cum-impedit-fuga" },
                    { 1L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 23, 44, 9, 543, DateTimeKind.Unspecified).AddTicks(5136), new TimeSpan(0, -3, 0, 0, 0)), "Small Cotton Hat", "non-magni-delectus" },
                    { 2L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 12, 20, 59, 425, DateTimeKind.Unspecified).AddTicks(9509), new TimeSpan(0, -3, 0, 0, 0)), "Unbranded Metal Bike", "consequatur-nam-molestiae" },
                    { 3L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 23, 59, 34, 113, DateTimeKind.Unspecified).AddTicks(9983), new TimeSpan(0, -3, 0, 0, 0)), "Practical Metal Salad", "quam-modi-rerum" },
                    { 5L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 18, 50, 58, 794, DateTimeKind.Unspecified).AddTicks(9318), new TimeSpan(0, -3, 0, 0, 0)), "Intelligent Metal Soap", "porro-voluptatum-ipsa" },
                    { 9L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 6, 22, 53, 23, 740, DateTimeKind.Unspecified).AddTicks(3134), new TimeSpan(0, -3, 0, 0, 0)), "Handcrafted Concrete Pizza", "quam-nisi-quidem" },
                    { 7L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 20, 50, 26, 533, DateTimeKind.Unspecified).AddTicks(633), new TimeSpan(0, -3, 0, 0, 0)), "Tasty Fresh Shoes", "iure-omnis-atque" },
                    { 8L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 2, 40, 34, 630, DateTimeKind.Unspecified).AddTicks(3585), new TimeSpan(0, -3, 0, 0, 0)), "Licensed Wooden Shirt", "hic-laboriosam-consequatur" },
                    { 10L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 10, 6, 59, 356, DateTimeKind.Unspecified).AddTicks(4902), new TimeSpan(0, -3, 0, 0, 0)), "Small Metal Tuna", "consectetur-rerum-aperiam" },
                    { 6L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 1, 38, 16, 946, DateTimeKind.Unspecified).AddTicks(6883), new TimeSpan(0, -3, 0, 0, 0)), "Handmade Granite Hat", "quia-repellat-est" }
                });

            migrationBuilder.UpdateData(
                table: "Shipment",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModified", "TrackNumber" },
                values: new object[] { new DateTime(2019, 9, 9, 1, 21, 49, 958, DateTimeKind.Utc).AddTicks(8757), new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 958, DateTimeKind.Unspecified).AddTicks(8754), new TimeSpan(0, 0, 0, 0, 0)), "0df2c052-bd92-4ef5-972b-d2a06bd8296f" });

            migrationBuilder.InsertData(
                table: "StormyProduct",
                columns: new[] { "Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId" },
                values: new object[,]
                {
                    { 39L, false, 0, 0, false, 39L, 39L, new DateTime(2018, 10, 23, 14, 28, 13, 235, DateTimeKind.Local).AddTicks(6134), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(9333), new TimeSpan(0, 0, 0, 0, 0)), 39L, 0, 0, false, "alias", "R$56,54", new DateTime(2019, 12, 5, 8, 19, 22, 52, DateTimeKind.Local).AddTicks(4475), "R$4,63", true, 0.00865028798982980m, 0L, "Incredible Plastic Bike", true, 36, 39, "oksugn8ps0vurayk", "rerum-fugit-et", "Good", true, null, "Computers", 70.767855723746000m, 8.2840086511727500m, 0.48603081912083124, 5, 4, new DateTime(2019, 9, 9, 11, 21, 55, 391, DateTimeKind.Local).AddTicks(9542), 39L },
                    { 40L, false, 0, 0, false, 40L, 40L, new DateTime(2019, 8, 22, 17, 16, 59, 418, DateTimeKind.Local).AddTicks(764), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(9553), new TimeSpan(0, 0, 0, 0, 0)), 40L, 0, 0, false, "Alias suscipit ex qui officia alias occaecati aliquam. Doloribus est dolores eligendi non illo. Itaque placeat illum impedit ut sed sequi et nemo. Sit qui ea officia. Et culpa voluptatibus dicta est eum sint libero inventore. Vitae quaerat explicabo quo at omnis veniam facilis necessitatibus.", "R$24,47", new DateTime(2020, 2, 13, 15, 49, 55, 823, DateTimeKind.Local).AddTicks(3959), "R$81,62", true, 0.1571630636030640m, 0L, "Gorgeous Plastic Shoes", true, 24, 40, "8f3cpucp3y6c92ac", "maxime-dicta-commodi", "Good", true, null, "Industrial", 69.9145312280928000m, 2.151505328785400m, 0.74281104316134516, 8, 8, new DateTime(2019, 9, 8, 16, 6, 10, 110, DateTimeKind.Local).AddTicks(6817), 40L },
                    { 41L, false, 0, 0, false, 41L, 41L, new DateTime(2019, 2, 15, 13, 50, 29, 576, DateTimeKind.Local).AddTicks(4820), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 919, DateTimeKind.Unspecified).AddTicks(60), new TimeSpan(0, 0, 0, 0, 0)), 41L, 0, 0, false, @"Molestiae in alias enim beatae.
                Consectetur ea a recusandae corporis nulla odio adipisci accusamus qui.
                In quia nisi.
                Quia modi veritatis soluta dolore impedit nihil consequuntur reprehenderit.", "R$5,64", new DateTime(2020, 6, 15, 19, 29, 8, 486, DateTimeKind.Local).AddTicks(777), "R$8,22", true, 0.2205306087716160m, 0L, "Sleek Plastic Chips", true, 74, 41, "sww4sjpug0f2rx5y", "inventore-non-qui", "Good", true, null, "Baby", 46.9380942391875000m, 0.84101778028580200m, 0.7740645193374085, 8, 7, new DateTime(2019, 9, 9, 4, 19, 40, 42, DateTimeKind.Local).AddTicks(8021), 41L },
                    { 42L, false, 0, 0, false, 42L, 42L, new DateTime(2018, 12, 2, 8, 57, 32, 591, DateTimeKind.Local).AddTicks(7968), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 919, DateTimeKind.Unspecified).AddTicks(451), new TimeSpan(0, 0, 0, 0, 0)), 42L, 0, 0, false, "Adipisci vel enim sit rerum repudiandae nulla hic. Dolorem maxime nobis voluptas est architecto dolores impedit dignissimos. Eos nulla facilis velit ex provident. Et non nihil impedit aliquid ea.", "R$117,90", new DateTime(2019, 9, 19, 14, 12, 25, 285, DateTimeKind.Local).AddTicks(8733), "R$44,49", true, 0.2147039879181910m, 0L, "Handcrafted Frozen Chips", true, 86, 42, "l395uavldpbe5fb6", "earum-harum-fugiat", "Good", true, null, "Home", 62.3042290854753000m, 2.8494691023833400m, 0.87555582117082353, 1, 2, new DateTime(2019, 9, 8, 21, 3, 21, 703, DateTimeKind.Local).AddTicks(6932), 42L },
                    { 43L, false, 0, 0, false, 43L, 43L, new DateTime(2019, 5, 15, 2, 6, 23, 675, DateTimeKind.Local).AddTicks(4062), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 919, DateTimeKind.Unspecified).AddTicks(917), new TimeSpan(0, 0, 0, 0, 0)), 43L, 0, 0, false, "Dignissimos aliquid sapiente dolor.", "R$173,84", new DateTime(2019, 12, 5, 21, 25, 32, 739, DateTimeKind.Local).AddTicks(6836), "R$26,52", true, 0.6528813455500090m, 0L, "Licensed Fresh Shoes", true, 34, 43, "xhv3ojqgsi4vj6wh", "provident-ab-harum", "Good", true, null, "Beauty", 17.981447800054000m, 2.46457586179700m, 0.39454672643660882, 3, 9, new DateTime(2019, 9, 9, 7, 46, 40, 68, DateTimeKind.Local).AddTicks(177), 43L },
                    { 44L, false, 0, 0, false, 44L, 44L, new DateTime(2018, 10, 4, 14, 55, 20, 769, DateTimeKind.Local).AddTicks(8422), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 919, DateTimeKind.Unspecified).AddTicks(1169), new TimeSpan(0, 0, 0, 0, 0)), 44L, 0, 0, false, "eos", "R$169,31", new DateTime(2020, 6, 2, 4, 12, 11, 387, DateTimeKind.Local).AddTicks(1437), "R$97,02", true, 0.8695881389405520m, 0L, "Awesome Fresh Gloves", true, 78, 44, "pnl8spz5ccg5mwa8", "omnis-quae-deserunt", "Good", true, null, "Movies", 37.2795286296306000m, 9.1365276878404100m, 0.92152253627848002, 0, 8, new DateTime(2019, 9, 9, 3, 20, 20, 213, DateTimeKind.Local).AddTicks(849), 44L },
                    { 46L, false, 0, 0, false, 46L, 46L, new DateTime(2018, 12, 29, 0, 47, 23, 697, DateTimeKind.Local).AddTicks(5426), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 919, DateTimeKind.Unspecified).AddTicks(1678), new TimeSpan(0, 0, 0, 0, 0)), 46L, 0, 0, false, @"Natus aut quis assumenda aut deleniti corrupti dolor inventore.
                Error numquam eius officiis.
                Quos nulla animi expedita aperiam.
                Odit ut laudantium amet cumque excepturi libero dolores laboriosam sit.", "R$102,52", new DateTime(2019, 12, 7, 0, 49, 9, 82, DateTimeKind.Local).AddTicks(6504), "R$38,92", true, 0.5238828694093430m, 0L, "Handcrafted Frozen Soap", true, 74, 46, "eof1jn0c03c90byc", "saepe-saepe-voluptas", "Good", true, null, "Outdoors", 87.1993276230988000m, 5.3782965314473500m, 0.15423408996045315, 7, 1, new DateTime(2019, 9, 8, 4, 37, 59, 576, DateTimeKind.Local).AddTicks(2394), 46L },
                    { 47L, false, 0, 0, false, 47L, 47L, new DateTime(2019, 6, 11, 1, 29, 46, 995, DateTimeKind.Local).AddTicks(2612), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 919, DateTimeKind.Unspecified).AddTicks(2073), new TimeSpan(0, 0, 0, 0, 0)), 47L, 0, 0, false, "vel", "R$131,76", new DateTime(2020, 1, 12, 1, 24, 41, 432, DateTimeKind.Local).AddTicks(2457), "R$46,32", true, 0.355286775787960m, 0L, "Practical Cotton Chips", true, 28, 47, "t0d9inknukzjwgrt", "culpa-velit-ut", "Good", true, null, "Sports", 6.10771361091533000m, 7.1532610418057400m, 0.18313758223463669, 7, 6, new DateTime(2019, 9, 8, 18, 7, 36, 748, DateTimeKind.Local).AddTicks(8558), 47L },
                    { 48L, false, 0, 0, false, 48L, 48L, new DateTime(2019, 8, 11, 21, 54, 33, 875, DateTimeKind.Local).AddTicks(6810), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 919, DateTimeKind.Unspecified).AddTicks(2328), new TimeSpan(0, 0, 0, 0, 0)), 48L, 0, 0, false, "Velit quod libero ut. Quisquam ducimus non. Est facere et itaque non dolore. Cupiditate et eaque. Consectetur qui rerum ut. Commodi et harum quia voluptate.", "R$7,45", new DateTime(2020, 4, 13, 7, 8, 10, 697, DateTimeKind.Local).AddTicks(6214), "R$68,49", true, 0.6608568237446510m, 0L, "Ergonomic Frozen Mouse", true, 48, 48, "u3uimeym867ltflp", "aut-rerum-velit", "Good", true, null, "Toys", 20.3538313137152000m, 1.92151094876300m, 0.18115461998672905, 2, 7, new DateTime(2019, 9, 9, 7, 54, 43, 815, DateTimeKind.Local).AddTicks(8075), 48L },
                    { 49L, false, 0, 0, false, 49L, 49L, new DateTime(2018, 12, 22, 10, 25, 1, 252, DateTimeKind.Local).AddTicks(9570), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 919, DateTimeKind.Unspecified).AddTicks(2776), new TimeSpan(0, 0, 0, 0, 0)), 49L, 0, 0, false, "Odit non deleniti quia reiciendis ullam saepe praesentium provident. Illum et tempore amet est possimus eos. Aut quod laborum dolorum impedit error ab et alias totam. Sunt ex nobis non dolor.", "R$151,12", new DateTime(2020, 1, 31, 12, 46, 15, 764, DateTimeKind.Local).AddTicks(9936), "R$3,98", true, 0.4435835031064150m, 0L, "Incredible Fresh Ball", true, 82, 49, "wiftrjzy4oxvqz0u", "voluptatem-rerum-possimus", "Good", true, null, "Jewelery", 3.44242984589302000m, 8.8743834145713500m, 0.092149143150145718, 7, 4, new DateTime(2019, 9, 8, 8, 18, 44, 297, DateTimeKind.Local).AddTicks(5422), 49L },
                    { 50L, false, 0, 0, false, 50L, 50L, new DateTime(2019, 5, 27, 2, 53, 42, 361, DateTimeKind.Local).AddTicks(7437), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 919, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)), 50L, 0, 0, false, "eum", "R$126,17", new DateTime(2020, 3, 12, 9, 58, 42, 253, DateTimeKind.Local).AddTicks(8614), "R$41,68", true, 0.1546744635117590m, 0L, "Licensed Plastic Sausages", true, 98, 50, "w5pbclhrp5h8w4ja", "nihil-magni-odio", "Good", true, null, "Computers", 42.6539593574842000m, 3.1347116982260300m, 0.16318879144414739, 4, 6, new DateTime(2019, 9, 9, 2, 6, 40, 492, DateTimeKind.Local).AddTicks(3522), 50L },
                    { 38L, false, 0, 0, false, 38L, 38L, new DateTime(2019, 9, 2, 21, 21, 2, 670, DateTimeKind.Local).AddTicks(8355), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 0, 0, 0, 0)), 38L, 0, 0, false, @"Est et adipisci nihil quasi labore adipisci.
                Quia error nihil inventore occaecati.
                Qui suscipit quia aliquam ut cupiditate doloremque dolores placeat.
                Totam consequuntur aut consequatur.", "R$138,63", new DateTime(2020, 2, 21, 21, 52, 25, 982, DateTimeKind.Local).AddTicks(1685), "R$59,22", true, 0.09773433632111840m, 0L, "Licensed Concrete Cheese", true, 22, 38, "ci4sp4li4lbi0bxr", "dicta-voluptatem-sit", "Good", true, null, "Movies", 75.6327221056599000m, 6.407589980590900m, 0.20558505188933809, 0, 0, new DateTime(2019, 9, 9, 8, 27, 28, 462, DateTimeKind.Local).AddTicks(4977), 38L },
                    { 45L, false, 0, 0, false, 45L, 45L, new DateTime(2018, 11, 15, 12, 23, 12, 657, DateTimeKind.Local).AddTicks(2745), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 919, DateTimeKind.Unspecified).AddTicks(1425), new TimeSpan(0, 0, 0, 0, 0)), 45L, 0, 0, false, "Non accusantium molestiae beatae deserunt culpa nemo.", "R$27,74", new DateTime(2020, 8, 12, 15, 53, 49, 438, DateTimeKind.Local).AddTicks(1869), "R$55,64", true, 0.3232463343642870m, 0L, "Handmade Soft Soap", true, 18, 45, "ig7ltsq0ewfx6yuj", "quibusdam-nostrum-libero", "Good", true, null, "Electronics", 48.706354363219000m, 5.1181274303785200m, 0.53663965386182055, 7, 6, new DateTime(2019, 9, 9, 2, 16, 27, 692, DateTimeKind.Local).AddTicks(8911), 45L },
                    { 37L, false, 0, 0, false, 37L, 37L, new DateTime(2019, 2, 11, 19, 33, 20, 315, DateTimeKind.Local).AddTicks(191), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(8559), new TimeSpan(0, 0, 0, 0, 0)), 37L, 0, 0, false, @"Dolor sint cumque.
                Et eos aspernatur.
                Inventore quia deserunt voluptas assumenda est non quidem qui.
                Esse voluptas voluptatem sunt saepe soluta.
                Sunt facilis praesentium.", "R$171,21", new DateTime(2019, 11, 5, 5, 26, 56, 328, DateTimeKind.Local).AddTicks(1717), "R$5,74", true, 0.1794527062119230m, 0L, "Licensed Cotton Pants", true, 28, 37, "uhz0rnbwda2gam7m", "non-at-et", "Good", true, null, "Clothing", 52.5953166897387000m, 8.4713502360840100m, 0.95414447363193355, 10, 4, new DateTime(2019, 9, 8, 18, 59, 59, 405, DateTimeKind.Local).AddTicks(1994), 37L },
                    { 31L, false, 0, 0, false, 31L, 31L, new DateTime(2018, 10, 13, 18, 15, 50, 437, DateTimeKind.Local).AddTicks(8735), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(6569), new TimeSpan(0, 0, 0, 0, 0)), 31L, 0, 0, false, "Rerum corporis quo ut quam.", "R$150,78", new DateTime(2020, 7, 8, 16, 14, 44, 669, DateTimeKind.Local).AddTicks(4770), "R$37,44", true, 0.3372424698142530m, 0L, "Unbranded Frozen Bike", true, 34, 31, "z3q1bdvtuuj6odce", "maxime-reiciendis-repudiandae", "Good", true, null, "Toys", 77.3535941156343000m, 5.1159604569505700m, 0.41919439352079962, 7, 3, new DateTime(2019, 9, 8, 20, 43, 56, 488, DateTimeKind.Local).AddTicks(9367), 31L },
                    { 35L, false, 0, 0, false, 35L, 35L, new DateTime(2018, 12, 19, 14, 29, 40, 348, DateTimeKind.Local).AddTicks(3128), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(7934), new TimeSpan(0, 0, 0, 0, 0)), 35L, 0, 0, false, "Mollitia accusamus consectetur beatae natus rerum officiis iusto. Libero in dignissimos sit explicabo voluptatibus fuga mollitia asperiores. Quis ex excepturi veritatis ea.", "R$133,16", new DateTime(2020, 5, 29, 21, 57, 24, 515, DateTimeKind.Local).AddTicks(5500), "R$22,68", true, 0.9794147773549960m, 0L, "Incredible Concrete Mouse", true, 54, 35, "5154njc9alvu5naa", "suscipit-qui-doloribus", "Good", true, null, "Books", 32.1055863667771000m, 1.7623659464355400m, 0.7464740666311579, 3, 0, new DateTime(2019, 9, 9, 4, 51, 8, 688, DateTimeKind.Local).AddTicks(7375), 35L },
                    { 11L, false, 0, 0, false, 11L, 11L, new DateTime(2018, 10, 28, 20, 9, 20, 155, DateTimeKind.Local).AddTicks(9842), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(9159), new TimeSpan(0, 0, 0, 0, 0)), 11L, 0, 0, false, "Officia sequi debitis sunt facere perspiciatis.", "R$153,28", new DateTime(2020, 2, 24, 22, 42, 16, 931, DateTimeKind.Local).AddTicks(1601), "R$46,68", true, 0.806793630033170m, 0L, "Practical Concrete Shoes", true, 70, 11, "nzrphvb1x4muwxv2", "qui-blanditiis-molestiae", "Good", true, null, "Outdoors", 22.2262196346308000m, 7.8337508429930300m, 0.59794866600909669, 7, 6, new DateTime(2019, 9, 9, 9, 3, 47, 20, DateTimeKind.Local).AddTicks(1078), 11L },
                    { 12L, false, 0, 0, false, 12L, 12L, new DateTime(2018, 11, 27, 10, 42, 37, 183, DateTimeKind.Local).AddTicks(7304), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(9424), new TimeSpan(0, 0, 0, 0, 0)), 12L, 0, 0, false, @"Enim ut voluptas alias.
                Magnam sed qui velit nobis adipisci ex incidunt.
                Id voluptatem quia nobis aperiam.
                Temporibus quia odit ipsa.", "R$128,70", new DateTime(2020, 1, 21, 17, 31, 27, 869, DateTimeKind.Local).AddTicks(1956), "R$46,46", true, 0.2557082964366810m, 0L, "Small Concrete Salad", true, 26, 12, "e5o1wyicfx7j4t6w", "qui-ex-aut", "Good", true, null, "Shoes", 37.4928126751877000m, 1.5195487213877700m, 0.41976917880576531, 3, 7, new DateTime(2019, 9, 8, 18, 52, 9, 169, DateTimeKind.Local).AddTicks(7132), 12L },
                    { 13L, false, 0, 0, false, 13L, 13L, new DateTime(2019, 1, 30, 11, 39, 44, 276, DateTimeKind.Local).AddTicks(964), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(9796), new TimeSpan(0, 0, 0, 0, 0)), 13L, 0, 0, false, "Natus dolorem qui dicta tempora eveniet dolorem expedita.", "R$93,02", new DateTime(2019, 9, 28, 6, 45, 42, 922, DateTimeKind.Local).AddTicks(1300), "R$26,09", true, 0.5136622146301260m, 0L, "Tasty Wooden Computer", true, 12, 13, "pfjfkn66ose1tr53", "explicabo-iste-in", "Good", true, null, "Tools", 54.3267866849558000m, 7.2191235689535400m, 0.051640555752273908, 10, 7, new DateTime(2019, 9, 9, 0, 58, 55, 972, DateTimeKind.Local).AddTicks(3272), 13L },
                    { 14L, false, 0, 0, false, 14L, 14L, new DateTime(2019, 5, 20, 10, 39, 25, 229, DateTimeKind.Local).AddTicks(7763), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(92), new TimeSpan(0, 0, 0, 0, 0)), 14L, 0, 0, false, "Praesentium quos dignissimos natus maxime nisi alias non. Quo laboriosam aliquam. Fugit facilis officiis aut et.", "R$101,44", new DateTime(2019, 10, 28, 12, 47, 9, 725, DateTimeKind.Local).AddTicks(4857), "R$88,15", true, 0.3257732951667970m, 0L, "Generic Cotton Chair", true, 88, 14, "4n1tkqykp0dkwqi3", "a-aut-hic", "Good", true, null, "Kids", 43.0337288617314000m, 3.3256646168072100m, 0.83972615182387, 1, 8, new DateTime(2019, 9, 9, 11, 32, 34, 138, DateTimeKind.Local).AddTicks(5884), 14L },
                    { 15L, false, 0, 0, false, 15L, 15L, new DateTime(2019, 6, 12, 13, 45, 22, 78, DateTimeKind.Local).AddTicks(3419), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(438), new TimeSpan(0, 0, 0, 0, 0)), 15L, 0, 0, false, @"Assumenda laboriosam ullam neque reprehenderit velit et.
                Consequuntur earum eos laudantium dolores alias maxime commodi officiis.
                Molestias in natus.
                Tempora et ea aperiam numquam occaecati.
                Architecto ratione corporis.", "R$164,88", new DateTime(2020, 8, 12, 3, 0, 33, 802, DateTimeKind.Local).AddTicks(9189), "R$54,88", true, 0.7308192838592540m, 0L, "Licensed Concrete Mouse", true, 92, 15, "poyuv9ix05dikx6l", "suscipit-natus-eius", "Good", true, null, "Jewelery", 36.7003809831573000m, 6.2648446514573200m, 0.15493425547840736, 4, 7, new DateTime(2019, 9, 8, 10, 20, 53, 614, DateTimeKind.Local).AddTicks(1388), 15L },
                    { 16L, false, 0, 0, false, 16L, 16L, new DateTime(2019, 1, 27, 0, 13, 41, 920, DateTimeKind.Local).AddTicks(3511), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 0, 0, 0, 0)), 16L, 0, 0, false, @"Qui ducimus sed temporibus velit qui mollitia et officia.
                Nemo dolores voluptate explicabo excepturi qui voluptate magni voluptas dolore.
                Qui eius mollitia id incidunt autem necessitatibus maxime ex.
                Quasi impedit et.
                Qui quibusdam provident repudiandae expedita neque id.
                Perferendis blanditiis iste eum laudantium voluptate pariatur.", "R$75,99", new DateTime(2020, 4, 16, 15, 36, 3, 657, DateTimeKind.Local).AddTicks(7002), "R$86,37", true, 0.8804988953659770m, 0L, "Rustic Plastic Tuna", true, 80, 16, "0ctfmmskq71zb4sr", "ex-adipisci-voluptates", "Good", true, null, "Shoes", 91.8131047356004000m, 5.5872606372401400m, 0.67378393219494448, 2, 5, new DateTime(2019, 9, 8, 9, 13, 49, 918, DateTimeKind.Local).AddTicks(1366), 16L },
                    { 17L, false, 0, 0, false, 17L, 17L, new DateTime(2019, 3, 1, 12, 4, 25, 338, DateTimeKind.Local).AddTicks(365), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(1355), new TimeSpan(0, 0, 0, 0, 0)), 17L, 0, 0, false, "Adipisci ut earum nemo qui. Quis ut eius assumenda aut doloribus deleniti dolorem doloribus. Optio non voluptas id. Praesentium eos quia. Tempora reiciendis quod. Quae eligendi similique.", "R$115,91", new DateTime(2019, 12, 13, 10, 57, 0, 729, DateTimeKind.Local).AddTicks(3173), "R$70,93", true, 0.8289839061112070m, 0L, "Intelligent Frozen Pants", true, 48, 17, "pv8s8sihx0v76344", "sed-qui-quae", "Good", true, null, "Sports", 49.3752417384532000m, 8.9365541278089200m, 0.74450396594801171, 2, 0, new DateTime(2019, 9, 9, 9, 15, 40, 502, DateTimeKind.Local).AddTicks(4138), 17L },
                    { 36L, false, 0, 0, false, 36L, 36L, new DateTime(2019, 8, 4, 21, 4, 7, 334, DateTimeKind.Local).AddTicks(3991), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(8303), new TimeSpan(0, 0, 0, 0, 0)), 36L, 0, 0, false, "sit", "R$23,04", new DateTime(2020, 8, 19, 3, 35, 2, 850, DateTimeKind.Local).AddTicks(4792), "R$1,20", true, 0.6771715063029770m, 0L, "Incredible Rubber Chicken", true, 8, 36, "qosl0fvj2lkc3c4q", "sunt-odio-quisquam", "Good", true, null, "Garden", 82.8927630944609000m, 8.0632762369063100m, 0.85732109838040593, 9, 6, new DateTime(2019, 9, 8, 13, 25, 9, 587, DateTimeKind.Local).AddTicks(5469), 36L },
                    { 19L, false, 0, 0, false, 19L, 19L, new DateTime(2019, 7, 10, 11, 28, 50, 563, DateTimeKind.Local).AddTicks(2436), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(2251), new TimeSpan(0, 0, 0, 0, 0)), 19L, 0, 0, false, "dolore", "R$91,67", new DateTime(2019, 11, 14, 20, 29, 29, 957, DateTimeKind.Local).AddTicks(4145), "R$81,04", true, 0.4477698022722130m, 0L, "Unbranded Wooden Table", true, 80, 19, "8h7vasnim4u7qvgy", "harum-reiciendis-saepe", "Good", true, null, "Industrial", 40.4257609697179000m, 9.647059715188600m, 0.40032750293627728, 7, 0, new DateTime(2019, 9, 8, 13, 13, 30, 332, DateTimeKind.Local).AddTicks(5000), 19L },
                    { 20L, false, 0, 0, false, 20L, 20L, new DateTime(2018, 12, 27, 4, 44, 17, 688, DateTimeKind.Local).AddTicks(4860), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(2475), new TimeSpan(0, 0, 0, 0, 0)), 20L, 0, 0, false, @"Qui ad expedita blanditiis maiores atque.
                Et a occaecati ut occaecati.
                Qui facere non.", "R$154,57", new DateTime(2020, 3, 9, 11, 43, 26, 845, DateTimeKind.Local).AddTicks(5115), "R$48,18", true, 0.1566752866640110m, 0L, "Incredible Wooden Chips", true, 26, 20, "eo50v470qhvzo06m", "ad-vitae-aut", "Good", true, null, "Games", 41.3925373653846000m, 6.55560165483300m, 0.70160124623291253, 1, 6, new DateTime(2019, 9, 8, 8, 19, 0, 391, DateTimeKind.Local).AddTicks(3682), 20L },
                    { 21L, false, 0, 0, false, 21L, 21L, new DateTime(2019, 9, 6, 13, 39, 17, 707, DateTimeKind.Local).AddTicks(1380), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(2813), new TimeSpan(0, 0, 0, 0, 0)), 21L, 0, 0, false, @"Quia nesciunt et aliquam est.
                Quia aut nemo vel fuga odio odit sed nihil a.
                Et repellendus cumque.
                Sed sapiente qui voluptatum dolores et tempore neque enim.
                Nostrum repellendus asperiores quae et dicta iusto et sint omnis.", "R$52,26", new DateTime(2019, 10, 4, 11, 51, 14, 424, DateTimeKind.Local).AddTicks(5020), "R$21,15", true, 0.7261191544710280m, 0L, "Small Soft Cheese", true, 26, 21, "9gu7gwka78ioiwyb", "error-ut-et", "Good", true, null, "Computers", 77.3376784647525000m, 6.5994484893043800m, 0.68304773731299107, 9, 5, new DateTime(2019, 9, 8, 5, 47, 8, 830, DateTimeKind.Local).AddTicks(2910), 21L },
                    { 22L, false, 0, 0, false, 22L, 22L, new DateTime(2019, 2, 12, 8, 50, 35, 555, DateTimeKind.Local).AddTicks(5830), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(3576), new TimeSpan(0, 0, 0, 0, 0)), 22L, 0, 0, false, "Odio corrupti quae rem nihil ut voluptate.", "R$11,12", new DateTime(2019, 12, 11, 8, 31, 39, 909, DateTimeKind.Local).AddTicks(3205), "R$87,26", true, 0.6561163103469260m, 0L, "Handmade Fresh Salad", true, 64, 22, "t2gm71s8djyzvcn4", "corrupti-quidem-officiis", "Good", true, null, "Baby", 23.4175663550466000m, 2.8397612240350600m, 0.38736571063630548, 7, 3, new DateTime(2019, 9, 8, 14, 12, 57, 773, DateTimeKind.Local).AddTicks(7334), 22L },
                    { 18L, false, 0, 0, false, 18L, 18L, new DateTime(2019, 1, 25, 16, 47, 55, 118, DateTimeKind.Local).AddTicks(6927), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(1809), new TimeSpan(0, 0, 0, 0, 0)), 18L, 0, 0, false, "Illo sed eos nesciunt tempore modi repudiandae ut ducimus omnis. Rem cum dolore explicabo. Praesentium qui voluptate autem sed. Placeat velit est veritatis aut quasi ipsa impedit libero. Excepturi ipsa enim velit aliquid expedita dolorum consequatur.", "R$80,46", new DateTime(2020, 5, 5, 7, 41, 7, 284, DateTimeKind.Local).AddTicks(8428), "R$97,47", true, 0.751715179417150m, 0L, "Handmade Frozen Sausages", true, 28, 18, "9yc02ilhk31bq7ta", "tempora-rerum-harum", "Good", true, null, "Electronics", 99.7582716866202000m, 9.0272553260565100m, 0.46440220878664507, 9, 8, new DateTime(2019, 9, 9, 1, 40, 28, 590, DateTimeKind.Local).AddTicks(2475), 18L },
                    { 24L, false, 0, 0, false, 24L, 24L, new DateTime(2018, 11, 24, 19, 27, 24, 956, DateTimeKind.Local).AddTicks(5555), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(4192), new TimeSpan(0, 0, 0, 0, 0)), 24L, 0, 0, false, "Nulla nisi eum nulla. At et dignissimos. Optio quam rerum veniam consequatur et corporis. Ullam et iste quia dolor et qui ullam minus. Blanditiis earum explicabo animi provident. Perspiciatis ipsum totam qui dolorum non vel mollitia quod.", "R$183,65", new DateTime(2019, 12, 26, 21, 36, 54, 877, DateTimeKind.Local).AddTicks(6437), "R$23,70", true, 0.003113708460290780m, 0L, "Awesome Soft Car", true, 32, 24, "wejonaqq0t7gjo06", "aut-laborum-nihil", "Good", true, null, "Grocery", 93.7677325651831000m, 5.7769837117646800m, 0.6027264234622598, 6, 0, new DateTime(2019, 9, 8, 21, 36, 41, 551, DateTimeKind.Local).AddTicks(1046), 24L },
                    { 23L, false, 0, 0, false, 23L, 23L, new DateTime(2019, 7, 9, 8, 57, 0, 765, DateTimeKind.Local).AddTicks(5891), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(3940), new TimeSpan(0, 0, 0, 0, 0)), 23L, 0, 0, false, "Porro eum doloremque eum quo.", "R$61,73", new DateTime(2020, 3, 17, 9, 30, 38, 569, DateTimeKind.Local).AddTicks(4133), "R$51,49", true, 0.8541778492993570m, 0L, "Refined Metal Keyboard", true, 96, 23, "1mfu62y5tcyn4wwx", "excepturi-excepturi-eum", "Good", true, null, "Sports", 8.10807221946682000m, 5.733005481647800m, 0.76432975370638523, 9, 9, new DateTime(2019, 9, 9, 5, 30, 10, 451, DateTimeKind.Local).AddTicks(4002), 23L },
                    { 33L, false, 0, 0, false, 33L, 33L, new DateTime(2018, 10, 28, 16, 10, 21, 204, DateTimeKind.Local).AddTicks(7915), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(7285), new TimeSpan(0, 0, 0, 0, 0)), 33L, 0, 0, false, "Ea recusandae similique dolores aut.", "R$190,30", new DateTime(2019, 12, 23, 19, 25, 56, 132, DateTimeKind.Local).AddTicks(2567), "R$35,80", true, 0.5232920970410540m, 0L, "Ergonomic Granite Soap", true, 56, 33, "9fpkb8ockbr7ivz2", "voluptates-magni-voluptatem", "Good", true, null, "Electronics", 71.0297122462791000m, 0.75586658472002800m, 0.75644976448102375, 1, 3, new DateTime(2019, 9, 9, 2, 39, 36, 168, DateTimeKind.Local).AddTicks(5508), 33L },
                    { 32L, false, 0, 0, false, 32L, 32L, new DateTime(2018, 9, 20, 12, 23, 32, 879, DateTimeKind.Local).AddTicks(6983), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(6821), new TimeSpan(0, 0, 0, 0, 0)), 32L, 0, 0, false, "Quam facilis reiciendis dolores ea et voluptatum. Recusandae et deleniti. Porro neque libero minus neque. Minima non nemo facere nostrum. Qui mollitia veniam a numquam sapiente. Similique dolorem qui a odit expedita qui.", "R$26,99", new DateTime(2019, 12, 11, 10, 18, 44, 334, DateTimeKind.Local).AddTicks(4373), "R$61,46", true, 0.1324061626253680m, 0L, "Fantastic Cotton Shirt", true, 82, 32, "x87kne0zdrmlyml2", "eum-ut-tenetur", "Good", true, null, "Toys", 27.5612058711989000m, 6.3808084122747200m, 0.9980431264257259, 6, 0, new DateTime(2019, 9, 9, 2, 50, 21, 500, DateTimeKind.Local).AddTicks(571), 32L },
                    { 30L, false, 0, 0, false, 30L, 30L, new DateTime(2019, 2, 9, 0, 36, 35, 653, DateTimeKind.Local).AddTicks(6754), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(6204), new TimeSpan(0, 0, 0, 0, 0)), 30L, 0, 0, false, @"Sed quod porro sint.
                Necessitatibus ea ut aperiam quis fuga totam facilis.
                At vitae hic qui quod.
                Distinctio velit incidunt.", "R$21,21", new DateTime(2020, 9, 2, 14, 25, 19, 384, DateTimeKind.Local).AddTicks(371), "R$94,40", true, 0.928556223832330m, 0L, "Fantastic Wooden Fish", true, 34, 30, "9a4juekhdiugky9a", "dolor-officiis-qui", "Good", true, null, "Games", 20.2414014470956000m, 7.0903575732793500m, 0.49126131436380621, 7, 4, new DateTime(2019, 9, 8, 3, 59, 56, 527, DateTimeKind.Local).AddTicks(3208), 30L },
                    { 34L, false, 0, 0, false, 34L, 34L, new DateTime(2019, 8, 31, 10, 34, 3, 984, DateTimeKind.Local).AddTicks(7926), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(7538), new TimeSpan(0, 0, 0, 0, 0)), 34L, 0, 0, false, "Sint vel doloribus. Et et dolor magnam fugiat mollitia consequatur. Distinctio ut nemo omnis quibusdam repudiandae. Earum voluptatem non et qui qui qui.", "R$91,56", new DateTime(2020, 6, 24, 13, 9, 25, 18, DateTimeKind.Local).AddTicks(4500), "R$50,28", true, 0.1621617251830930m, 0L, "Handmade Steel Keyboard", true, 26, 34, "uwm3htk4u916qyew", "eveniet-ea-hic", "Good", true, null, "Baby", 16.4277588559444000m, 4.1081332341340100m, 0.92754169410445808, 4, 2, new DateTime(2019, 9, 9, 9, 39, 3, 575, DateTimeKind.Local).AddTicks(1117), 34L },
                    { 28L, false, 0, 0, false, 28L, 28L, new DateTime(2019, 5, 6, 21, 2, 9, 863, DateTimeKind.Local).AddTicks(6449), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(5523), new TimeSpan(0, 0, 0, 0, 0)), 28L, 0, 0, false, "Omnis pariatur sed explicabo aut recusandae saepe. Voluptas voluptatem et sint aperiam cupiditate. Molestiae earum molestiae enim ut reiciendis. Illum sit voluptatem ducimus vitae repudiandae dolorem non. Ex laborum at aut in quae.", "R$48,04", new DateTime(2020, 7, 5, 11, 56, 31, 400, DateTimeKind.Local).AddTicks(9738), "R$25,16", true, 0.346411271182080m, 0L, "Licensed Rubber Sausages", true, 48, 28, "egiz8aaekfkcca8k", "quis-ut-iusto", "Good", true, null, "Tools", 53.9993072180074000m, 3.1915786132177200m, 0.67787231722747554, 8, 7, new DateTime(2019, 9, 9, 2, 35, 13, 68, DateTimeKind.Local).AddTicks(3014), 28L },
                    { 27L, false, 0, 0, false, 27L, 27L, new DateTime(2019, 2, 5, 12, 50, 57, 241, DateTimeKind.Local).AddTicks(9176), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(5298), new TimeSpan(0, 0, 0, 0, 0)), 27L, 0, 0, false, "eveniet", "R$57,27", new DateTime(2020, 1, 18, 2, 41, 14, 836, DateTimeKind.Local).AddTicks(2239), "R$51,30", true, 0.770234314617810m, 0L, "Ergonomic Cotton Soap", true, 94, 27, "khl1b6wef62jia2h", "non-corporis-qui", "Good", true, null, "Books", 49.2119146274458000m, 3.1755697322895600m, 0.89477759408521351, 9, 4, new DateTime(2019, 9, 9, 9, 32, 45, 285, DateTimeKind.Local).AddTicks(4725), 27L },
                    { 26L, false, 0, 0, false, 26L, 26L, new DateTime(2019, 2, 7, 16, 39, 54, 902, DateTimeKind.Local).AddTicks(6924), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(4944), new TimeSpan(0, 0, 0, 0, 0)), 26L, 0, 0, false, @"Nobis ea et dolores provident.
                Nisi ratione sed dolorem accusantium ut.
                Aut dolorem eum aut necessitatibus est.", "R$155,71", new DateTime(2020, 7, 29, 3, 29, 43, 42, DateTimeKind.Local).AddTicks(9590), "R$5,88", true, 0.7917723743206690m, 0L, "Awesome Steel Bike", true, 60, 26, "am8qt4ya0ltjykeo", "porro-ducimus-aut", "Good", true, null, "Books", 55.3120605905131000m, 4.0461454466200200m, 0.86214974516171483, 1, 2, new DateTime(2019, 9, 8, 18, 58, 0, 375, DateTimeKind.Local).AddTicks(6262), 26L },
                    { 25L, false, 0, 0, false, 25L, 25L, new DateTime(2019, 6, 3, 9, 43, 28, 426, DateTimeKind.Local).AddTicks(5461), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 0, 0, 0, 0)), 25L, 0, 0, false, "nihil", "R$69,89", new DateTime(2019, 9, 20, 12, 34, 30, 930, DateTimeKind.Local).AddTicks(1322), "R$64,65", true, 0.8599056326131830m, 0L, "Handmade Soft Ball", true, 38, 25, "d2nf8jaizih3wtq6", "iusto-atque-numquam", "Good", true, null, "Shoes", 98.8738825539471000m, 9.5097837082621600m, 0.13911046094219687, 5, 6, new DateTime(2019, 9, 8, 22, 43, 15, 40, DateTimeKind.Local).AddTicks(6150), 25L },
                    { 29L, false, 0, 0, false, 29L, 29L, new DateTime(2019, 4, 14, 6, 29, 46, 570, DateTimeKind.Local).AddTicks(3719), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 918, DateTimeKind.Unspecified).AddTicks(5978), new TimeSpan(0, 0, 0, 0, 0)), 29L, 0, 0, false, "vero", "R$109,22", new DateTime(2019, 10, 5, 4, 35, 16, 151, DateTimeKind.Local).AddTicks(8732), "R$69,76", true, 0.5103052773095230m, 0L, "Refined Cotton Bacon", true, 52, 29, "2rucmckw17tnuzl4", "illum-quaerat-et", "Good", true, null, "Games", 87.8897731601679000m, 8.9149092412157500m, 0.69694294347285435, 2, 9, new DateTime(2019, 9, 9, 4, 9, 10, 152, DateTimeKind.Local).AddTicks(131), 29L }
                });

            migrationBuilder.InsertData(
                table: "StormyVendor",
                columns: new[] { "Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite" },
                values: new object[,]
                {
                    { 9L, 0, null, "Moraes, Carvalho and Nogueira", "Pete_Reis1", "Pete88@live.com", false, new DateTimeOffset(new DateTime(2019, 8, 19, 1, 10, 10, 781, DateTimeKind.Unspecified).AddTicks(9526), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1437624520", "A similique quia neque dolorum accusantium ea dolore impedit.", "(45) 43630-3534", "0", "Baby & Home", "fabrício.net" },
                    { 1L, 0, null, "Moreira, Carvalho and Martins", "Tommie.Nogueira83", "Tommie97@yahoo.com", false, new DateTimeOffset(new DateTime(2019, 9, 7, 23, 30, 40, 955, DateTimeKind.Unspecified).AddTicks(9853), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=2123917279", @"Consequatur sed ducimus cum dolores laudantium cumque.
                Sunt commodi qui sit autem et debitis dolores.", "+55 (85) 8173-5459", "0", "Computers, Jewelery & Tools", "júlio.biz" },
                    { 2L, 0, null, "Macedo - Oliveira", "Marjorie8", "Marjorie39@gmail.com", false, new DateTimeOffset(new DateTime(2019, 9, 7, 5, 3, 43, 765, DateTimeKind.Unspecified).AddTicks(5695), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=342631471", "Consectetur architecto eum sit molestiae at distinctio ut consequatur. Vero sit quos autem repellendus qui voluptatibus. Et excepturi adipisci fuga. Consequatur voluptatem perferendis.", "+55 (93) 6512-8363", "0", "Toys, Electronics & Sports", "breno.net" },
                    { 3L, 0, null, "Nogueira e Associados", "Sylvester.Albuquerque", "Sylvester_Albuquerque56@bol.com.br", false, new DateTimeOffset(new DateTime(2019, 8, 26, 0, 11, 35, 172, DateTimeKind.Unspecified).AddTicks(8789), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=352140114", "eum", "(67) 39799-6845", "0", "Tools, Electronics & Beauty", "yuri.net" },
                    { 4L, 0, null, "Albuquerque - Moraes", "Brendan39", "Brendan.Melo@hotmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 25, 14, 57, 47, 837, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=476183543", "Delectus earum eum et qui qui explicabo.", "(89) 99747-1717", "0", "Games", "lorena.info" },
                    { 5L, 0, null, "Martins, Moreira and Silva", "Otis_Moraes36", "Otis98@gmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 29, 1, 13, 15, 434, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=139736825", "Ab dicta corporis qui et est ducimus.", "+55 (78) 8546-2918", "0", "Clothing & Electronics", "júlio césar.br" },
                    { 6L, 0, null, "Santos - Franco", "Adrienne.Reis", "Adrienne_Reis@hotmail.com", false, new DateTimeOffset(new DateTime(2019, 9, 5, 10, 48, 3, 871, DateTimeKind.Unspecified).AddTicks(3071), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=2023165179", "Sit voluptatum vero aut laborum quo. Consequatur odit quidem est aspernatur et expedita. Sapiente aspernatur saepe facilis rerum explicabo eveniet suscipit officiis error. Inventore sit corporis voluptatem. Tempora aut adipisci ut perspiciatis est laborum sit quis.", "+55 (49) 3492-4307", "0", "Shoes", "marli.name" },
                    { 7L, 0, null, "Santos - Albuquerque", "Holly.Nogueira", "Holly.Nogueira21@bol.com.br", false, new DateTimeOffset(new DateTime(2019, 8, 30, 21, 43, 59, 214, DateTimeKind.Unspecified).AddTicks(6228), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=594888452", "deserunt", "(03) 4665-3852", "0", "Automotive", "janaína.br" },
                    { 8L, 0, null, "Reis S.A.", "Connie18", "Connie.Costa@gmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 27, 22, 42, 40, 547, DateTimeKind.Unspecified).AddTicks(6730), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1834192405", "Minus eius ipsum nisi consequatur voluptatum voluptas. Beatae incidunt quas voluptas earum ducimus provident ut in ut. Corporis eos culpa. Rerum est a earum deleniti.", "+55 (13) 3764-5286", "0", "Industrial", "isabela.info" },
                    { 10L, 0, null, "Franco, Melo and Silva", "Garry_Carvalho73", "Garry_Carvalho74@yahoo.com", false, new DateTimeOffset(new DateTime(2019, 8, 20, 6, 44, 30, 113, DateTimeKind.Unspecified).AddTicks(326), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=2066227561", @"Delectus aliquam ea cum assumenda odio aspernatur.
                Qui sint cupiditate reprehenderit.
                Nisi impedit nobis voluptate autem magni.
                Rerum necessitatibus eum illum dolorem molestiae sapiente.
                Ut magnam eius sit et.", "(08) 9533-3947", "0", "Beauty", "paulo.info" }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName" },
                values: new object[,]
                {
                    { 11L, null, "http://lorempixel.com/640/480/fashion", -1264734430, false, new DateTimeOffset(new DateTime(2019, 8, 26, 3, 35, 23, 737, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 33L, null, "http://lorempixel.com/640/480/fashion", -1473902813, false, new DateTimeOffset(new DateTime(2019, 8, 29, 15, 29, 46, 329, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 34L, null, "http://lorempixel.com/640/480/fashion", 540893930, false, new DateTimeOffset(new DateTime(2019, 9, 1, 9, 1, 57, 808, DateTimeKind.Unspecified).AddTicks(1421), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 36L, null, "http://lorempixel.com/640/480/fashion", 1424906684, false, new DateTimeOffset(new DateTime(2019, 9, 3, 20, 5, 2, 151, DateTimeKind.Unspecified).AddTicks(8643), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 37L, null, "http://lorempixel.com/640/480/fashion", 945018751, false, new DateTimeOffset(new DateTime(2019, 9, 1, 15, 33, 22, 437, DateTimeKind.Unspecified).AddTicks(7363), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 38L, null, "http://lorempixel.com/640/480/fashion", -1684380823, false, new DateTimeOffset(new DateTime(2019, 8, 30, 12, 58, 6, 608, DateTimeKind.Unspecified).AddTicks(9653), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 39L, null, "http://lorempixel.com/640/480/fashion", -402365753, false, new DateTimeOffset(new DateTime(2019, 9, 2, 21, 30, 19, 7, DateTimeKind.Unspecified).AddTicks(8495), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 40L, null, "http://lorempixel.com/640/480/fashion", -1444882552, false, new DateTimeOffset(new DateTime(2019, 9, 6, 5, 6, 49, 244, DateTimeKind.Unspecified).AddTicks(9366), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 41L, null, "http://lorempixel.com/640/480/fashion", -1557697484, false, new DateTimeOffset(new DateTime(2019, 8, 31, 21, 48, 52, 19, DateTimeKind.Unspecified).AddTicks(804), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 42L, null, "http://lorempixel.com/640/480/fashion", -1924705078, false, new DateTimeOffset(new DateTime(2019, 8, 30, 13, 26, 48, 370, DateTimeKind.Unspecified).AddTicks(9557), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 43L, null, "http://lorempixel.com/640/480/fashion", -921539045, false, new DateTimeOffset(new DateTime(2019, 8, 30, 3, 21, 17, 238, DateTimeKind.Unspecified).AddTicks(6943), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 44L, null, "http://lorempixel.com/640/480/fashion", -1102749153, false, new DateTimeOffset(new DateTime(2019, 9, 7, 10, 17, 16, 180, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 45L, null, "http://lorempixel.com/640/480/fashion", 141938577, false, new DateTimeOffset(new DateTime(2019, 9, 5, 9, 41, 6, 837, DateTimeKind.Unspecified).AddTicks(75), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 46L, null, "http://lorempixel.com/640/480/fashion", -2072191706, false, new DateTimeOffset(new DateTime(2019, 8, 26, 9, 53, 19, 909, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 47L, null, "http://lorempixel.com/640/480/fashion", -1392325140, false, new DateTimeOffset(new DateTime(2019, 8, 28, 5, 35, 9, 689, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 48L, null, "http://lorempixel.com/640/480/fashion", -107725463, false, new DateTimeOffset(new DateTime(2019, 8, 26, 15, 10, 27, 511, DateTimeKind.Unspecified).AddTicks(4180), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 49L, null, "http://lorempixel.com/640/480/fashion", -693742117, false, new DateTimeOffset(new DateTime(2019, 9, 8, 12, 28, 38, 715, DateTimeKind.Unspecified).AddTicks(3556), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 50L, null, "http://lorempixel.com/640/480/fashion", 1792125534, false, new DateTimeOffset(new DateTime(2019, 9, 5, 18, 46, 47, 825, DateTimeKind.Unspecified).AddTicks(4955), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 32L, null, "http://lorempixel.com/640/480/fashion", 768884583, false, new DateTimeOffset(new DateTime(2019, 8, 27, 7, 6, 37, 268, DateTimeKind.Unspecified).AddTicks(7628), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 31L, null, "http://lorempixel.com/640/480/fashion", -606887426, false, new DateTimeOffset(new DateTime(2019, 9, 1, 20, 34, 7, 2, DateTimeKind.Unspecified).AddTicks(6484), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 35L, null, "http://lorempixel.com/640/480/fashion", 225239800, false, new DateTimeOffset(new DateTime(2019, 9, 4, 3, 27, 16, 460, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 29L, null, "http://lorempixel.com/640/480/fashion", -1721625985, false, new DateTimeOffset(new DateTime(2019, 9, 3, 3, 13, 44, 289, DateTimeKind.Unspecified).AddTicks(2548), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 12L, null, "http://lorempixel.com/640/480/fashion", -1942048856, false, new DateTimeOffset(new DateTime(2019, 8, 27, 18, 47, 28, 780, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 13L, null, "http://lorempixel.com/640/480/fashion", -594671186, false, new DateTimeOffset(new DateTime(2019, 9, 8, 5, 33, 24, 17, DateTimeKind.Unspecified).AddTicks(1875), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 14L, null, "http://lorempixel.com/640/480/fashion", -1445606272, false, new DateTimeOffset(new DateTime(2019, 9, 4, 0, 55, 43, 575, DateTimeKind.Unspecified).AddTicks(9875), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 15L, null, "http://lorempixel.com/640/480/fashion", -2030646440, false, new DateTimeOffset(new DateTime(2019, 9, 3, 10, 52, 43, 519, DateTimeKind.Unspecified).AddTicks(2765), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 30L, null, "http://lorempixel.com/640/480/fashion", -275607601, false, new DateTimeOffset(new DateTime(2019, 8, 28, 3, 0, 42, 553, DateTimeKind.Unspecified).AddTicks(34), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 17L, null, "http://lorempixel.com/640/480/fashion", 1225582823, false, new DateTimeOffset(new DateTime(2019, 8, 31, 13, 26, 18, 846, DateTimeKind.Unspecified).AddTicks(2099), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 18L, null, "http://lorempixel.com/640/480/fashion", 1072923031, false, new DateTimeOffset(new DateTime(2019, 8, 27, 22, 42, 43, 546, DateTimeKind.Unspecified).AddTicks(9084), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 19L, null, "http://lorempixel.com/640/480/fashion", 92350989, false, new DateTimeOffset(new DateTime(2019, 8, 31, 17, 44, 46, 553, DateTimeKind.Unspecified).AddTicks(9482), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 20L, null, "http://lorempixel.com/640/480/fashion", -605189417, false, new DateTimeOffset(new DateTime(2019, 8, 30, 5, 51, 28, 941, DateTimeKind.Unspecified).AddTicks(5704), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 16L, null, "http://lorempixel.com/640/480/fashion", 122236656, false, new DateTimeOffset(new DateTime(2019, 8, 28, 2, 37, 36, 230, DateTimeKind.Unspecified).AddTicks(9535), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 22L, null, "http://lorempixel.com/640/480/fashion", 1451929477, false, new DateTimeOffset(new DateTime(2019, 9, 6, 23, 30, 29, 540, DateTimeKind.Unspecified).AddTicks(7942), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 23L, null, "http://lorempixel.com/640/480/fashion", 1131857972, false, new DateTimeOffset(new DateTime(2019, 8, 29, 13, 52, 5, 678, DateTimeKind.Unspecified).AddTicks(2428), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 24L, null, "http://lorempixel.com/640/480/fashion", -2060878840, false, new DateTimeOffset(new DateTime(2019, 8, 26, 20, 22, 57, 333, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 25L, null, "http://lorempixel.com/640/480/fashion", -528168889, false, new DateTimeOffset(new DateTime(2019, 9, 3, 2, 34, 18, 488, DateTimeKind.Unspecified).AddTicks(5124), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 26L, null, "http://lorempixel.com/640/480/fashion", -282695610, false, new DateTimeOffset(new DateTime(2019, 8, 28, 17, 17, 17, 453, DateTimeKind.Unspecified).AddTicks(1616), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 27L, null, "http://lorempixel.com/640/480/fashion", 678894843, false, new DateTimeOffset(new DateTime(2019, 9, 1, 20, 48, 47, 41, DateTimeKind.Unspecified).AddTicks(713), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 28L, null, "http://lorempixel.com/640/480/fashion", 2063657694, false, new DateTimeOffset(new DateTime(2019, 8, 26, 1, 36, 29, 982, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 21L, null, "http://lorempixel.com/640/480/fashion", 1513091595, false, new DateTimeOffset(new DateTime(2019, 8, 30, 15, 32, 19, 811, DateTimeKind.Unspecified).AddTicks(8211), new TimeSpan(0, -3, 0, 0, 0)), 1, null }
                });

            migrationBuilder.InsertData(
                table: "StormyProduct",
                columns: new[] { "Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId" },
                values: new object[,]
                {
                    { 8L, false, 0, 0, false, 8L, 8L, new DateTime(2018, 12, 13, 5, 29, 20, 226, DateTimeKind.Local).AddTicks(7086), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(7787), new TimeSpan(0, 0, 0, 0, 0)), 8L, 0, 0, false, @"Sunt eum culpa aut.
                Possimus id aut qui ut repellendus et porro.
                Et et ut debitis consectetur.
                Veniam veritatis omnis laudantium aliquam.
                Qui et quia eos vel voluptatem minima ipsam magni rerum.
                Eum dolores dolores temporibus cumque vel expedita consequuntur provident.", "R$190,52", new DateTime(2020, 4, 12, 6, 21, 14, 457, DateTimeKind.Local).AddTicks(5375), "R$1,38", true, 0.2150053415517350m, 0L, "Fantastic Metal Fish", true, 72, 8, "fpxkbn6gp9e979ei", "harum-alias-voluptates", "Good", true, null, "Grocery", 28.2546035611325000m, 2.9549101474484900m, 0.60256014745801689, 7, 9, new DateTime(2019, 9, 8, 20, 20, 10, 461, DateTimeKind.Local).AddTicks(3142), 8L },
                    { 7L, false, 0, 0, false, 7L, 7L, new DateTime(2019, 3, 30, 2, 18, 4, 735, DateTimeKind.Local).AddTicks(9261), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(7323), new TimeSpan(0, 0, 0, 0, 0)), 7L, 0, 0, false, @"Ut perferendis nobis ut cupiditate et nisi et.
                Molestias accusantium hic animi itaque enim ratione tenetur in.
                Adipisci ipsam qui vel soluta iusto.
                Amet quae suscipit.", "R$161,72", new DateTime(2020, 6, 13, 19, 1, 17, 356, DateTimeKind.Local).AddTicks(2398), "R$26,29", true, 0.07071043414562490m, 0L, "Small Steel Pizza", true, 78, 7, "l0qlnowe0pgp7msb", "repellendus-et-ea", "Good", true, null, "Kids", 97.4202213796881000m, 4.0556088062262200m, 0.41329447059579866, 3, 8, new DateTime(2019, 9, 9, 6, 27, 23, 53, DateTimeKind.Local).AddTicks(2060), 7L },
                    { 6L, false, 0, 0, false, 6L, 6L, new DateTime(2019, 8, 31, 6, 38, 24, 117, DateTimeKind.Local).AddTicks(5520), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(7059), new TimeSpan(0, 0, 0, 0, 0)), 6L, 0, 0, false, "Sequi optio nulla consequatur sapiente voluptatibus.", "R$135,02", new DateTime(2020, 2, 19, 20, 48, 2, 766, DateTimeKind.Local).AddTicks(5147), "R$59,48", true, 0.7921158698350730m, 0L, "Generic Plastic Gloves", true, 46, 6, "brr663l45p872gsd", "a-alias-sit", "Good", true, null, "Kids", 38.5838592604659000m, 7.2271772833667600m, 0.38442640629803126, 5, 3, new DateTime(2019, 9, 8, 19, 1, 4, 366, DateTimeKind.Local).AddTicks(6864), 6L },
                    { 5L, false, 0, 0, false, 5L, 5L, new DateTime(2019, 3, 15, 4, 11, 0, 638, DateTimeKind.Local).AddTicks(3516), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 0, 0, 0, 0)), 5L, 0, 0, false, "nisi", "R$134,46", new DateTime(2020, 6, 10, 6, 6, 18, 659, DateTimeKind.Local).AddTicks(510), "R$76,15", true, 0.09680832926966640m, 0L, "Small Rubber Towels", true, 74, 5, "34rs0rjpi4tv1gc4", "architecto-et-asperiores", "Good", true, null, "Games", 75.8200576881972000m, 1.5803035169748100m, 0.77614764858789165, 4, 1, new DateTime(2019, 9, 9, 20, 30, 0, 901, DateTimeKind.Local).AddTicks(6459), 5L },
                    { 1L, false, 0, 0, false, 1L, 1L, new DateTime(2018, 10, 4, 16, 39, 33, 207, DateTimeKind.Local).AddTicks(9385), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 906, DateTimeKind.Unspecified).AddTicks(6303), new TimeSpan(0, 0, 0, 0, 0)), 1L, 0, 0, false, "est", "R$7,24", new DateTime(2020, 1, 2, 5, 56, 29, 546, DateTimeKind.Local).AddTicks(5964), "R$4,77", true, 0.04347067002368660m, 0L, "Ergonomic Fresh Table", true, 18, 1, "cbyd2dund75ea07i", "non-eaque-quidem", "Good", true, null, "Computers", 23.0859608962601000m, 4.0319945449158500m, 0.30094694220505047, 5, 2, new DateTime(2019, 9, 8, 13, 52, 41, 757, DateTimeKind.Local).AddTicks(8425), 1L },
                    { 3L, false, 0, 0, false, 3L, 3L, new DateTime(2019, 3, 3, 9, 53, 57, 951, DateTimeKind.Local).AddTicks(8916), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(5724), new TimeSpan(0, 0, 0, 0, 0)), 3L, 0, 0, false, @"Et quia aliquam.
                Enim libero blanditiis rem nesciunt modi id sed est odit.
                Dignissimos dicta officia inventore ut necessitatibus modi cumque.", "R$176,56", new DateTime(2019, 12, 11, 7, 1, 30, 73, DateTimeKind.Local).AddTicks(5570), "R$71,02", true, 0.7951030809409460m, 0L, "Intelligent Wooden Salad", true, 78, 3, "exkjp46yha6h87as", "nobis-assumenda-nisi", "Good", true, null, "Automotive", 10.118744853008000m, 0.25107908074328600m, 0.24961629009322089, 5, 6, new DateTime(2019, 9, 9, 9, 8, 58, 703, DateTimeKind.Local).AddTicks(265), 3L },
                    { 2L, false, 0, 0, false, 2L, 2L, new DateTime(2019, 1, 13, 3, 3, 20, 801, DateTimeKind.Local).AddTicks(5271), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(4756), new TimeSpan(0, 0, 0, 0, 0)), 2L, 0, 0, false, "quos", "R$117,68", new DateTime(2019, 12, 30, 23, 39, 4, 811, DateTimeKind.Local).AddTicks(4771), "R$87,32", true, 0.8837425079586650m, 0L, "Refined Wooden Tuna", true, 84, 2, "wxy9cwjnlzwu3gm8", "rerum-dicta-et", "Good", true, null, "Outdoors", 16.2922104430814000m, 2.1128529226932900m, 0.60742099937397098, 3, 1, new DateTime(2019, 9, 9, 3, 4, 58, 9, DateTimeKind.Local).AddTicks(5999), 2L },
                    { 9L, false, 0, 0, false, 9L, 9L, new DateTime(2019, 4, 18, 3, 34, 38, 806, DateTimeKind.Local).AddTicks(5433), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(8323), new TimeSpan(0, 0, 0, 0, 0)), 9L, 0, 0, false, @"Voluptas est dignissimos dolorum quaerat.
                Possimus temporibus aut et modi at nobis quos.
                Animi id doloremque nobis repellat cumque et quasi quis voluptatem.
                Omnis ut est nihil a saepe quaerat.
                Autem earum a mollitia molestiae ea in officia.", "R$180,84", new DateTime(2020, 1, 27, 11, 19, 24, 184, DateTimeKind.Local).AddTicks(9789), "R$81,26", true, 0.3610175053407520m, 0L, "Refined Granite Soap", true, 10, 9, "4mpm6hyymme7615d", "eligendi-occaecati-culpa", "Good", true, null, "Computers", 72.4169059062455000m, 3.390606214939900m, 0.98345063346598793, 2, 2, new DateTime(2019, 9, 9, 13, 14, 52, 154, DateTimeKind.Local).AddTicks(8896), 9L },
                    { 4L, false, 0, 0, false, 4L, 4L, new DateTime(2019, 2, 12, 12, 0, 46, 915, DateTimeKind.Local).AddTicks(8280), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(6234), new TimeSpan(0, 0, 0, 0, 0)), 4L, 0, 0, false, "Delectus reiciendis tempora excepturi iusto harum. Minus illo eaque tempora sit laudantium. Facere accusantium impedit animi nesciunt beatae voluptatem ratione. Adipisci inventore explicabo. Velit corporis veritatis accusamus praesentium veniam nemo.", "R$195,48", new DateTime(2020, 5, 4, 15, 30, 15, 582, DateTimeKind.Local).AddTicks(1231), "R$98,72", true, 0.6309451948064120m, 0L, "Handmade Frozen Mouse", true, 58, 4, "o0ycj0bvryyu3xgt", "iure-odit-expedita", "Good", true, null, "Jewelery", 54.640758342408000m, 5.0742225884805500m, 0.049929586728070671, 5, 1, new DateTime(2019, 9, 8, 20, 43, 0, 453, DateTimeKind.Local).AddTicks(7007), 4L },
                    { 10L, false, 0, 0, false, 10L, 10L, new DateTime(2019, 8, 11, 9, 52, 51, 730, DateTimeKind.Local).AddTicks(9788), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 1, 21, 49, 917, DateTimeKind.Unspecified).AddTicks(8786), new TimeSpan(0, 0, 0, 0, 0)), 10L, 0, 0, false, "Beatae nisi ut est asperiores iste architecto similique quia et. Amet dignissimos ut non. Et aperiam quibusdam ea ratione.", "R$149,33", new DateTime(2020, 2, 8, 2, 14, 36, 933, DateTimeKind.Local).AddTicks(9338), "R$85,93", true, 0.3106617272415490m, 0L, "Practical Concrete Salad", true, 32, 10, "pl8m5cqwu2gnbl0p", "sapiente-rerum-qui", "Good", true, null, "Music", 11.1523835506068000m, 6.0029580378918700m, 0.80688511757500703, 1, 9, new DateTime(2019, 9, 8, 16, 28, 21, 84, DateTimeKind.Local).AddTicks(126), 10L }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName" },
                values: new object[,]
                {
                    { 1L, null, "http://lorempixel.com/640/480/fashion", 471510968, false, new DateTimeOffset(new DateTime(2019, 8, 26, 1, 58, 5, 219, DateTimeKind.Unspecified).AddTicks(449), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 2L, null, "http://lorempixel.com/640/480/fashion", -625983839, false, new DateTimeOffset(new DateTime(2019, 9, 1, 19, 0, 2, 499, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 3L, null, "http://lorempixel.com/640/480/fashion", 333507804, false, new DateTimeOffset(new DateTime(2019, 9, 7, 20, 53, 49, 641, DateTimeKind.Unspecified).AddTicks(3050), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 4L, null, "http://lorempixel.com/640/480/fashion", -1873580435, false, new DateTimeOffset(new DateTime(2019, 9, 1, 18, 29, 49, 8, DateTimeKind.Unspecified).AddTicks(9532), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 5L, null, "http://lorempixel.com/640/480/fashion", -727424194, false, new DateTimeOffset(new DateTime(2019, 8, 28, 8, 20, 30, 142, DateTimeKind.Unspecified).AddTicks(5020), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 6L, null, "http://lorempixel.com/640/480/fashion", -2021669936, false, new DateTimeOffset(new DateTime(2019, 9, 4, 18, 55, 5, 553, DateTimeKind.Unspecified).AddTicks(5022), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 7L, null, "http://lorempixel.com/640/480/fashion", -732655365, false, new DateTimeOffset(new DateTime(2019, 9, 2, 4, 41, 51, 347, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 8L, null, "http://lorempixel.com/640/480/fashion", -692453031, false, new DateTimeOffset(new DateTime(2019, 8, 30, 0, 39, 26, 566, DateTimeKind.Unspecified).AddTicks(2167), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 9L, null, "http://lorempixel.com/640/480/fashion", 1801307023, false, new DateTimeOffset(new DateTime(2019, 8, 28, 15, 44, 32, 363, DateTimeKind.Unspecified).AddTicks(180), new TimeSpan(0, -3, 0, 0, 0)), 1, null },
                    { 10L, null, "http://lorempixel.com/640/480/fashion", 316626617, false, new DateTimeOffset(new DateTime(2019, 9, 3, 8, 4, 9, 92, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, -3, 0, 0, 0)), 1, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "StormyProduct",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.UpdateData(
                table: "Shipment",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModified", "TrackNumber" },
                values: new object[] { new DateTime(2019, 9, 9, 1, 16, 41, 284, DateTimeKind.Utc).AddTicks(8020), new DateTimeOffset(new DateTime(2019, 9, 9, 1, 16, 41, 284, DateTimeKind.Unspecified).AddTicks(7623), new TimeSpan(0, 0, 0, 0, 0)), "c66c417d-9f28-41ce-9bd3-906c469c848d" });
        }
    }
}
