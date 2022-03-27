using CodingExercise_NBC.ServiceLayer;
using System.Collections.Generic; 
using Microsoft.AspNetCore.Mvc;
using CodingExercise_NBC.Objects; 


namespace CodingExercise_NBC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _serviceLogic = new ProductService();
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _serviceLogic.GetProducts();
        }
        [HttpPost("{id}")]
        public Product GetProductById(int productId)
        {
            return _serviceLogic.GetProductById(productId);
        }
        [HttpPost("{id}")]
        public void  UpdateProduct([FromBody] string value)
        {
            _serviceLogic.UpdateProduct(value);
        }
        [HttpPost]
        public void CreateProduct([FromBody] string value)
        {
            _serviceLogic.CreateProduct(value);
        }

    }
}
