using CodingExercise_NBC.Objects;
using System.Collections.Generic;
using CodingExercise_NBC.DataLayer;
using System.Linq;

namespace CodingExercise_NBC.BusinessLayer
{
    public class ProductBusinessLogic : IProductBusinessLogic
    {
        private readonly IRepository _repo = new MockRepository(); 


        public void CreateProduct(Product product)
        {
            PriceBusinessLogic priceBusinessLogic = new PriceBusinessLogic();
            
            if (priceBusinessLogic.GetPriceById(product.price.priceId).Any())
            {
                _repo.CreateProduct(product);
            }
            else
            {
                throw new System.Exception("Price not found, please use an existing price.");
            }
        }
        public List<Product> GetProductById(int productId)
        {
            return _repo.GetProductById(productId);
        }

        public List<Product> GetProducts()
        {
            return _repo.GetProducts();
        }

        public Product UpdateProduct(Product product)
        {
            return _repo.UpdateProduct(product);
        }


    }
}
