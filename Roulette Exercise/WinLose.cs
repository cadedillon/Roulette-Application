using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    //The WinLose class gives the user all of the available betting options for the type of bet they have selected
    //Then it takes the user's bet and checks it aginst the win conditions of the bet type (by passing it to the CheckBets class)
    //If the user has won, the method returns true, if the user has lost it returns false

    //In summary, WinLose works together with CheckBets to determine:
    // 1. What the user bet is
    // 2. What the win conditions for bet type are based on the spinResult
    // 3. If the user bet matches those win conditions
    class WinLose
    {
        static readonly string format = "\n\t";
        
        public static bool NumberResult(string zeroResult, int spinResult)
        {
            Console.WriteLine(format + "You have selected the numbers bet.");
            Console.WriteLine(format + "What number would you like to bet on?");
            string stringBet = Console.ReadLine();
            
            if (stringBet == "0" || stringBet == "00")
            {
                if (CheckBets.Numbers(zeroResult, stringBet, spinResult) == true)
                {
                    return true;

                }

                else return false;
                
            }

            else
            {
                int numberBet = int.Parse(stringBet);
                if(numberBet < 1 || numberBet > 36)
                {
                    Console.WriteLine(format + "Invalid bet placed");
                    NumberResult(zeroResult, spinResult);
                }

                if (CheckBets.Numbers(spinResult, numberBet) == true)
                {
                    return true;
                }

                else return false;
            }
        }

        public static bool EvenOddResult(int spinResult)
        {
            Console.WriteLine(format + "You have selected the Even/Odd bet.");
            Console.WriteLine(format + "Would you like to bet even or odd?");
            Console.WriteLine(format + "Press 1 for odd and 2 for even.");
            int evenOddSelect = int.Parse(Console.ReadLine());
            if (evenOddSelect == 1)
            {
                if (CheckBets.EvenOdd(spinResult) == 1)
                {
                    return true;
                }
                else return false;

            }
            else if (evenOddSelect == 2)
            {
                if (CheckBets.EvenOdd(spinResult) == 2)
                {
                    return true;
                }
                else return false;
            }

            else return false;
        }

        public static bool ColorResult(string color, int spinResult)
        {
            Console.WriteLine(format + "You have selected the Colors bet.");
            Console.WriteLine(format + "Would you like to bet red or black?");
            Console.WriteLine(format + "Press 1 for red and 2 for black.");
            int redBlackSelect = int.Parse(Console.ReadLine());

            if (redBlackSelect == 1)
            {
                if (CheckBets.RedBlack(color, spinResult) == 1)
                return true;
                
                else return false;
                
            }
            else if (redBlackSelect == 2)
            {
                if (CheckBets.RedBlack(color, spinResult) == 2)
                return true;
                
                else return false;
            }

            else return false;

        }

        public static bool LowHighResult(int spinResult)
        {
            
            Console.WriteLine(format + "You have selected the Low/High bet.");
            Console.WriteLine(format + "Would you like to bet Low or High?");
            Console.WriteLine(format + "Press 1 for Low and 2 for High.");
            int lowHighSelect = int.Parse(Console.ReadLine());
            if (lowHighSelect == 1)
            {
                if (CheckBets.LowHigh(spinResult) == 1)
                {
                    return true;
                }
                else return false;

            }
            else if (lowHighSelect == 2)
            {
                if (CheckBets.LowHigh(spinResult) == 2)
                {
                    return true;
                }
                else return false;
            }

            else return false;
        }

        public static bool DozensResult(int spinResult)
        {
            Console.WriteLine(format + "You have selected the Dozens bet.");
            Console.WriteLine(format + "Would you like to bet Lower (1-12), Middle (13-24), or Upper (25-36) Dozen?");
            Console.WriteLine(format + "Press 1 for Lower, 2 for Middle, and 3 for Upper.");
            int dozenSelect = int.Parse(Console.ReadLine());
            if (dozenSelect == 1)
            {
                if (CheckBets.Dozens(spinResult) == 1)
                {
                    return true;
                }
                else return false;

            }
            else if (dozenSelect == 2)
            {
                if (CheckBets.Dozens(spinResult) == 2)
                {
                    return true;
                }
                else return false;
            }
            else if (dozenSelect == 3)
            {
                if (CheckBets.Dozens(spinResult) == 3)
                {
                    return true;
                }
                else return false;
            }

            else return false;
        }

        public static bool ColumnResult(int spinResult)
        {
            
            Console.WriteLine(format + "You have selected the Columns (Vertical) bet.");
            Console.WriteLine(format + "Would you like to bet First, Second, or Third Column?");
            Console.WriteLine(format + "Press 1 for First, 2 for Second, and 3 for Third.");
            int columnSelect = int.Parse(Console.ReadLine());
            if (columnSelect == 1)
            {
                if (CheckBets.Columns(spinResult) == 1)
                {
                    return true;
                }
                else return false;

            }
            else if (columnSelect == 2)
            {
                if (CheckBets.Columns(spinResult) == 2)
                {
                    return true;
                }
                else return false;
            }
            else if (columnSelect == 3)
            {
                if (CheckBets.Columns(spinResult) == 3)
                {
                    return true;
                }
                else return false;
            }

            else return false;
        }

        public static bool SixesResult(int spinResult)
        {
            Console.WriteLine(format + "You have selected the Sixes (Set of Two Rows) bet.");
            Console.WriteLine(format + "Would you like to bet First, Second, Third, Fourth, Fifth, or Sixth 'Sixes' Set?");
            Console.WriteLine(format + "Press 1 for First, 2 for Second, 3 for Third, 4 for Fourth, 5 for Fifth, or 6 for Sixth.");
            int sixesSelect = int.Parse(Console.ReadLine());
            if (sixesSelect == 1)
            {
                if (CheckBets.SixNums(spinResult) == 1)
                {
                    return true;
                }
                else return false;

            }
            else if (sixesSelect == 2)
            {
                if (CheckBets.SixNums(spinResult) == 2)
                {
                    return true;
                }
                else return false;
            }
            else if (sixesSelect == 3)
            {
                if (CheckBets.SixNums(spinResult) == 3)
                {
                    return true;
                }
                else return false;
            }
            else if (sixesSelect == 4)
            {
                if (CheckBets.SixNums(spinResult) == 4)
                {
                    return true;
                }
                else return false;
            }
            else if (sixesSelect == 5)
            {
                if (CheckBets.SixNums(spinResult) == 5)
                {
                    return true;
                }
                else return false;
            }
            else if (sixesSelect == 6)
            {
                if (CheckBets.SixNums(spinResult) == 6)
                {
                    return true;
                }
                else return false;
            }

            else return false;
        }

        public static bool CornersResult(int spinResult)
        {
            Console.WriteLine(format + "You have selected the Corners (Contiguous Set of 4) bet.");
            Console.WriteLine(format + "Select a number between 1 and 36 to bet on.");
            int numberBet = int.Parse(Console.ReadLine());
            if (CheckBets.Corners(spinResult).Contains(numberBet) == true)
            {
                return true;
            }
            else return false;
        }

        public static bool StreetResult(int spinResult)
        {
            Console.WriteLine(format + "You have selected the Street (Contiguous Row of 3) bet.");
            Console.WriteLine(format + "Select a number between 1 and 36 to bet on.");
            int numberBet = int.Parse(Console.ReadLine());
            if (CheckBets.Street(spinResult).Contains(numberBet) == true)
            {
                return true;
            }
            else return false;
        }

        public static bool SplitResult(int spinResult)
        {
            Console.WriteLine(format + "You have selected the Split (Contiguous Set of 2) bet.");
            Console.WriteLine(format + "Select a number between 1 and 36 to bet on.");
            int numberBet = int.Parse(Console.ReadLine());
            if (CheckBets.Split(spinResult).Contains(numberBet) == true)
            {
                return true;
            }
            else return false;
        }
    }
}
