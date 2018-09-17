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

        /// <summary>
        /// Отображает главную страницу.
        /// </summary>
        public IActionResult Index()
        {
            List<Banner> banners = bannersRepository.GetBanners();

            return View(banners);
        }




        ///// Страница с Бонусными баллами.
        //[Route("bonus-points")]

        ///// Страница с Подарочными сертификатами.
        //[Route("gift-certificate")]

        ///// Страница Оплаты и доставки.
        //[Route("payment-and-delivery")]

        ///// Страница Пункты самовывоза.
        //[Route("pickup-points")]
        
        ///// Страница Контакты
        //[Route("contacts")]
    }
}
