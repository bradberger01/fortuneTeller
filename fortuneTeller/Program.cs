using System;
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

            if (favColor == "help" || favColor == "help".ToLower() || favColor == "help".ToUpper())
            {
                Console.WriteLine("Red\r\nOrange\r\nYellow\r\nGreen\r\nBlue\r\nIndigo\r\nViolet");
                Console.WriteLine("So, now that you know, enter your favorite color.");

                favColor = (Console.ReadLine());
            }

            Console.WriteLine("Enter the number of siblings you have.");
            int numOfSibs = int.Parse(Console.ReadLine());

            //Giving meaning to all the information the user typed in
            //age = number of years until retirement

            int numOfYears = 0;
            if (age % 2 == 0)
            {
                numOfYears = numOfYears + 20;
            }
            else
            {
                numOfYears = numOfYears + 30;
            }

            // number of siblings will = where you will retire

            string location = null;

            if (numOfSibs == 0)
            {
               location = "Akron";
            }
            else if (numOfSibs == 1)
            {
               location ="Paris";
            }
            else if (numOfSibs == 2)
            {
                location = "the Bahamas";
            }
            else if (numOfSibs >= 3)
            {
                location = "Spain";
            }
            else if(numOfSibs < 0)
            {
                location = "the North Pole";
            }

            // favorite color with = what form of transportation you will have

            string transportation = null;

            if(favColor =="red")
            {
                transportation = "sports car";
            }
            else if(favColor == "orange")
            {
                transportation = "bicycle";
            }
            else if(favColor == "yellow")
            {
               transportation = "unicycle";
            }
            else if(favColor == "green")
            {
                transportation = "racing snail";
            }
            else if(favColor == "blue")
            {
                transportation = "motorcycle";
            }
            else if(favColor == "indigo")
            {
                transportation = "dog sled";
            }
            else
            {
                transportation = "segway";
            }

            // birthmonth will = how much money you will have in the bank

            string amountOfMoney = null;

            if (birthMonth >= 1 && birthMonth < 5 || birthMonth >= 01 && birthMonth < 05)
            {
                amountOfMoney = "$5,000";
            }
            else if (birthMonth >=5  && birthMonth < 9 || birthMonth >= 05 && birthMonth < 09) 
            {
               amountOfMoney = "$10,000";
            }
            else if(birthMonth >= 9 && birthMonth < 13 || birthMonth >= 09 && birthMonth < 13)
            {
                amountOfMoney = "$20,000";
            }
            else
            {
                amountOfMoney = "$0.00";
                
            }

            // Computer write out the follow response based on the user's information

            Console.WriteLine(firstName + " " + lastName + " will retire in " + numOfYears + " with " + amountOfMoney + " in the bank, a vacation home in " + location + " and a " + transportation + ".");
        }
    }
}
