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
            int itemsCount = items.Count();
            int maxCount = itemsCount > count ? count : itemsCount;
            var indexes = new List<int>();

            // Набираем из полного списка количество для страницы
            for (int i = 0; i < maxCount; i++)
            {
                int index = random.Next(itemsCount);
                bool isExistIndex = indexes.Contains(index);

                // Перебираем вперед по массиву, пока не найдём не выбранный индекс
                while (isExistIndex)
                {
                    index = index >= itemsCount - 1 ? 0 : index + 1;
                    isExistIndex = indexes.Contains(index);
                }

                indexes.Add(index);
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
