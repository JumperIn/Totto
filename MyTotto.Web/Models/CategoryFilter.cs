using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Фильтр категорий.
    /// </summary>
    public class CategoryFilter
    {
        /// <summary>
        /// Название-заголовок.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Список элементов в фильтре.
        /// </summary>
        public List<CategoryFilterItem> Items { get; set; }

        /// <summary>
        /// Создает экземпляр и иницилизирует поля.
        /// </summary>
        /// <param name="title">Название.</param>
        /// <param name="items">Элементы.</param>
        public CategoryFilter(string title, List<CategoryFilterItem> items)
        {
            Title = title;
            Items = items;
        }
    }
}
