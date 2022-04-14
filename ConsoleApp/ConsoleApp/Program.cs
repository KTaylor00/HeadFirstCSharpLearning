﻿using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 179;
            int width = 83;
            int area = Multiply(height, width);

            Console.WriteLine(area);

            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
            OperatorExamples();
            LoopExamples();

            // From instances uses fields to keep track of things(Sharpen your pencil) part of Chapter 3.
            Random random = new();
            double[] randomDoubles = new double[20];

            for (int i = 0; i < 20; i++)
            {
                double values = random.NextDouble();
                randomDoubles[i] = values;
                Console.WriteLine(values);
            }
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
