using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }



        public void Create(Category entity)
        {
            _categoryRepository.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public void DeleteFromCategory(int productId, int categoryId)
        {
            _categoryRepository.DeleteFromCategory(productId, categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }



        public Category GetIdWithProducts(int categoryId)
        {
            return _categoryRepository.GetByIdWithProducts(categoryId);
        }



        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }





        public string ErrorMessage { get; set; }

        public bool Validation(Category entity)
        {
            throw new NotImplementedException();
        }





        //***********************METOTLAR*****************************
        //private string CheckIfCategoryNameExists(string id)
        //{
        //    var result = _categoryRepository.GetAll(c=>c.)
        //}

    }
}
