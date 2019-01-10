using System;
using System.Collections.Generic;
using System.Linq;

using MyTotto.Data.Models;
using MyTotto.Data.Models.Layout;
using MyTotto.BusinessLogic.Models;
using MyTotto.Web.Models.Layout;

namespace MyTotto.Web.Models.Pages
{
    /// <summary>
    /// Модель представления продукта.
    /// </summary>
    public class ProductPage : BasePage
    {
        /// <summary>
        /// Данные о продукте.
        /// </summary>
        public ProductFull Product { get; set; }

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
            Product = new ProductFull(product);
        }
    }
}
