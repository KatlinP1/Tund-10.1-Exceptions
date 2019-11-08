using System;

namespace projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arvutame kasutaja vanust funktsiooniga, küsime tema sünniaastat. 
            
            GetAge();

        }
        public static void GetAge()
        {
            int yearOfBirth;
            Console.WriteLine("Hello! Please enter your year of birth.");
            try
            {

                yearOfBirth = int.Parse(Console.ReadLine());
                Console.WriteLine($"You are {2019-yearOfBirth} years old");

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid date format!");
                GetAge();
            }
        }
    }
}