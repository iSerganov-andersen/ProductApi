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
            _context.Entry<T>(entity).State = EntityState.Added;
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
            return _context.Set<T>().AsNoTracking();
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

        public async virtual Task<T> UpdateAsync(Guid id, T entity)
        {
            if (entity == null)
                return null;
            T exist = _context.Set<T>().AsNoTracking().FirstOrDefault(p => p.Id == id);
            if (exist != null)
            {
                _context.Entry<T>(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            return exist;
        }
    }
}
