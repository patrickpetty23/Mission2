using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceRoller
    {
        public void RollDice(int numRolls)
        {
            int rolls = numRolls;

            int[] counts = new int[11];

            Random random = new Random();

            for (int i = 0; i < rolls; i++)
            {
                // Roll two six-sided dice
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                int sum = die1 + die2;

                counts[sum - 2]++;
            }

            string output = "";
            string[] temp = new string[11];

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

            Console.Write(output);
        }
    }
}
