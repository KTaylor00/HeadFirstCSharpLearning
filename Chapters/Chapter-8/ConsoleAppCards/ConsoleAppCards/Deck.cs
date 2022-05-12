using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCards
{
    internal class Deck
    {
        private readonly Random random = new Random();
        private readonly Card[] cards = new Card[52];

        public Deck()
        {
            int index = 0;
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards[index++] = new Card((Values)value, (Suits)suit);
                }
            }
        }

        public void Shuffle()
        {
            int shuffle = random.Next();
            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine();
            }
        }

        public void PrintCards()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine(cards[i].Name);
            }
        }
    }
}
