using System;

namespace AbilityScoreTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (0.1 + 0.2 == 0.30000000000000004)
                Console.WriteLine("They're equal");
            else
                Console.WriteLine("They aren't equal");


            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q'))
                    return;
            }
        }

        /// <summary>
        /// Writes a prompt and read a double value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value</param>
        /// <param name="prompt">Prompt to print to the console.</param>
        /// <returns>The double value read, or the default value if unable to parse</returns>
        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write($"{prompt} [{lastUsedValue}]: ");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double value))
            {
                Console.WriteLine($"  using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine($"  using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }

        /// <summary>
        /// Writes a prompt and read an int value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value</param>
        /// <param name="prompt">Prompt to print to the console.</param>
        /// <returns>The int value read, or the default value if unable to parse</returns>
        private static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write($"{prompt} [{lastUsedValue}]: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine($"  using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine($"  using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}
