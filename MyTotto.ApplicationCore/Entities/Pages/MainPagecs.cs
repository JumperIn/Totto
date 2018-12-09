using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTotto.ApplicationCore.Entities.Pages
{
    /// <summary>
    /// Модель представления главной страницы.
    /// </summary>
    public class MainPage : BasePage
    {
        /// <summary>
        /// Список баннеров.
        /// </summary>
        public List<Banner> Banners { get; set; }

        /// <summary>
        /// Блок с продуктами.
        /// </summary>
        public ProductsAll Products { get; set; }

        /// <summary>
        /// Список промо-блоков.
        /// </summary>
        public List<Promo> Promos { get; set; }

        /// <summary>
        /// Список промо товаров.
        /// </summary>
        public List<PromoProduct> PromoProducts { get; set; }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public MainPage
        (
            SeoData seo,
            Navigation navigation,
            List<Breadcrumb> breadcrumbs,
            List<Banner> banners,
            List<Product> products,
            List<Promo> promos,
            List<PromoProduct> promoProducts
        ) : base(seo, navigation, breadcrumbs)
        {
            Banners = banners.Select(b => new BannerViewModel(b)).ToList();
            Promos = promos.Select(p => new PromoViewModel(p)).ToList();
            PromoProducts = promoProducts.Select(p => new PromoProductViewModel(p)).ToList();
            Products = new ProductsAllViewModel(products);
        }
    }
