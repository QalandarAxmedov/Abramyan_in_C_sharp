using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,B;
            Console.Write("A=");
            A = double.Parse(Console.ReadLine());
            Console.Write("B=");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine($"A={A}, B={B}");
            A += B;
            B = A - B;
            A = A - B;
            Console.WriteLine($"A={A}, B={B}");
        }
    }
}
