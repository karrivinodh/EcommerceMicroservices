using Microsoft.AspNetCore.Mvc;
using Review.Model;
using ReviewMicroService.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReviewMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        // GET: api/<ReviewController>
        [HttpGet]
        public List<Reviews> Get()
        {
            return ReviewService.Get(); 
        }

        // GET api/<ReviewController>/5
        [HttpGet("{id}")]
        public Reviews GetById(int id)
        {
            return ReviewService.GetByID(id);   
        }

        // POST api/<ReviewController>
        [HttpPost]
        public Reviews Post([FromBody] Reviews reviews)
        {
            return ReviewService.Post(reviews);
        }

      
    }
}
