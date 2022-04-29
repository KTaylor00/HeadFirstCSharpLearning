using System;

namespace ConsoleAppDamageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            Random random = new Random();



            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char keyChar = Console.ReadKey().KeyChar;
                if (keyChar != '0' && keyChar != '1' && keyChar != '2' && keyChar != '3')
                {
                    return;
                }
                Console.WriteLine();

                int roll1 = random.Next(1, 7);
                int roll2 = random.Next(1, 7);
                int roll3 = random.Next(1, 7);

                int roll = roll1 + roll2 + roll3;
                swordDamage.Roll = roll;
                swordDamage.SetMagic(keyChar == '1' || keyChar == '3');
                swordDamage.SetFlaming(keyChar == '2' || keyChar == '3');

                Console.WriteLine($"\nRolled {roll} for {swordDamage.Damage} HP\n");

            }
        }
    }
}

