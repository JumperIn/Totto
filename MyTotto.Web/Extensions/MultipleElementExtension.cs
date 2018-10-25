using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Extensions
{
    /// <summary>
    /// Расширение для получения кратных элементов.
    /// </summary>
    public static class MultipleElementExtension
    {
        /// <summary>
        /// Возвращает коллекцию элементов, чьё количество взято из кратности деления.
        /// </summary>
        /// <typeparam name="T">Тип.</typeparam>
        /// <param name="items">Список элементов.</param>
        /// <param name="multipleCount">Кратность.</param>
        /// <returns></returns>
        public static IEnumerable<T> TakeMultiple<T>(this IEnumerable<T> items, int multipleCount)
        {
            int itemsCount = items.Count();
            int itemsRow = itemsCount / multipleCount == 0 ? 1 : itemsCount / multipleCount;
            int itemsMultipleCount = itemsRow * multipleCount;

            return items.Take(itemsMultipleCount);
        }
    }
}
