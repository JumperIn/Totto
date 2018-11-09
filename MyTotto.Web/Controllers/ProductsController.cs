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
    [Route("[controller]")]
    public class ProductsController : BaseController
    {
        private IProductsRepository productsRepository;
        private ICatalogRepository catalogRepository;
        private ICommonRepository commonRepository;

        public ProductsController
        (
            IProductsRepository productsRepository,
            ICatalogRepository catalogRepository,
            ICommonRepository commonRepository
        )
        {
            this.productsRepository = productsRepository;
            this.catalogRepository = catalogRepository;
            this.commonRepository = commonRepository;
        }

        /// <summary>
        /// Отображает страницу продукта по идентификатору.
        /// </summary>
        /// <param name="url">Адрес продукта.</param>
        [HttpGet("{url}")]
        public IActionResult Product(string url)
        {
            int id = 0;
            var sectionUrls = url.Split("-"[0]);
            if (sectionUrls.Any())
            {
                int.TryParse(sectionUrls[0], out id);
            }

            if (id == 0)
            {
                return NotFound();
            }

            Navigation navigation = commonRepository.GetNavigation();
            SeoData seo = commonRepository.GetSeo("product");

            Product product = productsRepository.GetProduct(id);
            var productPage = new ProductPageViewModel(seo, navigation, product);

            return View(productPage);
        }
    }
}
