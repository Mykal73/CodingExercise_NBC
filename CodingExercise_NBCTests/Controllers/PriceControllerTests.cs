using CodingExercise_NBC.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace CodingExercise_NBC.Controllers.PriceController.Tests
{
    [TestClass()]
    public class PriceControllerTests
    {
        [TestMethod()]
        public void GetPricesTest()
        {
            PriceWebController controller = new PriceWebController();
            List<Price> prices = controller.GetPrices().ToList();
            Assert.IsTrue(prices.Count == 4);
        }
        
        [TestMethod()]
        public void GetPriceByIdTest()
        {
            PriceWebController controller = new PriceWebController();
            Price price = controller.GetPriceById(1);
            Assert.IsNotNull(price);
        }

        [TestMethod()]
        public void CreatePriceTest()
        {
            Price newPrice = new Price
            {
                priceId = 10,
                amount = 100.50,
                startDate = DateTime.Now,
            };


            PriceWebController controller = new PriceWebController();
            string jsonProduct = JsonSerializer.Serialize(newPrice);
            controller.CreatePrice(jsonProduct);

            Price price = controller.GetPriceById(10);
            Assert.IsNotNull(price);
        }

        [TestMethod()]
        public void UpdatePriceTest()
        {
        Price price1 = new Price
        {
            priceId = 1,
            amount = 1.00,
            startDate = DateTime.Now,
            endDate = null
        };


        PriceWebController controller = new PriceWebController();
            string jsonProduct = JsonSerializer.Serialize(price1);
            controller.UpdatePrice(jsonProduct);

            Price price = controller.GetPriceById(1);
            Assert.IsNull(price.endDate); 

        }


    }
}