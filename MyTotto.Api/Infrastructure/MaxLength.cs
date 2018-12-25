using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTotto.Api.Infrastructure
{
    /// <summary>
    /// Максимальный размер поля.
    /// </summary>
    public static class MaxLength
    {
        /// <summary>
        /// Максимальный размер поля для имени.
        /// </summary>
        public const int Name = 50;

        /// <summary>
        /// Максимальный размер поля для телефона.
        /// </summary>
        public const int Phone = 20;
    }
}
