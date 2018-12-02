using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class AddProductProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Products",
                newName: "Weights");

            migrationBuilder.RenameColumn(
                name: "ImageUrls",
                table: "Products",
                newName: "SuitableProducts");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "FullImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 11, 45, 35, 521, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 580, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 11, 45, 35, 523, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 583, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 11, 45, 35, 545, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 578, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "AdditionalInfo",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardImage",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Compounds",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPrice",
                table: "Products",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 12, 2, 11, 45, 35, 516, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 569, DateTimeKind.Local));

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 12, 2, 11, 45, 35, 519, DateTimeKind.Local), "/images/banner.jpg" });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 12, 2, 11, 45, 35, 519, DateTimeKind.Local), "/images/banner.jpg" });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 12, 2, 11, 45, 35, 519, DateTimeKind.Local), "/images/banner.jpg" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "ELIZAVECCA", "elizavecca" },
                    { 2, "ESTHETIC HOUSE", "esthetic-house" },
                    { 3, "KOELF", "koelf" },
                    { 4, "THE SAEM", "the-saem" },
                    { 5, "Innisfree", "innisfree" },
                    { 6, "A'PIEU", "apieu" },
                    { 7, "FARMSTAY", "farmstay" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdditionalInfo", "CardImage", "Compounds", "Created", "Description", "Discount", "DiscountPrice", "FullImages", "SuitableProducts", "Title", "TitleUrl", "Weights" },
                values: new object[] { "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.", "/images/cream2.png", "ядро фисташки;семена подсолнечника;кунжут;льняное масло", new DateTime(2018, 12, 2, 11, 45, 35, 546, DateTimeKind.Local), "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.", 18.0m, 18.04m, "/files/products/product-1/1.jpg;/files/products/product-1/2.jpg;/files/products/product-1/3.jpg;/files/products/product-1/4.jpg;", "2;3", "Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл", "nesmivaemaya-keratinovaya-sivorotka", "300г;500г" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdditionalInfo", "CardImage", "Compounds", "Created", "Description", "DiscountPrice", "FullImages", "SuitableProducts", "Title", "TitleUrl", "Weights" },
                values: new object[] { "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.", "/images/cream2.png", "ядро фисташки;семена подсолнечника;кунжут;льняное масло", new DateTime(2018, 12, 2, 11, 45, 35, 546, DateTimeKind.Local), "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.", 330.0m, "/files/products/product-2/1.jpg;/files/products/product-2/2.jpg;/files/products/product-2/3.jpg;/files/products/product-2/4.jpg;", "1;3", "Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл", "krem-dlya-lica-uvlajnayushiy", "100г;250г" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdditionalInfo", "CardImage", "Compounds", "Created", "Description", "DiscountPrice", "FullImages", "SuitableProducts", "Title", "TitleUrl", "Weights" },
                values: new object[] { "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.", "/images/cream2.png", "ядро фисташки;семена подсолнечника;кунжут;льняное масло", new DateTime(2018, 12, 2, 11, 45, 35, 546, DateTimeKind.Local), "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.", 501.20m, "/files/products/product-3/1.jpg;/files/products/product-3/2.jpg;/files/products/product-3/3.jpg;/files/products/product-3/4.jpg;", "1;2", "Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл", "esthetic-house-name-product", "500мл;1000мл" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdditionalInfo", "CardImage", "Compounds", "Created", "Description", "DiscountPrice", "FullImages", "SuitableProducts", "Title", "TitleUrl", "Weights" },
                values: new object[] { "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.", "/images/cream3.png", "ядро фисташки;семена подсолнечника;кунжут;льняное масло", new DateTime(2018, 12, 2, 11, 45, 35, 546, DateTimeKind.Local), "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.", 159.25m, "/files/products/product-4/1.jpg;/files/products/product-4/2.jpg;/files/products/product-4/3.jpg;/files/products/product-4/4.jpg;", "1;2", "Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр", "koelf-name-product", "100мл;200мл" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdditionalInfo", "CardImage", "Compounds", "Created", "Description", "Discount", "DiscountPrice", "FullImages", "SuitableProducts", "Title", "TitleUrl", "Weights" },
                values: new object[] { "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.", "/images/cream4.png", "ядро фисташки;семена подсолнечника;кунжут;льняное масло", new DateTime(2018, 12, 2, 11, 45, 35, 546, DateTimeKind.Local), "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.", 0m, 92m, "/files/products/product-5/1.jpg;/files/products/product-5/2.jpg;/files/products/product-5/3.jpg;/files/products/product-5/4.jpg;", "1;2", "Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл", "the-saem-name-product", "50г" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdditionalInfo", "CardImage", "Compounds", "Created", "Description", "DiscountPrice", "FullImages", "SuitableProducts", "Title", "TitleUrl", "Weights" },
                values: new object[] { "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.", "/images/cream5.png", "ядро фисташки;семена подсолнечника;кунжут;льняное масло", new DateTime(2018, 12, 2, 11, 45, 35, 546, DateTimeKind.Local), "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.", 120m, "/files/products/product-6/1.jpg;/files/products/product-6/2.jpg;/files/products/product-6/3.jpg;/files/products/product-6/4.jpg;", "1;2", "Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato", "innisfree-name-product", "50г;100г" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AdditionalInfo", "CardImage", "Compounds", "Created", "Description", "DiscountPrice", "FullImages", "SuitableProducts", "Title", "TitleUrl", "Weights" },
                values: new object[] { "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.", "/images/cream3.png", "ядро фисташки;семена подсолнечника;кунжут;льняное масло", new DateTime(2018, 12, 2, 11, 45, 35, 546, DateTimeKind.Local), "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.", 1365.00m, "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", "1;2", "Патчи гидрогелевые Красное вино Red Wine Hydrogel Eyepatch, 60шт.", "esthetic-house-name-product", "50г;100г" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AdditionalInfo", "CardImage", "Compounds", "Created", "Description", "DiscountPrice", "FullImages", "SuitableProducts", "Title", "TitleUrl", "Weights" },
                values: new object[] { "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.", "/images/cream1.png", "ядро фисташки;семена подсолнечника;кунжут;льняное масло", new DateTime(2018, 12, 2, 11, 45, 35, 546, DateTimeKind.Local), "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.", 730m, "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", "1;2", "Спрей для волос защитный Super Protein Hair Guard Mist, 105мл", "sprey-dlya-volos", "300мл" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AdditionalInfo", "CardImage", "Compounds", "Created", "Description", "DiscountPrice", "FullImages", "SuitableProducts", "Title", "TitleUrl", "Weights" },
                values: new object[] { "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.", "/images/cream3.png", "ядро фисташки;семена подсолнечника;кунжут;льняное масло", new DateTime(2018, 12, 2, 11, 45, 35, 546, DateTimeKind.Local), "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.", 1220m, "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", "1;2", "Маска для лица глиняно-пузырьковая Carbonated Bubble Clay Mask, 100гр", "maska-dlya-lica-glina", "50г;100г" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AdditionalInfo", "CardImage", "Compounds", "Created", "Description", "DiscountPrice", "FullImages", "SuitableProducts", "Title", "TitleUrl", "Weights" },
                values: new object[] { "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.", "/images/cream2.png", "ядро фисташки;семена подсолнечника;кунжут;льняное масло", new DateTime(2018, 12, 2, 11, 45, 35, 546, DateTimeKind.Local), "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.", 257.40m, "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", "1;2", "Протеиновый кондиционер д/волос CP-1 BС Intense Nourishing Conditioner, 100 мл", "proteinoviy-kondicioner-intensiv", "250мл;500мл" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AdditionalInfo", "CardImage", "Compounds", "Created", "Description", "DiscountPrice", "FullImages", "SuitableProducts", "Title", "TitleUrl", "Weights" },
                values: new object[] { "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.", "/images/cream5.png", "ядро фисташки;семена подсолнечника;кунжут;льняное масло", new DateTime(2018, 12, 2, 11, 45, 35, 546, DateTimeKind.Local), "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.", 58m, "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", "1;2", "Тканевая маска с натуральным экстрактом граната Visible Difference Pomegranate Mask, 23мл", "tkanevaya-maska-granat", "50г;100г" });

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 2, 11, 45, 35, 524, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 2, 11, 45, 35, 524, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 2, 11, 45, 35, 524, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 2, 11, 45, 35, 524, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PromoProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 12, 2, 11, 45, 35, 524, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 2, 11, 45, 35, 521, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 2, 11, 45, 35, 521, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 2, 11, 45, 35, 521, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 2, 11, 45, 35, 521, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 12, 2, 11, 45, 35, 521, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Promos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2018, 12, 2, 11, 45, 35, 521, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_Id",
                table: "Manufacturers",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropColumn(
                name: "AdditionalInfo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CardImage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Compounds",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Weights",
                table: "Products",
                newName: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "SuitableProducts",
                table: "Products",
                newName: "ImageUrls");

            migrationBuilder.RenameColumn(
                name: "FullImages",
                table: "Products",
                newName: "ImageUrl");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Promos",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 580, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 11, 45, 35, 521, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PromoProducts",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 583, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 11, 45, 35, 523, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 578, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 11, 45, 35, 545, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2018, 11, 7, 0, 27, 39, 569, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 12, 2, 11, 45, 35, 516, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 572, DateTimeKind.Local), "/files/banners/banner-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 572, DateTimeKind.Local), "/files/banners/banner-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 572, DateTimeKind.Local), "/files/banners/banner-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Discount", "ImageUrl", "ImageUrls", "Manufacturer", "Title", "TitleUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 578, DateTimeKind.Local), 78.0m, "/images/cream2.png", "/files/products/product-1/1.jpg;/files/products/product-1/2.jpg;/files/products/product-1/3.jpg;/files/products/product-1/4.jpg;", "ESTHETIC HOUSE", "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл", "1-esthetic-house-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ImageUrl", "ImageUrls", "Manufacturer", "Title", "TitleUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local), "/images/cream2.png", "/files/products/product-2/1.jpg;/files/products/product-2/2.jpg;/files/products/product-2/3.jpg;/files/products/product-2/4.jpg;", "ELIZAVECCA", "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл", "2-elizavecca-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "ImageUrl", "ImageUrls", "Manufacturer", "Title", "TitleUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local), "/images/cream2.png", "/files/products/product-3/1.jpg;/files/products/product-3/2.jpg;/files/products/product-3/3.jpg;/files/products/product-3/4.jpg;", "ESTHETIC HOUSE", "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл", "3-esthetic-house-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "ImageUrl", "ImageUrls", "Manufacturer", "Title", "TitleUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local), "/images/cream3.png", "/files/products/product-4/1.jpg;/files/products/product-4/2.jpg;/files/products/product-4/3.jpg;/files/products/product-4/4.jpg;", "KOELF", "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр", "4-koelf-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Discount", "ImageUrl", "ImageUrls", "Manufacturer", "Title", "TitleUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local), 38.0m, "/images/cream4.png", "/files/products/product-5/1.jpg;/files/products/product-5/2.jpg;/files/products/product-5/3.jpg;/files/products/product-5/4.jpg;", "THE SAEM", "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл", "5-the-saem-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "ImageUrl", "ImageUrls", "Manufacturer", "Title", "TitleUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local), "/images/cream5.png", "/files/products/product-6/1.jpg;/files/products/product-6/2.jpg;/files/products/product-6/3.jpg;/files/products/product-6/4.jpg;", "Innisfree", "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato", "6-innisfree-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "ImageUrl", "ImageUrls", "Manufacturer", "Title", "TitleUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local), "/images/cream3.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", "ESTHETIC HOUSE", "ESTHETIC HOUSE Патчи гидрогелевые Красное вино Red Wine Hydrogel Eyepatch, 60шт.", "7-esthetic-house-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "ImageUrl", "ImageUrls", "Manufacturer", "Title", "TitleUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local), "/images/cream1.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", "A'PIEU", "A'PIEU Спрей для волос защитный Super Protein Hair Guard Mist, 105мл", "8-apieu-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "ImageUrl", "ImageUrls", "Manufacturer", "Title", "TitleUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local), "/images/cream3.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", "ELIZAVECCA", "ELIZAVECCA Маска для лица глиняно-пузырьковая Carbonated Bubble Clay Mask, 100гр", "9-elizavecca-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "ImageUrl", "ImageUrls", "Manufacturer", "Title", "TitleUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local), "/images/cream2.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", "ESTHETIC HOUSE", "ESTHETIC HOUSE Протеиновый кондиционер д/волос CP-1 BС Intense Nourishing Conditioner, 100 мл", "10-esthetic-house-name-product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "ImageUrl", "ImageUrls", "Manufacturer", "Title", "TitleUrl" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 27, 39, 579, DateTimeKind.Local), "/images/cream5.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", "FARMSTAY", "FARMSTAY Тканевая маска с натуральным экстрактом граната Visible Difference Pomegranate Mask, 23мл", "11-farmstay-name-product" });

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
    }
}
