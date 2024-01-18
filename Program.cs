// Blake McAvoy Section 2
// Mission 02 assignment

using Mission02;

internal class Program
{
    // Main program class
    private static void Main(string[] args)
    {
        // declare variable
        int diceCount = 0;

        // beginning prompts
        System.Console.WriteLine("Welcome to the dice rolling simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        diceCount = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + diceCount + ".\n");

        // instantiate DiceRoll
        DiceRoll diceRoll = new DiceRoll();

        // Store RollAll array results to rollCounts
        int[] rollCounts = diceRoll.RollAll(diceCount);

        // Build histogram for each possible result
        for (int count = 2; count <= 12; count++) 
        {
            int rollPercent = (int)(((double)rollCounts[count] / diceCount) * 100);

            string stars = BuildString(rollPercent);

            System.Console.WriteLine((count) + ": " + stars);
        }

        System.Console.WriteLine("\nThank you for using the dice rolling simulator. Goodbye!");
    }

    // method to add *'s equal to percent
    private static string BuildString(int count)
    {
        string result = "";

        for (int i = 0; i < count; i++)
        {
            result = result + "*";
        }

        return result;
    }
}