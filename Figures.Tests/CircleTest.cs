namespace Figures.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Area_radius12_expected452_389()
        {
            var radius = 12;
            var expected = 452.389;

            Circle circle = new(radius);
            var result = Math.Round(circle.GetArea(), 3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Area_radius21_34_expected1430_667()
        {
            var radius = 21.34;
            var expected = 1430.667;

            Circle circle = new(radius);
            var result = Math.Round(circle.GetArea(), 3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Circle_radiusLessThanZero_exception()
        {
            var radius = -5;
            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        }
    }
}