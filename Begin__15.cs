using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi=3.14;
            double L, S, D;
            Console.Write("S=");
            S = double.Parse(Console.ReadLine());
            D = Math.Sqrt(4 * S / pi);
            L = pi * D;
            Console.WriteLine($"D={D}\nL={L}");
        }
    }
}
