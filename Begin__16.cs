using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double x_1, x_2, d;
            Console.Write("x__1=");
            x_1 = double.Parse(Console.ReadLine());
            Console.Write("x__2=");
            x_2 = double.Parse(Console.ReadLine());
            d = Math.Abs(x_2 - x_1);
            Console.WriteLine($"d={d}");
        }
    }
}
