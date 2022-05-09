using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHiLo
{
    static class HiLoGame
    {
        // All constants are static.
        public const int MAXIMUM = 10;
        public static Random Random = new Random();
        private static int currentNumber = Random.Next(1, MAXIMUM + 1);
        private static int pot = 10;

        // The main method can use the GetPot method to het its value without having a way to modify it.
        public static int GetPot() => pot;

        public static void Guess(bool higher)
        {
            int nextRandom = Random.Next(1, MAXIMUM + 1);

            if (higher && nextRandom >= currentNumber || !higher && nextRandom <= currentNumber)
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong...");
                pot--;
            }

            currentNumber = nextRandom;
            Console.WriteLine($"The current number is {currentNumber}\n");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
                Console.WriteLine($"The number is at least {half}");
            else
                Console.WriteLine($"The number is at most {half}");

            pot--;
        }
    }
}
