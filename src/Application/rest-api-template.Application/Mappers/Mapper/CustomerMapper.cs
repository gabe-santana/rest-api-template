using System.Collections.Generic;
using rest_api_template.Application.DTO;
using rest_api_template.Application.Mappers.Interfaces;
using rest_api_template.Domain.Entities;

namespace rest_api_template.Application.Mappers.Mapper
{
    public class CustomerMapper : IEntityMapper<Customer, CustomerDTO>
    {
        public CustomerDTO ToDTO(Customer entity)
        {
            return new CustomerDTO()
            {
                Id=entity.Id,
                Name=entity.Name,
                Email=entity.Email
            };
        }

        public Customer ToEntity(CustomerDTO entityDTO)
        {
            return new Customer()
            {
                Id=entityDTO.Id.Value,
                Name=entityDTO.Name,
                Email=entityDTO.Email
            };
        }
        public IEnumerable<CustomerDTO> ToDTOList(IEnumerable<Customer> entities)
        {
            foreach (var entity in entities)
            {
                yield return new CustomerDTO()
                {
                    Id=entity.Id,
                    Name=entity.Name,
                    Email=entity.Email
                };
            }
        }


        public IEnumerable<Customer> ToEntityList(IEnumerable<CustomerDTO> entityDTOs)
        {
             foreach (var entityDTO in entityDTOs)
            {
                yield return new Customer()
                {
                    Id=entityDTO.Id.Value,
                    Name=entityDTO.Name,
                    Email=entityDTO.Email
                };
            }
        }
    }
}