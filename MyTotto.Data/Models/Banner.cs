using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Модель новостного баннера.
    /// </summary>
    public class Banner
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Заголовок баннера.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Содержание.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Адрес, куда ведёт баннер.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Ссылка на изображение к баннеру.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Порядок, в котором выводится баннер.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public Banner()
        {
        }
    }
}
