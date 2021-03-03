using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2;
            int x2 = 3;
            int y1 = 2;
            int y2 = 6;
            int length = 0;
            length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length is: " + length);
            Console.ReadKey();
        }
    }
}
