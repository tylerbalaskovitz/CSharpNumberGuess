using System;

//Namespace
namespace NumberGuesser
{

    //Main class
    class Program{

        //Entry point method
        static void Main(string [] args){

            //setting the app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Tyler Balaskovitz";

            //Change text colr
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app information

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            //Asking the user's name
            Console.WriteLine("What is your name?");

            //Geting the user's input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            int correctNumber = 8;

            //Init guess var
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while (guess != correctNumber){
                string input = Console.ReadLine();

                //parse the String into an int
                guess = Int32.Parse(input);

                //match the guess to the correct number

                if (guess != correctNumber){
                    //change the text color
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Wrong number, please try again");

                Console.ResetColor();

                }
                //Outputting a success message.

            }
        }
    }

    
}