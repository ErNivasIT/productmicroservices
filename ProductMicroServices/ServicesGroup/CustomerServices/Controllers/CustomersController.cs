using CustomerServices.BAL;
using CustomerServices.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerBAL customerBAL;

        public CustomersController(ICustomerBAL customerBAL)
        {
            this.customerBAL = customerBAL;
        }
        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerViewModel>>> Get()
        {
            var res= await customerBAL.GetAllCustomers();
            return Ok(res);
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<ActionResult<CustomerViewModel>> Post([FromBody] CustomerViewModel obj)
        {
            await customerBAL.Save(obj);
            return Ok(obj);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
