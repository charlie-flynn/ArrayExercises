using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ArrayExercises
{
    /*
     * Array Exercises
     * - Write a function that lets the user enter 5 values into an array
     * - Write a function that prints the array
     * - Write a function that prints the sum of the elements in an integer array
     * - Write a function that prints the highest integer in an array
     * - Write a function that prints the lowest integer in an array
     * - Write a function that prints the array in reverse order
     * - CHARLIE'S COOL BONUS CHALLENGE: Write a function that prints the average of all integers in an array
     * - - dont do that actually that sounds hard
     * - DREW'S COOL BONUS CHALLENGE: Write a function that prints the array in ascending order (lowest to highest)
     * - - i did it >:3c
     */
    internal class Game
    {
        int[] ints;
        public void Run()
        {
            ints = GetLength(ints);

            GetValues();
            PrintArray(ints);
            PrintReverse(ints);
            PrintSum(ints);
            PrintHighest(ints);
            PrintLowest(ints);
            PrintLowestToHighest(ints);
        }

        int[] GetLength(Array array)
        {
            int length = 0;
            string input = "";
            while (true)
            {
                // prompt the player to input the length of the array
                Console.WriteLine("Input Array Length (Max of 50)");
                input = Console.ReadLine();
                Console.WriteLine();

                // if the player inputted a number higher than 0 and lower than or equal to 50, make the length of the array equal to their input
                if (Int32.TryParse(input, out int num))
                {
                    if (num > 0 && num <= 50)
                    {
                        length = num;
                        break;
                    }
                    
                }
               // otherwise, produce an error message and prompt the player again
               Console.WriteLine("Error: Invalid Input!");
            }

            return new int[length];
        }
        int[] GetValues()
        {
            // Int32.Parse()
            // ^^ that thang turns a string into an integer


            string input = "";

            // makes the player input all of the numbers into their cool awesome array
            for (int i = 0; i < ints.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Input Integer #" + (i + 1));
                    input = Console.ReadLine();
                    Console.WriteLine(); 
                    if (Int32.TryParse(input, out int num))
                    {
                        ints[i] = num;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid Input!");
                    }
                }
            }
            Console.Clear();
            return new int[0];
        }

        int[] PrintArray(int[] array)
        {
            // prints every variable in the array
            Console.WriteLine("Here's the array you made!");
            foreach (int num in ints)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
            Console.Clear();

            return null;
        }

        int PrintSum(int[] array)
        {
            double sumOfAllVariables = 0;

            // for each number in the array, add that number to the sum
            foreach (int num in ints)
            {
                sumOfAllVariables += num;
            }

            // then, print that sum
            Console.WriteLine("The sum of all of the variables in your array is " + sumOfAllVariables + "!");
            Console.ReadKey();
            Console.Clear();
            return 0;
        }

        int[] PrintHighest(int[] array)
        {
            int highestVariable = 0;
            
            // for each variable in the array, give it a score based on how many numbers it's higher than
            // if its score is equal to the amount of variables in the array, it is the highest variable
            foreach (int num in ints)
            {
                int numberScore = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    if (num >= ints[i])
                    {
                        numberScore++;
                    }
                }
                if (numberScore == ints.Length)
                {

                    highestVariable = num;
                    break;
                }
            }

            // print out the highest variable
            Console.WriteLine("The highest variable in your array is " + highestVariable + "!");
            Console.ReadKey();
            Console.Clear();


            return null;
        }

        int[] PrintLowest(int[] array)
        {
            int lowestVariable = 0;

            // this is just the same thing as the highest but instead of comparing if the number is higher, compare if it's lower
            // so i wont worry about commenting here :)
            foreach (int num in ints)
            {
                int numberScore = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    if (num <= ints[i])
                    {
                        numberScore++;
                    }
                }
                if (numberScore == ints.Length)
                {
                    lowestVariable = num;
                    break;
                }
            }

            // all that matters is that this prints out the lowest variable
            Console.WriteLine("And the lowest variable is " + lowestVariable + "!");
            Console.ReadKey();
            Console.Clear();


            return null;
        }

        int[] PrintReverse(int[] array)
        {
            // prints the array in reverse order
            Console.WriteLine("And here it is in reverse order!");
            for (int i = ints.Length - 1; i > -1; i--)
            {
                Console.WriteLine(ints[i]);
            }
            Console.ReadKey();
            Console.Clear();

            return null;
        }

        int[] PrintLowestToHighest(int[] array)
        {
            // array to put all the variables in the other array in
            int[] lowestToHighest = new int[ints.Length];



            // for each variable in the array, give it a score based on how many numbers it's higher than
            // then subtract that score by 1 and put it into the array up there
            foreach (int num in ints)
            {
                int numberScore = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    if (num >= ints[i])
                    {
                        numberScore++;
                    }
                }
                numberScore--;

                // failsafe in case there's a bunch of the same number
                while (lowestToHighest[numberScore] != 0)
                {
                    numberScore--;
                }

                lowestToHighest[numberScore] = num;

            }

            // prints out the array sorted lowest to highest
            Console.WriteLine("And just for fun, here's your array sorted by lowest variable to highest! :3c");
            foreach (int num in lowestToHighest)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
            Console.Clear();
            return null;
        }
    }
}
