namespace VideoStore
{
    public class Rental
    {
        private IMovie movie;
        private int daysRented;

        public Rental(IMovie movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        public IMovie GetMovie()
        {
            return movie;
        }

        public int CalculateFrequentRenterPoints()
        {
            return (movie.GetPriceCode() == MovieConstants.NEW_RELEASE && daysRented > 1) ? 2 : 1;
        }

        public double CalculateRentalPrice()
        {
            return movie.CalculateMoviePrice(daysRented);
        }

    }
}
