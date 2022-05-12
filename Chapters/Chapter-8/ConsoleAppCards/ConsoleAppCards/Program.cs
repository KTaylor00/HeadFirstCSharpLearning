using System;

namespace ConsoleAppCards
{
    internal class Program
    {
        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            /*int suit = random.Next(4);
            int value = random.Next(1, 14);
            int randomInt = random.Next();

            Values values = (Values)value;
            Suits suits = (Suits)suit;

            Card card = new Card(values, suits);
            Console.WriteLine(card.Name);*/

            // All the above code can be simplified to this:
            /*Card card = new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
            Console.WriteLine(card);*/

            Deck deck = new Deck();
            deck.PrintCards();
        }
    }
}
