using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTotto.Data.Models.Layout
{
    /// <summary>
    /// Модель категории в навигационном меню.
    /// </summary>
    public class NavigationCategory
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
        /// Мини-изображение.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Список подкатегорий.
        /// </summary>
        public List<NavigationSubcategory> Subcategories { get; set; }
        
        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public NavigationCategory
        (
            ProductCategory category,
            List<ProductSubcategory> subcategories,
            List<ProductGroup> groups
        )
        {
            Title = category.Title;
            Image = category.Image;
            string categoryLink = $"/catalog/{category.SectionUrl}";
            Link = categoryLink;

            Subcategories = category.Subcategories
                .Select(subcategory => new NavigationSubcategory(categoryLink, subcategory))
                .ToList();
        }
    }
}
