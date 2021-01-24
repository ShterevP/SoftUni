using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNandM = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = inputNandM[0];
            int cols = inputNandM[1];

            string[,] isleMatrix = new string[rows, cols];

            string snake = Console.ReadLine();

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {

                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {

                    }
                }

            }
        }
    }
}
