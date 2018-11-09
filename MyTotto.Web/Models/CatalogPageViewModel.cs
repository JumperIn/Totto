using System;
using System.Collections.Generic;
using System.Linq;

using MyTotto.Data.Models;
using MyTotto.Data.Models.Layout;
using MyTotto.Web.Extensions;
using MyTotto.Web.Models.Layout;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления каталога.
    /// </summary>
    public class CatalogPageViewModel : BasePageViewModel
    {
        /// <summary>
        /// Блок с продуктами.
        /// </summary>
        public ProductsAllViewModel Products { get; set; }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public CatalogPageViewModel
        (
            SeoData seo,
            Navigation navigation,
            List<Product> products
        ) : base(seo, navigation)
        {
            Products = new ProductsAllViewModel(products);
        }
    }
}
