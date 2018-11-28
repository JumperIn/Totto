using System;
using System.Collections.Generic;
using System.Linq;
using MyTotto.Data.Models;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления для фильтров в Каталоге.
    /// </summary>
    public class CatalogFilters
    {
        /// <summary>
        /// Минимальная цена.
        /// </summary>
        public int MinPrice { get; set; }

        /// <summary>
        /// Максимальная цена.
        /// </summary>
        public int MaxPrice { get; set; }

        /// <summary>
        /// Наличие или отсутствие скидки.
        /// </summary>
        public bool IsExistDiscount { get; set; }

        /// <summary>
        /// Список производителей.
        /// </summary>
        public List<Manufacturer> Manufacturers { get; set; }

        /// <summary>
        /// Список фильтров по категориям.
        /// </summary>
        public List<CategoryFilter> CategoryFilters { get; set; }
    }
}
