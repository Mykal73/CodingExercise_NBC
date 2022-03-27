using CodingExercise_NBC.Objects;
using System.Collections.Generic;
using System;
using System.Linq;

namespace CodingExercise_NBC.DataLayer
{
    public class MockRepository : IRepository
    {
        

        private List<Product> _products = new List<Product>
        {
            MockProducts.product1, 
            MockProducts.product2, 
            MockProducts.product3,
            MockProducts.product4  
        };


        private List<Price> _prices = new List<Price>
        {
            MockPrices.price1,
            MockPrices.price2,
            MockPrices.price3,
            MockPrices.price4

        }; 

        public void CreatePrice(Price price)
        {
            _prices.Add(price);
        }

        public void CreateProduct(Product product)
        {
            _products.Add(product); 
        }

        public List<Price> GetPriceById(int priceId)
        {
            List<Price> prices = GetPrices();

            return prices.Where(p => p.priceId == priceId).ToList();
        }

        public List<Price> GetPrices()
        {
           return _prices;
        }

        public List<Product> GetProductById(int productId)
        {
            List<Product> products = GetProducts();
            return products.Where(p => p.productId == productId).ToList();
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Price UpdatePrice(Price price)
        {
            List<Price> prices = GetPrices();

            List<Price> existingPrice = prices.Where(p => p.priceId != price.priceId).ToList();
            existingPrice.Add(price);
            _prices = existingPrice;
            return price;
        }

        public Product UpdateProduct(Product product)
        {
            List<Product> products = GetProducts(); 

            List<Product> existingProduct = products.Where(p => p.productId != product.productId).ToList();
            existingProduct.Add(product);
            _products = existingProduct;
            return product; 
        }
    }


    public class MockProducts
    {
        public static Product product1 = new Product
        {
            productId = 1,
            productName = "Book1",
            price = MockPrices.price2,
            currentProduct = true

        };
        public static Product product2 = new Product
        {
            productId = 2,
            productName = "Book2",
            price = MockPrices.price3,
            currentProduct = true

        };
        public static Product product3 = new Product
        {
            productId = 1,
            productName = "BookThree",
            price = MockPrices.price2,
            currentProduct = true

        };
        public static Product product4 = new Product
        {
            productId = 4,
            productName = "BookIV",
            price = MockPrices.price4,
            currentProduct = false

        };
    }

    public class MockPrices
    {
        public static Price price1 = new Price
        {
            priceId = 1,
            amount = 1.00,
            startDate = new DateTime(2002,1,1),
            endDate = new DateTime(2012,12,31)
        };

        public static Price price2 = new Price
        {
            priceId = 2,
            amount = 2.00,
            startDate = new DateTime(2013, 1, 1)
        }; 
        public static Price price3 = new Price
        {
            priceId = 3,
            amount = 3.00,
            startDate = new DateTime(2002, 1, 1)
        }; 
        public static Price price4 = new Price
        {
            priceId = 4,
            amount = .99,
            startDate = new DateTime(2002, 1, 1)
        }; 
        
    }

}
