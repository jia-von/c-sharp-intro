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
        }
    }
}
