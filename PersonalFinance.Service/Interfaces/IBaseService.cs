using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace PersonalFinance.Service.Interfaces
{
    public interface IBaseService<T> : IDisposable
        where T : class
    {
        IEnumerable<T> ListAll();
        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);
        T Find(int id);
        bool Add(T entity);
        bool Edit(T entity);
        bool Delete(T entity);
        bool Delete(int id);
        bool IsValid(T entity);
        void Dispose();
    }
}
