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

        public ProductsController(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
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