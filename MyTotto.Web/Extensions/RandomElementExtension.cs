using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Web.Extensions
{
    /// <summary>
    /// Расширение для получения случайных элементов.
    /// </summary>
    public static class RandomElementExtension
    {
        private static Random random = new Random();

        /// <summary>
        /// Возвращает случайный элемент из списка.
        /// </summary>
        /// <typeparam name="T">Тип.</typeparam>
        /// <param name="items">Список элементов.</param>
        public static T RandomElement<T>(this IEnumerable<T> items)
        {
            int number = random.Next(items.Count());
            return items.ElementAt(number);
        }

        /// <summary>
        /// Возвращает коллекцию случайных элементов по количеству.
        /// </summary>
        /// <typeparam name="T">Тип.</typeparam>
        /// <param name="items">Список элементов.</param>
        /// <param name="count">Количество элементов.</param>
        /// <returns></returns>
        public static IEnumerable<T> RandomElements<T>(this IEnumerable<T> items, int count)
        {
            var list = new List<T>();

            for (int i = 0; i < items.Count() && i < count; i++)
            {
                list.Add(items.RandomElement());
            }

            return list;
        }
    }
}
