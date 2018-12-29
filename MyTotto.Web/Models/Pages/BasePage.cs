using System;
using System.Collections.Generic;
using System.Linq;

using MyTotto.Data.Models;
using MyTotto.Data.Models.Layout;
using MyTotto.Web.Models.Layout;

namespace MyTotto.Web.Models.Pages
{
    /// <summary>
    /// Модель представления базовой части страницы.
    /// </summary>
    public abstract class BasePage
    {
        /// <summary>
        /// SEO-настройки.
        /// </summary>
        public Seo Seo { get; set; }

        /// <summary>
        /// Навигационное меню.
        /// </summary>
        public Navigation Navigation { get; set; }

        /// <summary>
        /// Хлебные крошки.
        /// </summary>
        public List<Breadcrumb> Breadcrumbs { get; set; }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public BasePage
        (
            SeoData seo,
            Navigation navigation,
            List<Breadcrumb> breadcrumbs
        )
        {
            Navigation = navigation;
            Seo = new Seo(seo);
            Breadcrumbs = breadcrumbs ?? new List<Breadcrumb>();
        }
    }
}
