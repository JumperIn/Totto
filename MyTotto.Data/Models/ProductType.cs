using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Тип продукта.
    /// </summary>
    public enum ProductType
    {
        /// <summary>
        /// Хиты продаж.
        /// </summary>
        Hit,

        /// <summary>
        /// Новинки.
        /// </summary>
        New,

        /// <summary>
        /// Скидки и акции.
        /// </summary>
        Discount,

        /// <summary>
        /// Обычный продукт.
        /// </summary>
        Normal
    }
}
