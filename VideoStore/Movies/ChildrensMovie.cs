namespace VideoStore
{
    public class ChildrensMovie : IMovie
    {
        private string title;
        private int priceCode;

        public ChildrensMovie(string title, int priceCode)
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
                return (daysRented > 3) ? 1.5 + (daysRented - 3) * 1.5 : 1.5;          
        }
    }
}
