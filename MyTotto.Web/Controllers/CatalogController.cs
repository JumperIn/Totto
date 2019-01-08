using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MyTotto.Data;
using MyTotto.Data.Abstract;
using MyTotto.Data.Enums;
using MyTotto.Data.Models;
using MyTotto.Data.Models.Comparers;
using MyTotto.Data.Models.Layout;
using MyTotto.BusinessLogic.Services;
using MyTotto.BusinessLogic.Abstract;
using MyTotto.Web.Abstract;
using MyTotto.Web.Models;
using MyTotto.Web.Models.Layout;
using MyTotto.Web.Models.Pages;

namespace MyTotto.Web.Controllers
{
    [Route("[controller]")]
    public class CatalogController : BaseController
    {
        private readonly IProductsRepository productsRepository;
        private readonly ICatalogRepository catalogRepository;
        private readonly ICommonRepository commonRepository;
        private readonly IProductsFilterService productsFilterService;

        public CatalogController
        (
            IProductsRepository productsRepository,
            ICatalogRepository catalogRepository,
            ICommonRepository commonRepository,
            IProductsFilterService productsFilterService
        )
        {
            this.productsRepository = productsRepository;
            this.catalogRepository = catalogRepository;
            this.commonRepository = commonRepository;
            this.productsFilterService = productsFilterService;
        }

        private readonly int[] showByCounts = new int[] { 12, 24, 36 };

        /// <summary>
        /// Отображает страницу раздела каталога.
        /// </summary>
        /// <param name="categoryUrl">Категория.</param>
        /// <param name="subcategoryUrl">Подкатегория.</param>
        /// <param name="groupUrl">Группа.</param>
        /// <param name="count">Отображать количество продуктов.</param>
        /// <param name="sorting">Сортировка.</param>
        /// <param name="page">Номер страницы.</param>
        /// <param name="filters">Набор фильтров.</param>
        /// <param name="minPrice">Минимальная цена.</param>
        /// <param name="maxPrice">Максимальная цена.</param>
        /// <param name="manufacturer">Производитель.</param>
        /// <param name="type">Тип продукта.</param>
        [HttpGet("{categoryUrl}/{subcategoryUrl?}/{groupUrl?}")]
        public IActionResult Section
        (
            string categoryUrl = "", 
            string subcategoryUrl = "",
            string groupUrl = "",
            CatalogCountItems count = CatalogCountItems.Small,
            CatalogSortingType sorting = CatalogSortingType.AscendingTitle,
            int page = 1,
            string filters = "",
            int minPrice = 0,
            int maxPrice = int.MaxValue,
            string manufacturer = "",
            ProductType type = ProductType.Normal
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

            if (category == null)
            {
                return NotFound();
            }

            int countItems = productsFilterService.GetPageCountByItems(count);

            List<Product> products = productsFilterService.Filter
            (
                categoryUrl, subcategoryUrl, groupUrl,
                count, sorting, page,
                filters,
                minPrice, maxPrice,
                manufacturer, type
            );

            List<Breadcrumb> breadcrumbs = GetBreadcrumbs(category, subcategory, group);

            var catalogFilters = new CatalogFilters()
            {
                MinPrice = (int)products.Min(x => x.Price),
                MaxPrice = (int)products.Max(x => x.Price),
                Manufacturers = products.Any() ?
                    products.Select(x => x.Manufacturer).Distinct(new ManufacturerEqualityComparer()).ToList() : 
                    new List<Manufacturer>(),
                CategoryFilters = new List<CategoryFilter>()
                {
                    new CategoryFilter("Категория 1", new List<CategoryFilterItem>()
                    {
                        new CategoryFilterItem(1, "Увлажняющие", "cat-1-uvlaj"),
                        new CategoryFilterItem(2, "Питательные", "cat-1-pitatel"),
                        new CategoryFilterItem(3, "Натуральные", "cat-1-natural"),
                        new CategoryFilterItem(4, "Дневные", "cat-1-den"),
                        new CategoryFilterItem(5, "Ночные", "cat-1-noch")
                    }),
                    new CategoryFilter("Категория 2", new List<CategoryFilterItem>()
                    {
                        new CategoryFilterItem(6, "Антивозрастные", "cat-2-antivozrast"),
                        new CategoryFilterItem(7, "Жирные", "cat-2-jirnie"),
                        new CategoryFilterItem(8, "Сухие", "cat-2-suhie"),
                        new CategoryFilterItem(9, "Невероятные", "cat-2-neveroyat"),
                        new CategoryFilterItem(10, "Чудесные", "cat-2-chudo")
                    })
                }
            };

            int pageCount = products.Count() / countItems != 0 ? products.Count() / countItems : 1;
            var pagination = new Pagination(page, pageCount);
            var sectionPage = new SectionPage(seo, navigation, breadcrumbs, products, products.Count, catalogFilters, pagination);

            return View(sectionPage);
        }


        private List<Breadcrumb> GetBreadcrumbs(ProductCategory category, ProductSubcategory subcategory, ProductGroup group)
        {
            List<Breadcrumb> breadcrumbs = new List<Breadcrumb>()
            {
                new Breadcrumb("Главная", "/"),
                new Breadcrumb("Каталог", "/catalog")
            };

            if (category != null)
            {
                breadcrumbs.Add(new Breadcrumb(category.Title, $"/catalog/{category.SectionUrl}"));
            }

            if (subcategory != null)
            {
                breadcrumbs.Add(new Breadcrumb(subcategory.Title, $"/catalog/{subcategory.ProductCategory.SectionUrl}/{subcategory.SectionUrl}"));
            }

            if (group != null)
            {
                breadcrumbs.Add(new Breadcrumb(group.Title, $"/catalog/{group.ProductCategory.SectionUrl}/{group.ProductSubcategory.SectionUrl}/{group.SectionUrl}"));
            }

            return breadcrumbs;
        }
    }
}
