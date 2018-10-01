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
                
            }
            catch (ArgumentException aEx)
            {
                Console.WriteLine("\n\t" + aEx.Message);
            }
            finally
            {
                Console.WriteLine("\n\t" + "Thanks for gambling at Cade's Casino!");
            }
            
        }
    }
}
