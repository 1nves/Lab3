using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side1=");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter side2=");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1,side2);

            rectangle.Print();
           
        }
    }
}
