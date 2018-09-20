using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTotto.Data.Models;

namespace MyTotto.Data.Configurations
{
    class BannersConfiguration : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.ToTable("Banners");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Created).ValueGeneratedOnAdd();

            builder.HasData
            (
                new Banner()
                {
                    Id = 1,
                    Title = "Бесплатная доставка",
                    Content = "При заказе на сумму от 300 рублей предоставляем бесплатную доставку в любой район Новосибирска",
                    Url = @"/promo/akciya-dostavka",
                    ImageUrl = @"/files/banners/banner-1.jpg",
                    ButtonText = "Заказать доставку",
                    Order = 10,
                    IsActive = true,
                    ActionDate = null
                },
                new Banner()
                {
                    Id = 2,
                    Title = "Подпишись на новости",
                    Content = "чтобы узнавать самым первым все последние новости и акции!",
                    Url = @"/promo/akciya-podpiska",
                    ImageUrl = @"/files/banners/banner-2.jpg",
                    ButtonText = "Подписаться",
                    Order = 20,
                    IsActive = true,
                    ActionDate = null
                },
                new Banner()
                {
                    Id = 3,
                    Title = "Скидка на первый заказ",
                    Content = "Чтобы получить скидку на первый заказ необходимо зарегистрироваться и заполнить анкету первооткрывателя сайта",
                    Url = @"/promo/akciya-skidon",
                    ImageUrl = @"/files/banners/banner-3.jpg",
                    ButtonText = "Получить скидку",
                    Order = 15,
                    IsActive = true,
                    ActionDate = null
                }
            );
        }
    }
}
