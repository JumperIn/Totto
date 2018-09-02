using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTotto.Data.Abstract;
using MyTotto.Data.Models;
using MyTotto.Web.Models;
using MyTotto.Web.Abstract;

namespace MyTotto.Web.Controllers
{
    public class HomeController : BaseController
    {
        protected IBannersRepository bannersRepository;

        public HomeController(IBannersRepository bannersRepository)
        {
            this.bannersRepository = bannersRepository;
        }


        public IActionResult Index()
        {
            //List<Banner> banners = bannersRepository.GetBanners();
            List<Banner> banners = new List<Banner>();
            var banner1 = new Banner()
            {
                Id = 1,
                Title = "Бесплатная доставка",
                Content = "Закажите от 300 рублей и получите доставку",
                ButtonText = "Заказать доставку",
                Url = "/promo"
            };
            var banner2 = new Banner()
            {
                Id = 2,
                Title = "Подпишись на рассылку",
                Content = "Укажи свой e-mail и получи письмо счастья о наших акциях",
                ButtonText = "Подписаться",
                Url = "/subscribe"
            };
            banners.Add(banner1);
            banners.Add(banner2);

            return View(banners);
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }




        ///// <summary>
        ///// Страница с Бонусными баллами.
        ///// </summary>
        //[Route("bonus-points")]
        //public IActionResult BonusPoints()
        //{
        //    return View();
        //}

        ///// <summary>
        ///// Страница с Подарочными сертификатами.
        ///// </summary>
        //[Route("gift-certificate")]
        //public IActionResult GiftCertificates()
        //{
        //    return View();
        //}

        ///// <summary>
        ///// Страница Оплаты и доставки.
        ///// </summary>
        //[Route("payment-and-delivery")]
        //public IActionResult PaymentAndDelivery()
        //{
        //    return View();
        //}

        ///// <summary>
        ///// Страница Пункты самовывоза.
        ///// </summary>
        //[Route("pickup-points")]
        //public IActionResult PickupPoints()
        //{
        //    return View();
        //}

        ///// <summary>
        ///// Страница Контакты
        ///// </summary>
        //[Route("contacts")]
        //public IActionResult Contacts()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}
    }
}
