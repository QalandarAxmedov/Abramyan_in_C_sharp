using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b, S,P;
            Console.WriteLine("S=a*b");
            Console.WriteLine("P=2*(a+b)");
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            S = a*b;
            P = 2 * (a + b);
            Console.Write("S={0}\nP={1}",S,P);
        }
    }
}
