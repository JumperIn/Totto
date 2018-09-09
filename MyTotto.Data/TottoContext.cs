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

        /// <summary>
        /// Таблица карточек продуктов.
        /// </summary>
        public DbSet<ProductCard> ProductCards { get; set; }

        /// <summary>
        /// Таблица промо-блоков, которые находятся на главной странице.
        /// </summary>
        public DbSet<Promo> Promos { get; set; }

        public TottoContext(DbContextOptions<TottoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
