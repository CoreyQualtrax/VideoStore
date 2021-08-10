using System;
using System.Collections.Generic;

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
            String result = "Rental Record for " + GetName() + "\n";

            foreach (var rental in rentals)
            {
                double thisAmount = rental.CalculatePrice();

                frequentRenterPoints += rental.CalculateFrequentRenterPoints();

                result += "\t" + rental.GetMovie().GetTitle() + "\t"
                                    + thisAmount + "\n";
                totalAmount += thisAmount;
            }

            result += "You owed " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";
            return result;
        }
    }
}
