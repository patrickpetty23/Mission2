using System;
using Mission2;
internal class Program
{
    private static void Main(string[] args)
    {
        DiceRoller dr = new DiceRoller();

        Console.WriteLine("Welcome to the dice rolling simulator");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        string input = Console.ReadLine();

        int numRolls = int.Parse(input);

        dr.RollDice(numRolls);
    }
}