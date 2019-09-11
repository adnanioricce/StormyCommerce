using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Complement", "Country", "District", "FirstAddress", "IsDeleted", "LastModified", "Number", "OwnerId", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street", "WhoReceives" },
                values: new object[,]
                {
                    { 6L, "Nova Natanieldo Norte", null, null, null, "Braga Rua", false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 161, DateTimeKind.Unspecified).AddTicks(4432), new TimeSpan(0, 0, 0, 0, 0)), "2051", 0L, "(37) 12628-8071", "67426-858", "Quadra 96", "Rio Grande do Sul", "664 Tertuliano Viela", null },
                    { 2L, "Reisdo Descoberto", null, null, null, "Carvalho Marginal", false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 161, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 0, 0, 0, 0)), "509", 0L, "+55 (23) 0650-6201", "06264", "Casa 5", "Mato Grosso", "9682 Saraiva Avenida", null },
                    { 3L, "Nogueirade Nossa Senhora", null, null, null, "Braga Ponte", false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 161, DateTimeKind.Unspecified).AddTicks(2728), new TimeSpan(0, 0, 0, 0, 0)), "996", 0L, "(88) 1410-7711", "85884", "Sobrado 72", "Maranhão", "7316 Alexandre Alameda", null },
                    { 4L, "Grande Félix", null, null, null, "Martins Marginal", false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 161, DateTimeKind.Unspecified).AddTicks(3302), new TimeSpan(0, 0, 0, 0, 0)), "1294", 0L, "(38) 2251-2720", "04589-435", "Apto. 840", "Roraima", "372 Batista Alameda", null },
                    { 5L, "Nova Joanado Sul", null, null, null, "Franco Marginal", false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 161, DateTimeKind.Unspecified).AddTicks(3846), new TimeSpan(0, 0, 0, 0, 0)), "4183", 0L, "+55 (37) 7100-4115", "31509-742", "Quadra 44", "Pará", "708 Sara Viela", null },
                    { 1L, "Grande Cecíliado Descoberto", null, null, null, "Marcelo Rua", false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 141, DateTimeKind.Unspecified).AddTicks(5456), new TimeSpan(0, 0, 0, 0, 0)), "940", 0L, "(81) 8480-7756", "67169-238", "Apto. 622", "Amazonas", "4466 Júlia Rua", null },
                    { 8L, "Nova Yango", null, null, null, "Carlos Travessa", false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 161, DateTimeKind.Unspecified).AddTicks(5543), new TimeSpan(0, 0, 0, 0, 0)), "87530", 0L, "(97) 3072-3070", "47127-472", "Apto. 290", "Rondônia", "5570 Albuquerque Rua", null },
                    { 9L, "Nova Elísio", null, null, null, "Paula Ponte", false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 161, DateTimeKind.Unspecified).AddTicks(6114), new TimeSpan(0, 0, 0, 0, 0)), "986", 0L, "(18) 71716-7491", "43789-159", "Lote 73", "Goiás", "302 Melo Viela", null },
                    { 10L, "Vila Lucasdo Descoberto", null, null, null, "Santos Rodovia", false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 161, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, 0, 0, 0, 0)), "5882", 0L, "(72) 7256-6005", "16812", "Apto. 286", "Rio de Janeiro", "91679 Santos Avenida", null },
                    { 7L, "Município de Kléber", null, null, null, "Pereira Rodovia", false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 161, DateTimeKind.Unspecified).AddTicks(4998), new TimeSpan(0, 0, 0, 0, 0)), "12803", 0L, "(91) 4473-4302", "91145", "Sobrado 80", "Ceará", "60411 Carvalho Marginal", null }
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website" },
                values: new object[,]
                {
                    { 9L, "Est rerum error sequi.", false, new DateTimeOffset(new DateTime(2019, 8, 19, 4, 7, 50, 434, DateTimeKind.Unspecified).AddTicks(8475), new TimeSpan(0, 0, 0, 0, 0)), "https://picsum.photos/640/480/?image=608", "Moreira LTDA", "cumque-atque-ut", "breno.name" },
                    { 1L, @"Iure sit expedita suscipit ipsa.
                Ut error ex dolorem esse et nihil minima quia quaerat.
                Maxime similique esse ut iusto dolor et esse et maxime.
                Eum quia itaque corporis veritatis aliquid.
                Non consequatur sint quam omnis.
                Suscipit minus hic perspiciatis aut magnam.", false, new DateTimeOffset(new DateTime(2019, 8, 29, 8, 56, 19, 963, DateTimeKind.Unspecified).AddTicks(252), new TimeSpan(0, 0, 0, 0, 0)), "https://picsum.photos/640/480/?image=967", "Xavier S.A.", "quisquam-et-suscipit", "tertuliano.com" },
                    { 2L, @"Mollitia cumque eum qui saepe temporibus magni deserunt perferendis.
                Delectus sint sed.
                Maxime sed fugit necessitatibus omnis quis accusantium eos.
                Perspiciatis illo sint consequuntur asperiores quia nam facere corrupti.", false, new DateTimeOffset(new DateTime(2019, 8, 31, 23, 30, 23, 57, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 0, 0, 0, 0)), "https://picsum.photos/640/480/?image=1", "Xavier, Carvalho and Souza", "atque-consequuntur-hic", "fabrício.br" },
                    { 3L, "eligendi", false, new DateTimeOffset(new DateTime(2019, 8, 30, 22, 40, 34, 830, DateTimeKind.Unspecified).AddTicks(3202), new TimeSpan(0, 0, 0, 0, 0)), "https://picsum.photos/640/480/?image=864", "Batista, Carvalho and Braga", "sed-at-assumenda", "mércia.name" },
                    { 4L, "Voluptatem facilis enim enim doloremque qui pariatur ut eos quos.", false, new DateTimeOffset(new DateTime(2019, 8, 22, 4, 5, 57, 360, DateTimeKind.Unspecified).AddTicks(6196), new TimeSpan(0, 0, 0, 0, 0)), "https://picsum.photos/640/480/?image=206", "Nogueira, Reis and Oliveira", "dolorum-cupiditate-totam", "carla.net" },
                    { 5L, @"Ipsa laboriosam eligendi illo ullam quasi.
                Sint non ea nesciunt.
                Dolor deserunt sint fugiat ratione eos.
                Quasi est est quia dolore deserunt beatae sit eos.", false, new DateTimeOffset(new DateTime(2019, 8, 21, 21, 38, 56, 705, DateTimeKind.Unspecified).AddTicks(5740), new TimeSpan(0, 0, 0, 0, 0)), "https://picsum.photos/640/480/?image=191", "Macedo - Nogueira", "rerum-perferendis-veritatis", "rafael.org" },
                    { 6L, "Voluptatem sint itaque id et mollitia sint.", false, new DateTimeOffset(new DateTime(2019, 9, 6, 14, 42, 38, 894, DateTimeKind.Unspecified).AddTicks(2135), new TimeSpan(0, 0, 0, 0, 0)), "https://picsum.photos/640/480/?image=406", "Carvalho S.A.", "et-suscipit-id", "antônio.net" },
                    { 7L, @"Deleniti et deserunt aut repudiandae quisquam quam.
                Voluptate perspiciatis fuga omnis beatae quia dolorum ea veniam facilis.
                Enim magni cum aliquam adipisci asperiores et enim.", false, new DateTimeOffset(new DateTime(2019, 8, 23, 6, 47, 45, 787, DateTimeKind.Unspecified).AddTicks(6498), new TimeSpan(0, 0, 0, 0, 0)), "https://picsum.photos/640/480/?image=362", "Martins S.A.", "itaque-qui-earum", "mércia.biz" },
                    { 8L, @"Commodi sit unde et sunt beatae magni.
                Recusandae iusto et quasi.
                Consequatur et qui iste est consequatur.
                Ducimus iure aut rem consequatur voluptate cumque est quo.
                Qui vero doloribus.
                Quasi explicabo blanditiis atque amet natus in.", false, new DateTimeOffset(new DateTime(2019, 9, 8, 12, 27, 4, 167, DateTimeKind.Unspecified).AddTicks(6952), new TimeSpan(0, 0, 0, 0, 0)), "https://picsum.photos/640/480/?image=525", "Souza - Albuquerque", "in-culpa-et", "sílvia.com" },
                    { 10L, "impedit", false, new DateTimeOffset(new DateTime(2019, 8, 28, 22, 11, 37, 629, DateTimeKind.Unspecified).AddTicks(4903), new TimeSpan(0, 0, 0, 0, 0)), "https://picsum.photos/640/480/?image=579", "Albuquerque - Santos", "itaque-a-qui", "carlos.br" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl" },
                values: new object[,]
                {
                    { 1L, @"Et repudiandae quam debitis praesentium.
                Veritatis odio iure ut et quisquam accusantium.", 0, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 26, 2, 4, 39, 408, DateTimeKind.Unspecified).AddTicks(2498), new TimeSpan(0, 0, 0, 0, 0)), "Blanditiis enim consectetur et et reprehenderit est et recusandae alias.", null, null, "Baby", null, "beatae-animi-cumque", "http://lorempixel.com/640/480/fashion" },
                    { 10L, "Quo vero odit sint excepturi ab adipisci ab quis.", 9, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 24, 11, 19, 36, 250, DateTimeKind.Unspecified).AddTicks(5298), new TimeSpan(0, 0, 0, 0, 0)), "Voluptas temporibus commodi illo nobis.", null, null, "Movies", null, "id-corrupti-dicta", "http://lorempixel.com/640/480/fashion" },
                    { 4L, "est", 3, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 22, 1, 31, 33, 589, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), "Id autem sequi quidem dolor quo cumque vel commodi. Hic laboriosam et adipisci velit dolores. Magnam earum nobis molestias.", null, null, "Baby", null, "vel-aut-impedit", "http://lorempixel.com/640/480/fashion" },
                    { 5L, "Quidem modi et rem officiis rerum. Consequuntur quia voluptatum ullam cupiditate saepe vero voluptatem aperiam. Repellendus quae molestias et asperiores ea. Laudantium consequatur molestiae similique dignissimos reiciendis dolor veritatis nulla. Qui amet voluptatem et doloremque enim quis consequatur maiores est. Nesciunt laborum tenetur atque cum ipsum laborum qui.", 4, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 30, 14, 5, 26, 598, DateTimeKind.Unspecified).AddTicks(4780), new TimeSpan(0, 0, 0, 0, 0)), "Rerum et omnis aut molestias a quaerat nobis adipisci.", null, null, "Industrial", null, "optio-ut-cum", "http://lorempixel.com/640/480/fashion" },
                    { 6L, "quo", 5, true, false, true, new DateTimeOffset(new DateTime(2019, 9, 6, 0, 11, 6, 551, DateTimeKind.Unspecified).AddTicks(8378), new TimeSpan(0, 0, 0, 0, 0)), @"Eos est aut qui modi corporis facere aut.
                Assumenda consequatur dolorem.
                Quas inventore dicta quia natus.
                Cupiditate aliquid fugit quia temporibus beatae voluptate atque harum.
                Aliquid sapiente omnis eos asperiores sed et harum minima.", null, null, "Industrial", null, "ut-nihil-facere", "http://lorempixel.com/640/480/fashion" },
                    { 7L, "Ut quia molestiae ipsa consequatur sequi omnis. Eum voluptatem veniam modi. Vel qui quia voluptatem minus aut quaerat. Laboriosam ullam vel blanditiis ipsa.", 6, true, false, true, new DateTimeOffset(new DateTime(2019, 9, 4, 23, 22, 24, 386, DateTimeKind.Unspecified).AddTicks(7198), new TimeSpan(0, 0, 0, 0, 0)), "voluptatem", null, null, "Grocery", null, "assumenda-consequatur-earum", "http://lorempixel.com/640/480/fashion" },
                    { 8L, @"Nihil dolor perspiciatis consequatur temporibus.
                Est sit a velit omnis est aut harum.
                Dignissimos aut consequuntur modi natus officiis fugit officia voluptas.
                Est blanditiis sit vitae.", 7, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 30, 11, 5, 45, 87, DateTimeKind.Unspecified).AddTicks(5289), new TimeSpan(0, 0, 0, 0, 0)), "Enim sint esse quis amet repellat rem tempore minus sed. Quae ut nostrum ut eos provident et corporis ad. Rerum et deserunt adipisci omnis. Dolor quia deserunt aspernatur dicta deserunt qui esse. Eius laudantium aliquam fugit expedita. Eum possimus quaerat ut et nulla laboriosam.", null, null, "Toys", null, "voluptatem-atque-qui", "http://lorempixel.com/640/480/fashion" },
                    { 9L, @"Qui dolor velit.
                Nostrum dolores qui sit assumenda.
                Ducimus officiis ut et et et.", 8, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 27, 3, 26, 16, 978, DateTimeKind.Unspecified).AddTicks(2132), new TimeSpan(0, 0, 0, 0, 0)), "dolorum", null, null, "Garden", null, "dolor-fugit-cum", "http://lorempixel.com/640/480/fashion" },
                    { 3L, "voluptates", 2, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 18, 7, 1, 37, 906, DateTimeKind.Unspecified).AddTicks(4176), new TimeSpan(0, 0, 0, 0, 0)), "Eligendi atque dicta perferendis natus modi autem. Et fuga maxime dolorum sed veniam consequatur expedita eos. Ad modi minus voluptatibus.", null, null, "Clothing", null, "dolorem-est-labore", "http://lorempixel.com/640/480/fashion" },
                    { 2L, "occaecati", 1, true, false, true, new DateTimeOffset(new DateTime(2019, 9, 7, 23, 9, 40, 741, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 0, 0, 0, 0)), @"Quasi qui expedita esse sint inventore ad nihil quasi.
                Qui et ex voluptatem nobis in qui sed.
                Non molestiae doloribus corrupti.
                Vel reiciendis commodi temporibus laboriosam illo aut ipsum consequuntur occaecati.
                Inventore et est repudiandae pariatur sed ut at voluptatem id.
                Dolore eum delectus est.", null, null, "Industrial", null, "illum-in-quam", "http://lorempixel.com/640/480/fashion" }
                });

            migrationBuilder.InsertData(
                table: "Entity",
                columns: new[] { "Id", "EntityId", "EntityTypeId", "IsDeleted", "LastModified", "Name", "Slug" },
                values: new object[,]
                {
                    { 3L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 12, 9, 2, 431, DateTimeKind.Unspecified).AddTicks(3501), new TimeSpan(0, 0, 0, 0, 0)), "Small Soft Car", "facilis-et-animi" },
                    { 4L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 17, 30, 28, 800, DateTimeKind.Unspecified).AddTicks(1127), new TimeSpan(0, 0, 0, 0, 0)), "Sleek Fresh Car", "rem-delectus-saepe" },
                    { 5L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 4, 26, 15, 881, DateTimeKind.Unspecified).AddTicks(721), new TimeSpan(0, 0, 0, 0, 0)), "Ergonomic Metal Bike", "et-repellat-vero" },
                    { 12L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 22, 27, 35, 472, DateTimeKind.Unspecified).AddTicks(2396), new TimeSpan(0, 0, 0, 0, 0)), "Awesome Granite Bacon", "corporis-et-ut" },
                    { 7L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 16, 13, 13, 448, DateTimeKind.Unspecified).AddTicks(1108), new TimeSpan(0, 0, 0, 0, 0)), "Fantastic Plastic Hat", "expedita-nam-ad" },
                    { 1L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 12, 17, 49, 560, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 0, 0, 0, 0)), "Ergonomic Frozen Tuna", "et-quidem-nisi" },
                    { 8L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 15, 40, 24, 192, DateTimeKind.Unspecified).AddTicks(8222), new TimeSpan(0, 0, 0, 0, 0)), "Licensed Cotton Cheese", "voluptas-nihil-aut" },
                    { 9L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 21, 33, 53, 570, DateTimeKind.Unspecified).AddTicks(6633), new TimeSpan(0, 0, 0, 0, 0)), "Ergonomic Rubber Shirt", "tempore-qui-quibusdam" },
                    { 2L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 14, 9, 30, 304, DateTimeKind.Unspecified).AddTicks(1407), new TimeSpan(0, 0, 0, 0, 0)), "Unbranded Fresh Sausages", "ut-iure-ratione" },
                    { 6L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 9, 39, 20, 630, DateTimeKind.Unspecified).AddTicks(3012), new TimeSpan(0, 0, 0, 0, 0)), "Unbranded Concrete Tuna", "placeat-iure-voluptatem" },
                    { 13L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 11, 27, 56, 452, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), "Gorgeous Cotton Mouse", "exercitationem-placeat-placeat" },
                    { 14L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 11, 26, 52, 865, DateTimeKind.Unspecified).AddTicks(4242), new TimeSpan(0, 0, 0, 0, 0)), "Handcrafted Concrete Car", "itaque-modi-velit" },
                    { 15L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 17, 56, 52, 900, DateTimeKind.Unspecified).AddTicks(2233), new TimeSpan(0, 0, 0, 0, 0)), "Handcrafted Wooden Ball", "autem-dolorem-eos" },
                    { 16L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 15, 30, 19, 414, DateTimeKind.Unspecified).AddTicks(8765), new TimeSpan(0, 0, 0, 0, 0)), "Tasty Fresh Computer", "consequuntur-dolores-occaecati" },
                    { 17L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 23, 59, 13, 505, DateTimeKind.Unspecified).AddTicks(6153), new TimeSpan(0, 0, 0, 0, 0)), "Small Rubber Pants", "fugiat-error-quos" },
                    { 18L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 6, 27, 13, 104, DateTimeKind.Unspecified).AddTicks(527), new TimeSpan(0, 0, 0, 0, 0)), "Gorgeous Concrete Computer", "ut-cumque-ad" },
                    { 19L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 11, 3, 25, 75, DateTimeKind.Unspecified).AddTicks(9840), new TimeSpan(0, 0, 0, 0, 0)), "Rustic Fresh Gloves", "ex-error-et" },
                    { 20L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 9, 11, 57, 646, DateTimeKind.Unspecified).AddTicks(820), new TimeSpan(0, 0, 0, 0, 0)), "Fantastic Rubber Sausages", "autem-aspernatur-vitae" },
                    { 10L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 7, 11, 56, 20, 647, DateTimeKind.Unspecified).AddTicks(2133), new TimeSpan(0, 0, 0, 0, 0)), "Intelligent Metal Shirt", "iure-nostrum-ducimus" },
                    { 11L, 1L, "Product", false, new DateTimeOffset(new DateTime(2019, 9, 8, 22, 14, 45, 295, DateTimeKind.Unspecified).AddTicks(4325), new TimeSpan(0, 0, 0, 0, 0)), "Sleek Cotton Salad", "labore-in-aut" }
                });

            migrationBuilder.UpdateData(
                table: "Shipment",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModified", "TrackNumber" },
                values: new object[] { new DateTime(2019, 9, 9, 3, 16, 6, 727, DateTimeKind.Utc).AddTicks(7409), new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 727, DateTimeKind.Unspecified).AddTicks(7402), new TimeSpan(0, 0, 0, 0, 0)), "4d4d8791-620b-47c2-a0a8-f2c071cae2d3" });

            migrationBuilder.InsertData(
                table: "StormyProduct",
                columns: new[] { "Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId" },
                values: new object[,]
                {
                    { 12L, false, 0, 0, false, 12L, 12L, new DateTime(2019, 8, 13, 17, 25, 56, 346, DateTimeKind.Local).AddTicks(1386), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(8507), new TimeSpan(0, 0, 0, 0, 0)), 12L, 0, 0, false, "Voluptas accusantium delectus. Et ab ullam dolorem perferendis laborum. Quas rerum voluptatem pariatur esse omnis eos quia. Eum a qui ea excepturi aperiam nulla et ad voluptas. Deleniti aut vitae voluptas sequi voluptatem temporibus.", "R$174.49", new DateTime(2020, 1, 28, 9, 46, 15, 665, DateTimeKind.Local).AddTicks(7539), "R$83.56", true, 0.2348219865163890m, 0L, "Generic Cotton Shirt", true, 66, 12, "offcb7em6j6892xj", "eveniet-atque-qui", "Good", true, null, "Books", 18.8268704893193000m, 5.7567849176734600m, 0.081294152457869681, 5, 6, new DateTime(2019, 9, 8, 23, 7, 59, 496, DateTimeKind.Local).AddTicks(1654), 12L },
                    { 20L, false, 0, 0, false, 20L, 20L, new DateTime(2019, 9, 7, 7, 29, 12, 455, DateTimeKind.Local).AddTicks(9750), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 619, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 0, 0, 0, 0)), 20L, 0, 0, false, @"In consectetur sint tenetur accusantium cumque.
                Sit possimus consectetur quae ea.
                Sit soluta ipsum.", "R$57.87", new DateTime(2020, 6, 4, 4, 42, 20, 920, DateTimeKind.Local).AddTicks(7368), "R$23.79", true, 0.8227091333003290m, 0L, "Tasty Cotton Bacon", true, 12, 20, "thrujbdpa6hs3j8r", "ea-maiores-voluptas", "Good", true, null, "Baby", 23.25793217088000m, 1.621998046348800m, 0.47000640419777778, 1, 6, new DateTime(2019, 9, 8, 15, 9, 51, 849, DateTimeKind.Local).AddTicks(6146), 20L },
                    { 19L, false, 0, 0, false, 19L, 19L, new DateTime(2018, 11, 16, 4, 2, 41, 733, DateTimeKind.Local).AddTicks(1462), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 619, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)), 19L, 0, 0, false, @"Possimus nulla quia illo officiis.
                Excepturi nihil aut autem et.", "R$194.20", new DateTime(2019, 10, 14, 9, 3, 49, 919, DateTimeKind.Local).AddTicks(9), "R$16.34", true, 0.3338875944418310m, 0L, "Incredible Wooden Keyboard", true, 44, 19, "azs0tsun3udet89a", "veritatis-voluptates-dolores", "Good", true, null, "Baby", 46.9098170972009000m, 4.5746763444387700m, 0.6447473474055283, 1, 5, new DateTime(2019, 9, 9, 2, 35, 30, 882, DateTimeKind.Local).AddTicks(856), 19L },
                    { 18L, false, 0, 0, false, 18L, 18L, new DateTime(2019, 6, 1, 8, 51, 53, 747, DateTimeKind.Local).AddTicks(8637), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 619, DateTimeKind.Unspecified).AddTicks(1244), new TimeSpan(0, 0, 0, 0, 0)), 18L, 0, 0, false, "adipisci", "R$96.93", new DateTime(2020, 5, 26, 9, 21, 13, 809, DateTimeKind.Local).AddTicks(8554), "R$20.00", true, 0.5656399478044550m, 0L, "Fantastic Rubber Towels", true, 30, 18, "iunz7inn4pr1gqg5", "enim-non-ipsum", "Good", true, null, "Home", 92.9980464247046000m, 4.4747426288550400m, 0.16194738036112272, 3, 8, new DateTime(2019, 9, 9, 1, 3, 10, 236, DateTimeKind.Local).AddTicks(6807), 18L },
                    { 17L, false, 0, 0, false, 17L, 17L, new DateTime(2018, 11, 16, 15, 24, 22, 511, DateTimeKind.Local).AddTicks(362), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 619, DateTimeKind.Unspecified).AddTicks(904), new TimeSpan(0, 0, 0, 0, 0)), 17L, 0, 0, false, "cupiditate", "R$176.29", new DateTime(2019, 9, 16, 7, 44, 0, 497, DateTimeKind.Local).AddTicks(8639), "R$56.80", true, 0.1110484740282630m, 0L, "Incredible Metal Chair", true, 98, 17, "4gkyxrlgq7xviq7l", "tempore-molestiae-at", "Good", true, null, "Automotive", 35.7891173268618000m, 1.3479102735165100m, 0.79704528199371194, 7, 4, new DateTime(2019, 9, 9, 10, 33, 16, 519, DateTimeKind.Local).AddTicks(4761), 17L },
                    { 16L, false, 0, 0, false, 16L, 16L, new DateTime(2019, 4, 18, 8, 11, 11, 660, DateTimeKind.Local).AddTicks(7767), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 619, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, 0, 0, 0, 0)), 16L, 0, 0, false, "Nostrum eum eius.", "R$76.02", new DateTime(2020, 8, 27, 11, 25, 57, 747, DateTimeKind.Local).AddTicks(8315), "R$13.15", true, 0.170460579530550m, 0L, "Incredible Plastic Pizza", true, 34, 16, "ed61e61ucch6tuhs", "perferendis-nulla-quam", "Good", true, null, "Health", 17.119715650156000m, 6.785222825959900m, 0.58983929855275863, 4, 4, new DateTime(2019, 9, 9, 1, 55, 50, 674, DateTimeKind.Local).AddTicks(7501), 16L },
                    { 15L, false, 0, 0, false, 15L, 15L, new DateTime(2019, 2, 1, 15, 20, 37, 289, DateTimeKind.Local).AddTicks(1282), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(9883), new TimeSpan(0, 0, 0, 0, 0)), 15L, 0, 0, false, @"Eius reprehenderit deleniti quidem.
                Saepe nulla et sit quaerat et non sint amet sed.
                Ut rerum et non.
                Quia unde quia veniam laudantium quisquam aperiam aut nihil blanditiis.
                Commodi et impedit vero dolores quibusdam.", "R$29.06", new DateTime(2019, 10, 2, 13, 53, 59, 951, DateTimeKind.Local).AddTicks(8797), "R$6.03", true, 0.7340838358430580m, 0L, "Fantastic Rubber Fish", true, 26, 15, "93e190zmx8zfz1k9", "aliquam-sint-labore", "Good", true, null, "Home", 6.35664430742927000m, 5.3380198149653200m, 0.5862680126848947, 3, 8, new DateTime(2019, 9, 9, 7, 21, 52, 428, DateTimeKind.Local).AddTicks(4927), 15L },
                    { 14L, false, 0, 0, false, 14L, 14L, new DateTime(2019, 2, 26, 23, 18, 56, 779, DateTimeKind.Local).AddTicks(7627), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(9540), new TimeSpan(0, 0, 0, 0, 0)), 14L, 0, 0, false, "ducimus", "R$81.66", new DateTime(2019, 10, 2, 10, 18, 39, 890, DateTimeKind.Local).AddTicks(5707), "R$16.11", true, 0.6367256704888890m, 0L, "Handcrafted Fresh Tuna", true, 4, 14, "n6iah1rgtniqqg2e", "quia-et-blanditiis", "Good", true, null, "Sports", 52.9438836746588000m, 2.3633508348666800m, 0.52549653338524349, 2, 5, new DateTime(2019, 9, 8, 18, 28, 57, 905, DateTimeKind.Local).AddTicks(2603), 14L },
                    { 13L, false, 0, 0, false, 13L, 13L, new DateTime(2018, 12, 19, 2, 17, 13, 738, DateTimeKind.Local).AddTicks(4086), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(9120), new TimeSpan(0, 0, 0, 0, 0)), 13L, 0, 0, false, "Et odit consequuntur sit sed et.", "R$27.85", new DateTime(2020, 4, 8, 8, 37, 2, 596, DateTimeKind.Local).AddTicks(9909), "R$61.35", true, 0.8008415563035950m, 0L, "Small Plastic Pants", true, 70, 13, "nprrsptkky771j61", "magnam-dolorum-iste", "Good", true, null, "Beauty", 97.2983707195606000m, 1.5189050377900300m, 0.027542139416347321, 3, 7, new DateTime(2019, 9, 9, 11, 41, 0, 915, DateTimeKind.Local).AddTicks(5825), 13L },
                    { 11L, false, 0, 0, false, 11L, 11L, new DateTime(2018, 10, 1, 15, 24, 18, 12, DateTimeKind.Local).AddTicks(5768), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(7969), new TimeSpan(0, 0, 0, 0, 0)), 11L, 0, 0, false, "Totam quis eius. Et in accusantium non quis non fuga ea. Recusandae rem minus sit sit eum qui fugit consequatur autem.", "R$130.36", new DateTime(2020, 2, 17, 22, 13, 56, 991, DateTimeKind.Local).AddTicks(8864), "R$3.93", true, 0.0268870410634610m, 0L, "Refined Plastic Mouse", true, 14, 11, "yhqc9kle5sn3tsft", "perspiciatis-id-aut", "Good", true, null, "Kids", 39.158990112673000m, 0.099832620518204100m, 0.26445568411818504, 0, 8, new DateTime(2019, 9, 9, 4, 51, 45, 218, DateTimeKind.Local).AddTicks(3737), 11L }
                });

            migrationBuilder.InsertData(
                table: "StormyVendor",
                columns: new[] { "Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite" },
                values: new object[,]
                {
                    { 9L, 0, null, "Martins - Pereira", "Winston_Macedo21", "Winston.Macedo@yahoo.com", false, new DateTimeOffset(new DateTime(2019, 9, 1, 20, 56, 21, 869, DateTimeKind.Unspecified).AddTicks(3052), new TimeSpan(0, 0, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1582359997", "saepe", "(27) 99525-0648", "0", "Automotive", "guilherme.net" },
                    { 8L, 0, null, "Xavier, Carvalho and Reis", "Diane69", "Diane.Albuquerque@yahoo.com", false, new DateTimeOffset(new DateTime(2019, 8, 18, 15, 50, 10, 16, DateTimeKind.Unspecified).AddTicks(1795), new TimeSpan(0, 0, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1431259465", "Aut modi et.", "+55 (52) 1862-6880", "0", "Grocery & Movies", "núbia.biz" },
                    { 7L, 0, null, "Santos S.A.", "Tyler1", "Tyler_Xavier61@live.com", false, new DateTimeOffset(new DateTime(2019, 8, 23, 4, 50, 36, 873, DateTimeKind.Unspecified).AddTicks(2012), new TimeSpan(0, 0, 0, 0, 0)), "https://loremflickr.com/320/240?lock=725377757", "Reprehenderit saepe harum et aut. Aliquam culpa eos vitae cupiditate. Aut explicabo omnis. Ratione perspiciatis quasi qui consectetur consectetur consequuntur. Qui quidem harum recusandae ut est in. Non culpa nulla accusamus.", "(94) 0352-4923", "0", "Clothing", "césar.net" },
                    { 6L, 0, null, "Moraes, Carvalho and Oliveira", "Jacqueline.Reis", "Jacqueline_Reis@bol.com.br", false, new DateTimeOffset(new DateTime(2019, 8, 24, 2, 13, 26, 744, DateTimeKind.Unspecified).AddTicks(1812), new TimeSpan(0, 0, 0, 0, 0)), "https://loremflickr.com/320/240?lock=865558548", @"Et praesentium voluptatem voluptas voluptas aliquid provident rerum deserunt.
                Delectus commodi non nihil quaerat temporibus.
                Omnis voluptate minima distinctio saepe veritatis dicta iste facere.
                Qui veritatis voluptatibus voluptatem magni deserunt repudiandae similique.", "(93) 35934-5115", "0", "Tools & Industrial", "eduarda.info" },
                    { 1L, 0, null, "Franco, Moraes and Macedo", "Carlton82", "Carlton88@hotmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 13, 6, 23, 47, 463, DateTimeKind.Unspecified).AddTicks(5408), new TimeSpan(0, 0, 0, 0, 0)), "https://loremflickr.com/320/240?lock=101515574", "quia", "(11) 17780-3370", "0", "Jewelery", "dalila.info" },
                    { 4L, 0, null, "Santos LTDA", "Brad_Martins", "Brad_Martins20@yahoo.com", false, new DateTimeOffset(new DateTime(2019, 8, 30, 13, 54, 5, 250, DateTimeKind.Unspecified).AddTicks(1662), new TimeSpan(0, 0, 0, 0, 0)), "https://loremflickr.com/320/240?lock=340707234", "Magni dolor non.", "(75) 82356-4182", "0", "Automotive", "joão.name" },
                    { 3L, 0, null, "Melo, Reis and Carvalho", "Marta_Franco", "Marta.Franco69@live.com", false, new DateTimeOffset(new DateTime(2019, 8, 22, 10, 39, 12, 242, DateTimeKind.Unspecified).AddTicks(6205), new TimeSpan(0, 0, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1804800036", "Veritatis quis sequi voluptatem veniam maiores. Similique ut consequatur non fuga molestiae eum. Earum fugit corrupti et iusto. Rerum itaque ut. Consequatur est nihil tenetur et ut repudiandae iusto ipsa.", "(42) 1414-2559", "0", "Grocery & Industrial", "víctor.com" },
                    { 2L, 0, null, "Oliveira - Batista", "Gail_Silva", "Gail_Silva82@bol.com.br", false, new DateTimeOffset(new DateTime(2019, 8, 24, 1, 38, 9, 535, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 0, 0, 0, 0)), "https://loremflickr.com/320/240?lock=2001850641", "Provident facilis reiciendis id.", "(09) 0088-4976", "0", "Automotive & Shoes", "fabrícia.com" },
                    { 5L, 0, null, "Macedo, Moreira and Nogueira", "David51", "David.Melo@gmail.com", false, new DateTimeOffset(new DateTime(2019, 9, 4, 4, 49, 45, 252, DateTimeKind.Unspecified).AddTicks(3166), new TimeSpan(0, 0, 0, 0, 0)), "https://loremflickr.com/320/240?lock=343702332", "molestiae", "+55 (89) 4705-2138", "0", "Automotive", "márcia.net" },
                    { 10L, 0, null, "Macedo - Carvalho", "Angel_Franco58", "Angel77@live.com", false, new DateTimeOffset(new DateTime(2019, 8, 17, 16, 4, 4, 821, DateTimeKind.Unspecified).AddTicks(7252), new TimeSpan(0, 0, 0, 0, 0)), "https://loremflickr.com/320/240?lock=44839909", "Reiciendis cupiditate consequuntur vel iusto id modi incidunt. Quos occaecati aut illo necessitatibus voluptatem optio. Aspernatur qui illo ducimus occaecati. Et perferendis dolore ullam. Laboriosam quam autem provident. Libero ut temporibus ea.", "(75) 3269-4613", "0", "Jewelery", "kléber.org" }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName" },
                values: new object[,]
                {
                    { 11L, null, "http://lorempixel.com/640/480/fashion", 2014682459, false, new DateTimeOffset(new DateTime(2019, 9, 1, 4, 38, 15, 697, DateTimeKind.Unspecified).AddTicks(5533), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 19L, null, "http://lorempixel.com/640/480/fashion", -1721592484, false, new DateTimeOffset(new DateTime(2019, 8, 28, 13, 5, 38, 590, DateTimeKind.Unspecified).AddTicks(3782), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 18L, null, "http://lorempixel.com/640/480/fashion", -499278568, false, new DateTimeOffset(new DateTime(2019, 8, 30, 14, 34, 3, 217, DateTimeKind.Unspecified).AddTicks(46), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 17L, null, "http://lorempixel.com/640/480/fashion", -1959132500, false, new DateTimeOffset(new DateTime(2019, 8, 31, 1, 12, 40, 289, DateTimeKind.Unspecified).AddTicks(3287), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 16L, null, "http://lorempixel.com/640/480/fashion", 1639770015, false, new DateTimeOffset(new DateTime(2019, 9, 5, 0, 53, 18, 410, DateTimeKind.Unspecified).AddTicks(8939), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 20L, null, "http://lorempixel.com/640/480/fashion", 1876426592, false, new DateTimeOffset(new DateTime(2019, 8, 27, 0, 26, 10, 975, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 14L, null, "http://lorempixel.com/640/480/fashion", 275599984, false, new DateTimeOffset(new DateTime(2019, 9, 4, 4, 32, 27, 854, DateTimeKind.Unspecified).AddTicks(9563), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 13L, null, "http://lorempixel.com/640/480/fashion", -982567320, false, new DateTimeOffset(new DateTime(2019, 9, 6, 16, 12, 22, 423, DateTimeKind.Unspecified).AddTicks(865), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 12L, null, "http://lorempixel.com/640/480/fashion", -484212623, false, new DateTimeOffset(new DateTime(2019, 9, 3, 13, 18, 39, 756, DateTimeKind.Unspecified).AddTicks(5763), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 15L, null, "http://lorempixel.com/640/480/fashion", 1719033700, false, new DateTimeOffset(new DateTime(2019, 8, 27, 11, 20, 51, 623, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, 0, 0, 0, 0)), 1, null }
                });

            migrationBuilder.InsertData(
                table: "StormyProduct",
                columns: new[] { "Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "ThumbnailImage", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId" },
                values: new object[,]
                {
                    { 9L, false, 0, 0, false, 9L, 9L, new DateTime(2018, 9, 17, 1, 42, 51, 14, DateTimeKind.Local).AddTicks(3769), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(6963), new TimeSpan(0, 0, 0, 0, 0)), 9L, 0, 0, false, @"Occaecati ut expedita qui facilis aut itaque.
                Sunt et ut odio est.
                Ea dolorum quasi a dicta.
                Et non cupiditate porro et.
                Eum molestiae deserunt ab eos reprehenderit impedit eius.", "R$71.53", new DateTime(2020, 3, 4, 11, 50, 52, 528, DateTimeKind.Local).AddTicks(6093), "R$16.40", true, 0.3406264289937110m, 0L, "Refined Plastic Tuna", true, 90, 9, "6xm7r4ftomzfcl1q", "rerum-animi-magni", "Good", true, null, "Clothing", 0.13040392665677000m, 3.4123816263919600m, 0.042251400669222422, 1, 6, new DateTime(2019, 9, 8, 13, 52, 24, 728, DateTimeKind.Local).AddTicks(5753), 9L },
                    { 1L, false, 0, 0, false, 1L, 1L, new DateTime(2019, 8, 26, 8, 41, 11, 498, DateTimeKind.Local).AddTicks(367), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 599, DateTimeKind.Unspecified).AddTicks(5953), new TimeSpan(0, 0, 0, 0, 0)), 1L, 0, 0, false, @"Labore ratione totam.
                Voluptatibus velit quaerat aut.
                Expedita vero incidunt corporis ut aut voluptate et sed.
                Magnam dolorum et.", "R$65.18", new DateTime(2020, 3, 4, 9, 6, 58, 141, DateTimeKind.Local).AddTicks(9848), "R$87.63", true, 0.7994309672151840m, 0L, "Tasty Metal Computer", true, 78, 1, "tgnywm16cb49w0qm", "sit-eligendi-odit", "Good", true, null, "Garden", 61.2244497804085000m, 7.0566492839980200m, 0.88669603126435359, 4, 7, new DateTime(2019, 9, 8, 10, 18, 43, 826, DateTimeKind.Local).AddTicks(496), 1L },
                    { 2L, false, 0, 0, false, 2L, 2L, new DateTime(2019, 1, 20, 5, 52, 50, 528, DateTimeKind.Local).AddTicks(8941), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(2308), new TimeSpan(0, 0, 0, 0, 0)), 2L, 0, 0, false, "id", "R$146.96", new DateTime(2020, 4, 14, 21, 54, 39, 572, DateTimeKind.Local).AddTicks(8250), "R$32.38", true, 0.3763653325738220m, 0L, "Unbranded Granite Soap", true, 100, 2, "a3ztn1bd7wgh2hsi", "deleniti-occaecati-mollitia", "Good", true, null, "Health", 14.7327064605116000m, 2.7043094638289500m, 0.43973919164377229, 10, 6, new DateTime(2019, 9, 9, 5, 25, 54, 30, DateTimeKind.Local).AddTicks(8396), 2L },
                    { 3L, false, 0, 0, false, 3L, 3L, new DateTime(2019, 5, 3, 15, 47, 8, 190, DateTimeKind.Local).AddTicks(2905), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(3864), new TimeSpan(0, 0, 0, 0, 0)), 3L, 0, 0, false, "Enim sint optio odio voluptatem rerum pariatur ipsam quisquam iure.", "R$140.81", new DateTime(2019, 10, 31, 9, 24, 8, 833, DateTimeKind.Local).AddTicks(8137), "R$69.33", true, 0.1468776581561550m, 0L, "Gorgeous Steel Cheese", true, 58, 3, "wecfupkyilyb09v3", "quo-distinctio-eius", "Good", true, null, "Music", 10.9147093775285000m, 7.2023298531781600m, 0.44666411049974342, 5, 9, new DateTime(2019, 9, 9, 0, 25, 26, 48, DateTimeKind.Local).AddTicks(5472), 3L },
                    { 4L, false, 0, 0, false, 4L, 4L, new DateTime(2019, 7, 18, 2, 48, 50, 839, DateTimeKind.Local).AddTicks(6187), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(4401), new TimeSpan(0, 0, 0, 0, 0)), 4L, 0, 0, false, "Beatae sit enim doloribus rerum et ut officia.", "R$18.49", new DateTime(2020, 5, 29, 9, 33, 31, 283, DateTimeKind.Local).AddTicks(3919), "R$69.29", true, 0.8629512902642370m, 0L, "Handmade Cotton Sausages", true, 50, 4, "1z3rxspq93y4potb", "dolorem-voluptas-blanditiis", "Good", true, null, "Outdoors", 97.8263495014172000m, 7.142680681842700m, 0.43717079723122099, 3, 2, new DateTime(2019, 9, 8, 20, 39, 29, 701, DateTimeKind.Local).AddTicks(4226), 4L },
                    { 5L, false, 0, 0, false, 5L, 5L, new DateTime(2019, 2, 15, 19, 0, 3, 991, DateTimeKind.Local).AddTicks(5613), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(4832), new TimeSpan(0, 0, 0, 0, 0)), 5L, 0, 0, false, "velit", "R$173.68", new DateTime(2019, 9, 20, 10, 28, 17, 975, DateTimeKind.Local).AddTicks(5619), "R$26.64", true, 0.8861345936945340m, 0L, "Awesome Cotton Tuna", true, 72, 5, "l2ja9jlj94blkdz6", "facere-cumque-qui", "Good", true, null, "Shoes", 75.9517959207072000m, 1.3506824436367900m, 0.5915006481071472, 7, 7, new DateTime(2019, 9, 9, 3, 54, 11, 946, DateTimeKind.Local).AddTicks(7235), 5L },
                    { 6L, false, 0, 0, false, 6L, 6L, new DateTime(2019, 1, 15, 2, 10, 11, 252, DateTimeKind.Local).AddTicks(1432), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(5214), new TimeSpan(0, 0, 0, 0, 0)), 6L, 0, 0, false, "Distinctio quisquam est eligendi ea. Doloribus voluptatem omnis quis veniam sapiente voluptatem repellendus. Labore odio quia aliquid in ut quia quos laboriosam. Cupiditate modi et qui non placeat ipsam aspernatur. Animi dolorem sit id ad.", "R$68.03", new DateTime(2020, 5, 14, 19, 49, 9, 309, DateTimeKind.Local).AddTicks(2318), "R$48.25", true, 0.07070434655561310m, 0L, "Small Cotton Pants", true, 84, 6, "pagdhbrl9j0fo7bc", "voluptate-ut-tempore", "Good", true, null, "Jewelery", 84.9459445499563000m, 4.877332511766500m, 0.87161928316188009, 4, 7, new DateTime(2019, 9, 9, 10, 20, 30, 826, DateTimeKind.Local).AddTicks(4493), 6L },
                    { 7L, false, 0, 0, false, 7L, 7L, new DateTime(2019, 3, 1, 20, 12, 51, 298, DateTimeKind.Local).AddTicks(67), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(5888), new TimeSpan(0, 0, 0, 0, 0)), 7L, 0, 0, false, "Dignissimos tenetur et tempora libero quo aliquid. Deserunt reiciendis cum. Delectus est reprehenderit illum quo esse. Fugiat excepturi rerum est corporis officia assumenda consectetur cum veritatis. In veniam aperiam maiores fugit est voluptates enim ullam voluptatem. Quia dignissimos molestiae accusantium provident et.", "R$177.20", new DateTime(2019, 9, 12, 10, 43, 10, 938, DateTimeKind.Local).AddTicks(2280), "R$30.11", true, 0.6570739693274140m, 0L, "Handcrafted Frozen Tuna", true, 88, 7, "0in9yj8c2vikotjy", "eos-nulla-amet", "Good", true, null, "Books", 27.7190129867378000m, 0.67625676313240900m, 0.47490057697282201, 2, 9, new DateTime(2019, 9, 8, 14, 48, 23, 554, DateTimeKind.Local).AddTicks(9756), 7L },
                    { 8L, false, 0, 0, false, 8L, 8L, new DateTime(2019, 1, 7, 6, 6, 2, 157, DateTimeKind.Local).AddTicks(6389), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(6599), new TimeSpan(0, 0, 0, 0, 0)), 8L, 0, 0, false, "reiciendis", "R$100.59", new DateTime(2019, 10, 23, 15, 14, 9, 673, DateTimeKind.Local).AddTicks(572), "R$62.03", true, 0.2957889713793010m, 0L, "Sleek Concrete Soap", true, 90, 8, "nwno0lkedznowe4y", "laboriosam-reprehenderit-et", "Good", true, null, "Jewelery", 40.3411970196018000m, 7.9057711027123800m, 0.47062867482687748, 9, 5, new DateTime(2019, 9, 9, 8, 55, 45, 140, DateTimeKind.Local).AddTicks(2784), 8L },
                    { 10L, false, 0, 0, false, 10L, 10L, new DateTime(2019, 1, 26, 17, 33, 32, 720, DateTimeKind.Local).AddTicks(2535), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 9, 9, 3, 16, 6, 618, DateTimeKind.Unspecified).AddTicks(7581), new TimeSpan(0, 0, 0, 0, 0)), 10L, 0, 0, false, "voluptatem", "R$54.96", new DateTime(2020, 3, 22, 9, 56, 35, 623, DateTimeKind.Local).AddTicks(1697), "R$38.78", true, 0.1456231773577740m, 0L, "Incredible Frozen Cheese", true, 96, 10, "97znf3nncylqxtw1", "perferendis-libero-cupiditate", "Good", true, null, "Beauty", 46.7287603052001000m, 7.325215301162200m, 0.19026455012628088, 0, 2, new DateTime(2019, 9, 9, 2, 18, 28, 301, DateTimeKind.Local).AddTicks(610), 10L }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName" },
                values: new object[,]
                {
                    { 1L, null, "http://lorempixel.com/640/480/fashion", 2081655719, false, new DateTimeOffset(new DateTime(2019, 9, 3, 13, 2, 3, 948, DateTimeKind.Unspecified).AddTicks(309), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 2L, null, "http://lorempixel.com/640/480/fashion", -895221300, false, new DateTimeOffset(new DateTime(2019, 9, 3, 18, 27, 13, 477, DateTimeKind.Unspecified).AddTicks(4639), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 3L, null, "http://lorempixel.com/640/480/fashion", -1976330345, false, new DateTimeOffset(new DateTime(2019, 9, 5, 15, 18, 24, 794, DateTimeKind.Unspecified).AddTicks(6096), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 4L, null, "http://lorempixel.com/640/480/fashion", -872456354, false, new DateTimeOffset(new DateTime(2019, 9, 1, 19, 6, 28, 451, DateTimeKind.Unspecified).AddTicks(8031), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 5L, null, "http://lorempixel.com/640/480/fashion", 286799546, false, new DateTimeOffset(new DateTime(2019, 9, 2, 19, 23, 1, 793, DateTimeKind.Unspecified).AddTicks(5540), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 6L, null, "http://lorempixel.com/640/480/fashion", 1371729843, false, new DateTimeOffset(new DateTime(2019, 9, 2, 1, 37, 27, 140, DateTimeKind.Unspecified).AddTicks(8371), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 7L, null, "http://lorempixel.com/640/480/fashion", 553967003, false, new DateTimeOffset(new DateTime(2019, 9, 5, 15, 5, 11, 388, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 8L, null, "http://lorempixel.com/640/480/fashion", -1771742410, false, new DateTimeOffset(new DateTime(2019, 9, 1, 18, 37, 27, 298, DateTimeKind.Unspecified).AddTicks(3613), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 9L, null, "http://lorempixel.com/640/480/fashion", -1674924810, false, new DateTimeOffset(new DateTime(2019, 9, 3, 12, 41, 2, 537, DateTimeKind.Unspecified).AddTicks(9048), new TimeSpan(0, 0, 0, 0, 0)), 1, null },
                    { 10L, null, "http://lorempixel.com/640/480/fashion", -551349145, false, new DateTimeOffset(new DateTime(2019, 9, 3, 2, 35, 56, 283, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, 0, 0, 0, 0)), 1, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10L);

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
                table: "Entity",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Entity",
                keyColumn: "Id",
                keyValue: 20L);

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

            migrationBuilder.InsertData(
                table: "ProductLink",
                columns: new[] { "Id", "IsDeleted", "LastModified", "LinkType", "LinkedProductId", "ProductId" },
                values: new object[,]
                {
                    { 1L, false, new DateTimeOffset(new DateTime(2019, 9, 2, 0, 59, 50, 286, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, 0, 0, 0, 0)), 2, 14L, 46L },
                    { 28L, false, new DateTimeOffset(new DateTime(2019, 8, 16, 23, 30, 32, 602, DateTimeKind.Unspecified).AddTicks(5657), new TimeSpan(0, 0, 0, 0, 0)), 2, 42L, 13L },
                    { 29L, false, new DateTimeOffset(new DateTime(2019, 9, 8, 6, 5, 27, 613, DateTimeKind.Unspecified).AddTicks(5065), new TimeSpan(0, 0, 0, 0, 0)), 2, 16L, 50L },
                    { 30L, false, new DateTimeOffset(new DateTime(2019, 8, 30, 23, 50, 55, 499, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 0, 0, 0, 0)), 2, 6L, 24L },
                    { 31L, false, new DateTimeOffset(new DateTime(2019, 9, 2, 10, 8, 16, 511, DateTimeKind.Unspecified).AddTicks(8473), new TimeSpan(0, 0, 0, 0, 0)), 2, 13L, 18L },
                    { 32L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 11, 10, 20, 497, DateTimeKind.Unspecified).AddTicks(3268), new TimeSpan(0, 0, 0, 0, 0)), 2, 41L, 49L },
                    { 33L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 23, 17, 35, 599, DateTimeKind.Unspecified).AddTicks(2357), new TimeSpan(0, 0, 0, 0, 0)), 2, 9L, 4L },
                    { 34L, false, new DateTimeOffset(new DateTime(2019, 9, 1, 9, 34, 32, 922, DateTimeKind.Unspecified).AddTicks(8342), new TimeSpan(0, 0, 0, 0, 0)), 2, 4L, 20L },
                    { 35L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 9, 22, 40, 249, DateTimeKind.Unspecified).AddTicks(7369), new TimeSpan(0, 0, 0, 0, 0)), 2, 33L, 33L },
                    { 36L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 22, 3, 49, 845, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 0, 0, 0, 0)), 2, 21L, 13L },
                    { 37L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 8, 1, 59, 741, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 0, 0, 0, 0)), 2, 50L, 47L },
                    { 27L, false, new DateTimeOffset(new DateTime(2019, 8, 23, 21, 53, 57, 34, DateTimeKind.Unspecified).AddTicks(3563), new TimeSpan(0, 0, 0, 0, 0)), 2, 42L, 29L },
                    { 38L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 14, 23, 3, 388, DateTimeKind.Unspecified).AddTicks(4099), new TimeSpan(0, 0, 0, 0, 0)), 2, 48L, 2L },
                    { 40L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 12, 28, 14, 501, DateTimeKind.Unspecified).AddTicks(9822), new TimeSpan(0, 0, 0, 0, 0)), 2, 45L, 33L },
                    { 41L, false, new DateTimeOffset(new DateTime(2019, 8, 31, 7, 57, 43, 732, DateTimeKind.Unspecified).AddTicks(7630), new TimeSpan(0, 0, 0, 0, 0)), 2, 35L, 14L },
                    { 42L, false, new DateTimeOffset(new DateTime(2019, 8, 19, 13, 10, 9, 482, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 0, 0, 0, 0)), 2, 44L, 18L },
                    { 43L, false, new DateTimeOffset(new DateTime(2019, 9, 3, 16, 17, 43, 569, DateTimeKind.Unspecified).AddTicks(4204), new TimeSpan(0, 0, 0, 0, 0)), 2, 49L, 37L },
                    { 44L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 12, 51, 54, 315, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 0, 0, 0, 0)), 2, 18L, 48L },
                    { 45L, false, new DateTimeOffset(new DateTime(2019, 9, 6, 1, 38, 28, 328, DateTimeKind.Unspecified).AddTicks(8561), new TimeSpan(0, 0, 0, 0, 0)), 2, 17L, 39L },
                    { 46L, false, new DateTimeOffset(new DateTime(2019, 9, 4, 15, 54, 19, 432, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 0, 0, 0, 0)), 2, 7L, 9L },
                    { 47L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 2, 38, 10, 312, DateTimeKind.Unspecified).AddTicks(6151), new TimeSpan(0, 0, 0, 0, 0)), 2, 14L, 45L },
                    { 48L, false, new DateTimeOffset(new DateTime(2019, 8, 21, 20, 50, 56, 949, DateTimeKind.Unspecified).AddTicks(867), new TimeSpan(0, 0, 0, 0, 0)), 2, 29L, 7L },
                    { 49L, false, new DateTimeOffset(new DateTime(2019, 8, 26, 22, 10, 4, 686, DateTimeKind.Unspecified).AddTicks(9700), new TimeSpan(0, 0, 0, 0, 0)), 2, 19L, 16L },
                    { 39L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 18, 25, 37, 389, DateTimeKind.Unspecified).AddTicks(1007), new TimeSpan(0, 0, 0, 0, 0)), 2, 17L, 22L },
                    { 50L, false, new DateTimeOffset(new DateTime(2019, 9, 1, 7, 44, 26, 61, DateTimeKind.Unspecified).AddTicks(7273), new TimeSpan(0, 0, 0, 0, 0)), 2, 11L, 24L },
                    { 26L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 1, 25, 38, 946, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), 2, 7L, 10L },
                    { 24L, false, new DateTimeOffset(new DateTime(2019, 9, 5, 19, 33, 47, 700, DateTimeKind.Unspecified).AddTicks(975), new TimeSpan(0, 0, 0, 0, 0)), 2, 31L, 29L },
                    { 2L, false, new DateTimeOffset(new DateTime(2019, 8, 19, 8, 17, 21, 910, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 0, 0, 0, 0)), 2, 24L, 14L },
                    { 3L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 19, 39, 7, 616, DateTimeKind.Unspecified).AddTicks(5261), new TimeSpan(0, 0, 0, 0, 0)), 2, 19L, 14L },
                    { 4L, false, new DateTimeOffset(new DateTime(2019, 8, 29, 11, 19, 37, 189, DateTimeKind.Unspecified).AddTicks(964), new TimeSpan(0, 0, 0, 0, 0)), 2, 7L, 48L },
                    { 5L, false, new DateTimeOffset(new DateTime(2019, 8, 30, 3, 19, 58, 622, DateTimeKind.Unspecified).AddTicks(7133), new TimeSpan(0, 0, 0, 0, 0)), 2, 42L, 25L },
                    { 6L, false, new DateTimeOffset(new DateTime(2019, 8, 28, 4, 12, 18, 171, DateTimeKind.Unspecified).AddTicks(9338), new TimeSpan(0, 0, 0, 0, 0)), 2, 39L, 35L },
                    { 7L, false, new DateTimeOffset(new DateTime(2019, 8, 24, 22, 14, 28, 525, DateTimeKind.Unspecified).AddTicks(3947), new TimeSpan(0, 0, 0, 0, 0)), 2, 50L, 17L },
                    { 8L, false, new DateTimeOffset(new DateTime(2019, 9, 3, 15, 12, 31, 442, DateTimeKind.Unspecified).AddTicks(281), new TimeSpan(0, 0, 0, 0, 0)), 2, 10L, 15L },
                    { 9L, false, new DateTimeOffset(new DateTime(2019, 8, 16, 1, 21, 49, 26, DateTimeKind.Unspecified).AddTicks(6192), new TimeSpan(0, 0, 0, 0, 0)), 2, 17L, 1L },
                    { 10L, false, new DateTimeOffset(new DateTime(2019, 8, 24, 7, 52, 15, 57, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), 2, 27L, 19L },
                    { 11L, false, new DateTimeOffset(new DateTime(2019, 8, 28, 2, 6, 34, 844, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)), 2, 40L, 46L },
                    { 25L, false, new DateTimeOffset(new DateTime(2019, 8, 21, 1, 13, 5, 120, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 0, 0, 0, 0)), 2, 27L, 38L },
                    { 12L, false, new DateTimeOffset(new DateTime(2019, 9, 8, 16, 16, 28, 678, DateTimeKind.Unspecified).AddTicks(9265), new TimeSpan(0, 0, 0, 0, 0)), 2, 27L, 18L },
                    { 14L, false, new DateTimeOffset(new DateTime(2019, 9, 7, 6, 21, 28, 851, DateTimeKind.Unspecified).AddTicks(3121), new TimeSpan(0, 0, 0, 0, 0)), 2, 12L, 21L },
                    { 15L, false, new DateTimeOffset(new DateTime(2019, 9, 6, 17, 50, 19, 183, DateTimeKind.Unspecified).AddTicks(2627), new TimeSpan(0, 0, 0, 0, 0)), 2, 1L, 33L },
                    { 16L, false, new DateTimeOffset(new DateTime(2019, 9, 5, 23, 54, 54, 84, DateTimeKind.Unspecified).AddTicks(6220), new TimeSpan(0, 0, 0, 0, 0)), 2, 39L, 4L },
                    { 17L, false, new DateTimeOffset(new DateTime(2019, 8, 20, 7, 38, 58, 87, DateTimeKind.Unspecified).AddTicks(6651), new TimeSpan(0, 0, 0, 0, 0)), 2, 14L, 17L },
                    { 18L, false, new DateTimeOffset(new DateTime(2019, 9, 4, 14, 46, 2, 242, DateTimeKind.Unspecified).AddTicks(3976), new TimeSpan(0, 0, 0, 0, 0)), 2, 40L, 28L },
                    { 19L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 13, 8, 55, 170, DateTimeKind.Unspecified).AddTicks(6456), new TimeSpan(0, 0, 0, 0, 0)), 2, 4L, 5L },
                    { 20L, false, new DateTimeOffset(new DateTime(2019, 8, 25, 0, 7, 31, 127, DateTimeKind.Unspecified).AddTicks(9667), new TimeSpan(0, 0, 0, 0, 0)), 2, 44L, 8L },
                    { 21L, false, new DateTimeOffset(new DateTime(2019, 9, 2, 11, 35, 26, 560, DateTimeKind.Unspecified).AddTicks(8789), new TimeSpan(0, 0, 0, 0, 0)), 2, 14L, 43L },
                    { 22L, false, new DateTimeOffset(new DateTime(2019, 8, 17, 4, 43, 52, 204, DateTimeKind.Unspecified).AddTicks(8530), new TimeSpan(0, 0, 0, 0, 0)), 2, 48L, 18L },
                    { 23L, false, new DateTimeOffset(new DateTime(2019, 9, 7, 20, 44, 52, 526, DateTimeKind.Unspecified).AddTicks(3294), new TimeSpan(0, 0, 0, 0, 0)), 2, 20L, 15L },
                    { 13L, false, new DateTimeOffset(new DateTime(2019, 8, 18, 13, 37, 57, 636, DateTimeKind.Unspecified).AddTicks(6499), new TimeSpan(0, 0, 0, 0, 0)), 2, 11L, 47L }
                });

            migrationBuilder.UpdateData(
                table: "Shipment",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModified", "TrackNumber" },
                values: new object[] { new DateTime(2019, 9, 9, 2, 49, 44, 456, DateTimeKind.Utc).AddTicks(9537), new DateTimeOffset(new DateTime(2019, 9, 9, 2, 49, 44, 456, DateTimeKind.Unspecified).AddTicks(8597), new TimeSpan(0, 0, 0, 0, 0)), "a4b83b71-a4ba-4d0b-81db-d9ad6365810e" });
        }
    }
}
