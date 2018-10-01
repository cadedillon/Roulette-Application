using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Exercise
{
    class Table
    {
        static string format = "\n\t";
        static string lineBreak = "---------------------------------------------------------------------------------------";
        public static void RouletteTable()
        {
            
            Console.WriteLine(format+"You sit down at the sole Roulette table in the large hall.");
            Console.WriteLine(format + "The ambience draws you in, you hear jazz music somewhere in the distance.");
            Console.WriteLine(format + "The dealer, a blonde man of about 23, turns to face you.");
            Console.WriteLine(format + "'Welcome! Place your bet and spin the wheel.'");
            Console.WriteLine(format + "(You can't actually place a bet, I haven't implemented that.. yet. Just press any key.");
            Console.WriteLine(format + lineBreak);
            Console.ReadLine();
            PlayRoulette();

           
        }

        public static void PlayRoulette()
        {
            RouletteWheel cadesWheel = new RouletteWheel();
            int[] coordinates = cadesWheel.GetCoords();
            int xCoord = coordinates[0];
            int spinResult = cadesWheel.SpinWheel(coordinates);

            if (spinResult == 0)
            {
                string zero = cadesWheel.CheckZero(spinResult, coordinates);
                CheckBets.Numbers(zero);
                return;
            }

            string color = cadesWheel.CheckColor(xCoord, spinResult);

            CheckBets.Numbers(spinResult);
            CheckBets.EvenOdd(spinResult);
            CheckBets.RedBlack(color);
            CheckBets.LowHigh(spinResult);
            CheckBets.Dozens(spinResult);
            CheckBets.Columns(spinResult);
            CheckBets.Street(spinResult);
            CheckBets.SixNums(spinResult);
            CheckBets.Split(spinResult);
            CheckBets.Corners(spinResult);

            Console.WriteLine(format + lineBreak);
            Console.WriteLine(format + "Would you like to spin again?");
            Console.WriteLine(format + "Press 1 for Yes and 2 for No");

            int userinput = int.Parse(Console.ReadLine());

            if (userinput == 1)
            {
                Table.PlayRoulette();
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
