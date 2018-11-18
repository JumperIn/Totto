using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTotto.Data.Models.Layout
{
    /// <summary>
    /// Модель для навигационного меню.
    /// </summary>
    public class Navigation
    {
        /// <summary>
        /// Список категорий.
        /// </summary>
        public List<NavigationCategory> Categories { get; set; }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public Navigation
        (
            List<ProductCategory> categories,
            List<ProductSubcategory> subcategories,
            List<ProductGroup> groups
        )
        {
            Categories = categories
                .Select(category => new NavigationCategory(category, subcategories, groups))
                .ToList();
        }
    }
}
