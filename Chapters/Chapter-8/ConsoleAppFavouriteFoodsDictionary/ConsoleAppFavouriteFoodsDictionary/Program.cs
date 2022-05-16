using System;
using System.Collections.Generic;

namespace ConsoleAppFavouriteFoodsDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> favouriteFoods = new Dictionary<string, string>();
            favouriteFoods["Alex"] = "hot dogs";
            favouriteFoods["A'ja"] = "pizza";
            favouriteFoods["Jules"] = "falafel";
            favouriteFoods["Naima"] = "spaghetti";

            string name;
            while ((name = Console.ReadLine()) != "")
            {
                if (favouriteFoods.ContainsKey(name))
                    Console.WriteLine($"{name}'s favourite food is {favouriteFoods[name]}");
                else
                    Console.WriteLine($"I don't know {name}'s favourite food");
            }
        }
    }
}
