using System;

namespace ConsoleAppHiLo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Every instance of Random initialized with the same seed will generate the dame squence of pseudo-random numbers.
            HiLoGame.Random = new Random(1);
            Random seededRandom = new Random(1);
            Console.Write("The first 11 numbers will be: ");
            for (int i = 0; i < 10; i++)
                Console.Write($"{seededRandom.Next(1, HiLoGame.MAXIMUM + 1)}");


            Console.WriteLine("Welcome to HiLo.");
            Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");

            while (HiLoGame.GetPot() > 0)
            {
                Console.WriteLine("Press H for higher, L for lower, ? to buy a hint,");
                Console.WriteLine($"or any other key to quit with.\n");
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'h')
                    HiLoGame.Guess(true);
                else if (key == 'l')
                    HiLoGame.Guess(false);
                else if (key == '?')
                    HiLoGame.Hint();
                else
                    return;
            }
            Console.WriteLine("The pot is empty. Bye!");
        }
    }
}
