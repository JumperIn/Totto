using System;
using System.Collections.Generic;
using System.Linq;
using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Data.Repositories
{
    public class FakeCommonRepository : ICommonRepository
    {
        /// <summary>
        /// Получает список баннеров.
        /// </summary>
        public List<Banner> GetBanners()
        {
            List<Banner> banners = new List<Banner>
            {
                new Banner
                {
                    Id = 1,
                    Title = "Скидка на первый заказ -10%",
                    Content = "Укажите при оформлении заказа промо-код <b>START10</b> и получите скиду 10%!<br>Промо-код действует на первый заказ новых клиентов.<br><b>Чем больше заказ - тем больше экономия!</b>",
                    ImageUrl = "/assets/images/banners/first-banner.jpg",
                    ButtonText = "Выбрать товары",
                    Url = "/payment-and-delivery",
                    Order = 100
                },
                new Banner
                {
                    Id = 2,
                    Title = "Оставь свой email",
                    Content = "и узнавай об акциях, скидках, специальных предложениях и новинках нашего магазина первой! Кроме того, зарегистрированные покупатели получают бонусные баллы, которые тут же можно потратить на покупки!",
                    ImageUrl = "/assets/images/banners/second-banner.jpg",
                    ButtonText = "Зарегистрироваться",
                    Url = "/registration",
                    Order = 200
                },
                new Banner
                {
                    Id = 3,
                    Title = "Бесплатная доставка",
                    Content = "Закажите товар на сумму от 3000 руб и выше и в городах присутствия курьерской службы вы получите свой заказ прямо в руки в кратчайшие сроки.",
                    ImageUrl = "/assets/images/banners/third-banner.jpg",
                    ButtonText = "Подробнее о доставке",
                    Url = "/payment-and-delivery",
                    Order = 300
                },
                new Banner
                {
                    Id = 4,
                    Title = "Новые гидрогелевые патчи",
                    Content = "Невероятно нежные и приятные на ощупь патчи увлажняют и успокаивают кожу, охлаждают ее и снимают раздражения и покраснения, питают, разглаживают и осветляют, повышают тонус и эластичность.",
                    ImageUrl = "/assets/images/banners/first-banner.jpg",
                    ButtonText = "Взять со скидкой",
                    Url = "/catalog/for-skin/321312",
                    Order = 400
                }
            };

            return banners.OrderBy(b => b.Order).ToList();
        }
    }
}
