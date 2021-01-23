using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
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
            int equal2x2Count = 0;

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ").ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            for (int col = 0; col < cols - 1; col++)
            {
                for (int row = 0; row < rows - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1,col] 
                        && matrix[row + 1, col] == matrix[row, col +1]
                        && matrix[row, col + 1] == matrix[row + 1, col + 1])
                    {
                        equal2x2Count++;
                    }
                }
            }

            Console.WriteLine(equal2x2Count);

        }
    }
}
