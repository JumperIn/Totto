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
        private IBannersRepository bannersRepository;
        private IProductsRepository productsRepository;
        private IPromosRepository promosRepository;

        public HomeController
        (
            IBannersRepository bannersRepository,
            IProductsRepository productsRepository,
            IPromosRepository promosRepository
        )
        {
            this.bannersRepository = bannersRepository;
            this.productsRepository = productsRepository;
            this.promosRepository = promosRepository;
        }

        /// <summary>
        /// Отображает главную страницу.
        /// </summary>
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Banner> banners = bannersRepository.GetBanners();
            List<Product> products = productsRepository.GetAllProducts();
            List<Promo> promos = promosRepository.GetAllPromos();
            List<PromoProduct> promoProducts = promosRepository.GetAllPromoProducts();

            var mainPage = new MainPageViewModel(banners, products, promos, promoProducts);

            return View(mainPage);
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
