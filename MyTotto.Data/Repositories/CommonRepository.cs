using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTotto.Data.Abstract;
using MyTotto.Data.Models;
using MyTotto.Data.Models.Layout;

namespace MyTotto.Data.Repositories
{
    /// <summary>
    /// Общий репозиторий.
    /// </summary>
    public class CommonRepository : BaseRepository, ICommonRepository
    {
        private ICatalogRepository catalogRepository;

        public CommonRepository(TottoContext context, ICatalogRepository catalogRepository)
        {
            this.context = context;
            this.catalogRepository = catalogRepository;
        }

        #region SEO

        /// <summary>
        /// Возвращает SEO-данные для страницы..
        /// </summary>
        public SeoData GetSeo(string key)
        {
            SeoData seo = new SeoData();

            switch (key)
            {
                case "main":
                    seo.Title = "MyTotto - Онлайн-магазин косметики";
                    seo.Description = "Интернет-магазин корейской косметики";
                    seo.Keywords = "Купить косметику корейскую";
                    break;
                case "catalog":
                    seo.Title = "Каталог - MyTotto - Онлайн-магазин косметики";
                    seo.Description = "Интернет-магазин корейской косметики";
                    seo.Keywords = "Купить косметику корейскую";
                    break;
                case "product":
                    seo.Title = "Продукт - MyTotto - Онлайн-магазин косметики";
                    seo.Description = "Интернет-магазин корейской косметики";
                    seo.Keywords = "Купить косметику корейскую";
                    break;
                default:
                    seo.Title = "Остальное - MyTotto - Онлайн-магазин косметики";
                    seo.Description = "Интернет-магазин корейской косметики";
                    seo.Keywords = "Купить косметику корейскую";
                    break;
            }

            return seo;
        }

        #endregion

        #region Navigation

        /// <summary>
        /// Возвращает модель навигационного меню.
        /// </summary>
        public Navigation GetNavigation()
        {
            List<ProductCategory> categories = catalogRepository.GetCategories();
            List<ProductSubcategory> subcategories = catalogRepository.GetSubcategories();
            List<ProductGroup> groups = catalogRepository.GetGroups();
            var navigation = new Navigation(categories, subcategories, groups);

            return navigation;
        }

        #endregion

    }
}
