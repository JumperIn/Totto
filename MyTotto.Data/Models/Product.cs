using System;
using System.Collections.Generic;
using System.Text;
using MyTotto.Data.Abstract;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Модель продукта.
    /// </summary>
    public class Product : IActive
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
        /// Идентификатор фирмы-изготовителя.
        /// </summary>
        public int ManufacturerId { get; set; }

        /// <summary>
        /// Фирма-изготовитель.
        /// </summary>
        public Manufacturer Manufacturer { get; set; }

        /// <summary>
        /// Название на латинице для URL-адреса продукта.
        /// </summary>
        public string TitleUrl { get; set; }

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
        public string CardImage { get; set; }

        /// <summary>
        /// Цена продукта.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Скидка на продукт в %.
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Цена продукта после скидки.
        /// </summary>
        public decimal DiscountPrice { get; set; }

        /// <summary>
        /// Тип продукта.
        /// </summary>
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Картинки для галереи.
        /// </summary>
        public string FullImages { get; set; }

        /// <summary>
        /// Веса фасовки.
        /// </summary>
        public string Weights { get; set; }

        /// <summary>
        /// Состав.
        /// </summary>
        public string Compounds { get; set; }

        /// <summary>
        /// Описание товара.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Дополнительная информация.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Подходящие продукты.
        /// </summary>
        public string SuitableProducts { get; set; }

        /// <summary>
        /// Признак активного элемента.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime Created { get; set; }


        /// <summary>
        /// Возвращает цену в нужном формате.
        /// </summary>
        public string GetPrice()
        {
            return FormatPrice(Price);
        }

        /// <summary>
        /// Возвращает цену с учётом скидки.
        /// </summary>
        public string GetDiscountPrice()
        {
            return FormatPrice(((100 - Discount) / 100 * Price));
        }

        private string FormatPrice(decimal price)
        {
            return price.ToString("0.00");
        }
    }
}
