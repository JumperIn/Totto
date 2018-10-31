using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Abstract
{
    /// <summary>
    /// Интерфейс активного элемента.
    /// </summary>
    public interface IActive
    {
        /// <summary>
        /// Признак активного элемента.
        /// </summary>
        bool IsActive { get; set; }
    }
}
