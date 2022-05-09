using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBirdInheritance
{
    abstract class Bird
    {
        public static Random Random = new Random();

        public abstract Egg[] LayEggs(int numberOfEggs);
    }
}
