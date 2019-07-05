using Microsoft.EntityFrameworkCore;
using ProductCore.Entities;
using ProductDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async Task AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid Id)
        {
            T existing = _context.Set<T>().SingleOrDefault(e => e.Id.Equals(Id));
            if (existing != null) _context.Set<T>().Remove(existing);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            T existing = _context.Set<T>().Find(entity);
            if (existing != null) _context.Set<T>().Remove(existing);
            await _context.SaveChangesAsync();
        }

        public IQueryable<T> Get()
        {
            return _context.Set<T>();
        }

        public IQueryable<T> Get(params System.Linq.Expressions.Expression<Func<T, object>>[] includes)
        {
            var entities = Get();
            return includes.Aggregate(entities, (current, includeProperty) => current.Include(includeProperty));
        }

        public IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate, params System.Linq.Expressions.Expression<Func<T, object>>[] includes)
        {
            var query = Get().Where(predicate);
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public IEnumerable<T> Get(Guid Id)
        {
            return Get(entity => entity.Id.Equals(Id));
        }

        public async Task UpdateAsync(Guid id, T entity)
        {
            var entityExists = Get(id).Any();
            if (!entityExists)
                await AddAsync(entity);
            else
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
