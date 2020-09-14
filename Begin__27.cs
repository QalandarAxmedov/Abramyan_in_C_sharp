using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            Console.Write("A=");
            A = double.Parse(Console.ReadLine());
            A = A * A;
            Console.WriteLine($"A^2={A}");
            A = A * A;
            Console.WriteLine($"A^4={A}");
            A = A * A;
            Console.WriteLine($"A^8={A}");
        }
    }
}
