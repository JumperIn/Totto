using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTotto.Data.Models;

namespace MyTotto.Web.Models.Layout
{
    /// <summary>
    /// Модель представления для навигационного меню.
    /// </summary>
    public class NavMenuViewModel
    {
        /// <summary>
        /// Список категорий.
        /// </summary>
        public List<CategoryNavMenuViewModel> Categories { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public NavMenuViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public NavMenuViewModel
        (
            List<ProductCategory> categories, 
            List<ProductSubcategory> subcategories, 
            List<ProductGroup> groups
        )
        {
            Categories = categories
                .Select(category => new CategoryNavMenuViewModel(category, subcategories, groups))
                .ToList();
        }
    }
}
