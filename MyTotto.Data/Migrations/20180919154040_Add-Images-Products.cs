using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class AddImagesProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "Products",
                nullable: true);

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
                columns: new[] { "Id", "Created", "Discount", "ImageUrl", "Images", "IsActive", "Manufacturer", "Price", "ProductType", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("d36d97d6-9e20-4164-a264-f1dd5ce014c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 78.0m, "/files/products/product-1/card.jpg", null, true, "ESTHETIC HOUSE", 22.00m, 2, "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл", "/katalog/category-1/subcategory-1/group-1/1" },
                    { new Guid("54499ffa-a2a4-4e03-837f-2733a8fd3213"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0m, "/files/products/product-2/card.jpg", null, true, "ELIZAVECCA", 660.00m, 0, "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл", "/katalog/category-1/subcategory-1/group-2/2" },
                    { new Guid("efd4be76-2634-492c-ba5f-7b586d2bfdd1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0m, "/files/products/product-3/card.jpg", null, true, "ESTHETIC HOUSE", 895.00m, 1, "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл", "/katalog/category-1/subcategory-2/group-1/3" },
                    { new Guid("a22bd5f7-b7ab-4a16-b70e-a5da78c33b9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0m, "/files/products/product-4/card.jpg", null, true, "KOELF", 245.00m, 3, "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр", "/katalog/category-4/subcategory-1/group-4/4" },
                    { new Guid("5e0676d9-759a-4c47-b6c4-b232a0349da5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0m, "/files/products/product-6/card.jpg", null, true, "THE SAEM", 92.00m, 2, "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл", "/katalog/category-2/subcategory-3/group-1/6" },
                    { new Guid("ad1fb1e8-6d6b-4ae0-9d98-c1f3051afae7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, "/files/products/product-7/card.jpg", null, true, "Innisfree", 120.00m, 3, "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato", "/katalog/category-3/subcategory-2/group-2/7" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54499ffa-a2a4-4e03-837f-2733a8fd3213"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e0676d9-759a-4c47-b6c4-b232a0349da5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a22bd5f7-b7ab-4a16-b70e-a5da78c33b9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad1fb1e8-6d6b-4ae0-9d98-c1f3051afae7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d36d97d6-9e20-4164-a264-f1dd5ce014c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efd4be76-2634-492c-ba5f-7b586d2bfdd1"));

            migrationBuilder.DropColumn(
                name: "Images",
                table: "Products");
        }
    }
}
