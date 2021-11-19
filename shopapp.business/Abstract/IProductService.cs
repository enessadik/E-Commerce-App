using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Product GetByIdWithCategories(int id);
        Product GetById(int id);
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);



        bool Create(Product entity);
        void Update(Product entity);
        bool Update(Product entity, int[] categoryIds);
        void Delete(Product entity);
        List<Product> GetAll();
        int GetCountByCategory(string category);
    }
}
