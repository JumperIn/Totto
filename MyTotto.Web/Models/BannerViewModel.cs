using MyTotto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления новостного баннера.
    /// </summary>
    public class BannerViewModel
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Заголовок.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Содержание.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Адрес, куда ведёт кнопка.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Ссылка на изображение баннера.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Текст кнопки.
        /// Если не пустое значение - кнопка есть.
        /// Иначе - кнопки нет.
        /// </summary>
        public string ButtonText { get; set; }

        /// <summary>
        /// Дата акции.
        /// </summary>
        public DateTime? ActionDate { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public BannerViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public BannerViewModel(Banner banner)
        {
            Id = banner.Id;
            Title = banner.Title;
            Content = banner.Content;
            Url = banner.Url;
            ImageUrl = banner.ImageUrl;
            ButtonText = banner.ButtonText;
            ActionDate = banner.ActionDate;
        }
    }
}
