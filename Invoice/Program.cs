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
            Invoice invoice = new Invoice(400," Illya","McDonalds","Article about fastfood", 45);

            invoice.Print();
            Console.ReadLine();
        }
    }
}
