using Cotix.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cotix.AppLayer.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        ICollection<T> GetAll();
        ICollection<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
        void Add(T entity);
        void Add(ICollection<T> entities);
        void Update(T entity);
        void Update(ICollection<T> entities);
        bool Exists(int id);
        void Delete(int id);
    }
}