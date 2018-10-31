using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Data.Repositories
{
    /// <summary>
    /// Репозиторий для каталога.
    /// </summary>
    public class CatalogRepository : BaseRepository, ICatalogRepository
    {
        public CatalogRepository(TottoContext context)
        {
            this.context = context;
        }

        #region Categories

        /// <summary>
        /// Возвращает список категорий продуктов.
        /// </summary>
        public List<ProductCategory> GetCategories()
        {
            return context.ProductCategories
                .Where(x => x.IsActive)
                .OrderBy(x => x.Order)
                .ToList();
        }

        /// <summary>
        /// Возвращает категорию по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор категории.</param>
        public ProductCategory GetCategory(int id)
        {
            return context.ProductCategories
                .FirstOrDefault(b => b.Id == id);
        }

        /// <summary>
        /// Добавляет категорию в список.
        /// </summary>
        /// <param name="category">Данные категории.</param>
        public void AddCategory(ProductCategory category)
        {
            context.ProductCategories.Add(category);
            Save();
        }

        /// <summary>
        /// Обновляет категорию в списке.
        /// </summary>
        /// <param name="category">Данные категории.</param>
        public void UpdateCategory(ProductCategory category)
        {
            context.ProductCategories.Update(category);
            Save();
        }

        /// <summary>
        /// Удаляет категорию по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор категории.</param>
        public void DeleteCategory(int id)
        {
            ProductCategory category = GetCategory(id);

            if (category == null)
            {
                return;
            }

            context.ProductCategories.Remove(category);
            Save();
        }

        #endregion

        #region Subcategories

        /// <summary>
        /// Возвращает список подкатегорий продуктов.
        /// </summary>
        public List<ProductSubcategory> GetSubcategories()
        {
            return context.ProductSubcategories
                .Where(x => x.IsActive)
                .OrderBy(x => x.Order)
                .ToList();
        }

        /// <summary>
        /// Возвращает подкатегорию по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор подкатегории.</param>
        public ProductSubcategory GetSubcategory(int id)
        {
            return context.ProductSubcategories
                .FirstOrDefault(b => b.Id == id);
        }

        /// <summary>
        /// Добавляет подкатегорию в список.
        /// </summary>
        /// <param name="subcategory">Данные подкатегории.</param>
        public void AddSubcategory(ProductSubcategory subcategory)
        {
            context.ProductSubcategories.Add(subcategory);
            Save();
        }

        /// <summary>
        /// Обновляет подкатегорию в списке.
        /// </summary>
        /// <param name="subcategory">Данные подкатегории.</param>
        public void UpdateSubcategory(ProductSubcategory subcategory)
        {
            context.ProductSubcategories.Update(subcategory);
            Save();
        }

        /// <summary>
        /// Удаляет подкатегорию по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор подкатегории.</param>
        public void DeleteSubcategory(int id)
        {
            ProductSubcategory subcategory = GetSubcategory(id);

            if (subcategory == null)
            {
                return;
            }

            context.ProductSubcategories.Remove(subcategory);
            Save();
        }

        #endregion

        #region Groups

        /// <summary>
        /// Возвращает список групп продуктов.
        /// </summary>
        public List<ProductGroup> GetGroups()
        {
            return context.ProductGroups
                .Where(x => x.IsActive)
                .OrderBy(x => x.Order)
                .ToList();
        }

        /// <summary>
        /// Возвращает группу по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор группы.</param>
        public ProductGroup GetGroup(int id)
        {
            return context.ProductGroups
                .FirstOrDefault(b => b.Id == id);
        }

        /// <summary>
        /// Добавляет группу в список.
        /// </summary>
        /// <param name="group">Данные группы.</param>
        public void AddGroup(ProductGroup group)
        {
            context.ProductGroups.Add(group);
            Save();
        }

        /// <summary>
        /// Обновляет группу в списке.
        /// </summary>
        /// <param name="group">Данные группы.</param>
        public void UpdateGroup(ProductGroup group)
        {
            context.ProductGroups.Update(group);
            Save();
        }

        /// <summary>
        /// Удаляет группу по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор группы.</param>
        public void DeleteGroup(int id)
        {
            ProductGroup group = GetGroup(id);

            if (group == null)
            {
                return;
            }

            context.ProductGroups.Remove(group);
            Save();
        }

        #endregion
    }
}
