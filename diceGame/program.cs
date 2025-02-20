using System;
using DiceGame;


// Create two dice
Dice dice1 = new Dice();
Dice dice2 = new Dice();

// Rolling both
for (int i = 0; i < 5; i++)
{
    int count = 0;

    int roll1 = dice1.Roll();
    int roll2 = dice2.Roll();

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
    return count;
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

