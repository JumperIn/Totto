using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Модель подписчика.
    /// </summary>
    public class Subscriber
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Телефон.
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public Subscriber()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public Subscriber(string email)
        {
            Email = email;
        }
    }
}
