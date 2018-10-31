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

            builder.HasMany(x => x.Groups)
                .WithOne(x => x.ProductSubcategory)
                .HasForeignKey(x => x.ProductSubcategoryId);

            builder.HasOne(x => x.ProductCategory)
                .WithMany(x => x.Subcategories)
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
                },
                new ProductSubcategory()
                {
                    Id = 10,
                    Title = "Основа под макияж",
                    SectionUrl = "osnova-pod-makiyazh",
                    ProductCategoryId = 4,
                    IsActive = true,
                    Order = 10
                },
                new ProductSubcategory()
                {
                    Id = 11,
                    Title = "Тональный крем",
                    SectionUrl = "tonalnyj-krem",
                    ProductCategoryId = 4,
                    IsActive = true,
                    Order = 20
                },
                new ProductSubcategory()
                {
                    Id = 12,
                    Title = "Консилеры",
                    SectionUrl = "konsilery",
                    ProductCategoryId = 4,
                    IsActive = true,
                    Order = 30
                },
                new ProductSubcategory()
                {
                    Id = 13,
                    Title = "Пудра и хайлайтеры",
                    SectionUrl = "pudra-i-hajlajtery",
                    ProductCategoryId = 4,
                    IsActive = true,
                    Order = 40
                },
                new ProductSubcategory()
                {
                    Id = 14,
                    Title = "Тени и румяна",
                    SectionUrl = "teni-i-rumyana",
                    ProductCategoryId = 4,
                    IsActive = true,
                    Order = 50
                },
                new ProductSubcategory()
                {
                    Id = 15,
                    Title = "Средства для бровей",
                    SectionUrl = "sredstva-dlya-brovej",
                    ProductCategoryId = 4,
                    IsActive = true,
                    Order = 60
                },
                new ProductSubcategory()
                {
                    Id = 16,
                    Title = "Тушь, контур и подводка для глаз",
                    SectionUrl = "tush-kontur-i-podvodka-dlya-glaz",
                    ProductCategoryId = 4,
                    IsActive = true,
                    Order = 70
                },
                new ProductSubcategory()
                {
                    Id = 17,
                    Title = "Макияж для губ",
                    SectionUrl = "makiyazh-dlya-gub",
                    ProductCategoryId = 4,
                    IsActive = true,
                    Order = 80
                },
                new ProductSubcategory()
                {
                    Id = 18,
                    Title = "Зубные пасты",
                    SectionUrl = "zubnye-pasty",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 30
                },
                new ProductSubcategory()
                {
                    Id = 19,
                    Title = "Зубные щетки",
                    SectionUrl = "zubnye-shchetki",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 30
                },
                new ProductSubcategory()
                {
                    Id = 20,
                    Title = "Пены для ванн",
                    SectionUrl = "peny-dlya-vann",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 30
                },
                new ProductSubcategory()
                {
                    Id = 21,
                    Title = "Морская соль",
                    SectionUrl = "morskaya-solj",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 40
                },
                new ProductSubcategory()
                {
                    Id = 22,
                    Title = "Мочалки",
                    SectionUrl = "mochalki",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 50
                },
                new ProductSubcategory()
                {
                    Id = 23,
                    Title = "Бритвы",
                    SectionUrl = "britvy",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 60
                },
                new ProductSubcategory()
                {
                    Id = 24,
                    Title = "Бритвенные станки",
                    SectionUrl = "britvennye-stanki",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 70
                },
                new ProductSubcategory()
                {
                    Id = 25,
                    Title = "Дезодоранты",
                    SectionUrl = "dezodoranty",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 80
                },
                new ProductSubcategory()
                {
                    Id = 26,
                    Title = "Стиральные порошки",
                    SectionUrl = "stiralnye-poroshki",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 90
                },
                new ProductSubcategory()
                {
                    Id = 27,
                    Title = "Кондиционеры для белья",
                    SectionUrl = "kondicionery-dly-belya",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 100
                },
                new ProductSubcategory()
                {
                    Id = 28,
                    Title = "Пятновыводители и отбеливатели",
                    SectionUrl = "pyatnovyvoditeli-i-otbelivateli",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 110
                },
                new ProductSubcategory()
                {
                    Id = 29,
                    Title = "Чистящие средства для ванной и кухни",
                    SectionUrl = "chistyashchie-sredstva-dly-vannoj-i-kuhni",
                    ProductCategoryId = 5,
                    IsActive = true,
                    Order = 120
                });
        }
    }
}