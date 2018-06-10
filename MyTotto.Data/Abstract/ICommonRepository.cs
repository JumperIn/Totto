using System;
using System.Collections.Generic;
using System.Text;
using MyTotto.Data.Models;

namespace MyTotto.Data.Abstract
{
    interface ICommonRepository
    {
        /// <summary>
        /// Получает список баннеров.
        /// </summary>
        List<Banner> GetBanners();
    }
}
