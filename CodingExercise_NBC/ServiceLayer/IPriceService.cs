using CodingExercise_NBC.Objects;
using System.Collections.Generic;

namespace CodingExercise_NBC.ServiceLayer
{
    public interface IPriceService
    {

        void CreatePrice(string json);
        Price UpdatePrice(string json);
        List<Price> GetPrices();
        Price GetPriceById(int priceId);
    }
}
