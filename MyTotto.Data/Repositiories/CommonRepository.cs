using System;
using System.Collections.Generic;
using System.Linq;

using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Data.Repositories
{
    /// <summary>
    /// Репозиторий для общих элементов.
    /// </summary>
    public class CommonRepository : BaseRepository, ICommonRepository
    {
        public CommonRepository()
        {
            this.context = null;
        }

        /// <summary>
        /// Возвращает список баннеров.
        /// </summary>
        public List<Banner> GetBanners()
        {
            return context.Banners.ToList();
        }

        /// <summary>
        /// Возвращает список карточек продуктов.
        /// </summary>
        public List<ProductCard> GetProductCards()
        {
            return context.ProductCards.ToList();
        }

        /// <summary>
        /// Возвращает список промо-блоков.
        /// </summary>
        public List<Promo> GetPromos()
        {
            return context.Promos.ToList();
        }
    }
}
