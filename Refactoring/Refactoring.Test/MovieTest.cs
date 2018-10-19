using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Start;

namespace Refactoring.Test
{
    [TestClass]
    public class MovieTest
    {
        [TestMethod]
        public void Verify_add_a_movie()
        {
            string movieName = "一出好戏";
            int movieType = Movie.CHILDRENS;

            var movie = new Movie(movieName, movieType);

            Assert.AreEqual(movieName, movie.Title);
            Assert.AreEqual(movieType, movie.PriceCode);
        }
    }
}
