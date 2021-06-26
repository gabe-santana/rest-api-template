using System.Collections.Generic;
using rest_api_template.Application.DTO;

namespace rest_api_template.Application.Interfaces
{
    public interface ICustomerServiceApplication
    {
        CustomerDTO Get(int id);
        IEnumerable<CustomerDTO> GetAll();
        void Add(CustomerDTO customerDTO);
        void Update(CustomerDTO customerDTO);
        void Delete(CustomerDTO customerDTO);
    }
}