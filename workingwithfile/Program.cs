using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace workingwithwhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //windowsi arvuti 
            string path = @"C:\demo\demo.txt";
            //Read file content
            List<string> lines = File.ReadAllLines(path).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine($"{line} is on the list");
                
            }
            Console.WriteLine("Lets add an item:");
            string userItem = Console.ReadLine();
            
            lines.Add(userItem);
            
            File.WriteAllLines(path,lines);

            List<string> lines1 = File.ReadAllLines(path).ToList();

            foreach (string line in lines1)
            {
                Console.WriteLine($"{line} is on the list");
                
                //on vaja teha kuskile "c kettale kaust", kuhu lisada fail kust andmed võetakse 
                //mac juurkataloog user'si all /users/katlinp....jne.... 
            }
        }
    }
}