using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShoes
{
    internal class Shoe
    {
        public Style Style { get; private set; }
        public string Colour { get; private set; }

        public Shoe(Style style, string colour)
        {
            Style = style;
            Colour = colour;
        }

        public string Description { get { return $"A {Colour} {Style}"; } }
    }
}
