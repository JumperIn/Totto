using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class AddCategoriesProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Url",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 583, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 204, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 206, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 580, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 201, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Products",
                nullable: false,
                oldClrType: typeof(Guid))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductGroupId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductSubcategoryId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 572, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 196, DateTimeKind.Local));

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    SectionUrl = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubbcategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    SectionUrl = table.Column<string>(nullable: true),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubbcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubbcategories_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    SectionUrl = table.Column<string>(nullable: true),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    ProductSubcategoryId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductGroups_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductGroups_ProductSubbcategories_ProductSubcategoryId",
                        column: x => x.ProductSubcategoryId,
                        principalTable: "ProductSubbcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 574, DateTimeKind.Local));

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

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "IsActive", "Order", "SectionUrl", "Title" },
                values: new object[,]
                {
                    { 7, false, 70, "brendy", "Бренды" },
                    { 6, false, 60, "nabory", "Наборы" },
                    { 5, true, 50, "dom-semya", "Дом&Семья" },
                    { 8, false, 80, "po-komponentam", "По компонентам" },
                    { 3, true, 30, "volosy", "Волосы" },
                    { 2, true, 20, "telo", "Тело" },
                    { 1, true, 10, "lico", "Лицо" },
                    { 4, true, 40, "makiyazh", "Макияж" }
                });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local), "/images/new1.png" });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local), "/images/new2.png" });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local), "/images/new3.png" });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local), "/images/new4.png" });

            migrationBuilder.InsertData(
                table: "PromoProducts",
                columns: new[] { "Id", "Content", "Created", "ImageUrl", "IsActive", "Order", "Title", "Url" },
                values: new object[] { 5, "Огуречная маска сохранит свежесть", new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local), "/images/new1.png", true, 25, "Лучшая маска всех времён", "/promo/akciya-5" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 10, 29, 11, 59, 17, 584, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "ProductSubbcategories",
                columns: new[] { "Id", "IsActive", "Order", "ProductCategoryId", "SectionUrl", "Title" },
                values: new object[,]
                {
                    { 1, true, 10, 1, "ochischenie-lica", "Очищение" },
                    { 2, true, 20, 1, "osnovnoj-uhod-lica", "Основной уход" },
                    { 3, true, 30, 1, "maski", "Маски" },
                    { 4, true, 40, 1, "osobyj-uhod-lica", "Особый уход" },
                    { 5, true, 10, 2, "osnovnoj-uhod-telo", "Основной уход" },
                    { 6, true, 20, 2, "osobyj-uhod-telo", "Особый уход" },
                    { 7, true, 10, 3, "uhod-za-volosami", "Уход за волосами" },
                    { 8, true, 20, 3, "stajling", "Стайлинг" },
                    { 9, true, 30, 3, "aksessuary-dlya-volos", "Аксессуары для волос" }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "IsActive", "Order", "ProductCategoryId", "ProductSubcategoryId", "SectionUrl", "Title" },
                values: new object[,]
                {
                    { 1, true, 10, 1, 1, "molochko-dlya-snyatiya-makiyazha", "Молочко для снятия макияжа" },
                    { 9, true, 40, 1, 2, "flyuidy-i-geli", "Флюиды и гели" },
                    { 10, true, 50, 1, 2, "ehmulsii-i-ehssencii", "Эмульсии и эссенции" },
                    { 11, true, 60, 1, 2, "BB-i-CC-kremy", "BB и CC кремы" },
                    { 27, true, 10, 2, 2, "krem-dlya-ruk", "Крем для рук" },
                    { 28, true, 20, 2, 2, "krem-dlya-nog", "Крем для ног" },
                    { 29, true, 30, 2, 2, "solncezashchitnye-sredstva", "Солнцезащитные средства" },
                    { 37, true, 10, 3, 2, "vosk", "Воск" },
                    { 8, true, 30, 1, 2, "syvorotki", "Сыворотки" },
                    { 38, true, 20, 3, 2, "gel", "Гель" },
                    { 40, true, 40, 3, 2, "lak-sprej", "Лак – спрей" },
                    { 12, true, 10, 1, 3, "tkanevye-maski", "Тканевые маски" },
                    { 13, true, 20, 1, 3, "gidrogelevye-maski", "Гидрогелевые маски" },
                    { 14, true, 30, 1, 3, "alginatnye-maski", "Альгинатные маски" },
                    { 15, true, 40, 1, 3, "inye-maski", "Иные маски" },
                    { 16, true, 50, 1, 3, "patchi", "Патчи" },
                    { 17, true, 10, 1, 4, "krem-dlya-kozhi-vokrug-glaz", "Крем для кожи вокруг глаз" },
                    { 39, true, 30, 3, 2, "muss", "Мусс" },
                    { 7, true, 20, 1, 2, "sprei", "Спреи" },
                    { 6, true, 10, 1, 2, "kremy", "Кремы" },
                    { 36, true, 70, 3, 1, "maski-dlya-volos", "Маски для волос" },
                    { 2, true, 20, 1, 1, "penki-geli-voda-dlya-umyvaniya", "Пенки, гели и вода для умывания" },
                    { 3, true, 30, 1, 1, "gidrofilnye-masla", "Гидрофильные масла" },
                    { 4, true, 40, 1, 1, "losiony-i-toniki", "Лосьоны и тоники" },
                    { 5, true, 50, 1, 1, "skraby-i-pilingi", "Скрабы и пилинги" },
                    { 20, true, 10, 2, 1, "mylo", "Мыло" },
                    { 21, true, 20, 2, 1, "gel-dlya-dusha", "Гель для душа" },
                    { 22, true, 30, 2, 1, "skraby-i-pilingi-dlya-tela", "Скрабы и пилинги для тела" },
                    { 23, true, 40, 2, 1, "kremy-geli-i-molochko", "Кремы, гели и молочко" },
                    { 24, true, 50, 2, 1, "losiony-i-masla", "Лосьоны и масла" },
                    { 25, true, 60, 2, 1, "sprei-dlya-tela", "Спреи для тела" },
                    { 26, true, 70, 2, 1, "dezodoranty", "Дезодоранты" },
                    { 30, true, 10, 3, 1, "shampuni", "Шампуни" },
                    { 31, true, 20, 3, 1, "balzamy", "Бальзамы" },
                    { 32, true, 30, 3, 1, "kondicionery", "Кондиционеры" },
                    { 33, true, 40, 3, 1, "sprei-i-misty", "Спреи и мисты" },
                    { 34, true, 50, 3, 1, "ehssencii-i-syvorotki", "Эссенции и сыворотки" },
                    { 35, true, 60, 3, 1, "masla", "Масла" },
                    { 18, true, 20, 1, 4, "balzam-dlya-gub", "Бальзам для губ" },
                    { 19, true, 30, 1, 4, "solncezashchitnye-sredstva", "Солнцезащитные средства" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "Discount", "ImageUrl", "ImageUrls", "IsActive", "Manufacturer", "Price", "ProductCategoryId", "ProductGroupId", "ProductSubcategoryId", "ProductType", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local), 78.0m, "/images/cream2.png", "/files/products/product-1/1.jpg;/files/products/product-1/2.jpg;/files/products/product-1/3.jpg;/files/products/product-1/4.jpg;", true, "ESTHETIC HOUSE", 22.00m, 1, 1, 1, 2, "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл" },
                    { 4, new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local), 35.0m, "/images/cream3.png", "/files/products/product-4/1.jpg;/files/products/product-4/2.jpg;/files/products/product-4/3.jpg;/files/products/product-4/4.jpg;", true, "KOELF", 245.00m, 2, 1, 1, 3, "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр" },
                    { 5, new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local), 38.0m, "/images/cream4.png", "/files/products/product-5/1.jpg;/files/products/product-5/2.jpg;/files/products/product-5/3.jpg;/files/products/product-5/4.jpg;", true, "THE SAEM", 92.00m, 2, 1, 2, 2, "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл" },
                    { 8, new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local), 0m, "/images/cream1.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", true, "A'PIEU", 730m, 1, 1, 1, 0, "A'PIEU Спрей для волос защитный Super Protein Hair Guard Mist, 105мл" },
                    { 9, new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local), 0m, "/images/cream3.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", true, "ELIZAVECCA", 1220m, 1, 1, 1, 0, "ELIZAVECCA Маска для лица глиняно-пузырьковая Carbonated Bubble Clay Mask, 100гр" },
                    { 10, new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local), 22m, "/images/cream2.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", true, "ESTHETIC HOUSE", 330m, 1, 1, 1, 1, "ESTHETIC HOUSE Протеиновый кондиционер д/волос CP-1 BС Intense Nourishing Conditioner, 100 мл" },
                    { 11, new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local), 0m, "/images/cream5.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", true, "FARMSTAY", 58m, 1, 1, 1, 0, "FARMSTAY Тканевая маска с натуральным экстрактом граната Visible Difference Pomegranate Mask, 23мл" },
                    { 2, new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local), 50.0m, "/images/cream2.png", "/files/products/product-2/1.jpg;/files/products/product-2/2.jpg;/files/products/product-2/3.jpg;/files/products/product-2/4.jpg;", true, "ELIZAVECCA", 660.00m, 1, 2, 1, 0, "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл" },
                    { 6, new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local), 0m, "/images/cream5.png", "/files/products/product-6/1.jpg;/files/products/product-6/2.jpg;/files/products/product-6/3.jpg;/files/products/product-6/4.jpg;", true, "Innisfree", 120.00m, 2, 2, 1, 3, "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato" },
                    { 7, new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local), 0m, "/images/cream3.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", true, "ESTHETIC HOUSE", 1365.00m, 2, 2, 1, 0, "ESTHETIC HOUSE Патчи гидрогелевые Красное вино Red Wine Hydrogel Eyepatch, 60шт." },
                    { 3, new DateTime(2018, 10, 29, 11, 59, 17, 581, DateTimeKind.Local), 44.0m, "/images/cream2.png", "/files/products/product-3/1.jpg;/files/products/product-3/2.jpg;/files/products/product-3/3.jpg;/files/products/product-3/4.jpg;", true, "ESTHETIC HOUSE", 895.00m, 1, 3, 1, 1, "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductGroupId",
                table: "Products",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSubcategoryId",
                table: "Products",
                column: "ProductSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_Id",
                table: "ProductCategories",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_Id",
                table: "ProductGroups",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ProductCategoryId",
                table: "ProductGroups",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ProductSubcategoryId",
                table: "ProductGroups",
                column: "ProductSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubbcategories_Id",
                table: "ProductSubbcategories",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubbcategories_ProductCategoryId",
                table: "ProductSubbcategories",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductGroups_ProductGroupId",
                table: "Products",
                column: "ProductGroupId",
                principalTable: "ProductGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductSubbcategories_ProductSubcategoryId",
                table: "Products",
                column: "ProductSubcategoryId",
                principalTable: "ProductSubbcategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductGroups_ProductGroupId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductSubbcategories_ProductSubcategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "ProductSubbcategories");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductGroupId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductSubcategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductGroupId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductSubcategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 204, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 583, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 206, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 586, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 201, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 580, DateTimeKind.Local));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 10, 27, 12, 28, 27, 196, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 10, 29, 11, 59, 17, 572, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 10, 27, 12, 28, 27, 198, DateTimeKind.Local));

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
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local), "/files/promos/promo-1/main.jpg" });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local), "/files/promos/promo-2/main.jpg" });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local), "/files/promos/promo-3/main.jpg" });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local), "/files/promos/promo-4/main.jpg" });

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
