using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class AddTitleUrlProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 382, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 639, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 385, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 379, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 636, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 371, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 628, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 373, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 373, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 373, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local), "1-esthetic-house-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local), "2-elizavecca-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local), "3-esthetic-house-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local), "4-koelf-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local), "5-the-saem-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local), "6-innisfree-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local), "7-esthetic-house-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local), "8-apieu-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local), "9-elizavecca-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local), "10-esthetic-house-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local), "11-farmstay-name-product" });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 385, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 385, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 385, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 385, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 385, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 383, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 383, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 383, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 383, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 383, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 383, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 639, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 382, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 385, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 636, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 379, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 628, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 371, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 630, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 630, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 630, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "TitleUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local));
        }
    }
}
