using System;
using System.Collections.Generic;
using CodingExercise_NBC.Objects;

namespace CodingExercise_NBC.BusinessLayer
{
    public interface IProductBusinessLogic
    {
        List<Product> GetProducts();

        List<Product> GetProductById(int productId);

        Product UpdateProduct(Product product);

        void CreateProduct(Product product);


    }
}
