using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class AddCategoryImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 580, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 220, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 583, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 578, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 217, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ProductCategories",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 569, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 209, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 572, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 572, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 572, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "/images/cream.jpg");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/images/cream.jpg");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "/images/cream.jpg");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/images/cream.jpg");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "/images/cream.jpg");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "/images/cream.jpg");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "/images/cream.jpg");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "/images/cream.jpg");

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 20,
                column: "ProductSubcategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 21,
                column: "ProductSubcategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 22,
                column: "ProductSubcategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 23,
                column: "ProductSubcategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 24,
                column: "ProductSubcategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 25,
                column: "ProductSubcategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 26,
                column: "ProductSubcategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 27,
                column: "ProductSubcategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 28,
                column: "ProductSubcategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 29,
                column: "ProductSubcategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 30,
                column: "ProductSubcategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 31,
                column: "ProductSubcategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 32,
                column: "ProductSubcategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 33,
                column: "ProductSubcategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 34,
                column: "ProductSubcategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 35,
                column: "ProductSubcategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 36,
                column: "ProductSubcategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 37,
                column: "ProductSubcategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 38,
                column: "ProductSubcategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 39,
                column: "ProductSubcategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 40,
                column: "ProductSubcategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 578, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 583, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 583, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 583, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 583, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 583, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 11, 7, 0, 27, 39, 581, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ProductCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 220, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 580, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 583, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 217, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 578, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 209, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 569, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 211, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 212, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 212, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 20,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 21,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 22,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 23,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 24,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 25,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 26,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 27,
                column: "ProductSubcategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 28,
                column: "ProductSubcategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 29,
                column: "ProductSubcategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 30,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 31,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 32,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 33,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 34,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 35,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 36,
                column: "ProductSubcategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 37,
                column: "ProductSubcategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 38,
                column: "ProductSubcategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 39,
                column: "ProductSubcategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductGroups",
                keyColumn: "Id",
                keyValue: 40,
                column: "ProductSubcategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local));
        }
    }
}
