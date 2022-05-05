using System;

namespace ConsoleAppSafeInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SafeOwner owner = new SafeOwner();
            Safe safe = new Safe();
            JewelThief thief = new JewelThief();
            thief.OpenSafe(safe, owner);
            Console.ReadKey(true);
        }
    }
}
