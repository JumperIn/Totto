using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.ApplicationCore.Entities.Layout
{
    /// <summary>
    /// Модель SEO-настроек.
    /// </summary>
    public class Seo
    {
        /// <summary>
        /// Название страницы.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Ключевые слова.
        /// </summary>
        public string Keywords { get; set; }
        
        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public Seo(SeoData seo)
        {
            Title = seo.Title;
            Description = seo.Description;
            Keywords = seo.Keywords;
        }
    }
}
