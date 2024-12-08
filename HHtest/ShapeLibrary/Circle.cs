namespace HHtest.ShapeLibrary
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive.");
            Radius = radius;
        }

        public double CalculateArea() => Math.PI * Radius * Radius;
    }
}
