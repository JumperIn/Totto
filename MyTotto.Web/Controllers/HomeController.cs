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
using MyTotto.Data.Models.Layout;

namespace MyTotto.Web.Controllers
{
    [Route("/")]
    public class HomeController : BaseController
    {
        private IBannersRepository bannersRepository;
        private IProductsRepository productsRepository;
        private IPromosRepository promosRepository;
        private ICommonRepository commonRepository;

        public HomeController
        (
            IBannersRepository bannersRepository,
            IProductsRepository productsRepository,
            IPromosRepository promosRepository,
            ICommonRepository commonRepository
        )
        {
            this.bannersRepository = bannersRepository;
            this.productsRepository = productsRepository;
            this.promosRepository = promosRepository;
            this.commonRepository = commonRepository;
        }

        /// <summary>
        /// Отображает главную страницу.
        /// </summary>
        [HttpGet]
        public IActionResult Index()
        {
            List<Banner> banners = bannersRepository.GetBanners();
            List<Product> products = productsRepository.GetAllProducts();
            List<Promo> promos = promosRepository.GetAllPromos();
            List<PromoProduct> promoProducts = promosRepository.GetAllPromoProducts();

            Navigation navigation = commonRepository.GetNavigation();
            SeoData seo = commonRepository.GetSeo("main");

            var mainPage = new MainPageViewModel(seo, navigation, banners, products, promos, promoProducts);
            
            return View(mainPage);
        }




    }
}
