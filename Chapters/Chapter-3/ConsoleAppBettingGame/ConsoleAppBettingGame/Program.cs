using System;

namespace ConsoleAppBettingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double odds = .20;
            Random random = new Random();

            Better billy = new Better { Name = "Billy", Cash = 100 };
            Better bob = new Better { Name = "Bob", Cash = 100 };

            Console.WriteLine($"Welcome to the casino. The odds are {odds}");
            while (billy.Cash > 0 && bob.Cash > 0)
            {
                billy.WriteMyInfo();
                bob.WriteMyInfo();
                Console.Write("Who is betting: ");
                string better = Console.ReadLine().ToLower();
                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amountGiven))
                {
                    if (better == "billy")
                    {
                        int pot = billy.GiveCash(amountGiven) * 2;

                        if (pot > 0)
                        {
                            if (random.NextDouble() > odds)
                            {
                                int winnings = pot;
                                Console.WriteLine($"You win {winnings}");
                                billy.ReceiveCash(winnings);
                            }
                            else
                            {
                                Console.WriteLine("Bad luck, you lose.");
                            }
                        }

                    }

                    if (better == "bob")
                    {
                        int pot = bob.GiveCash(amountGiven) * 2;

                        if (pot > 0)
                        {
                            if (random.NextDouble() > odds)
                            {
                                int winnings = pot;
                                Console.WriteLine($"You win {winnings}");
                                bob.ReceiveCash(winnings);
                            }
                            else
                            {
                                Console.WriteLine("Bad luck, you lose.");
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            Console.WriteLine("The house always wins!");
        }
    }
}
