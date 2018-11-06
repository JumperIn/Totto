using MyTotto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Models.Layout
{
    /// <summary>
    /// Модель представления для подкатегории в навигационном меню.
    /// </summary>
    public class SubcategoryNavMenuViewModel
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
        public List<GroupNavMenuViewModel> Groups { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public SubcategoryNavMenuViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public SubcategoryNavMenuViewModel
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
                    .Select(group => new GroupNavMenuViewModel(subcategoryLink, group))
                    .ToList()
                : new List<GroupNavMenuViewModel>();
        }
    }
}
