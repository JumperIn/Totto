using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MyTotto.Api.Abstract;
using MyTotto.Data;
using MyTotto.Data.Abstract;
using MyTotto.Data.Enums;
using MyTotto.Data.Models;

namespace MyTotto.Api.Controllers
{
    public class ProductsController : BaseController
    {
        private IProductsRepository productsRepository;
        private ICatalogRepository catalogRepository;

        private readonly int[] showByCounts = new int[] { 12, 24, 36 };

        public ProductsController(IProductsRepository productsRepository, ICatalogRepository catalogRepository)
        {
            this.productsRepository = productsRepository;
            this.catalogRepository = catalogRepository;
        }

        /// <summary>
        /// Возвращает список всех карточек продуктов.
        /// </summary>
        [HttpGet("all")]
        public IEnumerable<Product> GetAllProductCards()
        {
            List<Product> products = productsRepository.GetAllProducts();
            return products;
        }

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
        [HttpGet("section/{categoryUrl}/{subcategoryUrl?}/{groupUrl?}")]
        public IEnumerable<Product> GetProductCards
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
                return null;
            }
            
            ProductCategory category = catalogRepository.GetCategory(categoryUrl);
            ProductSubcategory subcategory = catalogRepository.GetSubcategory(subcategoryUrl);
            ProductGroup group = catalogRepository.GetGroup(groupUrl);

            int categoryId = category != null ? category.Id : 0;
            int subcategoryId = subcategory != null ? subcategory.Id : 0;
            int groupId = group != null ? group.Id : 0;

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

            return finalProducts;
        }

        /// <summary>
        /// Добавляет новый продукт в список.
        /// </summary>
        /// <param name="product">Данные продукта.</param>
        [HttpPost("product")]
        public void AddProduct([FromBody] Product product)
        {
            productsRepository.AddProduct(product);
        }

        /// <summary>
        /// Обновляет данные продукта в списке.
        /// </summary>
        /// <param name="product">Данные продукта.</param>
        [HttpPost("product/update")]
        public void UpdateProduct([FromBody] Product product)
        {
            productsRepository.UpdateProduct(product);
        }

        /// <summary>
        /// Удаляет продукт из списка.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        [HttpPost("product/delete/{id}")]
        public void DeleteProduct(int id)
        {
            productsRepository.DeleteProduct(id);
        }
    }
}