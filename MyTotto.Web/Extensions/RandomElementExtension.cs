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
            int maxCount = items.Count() > count ? count : items.Count();
            var indexes = new List<int>();

            for (int i = 0; i < maxCount; i++)
            {
                int num = 0;
                bool isExistIndex = false;

                do
                {
                    num = random.Next(maxCount);
                    isExistIndex = indexes.Contains(num);

                    if (!isExistIndex)
                    {
                        indexes.Add(num);
                    }

                } while (!isExistIndex);
            }

            var list = new List<T>();

            foreach (var index in indexes)
            {
                list.Add(items.ElementAt(index));
            }

            return list;
        }
    }
}
