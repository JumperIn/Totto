using System;
using System.Collections.Generic;
using System.Linq;

using MyTotto.Data.Models;
using MyTotto.Web.Extensions;
using MyTotto.Web.Models.Layout;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления главной страницы.
    /// </summary>
    public class MainPageViewModel
    {
        /// <summary>
        /// SEO-настройки.
        /// </summary>
        public SeoViewModel Seo { get; set; }

        /// <summary>
        /// Навигационное меню.
        /// </summary>
        public NavMenuViewModel Navigation { get; set; }

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
            List<ProductCategory> categories,
            List<ProductSubcategory> subcategories,
            List<ProductGroup> groups,
            List<Banner> banners, 
            List<Product> products, 
            List<Promo> promos, 
            List<PromoProduct> promoProducts
        )
        {
            string title = "MyTotto - Онлайн-магазин косметики";
            string description = "Интернет-магазин корейской косметики";
            string keywords = "Купить косметику корейскую";

            Navigation = new NavMenuViewModel(categories, subcategories, groups);
            Seo = new SeoViewModel(title, description, keywords);
            Banners = banners.Select(b => new BannerViewModel(b)).ToList();
            Promos = promos.Select(p => new PromoViewModel(p)).ToList();
            PromoProducts = promoProducts.Select(p => new PromoProductViewModel(p)).ToList();
            Products = new ProductsAllViewModel(products);
        }
    }
}
