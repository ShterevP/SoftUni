using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numQueue = new Queue<int>();

            int[] input1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = input1[0];
            int s = input1[1];
            int x = input1[2];

            int[] input2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < n; i++)
            {
                numQueue.Enqueue(input2[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numQueue.Dequeue();
            }

            if (numQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (numQueue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numQueue.Min());
            }


        }
    }
}
