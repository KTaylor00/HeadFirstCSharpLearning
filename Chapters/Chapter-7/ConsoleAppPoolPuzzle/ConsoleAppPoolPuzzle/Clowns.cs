using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPoolPuzzle
{
    internal class Clowns : Picasso
    {
        public Clowns() : base("Clowns") { }

        public override int Ear()
        {
            return 7;
        }
    }
}
