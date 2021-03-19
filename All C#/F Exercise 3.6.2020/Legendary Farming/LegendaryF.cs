using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class LegendaryF
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyItems = new Dictionary<string, int>();// string abc = "adjiw".tolower
            
            keyItems["shards"] = 0; // add an array with the words and look what for the items from that
            keyItems["fragments"] = 0;
            keyItems["motes"] = 0;
            
            //string[] keItemNames = new string[] { "shards", "fragments", "motes" };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string input;
            bool obtained = false;
            string weaponObtained = "";
            while (!obtained)
            {
                input = Console.ReadLine();
                string[] arrInput = input.Split();
                for (int i = 0; i < arrInput.Length; i += 2)
                {
                    int qtty = int.Parse(arrInput[i]);
                    string item = arrInput[i + 1].ToLower();
                    AddQuantityOfItem(keyItems, junk, qtty, item);

                    if (keyItems["shards"] >= 250)
                    {
                        keyItems["shards"] -= 250;
                        weaponObtained = "Shadowmourne";
                        obtained = true;
                        break;
                    }
                    else if (keyItems["fragments"] >= 250)
                    {
                        keyItems["fragments"] -= 250;
                        weaponObtained = "Valanyr";
                        obtained = true;
                        break;
                    }
                    else if (keyItems["motes"] >= 250)
                    {
                        keyItems["motes"] -= 250;
                        weaponObtained = "Dragonwrath";
                        obtained = true;
                        break;
                    }
                }
            }

            Console.WriteLine($"{weaponObtained} obtained!");

            keyItems = keyItems.OrderByDescending(a => a.Value).ThenBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in keyItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            junk = junk.OrderBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static void AddQuantityOfItem(Dictionary<string, int> keyItems, Dictionary<string, int> junk, int qtty, string item)
        {
            if (item == "shards")
            {
                keyItems["shards"] += qtty;
            }
            else if (item == "fragments")
            {
                keyItems["fragments"] += qtty;
            }
            else if (item == "motes")
            {
                keyItems["motes"] += qtty;
            }
            else if (!junk.ContainsKey(item))
            {
                junk[item] = qtty;
            }
            else
            {
                junk[item] += qtty;
            }
        }
    }
}
