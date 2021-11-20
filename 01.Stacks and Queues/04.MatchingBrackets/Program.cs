using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for(int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if(character == '(')
                {
                    indexes.Push(i);
                }

                if(character == ')')
                {
                    int startIndex = indexes.Pop();
                    for(int j = startIndex; j <= i; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
