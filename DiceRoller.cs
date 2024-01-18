using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    //this is the actual dice roller functionality
    internal class DiceRoller
    {
        public void RollDice(int numRolls)
        {
            //get the input for the number of rolls
            int rolls = numRolls;

            //create an array to hold a count of each possible sum of two dice
            int[] counts = new int[11];

            //create a new random object
            Random random = new Random();

            //loop to roll two six sided dice
            for (int i = 0; i < rolls; i++)
            {
                // Roll two six-sided dice
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                //add the die together
                int sum = die1 + die2;

                //add the sum to the counts array
                //you have to subtract 2 from the sum because arrays start at position 0 and 
                //the lowest possible combination for two dice is 2, so the positions are offset by 2
                //ie: '2' is at position 0, '3' is at position 1, etc.
                counts[sum - 2]++;
            }

            //initialize variables needed for later
            string output = "";
            string[] temp = new string[11];

            //loop to calculate percentages and add '*' to the output
            for (int i = 0; i < counts.Length; i++)
            {
                double number = counts[i];
                number = ((number / numRolls) * 100);
                for (int j = 0; j < number; j++)
                {
                    temp[i] += "*";
                }
                output += (i + 2) + ": " + temp[i] + "\n\n";
            }

            //write the output to the console
            Console.Write(output);
        }
    }
}
