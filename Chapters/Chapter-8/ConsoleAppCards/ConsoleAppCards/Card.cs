using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCards
{
    internal class Card
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }
        public string Name { get { return $"\n\n{Value} of {Suit}\n"; } }

        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
    }
}
