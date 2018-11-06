using System;
using System.Collections.Generic;
using System.Linq;
using MyTotto.Data.Models;

namespace MyTotto.Web.Models.Layout
{
    /// <summary>
    /// Модель представления для группы в навигационном меню.
    /// </summary>
    public class GroupNavMenuViewModel
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
        /// Создает экземпляр.
        /// </summary>
        public GroupNavMenuViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public GroupNavMenuViewModel(string subcategoryLink, ProductGroup group)
        {
            Title = group.Title;
            Link = $"{subcategoryLink}/{group.SectionUrl}";
        }
    }
}
