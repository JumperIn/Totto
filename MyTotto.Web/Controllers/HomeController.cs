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
using MyTotto.Data;

namespace MyTotto.Web.Controllers
{
    public class HomeController : BaseController
    {
        IBannersRepository bannersRepository;

        public HomeController(IBannersRepository bannersRepository)
        {
            this.bannersRepository = bannersRepository;
        }

        public IActionResult Index()
        {
            List<Banner> banners = bannersRepository.GetBanners();

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
