using asp.netIntro.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.netIntro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;
       
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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

        [HttpGet("high-price")]
        public async Task<IActionResult> GetHigherPricedProducts([FromQuery] int count)
        {
            var products = await _productService.GetHigherPricedProducts(count);
            return Ok(products);
        }
        [HttpGet("most-discount")]
        public async Task<IActionResult> GetMostDiscountedProducts([FromQuery] int count)
        {
            var products = await _productService.GetMostDiscountedProducts(count);
            return Ok(products);
        }
    }
}
