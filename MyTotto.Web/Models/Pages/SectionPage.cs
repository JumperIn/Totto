using System;
using System.Collections.Generic;
using System.Linq;

using MyTotto.Data.Models;
using MyTotto.Data.Models.Layout;
using MyTotto.BusinessLogic.Models;
using MyTotto.Web.Extensions;
using MyTotto.Web.Models.Layout;

namespace MyTotto.Web.Models.Pages
{
    /// <summary>
    /// Модель представления каталога.
    /// </summary>
    public class SectionPage : BasePage
    {
        /// <summary>
        /// Название раздела.
        /// </summary>
        public string SectionTitle { get; set; }

        /// <summary>
        /// Блок с продуктами.
        /// </summary>
        public List<ProductCard> Products { get; set; }

        /// <summary>
        /// Количество продуктов в разделе.
        /// </summary>
        public int ProductsCount { get; set; }

        /// <summary>
        /// Фильтры.
        /// </summary>
        public CatalogFilters Filters { get; set; }

        /// <summary>
        /// Пагинация.
        /// </summary>
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public SectionPage
        (
            SeoData seo,
            Navigation navigation,
            List<Breadcrumb> breadcrumbs,
            List<Product> products,
            int productsCount,
            CatalogFilters filters,
            Pagination pagination
        ) : base(seo, navigation, breadcrumbs)
        {
            SectionTitle = Breadcrumbs.LastOrDefault()?.Title;
            Products = products.Select(p => new ProductCard(p)).ToList();
            ProductsCount = productsCount;
            Filters = filters;
            Pagination = pagination;
        }
    }
}
