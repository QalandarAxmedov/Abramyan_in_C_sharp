using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int H;
            Console.Write("H=");
            H = int.Parse(Console.ReadLine());
            H /= 1024;
            Console.Write($"H={H} kilobayt");
        }
    }
}
