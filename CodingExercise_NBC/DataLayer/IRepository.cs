using System;
using System.Collections.Generic;
using CodingExercise_NBC.Objects; 


namespace CodingExercise_NBC.DataLayer
{
    public interface IRepository
    {
        List<Product> GetProducts();

        List<Product> GetProductById(int productId); 

        Product UpdateProduct(Product product); 

        void CreateProduct(Product product);

        void CreatePrice(Price price); 
        Price UpdatePrice(Price price);
        List<Price> GetPrices();
        List<Price> GetPriceById(int priceId);

    }
}
