using System;
using System.Collections.Generic;

using MyTotto.Data.Models;

namespace MyTotto.Data.Abstract
{
    /// <summary>
    /// Интерфейс для работы с продуктами.
    /// </summary>
    public interface IProductsRepository
    {
        /// <summary>
        /// Возвращает весь список продуктов.
        /// </summary>
        List<Product> GetAllProducts();

        /// <summary>
        /// Возвращает продукт по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        Product GetProduct(Guid id);

        /// <summary>
        /// Добавляет продукт в список.
        /// </summary>
        /// <param name="product">Данные продукта.</param>
        void AddProduct(Product product);

        /// <summary>
        /// Обновляет продукт в списке.
        /// </summary>
        /// <param name="product">Данные продукта.</param>
        void UpdateProduct(Product product);

        /// <summary>
        /// Удаляет продукт по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        void DeleteProduct(Guid id);
    }
}
