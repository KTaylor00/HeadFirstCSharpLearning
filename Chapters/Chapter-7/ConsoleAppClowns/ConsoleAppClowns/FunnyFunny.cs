using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClowns
{
    internal class FunnyFunny : IClown
    {
        private string funnyThingIHave;
        public string FunnyThingIHave { get { return funnyThingIHave; } }

        public void Honk()
        {
            Console.WriteLine($"Hi kids! I have a {funnyThingIHave}.");
        }

        public FunnyFunny(string funnyThing)
        {
            funnyThingIHave = funnyThing;
        }
    }
}
