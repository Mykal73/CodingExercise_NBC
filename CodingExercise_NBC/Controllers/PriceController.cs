using CodingExercise_NBC.Objects;
using CodingExercise_NBC.ServiceLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CodingExercise_NBC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceWebController : Controller
    {
        private readonly IPriceService _serviceLogic = new PriceService();

        [HttpGet]
        public IEnumerable<Price> GetPrices()
        {
            return _serviceLogic.GetPrices();
        }
        
        [HttpPost]
        public void CreatePrice([FromBody] string value)
        {
            _serviceLogic.CreatePrice(value);
        }
        [HttpPost("id")]
        public Price UpdatePrice([FromBody] string value)
        {
            return _serviceLogic.UpdatePrice(value);
        }
        [HttpGet("{id}")]
        public Price GetPriceById(int priceId)
        {
            return _serviceLogic.GetPriceById(priceId);
        }

    }
}
