using System;

namespace ConsoleAppElephantExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true)
            {
                char keyChar = Console.ReadKey(true).KeyChar;
                Console.WriteLine($"You pressed {keyChar}");
                if (keyChar == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (keyChar == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (keyChar == '3')
                {
                    Elephant holder;
                    Console.WriteLine("References have been swapped");
                    Console.WriteLine();
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                }
                else
                {
                    return;
                }
            }

        }
    }
}
