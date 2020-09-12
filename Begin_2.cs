using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, S;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            S = Math.Pow(a, 2);//or S = a * a;
            Console.Write("S=a*a\na={0}    S={1}", a, S);
        }
    }
}
