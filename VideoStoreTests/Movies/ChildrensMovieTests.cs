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
    public class ChildrensMovieTests
    {
        ChildrensMovie movie;
        public ChildrensMovieTests()
        {
            movie = new ChildrensMovie("Terminator 2", 3);
        }

        [TestMethod]
        public void TestPriceThreeDays()
        {
            Assert.AreEqual(movie.CalculateMoviePrice(3), 1.5);
        }

        [TestMethod]
        public void TestPriceLessThanThreeDays()
        {
            Assert.AreEqual(movie.CalculateMoviePrice(2), 1.5);
        }

        [TestMethod]
        public void TestPriceGreaterThanThreeDays()
        {
            Assert.AreEqual(movie.CalculateMoviePrice(4), 3);
        }
    }
}
