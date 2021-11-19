using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        //extra eklemek istediğimiz methodlar      
        List<Category> GetPopularCategories();
        Category GetByIdWithProducts(int categoryId);
        void DeleteFromCategory(int productId, int categoryId);
    }
}
