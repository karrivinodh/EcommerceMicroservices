using Microsoft.AspNetCore.Mvc;
using Products.Model;
using Products.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public List<Product> Get()
        {
            return ProductServices.Get();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return ProductServices.GetByID(id);
        }

        // POST api/<ProductController>
        [HttpPut]

        public void Put(int id,Product product)
        {
            ProductServices.Update(id,product);
        }
        // PUT api/<ProductController>/5
        [HttpPost]
        public Product Post(Product product)
        {
            return ProductServices.Post(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
         public void Delete(int id)
         {
            ProductServices.DeleteById(id);  
         }
    }

}
