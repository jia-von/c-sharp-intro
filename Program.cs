﻿using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guide the user...
            Console.WriteLine( "Please enter add/subtract/multiply:" );

            //Collect the uer input...
            string userInput;
            while ( ( userInput = Console.ReadLine() ) != "exit" )
            //LOOPS until a user enters "exit" command.
            {
                int firstNum;
                int secondNum;
                int result;
                // Switch statements are similar to if/else.
                switch ( userInput ) //Here we enter the value we want to test
                { // Cases are us testing the above against specific values.
                    case "add":
                        Console.WriteLine( "Enter first number for addition:" );
                        firstNum = Int32.Parse( Console.ReadLine() );
                        Console.WriteLine( "Enter second number for addition:" );
                        secondNum = Int32.Parse( Console.ReadLine() );
                        result = firstNum + secondNum;
                        Console.WriteLine( "{0} + {1} = {2}", firstNum, secondNum, result );
                        break;
                    case "subtract":
                        Console.WriteLine( "Enter first number for subtraction:" );
                        firstNum = Int32.Parse( Console.ReadLine() );
                        Console.WriteLine( "Enter second number for subtraction:" );
                        secondNum = Int32.Parse( Console.ReadLine() );
                        result = firstNum - secondNum;
                        Console.WriteLine( "{0} - {1} = {2}", firstNum, secondNum, result );
                        break;
                    case "multiply":
                        Console.WriteLine( "Enter first number for multiply:" );
                        firstNum = Int32.Parse( Console.ReadLine() );
                        Console.WriteLine( "Enter second number for multiply:" );
                        secondNum = Int32.Parse( Console.ReadLine() );
                        result = firstNum * secondNum;
                        Console.WriteLine( "{0} * {1} = {2}", firstNum, secondNum, result );
                        break;
                    default: 
                        Console.WriteLine( "Unrecognized opertor entered." );
                        break;
                } // End of switch statement.
                Console.WriteLine( "Please enter a new command: add/subtract/multiply/exit." );
            } // End of while statement.
        }
        

    }
}

