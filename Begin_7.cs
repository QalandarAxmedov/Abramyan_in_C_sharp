using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            const double  pi = 3.14;
            double R, L, S;
            Console.Write("R=");
            R = double.Parse(Console.ReadLine());
            S = pi * Math.Pow(R, 2);
            L = 2 * pi * R;
            Console.Write("S={0}\nL={1}",S,L);
        }
    }
}
