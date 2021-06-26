using System.Collections.Generic;
using rest_api_template.Application.DTO;
using rest_api_template.Domain.Entities;

namespace rest_api_template.Infra.CrossCutting.Interfaces
{
    public interface IEntityMapper<TEntity, TEntityDTO> where  TEntity : class
    {
        TEntity ToEntity(TEntityDTO entityDTO);
        TEntityDTO ToDTO(TEntity entity);
        IEnumerable<TEntityDTO> ToDTOList(IEnumerable<TEntity> entities);
        IEnumerable<TEntity> ToEntityList(IEnumerable<TEntityDTO> entityDTOs);

    }
}