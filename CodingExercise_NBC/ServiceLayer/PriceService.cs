using CodingExercise_NBC.BusinessLayer;
using CodingExercise_NBC.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace CodingExercise_NBC.ServiceLayer
{
    public class PriceService:IPriceService
    {
        IPricesBusinessLogic _businessLayer = new PriceBusinessLogic(); 
        public void CreatePrice(string json)
        {
            Price price = JsonSerializer.Deserialize<Price>(json);
            _businessLayer.CreatePrice(price);
        }

        public List<Price> GetPrices()
        {
            return _businessLayer.GetPrices();
        }

        public Price GetPriceById(int priceId)
        {
            List<Price> priceList = _businessLayer.GetPriceById(priceId);
            return priceList.FirstOrDefault();
        }

        public Price UpdatePrice(string json)
        {
            Price price = JsonSerializer.Deserialize<Price>(json);
            return _businessLayer.UpdatePrice(price);
        }
    }
}
