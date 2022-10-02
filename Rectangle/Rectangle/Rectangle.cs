using System;
internal class Rectangle
{
    private double side1, side2 ;
    public double Side1 { get { return side1; } set { side1 = value; } }
    public double Side2 { get { return side2; } set { side2 = value; } }
    public double Area { get { return AreaCalculator(); } }
    public double Perimetr { get { return PerimeterCalculator(); } }
    public Rectangle (double side1, double side2 )
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    double AreaCalculator()
    {
        return side1 * side2;
    }
    double PerimeterCalculator()
    {
        return (side1 + side2) * 2;
    }
    public void Print()
    {
        Console.WriteLine($"\nArea={AreaCalculator()} \nPerimetr={PerimeterCalculator()}");
        Console.ReadLine();
    }

}
