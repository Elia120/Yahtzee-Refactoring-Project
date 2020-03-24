using System;

namespace Yahtzee
{
    public class Yahtzee
    {
        protected int[] dice;
        public Yahtzee(int d1, int d2, int d3, int d4, int d5)
        {
            dice = new int[5];
            dice[0] = d1;
            dice[1] = d2;
            dice[2] = d3;
            dice[3] = d4;
            dice[4] = d5;
        }


        //Chance basicly just means, to add all the nubers
        public static int Chance(params int[] dice)
        {
            int total = 0;
            foreach (int die in dice)
            {
                total += die;
            }
            return total;
        }

        public static int Nubers(int Row, params int[] dice)
        {
            int sum = 0;
            foreach (int die in dice)
            {
                if (Row==die)
                {
                    sum += die;
                }
            }
            return sum;
        }
        public static int Multiples(int Row, params int[] dice)
        {
            int[] counts = new int[6];
            foreach (int die in dice)
                counts[die - 1]++;
            for (int i = 0; i < 6; i++)
            {
                if (counts[i] >= Row)
                {
                    if (Row==5)
                    {
                        return 50;
                    }
                    return Chance(dice);
                }
                   
            } 
            return 0;
        }

        public static int Straights(int Row, params int[] dice)
        {
            Array.Sort(dice);
            int temp = 0;
            int amount = 0;
            foreach (int die in dice)
            {
                if (die==temp+1)
                {
                    amount++;
                    temp = die;
                }
                else if (die>temp)
                {
                    if (amount<3)
                    {
                        amount = 1;
                        temp = die;
                    }
                    else
                    {
                        break;
                    }  
                }
            }
            if (amount>=Row)
            {
                return (Row-1) * 10;
            }
            return 0;
        }

        public static int FullHouse(params int[] dice)
        {
            int[] counts = new int[6];
            foreach (int die in dice)
                counts[die - 1]++;
            for (int i = 0; i < 6; i++)
            {
                if (counts[i] >= 3)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (j == i) continue;
                        if (counts[i] >= 2)
                        {
                            return 25;
                        }
                    }
                }
                    
            }
            return 0;
        }
    }
}
