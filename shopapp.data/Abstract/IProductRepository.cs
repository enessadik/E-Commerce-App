using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {

        
        Product GetByIdWithCategories(int id);
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        List<Product> GetPopularCategories();
        List<Product> GetTop5Products();
        List<Product> GetHomePageProducts();
        public int GetCountByCategory(string category);
        List<Product> GetSearchResult(string searchString);

        void Update(Product entity, int[] categoryIds);
    }
}
