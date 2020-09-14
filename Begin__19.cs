using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double x_1,x_2,y_1,y_2,a,b,P,S;
            Console.Write("x__1=");
            x_1 = double.Parse(Console.ReadLine());
            Console.Write("y__1=");
            y_1 = double.Parse(Console.ReadLine());
            Console.Write("x__2=");
            x_2 = double.Parse(Console.ReadLine());
            Console.Write("y__2=");
            y_2 = double.Parse(Console.ReadLine());
            a = Math.Abs(x_2 - x_1);
            b = Math.Abs(y_2 - y_1);
            P = 2 * (a + b);
            S = a * b;
            Console.WriteLine($"P={P}, S={S}");
        }
    }
}
