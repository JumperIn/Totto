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

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Created).ValueGeneratedOnAdd();

            builder.HasData(
               new Product()
               {
                   Id = Guid.NewGuid(),
                   Title = "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл",
                   Manufacturer = "ESTHETIC HOUSE",
                   Url = @"/katalog/category-1/subcategory-1/group-1/1",
                   ImageUrl = @"/files/products/product-1/card.jpg",
                   Price = 22.00m,
                   Discount = 78.0m,
                   ProductType = ProductType.Discount,
                   IsActive = true,
                   ImageUrls =                   
                        @"/files/products/product-1/1.jpg;" +
                        @"/files/products/product-1/2.jpg;" +
                        @"/files/products/product-1/3.jpg;" +
                        @"/files/products/product-1/4.jpg;"
                   
               },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Title = "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл",
                    Manufacturer = "ELIZAVECCA",
                    Url = @"/katalog/category-1/subcategory-1/group-2/2",
                    ImageUrl = @"/files/products/product-2/card.jpg",
                    Price = 660.00m,
                    Discount = 50.0m,
                    ProductType = ProductType.Hit,
                    IsActive = true,
                    ImageUrls =
                        @"/files/products/product-2/1.jpg;" +
                        @"/files/products/product-2/2.jpg;" +
                        @"/files/products/product-2/3.jpg;" +
                        @"/files/products/product-2/4.jpg;"
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Title = "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл",
                    Manufacturer = "ESTHETIC HOUSE",
                    Url = @"/katalog/category-1/subcategory-2/group-1/3",
                    ImageUrl = @"/files/products/product-3/card.jpg",
                    Price = 895.00m,
                    Discount = 44.0m,
                    ProductType = ProductType.New,
                    IsActive = true,
                    ImageUrls =
                        @"/files/products/product-3/1.jpg;" +
                        @"/files/products/product-3/2.jpg;" +
                        @"/files/products/product-3/3.jpg;" +
                        @"/files/products/product-3/4.jpg;"
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Title = "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр",
                    Manufacturer = "KOELF",
                    Url = @"/katalog/category-4/subcategory-1/group-4/4",
                    ImageUrl = @"/files/products/product-4/card.jpg",
                    Price = 245.00m,
                    Discount = 35.0m,
                    ProductType = ProductType.Normal,
                    IsActive = true,
                    ImageUrls =
                        @"/files/products/product-4/1.jpg;" +
                        @"/files/products/product-4/2.jpg;" +
                        @"/files/products/product-4/3.jpg;" +
                        @"/files/products/product-4/4.jpg;"
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Title = "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл",
                    Manufacturer = "THE SAEM",
                    Url = @"/katalog/category-2/subcategory-3/group-1/5",
                    ImageUrl = @"/files/products/product-5/card.jpg",
                    Price = 92.00m,
                    Discount = 38.0m,
                    ProductType = ProductType.Discount,
                    IsActive = true,
                    ImageUrls =
                        @"/files/products/product-5/1.jpg;" +
                        @"/files/products/product-5/2.jpg;" +
                        @"/files/products/product-5/3.jpg;" +
                        @"/files/products/product-5/4.jpg;"
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Title = "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato",
                    Manufacturer = "Innisfree",
                    Url = @"/katalog/category-3/subcategory-2/group-2/6",
                    ImageUrl = @"/files/products/product-6/card.jpg",
                    Price = 120.00m,
                    Discount = 0m,
                    ProductType = ProductType.Normal,
                    IsActive = true,
                    ImageUrls =
                        @"/files/products/product-6/1.jpg;" +
                        @"/files/products/product-6/2.jpg;" +
                        @"/files/products/product-6/3.jpg;" +
                        @"/files/products/product-6/4.jpg;"
                });
        }
    }
}