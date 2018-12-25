using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Data.Repositories
{
    /// <summary>
    /// Репозиторий для подписчиков.
    /// </summary>
    public class SubscribersRepository : BaseRepository, ISubscribersRepository
    {
        public SubscribersRepository(TottoContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Сохраняет подписчика.
        /// </summary>
        /// <param name="subscriber">Данные подписчика.</param>
        public void SaveSubscriber(Subscriber subscriber)
        {
            context.Subscribers.Add(subscriber);
            Save();
        }
    }
}
