using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double X,A,Y,B;
            Console.Write("X=");
            X = double.Parse(Console.ReadLine());
            Console.Write("A=");
            A = double.Parse(Console.ReadLine());
            Console.Write("Y=");
            Y = double.Parse(Console.ReadLine());
            Console.Write("B=");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine($"1kg konfet={A/X}");
            Console.WriteLine($"1kg iris={B/Y}");
            Console.WriteLine($"konfet/iris={(A * Y) / (X * B)}");
        }
    }
}
