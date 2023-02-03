using CartMicroservice.Model;
using CartMicroservice.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CartMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        // GET: api/<CartController>
        CartService cartService = new CartService();
        [HttpGet]
        public  List<CartItem> Get()
        {
            
            return cartService.GetAll();
        }
        [HttpPost]
        public void Post(CartItem cartItem)
        {
            cartService.Add(cartItem);
        }

        [HttpDelete]
        public void Delete(CartItem cartItem)
        {
            cartService.Delete(cartItem);
        }
        // GET api/<CartController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

      

       
       

        // DELETE api/<CartController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
