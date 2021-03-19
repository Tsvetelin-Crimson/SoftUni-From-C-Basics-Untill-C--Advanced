using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var tokens = Console.ReadLine().Split(": ");
        IList<int> actualCoins = tokens[1].Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        var tokens1 = Console.ReadLine().Split(": ");
        var targetSum = int.Parse(tokens1[1]);

        var selectedCoins = ChooseCoins(actualCoins, targetSum);
        if (selectedCoins != null)
        {
            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
            foreach (var selectedCoin in selectedCoins)
            {
                Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        var sortedCoins = coins.OrderByDescending(x => x).ToList();
        Dictionary<int, int> res = new Dictionary<int, int>();

        for (int i = 0; i < sortedCoins.Count; i++)
        {
            if (targetSum / sortedCoins[i] != 0)
            {
                res[sortedCoins[i]] = targetSum / sortedCoins[i];
                targetSum = targetSum % sortedCoins[i];
            }
        }
        if (targetSum == 0)
        {
            return res;
        }

        return null;

    }
}