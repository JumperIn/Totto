using System;
using System.Collections.Generic;
using System.Linq;

using MyTotto.Data.Abstract;
using MyTotto.Data.Enums;
using MyTotto.Data.Models;
using MyTotto.BusinessLogic.Abstract;

namespace MyTotto.BusinessLogic.Services
{
    public class ProductsFilterService : IProductsFilterService
    {
        private readonly IProductsRepository productsRepository;
        private readonly ICatalogRepository catalogRepository;

        private readonly int[] showByCounts = new int[] { 12, 24, 36 };

        public ProductsFilterService
        (
            IProductsRepository productsRepository,
            ICatalogRepository catalogRepository
        )
        {
            this.productsRepository = productsRepository;
            this.catalogRepository = catalogRepository;
        }

        public List<Product> Filter
        (
            string categoryUrl,
            string subcategoryUrl,
            string groupUrl,
            CatalogCountItems count,
            CatalogSortingType sorting,
            int page,
            string filters,
            int minPrice,
            int maxPrice,
            string manufacturer,
            ProductType type
        )
        {
            ProductCategory category = catalogRepository.GetCategory(categoryUrl);
            ProductSubcategory subcategory = catalogRepository.GetSubcategory(subcategoryUrl);
            ProductGroup group = catalogRepository.GetGroup(groupUrl);

            int categoryId = category != null ? category.Id : 0;
            int subcategoryId = subcategory != null ? subcategory.Id : 0;
            int groupId = group != null ? group.Id : 0;

            if (category == null)
            {
                return null;
            }

            int countItems = GetPageCountByItems(count);
                       
            List<Product> products = productsRepository.GetProducts(categoryId, subcategoryId, groupId);

            IEnumerable<Product> filteredProducts = FilterByCategories(products, filters);
            filteredProducts = FilterByPrice(filteredProducts, minPrice, maxPrice);
            filteredProducts = FilterByManufacturer(filteredProducts, manufacturer);
            filteredProducts = SortByCatalogType(filteredProducts, sorting);
            filteredProducts = FilterByProductType(filteredProducts, type);
            filteredProducts = GetProductByPage(filteredProducts, countItems, page);

            List<Product> finalProducts = filteredProducts.ToList();

            return finalProducts;
        }

        public int GetPageCountByItems(CatalogCountItems count)
        {
            int countItems;
            switch (count)
            {
                case CatalogCountItems.Medium:
                    countItems = showByCounts[1];
                    break;
                case CatalogCountItems.Large:
                    countItems = showByCounts[2];
                    break;
                default:
                    countItems = showByCounts[0];
                    break;
            }

            return countItems;
        }

        private IEnumerable<Product> FilterByCategories(IEnumerable<Product> products, string filters)
        {
            string[] filterValues = !string.IsNullOrEmpty(filters) ?
                filters.Split(";"[0]) :
                new string[] { };

            if (filterValues.Any())
            {
                // TODO: фильтровать по значениям в самом продукте
            }

            return products;
        }

        private IEnumerable<Product> FilterByPrice(IEnumerable<Product> products, int minPrice, int maxPrice)
        {
            return products.Where(x =>
                x.DiscountPrice >= minPrice && x.DiscountPrice <= maxPrice);
        }

        private IEnumerable<Product> FilterByManufacturer(IEnumerable<Product> products, string manufacturer)
        {
            return string.IsNullOrEmpty(manufacturer) ?
                products :
                products.Where(x =>
                    string.Equals(x.Manufacturer.Title, manufacturer, StringComparison.OrdinalIgnoreCase));
        }

        private IEnumerable<Product> FilterByProductType(IEnumerable<Product> products, ProductType type)
        {
            return type == ProductType.Normal ?
                products :
                products.Where(x => x.ProductType == type);
        }

        private IEnumerable<Product> SortByCatalogType(IEnumerable<Product> products, CatalogSortingType sorting)
        {
            switch (sorting)
            {
                case CatalogSortingType.DescendingTitle:
                    products = products.OrderByDescending(x => x.Title);
                    break;
                case CatalogSortingType.AscendingPrice:
                    products = products.OrderBy(x => x.Price);
                    break;
                case CatalogSortingType.DescendingPrice:
                    products = products.OrderByDescending(x => x.Price);
                    break;
                case CatalogSortingType.DiscountFirst:
                    products = products.OrderByDescending(x => x.ProductType == ProductType.Discount);
                    break;
                default:
                    products = products.OrderBy(x => x.Title);
                    break;
            }

            return products;
        }

        private IEnumerable<Product> GetProductByPage(IEnumerable<Product> products, int count, int page)
        {
            return products
                .Skip((page - 1) * count)
                .Take(count);
        }
    }
}
