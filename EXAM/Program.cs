//Brighton Hill
//Midterm
//login:

using System;

namespace EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            string Realusername = "Brighton";
                string realpassword = "Brighton20";

           Console.WriteLine("Please enter OUNETID:");
            string Userid = Console.ReadLine();

           Console.WriteLine("Please enter password:");
            string userpass = Console.ReadLine();

            //below i was trying to figure out how to make a loop with !isnumber
           // bool isnumber = false;

            //I couldnt figure out the loop so i used an if statement to at least show whether user and pass were correct or not.
            if (Userid == Realusername && realpassword == userpass)
            {
                Console.WriteLine("Weclome!");
            }
            else
            {
                Console.WriteLine("Incorrect. Please try again");
            }




            Console.ReadKey();


        }
    }
}
