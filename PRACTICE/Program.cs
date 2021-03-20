using System;

namespace PRACTICE
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many calories do you want to burn?");
            Int32.TryParse(Console.ReadLine(), out int caltoburn);
           // bool goal = Int32.TryParse(input, out int inputasint);

            int minute = 1;
            double calpermin = 3.9;
            
            for (int i = minute; i <= 20 ; i++ )
            {
                Console.WriteLine($"After {i}, you will have burned {i * calpermin}");
            }

    

            Console.ReadKey();

            




        }
    }
}
