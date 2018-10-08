using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Exercise
{
    class Table
    {
        static readonly string format = "\n\t";
        static readonly string lineBreak = "---------------------------------------------------------------------------------------";

        public static void RouletteTable()
        {
            int initialChips = 500;
            Console.WriteLine(format + "You sit down at the sole Roulette table in the large hall.");
            Console.WriteLine(format + "The ambience draws you in, you hear jazz music somewhere in the distance.");
            Console.WriteLine(format + "The dealer, a blonde man of about 23, turns to face you.");
            Console.WriteLine(format + "'Welcome! Place your bet and spin the wheel.'");
            Console.WriteLine(format + "You start with 500 Chips. The game ends when you have 0 chips, or 1000.");
            Console.WriteLine(format + lineBreak);
            Console.ReadLine();
            Gamble.PlaceBet(initialChips);

           
        }

        public static void PlayRoulette(int chips, int playerSelection, int playerBet)
        {
            RouletteWheel cadesWheel = new RouletteWheel();

            string zeroResult = "";
            int[] coordinates = cadesWheel.GetCoords();

            int xCoord = coordinates[0];
            int spinResult = cadesWheel.SpinWheel(coordinates);

            if (spinResult == 0)
            {
                zeroResult = cadesWheel.CheckZero(spinResult, coordinates);
            }
            else
            {
                zeroResult = null;
            }

            string color = cadesWheel.CheckColor(xCoord, spinResult);
            bool win;
            //Console.WriteLine(format + $"The winning number is {spinResult}");
            switch (playerSelection)
            {
                case 1:
                    win = WinLose.NumberResult(zeroResult, spinResult);
                    if(win == true)
                    {
                        chips = CalculatePayouts.Win(chips, playerBet, 35);
                    }
                    else
                    {
                        chips = CalculatePayouts.Lose(chips, playerBet);
                    }
                    break;

                case 2:
                    win = WinLose.EvenOddResult(spinResult);
                    if(win == true)
                    {
                        chips = CalculatePayouts.Win(chips, playerBet, 1);
                    }
                    else
                    {
                        chips = CalculatePayouts.Lose(chips, playerBet);
                    }
                    break;

                case 3:
                    win = WinLose.ColorResult(color, spinResult);
                    if (win == true)
                    {
                        chips = CalculatePayouts.Win(chips, playerBet, 1);
                    }
                    else
                    {
                        chips = CalculatePayouts.Lose(chips, playerBet);
                    }
                    break;
                case 4:
                    win = WinLose.LowHighResult(spinResult);
                    if (win == true)
                    {
                        chips = CalculatePayouts.Win(chips, playerBet, 1);
                    }
                    else
                    {
                        chips = CalculatePayouts.Lose(chips, playerBet);
                    }
                    break;
                case 5:
                    win = WinLose.DozensResult(spinResult);
                    if (win == true)
                    {
                        chips = CalculatePayouts.Win(chips, playerBet, 2);
                    }
                    else
                    {
                        chips = CalculatePayouts.Lose(chips, playerBet);
                    }
                    break;
               case 6:
                   win = WinLose.ColumnResult(spinResult);
                    if(win == true)
                    {
                        chips = CalculatePayouts.Win(chips, playerBet, 2);
                    }
                    else
                    {
                        chips = CalculatePayouts.Lose(chips, playerBet);
                    }
                    break;
                case 7:
                    win = WinLose.SixesResult(spinResult);
                    if (win == true)
                    {
                        chips = CalculatePayouts.Win(chips, playerBet, 5);
                    }
                    else
                    {
                        chips = CalculatePayouts.Lose(chips, playerBet);
                    }
                    break;
                case 8:
                    win = WinLose.CornersResult(spinResult);
                    if (win == true)
                    {
                        chips = CalculatePayouts.Win(chips, playerBet, 8);
                    }
                    else
                    {
                        chips = CalculatePayouts.Lose(chips, playerBet);
                    }
                    break;
                case 9:
                    win = WinLose.StreetResult(spinResult);
                    if (win == true)
                    {
                        chips = CalculatePayouts.Win(chips, playerBet, 11);
                    }
                    else
                    {
                        chips = CalculatePayouts.Lose(chips, playerBet);
                    }
                        break;
                case 10:
                    win = WinLose.SplitResult(spinResult);
                    if (win == true)
                    {
                        chips = CalculatePayouts.Win(chips, playerBet, 17);
                    }
                    else
                    {
                        chips = CalculatePayouts.Lose(chips, playerBet);
                    }
                    break;
            }
            
            SpinAgain(chips);
            
        }

        
        public static void SpinAgain(int chips)
        {
            Console.WriteLine(format + lineBreak);
            Console.WriteLine(format + "Would you like to spin again?");
            Console.WriteLine(format + "Press 1 for Yes and 2 for No");

            int userinput = int.Parse(Console.ReadLine());

            if (userinput == 1)
            {
                Gamble.PlaceBet(chips);
            }
            else if (userinput == 2)
            {
                return;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
