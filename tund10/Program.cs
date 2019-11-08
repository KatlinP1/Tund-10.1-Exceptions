using System;
using System.Collections.Generic;
using System.Linq;

namespace tund10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name three colors");
            string userInput = Console.ReadLine();

            //komade tühikute eemaldamine ja listi lugemine 
            string[] colors = userInput.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            List<string> colorList = colors.ToList();
            foreach (string color in colorList)
            {
                Console.WriteLine(color);
            }


            //värvi lisamine või eelmadamine
            Console.WriteLine("Add/Remove a color:");
            string userChoice = Console.ReadLine();
            if (userChoice.ToLower() == "add")
            {
                Console.WriteLine("Enter a color you want to add:");
                string userAnswer = Console.ReadLine();
                colorList.Add(userAnswer);
            }
            else if (userChoice.ToLower() == "remove")
            {
                Console.WriteLine("Insert a color you want to remove:");
                string userAnswer = Console.ReadLine();
                colorList.Remove(userAnswer);
            }
            else
            {
                Console.WriteLine("Unknown command");
            }

            foreach (string color in colorList)
            {
                Console.WriteLine(color);
            }

        }
    }
}