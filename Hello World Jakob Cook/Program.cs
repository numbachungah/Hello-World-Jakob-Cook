// system m=namespace need to use console class
using System;
// my collection of classes for the project
namespace Hello_World_Jakob_Cook
{  // main class for our program
    class Program
    {
        // the main method is executed when app starts.
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name?");
            // Asks User for first name
            string firstName = Console.ReadLine();
            // Assigns user input to first name variable       
            Console.WriteLine("What is your last name?");
            // Asks the user for last name
            string lastName = Console.ReadLine();
            // assigns input to lastname variable

            // prints a welcome message with first nd last name.
            Console.WriteLine($"Hello, " + firstName + " " + lastName + "!");
        }
    }
}
