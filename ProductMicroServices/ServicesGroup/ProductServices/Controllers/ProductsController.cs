using Microsoft.AspNetCore.Mvc;
using ProductServices.BAL;
using ProductServices.ViewModels;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductBAL productBAL;

        public ProductsController(IProductBAL productBAL)
        {
            this.productBAL = productBAL;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IEnumerable<ProductViewModel>> Get()
        {
            var res=await productBAL.GetAllProducts();
            return res;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult<ProductViewModel>>  Post([FromBody] ProductViewModel obj)
        {
            var res = await productBAL.Save(obj);
            return res;
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
