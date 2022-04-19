using System;

namespace ConsoleAppRandomTestDrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a new instance of the Random class
            Random random = new Random();

            // Returns a non-negative random integer.
            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            // Specifies a maximum value to get a random number from 0 - 9 in this case.
            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);

            // Simulates the roll of a die
            int dieRoll = random.Next(1, 7);
            Console.WriteLine(dieRoll);

            // Chooses a random double between 1 - 100, also a random float and decimal.
            double randomDouble = random.NextDouble();
            Console.WriteLine(randomDouble * 100);
            Console.WriteLine((float)randomDouble * 100);
            Console.WriteLine((decimal)randomDouble * 100);

            // Simulates a coin toss, resulting in true or false
            int zeroToOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroToOne);
            Console.WriteLine(coinFlip);

            // Gets a random greeting from the greetings array.
            string[] greetings = { "Hello", "Hi", "Welcome", "Bonjour", "Ola" };
            int randomGreetings = random.Next(greetings.Length);
            Console.WriteLine(greetings[randomGreetings]);
        }
    }
}
