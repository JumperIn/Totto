using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTotto.Data.Models;

namespace MyTotto.Data.Configurations
{
    class BannersEntityConfiguration : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.ToTable("Banners");

            // Индекс на таблицу
            builder.HasIndex(x => x.Id).IsUnique();

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Created).HasDefaultValue(DateTime.Now);

            builder.HasData(
               new Banner()
               {
                   Id = 1,
                   Title = "Бесплатная доставка",
                   Content = "При заказе на сумму от 300 рублей предоставляем бесплатную доставку в любой район Новосибирска",
                   ImageUrl = @"/files/banners/banner-1.jpg",
                   Order = 10,
                   IsActive = true,
                   ActionDate = null
               },
               new Banner()
               {
                   Id = 2,
                   Title = "Подпишись на новости",
                   Content = "чтобы узнавать самым первым все последние новости и акции!",
                   ImageUrl = @"/files/banners/banner-2.jpg",
                   Order = 20,
                   IsActive = true,
                   ActionDate = null
               },
               new Banner()
               {
                   Id = 3,
                   Title = "Скидка на первый заказ",
                   Content = "Чтобы получить скидку на первый заказ необходимо зарегистрироваться и заполнить анкету первооткрывателя сайта",
                   ImageUrl = @"/files/banners/banner-3.jpg",
                   Order = 15,
                   IsActive = true,
                   ActionDate = null
               });
        }
    }
}