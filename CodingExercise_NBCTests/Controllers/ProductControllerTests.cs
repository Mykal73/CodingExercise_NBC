using CodingExercise_NBC.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace CodingExercise_NBC.Controllers.Tests
{
    [TestClass()]
    public class ProductControllerTests
    {
        [TestMethod()]
        public void GetProductsTest()
        {
            ProductController controller = new ProductController();
            List<Product> products = controller.GetProducts().ToList();
            Assert.IsTrue(products.Count == 4); 
        }

        [TestMethod()]
        public void GetProductByIdTest()
        {
            ProductController controller = new ProductController();
            Product product = controller.GetProductById(1); 
            Assert.IsTrue(product.productName != null);
        }

        [TestMethod()]
        public void UpdateProductTest()
        {
            Price price3 = new Price
            {
                priceId = 3,
                amount = 3.00,
                startDate = new DateTime(2002, 1, 1)
            }; 
        Product product1 = new Product
        {
            productId = 1,
            productName = "Book1",
            price = price3,
            currentProduct = true

        };

            ProductController controller = new ProductController();
            string jsonProduct = JsonSerializer.Serialize(product1);
            controller.UpdateProduct(jsonProduct); 

            Product updatedProduct = controller.GetProductById(1); 
            Assert.IsTrue(updatedProduct.price.priceId == 3);
    }

        [TestMethod()]
        public void CreateProductTest()
        {
            Price price = new Price
            {
                priceId = 2,
                amount = 2.00,
                startDate = new DateTime(2013, 1, 1)
            };
            Product newProduct = new Product
            {
                productId = 5,
                productName = "BookCinco",
                price = price,

            };

            ProductController controller = new ProductController();
            string jsonProduct = JsonSerializer.Serialize(newProduct); 
            controller.CreateProduct(jsonProduct);

            Product product = controller.GetProductById(5);
            Assert.IsNotNull(product);  
        }
    }
}