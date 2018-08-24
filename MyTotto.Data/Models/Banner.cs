using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Модель новостного баннера.
    /// </summary>
    public class Banner
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Заголовок.
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Содержание.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Адрес, куда ведёт кнопка.
        /// </summary>
        [Required]
        public string Url { get; set; }

        /// <summary>
        /// Ссылка на изображение баннера.
        /// </summary>
        [Required]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Текст кнопки.
        /// Если не пустое значение - кнопка есть.
        /// Иначе - кнопки нет.
        /// </summary>
        public string ButtonText { get; set; }

        /// <summary>
        /// Порядок, в котором выводится баннер.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Признак активного элемента.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Дата акции.
        /// </summary>
        public DateTime? ActionDate { get; set; }

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime Created { get; set; }
    }
}
