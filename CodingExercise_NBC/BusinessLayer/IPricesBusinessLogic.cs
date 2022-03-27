using CodingExercise_NBC.Objects;
using System.Collections.Generic;

namespace CodingExercise_NBC.BusinessLayer
{
    public interface IPricesBusinessLogic
    {
        void CreatePrice(Price price);
        Price UpdatePrice(Price price);
        System.Collections.Generic.List<Price> GetPrices();
        List<Price> GetPriceById(int priceId);
    }
}
