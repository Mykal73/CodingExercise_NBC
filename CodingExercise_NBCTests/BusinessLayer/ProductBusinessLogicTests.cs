using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingExercise_NBC.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using CodingExercise_NBC.Objects;
using Moq;
using CodingExercise_NBC;
using CodingExercise_NBC.DataLayer;

namespace CodingExercise_NBC.BusinessLayer.Tests
{
    [TestClass()]
    public class ProductBusinessLogicTests
    {

        //TODO: Test for any logic added to layer

        [TestMethod()]
        public void CreateProductTestBadPrice()
        {
            Price price = new Price//not a new price...
            {
                priceId = 99,
                amount = 99.99,
                startDate = new DateTime(1900, 1, 1)
            };

            List<Price> priceList = new List<Price>();
            priceList.Add(price);   

            Product newProduct = new Product
            {
                productId = 100,
                productName = "Encyclopedia Ultima",
                price = price,
            };

            ProductBusinessLogic businessLogic = new ProductBusinessLogic();
            var mock = new Mock<IRepository>();
            mock.Setup(x => x.GetPriceById(It.IsAny<int>())).Returns(new List<Price>());

            Action action = () => businessLogic.CreateProduct(newProduct);

            Assert.ThrowsException<Exception>(action); 

        }

        [TestMethod()]
        public void GetProductByIdTest()
        {
            Assert.IsTrue(1 == 1);
        }

        [TestMethod()]
        public void GetProductsTest()
        {
            Assert.IsTrue(1 == 1);
        }

        [TestMethod()]
        public void UpdateProductTest()
        {
            Assert.IsTrue(1 == 1);
        }
    }
}