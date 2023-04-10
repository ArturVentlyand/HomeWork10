using System.Drawing;

namespace TestProject2
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            Point point = new Point(0, 1);
            string expected = "{X=0,Y=1}";

            string result = point.ToString();

            Assert.AreEqual(expected, result);
        }
    }
}