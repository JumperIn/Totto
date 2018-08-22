using System;
using System.Collections.Generic;
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
        public BannersRepository(string databaseConnection)
        {
            context = new TottoContext(databaseConnection);
        }

        /// <summary>
        /// Возвращает список баннеров.
        /// </summary>
        public List<Banner> GetBanners()
        {
            return context.Banners.ToList();
        }

        /// <summary>
        /// Добавляет баннер в список.
        /// </summary>
        /// <param name="banner">Данные баннера.</param>
        public void AddBanner(Banner banner)
        {
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
    }
}
