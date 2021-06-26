using rest_api_template.Domain.Core.Interfaces.Repositories;
using rest_api_template.Domain.Core.Interfaces.Services;
using rest_api_template.Domain.Entities;

namespace rest_api_template.Domain.Services.Services
{
    public class CustomerService : EntityService<Customer>, ICustomerService
    {
        private readonly ICustomerRepository CustomerRepository;

        public CustomerService( ICustomerRepository CustomerRepository) : base(CustomerRepository)
            => this.CustomerRepository = CustomerRepository;
    }
}