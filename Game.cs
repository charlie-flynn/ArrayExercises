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
     * - - dont do that either that sounds really hard
     */
    internal class Game
    {
        int[] ints = new int[5];
        public void Run()
        {
            
            GetValues();
            PrintArray(ints);
            PrintReverse(ints);
            PrintSum(ints);
            PrintHighest(ints);
            PrintLowest(ints);
        }

        int[] GetValues()
        {
            // Int32.Parse()
            // ^^ that thang turns a string into an integer


            string input = "";

            //
            for (int i = 0; i < ints.Length; i++)
            {
                while (true)
                {
                    // prompt the player to input the integer of the particular box in the array
                    Console.WriteLine("Input Integer #" + (i + 1));
                    input = Console.ReadLine();
                    Console.WriteLine();
                    
                    // if numbers can be parsed, 
                    if (Int32.TryParse(input, out int num))
                    {
                        // set the proper variable in the array to the input and break the loop
                        ints[i] = num;
                        break;
                    }
                    else
                    {
                        // otherwise, produce an error message and prompt the player again
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
            int sumOfAllVariables = 0;

            // for each number in the array, add that number to the sum
            foreach (int num in ints)
            {
                sumOfAllVariables += num;
            }

            // then, print that sum
            Console.WriteLine("Sum of all Variables: " + sumOfAllVariables);
            Console.ReadKey();
            Console.Clear();

            // and return
            return 0;
        }

        int[] PrintHighest(int[] array)
        {
            int highestVariable = 0;
            
            // for each variable in array ints[]
            foreach (int num in ints)
            {
                // give that variable a "score"
                int numberScore = 0;

                // compare that variable to every single variable in the array
                for (int i = 0; i < ints.Length; i++)
                {
                    if (num >= ints[i])
                    {
                        // if it is higher, increase that number's score
                        numberScore++;
                    }
                }
                // if the number is higher than every other number in the array,
                if (numberScore == ints.Length)
                {
                    // declare it as the highest variable, then break out of the loop
                    highestVariable = num;
                    break;
                }
            }

            // print out the highest variable
            Console.WriteLine("Highest Variable: " + highestVariable);
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
            Console.WriteLine("Lowest Variable: " + lowestVariable);
            Console.ReadKey();
            Console.Clear();


            return null;
        }

        int[] PrintReverse(int[] array)
        {

            // for loop, where i is equal to the number of spots in the array - 1
            // and decrements by 1 every cycle
            for (int i = ints.Length - 1; i > -1; i--)
            {
                Console.WriteLine(ints[i]);
            }
            Console.ReadKey();
            Console.Clear();

            return null;
        }
    }
}
