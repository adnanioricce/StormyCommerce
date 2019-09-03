using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class thumbnailToThumbnailUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_StormyProduct_StormyProductId",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLink_StormyProduct_ProductId",
                table: "ProductLink");

            migrationBuilder.DropForeignKey(
                name: "FK_StormyProduct_Media_MediaId",
                table: "StormyProduct");

            migrationBuilder.DropIndex(
                name: "IX_StormyProduct_CategoryId",
                table: "StormyProduct");

            migrationBuilder.DropIndex(
                name: "IX_StormyProduct_MediaId",
                table: "StormyProduct");

            migrationBuilder.DropIndex(
                name: "IX_Media_StormyProductId",
                table: "Media");

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9L);

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
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 2L);

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
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 1L);

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

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "StormyVendor",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DropColumn(
                name: "StormyProductId",
                table: "Media");

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailImage",
                table: "StormyProduct",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "ProductLink",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Media",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "City", "FirstAddress", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street" },
                values: new object[] { "Vila Alessandro", "Souza Ponte", new DateTimeOffset(new DateTime(2019, 9, 3, 2, 28, 56, 750, DateTimeKind.Unspecified).AddTicks(2398), new TimeSpan(0, 0, 0, 0, 0)), "69225", "+55 (69) 1743-9201", "40157", "Apto. 016", "Acre", "1555 Batista Marginal" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "City", "FirstAddress", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street" },
                values: new object[] { "Carvalhodo Descoberto", "Deneval Viela", new DateTimeOffset(new DateTime(2019, 9, 3, 2, 28, 56, 774, DateTimeKind.Unspecified).AddTicks(3137), new TimeSpan(0, 0, 0, 0, 0)), "239", "(29) 6328-2459", "90633", "Apto. 765", "Rio de Janeiro", "49012 Albuquerque Rodovia" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "City", "FirstAddress", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street" },
                values: new object[] { "Saraivado Sul", "Barros Rodovia", new DateTimeOffset(new DateTime(2019, 9, 3, 2, 28, 56, 774, DateTimeKind.Unspecified).AddTicks(3998), new TimeSpan(0, 0, 0, 0, 0)), "05336", "(35) 65251-6113", "26119-786", "Lote 76", "Alagoas", "729 Ígor Ponte" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "City", "FirstAddress", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street" },
                values: new object[] { "Xavierde Nossa Senhora", "Kléber Viela", new DateTimeOffset(new DateTime(2019, 9, 3, 2, 28, 56, 774, DateTimeKind.Unspecified).AddTicks(4379), new TimeSpan(0, 0, 0, 0, 0)), "865", "(56) 2363-7715", "15703", "Sobrado 49", "Minas Gerais", "2266 Braga Rodovia" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "City", "FirstAddress", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street" },
                values: new object[] { "Nogueirado Descoberto", "Xavier Avenida", new DateTimeOffset(new DateTime(2019, 9, 3, 2, 28, 56, 774, DateTimeKind.Unspecified).AddTicks(4750), new TimeSpan(0, 0, 0, 0, 0)), "401", "(09) 9766-4931", "74909-059", "Casa 9", "Alagoas", "743 Carvalho Rodovia" });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 10, 17, 11, 47, 366, DateTimeKind.Unspecified).AddTicks(7657), new TimeSpan(0, -3, 0, 0, 0)), 21L, 46L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 15, 22, 3, 26, 255, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, -3, 0, 0, 0)), 34L, 42L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 13, 15, 31, 22, 528, DateTimeKind.Unspecified).AddTicks(6544), new TimeSpan(0, -3, 0, 0, 0)), 34L, 14L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 29, 4, 26, 10, 716, DateTimeKind.Unspecified).AddTicks(2758), new TimeSpan(0, -3, 0, 0, 0)), 45L, 1L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 14, 2, 25, 52, 996, DateTimeKind.Unspecified).AddTicks(6243), new TimeSpan(0, -3, 0, 0, 0)), 39L, 27L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 20, 14, 38, 6, 444, DateTimeKind.Unspecified).AddTicks(4501), new TimeSpan(0, -3, 0, 0, 0)), 41L, 29L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 27, 2, 23, 44, 280, DateTimeKind.Unspecified).AddTicks(3304), new TimeSpan(0, -3, 0, 0, 0)), 38L, 22L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 2, 1, 9, 25, 713, DateTimeKind.Unspecified).AddTicks(4067), new TimeSpan(0, -3, 0, 0, 0)), 8L, 34L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 19, 9, 39, 55, 315, DateTimeKind.Unspecified).AddTicks(2619), new TimeSpan(0, -3, 0, 0, 0)), 24L, 34L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 25, 3, 50, 23, 707, DateTimeKind.Unspecified).AddTicks(7431), new TimeSpan(0, -3, 0, 0, 0)), 5L, 6L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 13, 10, 38, 22, 478, DateTimeKind.Unspecified).AddTicks(1820), new TimeSpan(0, -3, 0, 0, 0)), 14L, 22L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 15, 5, 14, 58, 684, DateTimeKind.Unspecified).AddTicks(471), new TimeSpan(0, -3, 0, 0, 0)), 25L, 40L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 26, 7, 57, 58, 323, DateTimeKind.Unspecified).AddTicks(5462), new TimeSpan(0, -3, 0, 0, 0)), 7L, 46L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 8, 38, 21, 956, DateTimeKind.Unspecified).AddTicks(4718), new TimeSpan(0, -3, 0, 0, 0)), 16L, 12L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastModified", "LinkedProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 24, 18, 2, 22, 448, DateTimeKind.Unspecified).AddTicks(6976), new TimeSpan(0, -3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 31, 7, 32, 12, 455, DateTimeKind.Unspecified).AddTicks(4562), new TimeSpan(0, -3, 0, 0, 0)), 6L, 29L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 28, 19, 41, 53, 470, DateTimeKind.Unspecified).AddTicks(9161), new TimeSpan(0, -3, 0, 0, 0)), 26L, 24L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 28, 3, 31, 40, 468, DateTimeKind.Unspecified).AddTicks(3966), new TimeSpan(0, -3, 0, 0, 0)), 33L, 48L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 15, 9, 9, 32, 534, DateTimeKind.Unspecified).AddTicks(5134), new TimeSpan(0, -3, 0, 0, 0)), 45L, 13L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 27, 19, 48, 32, 38, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, -3, 0, 0, 0)), 7L, 11L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 29, 18, 31, 0, 601, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, -3, 0, 0, 0)), 24L, 30L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 29, 19, 33, 3, 363, DateTimeKind.Unspecified).AddTicks(2855), new TimeSpan(0, -3, 0, 0, 0)), 19L, 32L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 19, 11, 30, 31, 87, DateTimeKind.Unspecified).AddTicks(6), new TimeSpan(0, -3, 0, 0, 0)), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 15, 15, 53, 43, 859, DateTimeKind.Unspecified).AddTicks(4540), new TimeSpan(0, -3, 0, 0, 0)), 12L, 34L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 6, 40, 45, 248, DateTimeKind.Unspecified).AddTicks(6581), new TimeSpan(0, -3, 0, 0, 0)), 31L, 23L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 28, 20, 24, 58, 647, DateTimeKind.Unspecified).AddTicks(326), new TimeSpan(0, -3, 0, 0, 0)), 34L, 49L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 10, 20, 40, 30, 384, DateTimeKind.Unspecified).AddTicks(9315), new TimeSpan(0, -3, 0, 0, 0)), 24L, 18L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 31, 10, 23, 53, 50, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, -3, 0, 0, 0)), 8L, 30L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 22, 55, 54, 261, DateTimeKind.Unspecified).AddTicks(4565), new TimeSpan(0, -3, 0, 0, 0)), 30L, 31L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 22, 4, 54, 10, 255, DateTimeKind.Unspecified).AddTicks(7975), new TimeSpan(0, -3, 0, 0, 0)), 1L, 30L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 20, 10, 10, 49, 613, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, -3, 0, 0, 0)), 3L, 50L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 16, 15, 38, 4, 504, DateTimeKind.Unspecified).AddTicks(4047), new TimeSpan(0, -3, 0, 0, 0)), 25L, 43L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 15, 29, 15, 348, DateTimeKind.Unspecified).AddTicks(2754), new TimeSpan(0, -3, 0, 0, 0)), 11L, 41L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 30, 23, 28, 16, 614, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, -3, 0, 0, 0)), 27L, 4L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 26, 18, 54, 57, 465, DateTimeKind.Unspecified).AddTicks(888), new TimeSpan(0, -3, 0, 0, 0)), 24L, 14L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 13, 21, 26, 11, 885, DateTimeKind.Unspecified).AddTicks(2383), new TimeSpan(0, -3, 0, 0, 0)), 29L, 3L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 21, 14, 21, 29, 919, DateTimeKind.Unspecified).AddTicks(2003), new TimeSpan(0, -3, 0, 0, 0)), 27L, 12L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 26, 20, 52, 11, 207, DateTimeKind.Unspecified).AddTicks(8792), new TimeSpan(0, -3, 0, 0, 0)), 17L, 34L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 12, 7, 31, 52, 180, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, -3, 0, 0, 0)), 4L, 16L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastModified", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 2, 23, 7, 29, 41, DateTimeKind.Unspecified).AddTicks(3873), new TimeSpan(0, -3, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 2, 21, 42, 39, 855, DateTimeKind.Unspecified).AddTicks(5540), new TimeSpan(0, -3, 0, 0, 0)), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 16, 19, 45, 46, 854, DateTimeKind.Unspecified).AddTicks(9285), new TimeSpan(0, -3, 0, 0, 0)), 10L, 9L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 7, 33, 29, 105, DateTimeKind.Unspecified).AddTicks(203), new TimeSpan(0, -3, 0, 0, 0)), 49L, 6L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 18, 15, 15, 7, 588, DateTimeKind.Unspecified).AddTicks(9966), new TimeSpan(0, -3, 0, 0, 0)), 28L, 24L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 30, 6, 46, 30, 899, DateTimeKind.Unspecified).AddTicks(1888), new TimeSpan(0, -3, 0, 0, 0)), 41L, 48L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 27, 4, 30, 41, 419, DateTimeKind.Unspecified).AddTicks(7945), new TimeSpan(0, -3, 0, 0, 0)), 41L, 34L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastModified", "LinkedProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 26, 10, 49, 7, 492, DateTimeKind.Unspecified).AddTicks(4651), new TimeSpan(0, -3, 0, 0, 0)), 42L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 19, 17, 7, 39, 454, DateTimeKind.Unspecified).AddTicks(5424), new TimeSpan(0, -3, 0, 0, 0)), 49L, 24L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 24, 17, 22, 45, 809, DateTimeKind.Unspecified).AddTicks(1149), new TimeSpan(0, -3, 0, 0, 0)), 13L, 37L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 25, 13, 51, 38, 876, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, -3, 0, 0, 0)), 42L, 22L });

            migrationBuilder.UpdateData(
                table: "Shipment",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "DeliveryDate", "LastModified", "ShippedDate", "TrackNumber" },
                values: new object[] { new DateTime(2019, 9, 3, 2, 28, 56, 518, DateTimeKind.Utc).AddTicks(1414), new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTimeOffset(new DateTime(2019, 9, 3, 2, 28, 56, 518, DateTimeKind.Unspecified).AddTicks(1004), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "d5b9c21e-ce44-4f18-9324-913112c6da5e" });

            migrationBuilder.CreateIndex(
                name: "IX_StormyProduct_CategoryId",
                table: "StormyProduct",
                column: "CategoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Media_StormyProduct_Id",
                table: "Media",
                column: "Id",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLink_StormyProduct_Id",
                table: "ProductLink",
                column: "Id",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLink_StormyProduct_ProductId",
                table: "ProductLink",
                column: "ProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_StormyProduct_Id",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLink_StormyProduct_Id",
                table: "ProductLink");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLink_StormyProduct_ProductId",
                table: "ProductLink");

            migrationBuilder.DropIndex(
                name: "IX_StormyProduct_CategoryId",
                table: "StormyProduct");

            migrationBuilder.DropColumn(
                name: "ThumbnailImage",
                table: "StormyProduct");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "ProductLink",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Media",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<long>(
                name: "StormyProductId",
                table: "Media",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "City", "FirstAddress", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street" },
                values: new object[] { "Município de Warley", "Isabela Travessa", new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 328, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 0, 0, 0, 0)), "368", "(28) 50091-5505", "16769", "Quadra 08", "Paraíba", "057 Júlia Alameda" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "City", "FirstAddress", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street" },
                values: new object[] { "Moreirado Descoberto", "Melo Rodovia", new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 330, DateTimeKind.Unspecified).AddTicks(7854), new TimeSpan(0, 0, 0, 0, 0)), "568", "+55 (36) 5356-5529", "20015-649", "Sobrado 74", "Pernambuco", "729 Santos Marginal" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "City", "FirstAddress", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street" },
                values: new object[] { "Batistado Descoberto", "Kléber Rodovia", new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 330, DateTimeKind.Unspecified).AddTicks(8536), new TimeSpan(0, 0, 0, 0, 0)), "8320", "+55 (17) 9738-4336", "83275-491", "Quadra 10", "Rio de Janeiro", "53520 Carvalho Viela" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "City", "FirstAddress", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street" },
                values: new object[] { "Município de Morganade Nossa Senhora", "Costa Marginal", new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 330, DateTimeKind.Unspecified).AddTicks(8992), new TimeSpan(0, 0, 0, 0, 0)), "1146", "+55 (54) 2596-3118", "91640", "Lote 25", "Mato Grosso", "65200 Saraiva Rodovia" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "City", "FirstAddress", "LastModified", "Number", "PhoneNumber", "PostalCode", "SecondAddress", "State", "Street" },
                values: new object[] { "Município de Yangodo Norte", "Saraiva Rua", new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 330, DateTimeKind.Unspecified).AddTicks(9390), new TimeSpan(0, 0, 0, 0, 0)), "447", "+55 (71) 3644-0193", "12085-706", "Apto. 741", "Minas Gerais", "58999 Meire Alameda" });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "Description", "IsDeleted", "LastModified", "LogoImage", "Name", "Slug", "Website" },
                values: new object[,]
                {
                    { 10L, @"Dolorem omnis laborum aut cupiditate explicabo voluptatum quia veniam voluptatem.
                Et eaque qui sint dolores fuga doloribus voluptatum omnis adipisci.
                Et provident numquam cumque possimus veniam culpa dicta provident vitae.
                Et odit ea.
                Aut eum inventore ut sed.", false, new DateTimeOffset(new DateTime(2019, 8, 21, 5, 56, 24, 93, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=1002", "Pereira, Nogueira and Macedo", "cum-ea-animi", "gustavo.info" },
                    { 9L, "Expedita est autem quasi.", false, new DateTimeOffset(new DateTime(2019, 8, 20, 2, 13, 43, 911, DateTimeKind.Unspecified).AddTicks(8886), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=460", "Souza - Souza", "minus-odio-similique", "eduarda.com" },
                    { 8L, @"Iusto illum eos architecto est aliquid.
                Sed ut hic est temporibus explicabo quas fugiat fugit.
                Modi impedit esse aperiam nemo aut quisquam.", false, new DateTimeOffset(new DateTime(2019, 8, 19, 1, 43, 21, 933, DateTimeKind.Unspecified).AddTicks(1718), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=426", "Moraes - Carvalho", "et-porro-quibusdam", "sara.com" },
                    { 7L, @"Sit qui voluptas distinctio perspiciatis libero.
                Aliquam quos et.
                Eligendi consequatur est vel quasi.
                Reiciendis ut quaerat sed voluptatem rem asperiores.", false, new DateTimeOffset(new DateTime(2019, 8, 9, 11, 51, 54, 323, DateTimeKind.Unspecified).AddTicks(8667), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=662", "Barros, Nogueira and Costa", "consequatur-harum-et", "salvador.name" },
                    { 6L, "Eum voluptate exercitationem tenetur.", false, new DateTimeOffset(new DateTime(2019, 7, 31, 19, 37, 27, 996, DateTimeKind.Unspecified).AddTicks(3247), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=577", "Barros - Pereira", "perferendis-sapiente-sed", "talita.name" },
                    { 1L, "Dolorum sed sapiente rerum quisquam velit asperiores hic. Porro ad eaque ut. Dolores error provident ipsam nemo. Inventore quibusdam quibusdam est nam voluptates a enim. Ut dolor a fugiat eos. Dolores reprehenderit corporis sit asperiores vero consequatur.", false, new DateTimeOffset(new DateTime(2019, 8, 4, 2, 59, 33, 135, DateTimeKind.Unspecified).AddTicks(942), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=75", "Saraiva - Pereira", "eveniet-est-ipsa", "isabel.info" },
                    { 2L, "Ratione molestiae quas tempora rerum quia id assumenda. Id culpa aut enim explicabo quia praesentium natus et. Quos velit repellat magnam et repellendus ea doloribus explicabo ut. Sequi sunt eos ab non deserunt. Cupiditate dolore in.", false, new DateTimeOffset(new DateTime(2019, 8, 10, 16, 57, 19, 630, DateTimeKind.Unspecified).AddTicks(4897), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=73", "Nogueira - Pereira", "rerum-iusto-minus", "frederico.net" },
                    { 3L, @"Cupiditate et eaque excepturi molestiae eum.
                Et laborum aliquid eaque laborum dicta vel aut facilis eum.
                Consequuntur tenetur quidem voluptatibus.
                Aut cumque optio tenetur.", false, new DateTimeOffset(new DateTime(2019, 7, 31, 13, 35, 32, 331, DateTimeKind.Unspecified).AddTicks(2204), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=824", "Silva - Moreira", "aliquam-neque-totam", "ofélia.info" },
                    { 4L, "Ea in et omnis quia doloribus aliquid.", false, new DateTimeOffset(new DateTime(2019, 8, 21, 23, 33, 57, 436, DateTimeKind.Unspecified).AddTicks(2827), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=323", "Carvalho Comércio", "ad-ut-odit", "alessandro.biz" },
                    { 5L, "Magni corporis et. Id magnam consequatur. Voluptatem unde officiis ipsa est eius debitis iure. Eum est ad eaque quam est corrupti eos aliquid architecto.", false, new DateTimeOffset(new DateTime(2019, 8, 18, 5, 0, 45, 801, DateTimeKind.Unspecified).AddTicks(5136), new TimeSpan(0, -3, 0, 0, 0)), "https://picsum.photos/640/480/?image=247", "Nogueira LTDA", "facere-autem-quidem", "carla.br" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "DisplayOrder", "IncludeInMenu", "IsDeleted", "IsPublished", "LastModified", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "ParentId", "Slug", "ThumbnailImageUrl" },
                values: new object[,]
                {
                    { 1L, "Qui quasi laboriosam cumque.", 0, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 22, 12, 20, 11, 886, DateTimeKind.Unspecified).AddTicks(6267), new TimeSpan(0, -3, 0, 0, 0)), "Esse nostrum ipsa dicta accusamus vitae beatae.", null, null, "Toys", null, "officia-accusamus-est", "http://lorempixel.com/640/480/fashion" },
                    { 9L, "Unde et impedit animi saepe. Molestias enim animi distinctio magnam. Ipsa aperiam aut dolorem ad inventore excepturi qui.", 8, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 4, 15, 17, 3, 966, DateTimeKind.Unspecified).AddTicks(4445), new TimeSpan(0, -3, 0, 0, 0)), "rerum", null, null, "Books", null, "vel-laborum-laboriosam", "http://lorempixel.com/640/480/fashion" },
                    { 8L, "Nesciunt iure quos est molestiae eum. Totam vitae laudantium vel blanditiis et harum omnis in. Molestiae nesciunt voluptas modi. Ut blanditiis tempore possimus omnis vel tenetur.", 7, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 6, 18, 6, 23, 112, DateTimeKind.Unspecified).AddTicks(1999), new TimeSpan(0, -3, 0, 0, 0)), "Molestiae architecto nemo exercitationem excepturi.", null, null, "Beauty", null, "impedit-molestiae-sed", "http://lorempixel.com/640/480/fashion" },
                    { 7L, @"Ut dolorem deleniti quis ut.
                Eius sit ipsam saepe autem molestias non ad necessitatibus.", 6, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 14, 18, 35, 22, 821, DateTimeKind.Unspecified).AddTicks(8876), new TimeSpan(0, -3, 0, 0, 0)), "Nemo in enim laborum consequuntur adipisci sequi. Quos a cumque vitae ducimus animi. Rem sint laudantium molestias rerum sed illum non iure. Aliquam qui architecto repellat soluta quas omnis qui eveniet. Sunt ipsa ex optio. Dolores assumenda ea quaerat harum.", null, null, "Clothing", null, "incidunt-dignissimos-est", "http://lorempixel.com/640/480/fashion" },
                    { 6L, "Aspernatur omnis voluptatem et corporis similique temporibus est. Atque dignissimos eaque possimus dolor ut qui vero. Est doloremque impedit ad exercitationem minus tempore ducimus aliquid blanditiis. At aut itaque dolorem atque.", 5, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 12, 19, 39, 13, 748, DateTimeKind.Unspecified).AddTicks(1662), new TimeSpan(0, -3, 0, 0, 0)), "Non aliquid tempore ratione porro aspernatur voluptatem aut culpa non.", null, null, "Computers", null, "tenetur-reprehenderit-possimus", "http://lorempixel.com/640/480/fashion" },
                    { 5L, "Hic quaerat aut quo molestias placeat eveniet officia voluptatem.", 4, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 20, 16, 11, 1, 353, DateTimeKind.Unspecified).AddTicks(5419), new TimeSpan(0, -3, 0, 0, 0)), "quo", null, null, "Computers", null, "similique-qui-voluptatibus", "http://lorempixel.com/640/480/fashion" },
                    { 4L, "Dolore sint error quod cum. Tenetur odio sed. Ipsum rerum possimus sint nesciunt et.", 3, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 1, 7, 44, 2, 664, DateTimeKind.Unspecified).AddTicks(7027), new TimeSpan(0, -3, 0, 0, 0)), "ipsam", null, null, "Electronics", null, "sed-mollitia-vel", "http://lorempixel.com/640/480/fashion" },
                    { 3L, "Voluptas libero minima dolores et dolores totam distinctio.", 2, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 19, 14, 47, 26, 854, DateTimeKind.Unspecified).AddTicks(4709), new TimeSpan(0, -3, 0, 0, 0)), "Ipsam molestiae magni enim nam omnis.", null, null, "Industrial", null, "dolorem-laudantium-corrupti", "http://lorempixel.com/640/480/fashion" },
                    { 2L, @"Et dolores repellendus.
                Debitis quo ea rerum et qui fugiat a.
                Ullam quia numquam illum labore aliquam perspiciatis fuga earum consequatur.
                Eum eum quia.
                Ipsum voluptate sed reprehenderit.", 1, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 16, 17, 44, 8, 335, DateTimeKind.Unspecified).AddTicks(9221), new TimeSpan(0, -3, 0, 0, 0)), @"Itaque omnis eaque velit.
                Inventore et aut et eaque consequuntur dolores nostrum distinctio.", null, null, "Grocery", null, "et-qui-dicta", "http://lorempixel.com/640/480/fashion" },
                    { 10L, "Et itaque in blanditiis ipsa.", 9, true, false, true, new DateTimeOffset(new DateTime(2019, 8, 7, 21, 35, 19, 819, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, -3, 0, 0, 0)), "Hic et culpa. Hic voluptas esse inventore rerum totam tempore hic hic. Assumenda nemo quia aut nam. Explicabo voluptatem at soluta modi alias. Quisquam pariatur velit alias magni aut quia quia eos non. Aliquam natus delectus iste optio sunt sit suscipit ea vel.", null, null, "Automotive", null, "dolorem-sunt-magni", "http://lorempixel.com/640/480/fashion" }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Caption", "FileName", "FileSize", "IsDeleted", "LastModified", "MediaType", "SeoFileName", "StormyProductId" },
                values: new object[,]
                {
                    { 36L, null, "http://lorempixel.com/640/480/fashion", -2108669627, false, new DateTimeOffset(new DateTime(2019, 8, 16, 15, 59, 29, 49, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 35L, null, "http://lorempixel.com/640/480/fashion", 1348465874, false, new DateTimeOffset(new DateTime(2019, 8, 23, 23, 1, 37, 97, DateTimeKind.Unspecified).AddTicks(4769), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 34L, null, "http://lorempixel.com/640/480/fashion", -908392503, false, new DateTimeOffset(new DateTime(2019, 8, 17, 4, 32, 54, 494, DateTimeKind.Unspecified).AddTicks(6754), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 33L, null, "http://lorempixel.com/640/480/fashion", -100319305, false, new DateTimeOffset(new DateTime(2019, 8, 14, 20, 17, 1, 255, DateTimeKind.Unspecified).AddTicks(1096), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 29L, null, "http://lorempixel.com/640/480/fashion", -2083566090, false, new DateTimeOffset(new DateTime(2019, 8, 15, 11, 30, 58, 817, DateTimeKind.Unspecified).AddTicks(4246), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 31L, null, "http://lorempixel.com/640/480/fashion", 544970196, false, new DateTimeOffset(new DateTime(2019, 8, 15, 16, 25, 17, 991, DateTimeKind.Unspecified).AddTicks(5817), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 30L, null, "http://lorempixel.com/640/480/fashion", 412570580, false, new DateTimeOffset(new DateTime(2019, 8, 12, 6, 39, 30, 390, DateTimeKind.Unspecified).AddTicks(897), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 37L, null, "http://lorempixel.com/640/480/fashion", 634328547, false, new DateTimeOffset(new DateTime(2019, 8, 13, 21, 36, 41, 747, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 28L, null, "http://lorempixel.com/640/480/fashion", -1097659092, false, new DateTimeOffset(new DateTime(2019, 8, 14, 13, 35, 7, 304, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 32L, null, "http://lorempixel.com/640/480/fashion", -1766148219, false, new DateTimeOffset(new DateTime(2019, 8, 22, 1, 56, 57, 659, DateTimeKind.Unspecified).AddTicks(9941), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 38L, null, "http://lorempixel.com/640/480/fashion", -1136934246, false, new DateTimeOffset(new DateTime(2019, 8, 22, 23, 39, 12, 27, DateTimeKind.Unspecified).AddTicks(811), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 43L, null, "http://lorempixel.com/640/480/fashion", -1914133396, false, new DateTimeOffset(new DateTime(2019, 8, 21, 21, 42, 4, 501, DateTimeKind.Unspecified).AddTicks(7864), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 40L, null, "http://lorempixel.com/640/480/fashion", 2098441845, false, new DateTimeOffset(new DateTime(2019, 8, 11, 7, 28, 56, 431, DateTimeKind.Unspecified).AddTicks(9428), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 41L, null, "http://lorempixel.com/640/480/fashion", 1786569821, false, new DateTimeOffset(new DateTime(2019, 8, 12, 19, 26, 14, 577, DateTimeKind.Unspecified).AddTicks(7249), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 42L, null, "http://lorempixel.com/640/480/fashion", -1260092941, false, new DateTimeOffset(new DateTime(2019, 8, 17, 16, 52, 34, 708, DateTimeKind.Unspecified).AddTicks(5621), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 44L, null, "http://lorempixel.com/640/480/fashion", -489405057, false, new DateTimeOffset(new DateTime(2019, 8, 10, 19, 49, 36, 178, DateTimeKind.Unspecified).AddTicks(3421), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 45L, null, "http://lorempixel.com/640/480/fashion", 339253202, false, new DateTimeOffset(new DateTime(2019, 8, 15, 12, 25, 5, 951, DateTimeKind.Unspecified).AddTicks(367), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 46L, null, "http://lorempixel.com/640/480/fashion", -1864844783, false, new DateTimeOffset(new DateTime(2019, 8, 13, 9, 19, 28, 233, DateTimeKind.Unspecified).AddTicks(3740), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 47L, null, "http://lorempixel.com/640/480/fashion", -1440869552, false, new DateTimeOffset(new DateTime(2019, 8, 11, 2, 44, 23, 585, DateTimeKind.Unspecified).AddTicks(1165), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 48L, null, "http://lorempixel.com/640/480/fashion", -181993261, false, new DateTimeOffset(new DateTime(2019, 8, 19, 7, 35, 18, 949, DateTimeKind.Unspecified).AddTicks(2305), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 49L, null, "http://lorempixel.com/640/480/fashion", -248962094, false, new DateTimeOffset(new DateTime(2019, 8, 14, 15, 32, 16, 712, DateTimeKind.Unspecified).AddTicks(7117), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 50L, null, "http://lorempixel.com/640/480/fashion", -1119961787, false, new DateTimeOffset(new DateTime(2019, 8, 14, 20, 39, 47, 89, DateTimeKind.Unspecified).AddTicks(5745), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 27L, null, "http://lorempixel.com/640/480/fashion", 1118343401, false, new DateTimeOffset(new DateTime(2019, 8, 19, 0, 46, 14, 762, DateTimeKind.Unspecified).AddTicks(7292), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 39L, null, "http://lorempixel.com/640/480/fashion", 535492750, false, new DateTimeOffset(new DateTime(2019, 8, 19, 23, 17, 8, 216, DateTimeKind.Unspecified).AddTicks(2402), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 26L, null, "http://lorempixel.com/640/480/fashion", -1456160779, false, new DateTimeOffset(new DateTime(2019, 8, 12, 15, 12, 12, 175, DateTimeKind.Unspecified).AddTicks(1162), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 23L, null, "http://lorempixel.com/640/480/fashion", 325028550, false, new DateTimeOffset(new DateTime(2019, 8, 18, 1, 30, 5, 535, DateTimeKind.Unspecified).AddTicks(2090), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 24L, null, "http://lorempixel.com/640/480/fashion", -1923942321, false, new DateTimeOffset(new DateTime(2019, 8, 17, 4, 55, 55, 763, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 1L, null, "http://lorempixel.com/640/480/fashion", 611298457, false, new DateTimeOffset(new DateTime(2019, 8, 17, 14, 35, 16, 802, DateTimeKind.Unspecified).AddTicks(100), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 25L, null, "http://lorempixel.com/640/480/fashion", 1917445442, false, new DateTimeOffset(new DateTime(2019, 8, 18, 21, 22, 33, 463, DateTimeKind.Unspecified).AddTicks(2435), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 3L, null, "http://lorempixel.com/640/480/fashion", -818678637, false, new DateTimeOffset(new DateTime(2019, 8, 23, 20, 37, 35, 754, DateTimeKind.Unspecified).AddTicks(9716), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 4L, null, "http://lorempixel.com/640/480/fashion", -1509550385, false, new DateTimeOffset(new DateTime(2019, 8, 23, 22, 43, 16, 136, DateTimeKind.Unspecified).AddTicks(6118), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 5L, null, "http://lorempixel.com/640/480/fashion", -1506346253, false, new DateTimeOffset(new DateTime(2019, 8, 17, 3, 1, 28, 889, DateTimeKind.Unspecified).AddTicks(9679), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 6L, null, "http://lorempixel.com/640/480/fashion", -149445437, false, new DateTimeOffset(new DateTime(2019, 8, 19, 12, 38, 35, 724, DateTimeKind.Unspecified).AddTicks(1811), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 7L, null, "http://lorempixel.com/640/480/fashion", -503129824, false, new DateTimeOffset(new DateTime(2019, 8, 18, 17, 43, 41, 750, DateTimeKind.Unspecified).AddTicks(6319), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 8L, null, "http://lorempixel.com/640/480/fashion", 1180898732, false, new DateTimeOffset(new DateTime(2019, 8, 18, 14, 52, 41, 387, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 9L, null, "http://lorempixel.com/640/480/fashion", 1087295132, false, new DateTimeOffset(new DateTime(2019, 8, 16, 2, 46, 31, 663, DateTimeKind.Unspecified).AddTicks(5978), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 10L, null, "http://lorempixel.com/640/480/fashion", 870675147, false, new DateTimeOffset(new DateTime(2019, 8, 17, 21, 0, 20, 753, DateTimeKind.Unspecified).AddTicks(7660), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 11L, null, "http://lorempixel.com/640/480/fashion", 1043204431, false, new DateTimeOffset(new DateTime(2019, 8, 12, 1, 34, 32, 983, DateTimeKind.Unspecified).AddTicks(7533), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 2L, null, "http://lorempixel.com/640/480/fashion", 243519899, false, new DateTimeOffset(new DateTime(2019, 8, 12, 21, 10, 18, 166, DateTimeKind.Unspecified).AddTicks(2415), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 13L, null, "http://lorempixel.com/640/480/fashion", 704351027, false, new DateTimeOffset(new DateTime(2019, 8, 18, 0, 39, 3, 509, DateTimeKind.Unspecified).AddTicks(8086), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 14L, null, "http://lorempixel.com/640/480/fashion", 1373767583, false, new DateTimeOffset(new DateTime(2019, 8, 14, 5, 33, 44, 539, DateTimeKind.Unspecified).AddTicks(3279), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 15L, null, "http://lorempixel.com/640/480/fashion", -1229790608, false, new DateTimeOffset(new DateTime(2019, 8, 11, 21, 51, 23, 846, DateTimeKind.Unspecified).AddTicks(7377), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 16L, null, "http://lorempixel.com/640/480/fashion", 16787319, false, new DateTimeOffset(new DateTime(2019, 8, 23, 6, 31, 3, 396, DateTimeKind.Unspecified).AddTicks(3065), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 17L, null, "http://lorempixel.com/640/480/fashion", 1618397578, false, new DateTimeOffset(new DateTime(2019, 8, 17, 11, 0, 18, 300, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 18L, null, "http://lorempixel.com/640/480/fashion", -453238050, false, new DateTimeOffset(new DateTime(2019, 8, 14, 18, 7, 39, 95, DateTimeKind.Unspecified).AddTicks(5776), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 19L, null, "http://lorempixel.com/640/480/fashion", -1059995747, false, new DateTimeOffset(new DateTime(2019, 8, 19, 5, 18, 58, 166, DateTimeKind.Unspecified).AddTicks(2835), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 20L, null, "http://lorempixel.com/640/480/fashion", -155246211, false, new DateTimeOffset(new DateTime(2019, 8, 15, 12, 59, 11, 30, DateTimeKind.Unspecified).AddTicks(8916), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 21L, null, "http://lorempixel.com/640/480/fashion", -495990426, false, new DateTimeOffset(new DateTime(2019, 8, 14, 21, 15, 30, 780, DateTimeKind.Unspecified).AddTicks(5881), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 22L, null, "http://lorempixel.com/640/480/fashion", 1229556885, false, new DateTimeOffset(new DateTime(2019, 8, 17, 19, 59, 8, 543, DateTimeKind.Unspecified).AddTicks(6457), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null },
                    { 12L, null, "http://lorempixel.com/640/480/fashion", -1459881308, false, new DateTimeOffset(new DateTime(2019, 8, 15, 16, 2, 56, 131, DateTimeKind.Unspecified).AddTicks(2680), new TimeSpan(0, -3, 0, 0, 0)), 1, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Shipment",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "DeliveryDate", "LastModified", "ShippedDate", "TrackNumber" },
                values: new object[] { new DateTime(2019, 8, 24, 15, 8, 25, 132, DateTimeKind.Utc).AddTicks(2089), new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 132, DateTimeKind.Unspecified).AddTicks(2078), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2019, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "166e94a2-95df-494a-ab5c-6f1fdd495f3f" });

            migrationBuilder.InsertData(
                table: "StormyVendor",
                columns: new[] { "Id", "AddressId", "AddressId1", "CompanyName", "ContactTitle", "Email", "IsDeleted", "LastModified", "Logo", "Note", "Phone", "SizeUrl", "TypeGoods", "WebSite" },
                values: new object[,]
                {
                    { 12L, 0, null, "Reis LTDA", "John_Carvalho", "John_Carvalho@yahoo.com", false, new DateTimeOffset(new DateTime(2019, 8, 11, 18, 50, 50, 407, DateTimeKind.Unspecified).AddTicks(2371), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=791857212", "deserunt", "(27) 38261-7332", "0", "Movies, Games & Health", "maria.info" },
                    { 13L, 0, null, "Xavier S.A.", "Marion20", "Marion.Silva22@live.com", false, new DateTimeOffset(new DateTime(2019, 8, 18, 21, 55, 11, 64, DateTimeKind.Unspecified).AddTicks(3543), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1288572883", "consequatur", "(85) 1969-4516", "0", "Electronics, Garden & Outdoors", "víctor.com" },
                    { 14L, 0, null, "Albuquerque, Moraes and Nogueira", "Garry81", "Garry_Melo@gmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 1, 11, 0, 34, 803, DateTimeKind.Unspecified).AddTicks(1698), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=22161171", @"Est veniam ut fuga optio dolor.
                Mollitia veritatis esse.
                Molestiae ut reiciendis nemo.
                Porro in facilis ut.", "+55 (09) 4771-0411", "0", "Sports", "lorraine.com" },
                    { 18L, 0, null, "Xavier, Braga and Silva", "Ivan.Carvalho77", "Ivan22@gmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 16, 18, 49, 33, 237, DateTimeKind.Unspecified).AddTicks(1704), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1799454219", "praesentium", "(23) 91325-2397", "0", "Computers & Games", "víctor.name" },
                    { 16L, 0, null, "Carvalho - Albuquerque", "Orlando_Carvalho", "Orlando_Carvalho@gmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 21, 9, 52, 9, 368, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=995885461", @"Doloribus labore et dolores voluptas facilis omnis et magnam rerum.
                Voluptatem excepturi magni.", "(77) 52907-5488", "0", "Home & Home", "alessandro.org" },
                    { 17L, 0, null, "Nogueira, Melo and Reis", "Dianne.Xavier29", "Dianne.Xavier34@bol.com.br", false, new DateTimeOffset(new DateTime(2019, 8, 2, 17, 14, 48, 144, DateTimeKind.Unspecified).AddTicks(5091), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=157927682", "Mollitia provident esse est aspernatur. Dolores cupiditate repudiandae quia dolor animi. Maiores ipsam nostrum ipsam et. Vero doloremque minima provident sint et odio soluta. Placeat qui accusantium natus cum natus molestias iure.", "(72) 3785-2466", "0", "Clothing, Shoes & Games", "janaína.net" },
                    { 11L, 0, null, "Melo LTDA", "Jerome_Carvalho", "Jerome.Carvalho@yahoo.com", false, new DateTimeOffset(new DateTime(2019, 8, 17, 2, 37, 28, 85, DateTimeKind.Unspecified).AddTicks(3972), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=750672895", "voluptas", "+55 (09) 6261-5919", "0", "Garden & Tools", "frederico.org" },
                    { 15L, 0, null, "Carvalho, Saraiva and Moreira", "Jonathan_Souza21", "Jonathan.Souza49@hotmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 21, 5, 49, 19, 75, DateTimeKind.Unspecified).AddTicks(3811), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=128559375", @"Quia aliquam doloribus eaque.
                Sequi optio consequuntur id quis sit sint cumque voluptatibus aperiam.
                Dolore mollitia autem aliquid iste quidem.
                Illo officia dolores dolores quae.", "(40) 4806-7683", "0", "Baby, Books & Computers", "lorraine.org" },
                    { 10L, 0, null, "Martins Comércio", "Alexandra.Albuquerque1", "Alexandra.Albuquerque@live.com", false, new DateTimeOffset(new DateTime(2019, 8, 6, 17, 17, 20, 996, DateTimeKind.Unspecified).AddTicks(1167), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1910852930", @"Dolorem voluptatem tempore rem blanditiis rerum.
                Voluptatem animi eaque aliquid.
                Enim neque nisi non nisi iste.
                Natus quo deleniti placeat commodi omnis ut quia officiis.
                Quia excepturi perferendis voluptatem aut rerum ex illum.", "(20) 18819-0757", "0", "Games, Toys & Clothing", "warley.biz" },
                    { 4L, 0, null, "Carvalho Comércio", "Erma73", "Erma.Melo@hotmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 19, 22, 31, 17, 131, DateTimeKind.Unspecified).AddTicks(5417), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=619332642", "quidem", "(60) 82307-1286", "0", "Beauty, Home & Grocery", "vicente.br" },
                    { 8L, 0, null, "Franco Comércio", "Jared_Moraes11", "Jared.Moraes@yahoo.com", false, new DateTimeOffset(new DateTime(2019, 8, 5, 10, 26, 51, 790, DateTimeKind.Unspecified).AddTicks(5274), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1528370096", @"Placeat quibusdam modi error in est autem fugit.
                Ex quo sint eum voluptas eos delectus.
                Saepe sed illum corrupti commodi sapiente.", "(39) 26128-9984", "0", "Outdoors & Shoes", "lucas.biz" },
                    { 7L, 0, null, "Saraiva, Moraes and Pereira", "Jack_Nogueira48", "Jack_Nogueira@hotmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 4, 15, 11, 41, 307, DateTimeKind.Unspecified).AddTicks(5728), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=258072353", "similique", "(36) 24376-9265", "0", "Industrial, Automotive & Toys", "júlio césar.net" },
                    { 6L, 0, null, "Souza - Carvalho", "Stanley39", "Stanley.Oliveira31@yahoo.com", false, new DateTimeOffset(new DateTime(2019, 7, 29, 9, 2, 30, 607, DateTimeKind.Unspecified).AddTicks(693), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=96771084", @"Illo eveniet consectetur.
                Sapiente hic ad aspernatur cumque.
                Ipsam ducimus et dignissimos.
                Laboriosam asperiores natus vitae dolorem est dolore in assumenda mollitia.", "(46) 59025-0175", "0", "Kids", "roberto.net" },
                    { 5L, 0, null, "Silva, Silva and Martins", "Margarita87", "Margarita.Franco@bol.com.br", false, new DateTimeOffset(new DateTime(2019, 8, 12, 22, 34, 34, 807, DateTimeKind.Unspecified).AddTicks(2521), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1227561311", "Consectetur corporis sint atque optio voluptatem numquam consequatur mollitia.", "(56) 16823-9976", "0", "Computers & Baby", "pablo.name" },
                    { 3L, 0, null, "Nogueira - Carvalho", "Ronnie29", "Ronnie20@bol.com.br", false, new DateTimeOffset(new DateTime(2019, 8, 12, 22, 19, 42, 135, DateTimeKind.Unspecified).AddTicks(5147), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=229830666", "Sit iusto ex dolor id fuga aut fugiat fugit nihil. Dolor reprehenderit doloremque eos nihil. Molestiae sed mollitia eum voluptatem occaecati suscipit animi odit.", "(11) 84475-7942", "0", "Computers", "marcos.com" },
                    { 2L, 0, null, "Santos, Xavier and Pereira", "Andres.Saraiva", "Andres.Saraiva24@yahoo.com", false, new DateTimeOffset(new DateTime(2019, 8, 13, 7, 39, 41, 736, DateTimeKind.Unspecified).AddTicks(3715), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1287796653", @"Et eaque consectetur maiores at reiciendis autem accusamus voluptatum quae.
                Aut inventore occaecati velit vero quis.
                Omnis assumenda quasi aut ducimus deserunt tempora tenetur.
                A asperiores dignissimos dicta assumenda rerum magnam sunt ipsa.
                Minus omnis labore.
                Consequatur officia rem commodi voluptatem esse unde soluta eius.", "(91) 18155-7818", "0", "Kids, Automotive & Jewelery", "sara.br" },
                    { 1L, 0, null, "Souza, Carvalho and Martins", "Josh86", "Josh_Reis@hotmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 22, 4, 35, 19, 352, DateTimeKind.Unspecified).AddTicks(5483), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1621284909", "numquam", "(41) 66293-9001", "0", "Shoes, Clothing & Movies", "heitor.info" },
                    { 19L, 0, null, "Silva, Santos and Macedo", "Audrey21", "Audrey_Braga8@hotmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 5, 11, 44, 13, 958, DateTimeKind.Unspecified).AddTicks(9430), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=703460413", "Tempore at corporis sed sit maxime omnis cumque sunt.", "+55 (64) 8538-0409", "0", "Kids", "roberta.info" },
                    { 9L, 0, null, "Albuquerque - Souza", "Courtney_Saraiva", "Courtney.Saraiva@gmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 16, 11, 52, 11, 384, DateTimeKind.Unspecified).AddTicks(3657), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=1596160703", "Quis fuga dolor dolorem qui aut id.", "(05) 5481-3711", "0", "Baby & Garden", "ígor.net" },
                    { 20L, 0, null, "Macedo - Batista", "Fernando37", "Fernando_Moreira32@hotmail.com", false, new DateTimeOffset(new DateTime(2019, 8, 12, 12, 51, 1, 194, DateTimeKind.Unspecified).AddTicks(917), new TimeSpan(0, -3, 0, 0, 0)), "https://loremflickr.com/320/240?lock=397258838", "Neque laboriosam consequatur.", "(18) 8585-1434", "0", "Toys, Toys & Health", "alexandre.biz" }
                });

            migrationBuilder.InsertData(
                table: "StormyProduct",
                columns: new[] { "Id", "AllowCustomerReview", "ApprovedRatingSum", "ApprovedTotalReviews", "AvailableForPreorder", "BrandId", "CategoryId", "CreatedAt", "Discount", "DiscountAvailable", "HasDiscountApplied", "IsDeleted", "LastModified", "MediaId", "NotApprovedRatingSum", "NotApprovedTotalReviews", "NotReturnable", "Note", "OldPrice", "PreOrderAvailabilityStartDate", "Price", "ProductAvailable", "ProductCost", "ProductLinksId", "ProductName", "Published", "QuantityPerUnity", "Ranking", "SKU", "Slug", "Status", "StockTrackingIsEnabled", "TypeName", "UnitPrice", "UnitSize", "UnitWeight", "UnitsInStock", "UnitsOnOrder", "UpdatedOnUtc", "VendorId" },
                values: new object[,]
                {
                    { 13L, false, 0, 0, false, 7L, 10L, new DateTime(2019, 3, 27, 9, 1, 14, 216, DateTimeKind.Local).AddTicks(4744), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(6613), new TimeSpan(0, 0, 0, 0, 0)), 2L, 0, 0, false, "Modi vel vitae minus aut molestias dolores ut inventore. Tempore qui laboriosam sed omnis veniam illo perferendis quasi in. Quia error tempore perferendis. Error repellat distinctio sunt sint laborum sunt aliquid. Facilis iusto magni eos quo voluptatibus dolorem non possimus et. Odit ea dolorem optio beatae et illum molestiae.", "R$12,05", new DateTime(2020, 2, 22, 11, 3, 9, 219, DateTimeKind.Local).AddTicks(5712), "R$62,37", true, 0.8189107788814750m, 0L, "Gorgeous Fresh Tuna", true, 72, 13, "r9yf5gln8khe730i", "et-dolore-modi", "Good", true, "Health", 41.5576038609993000m, 2.9122479599491900m, 0.44761612333711986, 56, 32, new DateTime(2019, 8, 24, 20, 34, 56, 589, DateTimeKind.Local).AddTicks(1148), 1L },
                    { 32L, false, 0, 0, false, 6L, 9L, new DateTime(2019, 6, 28, 9, 41, 32, 232, DateTimeKind.Local).AddTicks(1208), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(3043), new TimeSpan(0, 0, 0, 0, 0)), 3L, 0, 0, false, "Sit quasi est id ipsam laborum sed deleniti voluptatibus. Ipsam omnis quas adipisci dicta. In aspernatur dolore quo quis qui. Minus velit non et doloribus nemo. Expedita et officia in vitae. Optio eos voluptatem ducimus saepe eaque.", "R$160,92", new DateTime(2020, 8, 20, 23, 19, 23, 133, DateTimeKind.Local).AddTicks(4342), "R$59,49", true, 0.8201014128607240m, 0L, "Practical Plastic Pizza", true, 52, 32, "t5kv4zbcralpj53g", "totam-totam-suscipit", "Good", true, "Movies", 14.3501326974249000m, 5.7209344467711300m, 0.13519204227961229, 72, 48, new DateTime(2019, 8, 24, 3, 16, 50, 788, DateTimeKind.Local).AddTicks(8749), 12L },
                    { 39L, false, 0, 0, false, 9L, 10L, new DateTime(2019, 7, 31, 10, 55, 8, 366, DateTimeKind.Local).AddTicks(8601), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(5335), new TimeSpan(0, 0, 0, 0, 0)), 18L, 0, 0, false, "Sunt sit vitae ea suscipit earum.", "R$185,88", new DateTime(2020, 6, 25, 17, 50, 51, 690, DateTimeKind.Local).AddTicks(6025), "R$49,81", true, 0.1156523717174550m, 0L, "Gorgeous Soft Hat", true, 92, 39, "wtfw4llk4dzn5z1d", "ad-ut-totam", "Good", true, "Tools", 48.0011621713644000m, 6.9180676652668400m, 0.055496517594669253, 66, 48, new DateTime(2019, 8, 24, 9, 0, 8, 915, DateTimeKind.Local).AddTicks(4527), 12L },
                    { 49L, false, 0, 0, false, 7L, 8L, new DateTime(2019, 2, 3, 15, 35, 18, 229, DateTimeKind.Local).AddTicks(291), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(8622), new TimeSpan(0, 0, 0, 0, 0)), 15L, 0, 0, false, "Praesentium voluptas animi necessitatibus assumenda maxime.", "R$22,05", new DateTime(2020, 5, 28, 19, 38, 25, 587, DateTimeKind.Local).AddTicks(5761), "R$64,06", true, 0.3075980261469250m, 0L, "Fantastic Rubber Soap", true, 50, 49, "54gsdh8g9ix1a4du", "harum-nihil-consequuntur", "Good", true, "Beauty", 85.3512224207405000m, 1.4939504309994900m, 0.0046733892544514452, 100, 16, new DateTime(2019, 8, 23, 21, 8, 47, 255, DateTimeKind.Local).AddTicks(2844), 12L },
                    { 8L, false, 0, 0, false, 2L, 1L, new DateTime(2018, 12, 20, 12, 37, 44, 189, DateTimeKind.Local).AddTicks(3931), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(4260), new TimeSpan(0, 0, 0, 0, 0)), 15L, 0, 0, false, "Harum quam rerum. Aut pariatur cum omnis similique perspiciatis atque. Quos sapiente eius rerum tempore deleniti modi. Sit id ea vel ab inventore doloremque tenetur. Saepe praesentium suscipit inventore unde. Reiciendis ratione totam atque nesciunt rerum.", "R$176,19", new DateTime(2019, 11, 24, 13, 23, 30, 858, DateTimeKind.Local).AddTicks(8680), "R$51,80", true, 0.5097043432806170m, 0L, "Intelligent Plastic Soap", true, 16, 8, "6gzbclfdkkatm0es", "doloribus-commodi-aut", "Good", true, "Toys", 28.3852096779203000m, 2.6695315924796900m, 0.55612581295712193, 74, 4, new DateTime(2019, 8, 24, 16, 30, 2, 911, DateTimeKind.Local).AddTicks(4455), 13L },
                    { 4L, false, 0, 0, false, 10L, 2L, new DateTime(2019, 8, 18, 2, 6, 5, 78, DateTimeKind.Local).AddTicks(2900), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, 0, 0, 0, 0)), 11L, 0, 0, false, @"Enim officiis illum aut totam.
                Unde aliquam accusantium ullam nobis fuga cum et.
                Dolores id voluptatem distinctio.
                Reiciendis cumque facilis adipisci doloremque animi.", "R$176,39", new DateTime(2019, 11, 7, 22, 23, 37, 361, DateTimeKind.Local).AddTicks(249), "R$5,09", true, 0.7796730416732250m, 0L, "Intelligent Rubber Pants", true, 72, 4, "fza8qc77ij45b5u6", "occaecati-modi-aut", "Good", true, "Health", 18.1174839465495000m, 0.081169917285987100m, 0.90433514160305961, 62, 50, new DateTime(2019, 8, 24, 14, 10, 6, 571, DateTimeKind.Local).AddTicks(6211), 14L },
                    { 7L, false, 0, 0, false, 7L, 8L, new DateTime(2019, 7, 18, 6, 24, 0, 85, DateTimeKind.Local).AddTicks(543), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(3989), new TimeSpan(0, 0, 0, 0, 0)), 17L, 0, 0, false, "odio", "R$32,55", new DateTime(2020, 8, 15, 4, 58, 1, 227, DateTimeKind.Local).AddTicks(172), "R$11,18", true, 0.1522977678814430m, 0L, "Unbranded Granite Shoes", true, 20, 7, "vataetlgngl5ynej", "sunt-eum-aliquid", "Good", true, "Automotive", 68.559929155074000m, 0.48758496087397700m, 0.8150927055697389, 94, 42, new DateTime(2019, 8, 23, 20, 16, 26, 178, DateTimeKind.Local).AddTicks(9646), 14L },
                    { 9L, false, 0, 0, false, 5L, 5L, new DateTime(2018, 11, 3, 19, 47, 55, 982, DateTimeKind.Local).AddTicks(168), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(4737), new TimeSpan(0, 0, 0, 0, 0)), 16L, 0, 0, false, "Perferendis vel corrupti sapiente voluptatem asperiores distinctio. Neque perferendis sed molestiae cupiditate. Pariatur sit aut ex. Dolorum cum non sint ipsa sed eligendi dolores natus. Voluptatem vel quibusdam labore iste deleniti. Sunt minima deleniti non.", "R$145,70", new DateTime(2019, 10, 5, 6, 30, 47, 569, DateTimeKind.Local).AddTicks(410), "R$34,38", true, 0.6731094539505940m, 0L, "Small Soft Salad", true, 86, 9, "0tgttqio35hxk8s7", "repellat-et-fugiat", "Good", true, "Jewelery", 13.4983796689186000m, 8.9541156678246900m, 0.33681604374983165, 72, 6, new DateTime(2019, 8, 24, 12, 53, 44, 662, DateTimeKind.Local).AddTicks(4850), 14L },
                    { 37L, false, 0, 0, false, 10L, 8L, new DateTime(2018, 11, 18, 9, 34, 54, 878, DateTimeKind.Local).AddTicks(9316), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(4698), new TimeSpan(0, 0, 0, 0, 0)), 14L, 0, 0, false, @"Iusto sint minima.
                Veniam et exercitationem aut ut magnam architecto et aperiam.
                Rerum est repudiandae officiis quia blanditiis libero sed.
                Sequi veniam neque qui explicabo recusandae saepe maiores.", "R$76,32", new DateTime(2019, 9, 5, 23, 51, 39, 270, DateTimeKind.Local).AddTicks(6668), "R$51,38", true, 0.1616910487235020m, 0L, "Handmade Granite Pants", true, 66, 37, "td6hpl9f4z7y7777", "voluptas-voluptatem-perspiciatis", "Good", true, "Movies", 21.0329801873458000m, 0.17623353757720100m, 0.55346768235483568, 58, 50, new DateTime(2019, 8, 25, 10, 16, 53, 560, DateTimeKind.Local).AddTicks(8524), 14L },
                    { 46L, false, 0, 0, false, 7L, 3L, new DateTime(2019, 5, 2, 9, 20, 49, 608, DateTimeKind.Local).AddTicks(4129), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(7618), new TimeSpan(0, 0, 0, 0, 0)), 18L, 0, 0, false, "Magni facilis ut doloremque et. Architecto ea et. Dolorem minus eaque consequatur. Qui tempore sapiente molestias eos porro quia. Sunt deserunt est qui aut animi. Dicta eum cumque.", "R$45,44", new DateTime(2020, 4, 5, 9, 20, 34, 794, DateTimeKind.Local).AddTicks(8565), "R$24,64", true, 0.3573197486611640m, 0L, "Ergonomic Metal Soap", true, 80, 46, "9trxd9rzdlypypmk", "aliquid-alias-distinctio", "Good", true, "Books", 69.9507012823367000m, 9.6352022046387200m, 0.16278013082350609, 100, 44, new DateTime(2019, 8, 24, 7, 12, 9, 463, DateTimeKind.Local).AddTicks(2051), 15L },
                    { 17L, false, 0, 0, false, 1L, 5L, new DateTime(2018, 8, 31, 11, 13, 7, 440, DateTimeKind.Local).AddTicks(5180), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(8355), new TimeSpan(0, 0, 0, 0, 0)), 1L, 0, 0, false, "Nam omnis et non quo in voluptatem aut commodi. Omnis debitis voluptas voluptatibus. Animi et minus tenetur et et et. Assumenda quisquam ratione pariatur nihil repudiandae vel quis accusantium eaque. Est natus inventore praesentium.", "R$81,36", new DateTime(2020, 5, 21, 15, 23, 51, 749, DateTimeKind.Local).AddTicks(5521), "R$18,06", true, 0.759003484043760m, 0L, "Gorgeous Fresh Chicken", true, 62, 17, "c291i6wwnz9cuzvz", "voluptates-repellendus-est", "Good", true, "Automotive", 42.0782072665534000m, 9.3127215790155900m, 0.34589005231200254, 68, 26, new DateTime(2019, 8, 24, 9, 7, 12, 313, DateTimeKind.Local).AddTicks(9686), 16L },
                    { 18L, false, 0, 0, false, 5L, 1L, new DateTime(2019, 7, 23, 16, 15, 25, 144, DateTimeKind.Local).AddTicks(5553), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(8904), new TimeSpan(0, 0, 0, 0, 0)), 10L, 0, 0, false, "Eveniet et culpa odit quae nostrum iste nihil accusantium et.", "R$135,45", new DateTime(2020, 7, 20, 14, 31, 32, 817, DateTimeKind.Local).AddTicks(6673), "R$60,88", true, 0.310192191186450m, 0L, "Awesome Soft Sausages", true, 86, 18, "zw1u1tkqgwjuqund", "alias-perspiciatis-nisi", "Good", true, "Toys", 32.9801229913626000m, 9.2414520863636600m, 0.22282055403237258, 100, 2, new DateTime(2019, 8, 24, 10, 49, 18, 801, DateTimeKind.Local).AddTicks(7217), 16L },
                    { 27L, false, 0, 0, false, 9L, 6L, new DateTime(2018, 10, 5, 17, 45, 59, 154, DateTimeKind.Local).AddTicks(8413), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 0, 0, 0, 0)), 15L, 0, 0, false, "Sed dolor aliquid.", "R$15,27", new DateTime(2019, 9, 30, 7, 39, 33, 772, DateTimeKind.Local).AddTicks(7421), "R$10,67", true, 0.4738287066453270m, 0L, "Sleek Cotton Sausages", true, 42, 27, "4d79suz3xirtj9bg", "omnis-voluptas-velit", "Good", true, "Automotive", 55.4934694690134000m, 3.6326626705157900m, 0.54272435723930801, 70, 10, new DateTime(2019, 8, 24, 18, 47, 5, 313, DateTimeKind.Local).AddTicks(6128), 16L },
                    { 36L, false, 0, 0, false, 2L, 10L, new DateTime(2019, 6, 3, 1, 29, 38, 41, DateTimeKind.Local).AddTicks(8742), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(4414), new TimeSpan(0, 0, 0, 0, 0)), 4L, 0, 0, false, "Ut ducimus laboriosam alias numquam.", "R$87,49", new DateTime(2020, 7, 18, 4, 19, 39, 577, DateTimeKind.Local).AddTicks(4547), "R$56,38", true, 0.08442527804729770m, 0L, "Awesome Concrete Shoes", true, 98, 36, "gi9lt25l3lg4n6br", "facilis-sed-impedit", "Good", true, "Outdoors", 67.6102216670337000m, 7.8664924008150100m, 0.33264052603982414, 70, 6, new DateTime(2019, 8, 24, 11, 24, 18, 519, DateTimeKind.Local).AddTicks(8997), 16L },
                    { 43L, false, 0, 0, false, 5L, 3L, new DateTime(2018, 9, 30, 17, 23, 12, 504, DateTimeKind.Local).AddTicks(7733), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(6645), new TimeSpan(0, 0, 0, 0, 0)), 8L, 0, 0, false, "In ut officiis est. Voluptatum cupiditate eum praesentium. Dolorem modi non porro. Optio alias quae ipsum debitis asperiores voluptatem eos consectetur temporibus.", "R$63,41", new DateTime(2019, 10, 2, 7, 41, 27, 904, DateTimeKind.Local).AddTicks(6249), "R$34,73", true, 0.8802369296924380m, 0L, "Generic Cotton Fish", true, 38, 43, "m9abg6lom28xy104", "ut-occaecati-voluptate", "Good", true, "Kids", 37.814918364312000m, 3.1870315285339200m, 0.40556247458120925, 54, 14, new DateTime(2019, 8, 24, 9, 10, 27, 69, DateTimeKind.Local).AddTicks(8559), 17L },
                    { 29L, false, 0, 0, false, 2L, 4L, new DateTime(2019, 4, 16, 20, 25, 59, 662, DateTimeKind.Local).AddTicks(6387), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(1995), new TimeSpan(0, 0, 0, 0, 0)), 7L, 0, 0, false, @"Non quisquam consequatur eaque laborum aut commodi atque.
                In ab sed sapiente quos blanditiis beatae maiores.
                Quis corrupti quia voluptatem magnam.", "R$118,25", new DateTime(2020, 7, 13, 12, 20, 7, 296, DateTimeKind.Local).AddTicks(2694), "R$58,74", true, 0.7747753373229760m, 0L, "Rustic Fresh Hat", true, 10, 29, "dltle15tn1plki5v", "dolores-eum-fugiat", "Good", true, "Garden", 22.9745402573489000m, 3.5594804694687400m, 0.0058836592388728914, 84, 8, new DateTime(2019, 8, 24, 4, 13, 41, 620, DateTimeKind.Local).AddTicks(8932), 18L },
                    { 34L, false, 0, 0, false, 8L, 10L, new DateTime(2019, 1, 9, 20, 26, 51, 656, DateTimeKind.Local).AddTicks(6643), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 0, 0, 0, 0)), 10L, 0, 0, false, "Nemo impedit quia optio provident explicabo dolorum. Quis perferendis sequi ut nisi aliquam nostrum et similique. Sint suscipit porro asperiores.", "R$83,37", new DateTime(2019, 11, 10, 13, 0, 43, 262, DateTimeKind.Local).AddTicks(9617), "R$84,27", true, 0.5302963659774030m, 0L, "Licensed Soft Mouse", true, 38, 34, "7f14d0yeutv2p6gz", "aut-beatae-odio", "Good", true, "Books", 50.0851477263892000m, 0.30756001375036300m, 0.504851456035325, 96, 4, new DateTime(2019, 8, 24, 8, 14, 7, 367, DateTimeKind.Local).AddTicks(6804), 18L },
                    { 38L, false, 0, 0, false, 2L, 6L, new DateTime(2019, 6, 8, 4, 52, 41, 277, DateTimeKind.Local).AddTicks(8160), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(5109), new TimeSpan(0, 0, 0, 0, 0)), 20L, 0, 0, false, "distinctio", "R$110,70", new DateTime(2020, 7, 8, 1, 0, 41, 115, DateTimeKind.Local).AddTicks(2144), "R$98,80", true, 0.3224775313038740m, 0L, "Fantastic Frozen Shirt", true, 88, 38, "i28sb4i4d8s4k4s7", "architecto-beatae-ut", "Good", true, "Toys", 24.4038528410736000m, 9.3332911279673200m, 0.75310187915018845, 96, 42, new DateTime(2019, 8, 24, 18, 5, 19, 106, DateTimeKind.Local).AddTicks(8423), 18L },
                    { 40L, false, 0, 0, false, 7L, 6L, new DateTime(2018, 10, 13, 7, 42, 55, 909, DateTimeKind.Local).AddTicks(922), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 0, 0, 0, 0)), 1L, 0, 0, false, "et", "R$93,53", new DateTime(2020, 1, 18, 23, 54, 57, 534, DateTimeKind.Local).AddTicks(1218), "R$49,21", true, 0.4385488738485370m, 0L, "Ergonomic Concrete Soap", true, 34, 40, "qseufwqf29n3qssk", "maxime-facilis-odit", "Good", true, "Outdoors", 40.1881550625843000m, 1.5113984381367400m, 0.99955304153242752, 86, 14, new DateTime(2019, 8, 25, 3, 19, 21, 625, DateTimeKind.Local).AddTicks(3430), 18L },
                    { 12L, false, 0, 0, false, 8L, 9L, new DateTime(2019, 2, 17, 6, 36, 36, 88, DateTimeKind.Local).AddTicks(7128), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(5991), new TimeSpan(0, 0, 0, 0, 0)), 6L, 0, 0, false, "Ut id laudantium quis. Omnis atque odio aut et quas molestiae reiciendis dolores alias. Nihil enim praesentium soluta aut est sunt soluta similique accusantium. Consectetur error nisi accusamus incidunt laudantium perspiciatis. Perspiciatis quis dolor ab ut dolor impedit occaecati voluptatibus expedita. Neque magnam ut.", "R$182,19", new DateTime(2020, 4, 16, 18, 37, 45, 23, DateTimeKind.Local).AddTicks(7869), "R$9,34", true, 0.2814616348042440m, 0L, "Gorgeous Concrete Chicken", true, 16, 12, "u15w5lof7bs9au5z", "nam-distinctio-voluptatem", "Good", true, "Beauty", 13.9209376712893000m, 4.7526855742338500m, 0.38878679898976665, 52, 28, new DateTime(2019, 8, 24, 11, 57, 38, 688, DateTimeKind.Local).AddTicks(7306), 19L },
                    { 14L, false, 0, 0, false, 7L, 1L, new DateTime(2019, 4, 25, 20, 20, 24, 99, DateTimeKind.Local).AddTicks(3937), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(7157), new TimeSpan(0, 0, 0, 0, 0)), 1L, 0, 0, false, @"Non sed impedit impedit at nesciunt facere.
                Aut omnis voluptate perferendis ex iure.
                Maxime quia rerum tenetur maxime ut sit aliquam qui.
                Illum molestias voluptatem officia recusandae.
                Vitae dicta dolores et rem dolores laudantium.", "R$171,52", new DateTime(2020, 6, 16, 3, 12, 35, 764, DateTimeKind.Local).AddTicks(2560), "R$11,94", true, 0.5394472878144340m, 0L, "Rustic Frozen Tuna", true, 84, 14, "4uxvcf2ns1bl76y0", "nostrum-autem-qui", "Good", true, "Shoes", 2.55971150591956000m, 8.238660021796200m, 0.41369204102721624, 74, 28, new DateTime(2019, 8, 24, 12, 10, 38, 232, DateTimeKind.Local).AddTicks(399), 19L },
                    { 31L, false, 0, 0, false, 3L, 6L, new DateTime(2019, 5, 19, 4, 16, 38, 175, DateTimeKind.Local).AddTicks(2567), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 0, 0, 0, 0)), 18L, 0, 0, false, @"Aut sed est.
                Rem facere quo explicabo nesciunt dolore minus nobis aut commodi.
                Iure fugit quibusdam natus quia quidem rerum id ipsam.", "R$92,52", new DateTime(2020, 4, 22, 12, 56, 3, 231, DateTimeKind.Local).AddTicks(4590), "R$91,96", true, 0.2321380354613710m, 0L, "Rustic Steel Salad", true, 100, 31, "occyundkm123abkz", "expedita-accusantium-vel", "Good", true, "Shoes", 11.6292014306547000m, 2.1826282107190400m, 0.083286076822917013, 100, 16, new DateTime(2019, 8, 23, 20, 39, 19, 192, DateTimeKind.Local).AddTicks(5023), 19L },
                    { 24L, false, 0, 0, false, 7L, 2L, new DateTime(2018, 9, 27, 5, 20, 28, 779, DateTimeKind.Local).AddTicks(2136), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(653), new TimeSpan(0, 0, 0, 0, 0)), 10L, 0, 0, false, "Dolorem aut et amet velit aut qui et alias asperiores.", "R$194,67", new DateTime(2020, 7, 23, 15, 25, 39, 620, DateTimeKind.Local).AddTicks(3819), "R$44,26", true, 0.2697514916163640m, 0L, "Gorgeous Granite Chair", true, 24, 24, "af1kqrqh320dcvfy", "omnis-nisi-est", "Good", true, "Movies", 18.7064155557688000m, 5.120349533446300m, 0.60660611819783505, 56, 2, new DateTime(2019, 8, 24, 9, 20, 27, 341, DateTimeKind.Local).AddTicks(4816), 11L },
                    { 19L, false, 0, 0, false, 5L, 10L, new DateTime(2019, 1, 23, 7, 18, 27, 534, DateTimeKind.Local).AddTicks(2472), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, 0, 0, 0, 0)), 6L, 0, 0, false, "Voluptates quia fugiat beatae id dolorem sunt ex.", "R$20,15", new DateTime(2019, 11, 22, 7, 17, 23, 443, DateTimeKind.Local).AddTicks(7502), "R$78,38", true, 0.4262703128281380m, 0L, "Intelligent Concrete Pants", true, 88, 19, "4ypmftibjzb9msdt", "ullam-sint-est", "Good", true, "Industrial", 83.6943903862007000m, 5.4653517275421700m, 0.59626471465279562, 68, 0, new DateTime(2019, 8, 23, 18, 32, 33, 860, DateTimeKind.Local).AddTicks(3502), 11L },
                    { 16L, false, 0, 0, false, 7L, 10L, new DateTime(2018, 10, 27, 11, 26, 7, 777, DateTimeKind.Local).AddTicks(8527), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(7894), new TimeSpan(0, 0, 0, 0, 0)), 14L, 0, 0, false, @"Necessitatibus enim atque fugiat earum nostrum.
                Laboriosam quae optio repellendus voluptatum sed a.
                Vero tempore illum fugit sed.
                Ipsa culpa qui possimus.
                Et architecto nesciunt ratione et eos quos non.
                Quos accusamus temporibus nulla sed sit perspiciatis.", "R$132,30", new DateTime(2020, 6, 9, 3, 12, 10, 769, DateTimeKind.Local).AddTicks(6944), "R$12,90", true, 0.5259685695757940m, 0L, "Intelligent Frozen Table", true, 30, 16, "243vtfjradircmsh", "non-rerum-dolorem", "Good", true, "Garden", 85.6036529809254000m, 4.575230434804800m, 0.81076627867797679, 64, 38, new DateTime(2019, 8, 24, 18, 44, 10, 874, DateTimeKind.Local).AddTicks(8344), 11L },
                    { 6L, false, 0, 0, false, 8L, 2L, new DateTime(2019, 7, 31, 6, 23, 8, 159, DateTimeKind.Local).AddTicks(4991), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(3720), new TimeSpan(0, 0, 0, 0, 0)), 5L, 0, 0, false, "Voluptate et eveniet consequuntur dolores.", "R$137,26", new DateTime(2020, 8, 11, 3, 48, 42, 833, DateTimeKind.Local).AddTicks(2893), "R$43,54", true, 0.9477043663839360m, 0L, "Unbranded Metal Hat", true, 96, 6, "0asor8wsczyudvzr", "animi-dolores-provident", "Good", true, "Jewelery", 61.9646521573722000m, 5.559209541212400m, 0.35911439375910648, 54, 30, new DateTime(2019, 8, 25, 0, 12, 10, 868, DateTimeKind.Local).AddTicks(9759), 11L },
                    { 15L, false, 0, 0, false, 7L, 7L, new DateTime(2019, 1, 21, 10, 54, 53, 103, DateTimeKind.Local).AddTicks(1221), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(7629), new TimeSpan(0, 0, 0, 0, 0)), 2L, 0, 0, false, "atque", "R$113,47", new DateTime(2019, 12, 10, 1, 13, 35, 533, DateTimeKind.Local).AddTicks(2434), "R$25,42", true, 0.7753045432154580m, 0L, "Rustic Frozen Soap", true, 20, 15, "yaivve1nlv21bxul", "ex-dolore-eos", "Good", true, "Beauty", 88.7769226863873000m, 9.3752448583837800m, 0.076236519998049604, 70, 24, new DateTime(2019, 8, 24, 3, 47, 19, 566, DateTimeKind.Local).AddTicks(9271), 1L },
                    { 2L, false, 0, 0, false, 9L, 10L, new DateTime(2019, 3, 29, 13, 12, 54, 844, DateTimeKind.Local).AddTicks(4863), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(2117), new TimeSpan(0, 0, 0, 0, 0)), 11L, 0, 0, false, "Nam voluptas possimus nostrum eligendi sed. Harum vel velit pariatur ratione repudiandae non. Et et consequuntur omnis. Et culpa dolorem labore animi enim doloremque perferendis.", "R$56,90", new DateTime(2020, 3, 26, 20, 41, 45, 493, DateTimeKind.Local).AddTicks(2386), "R$65,96", true, 0.06627128416033060m, 0L, "Incredible Rubber Shoes", true, 32, 2, "nx6jr0ufdeo6ck8t", "qui-ad-illum", "Good", true, "Industrial", 50.2950522817183000m, 8.7813061656343300m, 0.74001695482992425, 68, 18, new DateTime(2019, 8, 24, 13, 52, 52, 846, DateTimeKind.Local).AddTicks(8717), 3L },
                    { 11L, false, 0, 0, false, 6L, 3L, new DateTime(2018, 11, 26, 10, 14, 44, 704, DateTimeKind.Local).AddTicks(8896), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(5730), new TimeSpan(0, 0, 0, 0, 0)), 7L, 0, 0, false, "Esse aut et facilis quae.", "R$12,27", new DateTime(2020, 6, 11, 4, 22, 39, 422, DateTimeKind.Local).AddTicks(3634), "R$69,17", true, 0.7112661361281140m, 0L, "Handmade Concrete Car", true, 90, 11, "ofgl8biasq5k3bb7", "eius-nam-officiis", "Good", true, "Electronics", 25.534857402339000m, 7.865179422248700m, 0.84048852689586973, 96, 26, new DateTime(2019, 8, 24, 1, 45, 37, 116, DateTimeKind.Local).AddTicks(7033), 3L },
                    { 20L, false, 0, 0, false, 4L, 6L, new DateTime(2018, 10, 29, 23, 24, 31, 735, DateTimeKind.Local).AddTicks(9692), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(9551), new TimeSpan(0, 0, 0, 0, 0)), 14L, 0, 0, false, "magnam", "R$39,66", new DateTime(2020, 1, 10, 16, 10, 28, 839, DateTimeKind.Local).AddTicks(1165), "R$32,54", true, 0.7076065287495060m, 0L, "Sleek Rubber Keyboard", true, 38, 20, "498qwzdkaxvv1z7w", "et-et-cupiditate", "Good", true, "Shoes", 54.2632581453134000m, 9.6183448795314600m, 0.097855447837084275, 74, 24, new DateTime(2019, 8, 24, 5, 29, 20, 499, DateTimeKind.Local).AddTicks(8051), 3L },
                    { 28L, false, 0, 0, false, 6L, 10L, new DateTime(2019, 1, 5, 18, 48, 20, 926, DateTimeKind.Local).AddTicks(5), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(1735), new TimeSpan(0, 0, 0, 0, 0)), 4L, 0, 0, false, "fugiat", "R$61,56", new DateTime(2019, 8, 26, 2, 27, 43, 124, DateTimeKind.Local).AddTicks(4145), "R$51,40", true, 0.3612095272919210m, 0L, "Awesome Metal Salad", true, 38, 28, "w1ddnt3girtovlgz", "voluptatibus-eos-nesciunt", "Good", true, "Baby", 66.3270205102521000m, 3.2425997700740600m, 0.050175691978156425, 66, 32, new DateTime(2019, 8, 24, 5, 37, 2, 53, DateTimeKind.Local).AddTicks(8389), 3L },
                    { 44L, false, 0, 0, false, 5L, 2L, new DateTime(2018, 11, 20, 21, 56, 21, 659, DateTimeKind.Local).AddTicks(409), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(7100), new TimeSpan(0, 0, 0, 0, 0)), 19L, 0, 0, false, "Nisi qui incidunt mollitia.", "R$141,48", new DateTime(2020, 5, 9, 7, 3, 35, 597, DateTimeKind.Local).AddTicks(1996), "R$38,68", true, 0.2614227343636670m, 0L, "Gorgeous Soft Towels", true, 16, 44, "hawdleuldp38ql78", "aspernatur-soluta-vero", "Good", true, "Jewelery", 93.2771615187066000m, 6.4275924425700600m, 0.22945374913022562, 78, 2, new DateTime(2019, 8, 24, 9, 19, 14, 828, DateTimeKind.Local).AddTicks(5547), 3L },
                    { 3L, false, 0, 0, false, 6L, 8L, new DateTime(2019, 5, 17, 15, 26, 17, 512, DateTimeKind.Local).AddTicks(9184), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(2687), new TimeSpan(0, 0, 0, 0, 0)), 17L, 0, 0, false, "incidunt", "R$64,46", new DateTime(2020, 2, 8, 3, 18, 15, 903, DateTimeKind.Local).AddTicks(2817), "R$2,85", true, 0.9730708696754050m, 0L, "Handmade Concrete Soap", true, 10, 3, "wk6ykhv287ix3lio", "eum-ipsum-non", "Good", true, "Industrial", 44.2303455175042000m, 3.4604690333178600m, 0.011263764934271465, 82, 28, new DateTime(2019, 8, 24, 5, 4, 28, 765, DateTimeKind.Local).AddTicks(9911), 4L },
                    { 35L, false, 0, 0, false, 6L, 5L, new DateTime(2018, 10, 26, 15, 50, 2, 874, DateTimeKind.Local).AddTicks(9134), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 0, 0, 0, 0)), 10L, 0, 0, false, "dolorem", "R$174,43", new DateTime(2020, 7, 30, 20, 25, 22, 697, DateTimeKind.Local).AddTicks(871), "R$38,92", true, 0.8498521190368810m, 0L, "Fantastic Granite Ball", true, 80, 35, "akzt8sdv95tm1myw", "optio-officiis-ipsam", "Good", true, "Outdoors", 90.9415151881713000m, 1.6617069494266600m, 0.80545211248353688, 74, 8, new DateTime(2019, 8, 24, 12, 9, 58, 779, DateTimeKind.Local).AddTicks(6161), 4L },
                    { 41L, false, 0, 0, false, 1L, 7L, new DateTime(2019, 5, 15, 21, 19, 23, 63, DateTimeKind.Local).AddTicks(7465), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(5872), new TimeSpan(0, 0, 0, 0, 0)), 18L, 0, 0, false, "dolores", "R$24,02", new DateTime(2020, 5, 9, 7, 16, 17, 721, DateTimeKind.Local).AddTicks(1243), "R$85,05", true, 0.6045405858217460m, 0L, "Handmade Granite Chair", true, 80, 41, "sqwg13fu8zb8kde4", "nesciunt-dolorem-recusandae", "Good", true, "Automotive", 93.3293826381347000m, 7.9520749384314200m, 0.96025233527657217, 70, 38, new DateTime(2019, 8, 23, 18, 5, 25, 934, DateTimeKind.Local).AddTicks(6710), 4L },
                    { 23L, false, 0, 0, false, 10L, 9L, new DateTime(2019, 8, 10, 17, 44, 35, 994, DateTimeKind.Local).AddTicks(5324), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(352), new TimeSpan(0, 0, 0, 0, 0)), 10L, 0, 0, false, "Quia quis aperiam aliquid fuga dolore qui sit voluptate.", "R$99,08", new DateTime(2020, 3, 31, 5, 53, 29, 979, DateTimeKind.Local).AddTicks(3875), "R$74,07", true, 0.5475551632920070m, 0L, "Incredible Soft Pants", true, 6, 23, "nxl5gsfdw6qd8270", "cupiditate-dolor-autem", "Good", true, "Shoes", 88.5216192754552000m, 2.2478071750364300m, 0.031278286609462594, 70, 48, new DateTime(2019, 8, 24, 9, 5, 10, 302, DateTimeKind.Local).AddTicks(8620), 5L },
                    { 47L, false, 0, 0, false, 2L, 5L, new DateTime(2019, 5, 21, 15, 4, 7, 112, DateTimeKind.Local).AddTicks(9780), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(8052), new TimeSpan(0, 0, 0, 0, 0)), 13L, 0, 0, false, "eum", "R$139,88", new DateTime(2019, 10, 16, 11, 18, 24, 663, DateTimeKind.Local).AddTicks(9989), "R$68,41", true, 0.161038780194260m, 0L, "Practical Plastic Chips", true, 22, 47, "wwywdrl08sfwoyre", "eos-asperiores-doloremque", "Good", true, "Jewelery", 68.2362967022864000m, 1.3749562536249700m, 0.8378037767660822, 90, 26, new DateTime(2019, 8, 24, 12, 14, 55, 423, DateTimeKind.Local).AddTicks(6083), 19L },
                    { 25L, false, 0, 0, false, 7L, 10L, new DateTime(2019, 1, 29, 16, 25, 24, 108, DateTimeKind.Local).AddTicks(5110), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(919), new TimeSpan(0, 0, 0, 0, 0)), 3L, 0, 0, false, "Tempora nostrum recusandae possimus illo.", "R$199,45", new DateTime(2019, 12, 31, 16, 9, 56, 422, DateTimeKind.Local).AddTicks(6977), "R$86,46", true, 0.4038791039045340m, 0L, "Licensed Soft Ball", true, 34, 25, "ftlnlf2p4jbt8row", "sed-ab-dolore", "Good", true, "Movies", 20.9471249119132000m, 8.3571113917776900m, 0.37456848443232871, 82, 12, new DateTime(2019, 8, 24, 5, 29, 20, 67, DateTimeKind.Local).AddTicks(7584), 5L },
                    { 50L, false, 0, 0, false, 6L, 4L, new DateTime(2019, 5, 26, 19, 59, 28, 54, DateTimeKind.Local).AddTicks(511), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(9402), new TimeSpan(0, 0, 0, 0, 0)), 19L, 0, 0, false, @"Et occaecati dolor possimus laudantium quia quis.
                Nostrum necessitatibus aut qui nihil beatae quia ipsum commodi mollitia.
                Sit possimus nobis laboriosam id illo amet.
                Qui saepe voluptas qui.
                Eaque rem provident voluptates dolorum.", "R$36,76", new DateTime(2019, 11, 28, 9, 50, 49, 749, DateTimeKind.Local).AddTicks(7201), "R$61,40", true, 0.0477555059118920m, 0L, "Gorgeous Soft Fish", true, 74, 50, "v9230agtc9w0s2lf", "in-consequatur-rerum", "Good", true, "Electronics", 96.0666699316663000m, 3.7128871417198700m, 0.093095554547894532, 66, 4, new DateTime(2019, 8, 24, 17, 18, 22, 774, DateTimeKind.Local).AddTicks(7332), 5L },
                    { 30L, false, 0, 0, false, 2L, 2L, new DateTime(2019, 4, 1, 20, 26, 3, 871, DateTimeKind.Local).AddTicks(6553), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(2333), new TimeSpan(0, 0, 0, 0, 0)), 14L, 0, 0, false, "saepe", "R$53,71", new DateTime(2019, 10, 7, 0, 33, 29, 93, DateTimeKind.Local).AddTicks(3359), "R$11,96", true, 0.49737229919870m, 0L, "Practical Steel Computer", true, 84, 30, "71zter6gn6p19u9p", "excepturi-hic-rem", "Good", true, "Computers", 37.488756253146000m, 4.5050636047986600m, 0.78021810100424016, 66, 2, new DateTime(2019, 8, 24, 4, 19, 6, 878, DateTimeKind.Local).AddTicks(2382), 6L },
                    { 48L, false, 0, 0, false, 7L, 7L, new DateTime(2019, 5, 15, 13, 2, 25, 919, DateTimeKind.Local).AddTicks(7400), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(8318), new TimeSpan(0, 0, 0, 0, 0)), 6L, 0, 0, false, @"Voluptas aut explicabo rerum vitae illum omnis.
                Modi dolores non aut aut eveniet cum ipsa.", "R$118,76", new DateTime(2020, 7, 6, 3, 6, 14, 627, DateTimeKind.Local).AddTicks(2091), "R$4,30", true, 0.4533050854007270m, 0L, "Intelligent Wooden Hat", true, 8, 48, "j81nxvlvej7or92k", "magnam-qui-dolor", "Good", true, "Beauty", 63.1280176635496000m, 2.7563159180601700m, 0.25170601264187414, 58, 4, new DateTime(2019, 8, 25, 2, 15, 47, 265, DateTimeKind.Local).AddTicks(4184), 7L },
                    { 45L, false, 0, 0, false, 4L, 7L, new DateTime(2018, 12, 21, 22, 2, 12, 896, DateTimeKind.Local).AddTicks(682), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(7351), new TimeSpan(0, 0, 0, 0, 0)), 12L, 0, 0, false, "dolorum", "R$100,44", new DateTime(2020, 3, 4, 17, 35, 51, 625, DateTimeKind.Local).AddTicks(8765), "R$78,59", true, 0.4474680206959450m, 0L, "Sleek Granite Ball", true, 34, 45, "zqoe0eucne1as47d", "commodi-consequatur-ratione", "Good", true, "Computers", 46.4538065001619000m, 0.74052073561610700m, 0.30747961360378173, 54, 2, new DateTime(2019, 8, 24, 6, 55, 12, 609, DateTimeKind.Local).AddTicks(9485), 8L },
                    { 5L, false, 0, 0, false, 9L, 1L, new DateTime(2019, 2, 20, 5, 18, 47, 204, DateTimeKind.Local).AddTicks(6328), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(3376), new TimeSpan(0, 0, 0, 0, 0)), 16L, 0, 0, false, @"Incidunt cum illo magni delectus est.
                Accusamus rem quis ratione.", "R$106,13", new DateTime(2020, 1, 11, 0, 45, 15, 477, DateTimeKind.Local).AddTicks(9948), "R$86,18", true, 0.4515349983477660m, 0L, "Generic Rubber Gloves", true, 48, 5, "00ebk8w09kn0zck8", "fuga-architecto-accusamus", "Good", true, "Baby", 12.7275209001859000m, 0.074559524690061600m, 0.5182823760054458, 94, 24, new DateTime(2019, 8, 25, 3, 56, 15, 84, DateTimeKind.Local).AddTicks(2475), 9L },
                    { 26L, false, 0, 0, false, 7L, 9L, new DateTime(2019, 8, 2, 4, 41, 22, 249, DateTimeKind.Local).AddTicks(5311), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(1203), new TimeSpan(0, 0, 0, 0, 0)), 3L, 0, 0, false, "Aut autem alias voluptatibus saepe est.", "R$179,43", new DateTime(2019, 12, 9, 4, 44, 58, 394, DateTimeKind.Local).AddTicks(2473), "R$59,78", true, 0.6512297986313840m, 0L, "Small Concrete Shirt", true, 12, 26, "fjp13zday9ogq73i", "ipsam-perferendis-et", "Good", true, "Books", 68.074377564748000m, 6.4665598219570500m, 0.70002879933455442, 74, 30, new DateTime(2019, 8, 24, 13, 28, 22, 308, DateTimeKind.Local).AddTicks(5847), 9L },
                    { 1L, false, 0, 0, false, 8L, 10L, new DateTime(2019, 2, 7, 22, 43, 40, 676, DateTimeKind.Local).AddTicks(1414), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 490, DateTimeKind.Unspecified).AddTicks(8424), new TimeSpan(0, 0, 0, 0, 0)), 1L, 0, 0, false, "Debitis minus ullam est.", "R$166,97", new DateTime(2019, 9, 15, 20, 51, 26, 761, DateTimeKind.Local).AddTicks(9664), "R$24,20", true, 0.2213346810179460m, 0L, "Handcrafted Wooden Computer", true, 34, 1, "f5puofelzgogkg75", "quidem-et-atque", "Good", true, "Kids", 30.6570036945199000m, 4.2179038022728200m, 0.29016060162808777, 64, 12, new DateTime(2019, 8, 24, 7, 56, 16, 453, DateTimeKind.Local).AddTicks(8078), 10L },
                    { 10L, false, 0, 0, false, 7L, 5L, new DateTime(2019, 8, 22, 7, 38, 21, 483, DateTimeKind.Local).AddTicks(8569), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(5211), new TimeSpan(0, 0, 0, 0, 0)), 8L, 0, 0, false, @"Rerum soluta incidunt.
                Iusto at ut labore est provident ipsum et.
                Rerum quis est dolores sapiente.
                Totam rerum delectus voluptatem repellendus inventore consectetur perspiciatis voluptas tenetur.
                Consequatur accusantium cum dolor voluptas veritatis quos minima exercitationem voluptatem.", "R$10,81", new DateTime(2020, 2, 1, 22, 44, 9, 788, DateTimeKind.Local).AddTicks(2919), "R$25,78", true, 0.1793774912037780m, 0L, "Ergonomic Concrete Salad", true, 96, 10, "swgumv3y5me6yqqx", "minus-officiis-animi", "Good", true, "Home", 11.3438711554482000m, 5.3908466386566200m, 0.38956307684516678, 54, 16, new DateTime(2019, 8, 23, 23, 10, 58, 674, DateTimeKind.Local).AddTicks(1164), 10L },
                    { 21L, false, 0, 0, false, 7L, 3L, new DateTime(2019, 2, 20, 5, 21, 43, 147, DateTimeKind.Local).AddTicks(3766), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(9777), new TimeSpan(0, 0, 0, 0, 0)), 17L, 0, 0, false, "doloremque", "R$93,77", new DateTime(2020, 6, 17, 4, 41, 0, 97, DateTimeKind.Local).AddTicks(5430), "R$12,82", true, 0.727782107297230m, 0L, "Unbranded Concrete Chair", true, 28, 21, "991oeytdyhvscvq3", "aut-quo-harum", "Good", true, "Toys", 54.9337027384591000m, 4.0263725044328600m, 0.78809454328757456, 84, 18, new DateTime(2019, 8, 24, 4, 43, 42, 894, DateTimeKind.Local).AddTicks(2319), 10L },
                    { 42L, false, 0, 0, false, 9L, 2L, new DateTime(2019, 8, 6, 22, 10, 10, 76, DateTimeKind.Local).AddTicks(8065), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(6145), new TimeSpan(0, 0, 0, 0, 0)), 14L, 0, 0, false, "Eligendi quis harum voluptas perferendis pariatur. Ullam nobis quidem ut qui. Ut perferendis provident tenetur nihil. Vel sequi et aliquam magni odit velit iusto deserunt libero. Suscipit voluptatem veniam eos vel quia. Saepe voluptatum veritatis vero aut dolor dolores repellendus officia consequatur.", "R$44,79", new DateTime(2019, 11, 14, 13, 0, 3, 834, DateTimeKind.Local).AddTicks(1755), "R$81,55", true, 0.3499007696983870m, 0L, "Tasty Rubber Ball", true, 32, 42, "09fq7tjfyx3i2pjn", "quos-voluptates-ipsum", "Good", true, "Tools", 22.8435505753586000m, 7.8249139514867800m, 0.88285979576542029, 50, 32, new DateTime(2019, 8, 25, 10, 19, 15, 689, DateTimeKind.Local).AddTicks(3794), 10L },
                    { 33L, false, 0, 0, false, 1L, 6L, new DateTime(2018, 9, 7, 2, 7, 42, 767, DateTimeKind.Local).AddTicks(1978), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 492, DateTimeKind.Unspecified).AddTicks(3533), new TimeSpan(0, 0, 0, 0, 0)), 20L, 0, 0, false, "Non est qui expedita blanditiis quidem.", "R$153,80", new DateTime(2020, 2, 9, 11, 5, 35, 789, DateTimeKind.Local).AddTicks(6701), "R$76,05", true, 0.867307450560530m, 0L, "Practical Cotton Tuna", true, 62, 33, "1edo46moe634prj2", "et-earum-dolore", "Good", true, "Industrial", 4.21673762808402000m, 9.1356211244760200m, 0.36467019485527191, 66, 40, new DateTime(2019, 8, 24, 21, 31, 20, 706, DateTimeKind.Local).AddTicks(6825), 5L },
                    { 22L, false, 0, 0, false, 2L, 3L, new DateTime(2019, 3, 8, 16, 13, 50, 341, DateTimeKind.Local).AddTicks(762), 0m, false, false, false, new DateTimeOffset(new DateTime(2019, 8, 24, 15, 8, 25, 491, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 0, 0, 0, 0)), 10L, 0, 0, false, "Quasi quae non inventore ab. Fugiat rerum nihil autem optio nostrum sit. Quia vero ut.", "R$186,22", new DateTime(2020, 8, 21, 12, 1, 32, 19, DateTimeKind.Local).AddTicks(1993), "R$93,53", true, 0.9398355134482660m, 0L, "Handmade Plastic Shoes", true, 40, 22, "auinfctao6zuhvqt", "blanditiis-dolorem-molestiae", "Good", true, "Garden", 84.6378441362818000m, 0.6018285409555900m, 0.038300707022799509, 66, 34, new DateTime(2019, 8, 25, 0, 39, 16, 747, DateTimeKind.Local).AddTicks(7824), 20L }
                });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 3, 12, 21, 52, 262, DateTimeKind.Unspecified).AddTicks(6789), new TimeSpan(0, -3, 0, 0, 0)), 30L, 23L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 13, 18, 32, 57, 791, DateTimeKind.Unspecified).AddTicks(2787), new TimeSpan(0, -3, 0, 0, 0)), 14L, 34L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 15, 23, 36, 23, 202, DateTimeKind.Unspecified).AddTicks(7475), new TimeSpan(0, -3, 0, 0, 0)), 41L, 23L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 18, 13, 16, 24, 617, DateTimeKind.Unspecified).AddTicks(8988), new TimeSpan(0, -3, 0, 0, 0)), 3L, 32L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 11, 10, 21, 26, 837, DateTimeKind.Unspecified).AddTicks(5416), new TimeSpan(0, -3, 0, 0, 0)), 1L, 37L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 13, 2, 46, 21, 361, DateTimeKind.Unspecified).AddTicks(2573), new TimeSpan(0, -3, 0, 0, 0)), 16L, 33L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 8, 21, 26, 49, 504, DateTimeKind.Unspecified).AddTicks(3879), new TimeSpan(0, -3, 0, 0, 0)), 23L, 25L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 3, 8, 43, 58, 783, DateTimeKind.Unspecified).AddTicks(4112), new TimeSpan(0, -3, 0, 0, 0)), 3L, 40L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 10, 3, 52, 8, 172, DateTimeKind.Unspecified).AddTicks(1285), new TimeSpan(0, -3, 0, 0, 0)), 14L, 40L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 4, 1, 7, 4, 759, DateTimeKind.Unspecified).AddTicks(162), new TimeSpan(0, -3, 0, 0, 0)), 38L, 14L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 22, 19, 6, 17, 474, DateTimeKind.Unspecified).AddTicks(7756), new TimeSpan(0, -3, 0, 0, 0)), 48L, 43L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 4, 8, 41, 50, 367, DateTimeKind.Unspecified).AddTicks(4236), new TimeSpan(0, -3, 0, 0, 0)), 28L, 44L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 23, 5, 26, 7, 191, DateTimeKind.Unspecified).AddTicks(6078), new TimeSpan(0, -3, 0, 0, 0)), 8L, 49L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 5, 21, 36, 26, 935, DateTimeKind.Unspecified).AddTicks(435), new TimeSpan(0, -3, 0, 0, 0)), 36L, 17L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastModified", "LinkedProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 4, 0, 40, 8, 374, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, -3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 14, 9, 48, 22, 838, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, -3, 0, 0, 0)), 49L, 1L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 4, 0, 56, 58, 187, DateTimeKind.Unspecified).AddTicks(2018), new TimeSpan(0, -3, 0, 0, 0)), 41L, 31L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 15, 14, 14, 28, 982, DateTimeKind.Unspecified).AddTicks(1178), new TimeSpan(0, -3, 0, 0, 0)), 17L, 50L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 11, 21, 38, 19, 379, DateTimeKind.Unspecified).AddTicks(3503), new TimeSpan(0, -3, 0, 0, 0)), 50L, 27L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 8, 3, 20, 15, 268, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, -3, 0, 0, 0)), 43L, 50L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 2, 18, 43, 10, 268, DateTimeKind.Unspecified).AddTicks(979), new TimeSpan(0, -3, 0, 0, 0)), 27L, 4L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 19, 20, 12, 4, 74, DateTimeKind.Unspecified).AddTicks(4574), new TimeSpan(0, -3, 0, 0, 0)), 9L, 6L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 5, 1, 14, 1, 826, DateTimeKind.Unspecified).AddTicks(9317), new TimeSpan(0, -3, 0, 0, 0)), 36L, 23L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 3, 0, 57, 22, 305, DateTimeKind.Unspecified).AddTicks(8622), new TimeSpan(0, -3, 0, 0, 0)), 21L, 8L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 7, 11, 45, 26, 361, DateTimeKind.Unspecified).AddTicks(1984), new TimeSpan(0, -3, 0, 0, 0)), 45L, 38L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 20, 13, 1, 17, 423, DateTimeKind.Unspecified).AddTicks(3823), new TimeSpan(0, -3, 0, 0, 0)), 2L, 50L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 23, 12, 32, 0, 231, DateTimeKind.Unspecified).AddTicks(5076), new TimeSpan(0, -3, 0, 0, 0)), 9L, 16L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 4, 22, 18, 12, 122, DateTimeKind.Unspecified).AddTicks(5474), new TimeSpan(0, -3, 0, 0, 0)), 50L, 47L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 8, 6, 26, 37, 215, DateTimeKind.Unspecified).AddTicks(4324), new TimeSpan(0, -3, 0, 0, 0)), 36L, 32L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 2, 22, 3, 13, 169, DateTimeKind.Unspecified).AddTicks(2317), new TimeSpan(0, -3, 0, 0, 0)), 16L, 29L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 16, 4, 6, 53, 801, DateTimeKind.Unspecified).AddTicks(8042), new TimeSpan(0, -3, 0, 0, 0)), 20L, 16L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 7, 31, 0, 18, 49, 207, DateTimeKind.Unspecified).AddTicks(267), new TimeSpan(0, -3, 0, 0, 0)), 44L, 10L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 13, 41, 41, 786, DateTimeKind.Unspecified).AddTicks(2767), new TimeSpan(0, -3, 0, 0, 0)), 32L, 45L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 8, 10, 41, 28, 188, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, -3, 0, 0, 0)), 32L, 13L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 10, 10, 50, 13, 377, DateTimeKind.Unspecified).AddTicks(1465), new TimeSpan(0, -3, 0, 0, 0)), 49L, 21L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 13, 4, 13, 7, 531, DateTimeKind.Unspecified).AddTicks(744), new TimeSpan(0, -3, 0, 0, 0)), 34L, 23L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 18, 12, 46, 37, 612, DateTimeKind.Unspecified).AddTicks(151), new TimeSpan(0, -3, 0, 0, 0)), 18L, 49L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 10, 17, 37, 20, 810, DateTimeKind.Unspecified).AddTicks(5539), new TimeSpan(0, -3, 0, 0, 0)), 31L, 35L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 7, 5, 41, 40, 215, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, -3, 0, 0, 0)), 5L, 27L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastModified", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 21, 5, 43, 45, 999, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, -3, 0, 0, 0)), 23L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 12, 12, 13, 56, 730, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, -3, 0, 0, 0)), 46L, 21L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 2, 10, 36, 59, 233, DateTimeKind.Unspecified).AddTicks(4573), new TimeSpan(0, -3, 0, 0, 0)), 27L, 1L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 3, 1, 32, 11, 643, DateTimeKind.Unspecified).AddTicks(8162), new TimeSpan(0, -3, 0, 0, 0)), 36L, 1L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 10, 18, 9, 9, 928, DateTimeKind.Unspecified).AddTicks(1607), new TimeSpan(0, -3, 0, 0, 0)), 45L, 20L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 22, 8, 18, 55, 886, DateTimeKind.Unspecified).AddTicks(1171), new TimeSpan(0, -3, 0, 0, 0)), 20L, 28L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 23, 3, 17, 42, 158, DateTimeKind.Unspecified).AddTicks(735), new TimeSpan(0, -3, 0, 0, 0)), 12L, 2L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastModified", "LinkedProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 11, 13, 50, 3, 881, DateTimeKind.Unspecified).AddTicks(431), new TimeSpan(0, -3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 20, 4, 10, 28, 10, DateTimeKind.Unspecified).AddTicks(5937), new TimeSpan(0, -3, 0, 0, 0)), 32L, 48L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 9, 13, 22, 51, 546, DateTimeKind.Unspecified).AddTicks(719), new TimeSpan(0, -3, 0, 0, 0)), 40L, 40L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 9, 2, 12, 18, 851, DateTimeKind.Unspecified).AddTicks(3858), new TimeSpan(0, -3, 0, 0, 0)), 15L, 40L });

            migrationBuilder.CreateIndex(
                name: "IX_StormyProduct_CategoryId",
                table: "StormyProduct",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StormyProduct_MediaId",
                table: "StormyProduct",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_StormyProductId",
                table: "Media",
                column: "StormyProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_StormyProduct_StormyProductId",
                table: "Media",
                column: "StormyProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLink_StormyProduct_ProductId",
                table: "ProductLink",
                column: "ProductId",
                principalTable: "StormyProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StormyProduct_Media_MediaId",
                table: "StormyProduct",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
