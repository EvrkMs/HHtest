namespace HHtest.ShapeLibrary
{
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("All sides must be positive.");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("The sides do not form a valid triangle.");

            A = a;
            B = b;
            C = c;
        }

        public double CalculateArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRightAngled()
        {
            var sides = new[] { A, B, C }.OrderBy(x => x).ToArray();
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }
    }
}
