using System.Collections.Generic;
using rest_api_template.Application.DTO;
using rest_api_template.Application.Interfaces;
using rest_api_template.Application.Mappers.Mapper;
using rest_api_template.Domain.Core.Interfaces.Services;

namespace rest_api_template.Application
{
    public class CustomerServiceApplication : ICustomerServiceApplication
    {
        private readonly CustomerMapper  CustomerMapper;
        private readonly ICustomerService CustomerService;

        public CustomerServiceApplication(CustomerMapper  CustomerMapper, ICustomerService CustomerService)
        {
            this.CustomerMapper = CustomerMapper;
            this.CustomerService = CustomerService;
        }
        public CustomerDTO Get(int id)
            => CustomerMapper.ToDTO(CustomerService.Get(id));

        public IEnumerable<CustomerDTO> GetAll()
            => CustomerMapper.ToDTOList(CustomerService.GetAll());
        
        public void Add(CustomerDTO customerDTO)
            => CustomerService
                .Add(CustomerMapper.ToEntity(customerDTO));


        public void Update(CustomerDTO customerDTO)
            => CustomerService
                .Update(CustomerMapper.ToEntity(customerDTO));
        public void Delete(CustomerDTO customerDTO)
            => CustomerService
                .Delete(CustomerMapper.ToEntity(customerDTO));
    }
}