using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double V_1,V_2,S,T;
            Console.Write("V_1=");
            V_1 = double.Parse(Console.ReadLine());
            Console.Write("V_2=");
            V_2 = double.Parse(Console.ReadLine());
            Console.Write("S=");
            S = double.Parse(Console.ReadLine());
            Console.Write("T=");
            T = double.Parse(Console.ReadLine());
            S = Math.Abs(S - (V_1 + V_2) * T); 
            Console.WriteLine($"S={S}");
        }
    }
}
