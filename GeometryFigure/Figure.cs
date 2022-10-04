using System;

 internal class Figure 
 {
    private static Point point1;
    private static Point point2;
    private static Point point3;
    private static Point point4;
    private static Point point5;

    private string name;

    public string Name { get { return name; } }

    public Figure(Point point1, Point point2, Point point3)
    {
        Figure.point1 = point1;
        Figure.point2 = point2;
        Figure.point3 = point3;

        name = "Triangle";
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        Figure.point1 = point1;
        Figure.point2 = point2;
        Figure.point3 = point3;
        Figure.point4 = point4;

        name = "Quadrangle";
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        Figure.point1 = point1;
        Figure.point2 = point2;
        Figure.point3 = point3;
        Figure.point4 = point4;
        Figure.point5 = point5;

        name = "Pentagon";
    }

    double LengthOfTheSide(Point pointA, Point pointB)
    {
        return Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
    }

    public void PerimeterCalculator()
    {
        Point[] points = { point1, point2, point3, point4, point5 };
        double perimeter = 0.0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            if (points[i]!= null && points[i + 1]!= null)
            {
                perimeter += LengthOfTheSide(points[i], points[i + 1]);
            }
            else if (points[0]!= null && points[i]!= null)
            {
                perimeter += LengthOfTheSide(points[i], points[0]);
            }
        }
        Console.WriteLine($"Perimeter= {perimeter}");
    }

    public void Show()
    {
        Console.WriteLine(Name);
        PerimeterCalculator();
    }
 }