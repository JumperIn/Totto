using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// SEO-данные для страницы.
    /// </summary>
    public class SeoData
    {
        /// <summary>
        /// Ключ.
        /// </summary>
        public string Key { get; set; }

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
    }
}
