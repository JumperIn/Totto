using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class AddProductManufacturer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 15, 52, 14, 903, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 13, 34, 15, 447, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 15, 52, 14, 906, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 13, 34, 15, 450, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 15, 52, 14, 929, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 13, 34, 15, 474, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 15, 52, 14, 899, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 13, 34, 15, 443, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 901, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 901, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 901, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 930, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 931, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 931, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 931, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 931, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 931, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 931, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 931, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 931, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 931, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 931, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 907, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 907, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 907, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 907, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 907, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 904, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 904, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 904, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 904, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 904, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 12, 2, 15, 52, 14, 904, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                table: "Products",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 13, 34, 15, 447, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 15, 52, 14, 903, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 13, 34, 15, 450, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 15, 52, 14, 906, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 13, 34, 15, 474, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 15, 52, 14, 929, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 13, 34, 15, 443, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 15, 52, 14, 899, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 445, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 445, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 445, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 475, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 476, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 476, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 476, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 476, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 476, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 476, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 476, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 476, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 476, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 476, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 450, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 450, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 450, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 450, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 450, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 447, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 448, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 448, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 448, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 448, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 12, 2, 13, 34, 15, 448, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                table: "Products",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
