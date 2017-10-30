using Infofactor.CaloriesControl.DAL;
using Infofactor.CaloriesControl.Repository.Base.Contract;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Infofactor.CaloriesControl.Repository.Base
{
    public class Repository<T>: IRepository<T> where T : class
    {
        private ModelContext db;
        private DbSet<T> dbSet;

        public Repository(ModelContext _db)
        {
            db = _db;
            dbSet = db.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(object Id)
        {
            return dbSet.Find(Id);
        }

        public void Insert(T obj)
        {
            dbSet.Add(obj);
        }
        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object Id)
        {
            T getObjById = dbSet.Find(Id);
            dbSet.Remove(getObjById);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.db != null)
                {
                    this.db.Dispose();
                    this.db = null;
                }
            }
        }
    }
}
