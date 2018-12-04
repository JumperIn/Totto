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

        ///// <summary>
        ///// Ссылка на картинку.
        ///// </summary>
        //public string CardImage { get; set; }

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
        /// Ссылки на изображения.
        /// </summary>
        public string[] ImageUrls { get; set; }

        /// <summary>
        /// Веса фасовки.
        /// </summary>
        public string[] Weights { get; set; }

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
        //public List<ProductCard> SuitableProducts { get; set; }
        public int[] SuitableProductIds { get; set; }

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
            Id = product.Id;
            Title = $"{product.Manufacturer.Title} {product.Title}";
            Manufacturer = product.Manufacturer.Title;
            Url = product.TitleUrl;
            Price = product.GetPrice();
            DiscountPrice = product.GetDiscountPrice();
            ProductType = product.ProductType;
            //ImageUrls = Split(product.FullImages);
            ImageUrls = new string[] { "/images/cream2.png", "/images/cream3.png", "/images/cream4.png" };
            Weights = Split(product.Weights);
            Compounds = product.Compounds.Replace(";", ", ");
            Description = product.Description;
            AdditionalInfo = product.AdditionalInfo;
            SuitableProductIds = IntSplit(product.SuitableProducts);
        }

        private string[] Split(string items)
        {
            return items.Split(";"[0]);
        }

        private int[] IntSplit(string textIds)
        {
            string[] items = Split(textIds);

            var ids = new List<int>();

            foreach (var item in items)
            {
                int id = int.Parse(item);
                ids.Add(id);
            }

            return ids.ToArray();
        }
    }
}
