using Microsoft.EntityFrameworkCore.Update.Internal;

using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepository.DataAccess
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> GetAll();
        T GetBy(int id);
        void Update(T t);
        // IEnumerable<T> Get(Predicate<T> predicate);
        void Add(T t);
        void Delete(T t);
    }
}