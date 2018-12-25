using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MyTotto.Api.Abstract;
using MyTotto.Data;
using MyTotto.Data.Abstract;
using MyTotto.Data.Models;

namespace MyTotto.Api.Controllers
{
    public class CatalogController : BaseController
    {
        private readonly ICatalogRepository catalogRepository;

        public CatalogController(ICatalogRepository catalogRepository)
        {
            this.catalogRepository = catalogRepository;
        }

        #region Categories

        /// <summary>
        /// Возвращает список всех категорий продуктов.
        /// </summary>
        [HttpGet("categories/all")]
        public IEnumerable<ProductCategory> GetCategories()
        {
            List<ProductCategory> categories = catalogRepository.GetCategories();
            return categories;
        }

        /// <summary>
        /// Возвращает категорию продукта по ID.
        /// </summary>
        [HttpGet("categories/category/{id}")]
        public ProductCategory GetCategories(int id)
        {
            ProductCategory category = catalogRepository.GetCategory(id);
            return category;
        }

        /// <summary>
        /// Добавляет новую категорию в список.
        /// </summary>
        /// <param name="category">Данные категории.</param>
        [HttpPost("categories/category")]
        public void AddCategory([FromBody] ProductCategory category)
        {
            catalogRepository.AddCategory(category);
        }

        /// <summary>
        /// Обновляет данные категории в списке.
        /// </summary>
        /// <param name="category">Данные категории.</param>
        [HttpPost("categories/category/update")]
        public void UpdateCategory([FromBody] ProductCategory category)
        {
            catalogRepository.UpdateCategory(category);
        }

        /// <summary>
        /// Удаляет категорию из списка.
        /// </summary>
        /// <param name="id">Идентификатор категории.</param>
        [HttpPost("categories/category/delete/{id}")]
        public void DeleteCategory(int id)
        {
            catalogRepository.DeleteCategory(id);
        }

        #endregion

        #region Subcategories

        /// <summary>
        /// Возвращает список всех подкатегорий продуктов.
        /// </summary>
        [HttpGet("subcategories/all")]
        public IEnumerable<ProductSubcategory> GetSubcategories()
        {
            List<ProductSubcategory> subcategories = catalogRepository.GetSubcategories();
            return subcategories;
        }

        /// <summary>
        /// Возвращает подкатегорию продукта по ID.
        /// </summary>
        [HttpGet("subcategories/subcategory/{id}")]
        public ProductSubcategory GetSubcategories(int id)
        {
            ProductSubcategory subcategory = catalogRepository.GetSubcategory(id);
            return subcategory;
        }

        /// <summary>
        /// Добавляет новую подкатегорию в список.
        /// </summary>
        /// <param name="subcategory">Данные подкатегории.</param>
        [HttpPost("subcategories/subcategory")]
        public void AddSubcategory([FromBody] ProductSubcategory subcategory)
        {
            catalogRepository.AddSubcategory(subcategory);
        }

        /// <summary>
        /// Обновляет данные подкатегории в списке.
        /// </summary>
        /// <param name="subcategory">Данные подкатегории.</param>
        [HttpPost("subcategories/subcategory/update")]
        public void UpdateSubcategory([FromBody] ProductSubcategory subcategory)
        {
            catalogRepository.UpdateSubcategory(subcategory);
        }

        /// <summary>
        /// Удаляет подкатегорию из списка.
        /// </summary>
        /// <param name="id">Идентификатор подкатегории.</param>
        [HttpPost("subcategories/subcategory/delete/{id}")]
        public void DeleteSubcategory(int id)
        {
            catalogRepository.DeleteCategory(id);
        }

        #endregion

        #region Groups

        /// <summary>
        /// Возвращает список всех групп продуктов.
        /// </summary>
        [HttpGet("groups/all")]
        public IEnumerable<ProductGroup> GetGroups()
        {
            List<ProductGroup> groups = catalogRepository.GetGroups();
            return groups;
        }

        /// <summary>
        /// Возвращает группу продукта по ID.
        /// </summary>
        [HttpGet("groups/group/{id}")]
        public ProductGroup GetGroup(int id)
        {
            ProductGroup group = catalogRepository.GetGroup(id);
            return group;
        }

        /// <summary>
        /// Добавляет новую группу в список.
        /// </summary>
        /// <param name="group">Данные группы.</param>
        [HttpPost("groups/group")]
        public void AddGroup([FromBody] ProductGroup group)
        {
            catalogRepository.AddGroup(group);
        }

        /// <summary>
        /// Обновляет данные группы в списке.
        /// </summary>
        /// <param name="group">Данные группы.</param>
        [HttpPost("groups/group/update")]
        public void UpdateGroup([FromBody] ProductGroup group)
        {
            catalogRepository.UpdateGroup(group);
        }

        /// <summary>
        /// Удаляет группу из списка.
        /// </summary>
        /// <param name="id">Идентификатор группы.</param>
        [HttpPost("groups/group/delete/{id}")]
        public void DeleteGroup(int id)
        {
            catalogRepository.DeleteGroup(id);
        }

        #endregion
    }
}