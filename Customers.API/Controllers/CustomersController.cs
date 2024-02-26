using Customers.API.Utility;
using Customers.Application.Customers.Dtos;
using Customers.Application.Customers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Customers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _service;
        
        public CustomersController(ICustomersService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("List")]
        public async Task<IActionResult> GetCustomers()
        {
            var response = new Response<List<GetCustomers>>();

            try
            {
                response.status = true;
                response.value = await _service.GetAllCustomers();
            }
            catch (Exception ex)
            {
                response.status = false;
                response.mensage = ex.Message;
            }

            return Ok(response);

        }

        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> SaveCustomers([FromBody] CreateCustomers customers)
        {
            var response = new Response<GetCustomers>();

            try
            {
                response.status = true;
                response.value = await _service.CreateCustomers(customers);
            }
            catch (Exception ex)
            {
                response.status = false;
                response.mensage = ex.Message;
            }

            return Ok(response);

        }

        [HttpPut]
        [Route("Edit")]
        public async Task<IActionResult> EditCustomers([FromBody] UpdateCustomers customers)
        {
            var response = new Response<bool>();

            try
            {
                response.status = true;
                response.value = await _service.UpdateCustomers(customers);
            }
            catch (Exception ex)
            {
                response.status = false;
                response.mensage = ex.Message;
            }

            return Ok(response);

        }

        [HttpDelete]
        [Route("Delete/{id:int}")]
        public async Task<IActionResult> DeleteCustomers(int id)
        {
            var response = new Response<bool>();

            try
            {
                response.status = true;
                response.value = await _service.EliminateCustomers(id);
            }
            catch (Exception ex)
            {
                response.status = false;
                response.mensage = ex.Message;
            }

            return Ok(response);

        }

    }

}
