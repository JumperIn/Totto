using System;
using System.Collections.Generic;
using System.Text;
using DataM = MyTotto.Data.Models;

namespace MyTotto.ApplicationCore.Entities.Components
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
        /// Заголовок.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Содержание.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Ссылка на изображение баннера.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Цвет фона для контента.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Дата акции.
        /// </summary>
        public string ActionDate { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public Banner()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public Banner(DataM.Banner banner)
        {
            Id = banner.Id;
            Title = banner.Title;
            Content = banner.Content;
            ImageUrl = banner.ImageUrl;
            BackgroundColor = !string.IsNullOrWhiteSpace(banner.BackgroundColor) ? $"#{banner.BackgroundColor}" : "#ffffff";
            ActionDate = banner.ActionDate?.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}
