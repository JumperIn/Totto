using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Таблица промо товаров с главной страницы.
        /// </summary>
        public DbSet<PromoProduct> PromoProducts { get; set; }

        /// <summary>
        /// Таблица с категориями товаров.
        /// </summary>
        public DbSet<ProductCategory> ProductCategories { get; set; }

        /// <summary>
        /// Таблица с подкатегориями товаров.
        /// </summary>
        public DbSet<ProductSubcategory> ProductSubcategories { get; set; }

        /// <summary>
        /// Таблица с группами товаров.
        /// </summary>
        public DbSet<ProductGroup> ProductGroups { get; set; }

        /// <summary>
        /// Таблица с производителями.
        /// </summary>
        public DbSet<Manufacturer> Manufacturers { get; set; }

        /// <summary>
        /// Таблица с заказанными звонками.
        /// </summary>
        public DbSet<OrderCall> OrderCalls { get; set; }

        /// <summary>
        /// Таблица с подписчиками.
        /// </summary>
        public DbSet<Subscriber> Subscribers { get; set; }

        public TottoContext(DbContextOptions<TottoContext> options) : base(options)
        {
            // Ниже включаю для миграций. Вроде должно быть ок.

            //Database.EnsureCreated();

            //var pendingMigrations = Database.GetPendingMigrations().ToList();
            //if (pendingMigrations.Any())
            //{
            //    Database.Migrate();
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BannersEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PromosEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PromoProductsEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriesEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SubcategoriesEntityConfiguration());
            modelBuilder.ApplyConfiguration(new GroupsEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ManufacturersEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductsEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderCallsEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SubscribersEntityConfiguration());
        }
    }
}