using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Модель производителя.
    /// </summary>
    public class Manufacturer
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Значение в URL.
        /// URL-значение для параметров.
        /// </summary>
        public string Url { get; set; }

        ///// <summary>
        ///// Продукты, принадлежащие производителю.
        ///// </summary>
        //public List<Product> Products { get; set; }
    }
}
