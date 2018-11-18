using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Enums
{
    /// <summary>
    /// Наличие скидки у продуктов.
    /// </summary>
    public enum ProductDiscount
    {
        /// <summary>
        /// Любой.
        /// </summary>
        Any = 0,

        /// <summary>
        /// Со скидкой.
        /// </summary>
        With = 1,

        /// <summary>
        /// Без скидки.
        /// </summary>
        Without = 2       
    }
}
