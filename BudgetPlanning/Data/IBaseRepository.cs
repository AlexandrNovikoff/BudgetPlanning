using Core;
using System;
using System.Collections.Generic;

namespace Data
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Create(TEntity item);

        TEntity FindById(Guid id);

        IEnumerable<TEntity> GetQuery();

        void Remove(TEntity item);

        void Remove(IEnumerable<TEntity> items);

        void Update(TEntity item);

        void Update(IEnumerable<TEntity> items);
    }
}
