using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Data.Repositories
{
    /// <summary>
    /// Репозиторий для заказанных звонков.
    /// </summary>
    public class CallsRepository : BaseRepository, ICallsRepository
    {
        public CallsRepository(TottoContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Сохраняет заказ обратного звонка.
        /// </summary>
        /// <param name="call">Данные звонка.</param>
        public void SaveCall(OrderCall call)
        {
            context.OrderCalls.Add(call);
            Save();
        }
    }
}
