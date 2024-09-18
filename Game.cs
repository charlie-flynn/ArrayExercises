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
            Console.WriteLine("Sum of all Variables: " + sumOfAllVariables);
            Console.ReadKey();
            Console.Clear();


            return 0;
        }

        int[] PrintHighest(int[] array)
        {
            int highestVariable = 0;
            
            foreach (int num in ints)
            {
                int numberScore = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    if (num >= ints[i])
                    {
                        numberScore++;
                    }
                    if (numberScore == ints.Length)
                    {
                        highestVariable = num;
                        break;
                    }
                }
            }
            Console.WriteLine("Highest Variable: " + highestVariable);
            Console.ReadKey();
            Console.Clear();


            return null;
        }

        int[] PrintLowest(int[] array)
        {
            int lowestVariable = 0;

            foreach (int num in ints)
            {
                int numberScore = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    if (num <= ints[i])
                    {
                        numberScore++;
                    }
                    if (numberScore == ints.Length)
                    {
                        lowestVariable = num;
                        break;
                    }
                }
            }

            Console.WriteLine("Lowest Variable: " + lowestVariable);
            Console.ReadKey();
            Console.Clear();


            return null;
        }

        int[] PrintReverse(int[] array)
        {

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
