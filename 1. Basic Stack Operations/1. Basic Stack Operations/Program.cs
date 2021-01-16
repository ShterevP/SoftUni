using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numStack = new Stack<int>();

            string[] input1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(input1[0]);
            int s = int.Parse(input1[1]);
            int x = int.Parse(input1[2]);

            string[] input2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                numStack.Push(int.Parse(input2[i]));
            }

            for (int i = 0; i < s; i++)
            {
                numStack.Pop();
            }

            if (numStack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if(numStack.Count > 0)
            {
                int smallestNum = numStack.Min();

                Console.WriteLine(smallestNum);
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
