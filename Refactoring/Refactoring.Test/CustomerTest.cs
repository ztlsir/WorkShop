using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Start;

namespace Refactoring.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void Verify_add_a_customer()
        {
            string movieName = "一出好戏";
            int movieType = Movie.CHILDRENS;
            Movie movie = new Movie(movieName, movieType);
            int daysRented = 10;
            Rental rental = new Rental(movie, daysRented);
            string customerName = "john";

            Customer customer = new Customer(customerName);
            customer.AddRental(rental);

            Assert.AreEqual(movieName, rental.Movie.Title);
            Assert.AreEqual(movieType, rental.Movie.PriceCode);
            Assert.AreEqual(daysRented, rental.DaysRented);
            Assert.AreEqual(customerName, customer.Name);
            Assert.IsNotNull(customer.Statement());
        }
    }
}
