using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<char> parentheses = new Queue<char>(input);

            bool squareBracketOpen = false;
            bool curlyBracketOpen = false;
            bool roundBracketOpen = false;
            bool spaceOpen = false;

            foreach (var item in parentheses)
            {
                switch (item)
                {
                    case '{':
                        curlyBracketOpen = true;
                        break;

                    case '}':
                        if (curlyBracketOpen)
                        {
                            curlyBracketOpen = false;
                        }
                        break;

                    case '(':
                        roundBracketOpen = true;
                        break;

                    case ')':
                        if (roundBracketOpen)
                        {
                            roundBracketOpen = false;
                        }
                        break;

                    case '[':
                        squareBracketOpen = true;
                        break;

                    case ']':
                        if (squareBracketOpen)
                        {
                            squareBracketOpen = false;
                        }
                        break;

                    case ' ':
                        if (spaceOpen)
                        {
                            spaceOpen = false;
                        }
                        else
                        {
                            spaceOpen = true;
                        }
                        break;
                    default:
                        break;
                }
            }
            bool isBalanced = !(squareBracketOpen
                || roundBracketOpen 
                || curlyBracketOpen
                || spaceOpen);

            Console.WriteLine(isBalanced?"YES":"NO");
        }
    }
}
