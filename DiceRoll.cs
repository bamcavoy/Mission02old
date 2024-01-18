using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission02
{
    internal class DiceRoll
    { 
        // constructor
        public DiceRoll() 
        {
        }

        // roll one die
        public int Roll()
        {
            Random dieRoll = new Random();

            int roll = dieRoll.Next(1, 7);

            return roll;
        }

        // roll 2 dice as many times as specified
        public int[] RollAll(int diceCount)
        {
            // create results array
            int[] rollCounts = new int[13];

            for (int count = 0; count < diceCount; count++)
            {
                DiceRoll die1 = new DiceRoll();
                DiceRoll die2 = new DiceRoll();

                int roll1 = die1.Roll();
                int roll2 = die2.Roll();
                int rollTotal = roll1 + roll2;

                // add to results array
                rollCounts[rollTotal]++;
            }

            // return results array
            return rollCounts;
        }
    }
}
