using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTotto.Data.Models;

namespace MyTotto.Data.Configurations
{
    class GroupsEntityConfiguration : IEntityTypeConfiguration<ProductGroup>
    {
        public void Configure(EntityTypeBuilder<ProductGroup> builder)
        {
            builder.ToTable("ProductGroups");

            // Индекс на таблицу
            builder.HasIndex(x => x.Id).IsUnique();
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.ProductCategory)
                .WithMany()
                .HasForeignKey(x => x.ProductCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ProductSubcategory)
                .WithMany()
                .HasForeignKey(x => x.ProductSubcategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new ProductGroup()
                {
                    Id = 1,
                    Title = "Молочко для снятия макияжа",
                    SectionUrl = "molochko-dlya-snyatiya-makiyazha",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 10
                },
                new ProductGroup()
                {
                    Id = 2,
                    Title = "Пенки, гели и вода для умывания",
                    SectionUrl = "penki-geli-voda-dlya-umyvaniya",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 20
                },
                new ProductGroup()
                {
                    Id = 3,
                    Title = "Гидрофильные масла",
                    SectionUrl = "gidrofilnye-masla",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 30
                },
                new ProductGroup()
                {
                    Id = 4,
                    Title = "Лосьоны и тоники",
                    SectionUrl = "losiony-i-toniki",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 40
                },
                new ProductGroup()
                {
                    Id = 5,
                    Title = "Скрабы и пилинги",
                    SectionUrl = "skraby-i-pilingi",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 50
                },
                new ProductGroup()
                {
                    Id = 6,
                    Title = "Кремы",
                    SectionUrl = "kremy",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 10
                },
                new ProductGroup()
                {
                    Id = 7,
                    Title = "Спреи",
                    SectionUrl = "sprei",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 20
                },
                new ProductGroup()
                {
                    Id = 8,
                    Title = "Сыворотки",
                    SectionUrl = "syvorotki",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 30
                },
                new ProductGroup()
                {
                    Id = 9,
                    Title = "Флюиды и гели",
                    SectionUrl = "flyuidy-i-geli",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 40
                },
                new ProductGroup()
                {
                    Id = 10,
                    Title = "Эмульсии и эссенции",
                    SectionUrl = "ehmulsii-i-ehssencii",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 50
                },
                new ProductGroup()
                {
                    Id = 11,
                    Title = "BB и CC кремы",
                    SectionUrl = "BB-i-CC-kremy",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 60
                },
                new ProductGroup()
                {
                    Id = 12,
                    Title = "Тканевые маски",
                    SectionUrl = "tkanevye-maski",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 3,
                    IsActive = true,
                    Order = 10
                },
                new ProductGroup()
                {
                    Id = 13,
                    Title = "Гидрогелевые маски",
                    SectionUrl = "gidrogelevye-maski",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 3,
                    IsActive = true,
                    Order = 20
                },
                new ProductGroup()
                {
                    Id = 14,
                    Title = "Альгинатные маски",
                    SectionUrl = "alginatnye-maski",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 3,
                    IsActive = true,
                    Order = 30
                },
                new ProductGroup()
                {
                    Id = 15,
                    Title = "Иные маски",
                    SectionUrl = "inye-maski",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 3,
                    IsActive = true,
                    Order = 40
                },
                new ProductGroup()
                {
                    Id = 16,
                    Title = "Патчи",
                    SectionUrl = "patchi",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 3,
                    IsActive = true,
                    Order = 50
                },
                new ProductGroup()
                {
                    Id = 17,
                    Title = "Крем для кожи вокруг глаз",
                    SectionUrl = "krem-dlya-kozhi-vokrug-glaz",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 4,
                    IsActive = true,
                    Order = 10
                },
                new ProductGroup()
                {
                    Id = 18,
                    Title = "Бальзам для губ",
                    SectionUrl = "balzam-dlya-gub",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 4,
                    IsActive = true,
                    Order = 20
                },
                new ProductGroup()
                {
                    Id = 19,
                    Title = "Солнцезащитные средства",
                    SectionUrl = "solncezashchitnye-sredstva",
                    ProductCategoryId = 1,
                    ProductSubcategoryId = 4,
                    IsActive = true,
                    Order = 30
                },
                new ProductGroup()
                {
                    Id = 20,
                    Title = "Мыло",
                    SectionUrl = "mylo",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 10
                },
                new ProductGroup()
                {
                    Id = 21,
                    Title = "Гель для душа",
                    SectionUrl = "gel-dlya-dusha",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 20
                },
                new ProductGroup()
                {
                    Id = 22,
                    Title = "Скрабы и пилинги для тела",
                    SectionUrl = "skraby-i-pilingi-dlya-tela",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 30
                },
                new ProductGroup()
                {
                    Id = 23,
                    Title = "Кремы, гели и молочко",
                    SectionUrl = "kremy-geli-i-molochko",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 40
                },
                new ProductGroup()
                {
                    Id = 24,
                    Title = "Лосьоны и масла",
                    SectionUrl = "losiony-i-masla",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 50
                },
                new ProductGroup()
                {
                    Id = 25,
                    Title = "Спреи для тела",
                    SectionUrl = "sprei-dlya-tela",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 60
                },
                new ProductGroup()
                {
                    Id = 26,
                    Title = "Дезодоранты",
                    SectionUrl = "dezodoranty",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 70
                },
                new ProductGroup()
                {
                    Id = 27,
                    Title = "Крем для рук",
                    SectionUrl = "krem-dlya-ruk",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 10
                },
                new ProductGroup()
                {
                    Id = 28,
                    Title = "Крем для ног",
                    SectionUrl = "krem-dlya-nog",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 20
                },
                new ProductGroup()
                {
                    Id = 29,
                    Title = "Солнцезащитные средства",
                    SectionUrl = "solncezashchitnye-sredstva",
                    ProductCategoryId = 2,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 30
                },
                new ProductGroup()
                {
                    Id = 30,
                    Title = "Шампуни",
                    SectionUrl = "shampuni",
                    ProductCategoryId = 3,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 10
                },
                new ProductGroup()
                {
                    Id = 31,
                    Title = "Бальзамы",
                    SectionUrl = "balzamy",
                    ProductCategoryId = 3,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 20
                },
                new ProductGroup()
                {
                    Id = 32,
                    Title = "Кондиционеры",
                    SectionUrl = "kondicionery",
                    ProductCategoryId = 3,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 30
                },
                new ProductGroup()
                {
                    Id = 33,
                    Title = "Спреи и мисты",
                    SectionUrl = "sprei-i-misty",
                    ProductCategoryId = 3,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 40
                },
                new ProductGroup()
                {
                    Id = 34,
                    Title = "Эссенции и сыворотки",
                    SectionUrl = "ehssencii-i-syvorotki",
                    ProductCategoryId = 3,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 50
                },
                new ProductGroup()
                {
                    Id = 35,
                    Title = "Масла",
                    SectionUrl = "masla",
                    ProductCategoryId = 3,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 60
                },
                new ProductGroup()
                {
                    Id = 36,
                    Title = "Маски для волос",
                    SectionUrl = "maski-dlya-volos",
                    ProductCategoryId = 3,
                    ProductSubcategoryId = 1,
                    IsActive = true,
                    Order = 70
                },
                new ProductGroup()
                {
                    Id = 37,
                    Title = "Воск",
                    SectionUrl = "vosk",
                    ProductCategoryId = 3,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 10
                },
                new ProductGroup()
                {
                    Id = 38,
                    Title = "Гель",
                    SectionUrl = "gel",
                    ProductCategoryId = 3,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 20
                },
                new ProductGroup()
                {
                    Id = 39,
                    Title = "Мусс",
                    SectionUrl = "muss",
                    ProductCategoryId = 3,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 30
                },
                new ProductGroup()
                {
                    Id = 40,
                    Title = "Лак – спрей",
                    SectionUrl = "lak-sprej",
                    ProductCategoryId = 3,
                    ProductSubcategoryId = 2,
                    IsActive = true,
                    Order = 40
                });
        }
    }
}