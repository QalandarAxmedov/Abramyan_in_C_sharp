using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double L, S, D,pi=3.14;
            Console.Write("S=");
            S = double.Parse(Console.ReadLine());
            D = Math.Sqrt(4 * S / pi);
            L = pi * D;
            Console.WriteLine($"D={D}\nL={L}");
        }
    }
}
