using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyTotto.Data.Models;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления продукта.
    /// </summary>
    public class ProductPageViewModel
    {
        /// <summary>
        /// Блок с продуктами.
        /// </summary>
        public ProductViewModel Product { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public ProductPageViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public ProductPageViewModel
        (
            Product product
        )
        {
            Product = new ProductViewModel(product);
        }
    }
}
