using System;
using System.Collections.Generic;

namespace ConsoleAppJumbledCards
{
    internal class Program
    {
        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            Console.Write("Enter a number of cards: ");
            string number = Console.ReadLine();

            if (int.TryParse(number, out int numberOfCards))
            {
                //RandomCard(numberOfCards);
                //PrintCards(numberOfCards);
            }
        }

        static void RandomCard(string card)
        {

        }

        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
