using System.Collections.Generic;
using rest_api_template.Infra.Data;
using rest_api_template.Domain.Core.Interfaces.Repositories;


namespace rest_api_template.Domain.Core.Interfaces.Repositories
{
    public class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class
    {
        private readonly Database database;

        public EntityRepository(Database database) =>
            this.database = database;
        
        public TEntity Get(int id)
        {
            return database.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return database.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            try
            {
                database.Set<TEntity>().Add(entity);
                database.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                database.Set<TEntity>().Update(entity);
                database.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                database.Set<TEntity>().Remove(entity);
                database.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        
    }
}