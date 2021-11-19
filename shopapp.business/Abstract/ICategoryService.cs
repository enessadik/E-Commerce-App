﻿using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Abstract
{
    public interface ICategoryService : IValidator<Category>
    {
        Category GetById(int id);

        List<Category> GetAll();
        Category GetIdWithProducts(int categoryId);

        void Create(Category entity);

        void Update(Category entity);
        void Delete(Category entity);

        void DeleteFromCategory(int productId, int categoryId);
    }
}
