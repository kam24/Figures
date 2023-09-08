namespace Figures.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Area_sides3_and4_and5_expected_6()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            Triangle triangle = new(a, b, c);
            var result = triangle.GetArea();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Area_sides_1_12_and7_5_and4_25_expected11_3679()
        {
            double a = 6.12;
            double b = 5.5;
            double c = 4.25;
            double expected = 11.3679;

            Triangle triangle = new(a, b, c);
            var result = triangle.GetArea();
            result = Math.Round(result, 4);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Triangle_sumOfTwoArgumentsLessThanThirdArgument_exception()
        {
            double a = 1.12;
            double b = 5.5;
            double c = 4.25;

            Assert.ThrowsException<ArgumentException>(() => new Triangle(a,b,c));
        }

        [TestMethod]
        public void Triangle_negativeArgument_exception()
        {
            double a = -1.12;
            double b = 5.5;
            double c = -4.25;

            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, c));
        }
    }
}
