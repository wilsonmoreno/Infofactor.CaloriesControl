using System;
using System.Collections.Generic;

namespace Infofactor.CaloriesControl.Repository.Base.Contract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object Id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(Object Id);
    }
}
