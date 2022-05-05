using System;

namespace ConsoleAppBirdInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Bird bird;
                Console.Write("\nPress P for pigeon, O for ostrich: ");
                char key = Char.ToUpper(Console.ReadKey().KeyChar);
                if (key == 'P')
                    bird = new Pigeon();
                else if (key == 'O')
                    bird = new Ostrich();
                else
                    return;

                Console.Write("\nHow many eggs should it lay? ");
                if (int.TryParse(Console.ReadLine(), out int numberOfEggs))
                {
                    if (key == 'P' && numberOfEggs > 2)
                    {
                        Console.WriteLine("Pigeons only lay 1-2 eggs");
                    }
                    else
                    {
                        Egg[] eggs = bird.LayEggs(numberOfEggs);
                        foreach (Egg egg in eggs)
                        {
                            Console.WriteLine(egg.Description);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("\nPlease enter an amount in numbers");
                }

            }
        }
    }
}
