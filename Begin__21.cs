using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double x_1,x_2,x_3,y_1,y_2,y_3,a,b,c,P,S;
            Console.Write("x__1=");
            x_1 = double.Parse(Console.ReadLine());
            Console.Write("y__1=");
            y_1 = double.Parse(Console.ReadLine());
            Console.Write("x__2=");
            x_2 = double.Parse(Console.ReadLine());
            Console.Write("y__2=");
            y_2 = double.Parse(Console.ReadLine());
            Console.Write("x__3=");
            x_3 = double.Parse(Console.ReadLine());
            Console.Write("y__3=");
            y_3 = double.Parse(Console.ReadLine());
            a = Math.Sqrt(Math.Pow(x_2 - x_1, 2) + Math.Pow(y_2 - y_1, 2));
            b = Math.Sqrt(Math.Pow(x_2 - x_3, 2) + Math.Pow(y_2 - y_3, 2));
            c = Math.Sqrt(Math.Pow(x_3 - x_1, 2) + Math.Pow(y_3 - y_1, 2));
            P = (a + b + c) / 2;
            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            Console.WriteLine($"S={S}, P={P}");
        }
    }
}
