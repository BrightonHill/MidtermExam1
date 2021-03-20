using System;

namespace Monogram
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //Here is where the user inputted info. I used toupper to get all uppercase, trim to get rid of white space.
            
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine("What is your Lastname?");
            string lastname = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine("What is your middle name?");
            string middlename = Console.ReadLine().ToUpper().Trim();

           // I made variables for all the intials. & I used [0] to get the first letter of each input because if i used [1] it really wouldve given me the second letter.
            char firstinit = firstname[0];
            char lastinit = lastname[0];
            char middleinit = middlename[0];

            Console.WriteLine($"Your initials are {firstinit}.{middleinit}.{lastinit}");

            Console.ReadKey();




        }
    }
}
