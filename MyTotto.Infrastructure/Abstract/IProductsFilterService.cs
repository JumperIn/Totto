using System;
using System.Collections.Generic;
using System.Text;
using MyTotto.Data.Enums;
using MyTotto.Data.Models;

namespace MyTotto.BusinessLogic.Abstract
{
    public interface IProductsFilterService
    {

        List<Product> Filter
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
        );

        int GetPageCountByItems(CatalogCountItems count);
    }
}
