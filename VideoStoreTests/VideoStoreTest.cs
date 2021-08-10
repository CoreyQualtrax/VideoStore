using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoStore;

namespace VideoStoreTests
{
    [TestClass]
    public class VideoStoreTest
    {
        private Customer customer;

        [TestInitialize]
        public void SetUp()
        {
            customer = new Customer("Fred");
        }

        [TestMethod]
        public void TestSingleNewReleaseStatement()
        {
            customer.AddRental(new Rental(MovieFactory.CreateMovie("The Cell", MovieConstants.NEW_RELEASE), 3));
            Assert.AreEqual("Rental Record for Fred\n\tThe Cell\t9\nYou owed 9\nYou earned 2 frequent renter points\n", customer.Statement());
        }

        [TestMethod]
        public void TestDualNewReleaseStatement()
        {
            customer.AddRental(new Rental(MovieFactory.CreateMovie("The Cell", MovieConstants.NEW_RELEASE), 3));
            customer.AddRental(new Rental(MovieFactory.CreateMovie("The Tigger Movie", MovieConstants.NEW_RELEASE), 3));
            Assert.AreEqual("Rental Record for Fred\n\tThe Cell\t9\n\tThe Tigger Movie\t9\nYou owed 18\nYou earned 4 frequent renter points\n", customer.Statement());
        }

        [TestMethod]
        public void TestSingleChildrensStatement()
        {
            customer.AddRental(new Rental(MovieFactory.CreateMovie("The Tigger Movie", MovieConstants.CHILDRENS), 3));
            Assert.AreEqual("Rental Record for Fred\n\tThe Tigger Movie\t1.5\nYou owed 1.5\nYou earned 1 frequent renter points\n", customer.Statement());
        }

        [TestMethod]
        public void TestSingleChildrensStatementGreaterThan3()
        {
            customer.AddRental(new Rental(MovieFactory.CreateMovie("The Tigger Movie", MovieConstants.CHILDRENS), 4));
            Assert.AreEqual("Rental Record for Fred\n\tThe Tigger Movie\t3\nYou owed 3\nYou earned 1 frequent renter points\n", customer.Statement());
        }

        [TestMethod]
        public void TestMultipleRegularStatement()
        {
            customer.AddRental(new Rental(MovieFactory.CreateMovie("Plan 9 from Outer Space", MovieConstants.REGULAR), 1));
            customer.AddRental(new Rental(MovieFactory.CreateMovie("8 1/2", MovieConstants.REGULAR), 2));
            customer.AddRental(new Rental(MovieFactory.CreateMovie("Eraserhead", MovieConstants.REGULAR), 3));

            Assert.AreEqual("Rental Record for Fred\n\tPlan 9 from Outer Space\t2\n\t8 1/2\t2\n\tEraserhead\t3.5\nYou owed 7.5\nYou earned 3 frequent renter points\n", customer.Statement());
        }
    }
}
