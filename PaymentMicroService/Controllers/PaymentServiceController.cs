using Microsoft.AspNetCore.Mvc;
using PaymentMicroService.Models;
using PaymentMicroService.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaymentMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentServiceController : ControllerBase
    {
        // GET: api/<PaymentServiceController>
        [HttpGet]
        public List<PaymentMethod>Get()
        {
            return PaymentService.Get();
        }

        // GET api/<PaymentServiceController>/5
        [HttpGet("{id}")]
        public PaymentMethod GetById(int id)
        {
            return PaymentService.GetByID(id);  
        }

     
       
    }
}
