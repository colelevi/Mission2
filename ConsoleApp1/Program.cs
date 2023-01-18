using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static string text = "Each \"*\" represents 1% of the total number of rolls.";
        static void Main(string[] args)
        {
            //Get input and intro
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            int rolls = Convert.ToInt32(Console.ReadLine());
            string r = rolls.ToString();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine(text);
            Console.WriteLine("Total number of rolls = " + r + "\n\n");


            
            // Random numbers and list
            Random rnd = new Random();
            List<int> diceList = new List<int>();
            for (int i = 0; i < rolls; i++)
            {
                int dice = rnd.Next(2, 13);
                diceList.Add(dice);
            }

            // find percentages and write lines
            for (int i = 2; i < 13; i++)
            {
                int count = diceList.Where(x => x.Equals(i)).Count();
                decimal pct = 100 * count / rolls;
                string stars = "";
                for (int ii = 0; ii < Math.Round(pct); ii++)
                {
                    stars = stars + "*";
                }
                string num = i.ToString();
                Console.WriteLine(num + ": " + stars);
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
