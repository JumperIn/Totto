using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Models.Layout
{
    /// <summary>
    /// Модель группы в навигационном меню.
    /// </summary>
    public class NavigationGroup
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
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public NavigationGroup(string subcategoryLink, ProductGroup group)
        {
            Title = group.Title;
            Link = $"{subcategoryLink}/{group.SectionUrl}";
        }
    }
}
