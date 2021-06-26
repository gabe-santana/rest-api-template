using rest_api_template.Domain.Core.Interfaces.Repositories;
using rest_api_template.Domain.Entities;

namespace rest_api_template.Infra.Data.Repositories
{
    public class CustomerRepository : EntityRepository<Customer>, ICustomerRepository
    {
        private readonly Database database;
        public CustomerRepository(Database database): base(database) 
            => this.database = database;
    }
}