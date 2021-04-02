//Brighton Hill
//lists

using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the list to hold the name of the players
            List<string> roster = new List<string>();

            //Add the players to the roster list
            roster.Add("Kelsey Carrington");
            roster.Add("Paige Anderson");
            roster.Add("Paige Johnson");
            roster.Add("Kylee Mclaughlin");
           

            foreach (string player in roster)
            {
                string displayText = string.Format("{0}", player);
               
                Console.WriteLine(displayText);
            }

            
            Console.ReadKey();
        }
    }
}
