using MyTotto.Data.Models;
using MyTotto.Data.Models.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Models.Layout
{
    /// <summary>
    /// Модель представления базовой части страницы.
    /// </summary>
    public abstract class BasePageViewModel
    {
        /// <summary>
        /// SEO-настройки.
        /// </summary>
        public SeoViewModel Seo { get; set; }

        /// <summary>
        /// Навигационное меню.
        /// </summary>
        public Navigation Navigation { get; set; }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public BasePageViewModel
        (
            SeoData seo,
            Navigation navigation
        )
        {
            Navigation = navigation;
            Seo = new SeoViewModel(seo);
        }
    }
}
