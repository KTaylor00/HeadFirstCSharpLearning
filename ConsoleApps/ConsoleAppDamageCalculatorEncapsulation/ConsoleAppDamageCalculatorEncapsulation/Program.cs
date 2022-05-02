using System;

namespace ConsoleAppDamageCalculatorEncapsulation
{
    internal class Program
    {
        static Random Random = new Random();

        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice());


            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char key = Console.ReadKey(true).KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3')
                {
                    return;
                }
                Console.WriteLine();

                swordDamage.Roll = RollDice();
                swordDamage.Magic = (key == '1' || key == '2');
                swordDamage.Flaming = (key == '2' || key == '3');

                Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP\n");
            }
        }

        private static int RollDice()
        {
            return Random.Next(1, 7) + Random.Next(1, 7) + Random.Next(1, 7);

        }
    }
}
