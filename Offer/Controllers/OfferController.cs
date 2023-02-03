using Microsoft.AspNetCore.Mvc;
using OfferMicroService.Model;
using OfferMicroService.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Offer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        // GET: api/<OfferController>
        [HttpGet]
        public List<Offers>Get()
        {
            return OfferService.Get();
        }

        // GET api/<OfferController>/5
        [HttpGet("{id}")]
        public Offers GetById(int id)
        {
            return OfferService.GetByOfferID(id);   
        }

        // POST api/<OfferController>
        [HttpPost]
        public Offers Post([FromBody] Offers offer)
        {
            return OfferService.Post(offer);

        }

        // PUT api/<OfferController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Offers offer)
        {
            OfferService.Update(id, offer);   
        }

        // DELETE api/<OfferController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             OfferService.DeleteById(id); 
        }
    }
}
