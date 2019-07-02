using Microsoft.EntityFrameworkCore;
using ProductCore.Entities;
using ProductDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductServices.BusinessServices
{
    public abstract class BaseService<T>
        where T : BaseEntity
    {
        private readonly AwesomeDbContext _context;
        public BaseService(AwesomeDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(Guid Id)
        {
            T existing = _context.Set<T>().SingleOrDefault(e => e.Id.Equals(Id));
            if (existing != null) _context.Set<T>().Remove(existing);
        }

        public void Delete(T entity)
        {
            T existing = _context.Set<T>().Find(entity);
            if (existing != null) _context.Set<T>().Remove(existing);
        }

        public IEnumerable<T> Get()
        {
            return _context.Set<T>().AsEnumerable<T>();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).AsEnumerable<T>();
        }

        public IEnumerable<T> Get(Guid Id)
        {
            return Get(entity => entity.Id.Equals(Id));
        }

        public void Update(Guid id, T entity)
        {
            var entityExists = Get(id).Any();
            if (!entityExists)
                Add(entity);
            else
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.Set<T>().Attach(entity);
            }
        }
    }
}
