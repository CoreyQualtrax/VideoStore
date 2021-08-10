namespace VideoStore
{
    public class RegularMovie : IMovie
    {
        private string title;
        private int priceCode;

        public RegularMovie(string title, int priceCode)
        {
            this.title = title;
            this.priceCode = priceCode;
        }

        public int GetPriceCode()
        {
            return priceCode;
        }

        public string GetTitle()
        {
            return title;
        }

        public double CalculateMoviePrice(int daysRented)
        {
            return (daysRented > 2) ? 2 + (daysRented - 2) * 1.5 : 2;
        }
    }
}
