using System;

namespace Monogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine().ToUpper().Trim();
            string lastname = Console.ReadLine();
        }
    }
}
