using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefaultTestUnit.Application.Interfaces;
using DefaultTestUnit.Infrastructure.Data.Context;

namespace DefaultTestUnit.Application.AppServices
{
    public class AppServiceBase<T> : IDisposable, IAppServiceBase<T> where T : class
    {
        protected Context db = new Context();

        public void Add(T entity)
        {
            db.Set<T>().Add(entity);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public T FindByKeys(params object[] key)
        {
            return db.Set<T>().Find(key);
        }

        public IList<T> Get(Func<T, bool> predicate)
        {
            return GetAll().Where(predicate).ToList();
        }

        public IList<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public void Remove(Func<T, bool> predicate)
        {
            db.Set<T>().Where(predicate).ToList()
                .ForEach(invoice => db.Set<T>()
                    .Remove(invoice)
                );
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
