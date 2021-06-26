using System.Collections.Generic;
using rest_api_template.Application.DTO;
using rest_api_template.Domain.Entities;
using rest_api_template.Infra.CrossCutting.Interfaces;

namespace rest_api_template.Infra.CrossCutting.Mapper
{
    public class ProductMapper : IEntityMapper<Product, ProductDTO>
    {
        public ProductDTO ToDTO(Product entity)
        {
            return new ProductDTO()
            {
                Id=entity.Id,
                Name=entity.Name,
                Price=entity.Price
            };
        }

        public Product ToEntity(ProductDTO entityDTO)
        {
            return new Product()
            {
                Id=entityDTO.Id.Value,
                Name=entityDTO.Name,
                Price=entityDTO.Price
            };
        }
        public IEnumerable<ProductDTO> ToDTOList(IEnumerable<Product> entities)
        {
            foreach (var entity in entities)
            {
                yield return new ProductDTO()
                {
                    Id=entity.Id,
                    Name=entity.Name,
                    Price=entity.Price
                };
            }
        }


        public IEnumerable<Product> ToEntityList(IEnumerable<ProductDTO> entityDTOs)
        {
            foreach (var entityDTO in entityDTOs)
            {
                yield return new Product()
                {
                    Id=entityDTO.Id.Value,
                    Name=entityDTO.Name,
                    Price=entityDTO.Price
                };
            }
        }
    }
}