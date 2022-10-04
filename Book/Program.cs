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
            Book book = new Book();
            book.addtheTitleAuthorContent("Neverwhere", "Neil Gaima", "This story was begin with...");
            book.Show();
            Console.ReadLine();
        }
    }
}
