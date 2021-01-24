using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[numOfRows][];

            for (int row = 0; row < numOfRows; row++)
            {
                double[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                matrix[row] = new double[input.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = input[col];
                }
            }

            for (int row = 0; row < numOfRows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int currentRow = row; currentRow <= row + 1; currentRow++)
                    {
                        for (int col = 0; col < matrix[currentRow].Length; col++)
                        {
                            matrix[currentRow][col] /= 2;
                        }
                    }
                }
            }

            string inputCommand = Console.ReadLine();

            while (inputCommand != "End")
            {
                string[] tokens = inputCommand
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (tokens[0])
                {
                    case "Add":
                        int rowToAdd = int.Parse(tokens[1]);
                        int colToAdd = int.Parse(tokens[2]);
                        double valueToAdd = int.Parse(tokens[3]);

                        if (rowToAdd >= 0 && colToAdd >= 0)
                        {
                            if (rowToAdd < matrix.GetLength(0) && colToAdd < matrix[rowToAdd].Length)
                            {
                                matrix[rowToAdd][colToAdd] += valueToAdd;
                            }
                        }
                        break;

                    case "Subtract":
                        int rowToSubtract = int.Parse(tokens[1]);
                        int colToSubtract = int.Parse(tokens[2]);
                        double valueToSubtract = int.Parse(tokens[3]);

                        if (rowToSubtract >= 0 && colToSubtract >= 0)
                        {
                            if (rowToSubtract < matrix.GetLength(0) && colToSubtract < matrix[rowToSubtract].Length)
                            {
                                matrix[rowToSubtract][colToSubtract] -= valueToSubtract;
                            }
                        }
                            break;

                    default:
                        break;
                }

                inputCommand = Console.ReadLine();
            }

            for (int row = 0; row < numOfRows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
