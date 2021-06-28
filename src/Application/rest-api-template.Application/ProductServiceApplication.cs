using System.Collections.Generic;
using rest_api_template.Application.DTO;
using rest_api_template.Application.Interfaces;
using rest_api_template.Application.Mappers.Mapper;
using rest_api_template.Domain.Core.Interfaces.Services;

namespace rest_api_template.Application
{
    public class ProductServiceApplication : IProductServiceApplication
    {
        private readonly ProductMapper ProductMapper;
        private readonly IProductService ProductService;

        public ProductServiceApplication(ProductMapper ProductMapper, IProductService ProductService)
        {
            this.ProductMapper = ProductMapper;
            this.ProductService = ProductService;
        }
        public ProductDTO Get(int id)
            => ProductMapper.ToDTO(ProductService.Get(id));

        public IEnumerable<ProductDTO> GetAll()
            => ProductMapper.ToDTOList(ProductService.GetAll());

        public void Add(ProductDTO productDTO)
            => ProductService.Add(ProductMapper.ToEntity(productDTO));

        public void Update(ProductDTO productDTO)
            => ProductService.Update(ProductMapper.ToEntity(productDTO));
        public void Delete(ProductDTO productDTO)
            => ProductService.Delete(ProductMapper.ToEntity(productDTO));
    }
}