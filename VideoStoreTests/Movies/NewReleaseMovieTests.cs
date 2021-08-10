using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStore;

namespace VideoStoreTests.Movies
{
    [TestClass]
    public class NewReleaseMovieTests
    {
        NewReleaseMovie movie;
        public NewReleaseMovieTests()
        {
            movie = new NewReleaseMovie("Generic Super Hero Movie 3", 3);
        }

        [TestMethod]
        public void TestPriceThreeDays()
        {
            Assert.AreEqual(movie.CalculateMoviePrice(3), 9);
        }

        [TestMethod]
        public void TestPriceZeroDays()
        {
            Assert.AreEqual(movie.CalculateMoviePrice(0), 0);
        }

        [TestMethod]
        public void TestPriceTenDays()
        {
            Assert.AreEqual(movie.CalculateMoviePrice(10), 30);
        }

    }
}
