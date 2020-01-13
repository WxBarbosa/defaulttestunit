using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DefaultTestUnit.Infrastructure.Data.Context;

namespace DefaultTestUnit.Application.Interfaces
{
    public interface IAppServiceBase<T> where T : class
    {
        void Add(T entity);
        IList<T> Get(Func<T, bool> predicate);
        T FindByKeys(params object[] key);
        IList<T> GetAll();
        void Remove(Func<T, bool> predicate);
        void Update(T entity);

        void SaveChanges();

        void Dispose();
    }
}
