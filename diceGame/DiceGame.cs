using System;

namespace DiceGame
{
    public class Dice
    {

        // Fields:
        private int numSides;
        private int currentSide;
        private Random dice;

        // Properties:
        public int CurrentSide
        {
            get
            {
                return currentSide;
            }
        }
        // public int NumberOfSides
        // {
        //     get
        //     {
        //         return numSides;
        //     }
        // }

        // Constructor:
        public Dice(int sides)
        {
            numSides = sides;
            currentSide = 1;
            dice = new Random();
        }

        // public Dice()
        //     : this(6) // Default constructor 6 sides
        // {
        // }

        public int Roll()
        {
            currentSide = dice.Next(1, numSides + 1);
            return currentSide;
        }

    }
}