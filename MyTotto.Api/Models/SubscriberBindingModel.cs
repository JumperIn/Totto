using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyTotto.Api.Infrastructure;

namespace MyTotto.Api.Models
{
    /// <summary>
    /// Модель для подписчика.
    /// </summary>
    public class SubscriberBindingModel
    {
        private string email;

        /// <summary>
        /// Email.
        /// </summary>
        [Required]
        [EmailAddress]
        [StringLength(MaxLength.Email)]
        public string Email
        {
            get => email;
            set => email = value.ToLower();
        }
    }
}
