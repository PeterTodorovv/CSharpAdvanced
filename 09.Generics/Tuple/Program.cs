using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string fullName = firstLine[0] + " " + firstLine[1];
            string address = firstLine[2];
            string town = string.Join(" ", firstLine.Skip(3));
            Tuple<string, string, string> tuple1 = new Tuple<string, string, string>(fullName, address, town);

            string[] secondLine = Console.ReadLine().Split();
            string firstName = secondLine[0];
            int litersOfBeer = int.Parse(secondLine[1]);
            bool drunkOrNot = secondLine[2] == "drunk";
            Tuple<string, int, bool> tuple2 = new Tuple<string, int, bool>(firstName, litersOfBeer, drunkOrNot);

            string[] thirdLine = Console.ReadLine().Split();
            string name = thirdLine[0];
            double accountBalance = double.Parse(thirdLine[1]);
            string bankName = thirdLine[2];
            Tuple<string, double, string> tuple3 = new Tuple<string, double, string>(name, accountBalance, bankName);

            Console.WriteLine($"{tuple1.item1} -> {tuple1.item2} -> {tuple1.item3}");
            Console.WriteLine($"{tuple2.item1} -> {tuple2.item2} -> {tuple2.item3}");
            Console.WriteLine($"{tuple3.item1} -> {tuple3.item2} -> {tuple3.item3}");
        }
    }
}
