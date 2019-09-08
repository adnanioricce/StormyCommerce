using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplCommerce.WebHost.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 5, 8, 6, 46, 318, DateTimeKind.Unspecified).AddTicks(5035), new TimeSpan(0, -3, 0, 0, 0)), 49L, 43L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 15, 14, 54, 9, 583, DateTimeKind.Unspecified).AddTicks(2114), new TimeSpan(0, -3, 0, 0, 0)), 10L, 48L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 30, 4, 49, 14, 663, DateTimeKind.Unspecified).AddTicks(1908), new TimeSpan(0, -3, 0, 0, 0)), 49L, 20L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 3, 5, 25, 59, 272, DateTimeKind.Unspecified).AddTicks(5212), new TimeSpan(0, -3, 0, 0, 0)), 29L, 26L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 29, 22, 8, 42, 188, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, -3, 0, 0, 0)), 26L, 49L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 25, 19, 22, 7, 38, DateTimeKind.Unspecified).AddTicks(9822), new TimeSpan(0, -3, 0, 0, 0)), 9L, 12L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 5, 8, 14, 37, 774, DateTimeKind.Unspecified).AddTicks(5222), new TimeSpan(0, -3, 0, 0, 0)), 9L, 21L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 6, 9, 40, 43, 247, DateTimeKind.Unspecified).AddTicks(5360), new TimeSpan(0, -3, 0, 0, 0)), 37L, 28L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 21, 39, 22, 743, DateTimeKind.Unspecified).AddTicks(7110), new TimeSpan(0, -3, 0, 0, 0)), 11L, 44L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 30, 10, 13, 18, 751, DateTimeKind.Unspecified).AddTicks(783), new TimeSpan(0, -3, 0, 0, 0)), 46L, 41L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 18, 23, 4, 11, 562, DateTimeKind.Unspecified).AddTicks(5467), new TimeSpan(0, -3, 0, 0, 0)), 5L, 16L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 28, 14, 47, 45, 244, DateTimeKind.Unspecified).AddTicks(7180), new TimeSpan(0, -3, 0, 0, 0)), 18L, 16L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastModified", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 5, 21, 38, 41, 171, DateTimeKind.Unspecified).AddTicks(1062), new TimeSpan(0, -3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 23, 12, 16, 57, 979, DateTimeKind.Unspecified).AddTicks(7714), new TimeSpan(0, -3, 0, 0, 0)), 20L, 19L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 1, 23, 57, 1, 522, DateTimeKind.Unspecified).AddTicks(9162), new TimeSpan(0, -3, 0, 0, 0)), 50L, 44L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 1, 11, 53, 57, 627, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, -3, 0, 0, 0)), 40L, 5L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 28, 22, 11, 20, 619, DateTimeKind.Unspecified).AddTicks(3928), new TimeSpan(0, -3, 0, 0, 0)), 31L, 47L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 4, 4, 54, 34, 766, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, -3, 0, 0, 0)), 17L, 13L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 6, 11, 23, 11, 250, DateTimeKind.Unspecified).AddTicks(8377), new TimeSpan(0, -3, 0, 0, 0)), 3L, 13L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 1, 10, 33, 44, 310, DateTimeKind.Unspecified).AddTicks(9877), new TimeSpan(0, -3, 0, 0, 0)), 5L, 50L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 6, 9, 33, 8, 49, DateTimeKind.Unspecified).AddTicks(8835), new TimeSpan(0, -3, 0, 0, 0)), 1L, 3L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 25, 9, 58, 56, 718, DateTimeKind.Unspecified).AddTicks(3731), new TimeSpan(0, -3, 0, 0, 0)), 20L, 24L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 4, 2, 18, 7, 872, DateTimeKind.Unspecified).AddTicks(3553), new TimeSpan(0, -3, 0, 0, 0)), 48L, 8L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 23, 2, 18, 47, 759, DateTimeKind.Unspecified).AddTicks(460), new TimeSpan(0, -3, 0, 0, 0)), 23L, 16L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 6, 18, 37, 57, 433, DateTimeKind.Unspecified).AddTicks(588), new TimeSpan(0, -3, 0, 0, 0)), 25L, 40L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 8, 3, 7, 44, 78, DateTimeKind.Unspecified).AddTicks(8000), new TimeSpan(0, -3, 0, 0, 0)), 42L, 37L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 23, 1, 40, 43, 824, DateTimeKind.Unspecified).AddTicks(5567), new TimeSpan(0, -3, 0, 0, 0)), 30L, 21L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 20, 14, 26, 23, 891, DateTimeKind.Unspecified).AddTicks(8754), new TimeSpan(0, -3, 0, 0, 0)), 47L, 16L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 19, 44, 44, 458, DateTimeKind.Unspecified).AddTicks(8140), new TimeSpan(0, -3, 0, 0, 0)), 33L, 39L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 7, 5, 35, 29, 557, DateTimeKind.Unspecified).AddTicks(6658), new TimeSpan(0, -3, 0, 0, 0)), 18L, 16L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 7, 7, 1, 43, 371, DateTimeKind.Unspecified).AddTicks(8934), new TimeSpan(0, -3, 0, 0, 0)), 42L, 39L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 4, 10, 27, 2, 471, DateTimeKind.Unspecified).AddTicks(8903), new TimeSpan(0, -3, 0, 0, 0)), 28L, 19L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 31, 18, 44, 22, 710, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, -3, 0, 0, 0)), 35L, 31L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 29, 8, 57, 44, 667, DateTimeKind.Unspecified).AddTicks(8026), new TimeSpan(0, -3, 0, 0, 0)), 6L, 43L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastModified", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 16, 3, 17, 35, 677, DateTimeKind.Unspecified).AddTicks(1477), new TimeSpan(0, -3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 24, 2, 10, 45, 21, DateTimeKind.Unspecified).AddTicks(9364), new TimeSpan(0, -3, 0, 0, 0)), 6L, 42L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 28, 5, 10, 54, 842, DateTimeKind.Unspecified).AddTicks(883), new TimeSpan(0, -3, 0, 0, 0)), 4L, 11L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 27, 2, 8, 57, 152, DateTimeKind.Unspecified).AddTicks(2398), new TimeSpan(0, -3, 0, 0, 0)), 32L, 26L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 25, 10, 32, 24, 515, DateTimeKind.Unspecified).AddTicks(8297), new TimeSpan(0, -3, 0, 0, 0)), 17L, 4L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 21, 4, 7, 33, 152, DateTimeKind.Unspecified).AddTicks(9596), new TimeSpan(0, -3, 0, 0, 0)), 35L, 37L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 22, 14, 13, 59, 948, DateTimeKind.Unspecified).AddTicks(2932), new TimeSpan(0, -3, 0, 0, 0)), 7L, 30L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 18, 21, 37, 17, 280, DateTimeKind.Unspecified).AddTicks(9292), new TimeSpan(0, -3, 0, 0, 0)), 31L, 32L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 26, 12, 53, 10, 942, DateTimeKind.Unspecified).AddTicks(6932), new TimeSpan(0, -3, 0, 0, 0)), 46L, 47L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 29, 11, 22, 46, 110, DateTimeKind.Unspecified).AddTicks(2796), new TimeSpan(0, -3, 0, 0, 0)), 36L, 7L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 5, 10, 33, 30, 682, DateTimeKind.Unspecified).AddTicks(5779), new TimeSpan(0, -3, 0, 0, 0)), 13L, 24L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 25, 14, 16, 17, 655, DateTimeKind.Unspecified).AddTicks(6282), new TimeSpan(0, -3, 0, 0, 0)), 42L, 9L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 5, 3, 31, 59, 497, DateTimeKind.Unspecified).AddTicks(814), new TimeSpan(0, -3, 0, 0, 0)), 13L, 28L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 16, 8, 24, 58, 707, DateTimeKind.Unspecified).AddTicks(3143), new TimeSpan(0, -3, 0, 0, 0)), 30L, 15L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 6, 9, 44, 47, 379, DateTimeKind.Unspecified).AddTicks(3139), new TimeSpan(0, -3, 0, 0, 0)), 28L, 10L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 2, 0, 22, 23, 905, DateTimeKind.Unspecified).AddTicks(6387), new TimeSpan(0, -3, 0, 0, 0)), 31L, 12L });

            migrationBuilder.UpdateData(
                table: "Shipment",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModified", "TrackNumber" },
                values: new object[] { new DateTime(2019, 9, 8, 21, 58, 21, 851, DateTimeKind.Utc).AddTicks(9557), new DateTimeOffset(new DateTime(2019, 9, 8, 21, 58, 21, 851, DateTimeKind.Unspecified).AddTicks(9166), new TimeSpan(0, 0, 0, 0, 0)), "8e825c7f-faba-47fd-a31f-8489e300141d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 22, 9, 4, 5, 745, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, -3, 0, 0, 0)), 22L, 47L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 27, 9, 31, 4, 402, DateTimeKind.Unspecified).AddTicks(14), new TimeSpan(0, -3, 0, 0, 0)), 29L, 8L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 29, 5, 29, 20, 686, DateTimeKind.Unspecified).AddTicks(9134), new TimeSpan(0, -3, 0, 0, 0)), 48L, 12L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 31, 4, 54, 10, 948, DateTimeKind.Unspecified).AddTicks(493), new TimeSpan(0, -3, 0, 0, 0)), 34L, 31L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 29, 21, 8, 24, 239, DateTimeKind.Unspecified).AddTicks(7172), new TimeSpan(0, -3, 0, 0, 0)), 15L, 12L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 7, 23, 8, 38, 660, DateTimeKind.Unspecified).AddTicks(5402), new TimeSpan(0, -3, 0, 0, 0)), 2L, 25L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 5, 3, 2, 56, 560, DateTimeKind.Unspecified).AddTicks(1995), new TimeSpan(0, -3, 0, 0, 0)), 46L, 15L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 23, 7, 19, 47, 466, DateTimeKind.Unspecified).AddTicks(8032), new TimeSpan(0, -3, 0, 0, 0)), 27L, 6L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 21, 54, 41, 748, DateTimeKind.Unspecified).AddTicks(8663), new TimeSpan(0, -3, 0, 0, 0)), 15L, 49L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 21, 7, 7, 37, 792, DateTimeKind.Unspecified).AddTicks(3941), new TimeSpan(0, -3, 0, 0, 0)), 25L, 26L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 8, 13, 43, 34, 613, DateTimeKind.Unspecified).AddTicks(183), new TimeSpan(0, -3, 0, 0, 0)), 18L, 26L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 24, 3, 47, 16, 579, DateTimeKind.Unspecified).AddTicks(5471), new TimeSpan(0, -3, 0, 0, 0)), 5L, 12L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastModified", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 27, 20, 39, 1, 63, DateTimeKind.Unspecified).AddTicks(5920), new TimeSpan(0, -3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 3, 5, 59, 47, 576, DateTimeKind.Unspecified).AddTicks(6657), new TimeSpan(0, -3, 0, 0, 0)), 1L, 18L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 26, 2, 59, 59, 513, DateTimeKind.Unspecified).AddTicks(1115), new TimeSpan(0, -3, 0, 0, 0)), 38L, 50L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 29, 18, 35, 54, 110, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, -3, 0, 0, 0)), 29L, 21L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 20, 16, 11, 32, 847, DateTimeKind.Unspecified).AddTicks(6615), new TimeSpan(0, -3, 0, 0, 0)), 39L, 10L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 22, 9, 52, 15, 460, DateTimeKind.Unspecified).AddTicks(7806), new TimeSpan(0, -3, 0, 0, 0)), 8L, 48L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 25, 7, 55, 55, 384, DateTimeKind.Unspecified).AddTicks(3378), new TimeSpan(0, -3, 0, 0, 0)), 2L, 45L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 19, 5, 11, 38, 410, DateTimeKind.Unspecified).AddTicks(3215), new TimeSpan(0, -3, 0, 0, 0)), 32L, 15L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 4, 2, 3, 20, 521, DateTimeKind.Unspecified).AddTicks(4085), new TimeSpan(0, -3, 0, 0, 0)), 35L, 24L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 21, 16, 49, 35, 721, DateTimeKind.Unspecified).AddTicks(1625), new TimeSpan(0, -3, 0, 0, 0)), 17L, 17L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 6, 4, 46, 57, 664, DateTimeKind.Unspecified).AddTicks(1471), new TimeSpan(0, -3, 0, 0, 0)), 39L, 11L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 14, 16, 45, 5, 428, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, -3, 0, 0, 0)), 28L, 8L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 29, 13, 7, 8, 765, DateTimeKind.Unspecified).AddTicks(7586), new TimeSpan(0, -3, 0, 0, 0)), 47L, 46L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 16, 4, 59, 46, 455, DateTimeKind.Unspecified).AddTicks(4803), new TimeSpan(0, -3, 0, 0, 0)), 6L, 40L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 5, 12, 31, 31, 89, DateTimeKind.Unspecified).AddTicks(6095), new TimeSpan(0, -3, 0, 0, 0)), 24L, 36L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 25, 13, 36, 15, 791, DateTimeKind.Unspecified).AddTicks(6175), new TimeSpan(0, -3, 0, 0, 0)), 49L, 37L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 31, 12, 52, 57, 422, DateTimeKind.Unspecified).AddTicks(8120), new TimeSpan(0, -3, 0, 0, 0)), 16L, 10L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 25, 13, 14, 1, 964, DateTimeKind.Unspecified).AddTicks(6190), new TimeSpan(0, -3, 0, 0, 0)), 3L, 3L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 31, 11, 45, 18, 322, DateTimeKind.Unspecified).AddTicks(9259), new TimeSpan(0, -3, 0, 0, 0)), 33L, 13L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 19, 18, 14, 17, 203, DateTimeKind.Unspecified).AddTicks(1479), new TimeSpan(0, -3, 0, 0, 0)), 2L, 16L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 8, 14, 49, 615, DateTimeKind.Unspecified).AddTicks(8465), new TimeSpan(0, -3, 0, 0, 0)), 42L, 21L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 23, 5, 39, 51, 924, DateTimeKind.Unspecified).AddTicks(916), new TimeSpan(0, -3, 0, 0, 0)), 15L, 41L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastModified", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 3, 14, 52, 23, 933, DateTimeKind.Unspecified).AddTicks(3081), new TimeSpan(0, -3, 0, 0, 0)), 11L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 7, 17, 4, 11, 331, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, -3, 0, 0, 0)), 15L, 12L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 7, 17, 37, 24, 506, DateTimeKind.Unspecified).AddTicks(7349), new TimeSpan(0, -3, 0, 0, 0)), 32L, 47L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 5, 18, 21, 4, 512, DateTimeKind.Unspecified).AddTicks(4033), new TimeSpan(0, -3, 0, 0, 0)), 35L, 8L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 25, 1, 8, 38, 245, DateTimeKind.Unspecified).AddTicks(7621), new TimeSpan(0, -3, 0, 0, 0)), 31L, 36L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 21, 5, 22, 41, 235, DateTimeKind.Unspecified).AddTicks(4330), new TimeSpan(0, -3, 0, 0, 0)), 20L, 2L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 4, 21, 51, 1, 118, DateTimeKind.Unspecified).AddTicks(6862), new TimeSpan(0, -3, 0, 0, 0)), 27L, 37L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 4, 16, 40, 54, 767, DateTimeKind.Unspecified).AddTicks(1783), new TimeSpan(0, -3, 0, 0, 0)), 34L, 46L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 10, 37, 28, 455, DateTimeKind.Unspecified).AddTicks(9989), new TimeSpan(0, -3, 0, 0, 0)), 31L, 45L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 24, 15, 51, 38, 733, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, -3, 0, 0, 0)), 3L, 15L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 30, 12, 9, 54, 665, DateTimeKind.Unspecified).AddTicks(6751), new TimeSpan(0, -3, 0, 0, 0)), 24L, 9L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 17, 4, 46, 33, 588, DateTimeKind.Unspecified).AddTicks(3058), new TimeSpan(0, -3, 0, 0, 0)), 19L, 11L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 26, 22, 24, 42, 393, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, -3, 0, 0, 0)), 15L, 2L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 8, 15, 15, 18, 33, 612, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, -3, 0, 0, 0)), 27L, 21L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 5, 16, 6, 29, 122, DateTimeKind.Unspecified).AddTicks(7195), new TimeSpan(0, -3, 0, 0, 0)), 11L, 49L });

            migrationBuilder.UpdateData(
                table: "ProductLink",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastModified", "LinkedProductId", "ProductId" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 9, 5, 21, 2, 0, 693, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, -3, 0, 0, 0)), 11L, 21L });

            migrationBuilder.UpdateData(
                table: "Shipment",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModified", "TrackNumber" },
                values: new object[] { new DateTime(2019, 9, 8, 18, 24, 17, 685, DateTimeKind.Utc).AddTicks(3967), new DateTimeOffset(new DateTime(2019, 9, 8, 18, 24, 17, 685, DateTimeKind.Unspecified).AddTicks(3296), new TimeSpan(0, 0, 0, 0, 0)), "f6d4ada1-cb85-4b5e-a3a5-1689998fa59e" });
        }
    }
}
