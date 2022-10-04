using System;

namespace GeometryFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(2, 3), new Point(1, 4), new Point(4, 2),new Point(-1,7 ), new Point (0,1.4));
            figure.Show();
            Console.ReadLine();
        }
    }
}
