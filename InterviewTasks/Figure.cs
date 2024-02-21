public abstract class Figure
{
    public abstract double CalculateArea();
}

public class Circle : Figure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius should be greater than zero.");

        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Triangle : Figure, IAdvancedTriangle
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Sides should be greater than zero.");

        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("One side is too long to form a triangle.");

        A = a;
        B = b;
        C = c;
    }

    public override double CalculateArea()
    {
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

    public bool IsRightAngled()
    {
        double[] sides = { A, B, C };
        Array.Sort(sides);
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) <= 1e-10;
    }
}