using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Microsoft.EntityFrameworkCore;

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
                // Включая эти свойства в Продукт подгружаются данные
                // Но возникают проблемы с кольцевыми ссылками в разделах
                //.Include(p => p.ProductCategory)
                //.Include(p => p.ProductSubcategory)
                //.Include(p => p.ProductGroup)
                .Include(p => p.Manufacturer)
                .Where(p => p.IsActive)
                .ToList();

            return products;
        }

        /// <summary>
        /// Возвращает список продуктов по идентификаторам разделов.
        /// </summary>
        /// <param name="categoryId">Идентификатор категории.</param>
        /// <param name="subcategoryId">Идентификатор подкатегории.</param>
        /// <param name="groupId">Идентификатор группы.</param>
        public List<Product> GetProducts(int categoryId, int subcategoryId, int groupId)
        {
            IEnumerable<Product> products = context.Products
                .Include(p => p.Manufacturer);

            if (categoryId != 0)
            {
                products = products.Where(x => x.ProductCategoryId == categoryId);
            }

            if (subcategoryId != 0)
            {
                products = products.Where(x => x.ProductSubcategoryId == subcategoryId);
            }

            if (groupId != 0)
            {
                products = products.Where(x => x.ProductGroupId == groupId);
            }

            return products.ToList();
        }

        /// <summary>
        /// Возвращает продукт по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        public Product GetProduct(int id)
        {
            return context.Products
                .Include(p => p.Manufacturer)
                .FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Добавляет продукт в список.
        /// </summary>
        /// <param name="product">Данные продукта.</param>
        public void AddProduct(Product product)
        {
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
        public void DeleteProduct(int id)
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