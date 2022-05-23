using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppCardLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck()
                .Shuffle()
                .Take(16);

            IOrderedEnumerable<IGrouping<Suits, Card>> grouped = Group(deck);

            foreach (var group in grouped)
            {
                Console.WriteLine($@"Group: {group.Key} 
Count: {group.Count()} 
Min: {group.Min()} 
Max: {group.Max()}");
            }
        }

        private static IOrderedEnumerable<IGrouping<Suits, Card>> Group(IEnumerable<Card> deck)
        {
            return from card in deck
                   group card by card.Suit into suitGroup
                   orderby suitGroup.Key descending
                   select suitGroup;
        }
    }
}
