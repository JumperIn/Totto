using System;
using System.Collections.Generic;

using MyTotto.Data.Models;

namespace MyTotto.Data.Abstract
{
    /// <summary>
    /// Интерфейс для работы с заказанными звонками.
    /// </summary>
    public interface ICallsRepository
    {
        /// <summary>
        /// Сохраняет заказ обратного звонка.
        /// </summary>
        /// <param name="call">Данные звонка.</param>
        void SaveCall(OrderCall call);
    }
}
