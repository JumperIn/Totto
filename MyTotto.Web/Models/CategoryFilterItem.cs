using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Элемент фильтра категорий.
    /// </summary>
    public class CategoryFilterItem
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Значение для URL.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Создает экземпляр и иницилизирует поля.
        /// </summary>
        public CategoryFilterItem(int id, string title, string url)
        {
            Id = id;
            Title = title;
            Url = url;
        }
    }
}
