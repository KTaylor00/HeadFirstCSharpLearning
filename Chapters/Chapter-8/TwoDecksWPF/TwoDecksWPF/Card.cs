using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDecksWPF
{
    internal class Card
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }

        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public override string ToString() => $"{Value} of {Suit}";
    }
}
