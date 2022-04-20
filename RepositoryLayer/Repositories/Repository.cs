using DomainLayer.Common;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> entities;

        public Repository(AppDbContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            await entities.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            T entity = await entities.FirstOrDefaultAsync(e => e.Id == id);

            if (entity == null) throw new ArgumentNullException(nameof(entity));

            return entity;
        }
        public async Task<T> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await entities.FindAsync(predicate);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }
        public async Task UpdateAsync(T entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));

            entities.Update(entity);

            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            entities.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task SoftDeleteAsync(T entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));

            T entityDb = await entities.FirstOrDefaultAsync(e => e.Id == entity.Id);

            if (entityDb == null) throw new ArgumentNullException(nameof(entityDb));

            entityDb.SoftDelete = true;

            await _context.SaveChangesAsync();
        }
    }
}
