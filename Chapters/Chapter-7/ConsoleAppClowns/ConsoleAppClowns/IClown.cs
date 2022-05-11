using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClowns
{
    internal interface IClown
    {
        string FunnyThingIHave { get; }

        protected static Random random = new Random();

        private static int carCapacity = 12;
        static int CarCapacity
        {
            get { return carCapacity; }
            set
            {
                if (value > 10)
                    carCapacity = value;
                else
                    Console.Error.WriteLine($"Warning: Car capacity {value} is too small");

            }
        }

        public static string ClownCarDescription()
        {
            return $"A clown car with {random.Next(CarCapacity / 2, CarCapacity)} clowns";
        }

        void Honk();
    }
}
