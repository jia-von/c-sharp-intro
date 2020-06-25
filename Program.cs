using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // It is a good idea, for user experiece to prompt the user.
            // Guiding the user is great, as it tells them what is expected.
            Console.WriteLine( "Please enter a string:" );
            string userInput = Console.ReadLine(); // Assignement; collecting data

            // We can use "if" statements to check a "condition."
            // If the "if statement" is true, its code block (marked by curly braces {} will execute.)
           if ( userInput.Length > 0)
            {
            Console.WriteLine( "The use entered a value." );
            } // If there is an "else" statement proceeding an "if", it will only execute if the "if statement" was false.
           else
            {
            Console.WriteLine( "The user did not enter a value." ); 
            }    
        }

    }
}

