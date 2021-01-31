using System;
using System.Collections.Generic;

namespace Problem_1._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNames = int.Parse(Console.ReadLine());
            List<string> usernames = new List<string>(numOfNames);

            for (int i = numOfNames - 1; i >= 0; i--)
            {
                string input = Console.ReadLine();
                if (!usernames.Contains(input))
                {
                    usernames.Add(input);
                }

            }

            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
