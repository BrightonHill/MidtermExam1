using System;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 100");
            bool isnumber = Int32.TryParse(Console.ReadLine(), out int userguess);

            Random random = new Random();
            //  int randomnumber = random.Next(1, 100); I wanted it to output a random number but how would I decided how low vs how high it would be??
            int randomnumber = 40;
            if (userguess == randomnumber)
            {
                Console.WriteLine("Great guess! that is correct!!");
            }
            if (userguess <= 30 )
            {
                Console.WriteLine("Too low! Guess again");
            }
            if (userguess >= 50)
            {
                Console.WriteLine("Too high, guess again!");
            }
            if (userguess < 40 )
            {
                Console.WriteLine("A little low, but so close");
            }
            if (userguess > 40)
            {
                Console.WriteLine("A little high! guess again!");
            }



        }
    }
}
