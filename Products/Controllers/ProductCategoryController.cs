using Microsoft.AspNetCore.Mvc;
using Products.Model;
using Products.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductCategory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        // GET: api/<ProductCategoryController>
        [HttpGet("GetCategoryList")]
        public List<Productcategory> Get()
        {
            return ProductCategoryService.Get();
        }

        // GET api/<ProductCategoryController>/5

        [HttpGet("{id}")]
        public Productcategory Get(int id)
        {
            return ProductCategoryService.GetByID(id);
        }

        [HttpGet("{categoryid}")]
        
         public Product GetByCategoryId(int id)
        {
            return ProductServices.GetByCategoryID(id);
        }
    

        // POST api/<ProductCategoryController>

        [HttpPost]
        public Productcategory Post(Productcategory productCategory)
        {
            return ProductCategoryService.Post(productCategory);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
       public void Delete(int id)
        {
            ProductCategoryService.DeleteById(id);
        }

        // PUT api/<ProductCategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id,Productcategory productCategory)
        {
            ProductCategoryService.Update(id,productCategory);
        }

        // DELETE api/<ProductCategoryController>/5
       
    }
}
