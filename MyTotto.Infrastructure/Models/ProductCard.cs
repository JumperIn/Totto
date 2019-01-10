using System;
using System.Collections.Generic;
using System.Text;
using MyTotto.Data.Models;

namespace MyTotto.BusinessLogic.Models
{
    /// <summary>
    /// Модель карточки продукта.
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
        public string CardImage { get; set; }

        /// <summary>
        /// Цена продукта.
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Цена с учётом % скидки.
        /// </summary>
        public string DiscountPrice { get; set; }

        /// <summary>
        /// Признак наличия скидки.
        /// </summary>
        public bool IsExistDiscount { get; set; }

        /// <summary>
        /// Модификатор класса для типа продукта.
        /// </summary>
        public string ProductTypeModifier { get; set; }

        /// <summary>
        /// Тип продукта.
        /// </summary>
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public ProductCard()
        {
            Id = 0;
            Title = string.Empty;
            Manufacturer = string.Empty;
            Url = string.Empty;
            CardImage = string.Empty;
            Price = string.Empty;
            DiscountPrice = string.Empty;
            IsExistDiscount = true;
            ProductType = ProductType.Normal;
            ProductTypeModifier = string.Empty;
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public ProductCard(Product product)
        {
            Id = product.Id;
            Title = $"{product.Manufacturer.Title} {product.Title}";
            Manufacturer = product.Manufacturer.Title;
            Url = SetUrl(product.Id, product.TitleUrl);
            CardImage = product.CardImage;
            Price = product.GetPrice();
            DiscountPrice = product.GetDiscountPrice();
            IsExistDiscount = product.DiscountPrice < product.Price; // product.ProductType == ProductType.Discount
            ProductType = product.ProductType;
            ProductTypeModifier = SetModifier(product.ProductType);
        }

        private string SetUrl(int id, string titleUrl)
        {
            return $"/products/{id}-{titleUrl}";
        }

        private string SetModifier(ProductType type)
        {
            string modifier = "";
            switch (type)
            {
                case ProductType.New:
                    modifier = "new";
                    break;
                case ProductType.Hit:
                    modifier = "hit";
                    break;
                case ProductType.Discount:
                    modifier = "discount";
                    break;
                default:
                    modifier = "normal";
                    break;
            }

            return modifier;
        }
    }
}
