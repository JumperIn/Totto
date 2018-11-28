using MyTotto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления карточки продукта.
    /// </summary>
    public class ProductCard
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
        public string Price { get; set; }

        /// <summary>
        /// Цена с учётом % скидки.
        /// </summary>
        public string DiscountPrice { get; set; }

        /// <summary>
        /// Тип продукта.
        /// </summary>
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public ProductCard()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public ProductCard(Product product)
        {
            Id = product.Id;
            Title = product.Title;
            Manufacturer = product.ManufacturerId.ToString();
            Url = SetUrl(product.Id, product.TitleUrl);
            ImageUrl = product.CardImage;
            Price = product.GetPrice();
            DiscountPrice = product.GetDiscountPrice();
            ProductType = product.ProductType;
        }

        private string SetUrl(int id, string titleUrl)
        {
            return $"/products/{id}-{titleUrl}";
        }
    }
}
