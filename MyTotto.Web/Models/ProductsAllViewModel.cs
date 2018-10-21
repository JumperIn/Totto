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
            int maxCount = 12;

            NewProducts = products
                .Where(p => p.ProductType == ProductType.New)
                .RandomElements(maxCount)
                .Select(p => new ProductCardViewModel(p))
                .ToList();

            HitProducts = products
                .Where(p => p.ProductType == ProductType.Hit)
                .RandomElements(maxCount)
                .Select(p => new ProductCardViewModel(p))
                .ToList();

            DiscountProducts = products
                .Where(p => p.ProductType == ProductType.Discount)
                .RandomElements(maxCount)
                .Select(p => new ProductCardViewModel(p))
                .ToList();

            AllProducts = NewProducts
                .Concat(DiscountProducts)
                .Concat(HitProducts)
                .ToList();
        }
    }
}
