using HHtest.ShapeLibrary;

namespace HHtest
{
    public class UnitTest1
    {
        [Fact]
        public void CircleAreaTest()
        {
            var circle = new Circle(10);
            Assert.Equal(Math.PI * 100, circle.CalculateArea(), 5);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea(), 5);
        }

        [Fact]
        public void TriangleIsRightAngledTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightAngled());
        }
    }
}