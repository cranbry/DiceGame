using System;
using DiceGame;


class Program
{

    static void Main(string[] args)
    {

        // Create two dice
        Dice dice1 = new Dice();
        Dice dice2 = new Dice();

        // Array to track topside for each die after rolls
        int[] topSideDice1 = new int[5];
        int[] topSideDice2 = new int[5];

        int count = 0;

        // Rolling both
        for (int i = 0; i < 5; i++)
        {
            int roll1 = dice1.Roll();
            int roll2 = dice2.Roll();

            // Storing rolls 
            topSideDice1[i] = dice1.Roll();
            topSideDice2[i] = dice2.Roll();

            // Comparing both
            Console.WriteLine($"Dice 1's roll is: {roll1}");
            Console.WriteLine($"Dice 2's roll is: {roll2}");

            // Winner winner chicken dinner
            if (roll1 > roll2)
            {
                Console.WriteLine("Dice 1 wins!");
                count++;
            }
            else if (roll2 > roll1)
            {
                Console.WriteLine("Dice 2 wins!");
                count--;
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
        // Winner with 3 points.
        if (count > 0)
        {
            Console.WriteLine("Dice 1 wins!");
        }
        else if (count < 0)
        {
            Console.WriteLine("Dice 2 wins!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }

        // Testing ContainsNumber and CreateUniqueRollArr

        int number = 5;

        bool NumInDice1 = dice1.ContainsNumber(topSideDice1, number);
        bool NumInDice2 = dice2.ContainsNumber(topSideDice2, number);

        if (NumInDice1)
        {
            Console.WriteLine($"Number {number} is rolled by dice 1");
        }
        if (NumInDice2)
        {
            Console.WriteLine($"Number {number} is rolled by dice 2");
        }
    }
}