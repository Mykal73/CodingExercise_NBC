using CodingExercise_NBC.Objects;
using System.Collections.Generic;
using System; 

namespace CodingExercise_NBC.ServiceLayer
{
    public interface IProductService
    {
        List<Product> GetProducts();

        Product GetProductById(int productId);

        Product UpdateProduct(string json);

        void CreateProduct(string json);

    }
}

