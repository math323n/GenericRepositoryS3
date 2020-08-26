using GenericRepository.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepository.DataAccess
{
    public class RepositoryBase<T>: IRepositoryBase<T> where T : class
    {
        protected NorthwindContext context;

        public RepositoryBase(NorthwindContext context)
        {
            Context = context;
        }

        #region Properties
        public virtual NorthwindContext Context
        {
            get
            {
                return context;
            }
            protected set
            {
                context = value;
            }
        }
        #endregion

        public void Add(T t)
        {
            context.Set<T>().Add(t);
        }

        public void Delete(T t)
        {
            context.Set<T>().Remove(t);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }

        public T GetBy(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Update(T t)
        {
            context.Set<T>().Update(t);
        }
    }
}