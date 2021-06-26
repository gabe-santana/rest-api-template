using System.Collections.Generic;
using rest_api_template.Application.DTO;
using rest_api_template.Domain.Entities;

namespace rest_api_template.Infra.CrossCutting.Interfaces
{
    public interface IEntityMapper<TEntity> where  TEntity : class
    {
        TEntity ToEntity(TEntity entityDTO);
        TEntity ToDTO(TEntity entity);
        IEnumerable<TEntity> ToDTOList(IEnumerable<TEntity> entities);
        IEnumerable<TEntity> ToEntityList(IEnumerable<TEntity> entityDTOs);

    }
}