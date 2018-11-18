using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Models.Layout
{
    /// <summary>
    /// Модель хлебной крошки
    /// </summary>
    public class Breadcrumb
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Ссылка.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Признак активной ссылки.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        /// <param name="title">Название.</param>
        /// <param name="link">Ссылка.</param>
        /// <param name="isActive">Признак активной ссылки.</param>
        public Breadcrumb(string title, string link, bool isActive = true)
        {
            Title = title;
            Link = link;
            IsActive = isActive;
        }
    }
}
