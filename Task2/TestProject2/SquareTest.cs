using HomeWork10;

namespace TestProject2
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeRadius()
        {
            Square square = new Square("Square", -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullName()
        {
            string nullName = null;
            Square square = new Square(nullName, 1);
        }

        [TestMethod]
        public void AreaTest()
        {
            Square square = new Square("Square", 2);
            double expected = 4;

            double result = square.Area();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            Square square = new Square("Square", 2);
            double expected = 8;

            double result = square.Perimeter();

            Assert.AreEqual(expected, result);
        }
    }
}