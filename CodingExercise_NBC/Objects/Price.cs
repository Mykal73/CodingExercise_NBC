using System;

namespace CodingExercise_NBC.Objects
{
    public class Price
    {
        public int priceId { get; set; } 
        public double amount { get; set; }  
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }  
    }
}
