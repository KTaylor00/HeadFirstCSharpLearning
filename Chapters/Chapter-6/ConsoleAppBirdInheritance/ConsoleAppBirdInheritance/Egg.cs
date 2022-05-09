using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBirdInheritance
{
    internal class Egg
    {
        public double Size { get; private set; }
        public string Colour { get; private set; }

        public Egg(double size, string colour)
        {
            Size = size;
            Colour = colour;
        }

        public string Description
        {
            get { return $"A {Size:0.0}cm {Colour} egg"; }
        }
    }
}
