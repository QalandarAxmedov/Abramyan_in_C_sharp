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
            y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
            Console.WriteLine($"x={x}, y={y}");
        }
    }
}
