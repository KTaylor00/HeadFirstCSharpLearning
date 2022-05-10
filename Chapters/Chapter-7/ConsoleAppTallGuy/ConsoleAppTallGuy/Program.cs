using System;

namespace ConsoleAppTallGuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallguy = new TallGuy() { Height = 76, Name = "Jimmy" };
            tallguy.TalkAboutYourself();
            Console.WriteLine($"The tall guy has {tallguy.FunnyThingIHave}");
            tallguy.Honk();
        }
    }
}
