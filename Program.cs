using System;
using Mission2;
internal class Program
{
    private static void Main(string[] args)
    {
        //create a new instance of DiceRoller
        DiceRoller dr = new DiceRoller();

        //initial message the user in the console sees
        Console.WriteLine("Welcome to the dice rolling simulator");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        string input = Console.ReadLine();

        //get the number of rolls from the user
        int numRolls = int.Parse(input);

        //call the RollDice method and pass the number of rolls to it
        dr.RollDice(numRolls);

        //goodbye
        Console.Write("Thank you for using the dice throwing simulator. Goodbye!");
    }
}