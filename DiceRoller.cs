using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2
{
    internal class DiceRoller
    {
        public int[] RollDice(int numberOfRolls)
        {
            int[] rollFrequencies = new int[13]; // Array to store frequencies of roll sums

            Random random = new Random(); // Random number generator for dice rolls

            for (int i = 0; i < numberOfRolls; i++)
            {
                // Roll two dice and sum them up
                int sum = random.Next(1, 7) + random.Next(1, 7);

                // Increment the frequency of the resulting sum
                rollFrequencies[sum]++;
            }

            return rollFrequencies;
        }
    }
}

