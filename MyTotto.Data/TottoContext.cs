using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyTotto.Data.Models;

namespace MyTotto.Data
{
    /// <summary>
    /// Контекст базы данных.
    /// </summary>
    public class TottoContext : DbContext
    {
        /// <summary>
        /// Таблица баннеров, которые представляют рекламные блоки.
        /// </summary>
        public DbSet<Banner> Banners { get; set; }

        public TottoContext(DbContextOptions<TottoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}