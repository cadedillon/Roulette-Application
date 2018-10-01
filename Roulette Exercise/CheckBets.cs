using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Exercise
{
    class CheckBets
    {
        public static string format = "\n\t";
        public static string lineBreak = "---------------------------------------------------------------------------------------";

        public static void Numbers(string zero)
        {
            Console.WriteLine(format + $"The winning number is {zero}!");
            Console.WriteLine(format + "None of the other bets have paid out! Better luck next time!");
            Console.WriteLine(format + lineBreak);
        }

        public static void Numbers(int spinResult)
        {
            Console.WriteLine(format + $"The winning numbers bet is {spinResult}!");
        }

        public static void EvenOdd(int spinResult)
        {
            if (spinResult % 2 != 0)
            {
                Console.WriteLine(format + $"The odd numbers bet has paid out!");
            }
            else if (spinResult % 2 == 0)
            {
                Console.WriteLine(format + $"The even numbers bet has paid out!");
            }
            else return;
        }

        public static void RedBlack(string color)
        {
            if (color == "red")
            {
                Console.WriteLine(format + "The bet on red numbers has paid out!");
            }
            else if (color == "black")
            {
                Console.WriteLine(format + "The bet on black numbers has paid out!");
            }
            else return;
        }

        public static void LowHigh(int spinResult)
        {
            if (spinResult > 0 && spinResult <= 18)
            {
                Console.WriteLine(format + "The low numbers bet has paid out!");
            }
            else if (spinResult > 18)
            {
                Console.WriteLine(format + "The high numbers bet has paid out!");
            }
            else return;
        }

        public static void Dozens(int spinResult)
        {
            if(spinResult <= 12 && spinResult != 0)
            {
                Console.WriteLine(format + "The lower dozens bet has paid out!");
            }
            else if( spinResult > 12 && spinResult <= 24)
            {
                Console.WriteLine(format + "The middle dozens bet has paid out!");
            }
            else if(spinResult > 24)
            {
                Console.WriteLine(format + "The upper dozens bet has paid out!");
            }
            else return;
        }

        public static void Columns(int spinResult)
        {
            int[] columnOne = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] columnTwo = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] columnThree = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

            if (columnOne.Contains(spinResult) == true)
            {
                Console.WriteLine(format + "The column one bet has paid out!");
            }
            else if (columnTwo.Contains(spinResult) == true)
            {
                Console.WriteLine(format + "The column two bet has paid out!");
            }
            else if (columnThree.Contains(spinResult) == true)
            {
                Console.WriteLine(format + "The column three bet has paid out!");
            }
            else return;
        }

        public static void Street(int spinResult)
        {
            int street = (spinResult * 10) / 3;

            if (street <= 10 && street != 0)
            {
                Console.WriteLine(format + "The first street bet 1/2/3 has paid out!");
            }
            else if(street <= 20 && street > 10)
            {
                Console.WriteLine(format + "The second street bet 4/5/6 has paid out!");
            }
            else if (street <= 30 && street > 20)
            {
                Console.WriteLine(format + "The third street bet 7/8/9 has paid out!");
            }
            else if (street <= 40 && street > 30)
            {
                Console.WriteLine(format + "The fourth street bet 10/11/12 has paid out!");
            }
            else if (street <= 50 && street > 40)
            {
                Console.WriteLine(format + "The fifth street bet 13/14/15 has paid out!");
            }
            else if (street <= 60 && street > 50)
            {
                Console.WriteLine(format + "The sixth street bet 16/17/18 has paid out!");
            }
            else if (street <= 70 && street > 60)
            {
                Console.WriteLine(format + "The seventh street bet 19/20/21 has paid out!");
            }
            else if (street <= 80 && street > 70)
            {
                Console.WriteLine(format + "The eigth street bet 22/23/24 has paid out!");
            }
            else if (street <= 90 && street > 80)
            {
                Console.WriteLine(format + "The ninth street bet 25/26/27 has paid out!");
            }
            else if (street <= 100 && street > 90)
            {
                Console.WriteLine(format + "The tenth street bet 28/29/30 has paid out!");
            }
            else if (street <= 110 && street > 100)
            {
                Console.WriteLine(format + "The evelenth street bet 31/32/33 has paid out!");
            }
            else if (street <= 120 && street > 110)
            {
                Console.WriteLine(format + "The twelfth street bet 34/35/36 has paid out!");
            }
        }

        public static void SixNums(int spinResult)
        {
            int row = (spinResult * 10) / 6;

            if (row <= 10 && row != 0)
            {
                Console.WriteLine(format + "The first sixes bet 1/2/3/4/5/6 has paid out!");
            }
            else if (row <= 20 && row > 10)
            {
                Console.WriteLine(format + "The second sixes bet 7/8/9/10/11/12 has paid out!");
            }
            else if (row <= 30 && row > 20)
            {
                Console.WriteLine(format + "The third sixes bet 13/14/15/16/17/18 has paid out!");
            }
            else if (row <= 40 && row > 30)
            {
                Console.WriteLine(format + "The fourth sixes bet 19/20/21/22/23/24 has paid out!");
            }
            else if (row <= 50 && row > 40)
            {
                Console.WriteLine(format + "The fifth sixes bet 25/26/27/28/29/30 has paid out!");
            }
            else if (row <= 60 && row > 50)
            {
                Console.WriteLine(format + "The sixth sixes bet 31/32/33/34/35/36 has paid out!");
            }
            else return;
        }

        public static void Split(int spinResult)
        {
            if(spinResult % 3 == 1 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult + 1}/{spinResult}, and {spinResult + 3}/{spinResult}");
            }
            else if (spinResult % 3 == 1 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 3}/{spinResult}, and {spinResult + 1}/{spinResult}");
            }
            else if(spinResult % 3 == 1)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 3}/{spinResult}, {spinResult + 1}/{spinResult}, and {spinResult + 3}/{spinResult}");
            }
            else if (spinResult % 3 == 2 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 1}/{spinResult}, {spinResult + 1}/{spinResult}, and {spinResult + 3}/{spinResult}");
            }
            else if (spinResult % 3 == 2 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 1}/{spinResult}, {spinResult - 3}/{spinResult}, and {spinResult + 1}/{spinResult}");
            }
            else if (spinResult % 3 == 2)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 1}/{spinResult}, {spinResult - 3}/{spinResult}, {spinResult + 1}/{spinResult}, and {spinResult + 3}/{spinResult}");
            }
            else if (spinResult % 3 == 0 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 1}/{spinResult}, and {spinResult + 3}/{spinResult}");
            }
            else if (spinResult % 3 == 0 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 1}/{spinResult}, and {spinResult - 3}/{spinResult}");
            }
            else if (spinResult % 3 == 0)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 1}/{spinResult}, {spinResult - 3}/{spinResult}, and {spinResult + 3}/{spinResult}");
            }

        }

        public static void Corners(int spinResult)
        {
            if (spinResult % 3 == 1 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning corner bet is: {spinResult}/{spinResult + 1}/{spinResult + 3}/{spinResult + 4}");
            }
            else if (spinResult % 3 == 1 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning corner bet is: {spinResult - 3}/{spinResult - 2}/{spinResult}/{spinResult + 1}");
            }
            else if (spinResult % 3 == 1)
            {
                Console.WriteLine(format + $"The winning corner bets are: {spinResult - 3}/{spinResult - 2}/{spinResult}/{spinResult + 1}, and {spinResult}/{spinResult + 1}/{spinResult + 3}/{spinResult + 4}");
            }
            else if (spinResult % 3 == 2 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning corner bets are: {spinResult - 1}/{spinResult}/{spinResult + 2}/{spinResult + 3}, and {spinResult}/{spinResult + 1}/{spinResult + 3}/{spinResult + 4}");
            }
            else if (spinResult % 3 == 2 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning corner bets are: {spinResult - 4}/{spinResult - 3}/{spinResult - 1}/{spinResult}, and {spinResult - 3}/{spinResult - 2}/{spinResult}/{spinResult + 1}");
            }
            else if (spinResult % 3 == 2)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 4}/{spinResult - 3}/{spinResult - 1}/{spinResult}, {spinResult - 3}/{spinResult - 2}/{spinResult}/{spinResult + 1}, " +
                    $"{spinResult - 1}/{spinResult}/{spinResult + 2}/{spinResult + 3}, and {spinResult}/{spinResult + 1}/{spinResult + 3}/{spinResult + 4},");
            }
            else if (spinResult % 3 == 0 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning corner bet is: {spinResult - 1}/{spinResult}/{spinResult + 2}/{spinResult + 3}");
            }
            else if (spinResult % 3 == 0 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning corner bet is: {spinResult - 4}/{spinResult - 3}/{spinResult - 1}/{spinResult}");
            }
            else if (spinResult % 3 == 0)
            {
                Console.WriteLine(format + $"The winning corner bets are: {spinResult - 4}/{spinResult - 3}/{spinResult - 1}/{spinResult}, and {spinResult - 1}/{spinResult}/{spinResult + 2}/{spinResult + 3}");
            }
        }
    }
}
