using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Api.Infrastructure
{
    /// <summary>
    /// Регулярные выражения для полей.
    /// </summary>
    public static class RegExps
    {
        /// <summary>
        /// Регулярное выражение для имени.
        /// </summary>
        public const string Name = @"^\s*[a-zA-Zа-яА-ЯёЁ,\s]+\s*$";

        /// <summary>
        /// Регулярное выражение для телефона.
        /// </summary>
        //public const string Phone = @"^([0-9]( |-)?)?(\(?[0-9]{3}\)?|[0-9]{3})( |-)?([0-9]{3}( |-)?[0-9]{4}|[a-zA-Z0-9]{7})$";
        //public const string Phone = @"^([0-9\s\(\)\+]*$";
        public const string Phone = @"^[0-9]*$";
    }
}
