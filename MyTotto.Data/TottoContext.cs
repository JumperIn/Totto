using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyTotto.Data.Configurations;
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
        /// Таблица продуктов.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Таблица промо-блоков, которые находятся на главной странице.
        /// </summary>
        public DbSet<Promo> Promos { get; set; }

        public TottoContext(DbContextOptions<TottoContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
            //Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
        }
    }
}