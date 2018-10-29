using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTotto.Data.Models;

namespace MyTotto.Data.Configurations
{
    class SubcategoriesEntityConfiguration : IEntityTypeConfiguration<ProductSubcategory>
    {
        public void Configure(EntityTypeBuilder<ProductSubcategory> builder)
        {
            builder.ToTable("ProductSubbcategories");

            // Индекс на таблицу
            builder.HasIndex(x => x.Id).IsUnique();
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.ProductCategory)
                .WithMany()
                .HasForeignKey(x => x.ProductCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new ProductSubcategory()
                {
                    Id = 1,
                    Title = "Очищение",
                    SectionUrl = "ochischenie-lica",
                    ProductCategoryId = 1,
                    IsActive = true,
                    Order = 10
                },
                new ProductSubcategory()
                {
                    Id = 2,
                    Title = "Основной уход",
                    SectionUrl = "osnovnoj-uhod-lica",
                    ProductCategoryId = 1,
                    IsActive = true,
                    Order = 20
                },
                new ProductSubcategory()
                {
                    Id = 3,
                    Title = "Маски",
                    SectionUrl = "maski",
                    ProductCategoryId = 1,
                    IsActive = true,
                    Order = 30
                },
                new ProductSubcategory()
                {
                    Id = 4,
                    Title = "Особый уход",
                    SectionUrl = "osobyj-uhod-lica",
                    ProductCategoryId = 1,
                    IsActive = true,
                    Order = 40
                },
                new ProductSubcategory()
                {
                    Id = 5,
                    Title = "Основной уход",
                    SectionUrl = "osnovnoj-uhod-telo",
                    ProductCategoryId = 2,
                    IsActive = true,
                    Order = 10
                },
                new ProductSubcategory()
                {
                    Id = 6,
                    Title = "Особый уход",
                    SectionUrl = "osobyj-uhod-telo",
                    ProductCategoryId = 2,
                    IsActive = true,
                    Order = 20
                },
                new ProductSubcategory()
                {
                    Id = 7,
                    Title = "Уход за волосами",
                    SectionUrl = "uhod-za-volosami",
                    ProductCategoryId = 3,
                    IsActive = true,
                    Order = 10
                },
                new ProductSubcategory()
                {
                    Id = 8,
                    Title = "Стайлинг",
                    SectionUrl = "stajling",
                    ProductCategoryId = 3,
                    IsActive = true,
                    Order = 20
                },
                new ProductSubcategory()
                {
                    Id = 9,
                    Title = "Аксессуары для волос",
                    SectionUrl = "aksessuary-dlya-volos",
                    ProductCategoryId = 3,
                    IsActive = true,
                    Order = 30
                });
        }
    }
}