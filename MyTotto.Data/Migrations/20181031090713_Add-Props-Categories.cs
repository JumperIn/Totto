using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class AddPropsCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 639, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 583, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 636, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 580, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "TitleUrl",
                table: "Products",
                nullable: true);

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
                defaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 628, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 572, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BackgroundColor", "Created" },
                values: new object[] { "faffe4", new DateTime(2018, 10, 31, 16, 7, 12, 630, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BackgroundColor", "Created" },
                values: new object[] { "ffffff", new DateTime(2018, 10, 31, 16, 7, 12, 630, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BackgroundColor", "Created" },
                values: new object[] { "84cad0", new DateTime(2018, 10, 31, 16, 7, 12, 630, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ProductSubbcategories",
                columns: new[] { "Id", "IsActive", "Order", "ProductCategoryId", "SectionUrl", "Title" },
                values: new object[,]
                {
                    { 16, true, 70, 4, "tush-kontur-i-podvodka-dlya-glaz", "Тушь, контур и подводка для глаз" },
                    { 17, true, 80, 4, "makiyazh-dlya-gub", "Макияж для губ" },
                    { 19, true, 30, 5, "zubnye-shchetki", "Зубные щетки" },
                    { 20, true, 30, 5, "peny-dlya-vann", "Пены для ванн" },
                    { 21, true, 40, 5, "morskaya-solj", "Морская соль" },
                    { 22, true, 50, 5, "mochalki", "Мочалки" },
                    { 24, true, 70, 5, "britvennye-stanki", "Бритвенные станки" },
                    { 15, true, 60, 4, "sredstva-dlya-brovej", "Средства для бровей" },
                    { 25, true, 80, 5, "dezodoranty", "Дезодоранты" },
                    { 26, true, 90, 5, "stiralnye-poroshki", "Стиральные порошки" },
                    { 27, true, 100, 5, "kondicionery-dly-belya", "Кондиционеры для белья" },
                    { 28, true, 110, 5, "pyatnovyvoditeli-i-otbelivateli", "Пятновыводители и отбеливатели" },
                    { 29, true, 120, 5, "chistyashchie-sredstva-dly-vannoj-i-kuhni", "Чистящие средства для ванной и кухни" },
                    { 23, true, 60, 5, "britvy", "Бритвы" },
                    { 14, true, 50, 4, "teni-i-rumyana", "Тени и румяна" },
                    { 18, true, 30, 5, "zubnye-pasty", "Зубные пасты" },
                    { 12, true, 30, 4, "konsilery", "Консилеры" },
                    { 11, true, 20, 4, "tonalnyj-krem", "Тональный крем" },
                    { 10, true, 10, 4, "osnova-pod-makiyazh", "Основа под макияж" },
                    { 13, true, 40, 4, "pudra-i-hajlajtery", "Пудра и хайлайтеры" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local));

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
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), "/images/discount-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), "/images/discount-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), "/images/discount-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), "/images/discount-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), "/images/discount-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), "/images/discount-3.jpg" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductSubbcategories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DropColumn(
                name: "TitleUrl",
                table: "Products");

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
                defaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 583, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 639, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 580, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 636, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 572, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 31, 16, 7, 12, 628, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BackgroundColor", "Created" },
                values: new object[] { "#faffe4", new DateTime(2018, 10, 29, 11, 59, 17, 574, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BackgroundColor", "Created" },
                values: new object[] { "#ffffff", new DateTime(2018, 10, 29, 11, 59, 17, 574, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BackgroundColor", "Created" },
                values: new object[] { "#84cad0", new DateTime(2018, 10, 29, 11, 59, 17, 574, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local), "/files/promos/promo-1/main.jpg" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local), "/files/promos/promo-2/main.jpg" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local), "/files/promos/promo-3/main.jpg" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local), "/files/promos/promo-4/main.jpg" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local), "/files/promos/promo-5/main.jpg" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local), "/files/promos/promo-6/main.jpg" });
        }
    }
}
