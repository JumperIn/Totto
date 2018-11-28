using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTotto.Data.Models;

namespace MyTotto.Data.Configurations
{
    class ProductsEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            // Индекс на таблицу
            builder.HasIndex(x => x.Id).IsUnique();

            builder.HasOne(x => x.ProductCategory)
                .WithMany()
                .HasForeignKey(x => x.ProductCategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.ProductSubcategory)
                .WithMany()
                .HasForeignKey(x => x.ProductSubcategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.ProductGroup)
                .WithMany() 
                .HasForeignKey(x => x.ProductGroupId)
                .OnDelete(DeleteBehavior.SetNull);

            //builder.HasOne(x => x.Manufacturer).WithMany().HasForeignKey(x => x.ManufacturerId).OnDelete(DeleteBehavior.ClientSetNull);

            //builder.HasOne(x => x.Manufacturer)
            //    .WithMany(x => x.Products)
            //    .HasForeignKey(x => x.ManufacturerId);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Created).HasDefaultValue(DateTime.Now);

            builder.HasData(
               new Product()
               {
                   Id = 1,
                   Title = "Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл",
                   ManufacturerId = 2,
                   ProductCategoryId = 1,
                   ProductSubcategoryId = 1,
                   ProductGroupId = 1,
                   TitleUrl = "nesmivaemaya-keratinovaya-sivorotka",
                   CardImage = @"/images/cream2.png",
                   Price = 22.0m,
                   Discount = 18.0m,
                   DiscountPrice = (1m - 0.18m) * 22m,
                   ProductType = ProductType.Discount,
                   IsActive = true,
                   Created = DateTime.Now,
                   FullImages =
                        @"/files/products/product-1/1.jpg;" +
                        @"/files/products/product-1/2.jpg;" +
                        @"/files/products/product-1/3.jpg;" +
                        @"/files/products/product-1/4.jpg;",
                   Weights = @"300г;500г",
                   Compounds = @"ядро фисташки;семена подсолнечника;кунжут;льняное масло",
                   Description = "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.",
                   AdditionalInfo = "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.",
                   SuitableProducts = "2;3"
               },
                new Product()
                {
                    Id = 2,
                    Title = "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл",
                    ManufacturerId = 1,
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 2,
                    TitleUrl = "krem-dlya-lica-uvlajnayushiy",
                    CardImage = @"/images/cream2.png",
                    Price = 660.00m,
                    Discount = 50.0m,
                    DiscountPrice = (1m - 0.5m) * 660m,
                    ProductType = ProductType.Hit,
                    IsActive = true,
                    Created = DateTime.Now,
                    FullImages =
                        @"/files/products/product-2/1.jpg;" +
                        @"/files/products/product-2/2.jpg;" +
                        @"/files/products/product-2/3.jpg;" +
                        @"/files/products/product-2/4.jpg;",
                    Weights = @"100г;250г",
                    Compounds = @"ядро фисташки;семена подсолнечника;кунжут;льняное масло",
                    Description = "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.",
                    AdditionalInfo = "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.",
                    SuitableProducts = "1;3"
                },
                new Product()
                {
                    Id = 3,
                    Title = "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл",
                    ManufacturerId = 2,
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 3,
                    TitleUrl = "kondic-opolaskivatel",
                    CardImage = @"/images/cream2.png",
                    Price = 895.00m,
                    Discount = 44.0m,
                    DiscountPrice = (1m - 0.44m) * 895m,
                    ProductType = ProductType.New,
                    IsActive = true,
                    Created = DateTime.Now,
                    FullImages =
                        @"/files/products/product-3/1.jpg;" +
                        @"/files/products/product-3/2.jpg;" +
                        @"/files/products/product-3/3.jpg;" +
                        @"/files/products/product-3/4.jpg;",
                    Weights = @"500мл;1000мл",
                    Compounds = @"ядро фисташки;семена подсолнечника;кунжут;льняное масло",
                    Description = "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.",
                    AdditionalInfo = "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.",
                    SuitableProducts = "1;2"
                },
                new Product()
                {
                    Id = 4,
                    Title = "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр",
                    ManufacturerId = 3,
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 1,
                    TitleUrl = "hydrogelevaya-maska-dlya-lica",
                    CardImage = @"/images/cream3.png",
                    Price = 245.00m,
                    Discount = 35.0m,
                    DiscountPrice = (1m - 0.35m) * 245m,
                    ProductType = ProductType.Normal,
                    IsActive = true,
                    Created = DateTime.Now,
                    FullImages =
                        @"/files/products/product-4/1.jpg;" +
                        @"/files/products/product-4/2.jpg;" +
                        @"/files/products/product-4/3.jpg;" +
                        @"/files/products/product-4/4.jpg;",
                    Weights = @"100мл;200мл",
                    Compounds = @"ядро фисташки;семена подсолнечника;кунжут;льняное масло",
                    Description = "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.",
                    AdditionalInfo = "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.",
                    SuitableProducts = "1;2"
                },
                new Product()
                {
                    Id = 5,
                    Title = "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл",
                    ManufacturerId = 4,
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 2,
                    ProductGroupId = 1,
                    TitleUrl = "maska-tkanevaya-shi",
                    CardImage = @"/images/cream4.png",
                    Price = 92.00m,
                    Discount = 0m,
                    DiscountPrice = 92m,
                    ProductType = ProductType.Normal,
                    IsActive = true,
                    Created = DateTime.Now,
                    FullImages =
                        @"/files/products/product-5/1.jpg;" +
                        @"/files/products/product-5/2.jpg;" +
                        @"/files/products/product-5/3.jpg;" +
                        @"/files/products/product-5/4.jpg;",
                    Weights = @"50г",
                    Compounds = @"ядро фисташки;семена подсолнечника;кунжут;льняное масло",
                    Description = "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.",
                    AdditionalInfo = "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.",
                    SuitableProducts = "1;2"
                },
                new Product()
                {
                    Id = 6,
                    Title = "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato",
                    ManufacturerId = 5,
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 2,
                    TitleUrl = "listovaya-maska-tomata",
                    CardImage = @"/images/cream5.png",
                    Price = 120.00m,
                    Discount = 0m,
                    DiscountPrice = 120m,
                    ProductType = ProductType.Normal,
                    IsActive = true,
                    Created = DateTime.Now,
                    FullImages =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/2.jpg;" +
                        @"/files/products/product-6/3.jpg;" +
                        @"/files/products/product-6/4.jpg;",
                    Weights = @"50г;100г",
                    Compounds = @"ядро фисташки;семена подсолнечника;кунжут;льняное масло",
                    Description = "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.",
                    AdditionalInfo = "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.",
                    SuitableProducts = "1;2"
                },
                new Product()
                {
                    Id = 7,
                    Title = "ESTHETIC HOUSE Патчи гидрогелевые Красное вино Red Wine Hydrogel Eyepatch, 60шт.",
                    ManufacturerId = 2,
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 2,
                    TitleUrl = "patchi-hydrogelevie",
                    CardImage = @"/images/cream3.png",
                    Price = 1365.00m,
                    Discount = 0m,
                    DiscountPrice = 1365.00m,
                    ProductType = ProductType.Hit,
                    IsActive = true,
                    Created = DateTime.Now,
                    FullImages =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/4.jpg;",
                    Weights = @"50г;100г",
                    Compounds = @"ядро фисташки;семена подсолнечника;кунжут;льняное масло",
                    Description = "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.",
                    AdditionalInfo = "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.",
                    SuitableProducts = "1;2"
                },
                new Product()
                {
                    Id = 8,
                    Title = "A'PIEU Спрей для волос защитный Super Protein Hair Guard Mist, 105мл",
                    ManufacturerId = 6,
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 1,
                    TitleUrl = "sprey-dlya-volos",
                    CardImage = @"/images/cream1.png",
                    Price = 730m,
                    Discount = 0m,
                    DiscountPrice = 730m,
                    ProductType = ProductType.Hit,
                    IsActive = true,
                    Created = DateTime.Now,
                    FullImages =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/4.jpg;",
                    Weights = @"300мл",
                    Compounds = @"ядро фисташки;семена подсолнечника;кунжут;льняное масло",
                    Description = "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.",
                    AdditionalInfo = "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.",
                    SuitableProducts = "1;2"
                },
                new Product()
                {
                    Id = 9,
                    Title = "ELIZAVECCA Маска для лица глиняно-пузырьковая Carbonated Bubble Clay Mask, 100гр",
                    ManufacturerId = 1,
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 1,
                    TitleUrl = "maska-dlya-lica-glina",
                    CardImage = @"/images/cream3.png",
                    Price = 1220m,
                    Discount = 0m,
                    DiscountPrice = 1220m,
                    ProductType = ProductType.Hit,
                    IsActive = true,
                    Created = DateTime.Now,
                    FullImages =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/4.jpg;",
                    Weights = @"50г;100г",
                    Compounds = @"ядро фисташки;семена подсолнечника;кунжут;льняное масло",
                    Description = "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.",
                    AdditionalInfo = "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.",
                    SuitableProducts = "1;2"
                },
                new Product()
                {
                    Id = 10,
                    Title = "ESTHETIC HOUSE Протеиновый кондиционер д/волос CP-1 BС Intense Nourishing Conditioner, 100 мл",
                    ManufacturerId = 2,
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 1,
                    TitleUrl = "proteinoviy-kondicioner-intensiv",
                    CardImage = @"/images/cream2.png",
                    Price = 330m,
                    Discount = 22m,
                    DiscountPrice = (1m - 0.22m) * 330m,
                    ProductType = ProductType.New,
                    IsActive = true,
                    Created = DateTime.Now,
                    FullImages =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/4.jpg;",
                    Weights = @"250мл;500мл",
                    Compounds = @"ядро фисташки;семена подсолнечника;кунжут;льняное масло",
                    Description = "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.",
                    AdditionalInfo = "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.",
                    SuitableProducts = "1;2"
                },
                new Product()
                {
                    Id = 11,
                    Title = "FARMSTAY Тканевая маска с натуральным экстрактом граната Visible Difference Pomegranate Mask, 23мл",
                    ManufacturerId = 7,
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 1,
                    TitleUrl = "tkanevaya-maska-granat",
                    CardImage = @"/images/cream5.png",
                    Price = 58m,
                    Discount = 0m,
                    DiscountPrice = 58m,
                    ProductType = ProductType.Hit,
                    IsActive = true,
                    Created = DateTime.Now,
                    FullImages =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/4.jpg;",
                    Weights = @"50г;100г",
                    Compounds = @"ядро фисташки;семена подсолнечника;кунжут;льняное масло",
                    Description = "В плодах ягод содержатся сахароза и прочие элементы, полезные для растущего организма.",
                    AdditionalInfo = "Питательные аминокислоты и эфирные масла придают коже невероятную блистательную свежесть зимнего утра.",
                    SuitableProducts = "1;2"
                });
        }
    }
}