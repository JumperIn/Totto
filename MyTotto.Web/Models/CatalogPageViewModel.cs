using System;
using System.Collections.Generic;
using System.Linq;

using MyTotto.Data.Models;
using MyTotto.Data.Models.Layout;
using MyTotto.BusinessLogic.Models;
using MyTotto.Web.Extensions;
using MyTotto.Web.Models.Layout;
using MyTotto.Web.Models.Pages;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления каталога.
    /// </summary>
    public class CatalogPageViewModel : BasePage
    {
        /// <summary>
        /// Блок с продуктами.
        /// </summary>
        public List<ProductCard> Products { get; set; }



        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public CatalogPageViewModel
        (
            SeoData seo,
            Navigation navigation,
            List<Breadcrumb> breadcrumbs,
            List<Product> products
        ) : base(seo, navigation, breadcrumbs)
        {
            Products = products.Select(p => new ProductCard(p)).ToList();
        }
    }
}
