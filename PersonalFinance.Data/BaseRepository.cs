using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PersonalFinance.Data.Interfaces;

namespace PersonalFinance.Data
{
    public class BaseRepository<C, T> : IBaseRepository<T>
        where T : class
        where C : DbContext, new()
    {
        private C entities = new C();

        public C Entities
        {
            get { return entities; }
            set { entities = value; }
        }

        public virtual IEnumerable<T> ListAll()
        {
            return entities.Set<T>();
        }

        public virtual IEnumerable<T> Search(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return entities.Set<T>().Where(predicate);
        }

        public virtual T Find(int id)
        {
            return entities.Set<T>().Find(id);
        }

        public virtual void Add(T entity)
        {
            entities.Set<T>().Add(entity);
        }

        public virtual void Edit(T entity)
        {
            entities.Entry(entity).State = System.Data.EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            entities.Set<T>().Remove(entity);
        }

        public virtual bool Save()
        {
            return (entities.SaveChanges() > 0);
        }

        public virtual void Dispose()
        {
            if (entities != null) entities.Dispose();
        }
    }
}
