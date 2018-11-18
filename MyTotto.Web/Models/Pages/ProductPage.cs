using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyTotto.Data.Models;
using MyTotto.Data.Models.Layout;
using MyTotto.Web.Models.Layout;

namespace MyTotto.Web.Models.Pages
{
    /// <summary>
    /// Модель представления продукта.
    /// </summary>
    public class ProductPage : BasePage
    {
        /// <summary>
        /// Блок с продуктами.
        /// </summary>
        public ProductViewModel Product { get; set; }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public ProductPage
        (
            SeoData seo,
            Navigation navigaton,
            List<Breadcrumb> breadcrumbs,
            Product product
        ) : base(seo, navigaton, breadcrumbs)
        {
            Product = new ProductViewModel(product);
        }
    }
}
