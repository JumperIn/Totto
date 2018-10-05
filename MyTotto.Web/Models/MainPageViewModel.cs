using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTotto.Data.Models;

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
        /// Список карточек продуктов.
        /// </summary>
        public List<ProductCardViewModel> Products { get; set; }

        /// <summary>
        /// Список промо-блоков.
        /// </summary>
        public List<PromoViewModel> Promos { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public MainPageViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public MainPageViewModel(List<Banner> banners, List<Product> products, List<Promo> promos)
        {
            Banners = banners.Select(b => new BannerViewModel(b)).ToList();
            Products = products.Select(p => new ProductCardViewModel(p)).ToList();
            Promos = promos.Select(p => new PromoViewModel(p)).ToList();
        }
    }
}
