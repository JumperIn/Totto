using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using MyTotto.Data.Models;

namespace MyTotto.Data.Configurations
{
    class PromosEntityConfiguration : IEntityTypeConfiguration<Promo>
    {
        public void Configure(EntityTypeBuilder<Promo> builder)
        {
            builder.ToTable("Promos");

            // Индекс на таблицу
            builder.HasIndex(x => x.Id).IsUnique();

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Created).HasDefaultValue(DateTime.Now);

            builder.HasData(
               new Promo()
               {
                   Id = 1,
                   Title = "3-х шаговая маска",
                   Content = "Набор из 3-х этапного ухода за кожей лица с увлажняющим эффектом",
                   Url = @"/promo/akciya-1",
                   ImageUrl = @"/images/discount-1.jpg",
                   Order = 10,
                   IsActive = true,
                   Created = DateTime.Now
               },
                new Promo()
                {
                    Id = 2,
                    Title = "Гидрогелевые патчи",
                    Content = "широкий выбор патчей",
                    Url = @"/promo/akciya-2",
                    ImageUrl = @"/images/discount-2.jpg",
                    Order = 20,
                    IsActive = true,
                    Created = DateTime.Now
                },
                new Promo()
                {
                    Id = 3,
                    Title = "Сыворотка CF-nest 97%",
                    Content = "с экстрактом ласточкиного гнезда",
                    Url = @"/promo/akciya-3",
                    ImageUrl = @"/images/discount-3.jpg",
                    Order = 30,
                    IsActive = true,
                    Created = DateTime.Now
                },
                new Promo()
                {
                    Id = 4,
                    Title = "Глиняная маска",
                    Content = "для глубокого очищения кожи лица",
                    Url = @"/promo/akciya-4",
                    ImageUrl = @"/images/discount-1.jpg",
                    Order = 15,
                    IsActive = true,
                    Created = DateTime.Now
                },
                new Promo()
                {
                    Id = 5,
                    Title = "Маска теневая",
                    Content = "с экстрактом масла ши",
                    Url = @"/promo/akciya-5",
                    ImageUrl = @"/images/discount-2.jpg",
                    Order = 25,
                    IsActive = true,
                    Created = DateTime.Now
                },
                new Promo()
                {
                    Id = 6,
                    Title = "Крем гиалуроновый",
                    Content = "для лица Aqua Hyalorunic Acid Water",
                    Url = @"/promo/akciya-6",
                    ImageUrl = @"/images/discount-3.jpg",
                    Order = 35,
                    IsActive = true,
                    Created = DateTime.Now
                });
        }
    }
}