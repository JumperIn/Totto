using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTotto.Data.Models;
using MyTotto.Web.Extensions;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления главной страницы.
    /// </summary>
    public class MainPageViewModel
    {
        /// <summary>
        /// Список баннеров.
        /// </summary>
        public List<BannerViewModel> Banners { get; set; }

        /// <summary>
        /// Блок с продуктами.
        /// </summary>
        public ProductsAllViewModel Products { get; set; }

        /// <summary>
        /// Список промо-блоков.
        /// </summary>
        public List<PromoViewModel> Promos { get; set; }

        /// <summary>
        /// Список промо товаров.
        /// </summary>
        public List<PromoProductViewModel> PromoProducts { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public MainPageViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public MainPageViewModel
        (
            List<Banner> banners, 
            List<Product> products, 
            List<Promo> promos, 
            List<PromoProduct> promoProducts
        )
        {
            Banners = banners.Select(b => new BannerViewModel(b)).ToList();
            Promos = promos.Select(p => new PromoViewModel(p)).ToList();
            PromoProducts = promoProducts.Select(p => new PromoProductViewModel(p)).ToList();
            Products = new ProductsAllViewModel(products);
        }
    }
}
