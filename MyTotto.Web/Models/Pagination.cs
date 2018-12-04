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
        /// Первая страница.
        /// </summary>
        public int First { get; set; }

        /// <summary>
        /// Предыдущая страница.
        /// </summary>
        public int Previous { get; set; }

        /// <summary>
        /// Текущая страница.
        /// </summary>
        public int Current { get; set; }
        
        /// <summary>
        /// Следующая страница.
        /// </summary>
        public int Next { get; set; }

        /// <summary>
        /// Последняя страница.
        /// </summary>
        public int Last { get; set; }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public Pagination(int current, int count)
        {
            First = 1;
            Last = count;
            Current = current;
            Previous = Current - 1 > 0 ? Current - 1 : 1;
            Next = Current + 1 <= Last ? Current + 1 : Last;
        }
    }
}
