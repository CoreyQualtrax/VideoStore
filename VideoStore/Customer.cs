using System;
using System.Collections.Generic;
using System.Text;

namespace VideoStore
{
    public class Customer
    {
        private String name;
        private List<Rental> rentals = new List<Rental>();

        public Customer(string name)
        {
            this.name = name;
        }

        public void AddRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public string GetName()
        {
            return name;
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            StringBuilder result = new StringBuilder();
            result.Append($"Rental Record for {GetName()}\n");

            foreach (var rental in rentals)
            {
                double thisAmount = rental.CalculatePrice();
                frequentRenterPoints += rental.CalculateFrequentRenterPoints();
                result.Append($"\t{rental.GetMovie().GetTitle()}");
                result.Append($"\t{thisAmount}\n");
     
                totalAmount += thisAmount;
            }

            result.Append($"You owed {totalAmount}\n");
            result.Append($"You earned {frequentRenterPoints} frequent renter points\n");
            return result.ToString();
        }
    }
}
