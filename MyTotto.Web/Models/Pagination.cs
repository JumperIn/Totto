using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель для пагинации.
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// Текущая страница.
        /// </summary>
        public int Current { get; set; }

        /// <summary>
        /// Количество страниц.
        /// </summary>
        public int Count { get; set; }
    }
}
