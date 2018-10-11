using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class RouletteWheel
    {
        readonly int[,] wheel = new int[,]
            {
            { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36, 0 },
            { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35, 00}
            };

        public int[] GetCoords()
        {
            Random ran = new Random();

            int xCoord = ran.Next(0, 2);
            int yCoord = ran.Next(0, 19);

            int[] coordinates = { xCoord, yCoord };

            return coordinates;
        }

        public int SpinWheel(int[] coordinates)
        {
            int xCoord = coordinates[0];
            int yCoord = coordinates[1];

            int spinResult = wheel[xCoord, yCoord];
            return spinResult;
        }

        public string CheckColor(int xCoord, int spinResult)
        {
            string color;
            if (spinResult != 0)
            {
                if (xCoord == 0)
                {
                    color = "red";
                }
                else
                {
                    color = "black";
                }
                return color;
            }
            else return "The winning number is zero, so the color is green but it doesn't matter because nobody will see this.";
        }

        public string CheckZero(int spinResult, int[] coordinates)
        {
            string zero;
            int xCoord = coordinates[0];
            int yCoord = coordinates[1];

            if (spinResult == 0 && xCoord == 0)
            {
                zero = "0";
            }
            else if (spinResult == 0 && xCoord == 1)
            {
                zero = "00";
            }
            else
            {
                zero = "spinResult != 0 || 00";
            }

            return zero;
        }

    }

}

