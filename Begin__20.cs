using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double x_1,x_2,y_1,y_2,d;
            Console.Write("x__1=");
            x_1 = double.Parse(Console.ReadLine());
            Console.Write("y__1=");
            y_1 = double.Parse(Console.ReadLine());
            Console.Write("x__2=");
            x_2 = double.Parse(Console.ReadLine());
            Console.Write("y__2=");
            y_2 = double.Parse(Console.ReadLine());
            d = Math.Sqrt(Math.Pow(x_2 - x_1, 2) + Math.Pow(y_2 - y_1, 2));
            Console.WriteLine($"d={d}");
        }
    }
}
