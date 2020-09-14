using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double V,U,T_1,T_2,S;
            Console.Write("V=");
            V = double.Parse(Console.ReadLine());
            Console.Write("T_1=");
            T_1 = double.Parse(Console.ReadLine());
            Console.Write("U=");
            U = double.Parse(Console.ReadLine());
            Console.Write("T_2=");
            T_2 = double.Parse(Console.ReadLine());
            S = V * T_1 + (V - U) * T_2;
            Console.WriteLine($"S={S}");
        }
    }
}
