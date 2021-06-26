using rest_api_template.Domain.Core.Interfaces.Repositories;
using rest_api_template.Domain.Core.Interfaces.Services;
using rest_api_template.Domain.Entities;

namespace rest_api_template.Domain.Services.Services
{
    public class ProductService : EntityService<Product>, IProductService
    {
        private readonly IEntityRepository<Product> TEntityRepository;
        public ProductService(IEntityRepository<Product> TEntityRepository) : base(TEntityRepository)
            => this.TEntityRepository = TEntityRepository;
    }
}