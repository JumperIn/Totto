using System;
using System.Collections.Generic;
using System.Text;
using MyTotto.Data.Abstract;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Модель для категории продукта.
    /// </summary>
    public class ProductCategory : ISorted
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
        /// URL-адрес секции.
        /// </summary>
        public string SectionUrl { get; set; }

        /// <summary>
        /// Изображение для меню.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Список подкатегорий, относящихся к категории.
        /// </summary>
        public List<ProductSubcategory> Subcategories { get; set; }

        /// <summary>
        /// Список групп, относящихся к категории.
        /// </summary>
        public List<ProductGroup> Groups { get; set; }

        /// <summary>
        /// Признак показа на сайте.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Порядок сортировки в выдаче.
        /// </summary>
        public int Order { get; set; }
    }
}
