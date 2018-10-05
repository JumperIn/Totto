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

        private bool disposed;

        /// <summary>
        /// Сохраняет изменения в контексте базы данных.
        /// </summary>
        public void Save()
        {
            context.SaveChanges();
        }

        /// <summary>
        /// Освобождает ресурсы.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                context.Dispose();
            }
            disposed = true;
        }
    }
}
