using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Enums
{
    /// <summary>
    /// Тип сортировки продуктов в каталоге.
    /// </summary>
    public enum CatalogSortingType
    {
        /// <summary>
        /// По возрастанию названию.
        /// </summary>
        AscendingTitle = 0,

        /// <summary>
        /// По убыванию названию.
        /// </summary>
        DescendingTitle,

        /// <summary>
        /// По возрастанию цены.
        /// </summary>
        AscendingPrice,

        /// <summary>
        /// По убыванию цены.
        /// </summary>
        DescendingPrice,

        /// <summary>
        /// Сперва новинки.
        /// </summary>
        DiscountFirst
    }
}
