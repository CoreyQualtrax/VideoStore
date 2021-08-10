namespace VideoStore
{
    public interface IMovie
    {
        int GetPriceCode();
        string GetTitle();
        double CalculateMoviePrice(int daysRented);
    }
}