using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = rowsCols[0];
            int cols = rowsCols[1];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {

                }
            }
        }
    }
}
