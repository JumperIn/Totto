using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MyTotto.Data
{
    public class TottoDataBaseInitializer
    {
        private TottoContext tottoDbContext;

        public TottoDataBaseInitializer(TottoContext tottoDbContext)
        {
            this.tottoDbContext = tottoDbContext;
        }

        public void InitDataBase(string connectionString)
        {
            var pendingMigrations = tottoDbContext.Database.GetPendingMigrations().ToList();

            if (!pendingMigrations.Any())
            {
                return;
            }


        }
    }
}
