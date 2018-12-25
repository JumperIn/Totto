using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MyTotto.Data.Abstract;

namespace MyTotto.Data.Models
{
    /// <summary>
    /// Модель заказанного звонка.
    /// </summary>
    public class OrderCall
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Телефон.
        /// </summary>
        [Required]
        public string Phone { get; set; }

        /// <summary>
        /// Признак уже состоявшегося звонка.
        /// </summary>
        public bool IsCalled { get; set; }

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public OrderCall()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля.
        /// </summary>
        public OrderCall(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
