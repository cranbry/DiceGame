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
        public Dice(int sides = 6)
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

        // method using 
        public bool ContainsNumber(int[] trackingTopArr, int number)
        {
            foreach (int side in trackingTopArr)
            {
                if (side == number)
                {
                    return true;
                }
            }
            return false;
        }

        public int[] CreateArrUniqueRolls(int size)
        {
            int[] UniqueRollsArr = new int[size];
            int count = 0;

            while (count < size)
            {
                int roll = Roll();
                bool alreadyExists = false;

                for (int i = 0; i < count; i++)
                {
                    if (UniqueRollsArr[i] == roll)
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (!alreadyExists)
                {
                    UniqueRollsArr[count] = roll;
                    count++;
                }
            }
            return UniqueRollsArr;
        }
    }
}