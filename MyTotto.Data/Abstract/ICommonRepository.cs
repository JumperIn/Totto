using System;
using System.Collections.Generic;
using MyTotto.Data.Models;
using MyTotto.Data.Models.Layout;

namespace MyTotto.Data.Abstract
{
    /// <summary>
    /// Интерфейс для работы с общими элементами.
    /// </summary>
    public interface ICommonRepository
    {
        #region SEO

        /// <summary>
        /// Возвращает SEO-данные для страницы..
        /// </summary>
        SeoData GetSeo(string key);

        #endregion

        #region Navigation

        /// <summary>
        /// Возвращает модель навигационного меню.
        /// </summary>
        Navigation GetNavigation();

        #endregion
    }
}
