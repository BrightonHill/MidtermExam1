using System;

namespace TopEarners_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstname = new string[3];
            string[] lastname = new string[3];

            Console.WriteLine("The top 3 earners are: \n\r ");

            for (int i = 0; i <= firstname.Length; i++)
            {
                Console.WriteLine($"salesperson {i + 1} first name: ");
                firstname[i] = Console.ReadLine().Trim();
                Console.WriteLine($"salesperson {i + 1} last name: ");
                lastname[i] = Console.ReadLine().Trim();

            }
            list<double> thisyearearnings = new list<double> ();
            for (int i = 0; <= firstname.Length; i++)
            {
                bool isnumber;
                double earnings;
                do
                {
                    Console.WriteLine($"What is {firstname[i]} {lastname[i]}'s earnings this year? ");
                    isnumber = double.TryParse(Console.ReadLine(), out earnings);

                } while (!isnumber);

                thisyearearnings.add(earnings);
            }
            double sum = 0;
            for (int i = 0; i <= thisyearearnings.count; i++) ;
            {
                sum += thisyearearnings[i];
            }
            Console.WriteLine($"Average earnings between these three salepeople is {sum/3:c2}");
            Console.ReadKey();



        }

    }
}
