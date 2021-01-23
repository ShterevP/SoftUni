using System;
using System.Linq;
using System.Text;

namespace _4._Matrix_Shuffling
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
            int rowFromCoordinate = 0;
            int colFromCoordinate = 0;
            int rowToCoordinate = 0;
            int colToCoordinate = 0;

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowdata = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowdata[col];
                }
            }
            string input = Console.ReadLine();
            
            while (input != "END")
            {
                string[] tokens = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (tokens.Length == 5
                    && tokens[0] == "swap"
                    && int.TryParse(tokens[1], out rowFromCoordinate)
                    && int.TryParse(tokens[2], out colFromCoordinate)
                    && int.TryParse(tokens[3], out rowToCoordinate)
                    && int.TryParse(tokens[4], out colToCoordinate))

                {
                    if (rowFromCoordinate <= matrix.GetLength(0) - 1
                        && rowToCoordinate <= matrix.GetLength(0) -1
                        && colFromCoordinate <= matrix.GetLength(1) - 1
                        && colToCoordinate <= matrix.GetLength(1) - 1)
                    {
                        string temp = matrix[rowToCoordinate, colToCoordinate];
                        matrix[rowToCoordinate, colToCoordinate] = matrix[rowFromCoordinate,colFromCoordinate];
                        matrix[rowFromCoordinate, colFromCoordinate] = temp;
                        matrixPrint(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
            


        }

        private static void matrixPrint(string[,] matrixInput)
        {
            for (int row = 0; row < matrixInput.GetLength(0); row++)
            {
                for (int col = 0; col < matrixInput.GetLength(1); col++)
                {
                    Console.Write($"{matrixInput[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
