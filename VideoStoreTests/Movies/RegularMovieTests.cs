using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStore;

namespace VideoStoreTests.Movies
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class RegularMovieTests
    {
        RegularMovie movie;
        public RegularMovieTests()
        {
            movie = new RegularMovie("A Regular Movie", 3);
        }

        [TestMethod]
        public void TestPriceOneDay()
        {
            Assert.AreEqual(movie.CalculateMoviePrice(1), 2);
        }

        [TestMethod]
        public void TestPriceTwoDays()
        {
            Assert.AreEqual(movie.CalculateMoviePrice(2), 2);
        }

        [TestMethod]
        public void TestPriceThreeDays()
        {
            Assert.AreEqual(movie.CalculateMoviePrice(3), 3.5);
        }
    }
}
