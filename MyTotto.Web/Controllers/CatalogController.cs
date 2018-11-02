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
    public class CatalogController : BaseController
    {
        private IProductsRepository productsRepository;

        public CatalogController
        (
            IProductsRepository productsRepository
        )
        {
            this.productsRepository = productsRepository;
        }

        /// <summary>
        /// Отображает страницу каталога.
        /// </summary>
        [HttpGet("catalog")]
        public IActionResult Index()
        {
            List<Product> products = productsRepository.GetAllProducts();
            var catalogPage = new CatalogPageViewModel(products);
            return View(catalogPage);
        }

        /// <summary>
        /// Отображает страницу раздела каталога.
        /// </summary>
        /// <param name="category">Категория.</param>
        /// <param name="subcategory">Подкатегория.</param>
        /// <param name="group">Группа.</param>
        [HttpGet("catalog/{category}/{subcategory}/{group}")]
        public IActionResult Section(string category = "", string subcategory = "", string group = "")
        {
            List<Product> products = productsRepository.GetAllProducts();
            var catalogPage = new CatalogPageViewModel(products);
            return View(catalogPage);
        }

        /// <summary>
        /// Отображает страницу продукта по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <param name="title">Название.</param>
        [HttpGet("catalog/products/{title}")]
        public IActionResult Product(string title)
        {
            int id = 0;
            var sectionUrls = title.Split("-"[0]);
            if (sectionUrls.Any())
            {
                int.TryParse(sectionUrls[0], out id);
            }

            if (id == 0)
            {
                return NotFound();
            }

            Product product = productsRepository.GetProduct(id);
            var productPage = new ProductPageViewModel(product);
            return View(productPage);
        }
    }
}
