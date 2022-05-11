using System;

namespace ConsoleAppClowns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClown.CarCapacity = 18;
            Console.WriteLine(IClown.ClownCarDescription());

            IClown fingersTheClown = new ScaryScary(14, "big red nose");
            fingersTheClown.Honk();

            // How I did it via the IDE prompt
            /*IScaryClown iScaryClownReference = (IScaryClown)fingersTheClown;
            iScaryClownReference.ScareLittleChildren();*/

            // How the book said it should be done
            if (fingersTheClown is IScaryClown iScaryClownReference)
            {
                iScaryClownReference.ScareAdults();
            }
        }
    }
}
