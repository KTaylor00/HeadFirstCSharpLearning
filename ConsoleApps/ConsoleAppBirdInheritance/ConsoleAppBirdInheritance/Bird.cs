using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBirdInheritance
{
    internal class Bird
    {
        public static Random Random = new Random();

        public virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Bird.LayEggs should never get called.");
            return new Egg[0];
        }
    }
}
