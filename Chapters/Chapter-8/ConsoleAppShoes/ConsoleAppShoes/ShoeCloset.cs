using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShoes
{
    internal class ShoeCloset
    {
        private readonly List<Shoe> shoes = new List<Shoe>();

        public void PrintShoes()
        {
            if (shoes.Count == 0)
            {
                Console.WriteLine("\nThe shoe closet is empty");
            }
            else
            {
                Console.WriteLine("\nThe shoe closet contains:");
                int i = 1;
                foreach (Shoe shoe in shoes)
                {
                    Console.WriteLine($"Shoe #{i++}: {shoe.Description}");
                }
            }
        }

        public void AddShoe()
        {
            Console.WriteLine("\nAdd a shoe:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Press {i} to add a {(Style)i}");
            }
            Console.Write("Enter a style: ");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int style))
            {
                Console.Write("\nEnter a colour: ");
                string colour = Console.ReadLine();
                Shoe shoe = new Shoe((Style)style, colour);
                shoes.Add(shoe);
            }
        }

        public void RemoveShoe()
        {
            Console.Write("\n Enter the number of the shoe to remove: ");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int shoeNumber) && (shoeNumber >= 1) && (shoeNumber <= shoes.Count))
            {
                Console.WriteLine($"\nRemoving {shoes[shoeNumber - 1].Description}");
                shoes.RemoveAt(shoeNumber - 1);
            }
        }
    }
}
