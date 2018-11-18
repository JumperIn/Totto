using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MyTotto.Api.Abstract;
using MyTotto.Data;
using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Api.Controllers
{
    public class ProductsController : BaseController
    {
        private IProductsRepository productsRepository;
        private ICatalogRepository catalogRepository;

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
        /// <param name="showBy">Отображать по количеству.</param>
        /// <param name="page">Номер страницы.</param>
        /// <param name="priceInterval">Интервал цен.</param>
        /// <param name="manufacturer">Производитель.</param>
        /// <param name="discount">Наличие скидки. Да = 1. Нет = 0. Не важно = -1</param>
        [HttpGet("section/{categoryUrl}/{subcategoryUrl?}/{groupUrl?}")]
        public IEnumerable<Product> GetProductCards
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
                return null;
            }
            
            ProductCategory category = catalogRepository.GetCategory(categoryUrl);
            ProductSubcategory subcategory = catalogRepository.GetSubcategory(subcategoryUrl);
            ProductGroup group = catalogRepository.GetGroup(groupUrl);

            int categoryId = category != null ? category.Id : 0;
            int subcategoryId = subcategory != null ? subcategory.Id : 0;
            int groupId = group != null ? group.Id : 0;

            List<Product> products = productsRepository.GetProducts(categoryId, subcategoryId, groupId);

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