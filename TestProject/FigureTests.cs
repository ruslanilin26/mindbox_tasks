namespace TestProject
{
    public class FigureTests
    {
        [Fact]
        public void TestCircleArea()
        {
            var circle = new Circle(5);
            double expectedArea = Math.PI * 25;
            Assert.Equal(expectedArea, circle.CalculateArea(), 5);
        }

        [Fact]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea(), 5);
        }

        [Fact]
        public void TestRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightAngled());
        }

        [Fact]
        public void TestNotRightTriangle()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.IsRightAngled());
        }

        [Fact]
        public void TestInvalidTriangle()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 4, 5));
        }
    }
}