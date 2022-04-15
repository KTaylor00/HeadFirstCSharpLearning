﻿using System;

namespace ConsoleAppBettingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double odds = .75;
            Random random = new Random();
            double odds = 0.75;

            Better billy = new Better { Name = "Billy", Cash = 100 };
            Better bob = new Better { Name = "Bob", Cash = 100 };

            Console.WriteLine($"Welcome to the casino. The odds are {odds}");
            while (billy.Cash > 0 && bob.Cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    if (better == "Billy")
                    {
                        int pot = billy.GiveCash(amount) * 2;

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
                    if (better == "Bob")
                    {
                        int pot = bob.GiveCash(amount) * 2;

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
