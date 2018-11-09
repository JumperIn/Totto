﻿using System;
using System.Collections.Generic;
using System.Linq;

using MyTotto.Data.Models;
using MyTotto.Data.Models.Layout;
using MyTotto.Web.Extensions;
using MyTotto.Web.Models.Layout;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления главной страницы.
    /// </summary>
    public class MainPageViewModel : BasePageViewModel
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
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public MainPageViewModel
        (
            SeoData seo,
            Navigation navigation,
            List<Banner> banners, 
            List<Product> products, 
            List<Promo> promos, 
            List<PromoProduct> promoProducts
        ) :base(seo, navigation)
        {
            Banners = banners.Select(b => new BannerViewModel(b)).ToList();
            Promos = promos.Select(p => new PromoViewModel(p)).ToList();
            PromoProducts = promoProducts.Select(p => new PromoProductViewModel(p)).ToList();
            Products = new ProductsAllViewModel(products);
        }
    }
}
