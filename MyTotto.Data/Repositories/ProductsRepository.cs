using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Data.Repositories
{
    /// <summary>
    /// Репозиторий для продуктов.
    /// </summary>
    public class ProductsRepository : BaseRepository, IProductsRepository
    {
        public ProductsRepository(TottoContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Возвращает весь список продуктов.
        /// </summary>
        public List<Product> GetAllProducts()
        {
            List<Product> products = context.Products
                .Where(b => b.IsActive)
                .ToList();

            return products;
        }

        /// <summary>
        /// Возвращает продукт по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        public Product GetProduct(Guid id)
        {
            return context.Products.FirstOrDefault(b => b.Id == id);
        }

        /// <summary>
        /// Добавляет продукт в список.
        /// </summary>
        /// <param name="product">Данные продукта.</param>
        public void AddProduct(Product product)
        {
            product.Created = DateTime.Now;
            context.Products.Add(product);
            Save();
        }

        /// <summary>
        /// Обновляет продукт в списке.
        /// </summary>
        /// <param name="product">Данные продукта.</param>
        public void UpdateProduct(Product product)
        {
            context.Products.Update(product);
            Save();
        }

        /// <summary>
        /// Удаляет продукт по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        public void DeleteProduct(Guid id)
        {
            Product product = GetProduct(id);

            if (product == null)
            {
                return;
            }

            context.Products.Remove(product);
            Save();
        }
    }
}
