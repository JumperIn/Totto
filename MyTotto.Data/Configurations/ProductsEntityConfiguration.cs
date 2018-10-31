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
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ProductSubcategory)
                .WithMany()
                .HasForeignKey(x => x.ProductSubcategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ProductGroup)
                .WithMany() 
                .HasForeignKey(x => x.ProductGroupId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Created).HasDefaultValue(DateTime.Now);

            builder.HasData(
               new Product()
               {
                   Id = 1,
                   Title = "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл",
                   Manufacturer = "ESTHETIC HOUSE",
                   ProductCategoryId = 1,
                   ProductSubcategoryId = 1,
                   ProductGroupId = 1,
                   TitleUrl = "1-esthetic-house-name-product",
                   ImageUrl = @"/images/cream2.png",
                   Price = 22.00m,
                   Discount = 78.0m,
                   ProductType = ProductType.Discount,
                   IsActive = true,
                   Created = DateTime.Now,
                   ImageUrls =                   
                        @"/files/products/product-1/1.jpg;" +
                        @"/files/products/product-1/2.jpg;" +
                        @"/files/products/product-1/3.jpg;" +
                        @"/files/products/product-1/4.jpg;"
                   
               },
                new Product()
                {
                    Id = 2,
                    Title = "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл",
                    Manufacturer = "ELIZAVECCA",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 2,
                    TitleUrl = "2-elizavecca-name-product",
                    ImageUrl = @"/images/cream2.png",
                    Price = 660.00m,
                    Discount = 50.0m,
                    ProductType = ProductType.Hit,
                    IsActive = true,
                    Created = DateTime.Now,
                    ImageUrls =
                        @"/files/products/product-2/1.jpg;" +
                        @"/files/products/product-2/2.jpg;" +
                        @"/files/products/product-2/3.jpg;" +
                        @"/files/products/product-2/4.jpg;"
                },
                new Product()
                {
                    Id = 3,
                    Title = "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл",
                    Manufacturer = "ESTHETIC HOUSE",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 3,
                    TitleUrl = "3-esthetic-house-name-product",
                    ImageUrl = @"/images/cream2.png",
                    Price = 895.00m,
                    Discount = 44.0m,
                    ProductType = ProductType.New,
                    IsActive = true,
                    Created = DateTime.Now,
                    ImageUrls =
                        @"/files/products/product-3/1.jpg;" +
                        @"/files/products/product-3/2.jpg;" +
                        @"/files/products/product-3/3.jpg;" +
                        @"/files/products/product-3/4.jpg;"
                },
                new Product()
                {
                    Id = 4,
                    Title = "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр",
                    Manufacturer = "KOELF",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 1,
                    TitleUrl = "4-koelf-name-product",
                    ImageUrl = @"/images/cream3.png",
                    Price = 245.00m,
                    Discount = 35.0m,
                    ProductType = ProductType.Normal,
                    IsActive = true,
                    Created = DateTime.Now,
                    ImageUrls =
                        @"/files/products/product-4/1.jpg;" +
                        @"/files/products/product-4/2.jpg;" +
                        @"/files/products/product-4/3.jpg;" +
                        @"/files/products/product-4/4.jpg;"
                },
                new Product()
                {
                    Id = 5,
                    Title = "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл",
                    Manufacturer = "THE SAEM",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 2,
                    ProductGroupId = 1,
                    TitleUrl = "5-the-saem-name-product",
                    ImageUrl = @"/images/cream4.png",
                    Price = 92.00m,
                    Discount = 38.0m,
                    ProductType = ProductType.Discount,
                    IsActive = true,
                    Created = DateTime.Now,
                    ImageUrls =
                        @"/files/products/product-5/1.jpg;" +
                        @"/files/products/product-5/2.jpg;" +
                        @"/files/products/product-5/3.jpg;" +
                        @"/files/products/product-5/4.jpg;"
                },
                new Product()
                {
                    Id = 6,
                    Title = "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato",
                    Manufacturer = "Innisfree",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 2,
                    TitleUrl = "6-innisfree-name-product",
                    ImageUrl = @"/images/cream5.png",
                    Price = 120.00m,
                    Discount = 0m,
                    ProductType = ProductType.Normal,
                    IsActive = true,
                    Created = DateTime.Now,
                    ImageUrls =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/2.jpg;" +
                        @"/files/products/product-6/3.jpg;" +
                        @"/files/products/product-6/4.jpg;"
                },
                new Product()
                {
                    Id = 7,
                    Title = "ESTHETIC HOUSE Патчи гидрогелевые Красное вино Red Wine Hydrogel Eyepatch, 60шт.",
                    Manufacturer = "ESTHETIC HOUSE",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 2,
                    TitleUrl = "7-esthetic-house-name-product",
                    ImageUrl = @"/images/cream3.png",
                    Price = 1365.00m,
                    Discount = 0m,
                    ProductType = ProductType.Hit,
                    IsActive = true,
                    Created = DateTime.Now,
                    ImageUrls =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/4.jpg;"
                },
                new Product()
                {
                    Id = 8,
                    Title = "A'PIEU Спрей для волос защитный Super Protein Hair Guard Mist, 105мл",
                    Manufacturer = "A'PIEU",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 1,
                    TitleUrl = "8-apieu-name-product",
                    ImageUrl = @"/images/cream1.png",
                    Price = 730m,
                    Discount = 0m,
                    ProductType = ProductType.Hit,
                    IsActive = true,
                    Created = DateTime.Now,
                    ImageUrls =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/4.jpg;"
                },
                new Product()
                {
                    Id = 9,
                    Title = "ELIZAVECCA Маска для лица глиняно-пузырьковая Carbonated Bubble Clay Mask, 100гр",
                    Manufacturer = "ELIZAVECCA",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 1,
                    TitleUrl = "9-elizavecca-name-product",
                    ImageUrl = @"/images/cream3.png",
                    Price = 1220m,
                    Discount = 0m,
                    ProductType = ProductType.Hit,
                    IsActive = true,
                    Created = DateTime.Now,
                    ImageUrls =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/4.jpg;"
                },
                new Product()
                {
                    Id = 10,
                    Title = "ESTHETIC HOUSE Протеиновый кондиционер д/волос CP-1 BС Intense Nourishing Conditioner, 100 мл",
                    Manufacturer = "ESTHETIC HOUSE",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 1,
                    TitleUrl = "10-esthetic-house-name-product",
                    ImageUrl = @"/images/cream2.png",
                    Price = 330m,
                    Discount = 22m,
                    ProductType = ProductType.New,
                    IsActive = true,
                    Created = DateTime.Now,
                    ImageUrls =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/4.jpg;"
                },
                new Product()
                {
                    Id = 11,
                    Title = "FARMSTAY Тканевая маска с натуральным экстрактом граната Visible Difference Pomegranate Mask, 23мл",
                    Manufacturer = "FARMSTAY",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    ProductGroupId = 1,
                    TitleUrl = "11-farmstay-name-product",
                    ImageUrl = @"/images/cream5.png",
                    Price = 58m,
                    Discount = 0m,
                    ProductType = ProductType.Hit,
                    IsActive = true,
                    Created = DateTime.Now,
                    ImageUrls =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/4.jpg;"
                });
        }
    }
}