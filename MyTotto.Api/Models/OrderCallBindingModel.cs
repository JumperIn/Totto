using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyTotto.Api.Infrastructure;

namespace MyTotto.Api.Models
{
    /// <summary>
    /// Модель для заказа звонка.
    /// </summary>
    public class OrderCallBindingModel
    {
        /// <summary>
        /// Имя.
        /// </summary>
        [Required]
        [RegularExpression(RegExps.Name)]
        [StringLength(MaxLength.Name)]
        public string Name { get; set; }

        /// <summary>
        /// Телефон.
        /// </summary>
        [Required]
        [RegularExpression(RegExps.Phone)]
        [StringLength(MaxLength.Phone)]
        public string Phone { get; set; }
    }
}
