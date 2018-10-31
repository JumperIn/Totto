using System;
using System.Collections.Generic;
using System.Text;
using MyTotto.Data.Abstract;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Модель для подкатегории продукта.
    /// </summary>
    public class ProductSubcategory : ISorted
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
        /// Список групп, относящихся к подкатегории.
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
