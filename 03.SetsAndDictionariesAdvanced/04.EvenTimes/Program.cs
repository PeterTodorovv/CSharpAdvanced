using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!dic.ContainsKey(number))
                {
                    dic.Add(number, 0);
                }

                dic[number]++;
            }

            foreach(var number in dic)
            {
                if(number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                    break;
                }
            }
        }
    }
}
