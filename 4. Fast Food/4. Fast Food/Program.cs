using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());

            Queue<int> foodQueue = new Queue<int>();

            int[] foodOrders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var order in foodOrders)
            {
                foodQueue.Enqueue(order);
            }

            Console.WriteLine(foodQueue.Max());

            while (foodQueue.Count > 0)
            {
                if (totalFood >= foodQueue.Peek())
                {
                    totalFood -= foodQueue.Dequeue();
                }
                else break;
            }

            if (foodQueue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", foodQueue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
