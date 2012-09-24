using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace PersonalFinance.Data.Interfaces
{
    public interface IBaseRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> ListAll();
        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);
        T Find(int id);
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        bool Save();
        void Dispose();
    }
}
