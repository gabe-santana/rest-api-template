using System.Collections.Generic;
using rest_api_template.Domain.Core.Interfaces.Repositories;
using rest_api_template.Domain.Core.Interfaces.Services;

namespace rest_api_template.Domain.Services.Services
{
    public class EntityService<TEntity> : IEntityService<TEntity> where TEntity : class
    {

        private readonly IEntityRepository<TEntity> TEntityRepository;

        public EntityService( IEntityRepository<TEntity> TEntityRepository)
            => this.TEntityRepository = TEntityRepository;

        public TEntity Get(int id)
        {
            return TEntityRepository.Get(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return  TEntityRepository.GetAll();
        }

        public void Add(TEntity entity)
        {
            TEntityRepository.Add(entity);
        }

        public void Update(TEntity entity)
        {
            TEntityRepository.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            TEntityRepository.Delete(entity);
        }
    }
}