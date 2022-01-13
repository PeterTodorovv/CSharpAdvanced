using System;
namespace SumOfCoins
{
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).OrderByDescending(x => x).ToArray();
            int targetSum = int.Parse(Console.ReadLine());
            Dictionary<int, int> money = ChooseCoins(coins, targetSum);

            Console.WriteLine($"Number of coins to take: {money.Values.Sum()}");
            foreach (var coin in money)
            {
                Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            Dictionary<int, int> money = new Dictionary<int, int>();
            int coinIndex = 0;

            while(targetSum != 0)
            {
                if(targetSum / coins[coinIndex] > 0)
                {
                    targetSum -= coins[coinIndex];

                    if (!money.ContainsKey(coins[coinIndex]))
                    {
                        money.Add(coins[coinIndex], 0);
                    }

                    money[coins[coinIndex]]++;
                }
                else
                {
                    if (targetSum == 0)
                        break;
                    coinIndex++;

                    if (coinIndex == coins.Count)
                    {
                        throw new InvalidCastException();
                    }

                }
            }

            return money;
        }
    }
}