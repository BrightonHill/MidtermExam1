//Brighton Hill
//arrays
using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudent = 0;
            Console.WriteLine("How many names do you want to store?");
            var input = Console.ReadLine();

            string[] firstNames = new string[0];
            string[] lastNames = new string[0];

            if (int.TryParse(input, out numberOfStudent)) 
            {
                Console.WriteLine(numberOfStudent);
               
                firstNames = new string[numberOfStudent];
                lastNames = new string[numberOfStudent];
            }
           
            if (numberOfStudent > 0)
            {
                for (int i = 0; i < numberOfStudent; i++)
                {
                    Console.WriteLine("What is students first name?");
                    string firstName = Console.ReadLine();
                    firstNames[i] = firstName;
                    Console.WriteLine("What is the students last name?");
                    string lastname = Console.ReadLine();
                    lastNames[i] = lastname;
                }
                //Output the name of the students
                for (int j = 0; j < numberOfStudent; j++)
                {
                    string firstName = firstNames[j];
                    string lastName = lastNames[j];
                    int studentId = j + 1;
                    string displayText = string.Format("{0}. {1}, {2}", studentId, lastName, firstName);
                    Console.WriteLine(displayText);//string interpolation
                }
            }
            Console.ReadLine();


        }
    }
}
