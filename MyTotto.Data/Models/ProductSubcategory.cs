using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Модель для подкатегории продукта.
    /// </summary>
    public class ProductSubcategory
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
        /// Идентификатор категории продукта.
        /// </summary>
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// Категория продукта.
        /// </summary>
        public ProductCategory ProductCategory { get; set; }

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
