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

            Console.WriteLine("Hello " + firstName +  ". What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Okay. Now enter your birth month (by number).");
            int birthMonth = int.Parse(Console.ReadLine());

            //Make a formula that gives equates a month to the entered number. Make sure it will work if someone enters 1 or 01.
            // if(birthMonth == 1 || birthMonth == 01) use this later on for part 2

            Console.WriteLine("Using ROYGBIV, enter your favorite color. If you don't know ROYGBIV type in \r\n\"Help\"");
            string favColor = Console.ReadLine();

            if (favColor == "Help")
            {
                Console.WriteLine("Red\r\nOrange\r\nYellow\r\nGreen\r\nBlue\r\nIndigo\r\nViolet")
            }

            
        }
    }
}
