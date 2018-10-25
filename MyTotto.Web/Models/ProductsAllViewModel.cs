using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTotto.Data.Models;
using MyTotto.Web.Extensions;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления продуктов.
    /// </summary>
    public class ProductsAllViewModel
    {
        /// <summary>
        /// Список карточек всех продуктов.
        /// </summary>
        public List<ProductCardViewModel> AllProducts { get; set; }

        /// <summary>
        /// Список карточек продуктов-новинок.
        /// </summary>
        public List<ProductCardViewModel> NewProducts { get; set; }

        /// <summary>
        /// Список карточек продуктов-хитов.
        /// </summary>
        public List<ProductCardViewModel> HitProducts { get; set; }

        /// <summary>
        /// Список карточек продуктов со скидками.
        /// </summary>
        public List<ProductCardViewModel> DiscountProducts { get; set; }

        private int maxCount = 12;
        private int multipleCount = 4;

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public ProductsAllViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public ProductsAllViewModel(List<Product> products)
        {
            NewProducts = SelectProductCardByType(products, ProductType.New);
            HitProducts = SelectProductCardByType(products, ProductType.Hit);
            DiscountProducts = SelectProductCardByType(products, ProductType.Discount);

            AllProducts = NewProducts.Concat(DiscountProducts).Concat(HitProducts)
                .RandomElements(maxCount)
                .TakeMultiple(multipleCount)
                .ToList();
        }

        private List<ProductCardViewModel> SelectProductCardByType(List<Product> products, ProductType type)
        {
            return products
                .Where(p => p.ProductType == type)
                .RandomElements(maxCount)
                .TakeMultiple(multipleCount)
                .Select(p => new ProductCardViewModel(p))
                .ToList();
        }
    }
}
