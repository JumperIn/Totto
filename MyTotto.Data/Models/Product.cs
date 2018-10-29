using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Модель продукта.
    /// </summary>
    public class Product
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
        /// Фирма-изготовитель.
        /// </summary>
        public string Manufacturer { get; set; }

        ///// <summary>
        ///// URL-адрес продукта.
        ///// </summary>
        //public string Url { get; set; }

        /// <summary>
        /// Идентификатор категории продукта.
        /// </summary>
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// Категория продукта.
        /// </summary>
        public ProductCategory ProductCategory { get; set; }

        /// <summary>
        /// Идентификатор подкатегории продукта.
        /// </summary>
        public int ProductSubcategoryId { get; set; }

        /// <summary>
        /// Подкатегория продукта.
        /// </summary>
        public ProductSubcategory ProductSubcategory { get; set; }

        /// <summary>
        /// Идентификатор группы продукта.
        /// </summary>
        public int? ProductGroupId { get; set; }

        /// <summary>
        /// Группа продукта.
        /// </summary>
        public ProductGroup ProductGroup { get; set; }

        /// <summary>
        /// Ссылка на картинку.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Цена продукта.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Скидка на продукт в %.
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Тип продукта.
        /// </summary>
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Строка с массивом ссылок на изображения.
        /// </summary>
        public string ImageUrls { get; set; }

        /// <summary>
        /// Признак активного элемента.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime Created { get; set; }
    }
}
