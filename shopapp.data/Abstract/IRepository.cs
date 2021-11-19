using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data.Abstract
{
    public interface IRepository<T>
    {
        //Genel operasyonlarımız CRUD ekleme silme güncelleme listeleme vs.
        T GetById(int id);

        List<T> GetAll();

        void Create(T entity);

        void Update(T entity);
        void Delete(T entity);
    }
}
