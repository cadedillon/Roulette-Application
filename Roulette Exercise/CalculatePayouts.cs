using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    //These two methods are strictly for telling the user that they either won or lost
    //and manipulating the value of chips (the chips variable represents the users current number of chips and are persistent throughout the application)
    //based on the user bet
    class CalculatePayouts
    {
        static readonly string format = "\n\t";
        
        public static int Win(int chips, int playerBet, int multiplier)
        {

            chips += (playerBet * multiplier);
            Console.WriteLine(format + $"Congratulations! You have won! Your new chip count is {chips}.");
            return chips;
        }

        public static int Lose(int chips, int playerBet)
        {
            chips -= playerBet;
            Console.WriteLine(format + $"Too bad! You've lost this round. Your new chip count is {chips}.");
            return chips;
        }
    }
}
