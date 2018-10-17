using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    //Class that implements roulette wheel functionality.
    //We instantiate RouletteWheel in the PlayRoulette method
    class RouletteWheel
    {
        //This multidimensional array represents every possible result of a roulette wheel spin
        //Numbers are divided by color as they appear on a real roulette wheel
        //Winning number is selected by randomly generating an x coordinate and a y coordinate and retrieving the number
        //from the array using those coordinates
        readonly int[,] wheel = new int[,]
            {
            { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36, 0 },
            { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35, 00}
            };

        //Struct containing the Random number generator 
        public int[] GetCoords()
        {
            Random randomNumGenerator = new Random();

            int xCoord = randomNumGenerator.Next(0, 2);
            int yCoord = randomNumGenerator.Next(0, 19);

            int[] coordinates = { xCoord, yCoord };

            return coordinates;
        }

        //Method that "Spins" the roulette wheel (takes the random coordinates and uses them to pull a winning number from the array)
        public int SpinWheel(int[] coordinates)
        {
            int xCoord = coordinates[0];
            int yCoord = coordinates[1];

            int spinResult = wheel[xCoord, yCoord];
            return spinResult;
        }
        //Checks the color of the spinResult by checking the value of the x coordinate 
        //Color is important because of the win criteria of a few of the bets
        public string CheckColor(int xCoord, int spinResult)
        {
            string color;
            //If spin result = 0, the spinResult effectively has no relevant color
            //If The xCoordinate is 0, the color is red. If xCoord = 1, the color is black
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
        //This method takes the spin result and the coordinates array
        //as parameters and uses them to determine if the spin result is equal to 0 or 00
        
        //This was a challenge because functionally, the integer data type will not differentiate between 0 and 00
        //So what I had to do was place 0 in one array axis and 00 in the other
        //When a 0 is returned I check the value of the X Coordinate to see which axis the 0 result came from
        //If xCoord = 0 i return a string "0"
        //If xCoord = 1 i return a string "00"
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

