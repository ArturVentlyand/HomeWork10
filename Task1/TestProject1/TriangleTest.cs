using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace TestProject1
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod()]
        public void DistanceTest()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(1, 0);
            double expected = 1;

            double result = Triangle.Distance(point1, point2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            Triangle triangle1 = new Triangle
                (
                new Point(0, 0),
                new Point(1, 0),
                new Point(0, 1)
                );

            double expected = 2 + Math.Sqrt(2);

            double result = triangle1.Perimeter();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SquareTest()
        {
            Triangle triangle1 = new Triangle
                (
                new Point(0, 0),
                new Point(1, 0),
                new Point(0, 1)
                );

            double expected = 0.5;

            double result = triangle1.Square();

            Assert.AreEqual(expected, Math.Round(result, 1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnterTriangleTest()
        {
            Triangle triangle1 = new Triangle
            (
            new Point(0, 0),
            new Point(1, 0),
            new Point(0, 0)
            );
        }
    }
}