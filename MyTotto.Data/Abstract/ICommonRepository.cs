using System;
using System.Collections.Generic;
using System.Text;
using MyTotto.Data.Models;

namespace MyTotto.Data.Abstract
{
    public interface ICommonRepository
    {
        /// <summary>
        /// Возвращает список баннеров.
        /// </summary>
        List<Banner> GetBanners();

        /// <summary>
        /// Добавляет баннер в список.
        /// </summary>
        /// <param name="banner">Данные баннера.</param>
        void AddBanner(Banner banner);

        /// <summary>
        /// Обновляет баннер в списке.
        /// </summary>
        /// <param name="banner">Данные баннера.</param>
        void UpdateBanner(Banner banner);
    }
}
