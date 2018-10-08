using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string format = "\n\t";
                Console.WriteLine(format + "Welcome to Cade's Casino! We only have a single Roulette table.");
                Console.WriteLine(format + "Press any key to play Roulette.");
                Console.ReadLine();
                Table.RouletteTable();

                //TODO: Implement a system for checking the total number of the player chips at the end of every spin
                //TODO: Make the program more robust at every place the user must interact with the console
                //TODO: Refactor some of the redundant code?
                //TODO: 
                
            }
            catch (ArgumentException aEx)
            {
                Console.WriteLine("\n\t" + aEx.Message);
            }
            catch (FormatException fEx)
            {
                Console.WriteLine("\n\t" + fEx.Message);
                Table.RouletteTable();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("\n\t" + Ex.Message);
            }
            finally
            {
                Console.WriteLine("\n\t" + "Thanks for gambling at Cade's Casino!");
            }
            
        }
    }
}
