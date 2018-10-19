using System;
using System.Collections.Generic;
using System.Text;
using MyTotto.Data.Models;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления промо товара.
    /// </summary>
    public class PromoProductViewModel
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
        public PromoProductViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public PromoProductViewModel(PromoProduct promo)
        {
            Title = promo.Title;
            Content = promo.Content;
            Url = promo.Url;
            ImageUrl = promo.ImageUrl;
        }
    }
}
