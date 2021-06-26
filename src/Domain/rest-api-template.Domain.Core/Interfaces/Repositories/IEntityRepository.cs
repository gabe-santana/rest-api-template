using System.Collections.Generic;

namespace rest_api_template.Domain.Core.Interfaces.Repositories
{
    public interface IEntityRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}