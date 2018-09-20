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
        public Guid Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Фирма-изготовитель.
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// URL-адрес продукта.
        /// </summary>
        public string Url { get; set; }

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
        /// Признак активного элемента.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Строка с массивом ссылок на изображения.
        /// </summary>
        public string ImageUrls { get; set; }
    }
}
