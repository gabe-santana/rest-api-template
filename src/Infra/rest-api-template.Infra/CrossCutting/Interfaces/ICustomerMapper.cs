using System.Collections.Generic;
using rest_api_template.Application.DTO;
using rest_api_template.Domain.Entities;

namespace rest_api_template.Infra.CrossCutting.Interfaces
{
    public interface ICustomerMapper
    {
        Customer ToEntity(CustomerDTO customerDTO);
        CustomerDTO ToDTO(Customer customer);
        IEnumerable<CustomerDTO> ToDTOList(IEnumerable<Customer> customers);
        IEnumerable<Customer> ToEntityList(IEnumerable<CustomerDTO> customerDTOs);

    }
}