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
        private ICatalogRepository catalogRepository;

        public HomeController
        (
            IBannersRepository bannersRepository,
            IProductsRepository productsRepository,
            IPromosRepository promosRepository,
            ICatalogRepository catalogRepository
        )
        {
            this.bannersRepository = bannersRepository;
            this.productsRepository = productsRepository;
            this.promosRepository = promosRepository;
            this.catalogRepository = catalogRepository;
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

            List<ProductCategory> categories = catalogRepository.GetCategories();
            List<ProductSubcategory> subcategories = catalogRepository.GetSubcategories();
            List<ProductGroup> groups = catalogRepository.GetGroups();

            var mainPage = new MainPageViewModel(categories, subcategories, groups, banners, products, promos, promoProducts);

            ViewBag.Seo = mainPage.Seo;
            ViewBag.Navigation = mainPage.Navigation;

            return View(mainPage);
        }




    }
}
