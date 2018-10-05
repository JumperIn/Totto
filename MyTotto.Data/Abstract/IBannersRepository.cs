using System;
using System.Collections.Generic;

using MyTotto.Data.Models;

namespace MyTotto.Data.Abstract
{
    /// <summary>
    /// Интерфейс для работы с баннерами.
    /// </summary>
    public interface IBannersRepository
    {
        /// <summary>
        /// Возвращает список баннеров в порядке сортировки Order.
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

        /// <summary>
        /// Удаляет баннер по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор баннера.</param>
        void DeleteBanner(int id);
    }
}
