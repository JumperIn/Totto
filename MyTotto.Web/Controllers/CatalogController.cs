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
using MyTotto.Data.Models.Layout;
using MyTotto.Web.Abstract;
using MyTotto.Web.Models;
using MyTotto.Web.Models.Layout;
using MyTotto.Web.Models.Pages;

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

        private readonly int[] showByCounts = new int[] { 12, 24, 36 };

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
        /// <param name="count">Отображать количество продуктов.</param>
        /// <param name="sorting">Сортировка.</param>
        /// <param name="page">Номер страницы.</param>
        /// <param name="filters">Набор фильтров.</param>
        /// <param name="minPrice">Минимальная цена.</param>
        /// <param name="maxPrice">Максимальная цена.</param>
        /// <param name="manufacturer">Производитель.</param>
        /// <param name="discount">Наличие скидки.</param>
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
            ProductDiscount discount = ProductDiscount.Any
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

            if (category == null)
            {
                return NotFound();
            }

            // 1. Сперва выбрать продукты по разделу
            List<Product> products = productsRepository.GetProducts(categoryId, subcategoryId, groupId);

            IEnumerable<Product> filteredProducts = products;

            // 2. Отфильтровать по остальным параметрам

            string[] filterValues = !string.IsNullOrEmpty(filters) ? 
                filters.Split(";"[0]) :
                new string[] { };

            if (filterValues.Any())
            {
                // 2.1 TODO: фильтровать по значениям в самом продукте
            }
             
            // 2.2 Выбрать по цене
            filteredProducts = filteredProducts
                .Where(x =>
                    x.Price >= minPrice && x.Price <= maxPrice);

            // 2.3 Если есть производитель - выбрать по нему
            if (!string.IsNullOrEmpty(manufacturer))
            {
                filteredProducts = filteredProducts
                    .Where(x => string.Equals(x.Manufacturer, manufacturer, StringComparison.InvariantCultureIgnoreCase));
            }

            // 3. Отсортировать по типу сортировки
            switch (sorting)
            {
                case CatalogSortingType.DescendingTitle:
                    filteredProducts = filteredProducts.OrderByDescending(x => x.Title);
                    break;
                case CatalogSortingType.AscendingPrice:
                    filteredProducts = filteredProducts.OrderBy(x => x.Price);
                    break;
                case CatalogSortingType.DescendingPrice:
                    filteredProducts = filteredProducts.OrderByDescending(x => x.Price);
                    break;
                case CatalogSortingType.DiscountFirst:
                    filteredProducts = filteredProducts.OrderByDescending(x => x.ProductType == ProductType.Discount);
                    // x.Price > x.DiscountPrice
                    break;
                default:
                    filteredProducts = filteredProducts.OrderBy(x => x.Title);
                    break;
            }

            // 4. По пагинации выдать количество предметов
            int countItems;
            switch (count)
            {
                case CatalogCountItems.Medium:
                    countItems = showByCounts[1];
                    break;
                case CatalogCountItems.Large:
                    countItems = showByCounts[2];
                    break;
                default:
                    countItems = showByCounts[0];
                    break;
            }

            List<Product> finalProducts = filteredProducts
                .Skip((page - 1) * countItems)
                .Take(countItems)
                .ToList();

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



            var catalogFilters = new CatalogFilters()
            {
                MinPrice = (int)finalProducts.Min(x => x.Price),
                MaxPrice = (int)finalProducts.Max(x => x.Price),
                Manufacturers = new List<Manufacturer>()
                {
                    new Manufacturer()
                    {
                        Id = 1,
                        Title = "ELIZAVECCA",
                        Url = "elizavecca"
                    },
                    new Manufacturer()
                    {
                        Id = 2,
                        Title = "A-Kids",
                        Url = "a-kids"
                    },
                    new Manufacturer()
                    {
                        Id = 3,
                        Title = "ESTHETIC HOUSE",
                        Url = "esthetic-house"
                    }
                },
                IsExistDiscount = true,
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

            int pageCount = finalProducts.Count / countItems != 0 ? finalProducts.Count / countItems : 1;

            var pagination = new Pagination()
            {
                Current = page,
                Count = pageCount
            };

            var catalogPage = new SectionPage(seo, navigation, breadcrumbs, finalProducts, products.Count, catalogFilters, pagination);

            return View(catalogPage);
        }
    }
}
