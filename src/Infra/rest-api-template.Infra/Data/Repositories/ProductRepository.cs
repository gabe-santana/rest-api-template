using rest_api_template.Domain.Core.Interfaces.Repositories;
using rest_api_template.Domain.Entities;

namespace rest_api_template.Infra.Data.Repositories
{
    public class ProductRepository : EntityRepository<Product>, IProductRepository
    {
        private readonly Database database;
        public ProductRepository(Database database) : base(database)
            => this.database=database;
    }
}