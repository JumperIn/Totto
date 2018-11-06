using MyTotto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Models.Layout
{
    /// <summary>
    /// Модель представления для категории в навигационном меню.
    /// </summary>
    public class CategoryNavMenuViewModel
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
        public List<SubcategoryNavMenuViewModel> Subcategories { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public CategoryNavMenuViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public CategoryNavMenuViewModel
        (
            ProductCategory category,
            List<ProductSubcategory> subcategories,
            List<ProductGroup> groups
        )
        {
            Title = category.Title;
            Image = "/images/cream.jpg";
            string categoryLink = $"/catalog/{category.SectionUrl}";
            Link = categoryLink;

            Subcategories = category.Subcategories
                .Select(subcategory => new SubcategoryNavMenuViewModel(categoryLink, subcategory))
                .ToList();
        }
    }
}
