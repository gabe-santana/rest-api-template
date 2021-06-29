using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rest_api_template.Application.DTO;
using rest_api_template.Application.Interfaces;

namespace rest_api_template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServiceApplication CustomerService; 

        public CustomerController(ICustomerServiceApplication CustomerService)
            => this.CustomerService = CustomerService;
        
        [HttpGet]
        public ActionResult<CustomerDTO> Get([FromQuery] int id)
        {
            var result = CustomerService.Get(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAll")]
        public ActionResult<CustomerDTO> GetAll()
        {
            var result = CustomerService.GetAll();
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody] CustomerDTO customer)
        {
            if(!ModelState.IsValid)
                return BadRequest();
            try{
                CustomerService.Add(customer);
                return Ok(StatusCodes.Status201Created);
            }
            catch(System.Exception ex){
                return BadRequest();
                throw ex;
            }  
        }      

        [HttpPut]
        public ActionResult Put([FromBody] CustomerDTO customer)
        {
            if(!ModelState.IsValid)
                return BadRequest();
             try{
                CustomerService.Update(customer);
                return Ok(StatusCodes.Status200OK);
            }
            catch(Exception ex){
                return BadRequest();
                throw ex;
            }  
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] CustomerDTO customer)
        {
            if(!ModelState.IsValid)
                return BadRequest();
            try{
                CustomerService.Delete(customer);
                return Ok(StatusCodes.Status200OK);
            }
            catch(Exception ex){
                return BadRequest();
                throw ex;
            }
        }
    }
}