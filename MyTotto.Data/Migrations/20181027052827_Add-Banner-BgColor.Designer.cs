﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTotto.Data;

namespace MyTotto.Data.Migrations
{
    [DbContext(typeof(TottoContext))]
    [Migration("20181027052827_Add-Banner-BgColor")]
    partial class AddBannerBgColor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("BackgroundColor");

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 10, 27, 12, 28, 27, 196, DateTimeKind.Local));

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Banners");

                    b.HasData(
                        new { Id = 1, BackgroundColor = "#faffe4", Content = "При заказе на сумму от 300 рублей предоставляем бесплатную доставку в любой район Новосибирска", Created = new DateTime(2018, 10, 27, 12, 28, 27, 198, DateTimeKind.Local), ImageUrl = "/files/banners/banner-1.jpg", IsActive = true, Order = 10, Title = "Бесплатная доставка" },
                        new { Id = 2, BackgroundColor = "#faffe4", Content = "чтобы узнавать самым первым все последние новости и акции!", Created = new DateTime(2018, 10, 27, 12, 28, 27, 198, DateTimeKind.Local), ImageUrl = "/files/banners/banner-2.jpg", IsActive = true, Order = 20, Title = "Подпишись на новости" },
                        new { Id = 3, BackgroundColor = "#faffe4", Content = "Чтобы получить скидку на первый заказ необходимо зарегистрироваться и заполнить анкету первооткрывателя сайта", Created = new DateTime(2018, 10, 27, 12, 28, 27, 198, DateTimeKind.Local), ImageUrl = "/files/banners/banner-3.jpg", IsActive = true, Order = 15, Title = "Скидка на первый заказ" }
                    );
                });

            modelBuilder.Entity("MyTotto.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 10, 27, 12, 28, 27, 201, DateTimeKind.Local));

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

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = new Guid("d2f7bf6d-d467-42cd-9d14-20e2a307b4a0"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 78.0m, ImageUrl = "/files/products/product-1/card.jpg", ImageUrls = "/files/products/product-1/1.jpg;/files/products/product-1/2.jpg;/files/products/product-1/3.jpg;/files/products/product-1/4.jpg;", IsActive = true, Manufacturer = "ESTHETIC HOUSE", Price = 22.00m, ProductType = 2, Title = "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл", Url = "/katalog/category-1/subcategory-1/group-1/1" },
                        new { Id = new Guid("82e1d7e7-698e-4311-99a6-910a3c7a70d9"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 50.0m, ImageUrl = "/files/products/product-2/card.jpg", ImageUrls = "/files/products/product-2/1.jpg;/files/products/product-2/2.jpg;/files/products/product-2/3.jpg;/files/products/product-2/4.jpg;", IsActive = true, Manufacturer = "ELIZAVECCA", Price = 660.00m, ProductType = 0, Title = "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл", Url = "/katalog/category-1/subcategory-1/group-2/2" },
                        new { Id = new Guid("8ec18568-f013-4a91-921e-bf3ba7064618"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 44.0m, ImageUrl = "/files/products/product-3/card.jpg", ImageUrls = "/files/products/product-3/1.jpg;/files/products/product-3/2.jpg;/files/products/product-3/3.jpg;/files/products/product-3/4.jpg;", IsActive = true, Manufacturer = "ESTHETIC HOUSE", Price = 895.00m, ProductType = 1, Title = "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл", Url = "/katalog/category-1/subcategory-2/group-1/3" },
                        new { Id = new Guid("fb8455ea-df01-4d74-acb5-866ba27aa8e1"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 35.0m, ImageUrl = "/files/products/product-4/card.jpg", ImageUrls = "/files/products/product-4/1.jpg;/files/products/product-4/2.jpg;/files/products/product-4/3.jpg;/files/products/product-4/4.jpg;", IsActive = true, Manufacturer = "KOELF", Price = 245.00m, ProductType = 3, Title = "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр", Url = "/katalog/category-4/subcategory-1/group-4/4" },
                        new { Id = new Guid("13b766fa-a036-40e9-ac38-026e17f716da"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 38.0m, ImageUrl = "/files/products/product-5/card.jpg", ImageUrls = "/files/products/product-5/1.jpg;/files/products/product-5/2.jpg;/files/products/product-5/3.jpg;/files/products/product-5/4.jpg;", IsActive = true, Manufacturer = "THE SAEM", Price = 92.00m, ProductType = 2, Title = "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл", Url = "/katalog/category-2/subcategory-3/group-1/5" },
                        new { Id = new Guid("fe3321b4-6a22-4e92-9723-8b071728536d"), Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Discount = 0m, ImageUrl = "/files/products/product-6/card.jpg", ImageUrls = "/files/products/product-6/1.jpg;/files/products/product-6/2.jpg;/files/products/product-6/3.jpg;/files/products/product-6/4.jpg;", IsActive = true, Manufacturer = "Innisfree", Price = 120.00m, ProductType = 3, Title = "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato", Url = "/katalog/category-3/subcategory-2/group-2/6" }
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
                        .HasDefaultValue(new DateTime(2018, 10, 27, 12, 28, 27, 204, DateTimeKind.Local));

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

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

            modelBuilder.Entity("MyTotto.Data.Models.PromoProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 10, 27, 12, 28, 27, 206, DateTimeKind.Local));

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("PromoProducts");

                    b.HasData(
                        new { Id = 1, Content = "Введите код HAIR20 при оформлении заказа", Created = new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local), ImageUrl = "/files/promos/promo-1/main.jpg", IsActive = true, Order = 10, Title = "Новая антивозрастная косметика", Url = "/promo/akciya-1" },
                        new { Id = 2, Content = "Волосы становятся шелковистее", Created = new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local), ImageUrl = "/files/promos/promo-2/main.jpg", IsActive = true, Order = 20, Title = "Новинка: сыворотка от бабушки Агафьи", Url = "/promo/akciya-2" },
                        new { Id = 3, Content = "с экстрактом ласточкиного гнезда", Created = new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local), ImageUrl = "/files/promos/promo-3/main.jpg", IsActive = true, Order = 30, Title = "Инновационная сыворотка CF-nest 97%", Url = "/promo/akciya-3" },
                        new { Id = 4, Content = "для глубокого очищения кожи лица", Created = new DateTime(2018, 10, 27, 12, 28, 27, 207, DateTimeKind.Local), ImageUrl = "/files/promos/promo-4/main.jpg", IsActive = true, Order = 15, Title = "Глиняная маска", Url = "/promo/akciya-4" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}