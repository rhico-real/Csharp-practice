using System;

namespace _Hackerrank__Solve_Me_First
{
    class Program
    {
        static int solveMeFirst(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
    }
}
