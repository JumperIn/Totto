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
    public class CatalogController : BaseController
    {
        private IProductsRepository productsRepository;
        private ICatalogRepository catalogRepository;
        private ICommonRepository commonRepository;

        public CatalogController
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

        private readonly int[] showByCounts = new int[] { 18, 30, 60 };

        ///// <summary>
        ///// Отображает страницу каталога.
        ///// </summary>
        //[HttpGet("catalog")]
        //public IActionResult Index()
        //{
        //    List<Product> products = productsRepository.GetAllProducts();
        //    var catalogPage = new CatalogPageViewModel(products);
        //    return View(catalogPage);
        //}

        /// <summary>
        /// Отображает страницу раздела каталога.
        /// </summary>
        /// <param name="categoryUrl">Категория.</param>
        /// <param name="subcategoryUrl">Подкатегория.</param>
        /// <param name="groupUrl">Группа.</param>
        /// <param name="showBy">Отображать по количеству.</param>
        /// <param name="page">Номер страницы.</param>
        /// <param name="priceInterval">Интервал цен.</param>
        /// <param name="manufacturer">Производитель.</param>
        /// <param name="discount">Наличие скидки. Да = 1. Нет = 0. Не важно = -1</param>
        [HttpGet("{categoryUrl}/{subcategoryUrl?}/{groupUrl?}")]
        public IActionResult Section
        (
            string categoryUrl = "", 
            string subcategoryUrl = "", 
            string groupUrl = "",

            int showBy = 1,
            int page = 1,
            int priceInterval = 0,
            string manufacturer = "",
            int discount = -1
        )
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                return NotFound();
            }

            Navigation navigation = commonRepository.GetNavigation();
            SeoData seo = commonRepository.GetSeo("catalog");

            ProductCategory category = catalogRepository.GetCategory(categoryUrl);
            ProductSubcategory subcategory = catalogRepository.GetSubcategory(subcategoryUrl);
            ProductGroup group = catalogRepository.GetGroup(groupUrl);

            int categoryId = category != null ? category.Id : 0;
            int subcategoryId = subcategory != null ? subcategory.Id : 0;
            int groupId = group != null ? group.Id : 0;

            List<Product> products = productsRepository.GetProducts(categoryId, subcategoryId, groupId);
            
            var catalogPage = new CatalogPageViewModel(seo, navigation, products);

            return View(catalogPage);
        }
    }
}
