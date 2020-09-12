using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,S,V;
            Console.WriteLine("V=a*b*c");
            Console.WriteLine("S=2*(a*b+b*c+a*c)");
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            c = double.Parse(Console.ReadLine());
            S = 2 * (a * b + b * c + a * c);
            V = a * b * c;
            Console.Write("S={0}\nV={1}",S,V);
        }
    }
}
