using System;
using System.Collections.Generic;

using MyTotto.Data.Models;

namespace MyTotto.Data.Abstract
{
    /// <summary>
    /// Интерфейс для работы с подписчиками.
    /// </summary>
    public interface ISubscribersRepository
    {
        /// <summary>
        /// Сохраняет подписчика.
        /// </summary>
        /// <param name="subscriber">Данные подписчика.</param>
        void SaveSubscriber(Subscriber subscriber);
    }
}
