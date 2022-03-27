using CodingExercise_NBC.DataLayer;
using CodingExercise_NBC.Objects;
using System.Collections.Generic;
namespace CodingExercise_NBC.BusinessLayer
{
    public class PriceBusinessLogic : IPricesBusinessLogic
    {
        private readonly IRepository _repo = new MockRepository();
        public void CreatePrice(Price price)
        {
            _repo.CreatePrice(price);
        }

        public List<Price> GetPriceById(int priceId)
        {
            return _repo.GetPriceById(priceId);
        }

        public List<Price> GetPrices()
        {
            return _repo.GetPrices();
        }

        public Price UpdatePrice(Price price)
        {

            return _repo.UpdatePrice(price);
        }
    }
}
