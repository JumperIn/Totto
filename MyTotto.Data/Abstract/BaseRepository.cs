using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Abstract
{
    /// <summary>
    /// Базовый репозиторий.
    /// </summary>
    public class BaseRepository : IDisposable
    {
        protected TottoContext context;

        public BaseRepository(TottoContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Сохраняет изменения в контексте базы данных.
        /// </summary>
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                context.Dispose();
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
