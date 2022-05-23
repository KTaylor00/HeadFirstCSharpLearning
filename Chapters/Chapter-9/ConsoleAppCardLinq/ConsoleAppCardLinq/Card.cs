using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCardLinq
{
    internal class Card : IComparable<Card>
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }

        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public override string ToString() => $"{Value} of {Suit}";

        public int CompareTo(Card other)
        {
            return new CardComparerByValue().Compare(this, other);
        }
    }
}
