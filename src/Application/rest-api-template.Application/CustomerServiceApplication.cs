using System.Collections.Generic;
using rest_api_template.Application.DTO;
using rest_api_template.Application.Interfaces;
using rest_api_template.Application.Mappers.Mapper;

namespace rest_api_template.Application
{
    public class CustomerServiceApplication : ICustomerServiceApplication
    {
        private readonly ICustomerServiceApplication CustomerService;
        private readonly CustomerMapper  CustomerMapper;
        
        public void Add(CustomerDTO customerDTO)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(CustomerDTO customerDTO)
        {
            throw new System.NotImplementedException();
        }

        public CustomerDTO Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(CustomerDTO customerDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}