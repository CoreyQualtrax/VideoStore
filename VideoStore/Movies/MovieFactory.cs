namespace VideoStore
{
    public static class MovieFactory
    {
        public static IMovie CreateMovie(string title, int priceCode)
        {
            if(priceCode == MovieConstants.CHILDRENS)
            {
                return new ChildrensMovie(title, priceCode);
            }
            else if (priceCode == MovieConstants.NEW_RELEASE)
            {
                return new NewReleaseMovie(title, priceCode);
            }
            else
            {
                return new RegularMovie(title, priceCode);
            }
        }
    }
}
