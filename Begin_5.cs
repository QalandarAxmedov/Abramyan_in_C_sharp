using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,S,V;
            Console.WriteLine("V=a*a*a");
            Console.WriteLine("S=6*a");
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            S = 6 * a;
            V = Math.Pow(a, 3);//or V=a*a*a;
            Console.Write("S={0}\nV={1}",S,V);
        }
    }
}
