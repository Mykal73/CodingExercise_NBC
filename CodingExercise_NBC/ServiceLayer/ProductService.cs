using CodingExercise_NBC.Objects;
using System.Collections.Generic;
using CodingExercise_NBC.BusinessLayer;
using System.Text.Json;
using System.Linq;

namespace CodingExercise_NBC.ServiceLayer
{
    public class ProductService : IProductService
    {
        private readonly IProductBusinessLogic _businessLayer = new ProductBusinessLogic();


        public void CreateProduct(string json)
        {
            Product product = JsonSerializer.Deserialize<Product>(json); 
            _businessLayer.CreateProduct(product); 
        }

        public Product GetProductById(int productId)
        {
            List<Product> products = _businessLayer.GetProductById(productId);
            return products.FirstOrDefault();
            
        }

        public List<Product> GetProducts()
        {
            return _businessLayer.GetProducts();    
        }

        public Product UpdateProduct(string json)
        {
            Product product = JsonSerializer.Deserialize<Product>(json);
            return _businessLayer.UpdateProduct(product);   
        }


    }
}
