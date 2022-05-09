using System;

namespace ConsoleAppElephantExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant[] elephants = new Elephant[7];
            elephants[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant() { Name = "Lucinda", EarSize = 33 };
            elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant() { Name = "Lucille", EarSize = 32 };
            elephants[4] = new Elephant() { Name = "Lars", EarSize = 44 };
            elephants[5] = new Elephant() { Name = "Linda", EarSize = 37 };
            elephants[6] = new Elephant() { Name = "Humphrey", EarSize = 45 };
            Elephant biggestEars = elephants[0];
            for (int i = 1; i < elephants.Length; i++)
            {
                Console.WriteLine("Iteration #" + i);
                if (elephants[i].EarSize > biggestEars.EarSize)
                {
                    biggestEars = elephants[i];
                }
                Console.WriteLine(biggestEars.EarSize.ToString());
            }

            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, 4 remove the first object, 5 to speak to");
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
                else if (keyChar == '4')
                {
                    lloyd = lucinda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else if (keyChar == '5')
                {
                    lloyd.SpeakTo(lucinda, "Hi Lucinda!");
                }
                else
                {
                    return;
                }
            }

        }
    }
}
