namespace VideoStore
{
    public class NewReleaseMovie : IMovie
    {
        private string title;
        private int priceCode;

        public NewReleaseMovie(string title, int priceCode)
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
            return daysRented * 3;
        }
    }
}
