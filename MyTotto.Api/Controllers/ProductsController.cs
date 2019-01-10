using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MyTotto.Api.Abstract;
using MyTotto.BusinessLogic.Abstract;
using MyTotto.BusinessLogic.Models;
using MyTotto.Data;
using MyTotto.Data.Abstract;
using MyTotto.Data.Enums;
using MyTotto.Data.Models;

namespace MyTotto.Api.Controllers
{
    /// <summary>
    /// Контроллер для работы с продуктами.
    /// </summary>
    [Consumes("application/json")]
    [Produces("application/json")]
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
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ProductCard>))]
        public IActionResult GetProductCards
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
                return BadRequest();
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

            List<ProductCard> productCards = products
                .Select(product => new ProductCard(product))
                .ToList();

            return Ok(productCards);
        }

        /// <summary>
        /// Добавляет отметку "Лайк" для продукта по ID.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <response code="400">Not exist ID.</response>
        /// <response code="200">Success.</response>
        [HttpPost("product/like/{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult AddLike(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            productsRepository.AddLikeToProduct(id);

            return Ok();
        }

        #region Admin Panel

        /// <summary>
        /// Возвращает список всех карточек продуктов.
        /// ** Админ-кабинет. **
        /// </summary>
        [HttpGet("all")]
        public IEnumerable<Product> GetAllProductCards()
        {
            List<Product> products = productsRepository.GetAllProducts();
            return products;
        }

        /// <summary>
        /// Добавляет новый продукт в список.
        /// ** Админ-кабинет. **
        /// </summary>
        /// <param name="product">Данные продукта.</param>
        [HttpPost("product")]
        public void AddProduct([FromBody] Product product)
        {
            productsRepository.AddProduct(product);
        }

        /// <summary>
        /// Обновляет данные продукта в списке.
        /// ** Админ-кабинет. **
        /// </summary>
        /// <param name="product">Данные продукта.</param>
        [HttpPost("product/update")]
        public void UpdateProduct([FromBody] Product product)
        {
            productsRepository.UpdateProduct(product);
        }

        /// <summary>
        /// Удаляет продукт из списка.
        /// ** Админ-кабинет. **
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        [HttpPost("product/delete/{id}")]
        public void DeleteProduct(int id)
        {
            productsRepository.DeleteProduct(id);
        }

        #endregion
    }
}