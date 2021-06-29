using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rest_api_template.Application.DTO;
using rest_api_template.Application.Interfaces;

namespace rest_api_template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServiceApplication ProductService;
        public ProductController(IProductServiceApplication ProductService)
            => this.ProductService = ProductService;
        
        [HttpGet]
        public ActionResult<CustomerDTO> Get([FromQuery] int id)
        {
            var result = ProductService.Get(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAll")]
        public ActionResult<CustomerDTO> GetAll()
        {
            var result = ProductService.GetAll();
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDTO product)
        {
            if(!ModelState.IsValid)
                return BadRequest();
            try{
                ProductService.Add(product);
                return Ok(StatusCodes.Status201Created);
            }
            catch(System.Exception ex){
                return BadRequest();
                throw ex;
            }  
        }      

        [HttpPut]
        public ActionResult Put([FromBody] ProductDTO product)
        {
            if(!ModelState.IsValid)
                return BadRequest();
            try{
                ProductService.Update(product);
                return Ok(StatusCodes.Status201Created);
            }
            catch(System.Exception ex){
                return BadRequest();
                throw ex;
            }  
        }      

        [HttpDelete]
        public ActionResult Delete([FromBody] ProductDTO product)
        {
            if(!ModelState.IsValid)
                return BadRequest();
            try{
                ProductService.Delete(product);
                return Ok(StatusCodes.Status201Created);
            }
            catch(System.Exception ex){
                return BadRequest();
                throw ex;
            }  
        }      
    }
}