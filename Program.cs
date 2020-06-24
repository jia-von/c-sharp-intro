using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two slahes mark the beginning of a single-line comment.
            // We are assigning a string value to a variable.
            string myName = "Jia Von";
            // ';' must be added to end the string
            /* We begin multi-line comments with a forward-slash and asterisk...

            Symbols between values or evaluations are considered "operators."
            Below we are using the addition symbol to concatenate two strings.
            (Concatentation means gluing two strings, or texts, together.)

            ... and we end multi-line comments with an asterisk followed by a forward-slash */
            Console.WriteLine("Hello, " + myName);
            
            //New user input name
            Console.WriteLine("Please enter your name...");
            // Assign variable 'userName' to a value entered by the user.
            string userName = Console.ReadLine();
            // Show the user we collected the name.
            Console.WriteLine("You have entered : "+userName);
            // Instead of traditional concatenation using the addition operator ...
            //We can use string interpolation (placeholders) to embed values in
            // a string!
            //@ link: https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=netcore-3.1
            Console.WriteLine("Hey {0}, you're looking great today!", userName);
        }
    }
}
