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
        /// Ссылка на изображение баннера.
        /// </summary>
        public string ImageUrl { get; set; }
        
        /// <summary>
        /// Дата акции.
        /// </summary>
        public string ActionDate { get; set; }

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
            ImageUrl = banner.ImageUrl;
            ActionDate = banner.ActionDate?.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}
