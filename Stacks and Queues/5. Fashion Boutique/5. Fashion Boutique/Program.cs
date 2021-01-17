using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesValues = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> clothesStack = new Stack<int>();

            foreach (var clothValue in clothesValues)
            {
                clothesStack.Push(clothValue);
            }

            int rackCapacity = int.Parse(Console.ReadLine());
            int racksCount = 0;
            int currentRackCapacity = rackCapacity;

            while (clothesStack.Count > 0)
            {
                if (clothesStack.Peek() > currentRackCapacity)
                {
                    racksCount++;
                    currentRackCapacity = rackCapacity - clothesStack.Pop();
                }
                else
                {
                    currentRackCapacity -= clothesStack.Pop();
                    if (racksCount == 0)
                    {
                        racksCount++;
                    }
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
