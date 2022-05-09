using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBirdInheritance
{
    internal class BrokenEgg : Egg
    {
        public BrokenEgg(string colour) : base(0, $"broken {colour}")
        {
            Console.WriteLine("A bird laid a broken egg");
        }
    }
}
