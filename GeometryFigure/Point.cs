using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Point
{
    private double x, y;

    //Added 'string' in Figure

    public double X { get { return x; } }
    public double Y { get { return y; } }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
}
