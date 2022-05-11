using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClowns
{
    internal class ScaryScary : FunnyFunny, IScaryClown
    {
        private readonly int scaryThingCount;

        public string ScaryThingIHave { get { return $"{scaryThingCount} spiders"; } }

        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}");
        }

        public ScaryScary(int scaryThingCount, string funnyThing) : base(funnyThing)
        {

            this.scaryThingCount = scaryThingCount;
        }
    }
}
