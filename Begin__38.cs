using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,B,X;
            Console.Write("A*X+B=0\t(A!=0)\n\nA=");
            A = double.Parse(Console.ReadLine());
            Console.Write("B=");
            B = double.Parse(Console.ReadLine());
            X = -B / A;
            Console.WriteLine($"X={X}");
        }
    }
}
