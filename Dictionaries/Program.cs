//Brighton Hill
//dictionaries
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionaries
            Dictionary<string, string> foodCaregories = new Dictionary<string, string>();

            foodCaregories.Add("Friuts", "Apple, Strawberries, Orange");
            foodCaregories.Add("Vegetables", "Carrots, Peas, Onions");
            foodCaregories.Add("Meats", "Beef, Chicken, Lamb");
            

            foreach (string key in foodCaregories.Keys)
            {
                Console.WriteLine($"{key}: {foodCaregories[key]}");
            }
            string response = "";
            do
            {
                Console.WriteLine("Would you like to enter");
                Console.WriteLine("1. New Category");
                Console.WriteLine("2. New Food");
                Console.WriteLine("Enter 1 or 2 or any other key to exit."); 
                Console.Write("Please make a selection:");
                
                //Read users selection
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Write("Please enter a new category:");

                    //Read the category entered by the user
                    input = Console.ReadLine();

                    if (!foodCaregories.ContainsKey(input)) //if the dictionary does not contain this new category
                    {
                        //Category does not exist
                        foodCaregories.Add(input, "");
                    }
                    response = "yes";
                }
                else if (input == "2")
                {
                    Console.Write("Please enter a new food:");
                    string newFood = Console.ReadLine();

                    //Convert the keys to an array
                    string[] items = foodCaregories.Keys.ToArray();

                    Console.WriteLine("Which category does it belong to. Pick the number:");

                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}: {items[i]}");
                    }
                    input = Console.ReadLine();
                    int selection = int.Parse(input);
                    string category = items[selection - 1]; //Array is zeor based so we have to move one place to the left
                    string foods = foodCaregories[category];
                    if (!string.IsNullOrWhiteSpace(foods))
                    {
                        foods = foods + ", ";
                    }
                    foods = foods + newFood;
                    foodCaregories[category] = foods;

                    response = "yes";
                }
                
                Console.WriteLine("Do you want to continue? Yes/No:");
                response = Console.ReadLine();
                response = response.Trim().ToLower();

                if (response == "no")
                {
                    foreach (string key in foodCaregories.Keys)
                    {
                        Console.WriteLine($"{key}: {foodCaregories[key]}");
                    }
                }

            } while (response == "yes");

            Console.ReadLine();

        }
    }
}
