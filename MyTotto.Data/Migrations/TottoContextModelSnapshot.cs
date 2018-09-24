﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTotto.Data;

namespace MyTotto.Data.Migrations
{
    [DbContext(typeof(TottoContext))]
    partial class TottoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyTotto.Data.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActionDate");

                    b.Property<string>("ButtonText");

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 9, 24, 23, 55, 43, 61, DateTimeKind.Local));

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Banners");

                    b.HasData(
                        new { Id = 1, ButtonText = "Заказать доставку", Content = "При заказе на сумму от 300 рублей предоставляем бесплатную доставку в любой район Новосибирска", Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ImageUrl = "/files/banners/banner-1.jpg", IsActive = true, Order = 10, Title = "Бесплатная доставка", Url = "/promo/akciya-dostavka" },
                        new { Id = 2, ButtonText = "Подписаться", Content = "чтобы узнавать самым первым все последние новости и акции!", Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ImageUrl = "/files/banners/banner-2.jpg", IsActive = true, Order = 20, Title = "Подпишись на новости", Url = "/promo/akciya-podpiska" },
                        new { Id = 3, ButtonText = "Получить скидку", Content = "Чтобы получить скидку на первый заказ необходимо зарегистрироваться и заполнить анкету первооткрывателя сайта", Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ImageUrl = "/files/banners/banner-3.jpg", IsActive = true, Order = 15, Title = "Скидка на первый заказ", Url = "/promo/akciya-skidon" }
                    );
                });

            modelBuilder.Entity("MyTotto.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 9, 24, 23, 55, 43, 66, DateTimeKind.Local));

                    b.Property<decimal>("Discount");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("ImageUrls");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Manufacturer");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductType");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = new Guid("a138e8e5-3f8b-41ef-83e5-9c931fe8fcd3"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 78.0m, ImageUrl = "/files/products/product-1/card.jpg", ImageUrls = "/files/products/product-1/1.jpg;/files/products/product-1/2.jpg;/files/products/product-1/3.jpg;/files/products/product-1/4.jpg;", IsActive = true, Manufacturer = "ESTHETIC HOUSE", Price = 22.00m, ProductType = 2, Title = "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл", Url = "/katalog/category-1/subcategory-1/group-1/1" },
                        new { Id = new Guid("2c66a0dd-7905-4372-88a7-551cd164f833"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 50.0m, ImageUrl = "/files/products/product-2/card.jpg", ImageUrls = "/files/products/product-2/1.jpg;/files/products/product-2/2.jpg;/files/products/product-2/3.jpg;/files/products/product-2/4.jpg;", IsActive = true, Manufacturer = "ELIZAVECCA", Price = 660.00m, ProductType = 0, Title = "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл", Url = "/katalog/category-1/subcategory-1/group-2/2" },
                        new { Id = new Guid("75632679-116c-404d-b52a-05dcb750d708"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 44.0m, ImageUrl = "/files/products/product-3/card.jpg", ImageUrls = "/files/products/product-3/1.jpg;/files/products/product-3/2.jpg;/files/products/product-3/3.jpg;/files/products/product-3/4.jpg;", IsActive = true, Manufacturer = "ESTHETIC HOUSE", Price = 895.00m, ProductType = 1, Title = "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл", Url = "/katalog/category-1/subcategory-2/group-1/3" },
                        new { Id = new Guid("919e5be6-9c56-4c48-b506-94411cef8234"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 35.0m, ImageUrl = "/files/products/product-4/card.jpg", ImageUrls = "/files/products/product-4/1.jpg;/files/products/product-4/2.jpg;/files/products/product-4/3.jpg;/files/products/product-4/4.jpg;", IsActive = true, Manufacturer = "KOELF", Price = 245.00m, ProductType = 3, Title = "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр", Url = "/katalog/category-4/subcategory-1/group-4/4" },
                        new { Id = new Guid("4ccbffc0-1264-44c6-9e53-d190d9b0da60"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 38.0m, ImageUrl = "/files/products/product-5/card.jpg", ImageUrls = "/files/products/product-5/1.jpg;/files/products/product-5/2.jpg;/files/products/product-5/3.jpg;/files/products/product-5/4.jpg;", IsActive = true, Manufacturer = "THE SAEM", Price = 92.00m, ProductType = 2, Title = "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл", Url = "/katalog/category-2/subcategory-3/group-1/5" },
                        new { Id = new Guid("8ab350e7-40c2-45a1-9e77-1a4dcb5213cc"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 0m, ImageUrl = "/files/products/product-6/card.jpg", ImageUrls = "/files/products/product-6/1.jpg;/files/products/product-6/2.jpg;/files/products/product-6/3.jpg;/files/products/product-6/4.jpg;", IsActive = true, Manufacturer = "Innisfree", Price = 120.00m, ProductType = 3, Title = "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato", Url = "/katalog/category-3/subcategory-2/group-2/6" }
                    );
                });

            modelBuilder.Entity("MyTotto.Data.Models.Promo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 9, 24, 23, 55, 43, 70, DateTimeKind.Local));

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Promos");

                    b.HasData(
                        new { Id = 1, Content = "Набор из 3-х этапного ухода за кожей лица с увлажняющим эффектом", Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ImageUrl = "/files/promos/promo-1/main.jpg", IsActive = true, Order = 10, Title = "3-х шаговая маска", Url = "/promo/akciya-1" },
                        new { Id = 2, Content = "широкий выбор патчей", Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ImageUrl = "/files/promos/promo-2/main.jpg", IsActive = true, Order = 20, Title = "Гидрогелевые патчи", Url = "/promo/akciya-2" },
                        new { Id = 3, Content = "с экстрактом ласточкиного гнезда", Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ImageUrl = "/files/promos/promo-3/main.jpg", IsActive = true, Order = 30, Title = "Сыворотка CF-nest 97%", Url = "/promo/akciya-3" },
                        new { Id = 4, Content = "для глубокого очищения кожи лица", Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ImageUrl = "/files/promos/promo-4/main.jpg", IsActive = true, Order = 15, Title = "Глиняная маска", Url = "/promo/akciya-4" },
                        new { Id = 5, Content = "с экстрактом масла ши", Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ImageUrl = "/files/promos/promo-5/main.jpg", IsActive = true, Order = 25, Title = "Маска теневая", Url = "/promo/akciya-5" },
                        new { Id = 6, Content = "для лица Aqua Hyalorunic Acid Water", Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ImageUrl = "/files/promos/promo-6/main.jpg", IsActive = true, Order = 35, Title = "Крем гиалуроновый", Url = "/promo/akciya-6" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
