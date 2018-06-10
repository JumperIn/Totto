using System;
using System.Collections.Generic;
using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Data.Repositories
{
    public class CommonRepository : ICommonRepository
    {
        /// <summary>
        /// Получает список баннеров.
        /// </summary>
        public List<Banner> GetBanners()
        {
            return new List<Banner>();
        }
    }
}
