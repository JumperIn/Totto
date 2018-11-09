using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyTotto.Data.Models;
using MyTotto.Data.Models.Layout;
using MyTotto.Web.Models.Layout;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления продукта.
    /// </summary>
    public class ProductPageViewModel : BasePageViewModel
    {
        /// <summary>
        /// Блок с продуктами.
        /// </summary>
        public ProductViewModel Product { get; set; }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public ProductPageViewModel
        (
            SeoData seo,
            Navigation navigaton,
            Product product
        ) : base(seo, navigaton)
        {
            Product = new ProductViewModel(product);
        }
    }
}
