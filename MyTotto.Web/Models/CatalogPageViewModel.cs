using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTotto.Data.Models;
using MyTotto.Web.Extensions;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления каталога.
    /// </summary>
    public class CatalogPageViewModel
    {
        /// <summary>
        /// Блок с продуктами.
        /// </summary>
        public ProductsAllViewModel Products { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public CatalogPageViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public CatalogPageViewModel
        (
            List<Product> products
        )
        {
            Products = new ProductsAllViewModel(products);
        }
    }
}
