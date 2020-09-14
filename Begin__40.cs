using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double A_1,B_1,C_1,A_2,B_2,C_2,D,x,y;
            Console.Write("A_1=");
            A_1 = double.Parse(Console.ReadLine());
            Console.Write("B_1=");
            B_1 = double.Parse(Console.ReadLine());
            Console.Write("C_1=");
            C_1 = double.Parse(Console.ReadLine());
            Console.Write("A_2=");
            A_2 = double.Parse(Console.ReadLine());
            Console.Write("B_2=");
            B_2 = double.Parse(Console.ReadLine());
            Console.Write("C_2=");
            C_2 = double.Parse(Console.ReadLine());
            D = A_1 * B_2 - A_2 * B_1;
            x = (C_1 * B_2 - C_2 * B_1) / D;
            y = (A_1 * C_2 - A_2 * C_1) / D;
            Console.WriteLine($"x={x}\ty={y}");
        }
    }
}
