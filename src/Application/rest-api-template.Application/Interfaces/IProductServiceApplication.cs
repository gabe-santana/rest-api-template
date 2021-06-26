using System.Collections.Generic;
using rest_api_template.Application.DTO;

namespace rest_api_template.Application.Interfaces
{
    public interface IProductServiceApplication
    {
        ProductDTO Get(int id);
        IEnumerable<ProductDTO> GetAll();
        void Add(ProductDTO productDTO);
        void Update(ProductDTO productDTO);
        void Delete(ProductDTO productDTO);
    }
}