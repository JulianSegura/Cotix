using Cotix.AppLayer.Interfaces;
using Cotix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cotix.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly DbSet<T> _dbSet;
        private static DateTime currentTime = DateTime.UtcNow;

        public Repository(DbContext context)
        {
            _dbSet = context.Set<T>();
        }

        public ICollection<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return orderBy != null ? orderBy(query).ToList() : query.ToList();

        }

        public ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Add(T entity)
        {
            if (entity is AuditableEntity e)
            {
                e.CreatedAt = currentTime;
                //ToDo: Register userId for auditable entities
            }

            _dbSet.Add(entity);
        }

        public virtual void Add (ICollection<T> entities)
        {
            foreach (var entity in entities)
            {
                if (entity is AuditableEntity e)
                {
                    e.CreatedAt= currentTime;
                    //Todo: Register UserIf for auditable entities
                }
            }
        }

        public void Update(T entity)
        {
            if (entity is AuditableEntity e)
            {
                e.CreatedAt = currentTime;
                //ToDo: Register userId for auditable entities
            }
        }

        public void Update(ICollection<T> entities)
        {
            foreach (var entity in entities)
            {
                if (entity is AuditableEntity e)
                {
                    e.CreatedAt = currentTime;
                    //Todo: Register UserIf for auditable entities
                }
            }
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _dbSet.Remove(entity);
        }

        public bool Exists(int id)
        {
            return _dbSet.Any(e => e.Id == id);
        }
    }
}