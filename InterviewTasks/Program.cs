class Program
{
    static void Main()
    {
        double circleRadius = 7;
        double triangleSide1 = 3;
        double triangleSide2 = 4;
        double triangleSide3 = 5;

        Circle circle = new Circle(circleRadius);
        Triangle triangle = new Triangle(triangleSide1, triangleSide2, triangleSide3);

        // Площадь круга
        Console.WriteLine($"Circle Area with radius {circleRadius}: {circle.CalculateArea()}");

        // Площадь треугольника
        Console.WriteLine($"Triangle Area with sides {triangleSide1}, {triangleSide2}, {triangleSide3}: {triangle.CalculateArea()}");

        // Проверка на прямоугольность треугольника
        bool isRightTriangle = triangle.IsRightAngled();
        Console.WriteLine($"Is the triangle right-angled? {isRightTriangle}");
    }
}