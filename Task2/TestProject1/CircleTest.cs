using HomeWork10;

namespace TestProject1
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeRadius()
        {
            Circle circle = new Circle("Circle", -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullName()
        {
            string nullName = null;
            Circle circle = new Circle(nullName, 1);
        }

        [TestMethod]
        public void AreaTest()
        {
            Circle circle = new Circle("Circle", 2);
            double expected = Math.PI * 4;

            double result = circle.Area();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            Circle circle = new Circle("Circle", 3);
            double expected = Math.PI * 6;

            double result = circle.Perimeter();

            Assert.AreEqual(expected, result);
        }
    }
}