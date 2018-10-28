using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTotto.Data.Models;

namespace MyTotto.Data.Configurations
{
    class CategoriesEntityConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");

            // Индекс на таблицу
            builder.HasIndex(x => x.Id).IsUnique();
            builder.HasKey(x => x.Id);

            builder.HasData(
                new ProductCategory()
                {
                    Id = 1,
                    Title = "Лицо",
                    SectionUrl = "lico",
                    IsActive = true,
                    Order = 10
                },
                new ProductCategory()
                {
                    Id = 2,
                    Title = "Тело",
                    SectionUrl = "telo",
                    IsActive = true,
                    Order = 20
                },
                new ProductCategory()
                {
                    Id = 3,
                    Title = "Волосы",
                    SectionUrl = "volosy",
                    IsActive = true,
                    Order = 30
                },
                new ProductCategory()
                {
                    Id = 4,
                    Title = "Макияж",
                    SectionUrl = "makiyazh",
                    IsActive = true,
                    Order = 40
                },
                new ProductCategory()
                {
                    Id = 5,
                    Title = "Дом&Семья",
                    SectionUrl = "dom-semya",
                    IsActive = true,
                    Order = 50
                },
                new ProductCategory()
                {
                    Id = 6,
                    Title = "Наборы",
                    SectionUrl = "nabory",
                    IsActive = false,
                    Order = 60
                },
                new ProductCategory()
                {
                    Id = 7,
                    Title = "Бренды",
                    SectionUrl = "brendy",
                    IsActive = false,
                    Order = 70
                },
                new ProductCategory()
                {
                    Id = 8,
                    Title = "По компонентам",
                    SectionUrl = "po-komponentam",
                    IsActive = false,
                    Order = 80
                });
        }
    }
}