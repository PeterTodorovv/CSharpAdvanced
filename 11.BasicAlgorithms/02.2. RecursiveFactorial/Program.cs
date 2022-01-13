using System;

namespace _02.RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fact = Factoriel(n);
            Console.WriteLine(fact);
        }

        private static int Factoriel(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factoriel(n - 1);
        }
    }
}
