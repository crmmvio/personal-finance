using System;
using System.Collections.Generic;
using PersonalFinance.Data.Interfaces;
using PersonalFinance.Service.Interfaces;
using PersonalFinance.Service.Validation;

namespace PersonalFinance.Service
{
    public class BaseService<R, T> : IBaseService<T>
        where T : class
        where R : IBaseRepository<T>, new()
    {
        private IBaseRepository<T> repository;

        public IBaseRepository<T> Repository
        {
            get { return repository; }
            set { repository = value; }
        }

        private IValidationDictionary validation;

        public IValidationDictionary Validation
        {
            get { return validation; }
            set { validation = value; }
        }

        public virtual IEnumerable<T> ListAll()
        {
            return repository.ListAll();
        }

        public virtual IEnumerable<T> Search(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return repository.Search(predicate);
        }

        public virtual T Find(int id)
        {
            return repository.Find(id);
        }

        public virtual bool Add(T entity)
        {
            repository.Add(entity);
            return repository.Save();
        }

        public virtual bool Edit(T entity)
        {
            repository.Edit(entity);
            return repository.Save();
        }

        public virtual bool Delete(T entity)
        {
            repository.Delete(entity);
            return repository.Save();
        }

        public virtual bool Delete(int id)
        {
            T entity = repository.Find(id);
            if (entity != null)
            {
                repository.Delete(entity);
                return repository.Save();
            }

            return false;
        }

        public virtual bool IsValid(T entity)
        {
            return true;
        }

        public virtual void Dispose()
        {
            repository.Dispose();
        }
    }
}
