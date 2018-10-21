using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class AddProductsPromo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c66a0dd-7905-4372-88a7-551cd164f833"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ccbffc0-1264-44c6-9e53-d190d9b0da60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75632679-116c-404d-b52a-05dcb750d708"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ab350e7-40c2-45a1-9e77-1a4dcb5213cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("919e5be6-9c56-4c48-b506-94411cef8234"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a138e8e5-3f8b-41ef-83e5-9c931fe8fcd3"));

            migrationBuilder.DropColumn(
                name: "ButtonText",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Banners");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 453, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 9, 24, 23, 55, 43, 70, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 450, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 9, 24, 23, 55, 43, 66, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 446, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 9, 24, 23, 55, 43, 61, DateTimeKind.Local));

            migrationBuilder.CreateTable(
                name: "PromoProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 455, DateTimeKind.Local))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoProducts", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "PromoProducts",
                columns: new[] { "Id", "Content", "Created", "ImageUrl", "IsActive", "Order", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "Введите код HAIR20 при оформлении заказа", new DateTime(2018, 10, 18, 22, 43, 35, 456, DateTimeKind.Local), "/files/promos/promo-1/main.jpg", true, 10, "Новая антивозрастная косметика", "/promo/akciya-1" },
                    { 2, "Волосы становятся шелковистее", new DateTime(2018, 10, 18, 22, 43, 35, 456, DateTimeKind.Local), "/files/promos/promo-2/main.jpg", true, 20, "Новинка: сыворотка от бабушки Агафьи", "/promo/akciya-2" },
                    { 3, "с экстрактом ласточкиного гнезда", new DateTime(2018, 10, 18, 22, 43, 35, 456, DateTimeKind.Local), "/files/promos/promo-3/main.jpg", true, 30, "Инновационная сыворотка CF-nest 97%", "/promo/akciya-3" },
                    { 4, "для глубокого очищения кожи лица", new DateTime(2018, 10, 18, 22, 43, 35, 456, DateTimeKind.Local), "/files/promos/promo-4/main.jpg", true, 15, "Глиняная маска", "/promo/akciya-4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promos_Id",
                table: "Promos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id",
                table: "Products",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Banners_Id",
                table: "Banners",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PromoProducts_Id",
                table: "PromoProducts",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PromoProducts");

            migrationBuilder.DropIndex(
                name: "IX_Promos_Id",
                table: "Promos");

            migrationBuilder.DropIndex(
                name: "IX_Products_Id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Banners_Id",
                table: "Banners");

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
                defaultValue: new DateTime(2018, 9, 24, 23, 55, 43, 70, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 453, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 9, 24, 23, 55, 43, 66, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 450, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 9, 24, 23, 55, 43, 61, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 18, 22, 43, 35, 446, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "ButtonText",
                table: "Banners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Banners",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ButtonText", "Url" },
                values: new object[] { "Заказать доставку", "/promo/akciya-dostavka" });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ButtonText", "Url" },
                values: new object[] { "Подписаться", "/promo/akciya-podpiska" });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ButtonText", "Url" },
                values: new object[] { "Получить скидку", "/promo/akciya-skidon" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "Discount", "ImageUrl", "ImageUrls", "IsActive", "Manufacturer", "Price", "ProductType", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("a138e8e5-3f8b-41ef-83e5-9c931fe8fcd3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 78.0m, "/files/products/product-1/card.jpg", "/files/products/product-1/1.jpg;/files/products/product-1/2.jpg;/files/products/product-1/3.jpg;/files/products/product-1/4.jpg;", true, "ESTHETIC HOUSE", 22.00m, 2, "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл", "/katalog/category-1/subcategory-1/group-1/1" },
                    { new Guid("2c66a0dd-7905-4372-88a7-551cd164f833"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0m, "/files/products/product-2/card.jpg", "/files/products/product-2/1.jpg;/files/products/product-2/2.jpg;/files/products/product-2/3.jpg;/files/products/product-2/4.jpg;", true, "ELIZAVECCA", 660.00m, 0, "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл", "/katalog/category-1/subcategory-1/group-2/2" },
                    { new Guid("75632679-116c-404d-b52a-05dcb750d708"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0m, "/files/products/product-3/card.jpg", "/files/products/product-3/1.jpg;/files/products/product-3/2.jpg;/files/products/product-3/3.jpg;/files/products/product-3/4.jpg;", true, "ESTHETIC HOUSE", 895.00m, 1, "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл", "/katalog/category-1/subcategory-2/group-1/3" },
                    { new Guid("919e5be6-9c56-4c48-b506-94411cef8234"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0m, "/files/products/product-4/card.jpg", "/files/products/product-4/1.jpg;/files/products/product-4/2.jpg;/files/products/product-4/3.jpg;/files/products/product-4/4.jpg;", true, "KOELF", 245.00m, 3, "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр", "/katalog/category-4/subcategory-1/group-4/4" },
                    { new Guid("4ccbffc0-1264-44c6-9e53-d190d9b0da60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0m, "/files/products/product-5/card.jpg", "/files/products/product-5/1.jpg;/files/products/product-5/2.jpg;/files/products/product-5/3.jpg;/files/products/product-5/4.jpg;", true, "THE SAEM", 92.00m, 2, "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл", "/katalog/category-2/subcategory-3/group-1/5" },
                    { new Guid("8ab350e7-40c2-45a1-9e77-1a4dcb5213cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, "/files/products/product-6/card.jpg", "/files/products/product-6/1.jpg;/files/products/product-6/2.jpg;/files/products/product-6/3.jpg;/files/products/product-6/4.jpg;", true, "Innisfree", 120.00m, 3, "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato", "/katalog/category-3/subcategory-2/group-2/6" }
                });
        }
    }
}
