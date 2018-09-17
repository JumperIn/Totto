using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Data.Repositories
{
    /// <summary>
    /// Репозиторий для баннеров.
    /// </summary>
    public class BannersRepository : BaseRepository, IBannersRepository
    {
        public BannersRepository(TottoContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Возвращает список баннеров в порядке сортировки Order.
        /// </summary>
        public List<Banner> GetBanners()
        {
            List<Banner> banners = context.Banners
                .OrderBy(b => b.Order)
                .ToList();

            return banners;
        }

        /// <summary>
        /// Возвращает баннер по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор баннера.</param>
        public Banner GetBanner(int id)
        {
            return context.Banners.FirstOrDefault(b => b.Id == id);
        }

        /// <summary>
        /// Добавляет баннер в список.
        /// </summary>
        /// <param name="banner">Данные баннера.</param>
        public void AddBanner(Banner banner)
        {
            banner.Created = DateTime.Now;
            context.Banners.Add(banner);
            Save();
        }

        /// <summary>
        /// Обновляет баннер в списке.
        /// </summary>
        /// <param name="banner">Данные баннера.</param>
        public void UpdateBanner(Banner banner)
        {
            context.Banners.Update(banner);
            Save();
        }

        /// <summary>
        /// Удаляет баннер по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор баннера.</param>
        public void DeleteBanner(int id)
        {
            Banner banner = GetBanner(id);

            if (banner == null)
            {
                return;
            }

            context.Banners.Remove(banner);
            Save();
        }
    }
}
