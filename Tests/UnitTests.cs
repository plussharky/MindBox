namespace Tests
{
    public class Tests
    {
        [TestCase(new double[] { 0.56419 }, 1, TestName = "Check circle with area = 1")]
        [TestCase(new double[] { 1 }, Math.PI, TestName = "Check circle with radius = 1")]
        [TestCase(new double[] { 3, 4, 5 }, 6, TestName = "Check right triangle")]
        [TestCase(new double[] { 4, 5, 3 }, 6, TestName = "Check right triangle")]
        [TestCase(new double[] { 5, 3, 4 }, 6, TestName = "Check right triangle")]
        [TestCase(new double[] { 1, 1, 2 }, 0, TestName = "Check triangle with area = 0")]
        [TestCase(new double[] { 1, 1, 1 }, 0.433, TestName = "Check equilateral triangle")]
        [TestCase(new double[] { 1, 1, 1, 1 }, 1, TestName = "Check equilateral polygon")]
        [TestCase(new double[] { 1, 1, 1, 1, 1 }, 1.72, TestName = "Check equilateral polygon")]
        [TestCase(new double[] { 1, 1, 1, 1, 1, 1 }, 2.598, TestName = "Check equilateral polygon")]
        [TestCase(new double[] { 1, 1, 1, 1, 1, 1, 1 }, 3.634, TestName = "Check equilateral polygon")]
        public void Test(double[] input, double expectedResult)
        {
            double calculatedResult = CalculateAreaFigure.CalculateAreaFigure.CalculateArea(input);
            Assert.That(Math.Abs(calculatedResult - expectedResult) < 0.001, Is.EqualTo(true));
        }
    }
}