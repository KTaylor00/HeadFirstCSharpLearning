using System;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                // this block is executed if line COULD be converted to an int
                // value that's stored in a new variable called numberOfCards.

                // I would have to do this if I did not use the static keyword(in the PickSomeCards method):
                // CardPicker results = new CardPicker();
                // then I would have to access the method by using the results variable - results.PickSomeCards(numberOfCards).

                // Using the static keyword allows me to just call the method like this - CardPicker.PickSomeCards(numberOfCards);
                string[] results = CardPicker.PickSomeCards(numberOfCards);

                foreach (string card in results)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                // this block is executed if line COULD NOT be converted to an int
                Console.WriteLine("Please enter a vaild number.");
            }
        }
    }


}
