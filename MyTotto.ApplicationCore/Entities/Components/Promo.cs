using System;
using System.Collections.Generic;
using System.Text;
using DataM = MyTotto.Data.Models;

namespace MyTotto.ApplicationCore.Entities.Components
{
    /// <summary>
    /// Модель промо-блока.
    /// </summary>
    public class Promo
    {
        /// <summary>
        /// Заголовок.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Содержание.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// URL-адрес.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Ссылка на изображение.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public Promo()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public Promo(DataM.Promo promo)
        {
            Title = promo.Title;
            Content = promo.Content;
            Url = promo.Url;
            ImageUrl = promo.ImageUrl;
        }
    }
}
