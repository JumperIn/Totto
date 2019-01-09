using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MyTotto.Api.Abstract;
using MyTotto.BusinessLogic.Abstract;
using MyTotto.Data;
using MyTotto.Data.Abstract;
using MyTotto.Data.Enums;
using MyTotto.Data.Models;

namespace MyTotto.Api.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProductsRepository productsRepository;
        private readonly ICatalogRepository catalogRepository;
        private readonly IProductsFilterService productsFilterService;
        
        public ProductsController
        (
            IProductsRepository productsRepository, 
            ICatalogRepository catalogRepository,
            IProductsFilterService productsFilterService
        )
        {
            this.productsRepository = productsRepository;
            this.catalogRepository = catalogRepository;
            this.productsFilterService = productsFilterService;
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
        /// <param name="type">Тип продукта.</param>
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
            ProductType type = ProductType.Normal
        )
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                return null;
            }
            
            ProductCategory category = catalogRepository.GetCategory(categoryUrl);
            ProductSubcategory subcategory = catalogRepository.GetSubcategory(subcategoryUrl);
            ProductGroup group = catalogRepository.GetGroup(groupUrl);

            int countItems = productsFilterService.GetPageCountByItems(count);

            List<Product> products = productsFilterService.Filter
            (
                categoryUrl, subcategoryUrl, groupUrl,
                count, sorting, page,
                filters,
                minPrice, maxPrice,
                manufacturer, type
            );

            return products;
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