﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Computer asks for firstName, lastName, age, birthMonth (as in int), favColor (by ROYGBIV - if usser doesn't know ROYGBIV, offer "help" to explain, numOfSibs

            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + ". What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Okay. Now enter your birth month (by number).");
            int birthMonth = int.Parse(Console.ReadLine());

            //Make a formula that gives equates a month to the entered number. Make sure it will work if someone enters 1 or 01.
            // if(birthMonth == 1 || birthMonth == 01) use this later on for part 2

            Console.WriteLine("Using ROYGBIV, enter your favorite color. If you don't know ROYGBIV type in \r\n\"Help\"");
            string favColor = Console.ReadLine();

            if (favColor == "help")
            {
                Console.WriteLine("Red\r\nOrange\r\nYellow\r\nGreen\r\nBlue\r\nIndigo\r\nViolet");
                Console.WriteLine("So, now that you know, enter your favorite color.");

                favColor = (Console.ReadLine());
            }

            Console.WriteLine("Enter the number of siblings you have.");
            int numOfSibs = int.Parse(Console.ReadLine());

            //Giving meaning to all the information the user typed in

            if (age % 2 == 0)
            {
                Console.WriteLine("You will retire in 20 years.");
            }
            else
            {
                Console.WriteLine("You will retire in 30 years.");
            }

            if (numOfSibs == 0)
            {
                Console.WriteLine("You will have a vacation home in Akron");
            }
            else if (numOfSibs == 1)
            {
                Console.WriteLine("You will have a vacation home in Paris");
            }
            else if (numOfSibs == 2)
            {
                Console.WriteLine("You will have a vacation home in the Bahamas");
            }
            else if (numOfSibs >= 3)
            {
                Console.WriteLine("You will have a vacation home in Spain");
            }
            else if(numOfSibs < 0)
            {
                Console.WriteLine("you will have a vacation home in the North Pole");
            }

            if(favColor =="red")
            {
                Console.WriteLine("You have a sports car as you mode of transportation.");
            }
            else if(favColor == "orange")
            {
                Console.WriteLine("You have a bike as your mode of transportation.");
            }
            else if(favColor == "yellow")
            {
                Console.WriteLine("You have a unicycle as your mode of transportation.");
            }
            else if(favColor == "green")
            {
                Console.WriteLine("You have a horse as your mode of transportation.");
            }
            else if(favColor == "blue")
            {
                Console.WriteLine("You have a motorcycle as your mode of transportation.");
            }
            else if(favColor == "indigo")
            {
                Console.WriteLine("You have a dog sled as your mode of transportation.");
            }
            else
            {
                Console.WriteLine("You have a yaht as your mode of transportation.");
            }

            if (birthMonth >= 1 && birthMonth < 5 || birthMonth >= 01 && birthMonth < 05)
            {
                Console.WriteLine("You will have $5,000 in the bank.");
            }
            else if (birthMonth >=5  && birthMonth < 9 || birthMonth >= 05 && birthMonth < 09) 
            {
                Console.WriteLine("You will have $10,000 in the bank.");
            }
            else if(birthMonth >= 9 && birthMonth < 13 || birthMonth >= 09 && birthMonth < 13)
            {
                Console.WriteLine("You will have $20,000 in the bank.");
            }
            else
            {
                Console.WriteLine("You will have $0.00 in the bank.");
            }
        }
    }
}
