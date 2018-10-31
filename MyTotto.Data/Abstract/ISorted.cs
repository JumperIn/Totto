using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Abstract
{
    /// <summary>
    /// Интерфейс сортируемого элемента.
    /// </summary>
    public interface ISorted : IActive
    {
        /// <summary>
        /// Порядок, в котором выводится баннер.
        /// </summary>
        int Order { get; set; }
    }
}
