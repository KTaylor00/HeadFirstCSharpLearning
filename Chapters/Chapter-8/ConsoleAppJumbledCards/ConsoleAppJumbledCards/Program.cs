using System;
using System.Collections.Generic;

namespace ConsoleAppJumbledCards
{
    internal class Program
    {
        private static readonly Random random = new Random();
        static Card RandomCard()
        {
            return new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
        }

        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }

        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            Console.Write("Enter a number of cards: ");

            if (int.TryParse(Console.ReadLine(), out int numberOfCards))
            {
                for (int i = 0; i < numberOfCards; i++)
                    cards.Add(RandomCard());
            }

            PrintCards(cards);

            Console.WriteLine("\n... sorting the cards ...\n");

            cards.Sort(new CardComparerByValue());
            PrintCards(cards);

        }

    }
}
