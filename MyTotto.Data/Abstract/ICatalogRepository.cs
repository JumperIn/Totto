using System;
using System.Collections.Generic;

using MyTotto.Data.Models;

namespace MyTotto.Data.Abstract
{
    /// <summary>
    /// Интерфейс для работы с каталогом.
    /// </summary>
    public interface ICatalogRepository
    {
        #region Categories

        /// <summary>
        /// Возвращает список категорий продуктов.
        /// </summary>
        List<ProductCategory> GetCategories();

        /// <summary>
        /// Возвращает категорию по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        ProductCategory GetCategory(int id);

        /// <summary>
        /// Возвращает категорию по URL.
        /// </summary>
        /// <param name="url">URL-адрес.</param>
        ProductCategory GetCategory(string url);

        /// <summary>
        /// Добавляет категорию в список.
        /// </summary>
        /// <param name="category">Данные категории.</param>
        void AddCategory(ProductCategory category);

        /// <summary>
        /// Обновляет категорию в списке.
        /// </summary>
        /// <param name="category">Данные категории.</param>
        void UpdateCategory(ProductCategory category);

        /// <summary>
        /// Удаляет категорию по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        void DeleteCategory(int id);

        #endregion

        #region Subcategories

        /// <summary>
        /// Возвращает список подкатегорий продуктов.
        /// </summary>
        List<ProductSubcategory> GetSubcategories();

        /// <summary>
        /// Возвращает подкатегорию по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        ProductSubcategory GetSubcategory(int id);

        /// <summary>
        /// Возвращает подкатегорию по URL.
        /// </summary>
        /// <param name="url">URL-адрес.</param>
        ProductSubcategory GetSubcategory(string url);

        /// <summary>
        /// Добавляет подкатегорию в список.
        /// </summary>
        /// <param name="subcategory">Данные подкатегории.</param>
        void AddSubcategory(ProductSubcategory subcategory);

        /// <summary>
        /// Обновляет подкатегорию в списке.
        /// </summary>
        /// <param name="subcategory">Данные подкатегории.</param>
        void UpdateSubcategory(ProductSubcategory subcategory);

        /// <summary>
        /// Удаляет подкатегорию по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        void DeleteSubcategory(int id);

        #endregion

        #region Groups

        /// <summary>
        /// Возвращает список групп продуктов.
        /// </summary>
        List<ProductGroup> GetGroups();

        /// <summary>
        /// Возвращает группу по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        ProductGroup GetGroup(int id);

        /// <summary>
        /// Возвращает подкатегорию по URL.
        /// </summary>
        /// <param name="url">URL-адрес.</param>
        ProductGroup GetGroup(string url);

        /// <summary>
        /// Добавляет группу в список.
        /// </summary>
        /// <param name="group">Данные группы.</param>
        void AddGroup(ProductGroup group);

        /// <summary>
        /// Обновляет группу в списке.
        /// </summary>
        /// <param name="group">Данные группы.</param>
        void UpdateGroup(ProductGroup group);

        /// <summary>
        /// Удаляет группу по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        void DeleteGroup(int id);

        #endregion
    }
}
