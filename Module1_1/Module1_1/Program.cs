using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = a + b - (b = a);
            Console.WriteLine(a + ";" + b);
            Console.ReadKey();
        }
    }
}
