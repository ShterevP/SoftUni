using System;
using System.Collections.Generic;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] setsNM = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(setsNM[0]);
            int m = int.Parse(setsNM[1]);

            HashSet<int> numbers1 = new HashSet<int>(n);
            HashSet<int> numbers2 = new HashSet<int>(m);

            for (int i = n - 1; i >= 0; i--)
            {
                numbers1.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = m - 1; i >= 0; i--)
            {
                numbers2.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var number in numbers1)
            {
                if (numbers2.Contains(number))
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
