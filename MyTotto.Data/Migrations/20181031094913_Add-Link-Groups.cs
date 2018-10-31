using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class AddLinkGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductGroups_ProductCategories_ProductCategoryId1",
                table: "ProductGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductGroups_ProductSubbcategories_ProductSubcategoryId1",
                table: "ProductGroups");

            migrationBuilder.DropIndex(
                name: "IX_ProductGroups_ProductCategoryId1",
                table: "ProductGroups");

            migrationBuilder.DropIndex(
                name: "IX_ProductGroups_ProductSubcategoryId1",
                table: "ProductGroups");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId1",
                table: "ProductGroups");

            migrationBuilder.DropColumn(
                name: "ProductSubcategoryId1",
                table: "ProductGroups");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 49, 12, 706, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 382, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 49, 12, 708, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 385, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 49, 12, 702, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 379, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 49, 12, 694, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 371, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 696, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 696, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 696, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 704, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 704, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 704, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 704, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 704, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 704, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 704, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 704, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 704, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 704, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 704, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 709, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 709, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 709, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 709, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 709, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 706, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 706, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 706, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 706, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 706, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 49, 12, 706, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 382, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 49, 12, 706, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 385, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 49, 12, 708, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 379, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 49, 12, 702, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId1",
                table: "ProductGroups",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductSubcategoryId1",
                table: "ProductGroups",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 33, 39, 371, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 49, 12, 694, DateTimeKind.Local));

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
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 33, 39, 380, DateTimeKind.Local));

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ProductCategoryId1",
                table: "ProductGroups",
                column: "ProductCategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ProductSubcategoryId1",
                table: "ProductGroups",
                column: "ProductSubcategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductGroups_ProductCategories_ProductCategoryId1",
                table: "ProductGroups",
                column: "ProductCategoryId1",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductGroups_ProductSubbcategories_ProductSubcategoryId1",
                table: "ProductGroups",
                column: "ProductSubcategoryId1",
                principalTable: "ProductSubbcategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
