using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class AddBannerBgColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4daddde1-722d-4ddc-9474-3de2a4f2c824"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e5120fa-507a-4ea7-a2f9-c05dfbdec17f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5339cd6f-d0ef-453d-89bb-4b88710a90ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56b75251-01ac-48fd-b13d-a65394c15ce9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fb67743-c3a2-4e1a-9e18-2c48bbd4dc4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5790270-9d2e-4038-a80e-4a634ba2ebd2"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 204, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 453, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 206, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 455, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 201, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 450, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 196, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 446, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "BackgroundColor",
                table: "Banners",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BackgroundColor", "Created" },
                values: new object[] { "#faffe4", new DateTime(2018, 10, 27, 12, 28, 27, 198, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BackgroundColor", "Created" },
                values: new object[] { "#faffe4", new DateTime(2018, 10, 27, 12, 28, 27, 198, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BackgroundColor", "Created" },
                values: new object[] { "#faffe4", new DateTime(2018, 10, 27, 12, 28, 27, 198, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "Discount", "ImageUrl", "ImageUrls", "IsActive", "Manufacturer", "Price", "ProductType", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("d2f7bf6d-d467-42cd-9d14-20e2a307b4a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 78.0m, "/files/products/product-1/card.jpg", "/files/products/product-1/1.jpg;/files/products/product-1/2.jpg;/files/products/product-1/3.jpg;/files/products/product-1/4.jpg;", true, "ESTHETIC HOUSE", 22.00m, 2, "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл", "/katalog/category-1/subcategory-1/group-1/1" },
                    { new Guid("82e1d7e7-698e-4311-99a6-910a3c7a70d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0m, "/files/products/product-2/card.jpg", "/files/products/product-2/1.jpg;/files/products/product-2/2.jpg;/files/products/product-2/3.jpg;/files/products/product-2/4.jpg;", true, "ELIZAVECCA", 660.00m, 0, "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл", "/katalog/category-1/subcategory-1/group-2/2" },
                    { new Guid("8ec18568-f013-4a91-921e-bf3ba7064618"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0m, "/files/products/product-3/card.jpg", "/files/products/product-3/1.jpg;/files/products/product-3/2.jpg;/files/products/product-3/3.jpg;/files/products/product-3/4.jpg;", true, "ESTHETIC HOUSE", 895.00m, 1, "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл", "/katalog/category-1/subcategory-2/group-1/3" },
                    { new Guid("fb8455ea-df01-4d74-acb5-866ba27aa8e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0m, "/files/products/product-4/card.jpg", "/files/products/product-4/1.jpg;/files/products/product-4/2.jpg;/files/products/product-4/3.jpg;/files/products/product-4/4.jpg;", true, "KOELF", 245.00m, 3, "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр", "/katalog/category-4/subcategory-1/group-4/4" },
                    { new Guid("13b766fa-a036-40e9-ac38-026e17f716da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0m, "/files/products/product-5/card.jpg", "/files/products/product-5/1.jpg;/files/products/product-5/2.jpg;/files/products/product-5/3.jpg;/files/products/product-5/4.jpg;", true, "THE SAEM", 92.00m, 2, "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл", "/katalog/category-2/subcategory-3/group-1/5" },
                    { new Guid("fe3321b4-6a22-4e92-9723-8b071728536d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, "/files/products/product-6/card.jpg", "/files/products/product-6/1.jpg;/files/products/product-6/2.jpg;/files/products/product-6/3.jpg;/files/products/product-6/4.jpg;", true, "Innisfree", 120.00m, 3, "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato", "/katalog/category-3/subcategory-2/group-2/6" }
                });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13b766fa-a036-40e9-ac38-026e17f716da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82e1d7e7-698e-4311-99a6-910a3c7a70d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ec18568-f013-4a91-921e-bf3ba7064618"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2f7bf6d-d467-42cd-9d14-20e2a307b4a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb8455ea-df01-4d74-acb5-866ba27aa8e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe3321b4-6a22-4e92-9723-8b071728536d"));

            migrationBuilder.DropColumn(
                name: "BackgroundColor",
                table: "Banners");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 453, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 204, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 455, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 206, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 450, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 201, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 446, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 196, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "Discount", "ImageUrl", "ImageUrls", "IsActive", "Manufacturer", "Price", "ProductType", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("b5790270-9d2e-4038-a80e-4a634ba2ebd2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 78.0m, "/files/products/product-1/card.jpg", "/files/products/product-1/1.jpg;/files/products/product-1/2.jpg;/files/products/product-1/3.jpg;/files/products/product-1/4.jpg;", true, "ESTHETIC HOUSE", 22.00m, 2, "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл", "/katalog/category-1/subcategory-1/group-1/1" },
                    { new Guid("4e5120fa-507a-4ea7-a2f9-c05dfbdec17f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0m, "/files/products/product-2/card.jpg", "/files/products/product-2/1.jpg;/files/products/product-2/2.jpg;/files/products/product-2/3.jpg;/files/products/product-2/4.jpg;", true, "ELIZAVECCA", 660.00m, 0, "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл", "/katalog/category-1/subcategory-1/group-2/2" },
                    { new Guid("4daddde1-722d-4ddc-9474-3de2a4f2c824"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0m, "/files/products/product-3/card.jpg", "/files/products/product-3/1.jpg;/files/products/product-3/2.jpg;/files/products/product-3/3.jpg;/files/products/product-3/4.jpg;", true, "ESTHETIC HOUSE", 895.00m, 1, "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл", "/katalog/category-1/subcategory-2/group-1/3" },
                    { new Guid("6fb67743-c3a2-4e1a-9e18-2c48bbd4dc4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0m, "/files/products/product-4/card.jpg", "/files/products/product-4/1.jpg;/files/products/product-4/2.jpg;/files/products/product-4/3.jpg;/files/products/product-4/4.jpg;", true, "KOELF", 245.00m, 3, "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр", "/katalog/category-4/subcategory-1/group-4/4" },
                    { new Guid("56b75251-01ac-48fd-b13d-a65394c15ce9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0m, "/files/products/product-5/card.jpg", "/files/products/product-5/1.jpg;/files/products/product-5/2.jpg;/files/products/product-5/3.jpg;/files/products/product-5/4.jpg;", true, "THE SAEM", 92.00m, 2, "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл", "/katalog/category-2/subcategory-3/group-1/5" },
                    { new Guid("5339cd6f-d0ef-453d-89bb-4b88710a90ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, "/files/products/product-6/card.jpg", "/files/products/product-6/1.jpg;/files/products/product-6/2.jpg;/files/products/product-6/3.jpg;/files/products/product-6/4.jpg;", true, "Innisfree", 120.00m, 3, "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato", "/katalog/category-3/subcategory-2/group-2/6" }
                });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 18, 22, 43, 35, 456, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 18, 22, 43, 35, 456, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 18, 22, 43, 35, 456, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 18, 22, 43, 35, 456, DateTimeKind.Local));
        }
    }
}
