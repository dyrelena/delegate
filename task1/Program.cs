using System;

namespace task1
{
    class Program
    {
        delegate double Average(int a, int b, int c);
        public static void Main()
        {
            Average average1 = delegate (int a, int b, int c)
            {
                double ave = (a + b + c) / 3.0;
                return ave;
            };

            int x1 = 2;
            int x2 = 5;
            int x3 = 6;
            Console.WriteLine($"Average of {x1}, {x2}, {x3} is {average1(x1, x2, x3)}");
            Console.ReadLine();
        }

    }
}