using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    ButtonText = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2018, 9, 24, 23, 55, 43, 61, DateTimeKind.Local))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    ProductType = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2018, 9, 24, 23, 55, 43, 66, DateTimeKind.Local)),
                    ImageUrls = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promos",
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
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2018, 9, 24, 23, 55, 43, 70, DateTimeKind.Local))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "ActionDate", "ButtonText", "Content", "Created", "ImageUrl", "IsActive", "Order", "Title", "Url" },
                values: new object[,]
                {
                    { 1, null, "Заказать доставку", "При заказе на сумму от 300 рублей предоставляем бесплатную доставку в любой район Новосибирска", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/files/banners/banner-1.jpg", true, 10, "Бесплатная доставка", "/promo/akciya-dostavka" },
                    { 2, null, "Подписаться", "чтобы узнавать самым первым все последние новости и акции!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/files/banners/banner-2.jpg", true, 20, "Подпишись на новости", "/promo/akciya-podpiska" },
                    { 3, null, "Получить скидку", "Чтобы получить скидку на первый заказ необходимо зарегистрироваться и заполнить анкету первооткрывателя сайта", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/files/banners/banner-3.jpg", true, 15, "Скидка на первый заказ", "/promo/akciya-skidon" }
                });

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

            migrationBuilder.InsertData(
                table: "Promos",
                columns: new[] { "Id", "Content", "Created", "ImageUrl", "IsActive", "Order", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "Набор из 3-х этапного ухода за кожей лица с увлажняющим эффектом", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/files/promos/promo-1/main.jpg", true, 10, "3-х шаговая маска", "/promo/akciya-1" },
                    { 2, "широкий выбор патчей", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/files/promos/promo-2/main.jpg", true, 20, "Гидрогелевые патчи", "/promo/akciya-2" },
                    { 3, "с экстрактом ласточкиного гнезда", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/files/promos/promo-3/main.jpg", true, 30, "Сыворотка CF-nest 97%", "/promo/akciya-3" },
                    { 4, "для глубокого очищения кожи лица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/files/promos/promo-4/main.jpg", true, 15, "Глиняная маска", "/promo/akciya-4" },
                    { 5, "с экстрактом масла ши", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/files/promos/promo-5/main.jpg", true, 25, "Маска теневая", "/promo/akciya-5" },
                    { 6, "для лица Aqua Hyalorunic Acid Water", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/files/promos/promo-6/main.jpg", true, 35, "Крем гиалуроновый", "/promo/akciya-6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Promos");
        }
    }
}
