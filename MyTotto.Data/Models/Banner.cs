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
        /// Ссылка на изображение баннера.
        /// </summary>
        [Required]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Цвет фона для контента.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Порядок, в котором выводится баннер.
        /// </summary>
        [Required]
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

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public Banner()
        {
        }
    }
}
