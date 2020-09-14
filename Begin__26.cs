using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,y;
            Console.Write("x=");
            x = double.Parse(Console.ReadLine());
            y = 4 * Math.Pow(x-3, 6) - 7 * Math.Pow(x-3, 2) + 2;
            Console.WriteLine($"x={x}, y={y}");
        }
    }
}
