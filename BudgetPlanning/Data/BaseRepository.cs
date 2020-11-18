using Core;
using Core.Domain.Customers;
using Data.Maping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Data
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbSet<TEntity> _dbSet;
        private readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            _dbContext.SaveChanges();
        }

        public TEntity FindById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetQuery()
        {
            return _dbSet.AsNoTracking();
        }

        public void Remove(TEntity item)
        {
            _dbSet.Remove(item);
            _dbContext.SaveChanges();
        }

        public void Remove(IEnumerable<TEntity> items)
        {
            _dbSet.RemoveRange(items);
            _dbContext.SaveChanges();
        }

        public void Update(TEntity item)
        {
            _dbContext.Entry(item).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Update(IEnumerable<TEntity> items)
        {
            foreach (TEntity item in items)
            {
                _dbContext.Entry(item).State = EntityState.Modified;
            }

            _dbContext.SaveChanges();
        }
    }
}
