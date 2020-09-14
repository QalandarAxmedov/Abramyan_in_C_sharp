using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            Console.Write("A=");
            A = double.Parse(Console.ReadLine());
            Console.Write("B=");
            B = double.Parse(Console.ReadLine());
            Console.Write("C=");
            C = double.Parse(Console.ReadLine());
            Console.WriteLine($"A={A}, B={B}, C={C}");
            A = A + B + C;
            B = A - B - C;
            C = A - B - C;
            A = A - B - C;
            Console.WriteLine($"A={A}, B={B}, C={C}");
        }
    }
}
