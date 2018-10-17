using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    //This class takes the result of the spin 
    //(spinResult, 
    //stringBet(if a user bets 0/00) if applicable,
    //and zeroResult(if the result of the spin is 0/00) if applicable)
    //and calculates which of the bet conditions are true.
    //All methods return winner = true if the user won
    //and return winner = false if user lost
    class CheckBets
    {
        public static string format = "\n\t";
        public static string lineBreak = "---------------------------------------------------------------------------------------";
        

        public static bool Numbers(string zeroResult, string stringBet, int spinResult)
        {
            bool winner;
            if (spinResult == 0)
            {
                Console.WriteLine(format + $"The winning number is {zeroResult}");
                Console.WriteLine(format + $"The winning numbers bet is {zeroResult}!");
            }
            else
            {
                Console.WriteLine(format + $"The winning number is {spinResult}");
                Console.WriteLine(format + $"The winning numbers bet is {spinResult}!");
            }
            if (zeroResult == stringBet)
            {
                winner = true;
            }
            else
            {
                winner = false;
            }
            return winner;
        }

        public static bool Numbers(int spinResult, int playerBet)
        {
            bool winner;
            Console.WriteLine(format + $"The winning number is {spinResult}");
            Console.WriteLine(format + $"The winning numbers bet is {spinResult}!");
            if(spinResult == playerBet)
            {
                winner = true;
            }
            else
            {
                winner = false;
            }

            return winner;
        }

        public static int EvenOdd(int spinResult)
        {
            int winner = 0;
            Console.WriteLine(format + $"The winning number is {spinResult}");
            if (spinResult % 2 != 0)
            {
                winner = 1;
                Console.WriteLine(format + $"The odd numbers bet has paid out!");
                return winner;
            }
            else if (spinResult % 2 == 0)
            {
                winner = 2;
                Console.WriteLine(format + $"The even numbers bet has paid out!");
                return winner;
            }
            else return winner;
            
        }

        public static int RedBlack(string color, int spinResult)
        {
            int winner = 0;
            Console.WriteLine(format + $"The winning number is {spinResult}");
            if (color == "red")
            {
                winner = 1;
                Console.WriteLine(format + "The bet on red numbers has paid out!");
                return winner;
            }
            else if (color == "black")
            {
                winner = 2;
                Console.WriteLine(format + "The bet on black numbers has paid out!");
                return winner;
            }
            else return winner;
        }

        public static int LowHigh(int spinResult)
        {
            int win = 0;
            Console.WriteLine(format + $"The winning number is {spinResult}");
            if (spinResult > 0 && spinResult <= 18)
            {
                Console.WriteLine(format + "The low numbers bet has paid out!");
                return win = 1;
            }
            else if (spinResult > 18)
            {
                Console.WriteLine(format + "The high numbers bet has paid out!");
                return win = 2;
            }
            else return win;
        }

        public static int Dozens(int spinResult)
        {
            int win = 0;
            Console.WriteLine(format + $"The winning number is {spinResult}");
            if (spinResult <= 12 && spinResult != 0)
            {
                Console.WriteLine(format + "The lower dozens bet has paid out!");
                return win = 1;
            }
            else if( spinResult > 12 && spinResult <= 24)
            {
                Console.WriteLine(format + "The middle dozens bet has paid out!");
                return win = 2;
            }
            else if(spinResult > 24)
            {
                Console.WriteLine(format + "The upper dozens bet has paid out!");
                return win = 3;
            }
            else return win;
        }

        public static int Columns(int spinResult)
        {
            int win = 0;
            int[] columnOne = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] columnTwo = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] columnThree = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            Console.WriteLine(format + $"The winning number is {spinResult}");

            if (columnOne.Contains(spinResult) == true)
            {
                Console.WriteLine(format + "The column one bet has paid out!");
                return win = 1;
            }
            else if (columnTwo.Contains(spinResult) == true)
            {
                Console.WriteLine(format + "The column two bet has paid out!");
                return win = 2;
            }
            else if (columnThree.Contains(spinResult) == true)
            {
                Console.WriteLine(format + "The column three bet has paid out!");
                return win = 3;
            }
            else return win;
        }

        public static int SixNums(int spinResult)
        {
            int win = 0;
            int row = (spinResult * 10) / 6;

            Console.WriteLine(format + $"The winning number is {spinResult}");
            if (row <= 10 && row != 0)
            {
                Console.WriteLine(format + "The first sixes bet 1/2/3/4/5/6 has paid out!");
                return win = 1;
            }
            else if (row <= 20 && row > 10)
            {
                Console.WriteLine(format + "The second sixes bet 7/8/9/10/11/12 has paid out!");
                return win = 2;
            }
            else if (row <= 30 && row > 20)
            {
                Console.WriteLine(format + "The third sixes bet 13/14/15/16/17/18 has paid out!");
                return win = 3;
            }
            else if (row <= 40 && row > 30)
            {
                Console.WriteLine(format + "The fourth sixes bet 19/20/21/22/23/24 has paid out!");
                return win = 4;
            }
            else if (row <= 50 && row > 40)
            {
                Console.WriteLine(format + "The fifth sixes bet 25/26/27/28/29/30 has paid out!");
                return win = 5;
            }
            else if (row <= 60 && row > 50)
            {
                Console.WriteLine(format + "The sixth sixes bet 31/32/33/34/35/36 has paid out!");
                return win = 6;
            }
            else return win;
        }

        public static int[] Corners(int spinResult)
        {
            int[] results;

            Console.WriteLine(format + $"The winning number is {spinResult}");
            if (spinResult % 3 == 1 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning corner bet is: {spinResult}/{spinResult + 1}/{spinResult + 3}/{spinResult + 4}");
                results = new int[] { spinResult, spinResult + 1, spinResult + 3, spinResult + 4 };
                return results;
            }
            else if (spinResult % 3 == 1 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning corner bet is: {spinResult - 3}/{spinResult - 2}/{spinResult}/{spinResult + 1}");
                results = new int[] { spinResult - 3, spinResult - 2, spinResult, spinResult + 1 };
                return results;
            }
            else if (spinResult % 3 == 1)
            {
                Console.WriteLine(format + $"The winning corner bets are: {spinResult - 3}/{spinResult - 2}/{spinResult}/{spinResult + 1}, and {spinResult}/{spinResult + 1}/{spinResult + 3}/{spinResult + 4}");
                results = new int[] { spinResult - 3, spinResult - 2, spinResult, spinResult + 1, spinResult + 3, spinResult + 4 };
                return results;
            }
            else if (spinResult % 3 == 2 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning corner bets are: {spinResult - 1}/{spinResult}/{spinResult + 2}/{spinResult + 3}, and {spinResult}/{spinResult + 1}/{spinResult + 3}/{spinResult + 4}");
                results = new int[] { spinResult - 1, spinResult, spinResult + 1, spinResult + 2, spinResult + 3, spinResult + 4 };
                return results;
            }
            else if (spinResult % 3 == 2 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning corner bets are: {spinResult - 4}/{spinResult - 3}/{spinResult - 1}/{spinResult}, and {spinResult - 3}/{spinResult - 2}/{spinResult}/{spinResult + 1}");
                results = new int[] { spinResult - 4, spinResult - 3, spinResult - 2, spinResult - 1, spinResult, spinResult + 1 };
                return results;
            }
            else if (spinResult % 3 == 2)
            {
                Console.WriteLine(format + $"The winning corner bets are: {spinResult - 4}/{spinResult - 3}/{spinResult - 1}/{spinResult}, {spinResult - 3}/{spinResult - 2}/{spinResult}/{spinResult + 1}, " +
                    $"{spinResult - 1}/{spinResult}/{spinResult + 2}/{spinResult + 3}, and {spinResult}/{spinResult + 1}/{spinResult + 3}/{spinResult + 4}");
                results = new int[] { spinResult - 4, spinResult - 3, spinResult - 2, spinResult - 1, spinResult, spinResult + 1, spinResult + 2, spinResult + 3, spinResult + 4 };
                return results;
            }
            else if (spinResult % 3 == 0 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning corner bet is: {spinResult - 1}/{spinResult}/{spinResult + 2}/{spinResult + 3}");
                results = new int[] { spinResult - 1, spinResult, spinResult + 2, spinResult + 3 };
                return results;
            }
            else if (spinResult % 3 == 0 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning corner bet is: {spinResult - 4}/{spinResult - 3}/{spinResult - 1}/{spinResult}");
                results = new int[] { spinResult - 4, spinResult - 3, spinResult - 1, spinResult };
                return results;
            }
            else if (spinResult % 3 == 0)
            {
                Console.WriteLine(format + $"The winning corner bets are: {spinResult - 4}/{spinResult - 3}/{spinResult - 1}/{spinResult}, and {spinResult - 1}/{spinResult}/{spinResult + 2}/{spinResult + 3}");
                results = new int[] { spinResult - 4, spinResult - 3, spinResult - 1, spinResult, spinResult + 2, spinResult + 3 };
                return results;
            }
            else
            {
                results = new int[0];
            }
            return results;
        }

        public static int[] Street(int spinResult)
        {
            int[] results = new int[3];
            int street = (spinResult * 10) / 3;

            Console.WriteLine(format + $"The winning number is {spinResult}");
            if (street <= 10 && street != 0)
            {
                Console.WriteLine(format + "The first street bet 1/2/3 has paid out!");
                results = new int[] { 1, 2, 3 };
                return results;
            }
            else if (street <= 20 && street > 10)
            {
                Console.WriteLine(format + "The second street bet 4/5/6 has paid out!");
                results = new int[] { 4, 5, 6 };
                return results;
            }
            else if (street <= 30 && street > 20)
            {
                Console.WriteLine(format + "The third street bet 7/8/9 has paid out!");
                results = new int[] { 7, 8, 9 };
                return results;
            }
            else if (street <= 40 && street > 30)
            {
                Console.WriteLine(format + "The fourth street bet 10/11/12 has paid out!");
                results = new int[] { 10, 11, 12 };
                return results;
            }
            else if (street <= 50 && street > 40)
            {
                Console.WriteLine(format + "The fifth street bet 13/14/15 has paid out!");
                results = new int[] { 13, 14, 15 };
                return results;
            }
            else if (street <= 60 && street > 50)
            {
                Console.WriteLine(format + "The sixth street bet 16/17/18 has paid out!");
                results = new int[] { 16, 17, 18 };
                return results;
            }
            else if (street <= 70 && street > 60)
            {
                Console.WriteLine(format + "The seventh street bet 19/20/21 has paid out!");
                results = new int[] { 19, 20, 21 };
                return results;
            }
            else if (street <= 80 && street > 70)
            {
                Console.WriteLine(format + "The eigth street bet 22/23/24 has paid out!");
                results = new int[] { 22, 23, 24 };
                return results;
            }
            else if (street <= 90 && street > 80)
            {
                Console.WriteLine(format + "The ninth street bet 25/26/27 has paid out!");
                results = new int[] { 25, 26, 27 };
                return results;
            }
            else if (street <= 100 && street > 90)
            {
                Console.WriteLine(format + "The tenth street bet 28/29/30 has paid out!");
                results = new int[] { 28, 29, 30 };
                return results;
            }
            else if (street <= 110 && street > 100)
            {
                Console.WriteLine(format + "The evelenth street bet 31/32/33 has paid out!");
                results = new int[] { 31, 32, 33 };
                return results;
            }
            else if (street <= 120 && street > 110)
            {
                Console.WriteLine(format + "The twelfth street bet 34/35/36 has paid out!");
                results = new int[] { 34, 35, 36 };
                return results;
            }
            else return results;
        }

        public static int[] Split(int spinResult)
        {
            int[] results;

            Console.WriteLine(format + $"The winning number is {spinResult}");
            if (spinResult % 3 == 1 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult}/{spinResult + 1}, and {spinResult}/{spinResult + 3}");
                results = new int[] { spinResult, spinResult + 1, spinResult + 3 };
                return results;
            }
            else if (spinResult % 3 == 1 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 3}/{spinResult}, and {spinResult}/{spinResult + 1}");
                results = new int[] { spinResult - 3, spinResult, spinResult + 1 };
                return results;
            }
            else if (spinResult % 3 == 1)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 3}/{spinResult}, {spinResult}/{spinResult + 1}, and {spinResult}/{spinResult + 3}");
                results = new int[] { spinResult - 3, spinResult, spinResult + 1, spinResult + 3 };
                return results;
            }
            else if (spinResult % 3 == 2 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 1}/{spinResult}, {spinResult}/{spinResult + 1}, and {spinResult}/{spinResult + 3}");
                results = new int[] { spinResult - 1, spinResult, spinResult + 1, spinResult + 3 };
                return results;
            }
            else if (spinResult % 3 == 2 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 3}/{spinResult}, {spinResult - 1}/{spinResult}, and {spinResult}/{spinResult + 1}");
                results = new int[] { spinResult - 3, spinResult - 1, spinResult, spinResult + 1 };
                return results;
            }
            else if (spinResult % 3 == 2)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 3}/{spinResult}, {spinResult - 1}/{spinResult}, {spinResult}/{spinResult + 1}, and {spinResult}/{spinResult + 3}");
                results = new int[] { spinResult - 3, spinResult - 1, spinResult, spinResult + 1, spinResult + 3 };
                return results;
            }
            else if (spinResult % 3 == 0 && spinResult <= 3)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 1}/{spinResult}, and {spinResult}/{spinResult + 3}");
                results = new int[] { spinResult - 1, spinResult, spinResult + 3 };
                return results;
            }
            else if (spinResult % 3 == 0 && spinResult >= 34)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 3}/{spinResult}, and {spinResult - 1}/{spinResult}");
                results = new int[] { spinResult - 3, spinResult - 1, spinResult };
                return results;
            }
            else if (spinResult % 3 == 0)
            {
                Console.WriteLine(format + $"The winning split bets are: {spinResult - 3}/{spinResult}, {spinResult - 1}/{spinResult}, and {spinResult}/{spinResult + 3}");
                results = new int[] { spinResult - 3, spinResult - 1, spinResult, spinResult, +3 };
                return results;
            }
            else results = new int[0];
            return results;

        }

        
    }
}
