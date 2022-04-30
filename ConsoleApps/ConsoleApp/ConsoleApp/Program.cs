using System;
using System.Reflection;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------------------//
            //----------------------------------------------------------------------------------//
            // From Chapter 5 pg246
            HasASecret keeper = new HasASecret();

            // Uncommenting this Console.WriteLine statement causes a compiler error:
            // 'HasASecret.secret' is inaccessible due to its protection level
            //Console.WriteLine(keeper.secret);

            //But we can still use refelection to get the value of the secret field
            FieldInfo[] fields = keeper.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            // This foreach loop will cause "xyzzy" to be printed to the console
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.GetValue(keeper));
            }

            //----------------------------------------------------------------------------------//
            //----------------------------------------------------------------------------------//
            Console.WriteLine(Convert.ToString(50, 2));

            int height = 179;
            int width = 83;
            int area = Multiply(height, width);

            Console.WriteLine(area);

            //----------------------------------------------------------------------------------//
            //----------------------------------------------------------------------------------//
            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
            OperatorExamples();
            LoopExamples();

            //----------------------------------------------------------------------------------//
            //----------------------------------------------------------------------------------//
            // From a better solution for Anna(Sharpen your pencil) part of Chapter 3.
            Random random = new();
            double[] randomDoubles = new double[20];

            for (int i = 0; i < 20; i++)
            {
                double values = random.NextDouble();
                randomDoubles[i] = values;
                Console.WriteLine(values);
            }

            //----------------------------------------------------------------------------------//
            //----------------------------------------------------------------------------------//
            // From Chapter 3 (Sharpen Your Pencil Exercise) - An instance uses fields to keep track of things
            // These statements create an instance of Clown and then set its fields:
            Clown oneClown = new Clown();
            oneClown.Name = "Boffo";
            oneClown.Height = 14;
            oneClown.TalkAboutYourself();

            //These statements instantiate a second Clown object and fill it with data:
            Clown anotherClown = new Clown();
            anotherClown.Name = "Biff";
            anotherClown.Height = 16;

            // Now we instantiate a third Clown object and use data from the other two instances to set its fields:
            Clown clown3 = new Clown();
            clown3.Name = anotherClown.Name;
            clown3.Height = oneClown.Height - 3;
            clown3.TalkAboutYourself();

            // Notic how there's no "new" statement here -- we're not creating a new object, just modifying one already in memory:
            anotherClown.Height *= 2;
            anotherClown.TalkAboutYourself();

            //----------------------------------------------------------------------------------//
            //----------------------------------------------------------------------------------//
            // An example instance from Chapter 3 (Build a class to work with some guys and There's an easier way to initialize objects with C#).

            // This is their solution to the exercise:
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy bob = new Guy() { Cash = 100, Name = "Bob" };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "")
                    return;
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);
                    }
                    else if (whichGuy == "Bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }

            // This was my solution to the exercise:
            //Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            //Guy bob = new Guy() { Cash = 100, Name = "Bob" };

            //while (joe.Cash > 1 || bob.Cash > 1)
            //{
            //    int amount;
            //    joe.WriteMyInfo();
            //    bob.WriteMyInfo();
            //    Console.Write("Enter an amount: ");
            //    string input = Console.ReadLine();
            //    if (input == "")
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        amount = Int32.Parse(input);
            //    }

            //    Console.Write("Who should give the cash: ");
            //    string name = Console.ReadLine().ToLower();
            //    if (name == "joe")
            //    {
            //        joe.GiveCash(amount);
            //        if (joe.Cash == amount)
            //        {
            //            bob.ReceiveCash(amount);
            //        }
            //    }
            //    if (name == "bob")
            //    {
            //        bob.GiveCash(amount);
            //        if (bob.Cash == amount)
            //        {
            //            joe.ReceiveCash(amount);
            //        }
            //    }
            //}
            //----------------------------------------------------------------------------------//
            //----------------------------------------------------------------------------------//
        }

        private static void TryAnIf()
        {
            // Runs the last Console.WriteLine and skips the if statement as it is false.
            int someValue = 4;
            string name = "Bobbo Jr.";
            if ((someValue == 3) && (name == "Joe"))
            {
                Console.WriteLine("x is 3 and the name is Joe");
            }
            Console.WriteLine("This line runs no matter what");
        }

        private static void TrySomeLoops()
        {
            // Will print the answer is 5 to the console.
            int count = 0;
            while (count < 10)
            {
                count += 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count -= 1;
            }
            Console.WriteLine("The answer is " + count);
        }

        private static void TryAnIfElse()
        {
            // Will write the else statement to the console. As x doesn't equal 10.
            int x = 5;
            if (x == 10)
            {
                Console.WriteLine("x must be 10");
            }
            else
            {
                Console.WriteLine("x isn't 10");
            }
        }

        private static void OperatorExamples()
        {
            //This statement declares a vairable and sets it to 3
            int width = 3;

            // The ++ operator increments a vaiable (adds 1 to it)
            width++;

            // Declare two more in variables to hold numbres and 
            // use the + and * operators to add and multiply values
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            while (area < 50)
            {
                height++;
                area = width * height;
            }

            do
            {
                width--;
                area = width * height;
            } while (area < 25);

            // The next two statements declare string variables 
            // and use the + to concatenate them 
            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            // A Boolean variable is either true or false
            bool truthValue = true;
            Console.WriteLine(truthValue);
        }

        private static void LoopExamples()
        {
            // Loop Exercies
            // Loop #1 - loops infinitly
            //int count = 5;
            //while (count > 0)
            //{
            //    count *= 3;
            //    count *= -1;
            //}

            // Loop #2 - 7 times
            //int j = 2;
            //for (int i = 1; i < 100;
            // i *= 2)
            //{
            //    j--;
            //    while (j < 25)
            //    {
            // How many times will
            // the next statement
            // be executed?
            //        j += 5; - 6 times
            //    }
            //}

            // Loop #3 - 8 times
            //int p = 2;
            //for (int q = 2; q < 32;
            // q *= 2)
            //{
            //    while (p < q)
            //    {
            // How many times will
            // the next statement
            // be executed?
            //        p *= 2; - 3 times
            //    }
            //    q = p - q;
            //}

            // Loop #4 - infinite loop
            //int i = 0;
            //int count = 2;
            //while (i == 0)
            //{
            //    count = count * 3;
            //    count = count * -1;
            //}

            // Loop #5 - infinite loop
            //while (true)
            //{ int i = 1; }
        }

        static int Multiply(int factor1, int factor2)
        {
            int product = factor1 * factor2;
            return product;
        }
    }
}
