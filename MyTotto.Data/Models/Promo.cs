using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Модель промо-блока.
    /// </summary>
    public class Promo
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Заголовок.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Содержание.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// URL-адрес.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Ссылка на изображение.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Порядок, в котором выводится элемент.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Признак активного элемента.
        /// </summary>
        public bool IsActive { get; set; }
        
        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime Created { get; set; }
    }
}
