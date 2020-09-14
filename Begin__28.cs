using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,A2;
            Console.Write("A=");
            A = double.Parse(Console.ReadLine());
            A2 = A * A;
            Console.WriteLine($"A^2={A}");
            A = A2 * A;
            Console.WriteLine($"A^3={A}");
            A = A2 * A;
            Console.WriteLine($"A^5={A}");
            A2 = A * A;
            Console.WriteLine($"A^10={A2}");
            A = A2 * A;
            Console.WriteLine($"A^15={A}");
        }
    }
}
