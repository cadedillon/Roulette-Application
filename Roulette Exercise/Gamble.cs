using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Exercise
{
    class Gamble
    {
        static readonly string format = "\n\t";
        static readonly string lineBreak = "---------------------------------------------------------------------------------------";

        public static void PlaceBet(int currentChips)
        {
            Console.WriteLine(format + "How many chips would you like to bet?");

            int playerBet = int.Parse(Console.ReadLine());
            if (playerBet < 0 || playerBet > currentChips)
            {
                Console.WriteLine(format + "Invalid bet.");
                PlaceBet(currentChips);
            }

            Console.WriteLine(format + "Select the type of bet you would like to place.");
            Console.WriteLine(format + "1. Numbers (Straight) bet. (Number 1 - 36 or 0/00) Returns 35:1.");
            Console.WriteLine(format + "2. Odds/Evens bet. (Odd or Even numbers) Returns 1:1.");
            Console.WriteLine(format + "3. Colors bet. (Red or Black numbers) Returns 1:1.");
            Console.WriteLine(format + "4. Low/High bet. (Numbers 1-18 or 19-36) Returns 1:1.");
            Console.WriteLine(format + "5. Dozens bet. (Set of dozen numbers) Returns 2:1.");
            Console.WriteLine(format + "6. Columns bet. (One vertical column) Returns 2:1.");
            Console.WriteLine(format + "7. Sixes bet. (Set of two rows) Returns 5:1.");
            Console.WriteLine(format + "8. Corners bet. (Contiguous square of 4 numbers) Returns 8:1.");
            Console.WriteLine(format + "9. Street bet. (Contiguous row of 3 numbers) Returns 11:1.");
            Console.WriteLine(format + "10. Split bet. (Contiguous 2 numbers) Returns 17:1.");
            Console.WriteLine(format + lineBreak);

            int playerSelection = int.Parse(Console.ReadLine());

            if (playerSelection < 1 || playerSelection > 10)
            {
                Console.WriteLine(format + "Invalid selection.");
                PlaceBet(currentChips);
            }

            Table.PlayRoulette(currentChips, playerSelection, playerBet);
        }
    }
}
