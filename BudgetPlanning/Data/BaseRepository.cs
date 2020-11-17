using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Data
{
    public class BaseRepository<TEntity> : DbContext, IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
            _dbSet = Set<TEntity>();
        }

        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            SaveChanges();
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
            SaveChanges();
        }

        public void Remove(IEnumerable<TEntity> items)
        {
            _dbSet.RemoveRange(items);
            SaveChanges();
        }

        public void Update(TEntity item)
        {
            Entry(item).State = EntityState.Modified;
            SaveChanges();
        }

        public void Update(IEnumerable<TEntity> items)
        {
            foreach (TEntity item in items)
            {
                Entry(item).State = EntityState.Modified;
            }

            SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TEntity>();
        }
    }
}
