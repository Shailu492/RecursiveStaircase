using System;

namespace RecursiveStaircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = RecursiveStaircaseSolution.Solve(4, new int[] {1, 2});
            Console.WriteLine(sum);
            Console.ReadLine();
        }

    }
}
