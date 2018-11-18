using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTotto.Data.Models.Layout
{
    /// <summary>
    /// Модель подкатегории в навигационном меню.
    /// </summary>
    public class NavigationSubcategory
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
        /// Список групп.
        /// </summary>
        public List<NavigationGroup> Groups { get; set; }
        
        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public NavigationSubcategory
        (
            string categoryLink,
            ProductSubcategory subcategory
        )
        {
            Title = subcategory.Title;
            string subcategoryLink = $"{categoryLink}/{subcategory.SectionUrl}";
            Link = subcategoryLink;

            Groups = subcategory.Groups != null ?
                subcategory.Groups
                    .Where(s => s.ProductSubcategoryId == subcategory.Id)
                    .Select(group => new NavigationGroup(subcategoryLink, group))
                    .ToList()
                : new List<NavigationGroup>();
        }
    }
}
