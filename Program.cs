using System;

namespace m2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial welcome message and user prompt for the number of dice rolls
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            // Reading and parsing the user's input
            int numberOfRolls = int.Parse(Console.ReadLine());

            // Simulating dice rolls
            DiceRoller dr = new DiceRoller();
            int[] frequencies = dr.RollDice(numberOfRolls);

            // Processing and displaying the results
            for (int i = 2; i <= 12; i++)
            {
                double percentage = (double)frequencies[i] / numberOfRolls * 100;
                Console.Write($"{i}: ");

                // Displaying the frequency of each roll as asterisks
                for (int j = 0; j < (int)percentage; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Closing message
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}