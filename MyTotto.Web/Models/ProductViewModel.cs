using MyTotto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления продукта.
    /// </summary>
    public class ProductViewModel
    {
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
        /// Ссылки на изображения.
        /// </summary>
        public string[] ImageUrls { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public ProductViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public ProductViewModel(Product product)
        {
            Title = product.Title;
            Manufacturer = product.ManufacturerId.ToString();
            Url = product.TitleUrl;
            ImageUrl = product.CardImage;
            Price = product.GetPrice();
            DiscountPrice = product.GetDiscountPrice();
            ProductType = product.ProductType;
            ImageUrls = product.FullImages.Split(";"[0]);
        }
    }
}
